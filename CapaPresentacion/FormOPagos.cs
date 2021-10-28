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
    public partial class FormOPagos : Form
    {
        CN_CtaCte objeto = new CN_CtaCte();
        CN_Recibo objeto1 = new CN_Recibo();

        public FormOPagos()
        {
            InitializeComponent();
        }

        private void FormOPagos_Load(object sender, EventArgs e)
        {
            fechaHoy();
            CargarComboBoxProveedores();
            CargarGrillaOPagos();
            CargaSaldoCtaCte();
            BuscaNumeroOPago();
        }

        private void fechaHoy()
        {
            dtpFechaRecibo.Value = DateTime.Now;
            dtpFecha1.Value = DateTime.Now;
            dtpFecha2.Value = DateTime.Now;
        }

        private void CargarGrillaOPagos()
        {
            if (chekVerAnulados.Checked == false)
            {
                this.dgvOPago.DataSource = CN_Recibo.MostrarOP();
                this.dgvOPago.Columns[0].Visible = false;
                this.dgvOPago.Columns[3].Visible = false;
                this.dgvOPago.Columns[7].Visible = false;

                this.dgvOPago.Columns[1].Width = 80;
                this.dgvOPago.Columns[2].Width = 50;
                this.dgvOPago.Columns[4].Width = 100;
                this.dgvOPago.Columns[5].Width = 100;
                this.dgvOPago.Columns[6].Width = 80;
            }
            else
            {
                this.dgvOPago.DataSource = CN_Recibo.MostrarAnuladosOP();
                this.dgvOPago.Columns[0].Visible = false;
                this.dgvOPago.Columns[3].Visible = false;
                this.dgvOPago.Columns[7].Visible = false;

                this.dgvOPago.Columns[1].Width = 80;
                this.dgvOPago.Columns[2].Width = 50;
                this.dgvOPago.Columns[4].Width = 100;
                this.dgvOPago.Columns[5].Width = 100;
                this.dgvOPago.Columns[6].Width = 80;
            }
        }

        private void ResetRecibo()
        {
            tbBanco.Text = "0,00";
            tbValores.Text = "0,00";
            tbEfectivo.Text = "0,00";
            lblTotalOPago.Text = "0,00";
            tbDetalleOPago.Text = "";
            tbNumOPago.Text = "";
            cbProveedor.SelectedIndex = -1;
        }

        private void BuscaNumeroOPago()
        {
            int numOPago = objeto1.MostrarUltimaOPago();
            tbNumOPago.Text = (numOPago + 1).ToString();
        }

        private void CargarComboBoxProveedores()
        {
            cbProveedor.DataSource = objeto.CargaProveedores();
            cbProveedor.DisplayMember = "NOMBRE";
            cbProveedor.ValueMember = "CUIL_CUIT";           
        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProveedor.Text != "")
            {
                CargaGrillaCtaCte(cbProveedor.SelectedValue.ToString());
                CargaSaldoCtaCte();
            }            
        }


        //Mostrar Mensaje de Confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SOLIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SOLIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void CargaGrillaCtaCte(string cuit)
        {
            this.dgvDetCtaCte.DataSource = CN_CtaCte.MostrarDetalleCtaCteCompletoP(cuit);
        }

        private void CargaSaldoCtaCte()
        {
            CN_CtaCte obsaldo = new CN_CtaCte();

            decimal suma = 0;
            foreach (DataGridViewRow row in dgvDetCtaCte.Rows)
            {
                if (row.Cells["IMPORTE"].Value != null)
                    suma += (Decimal)row.Cells["IMPORTE"].Value;
            }
            decimal saldo = obsaldo.MostrarSaldoP(cbProveedor.SelectedValue.ToString());

            this.lblSaldo.Text = saldo.ToString();
        }


        private void btnNuevaOPago_Click(object sender, EventArgs e)
        {
            tabOrdenPagos.SelectedTab = tabNuevaOPago;
        }

        private void btnAceptaOPago_Click(object sender, EventArgs e)
        {
            if(lblTotalOPago.Text != "")
            {
                decimal totopag = Convert.ToDecimal(lblTotalOPago.Text);
                if (totopag <= 0)
                {
                    MensajeError("Por Favor Ingrese un Importe");
                }
                else
                {
                    if(tbNumOPago.Text == "" || tbNumOPago.Text == "0")
                    {
                        MensajeError("Por Favor Ingrese un Numero de Comprobante");
                    }
                    else
                    {
                        try
                        {
                            Decimal efectivo = 0, valores = 0, banco = 0;
                            if (tbEfectivo.Text != "," && tbEfectivo.Text != "")
                            {
                                efectivo = Convert.ToDecimal(tbEfectivo.Text.ToString());
                            }
                            if (tbValores.Text != "," && tbValores.Text != "")
                            {
                                valores = Convert.ToDecimal(tbValores.Text.ToString());
                            }
                            if (tbBanco.Text != "," && tbBanco.Text != "")
                            {
                                banco = Convert.ToDecimal(tbBanco.Text.ToString());
                            }
                            Decimal Suma = efectivo + valores + banco;

                            lblTotalOPago.Text = Suma.ToString("0.00");

                            string rpta = "";

                            DialogResult Opcion;

                            Opcion = MessageBox.Show("Desea Generar Nuevo Comprobante?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (Opcion == DialogResult.OK)
                            {
                                string Estado = "ACTIVO";
                                rpta = CN_Recibo.InsertarOP(tbNumOPago.Text, dtpFechaRecibo.Value, cbProveedor.SelectedValue.ToString(), Convert.ToInt32(UserLoginCache.UserId), efectivo, valores, banco, Suma, tbDetalleOPago.Text, Estado);
                                decimal debe = Suma, haber = 0;

                                if (rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Se Generó con éxito el Comprobante");
                                    rpta = CN_CtaCte.InsertarP(cbProveedor.SelectedValue.ToString(), dtpFechaRecibo.Value, tbNumOPago.Text, "ORDEN DE PAGO", debe, haber, valores, efectivo, banco, (debe - haber), 0, 0, "N", Estado);
                                    if (rpta.Equals("OK"))
                                    {
                                        this.MensajeOk("Se registro en cuenta corriente");
                                    }
                                    else
                                    {
                                        this.MensajeError(rpta);
                                    }
                                    ResetRecibo();
                                    CargarGrillaOPagos();
                                    tabOrdenPagos.SelectedTab = tabConsultaOPagos;
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
            else
            {
                MensajeError("Por Favor, Ingrese un Importe");
            }            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvOPago.SelectedRows.Count > 0)
            {
                if (dgvOPago.CurrentRow.Cells[7].Value.ToString() != "ANULADO")
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("Desea ANULAR el comprobante seleccionado?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        CN_Recibo objetoCN = new CN_Recibo();
                        int idOPago = Convert.ToInt32(dgvOPago.CurrentRow.Cells[0].Value.ToString());
                        objetoCN.AnularOPago(idOPago);

                        MessageBox.Show("SE ANULÓ CORRECTAMENTE EL RECIBO SELECCIONADO");
                        string rpta = CN_CtaCte.AnularRegistroCtaCteP(dgvOPago.CurrentRow.Cells[2].Value.ToString(), "ORDEN DE PAGO");
                        if (rpta.Equals("OK"))
                        {
                            MessageBox.Show("Se QUITO EL REGISTO DE LA CTA CTE");
                        }
                        else
                        {
                            this.MensajeError(rpta);
                        }
                        CargarGrillaOPagos();
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


        private void btnActualizaLista_Click(object sender, EventArgs e)
        {
            CargarGrillaOPagos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarRegistros();
        }

        private void BuscarRegistros()
        {
            if (chekVerAnulados.Checked == false)
            {
                dgvOPago.DataSource = CN_Recibo.BuscarRegistrosOP(dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
                this.dgvOPago.Columns[0].Visible = false;
            }
            else
            {
                dgvOPago.DataSource = CN_Recibo.BuscarRegistrosAnuladosOP(dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
                this.dgvOPago.Columns[0].Visible = false;
            }
        }

        private void chekVerAnulados_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrillaOPagos();
        }

        private void tbEfectivo_Leave(object sender, EventArgs e)
        {
            Decimal efectivo = 0, valores = 0, banco = 0;
            if (tbEfectivo.Text != "," && tbEfectivo.Text != "")
            {
                efectivo = Convert.ToDecimal(tbEfectivo.Text.ToString());
            }
            if (tbValores.Text != "," && tbValores.Text != "")
            {
                valores = Convert.ToDecimal(tbValores.Text.ToString());
            }
            if (tbBanco.Text != "," && tbBanco.Text != "")
            {
                banco = Convert.ToDecimal(tbBanco.Text.ToString());
            }
            Decimal Suma = efectivo + valores + banco;
            lblTotalOPago.Text = Suma.ToString("0.00");
        }

        private void tbValores_Leave(object sender, EventArgs e)
        {
            Decimal efectivo = 0, valores = 0, banco = 0;
            if (tbEfectivo.Text != "," && tbEfectivo.Text != "")
            {
                efectivo = Convert.ToDecimal(tbEfectivo.Text.ToString());
            }
            if (tbValores.Text != "," && tbValores.Text != "")
            {
                valores = Convert.ToDecimal(tbValores.Text.ToString());
            }
            if (tbBanco.Text != "," && tbBanco.Text != "")
            {
                banco = Convert.ToDecimal(tbBanco.Text.ToString());
            }
            Decimal Suma = efectivo + valores + banco;
            lblTotalOPago.Text = Suma.ToString("0.00");
        }

        private void tbBanco_Leave(object sender, EventArgs e)
        {
            Decimal efectivo = 0, valores = 0, banco = 0;
            if (tbEfectivo.Text != "," && tbEfectivo.Text != "")
            {
                efectivo = Convert.ToDecimal(tbEfectivo.Text.ToString());
            }
            if (tbValores.Text != "," && tbValores.Text != "")
            {
                valores = Convert.ToDecimal(tbValores.Text.ToString());
            }
            if (tbBanco.Text != "," && tbBanco.Text != "")
            {
                banco = Convert.ToDecimal(tbBanco.Text.ToString());
            }
            Decimal Suma = efectivo + valores + banco;
            lblTotalOPago.Text = Suma.ToString("0.00");
        }

        private void tbEfectivo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbValores_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbBanco_KeyPress(object sender, KeyPressEventArgs e)
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


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            /*if (dgvOPago.SelectedRows.Count > 0)
            {
                FormReporteRecibo form = new FormReporteRecibo();
                form.IdRecibo = Convert.ToInt32(this.dgvOPago.CurrentRow.Cells["ID_RECIBO"].Value);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por Favor seleccione un comprobante");
            }*/
        }

        private void tbNumOPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
