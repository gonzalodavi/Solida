using System;
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
        CN_NotaCRDB objeto1 = new CN_NotaCRDB();

        public FormNotaDBCR()
        {
            InitializeComponent();
        }

        private void FormNotaDBCR_Load(object sender, EventArgs e)
        {
            fechaHoy();
            ObtenerUltimoComprob();
            CargarComboBoxClientes();
            CargarGrillaNotas();
        }

        private void fechaHoy()
        {
            dtpFecha1.Value = DateTime.Now;
            dtpFecha2.Value = DateTime.Now;
            dtpFechaNota.Value = DateTime.Now;
        }

        private void CargarGrillaNotas()
        {
            if (chekVerAnulados.Checked == false)
            {
                this.dgvNotasDBCR.DataSource = CN_NotaCRDB.Mostrar();
                this.dgvNotasDBCR.Columns[0].Visible = false;
                this.dgvNotasDBCR.Columns[3].Visible = false;
                this.dgvNotasDBCR.Columns[5].Visible = false;
                this.dgvNotasDBCR.Columns[7].Visible = false;
                this.dgvNotasDBCR.Columns[1].Width = 50;
                this.dgvNotasDBCR.Columns[2].Width = 30;
                this.dgvNotasDBCR.Columns[4].Width = 100;
                this.dgvNotasDBCR.Columns[6].Width = 50;
                this.dgvNotasDBCR.Columns[8].Width = 70;

            }
            else
            {
                this.dgvNotasDBCR.DataSource = CN_NotaCRDB.MostrarAnuladas();
                this.dgvNotasDBCR.Columns[0].Visible = false;
                this.dgvNotasDBCR.Columns[3].Visible = false;
                this.dgvNotasDBCR.Columns[5].Visible = false;
                this.dgvNotasDBCR.Columns[7].Visible = false;
                this.dgvNotasDBCR.Columns[1].Width = 50;
                this.dgvNotasDBCR.Columns[2].Width = 30;
                this.dgvNotasDBCR.Columns[4].Width = 100;
                this.dgvNotasDBCR.Columns[6].Width = 50;
                this.dgvNotasDBCR.Columns[8].Width = 70;
            }

            
        }

        private void LimpiarCampos()
        {
            tbDetalleNota.Text = "";
            tbImporte.Text = "0,00";
            cbCliente.Text = "Consumidor Final";
            ObtenerUltimoComprob();
            rbCredito.Checked = false;
            rbDebito.Checked = false;
            lblTotalNota.Text = "0,00";
        }

        private void ObtenerUltimoComprob()
        {
            int numNota = objeto1.MostrarUltimaNota();
            tbNumNota.Text = (numNota + 1).ToString();
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabNotasDBCR.SelectedTab = tabNuevaNotasDBCR;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            decimal import = Convert.ToDecimal(lblTotalNota.Text);

            if (import <= 0)
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

                                }
                                else
                                {
                                    this.MensajeError(rpta);
                                }
                            }
                            LimpiarCampos();
                            CargarGrillaNotas();
                            tabNotasDBCR.SelectedTab = tabListaNotas;

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

        private void btnBuscarReg_Click(object sender, EventArgs e)
        {
            BuscarRegistros();
        }

        private void BuscarRegistros()
        {
            if (chekVerAnulados.Checked == false)
            {
                dgvNotasDBCR.DataSource = CN_NotaCRDB.BuscarRegistros(dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
                this.dgvNotasDBCR.Columns[0].Visible = false;
            }
            else
            {
                dgvNotasDBCR.DataSource = CN_NotaCRDB.BuscarRegistrosAnulados(dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
                this.dgvNotasDBCR.Columns[0].Visible = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGrillaNotas();
        }

        private void tbNumNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void chekVerAnulados_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrillaNotas();
        }

        private void tbImporte_Leave(object sender, EventArgs e)
        {
            Decimal suma = 0;
            if (tbImporte.Text != "," && tbImporte.Text != "")
            {
                suma = Convert.ToDecimal(tbImporte.Text.ToString());
            }           
            
            lblTotalNota.Text = suma.ToString("0.00");
        }
    }
}
