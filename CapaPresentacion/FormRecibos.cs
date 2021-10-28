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
    public partial class FormRecibos : Form
    {
        CN_CtaCte objeto = new CN_CtaCte();
        CN_Recibo objeto1 = new CN_Recibo();

        public FormRecibos()
        {
            InitializeComponent();
        }

        private void FormRecibos_Load(object sender, EventArgs e)
        {
            fechaHoy();
            CargarComboBoxClientes();
            CargarGrillaRecibos();
            CargaSaldoCtaCte();
            BuscaNumeroRecibo();
        }
        private void fechaHoy()
        {
            dtpFechaRecibo.Value = DateTime.Now;
            dtpFecha1.Value = DateTime.Now;
            dtpFecha2.Value = DateTime.Now;
        }

        private void BuscaNumeroRecibo()
        {
            int numRecibo = objeto1.MostrarUltimoRecibo();
            tbNumRecibo.Text = (numRecibo + 1).ToString();
        }

        private void CargarComboBoxClientes()
        {
            cbCliente.DataSource = objeto.CargaClientes();
            cbCliente.DisplayMember = "NOMBRE";
            cbCliente.ValueMember = "DNI";
            cbCliente.Text = "Consumidor Final";            
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptaRecibo_Click(object sender, EventArgs e)
        {
            if (lblTotalRecibo.Text != "")
            {
                decimal totrec = Convert.ToDecimal(lblTotalRecibo.Text);
                if (totrec <= 0 || tbNumRecibo.Text == "")
                {
                    MensajeError("Ingrese Importe y numero de Recibo");
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

                        lblTotalRecibo.Text = Suma.ToString("0.00");

                        string rpta = "";

                        DialogResult Opcion;

                        Opcion = MessageBox.Show("Desea Generar Nuevo Comprobante?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (Opcion == DialogResult.OK)
                        {
                            string Estado = "ACTIVO";
                            rpta = CN_Recibo.Insertar(tbNumRecibo.Text, dtpFechaRecibo.Value, cbCliente.SelectedValue.ToString(), Convert.ToInt32(UserLoginCache.UserId), efectivo, valores, banco, Suma, tbDetalleRecibo.Text, Estado);
                            decimal debe = 0, haber = Suma;

                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Generó con éxito el Comprobante");
                                rpta = CN_CtaCte.Insertar(cbCliente.SelectedValue.ToString(), dtpFechaRecibo.Value, tbNumRecibo.Text, "RECIBO DE PAGO", debe, haber, valores, efectivo, banco, (debe - haber), 0, 0, "N", Estado);
                                if (rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Se registro en cuenta corriente");
                                }
                                else
                                {
                                    this.MensajeError(rpta);
                                }
                                ResetRecibo();
                                CargarGrillaRecibos();
                                tabRecibos.SelectedTab = tabConsultaRecibos;
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
            else
            {
                MensajeError("Por Favor Ingrese un Importe");
            }                   
        }

        private void ResetRecibo()
        {
            tbBanco.Text = "0,00";
            tbValores.Text = "0,00";
            tbEfectivo.Text = "0,00";
            lblTotalRecibo.Text = "0,00";
            tbDetalleRecibo.Text = "";
            tbNumRecibo.Text = "";
            cbCliente.Text = "Consumidor Final";
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
            lblTotalRecibo.Text = Suma.ToString("0.00");
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
            lblTotalRecibo.Text = Suma.ToString("0.00");
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
            lblTotalRecibo.Text = Suma.ToString("0.00");
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

        private void btnActualizaLista_Click(object sender, EventArgs e)
        {
            CargarGrillaRecibos();
        }

        private void CargarGrillaRecibos()
        {
            if (chekVerAnulados.Checked == false)
            {
                this.dgvRecibos.DataSource = CN_Recibo.Mostrar();
                this.dgvRecibos.Columns[0].Visible = false;
                this.dgvRecibos.Columns[3].Visible = false;
                this.dgvRecibos.Columns[7].Visible = false;

                this.dgvRecibos.Columns[1].Width = 80;
                this.dgvRecibos.Columns[2].Width = 50;
                this.dgvRecibos.Columns[4].Width = 100;
                this.dgvRecibos.Columns[5].Width = 100;
                this.dgvRecibos.Columns[6].Width = 80;

            }
            else
            {
                this.dgvRecibos.DataSource = CN_Recibo.MostrarAnulados();
                this.dgvRecibos.Columns[0].Visible = false;
                this.dgvRecibos.Columns[3].Visible = false;
                this.dgvRecibos.Columns[7].Visible = false;

                this.dgvRecibos.Columns[1].Width = 80;
                this.dgvRecibos.Columns[2].Width = 50;
                this.dgvRecibos.Columns[4].Width = 100;
                this.dgvRecibos.Columns[5].Width = 100;
                this.dgvRecibos.Columns[6].Width = 80;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRecibos.SelectedRows.Count > 0)
            {
                if (dgvRecibos.CurrentRow.Cells[7].Value.ToString() != "ANULADO")
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("Desea ANULAR el comprobante seleccionado?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        CN_Recibo objetoCN = new CN_Recibo();
                        int idRecibo = Convert.ToInt32(dgvRecibos.CurrentRow.Cells[0].Value.ToString());
                        objetoCN.AnularRecibo(idRecibo);

                        MessageBox.Show("SE ANULÓ CORRECTAMENTE EL RECIBO SELECCIONADO");
                        string rpta = CN_CtaCte.AnularRegistroCtaCte(dgvRecibos.CurrentRow.Cells[2].Value.ToString(), "RECIBO DE PAGO");
                        if (rpta.Equals("OK"))
                        {
                            MessageBox.Show("Se QUITO EL REGISTO DE LA CTA CTE");
                        }
                        else
                        {
                            this.MensajeError(rpta);
                        }
                        CargarGrillaRecibos();
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

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            tabRecibos.SelectedTab = tabNuevoRecibo;
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaGrillaCtaCte(cbCliente.SelectedValue.ToString());
            CargaSaldoCtaCte();
        }

        private void CargaGrillaCtaCte(string dni)
        {
            this.dgvDetCtaCte.DataSource = CN_CtaCte.MostrarDetalleCtaCteCompleto(dni);
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
            decimal saldo = obsaldo.MostrarSaldo(cbCliente.SelectedValue.ToString());

            this.lblSaldo.Text = saldo.ToString();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvRecibos.SelectedRows.Count > 0)
            {
                FormReporteRecibo form = new FormReporteRecibo();
                form.IdRecibo = Convert.ToInt32(this.dgvRecibos.CurrentRow.Cells["ID_RECIBO"].Value);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por Favor seleccione un comprobante");
            }
        }

        private void tbNumRecibo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarRegistros();
        }

        private void BuscarRegistros()
        {
            if (chekVerAnulados.Checked == false)
            {
                dgvRecibos.DataSource = CN_Recibo.BuscarRegistros(dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
                this.dgvRecibos.Columns[0].Visible = false;
            }
            else
            {
                dgvRecibos.DataSource = CN_Recibo.BuscarRegistrosAnulados(dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
                this.dgvRecibos.Columns[0].Visible = false;
            }
        }

        private void chekVerAnulados_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrillaRecibos();
        }
    }
}
