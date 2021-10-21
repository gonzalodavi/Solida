﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaComun.Cache;

namespace CapaPresentacion
{
    public partial class FormNotaDBCR : Form
    {
        CN_CtaCte objeto = new CN_CtaCte();

        public FormNotaDBCR()
        {
            InitializeComponent();
        }

        private void FormNotaDBCR_Load(object sender, EventArgs e)
        {
            //CargarUltimoComprobante();
            CargarComboBoxClientes();
            CargarGrillaNotas();
        }

        private void CargarGrillaNotas()
        {
            this.dgvNotasDBCR.DataSource = CN_NotaCRDB.Mostrar();
            this.dgvNotasDBCR.Columns[0].Visible = false;
            this.dgvNotasDBCR.Columns[3].Visible = false;
            this.dgvNotasDBCR.Columns[5].Visible = false;
            this.dgvNotasDBCR.Columns[7].Visible = false;

            this.dgvNotasDBCR.Columns[1].Width = 80;
            this.dgvNotasDBCR.Columns[2].Width = 50;
            this.dgvNotasDBCR.Columns[6].Width = 70;
            this.dgvNotasDBCR.Columns[8].Width = 70;
        }

        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SOLIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SOLIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void CargarComboBoxClientes()
        {
            cbCliente.DataSource = objeto.CargaClientes();
            cbCliente.DisplayMember = "NOMBRE";
            cbCliente.ValueMember = "DNI";
            cbCliente.Text = "Consumidor Final";
        }

        private void CargarUltimoComprobante()
        {
            //int comprob = 
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabNotasDBCR.SelectedTab = tabNuevaNotasDBCR;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            decimal import = Convert.ToDecimal(tbImporte.Text);
            if (tbImporte.Text == "" || import <= 0)
            {
                MensajeError("Por Favor Ingrese el Importe del Comprobante");
            }
            else
            {
                if (tbNumNota.Text == "")
                {
                    MensajeError("Por Favor Ingrese un Número de Comprobante");
                }
                else
                {
                    if (rbDebito.Checked == false && rbCredito.Checked == false)
                    {
                        MensajeError("Por Favor Seleccione Tipo de Nota");
                    }
                    else
                    {
                        string tipoNota = "";
                        decimal debe=0, haber=0;
                        if(rbCredito.Checked == true)
                        {
                            tipoNota = "CREDITO";
                            haber = Convert.ToDecimal(tbImporte.Text);
                        }
                        else
                        {
                            tipoNota = "DEBITO";
                            debe = Convert.ToDecimal(tbImporte.Text);
                        }
                        try
                        {
                            string rpta = "";

                            DialogResult Opcion;

                            Opcion = MessageBox.Show("Desea Generar Nuevo Comprobante?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (Opcion == DialogResult.OK)
                            {
                                string Estado = "ACTIVO";
                                rpta = CN_NotaCRDB.Insertar(Convert.ToInt32(UserLoginCache.UserId), dtpFechaNota.Value, tbNumNota.Text, cbCliente.SelectedValue.ToString(),Convert.ToDecimal(tbImporte.Text), tbDetalleNota.Text, Estado,tipoNota);

                                if (rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Se Generó con éxito el Comprobante");
                                    rpta = CN_CtaCte.Insertar(cbCliente.SelectedValue.ToString(), dtpFechaNota.Value, tbNumNota.Text, "NOTA DE "+tipoNota, debe, haber, 0, 0, 0, (debe - haber), 0, 0, "N", Estado);
                                    if (rpta.Equals("OK"))
                                    {
                                        this.MensajeOk("Se registro en cuenta corriente");
                                    }
                                    else
                                    {
                                        this.MensajeError(rpta);
                                    }
                                    //ResetRecibo();
                                    //CargarGrillaRecibos();
                                    tabNotasDBCR.SelectedTab = tabListaNotas;
                                }
                                else
                                {
                                    this.MensajeError(rpta);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + ex.StackTrace);
                        }
                    }
                }

            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (dgvNotasDBCR.SelectedRows.Count > 0)
            {
                if (dgvNotasDBCR.CurrentRow.Cells[6].Value.ToString() != "ANULADO")
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("Desea ANULAR el comprobante seleccionado?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        CN_NotaCRDB objetoCN = new CN_NotaCRDB();
                        int idNota = Convert.ToInt32(dgvNotasDBCR.CurrentRow.Cells[0].Value.ToString());
                        string tipoNota = dgvNotasDBCR.CurrentRow.Cells[8].Value.ToString();
                        objetoCN.AnularComprobante(idNota, tipoNota);

                        MessageBox.Show("El Comprobante se ANULÓ CORRECTAMENTE");
                        string rpta = CN_CtaCte.AnularRegistroCtaCte(dgvNotasDBCR.CurrentRow.Cells[2].Value.ToString(), "NOTA DE " + tipoNota);
                        if (rpta.Equals("OK"))
                        {
                            MessageBox.Show("Se QUITO EL REGISTO DE LA CTA CTE");
                        }
                        else
                        {
                            this.MensajeError(rpta);
                        }

                        CargarGrillaNotas();
                    }
                }
                else
                {
                    MensajeError("EL COMPROBANTE SELECCIONADO SE ENCUENTRA ANULADO");
                }

            }
            else
            {
                MessageBox.Show("Por Favor seleccione un comprobante");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvNotasDBCR.SelectedRows.Count > 0)
            {
                FormReporteNotas form = new FormReporteNotas();
                form.IdNota = Convert.ToInt32(this.dgvNotasDBCR.CurrentRow.Cells["ID_NOTA"].Value);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por Favor seleccione un comprobante");
            }
        }
    }
}
