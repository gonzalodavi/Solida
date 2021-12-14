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

namespace CapaPresentacion
{
    public partial class FormInfoBanco : Form
    {
        CN_CuentaBancaria objetoBanco = new CN_CuentaBancaria();

        public FormInfoBanco()
        {
            InitializeComponent();
        }

        private void FormInfoBanco_Load(object sender, EventArgs e)
        {
            fechaHoy();
            CargarComboBoxCuentas();
        }

        //Mostrar Mensaje de Confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SOLIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeAviso(string mensaje)
        {
            MessageBox.Show(mensaje, "SOLIDA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SOLIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void fechaHoy()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            dtpFecha1.Value = new DateTime(year, month, 1);
            dtpFecha2.Value = DateTime.Now;
        }

        private void CargarDetalleCtaBco()
        {
            if(cbCtaBancaria.SelectedIndex != -1)
            {
                this.dgvBanco.DataSource = CN_CuentaBancaria.MostrarDetalleBanco(Convert.ToInt32(cbCtaBancaria.SelectedValue));
                this.dgvBanco.Columns[0].Visible = false;
                this.dgvBanco.Columns[8].Visible = false;


                this.dgvBanco.Columns[1].Width = 60;
                this.dgvBanco.Columns[2].Width = 100;
                this.dgvBanco.Columns[3].Width = 40;
                this.dgvBanco.Columns[4].Width = 90;
                this.dgvBanco.Columns[5].Width = 60;
                this.dgvBanco.Columns[6].Width = 60;
                this.dgvBanco.Columns[7].Width = 90;
            }
        }

        private void CargarComboBoxCuentas()
        {
            cbCtaBancaria.DataSource = objetoBanco.CargaCuentasBanco();
            cbCtaBancaria.DisplayMember = "NOMBRE";
            cbCtaBancaria.ValueMember = "ID_BANCO";
            cbCtaBancaria.SelectedIndex = -1;
        }

        private void btnBuscarReg_Click(object sender, EventArgs e)
        {
            if (dtpFecha1.Value <= dtpFecha2.Value)
            {
                CargarDetalleCajaxFecha();
                CargarSaldos();
                CargaSaldoAnterior();
            }
            else
            {
                MensajeError("No se permite que la fecha de inicio sea superior a la fecha final");
            }            
        }

        private void CargaSaldoAnterior()
        {
            if (dgvBanco.Rows.Count > 0)
            {
                try
                {
                    string saldoA = CN_CuentaBancaria.SaldoAnterior(Convert.ToInt32(cbCtaBancaria.SelectedValue), dtpFecha1.Value.ToString("dd/MM/yyyy"));
                    tbSaldoAnterior.Text = saldoA;
                }
                catch (Exception ex)
                {
                    this.MensajeError("No se pudo ejecutar la operacion:\n\n" + ex);
                }
            }
            else
            {
                tbSaldoAnterior.Text = "";
            }
        }

        private void CargarDetalleCajaxFecha()
        {
            if (cbCtaBancaria.SelectedIndex != -1)
            {
                this.dgvBanco.DataSource = CN_CuentaBancaria.MostrarDetalleBancoxFecha(Convert.ToInt32(cbCtaBancaria.SelectedValue), dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
                this.dgvBanco.Columns[0].Visible = false;
                this.dgvBanco.Columns[8].Visible = false;


                this.dgvBanco.Columns[1].Width = 60;
                this.dgvBanco.Columns[2].Width = 100;
                this.dgvBanco.Columns[3].Width = 40;
                this.dgvBanco.Columns[4].Width = 90;
                this.dgvBanco.Columns[5].Width = 60;
                this.dgvBanco.Columns[6].Width = 60;
                this.dgvBanco.Columns[7].Width = 90;
            }            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCtaBancaria_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dgvBanco.Columns.Clear();
            this.tbDebe.Text = ""; 
            this.tbHaber.Text = "";
            this.tbSaldo.Text = "";
            if (dgvBanco.Rows.Count > 0)
            {
                btnImprimir.Enabled = true;
            }
            else
            {
                btnImprimir.Enabled = false;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (cbCtaBancaria.SelectedIndex != -1)
            {
                if(dgvBanco.Rows.Count > 0)
                {
                    if (chekPORFECHA.Checked == true)
                    {
                        ImprimirDetallexFecha();
                    }
                    else
                    {
                        ImprimirDetalleCompleto();
                    }
                }
                else
                {
                    MensajeError("No existen Registros");

                }
            }
            else
            {
                MensajeError("No se seleccionó Cuenta Bancaria");
            }
        }

        private void ImprimirDetalleCompleto()
        {
            FormDetalleBanco form = new FormDetalleBanco();
            form.Id = Convert.ToInt32(cbCtaBancaria.SelectedValue);
            form.ShowDialog();
        }

        private void ImprimirDetallexFecha()
        {
            FormDetalleBancoXFecha form = new FormDetalleBancoXFecha();
            form.Id = Convert.ToInt32(cbCtaBancaria.SelectedValue);
            form.Fecha1 = dtpFecha1.Value;
            form.Fecha2 = dtpFecha2.Value;
            form.ShowDialog();
        }

        private void chekCLASIFICA_CheckedChanged(object sender, EventArgs e)
        {
            if (chekCLASIFICA.Checked == true)
            {
                dgvBanco.ClearSelection();
                lblOPagos.Visible = true;
                lblRecibos.Visible = true;

                foreach (DataGridViewRow MyRow in dgvBanco.Rows)
                {
                    if (Convert.ToDecimal(MyRow.Cells[5].Value) > 0)
                    {
                        MyRow.DefaultCellStyle.BackColor = Color.LightSalmon;
                        MyRow.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
                    }
                    if (Convert.ToDecimal(MyRow.Cells[6].Value) > 0)
                    {
                        MyRow.DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                        MyRow.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
            else
            {
                lblOPagos.Visible = false;
                lblRecibos.Visible = false;
                foreach (DataGridViewRow MyRow in dgvBanco.Rows)
                {
                    MyRow.DefaultCellStyle.BackColor = Color.FromArgb(12, 52, 119);
                    MyRow.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void CargarSaldos()
        {
            if (dgvBanco.Rows.Count > 0)
            {
                try
                {
                    int idbanco = Convert.ToInt32(cbCtaBancaria.SelectedValue);
                    string Ssaldo = CN_CuentaBancaria.TotalImporte(idbanco);
                    string Sdebe = CN_CuentaBancaria.TotalDebe(idbanco);
                    string Shaber = CN_CuentaBancaria.TotalHaber(idbanco);
                    decimal saldo = Convert.ToDecimal(Ssaldo);
                    decimal debe = Convert.ToDecimal(Sdebe);
                    decimal haber = Convert.ToDecimal(Shaber);

                    if ((debe - haber) == saldo)
                    {
                        tbSaldo.Text = saldo.ToString("0.00");
                        tbHaber.Text = haber.ToString("0.00");
                        tbDebe.Text = debe.ToString("0.00");
                    }
                    else
                    {
                        this.MensajeError("Existen Inconsistencias en la cuenta bancaria");
                    }

                }
                catch (Exception ex)
                {
                    this.MensajeError("No se pudo ejecutar la operacion:\n\n" + ex);
                }
            }
            else
            {
                this.MensajeAviso("No Existen Movimientos en la Cuenta Bancaria Seleccionada");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cbCtaBancaria.SelectedIndex != -1)
            {
                chekPORFECHA.Checked = false;
                CargarDetalleCtaBco();
                CargarSaldos();
                tbSaldoAnterior.Text = "";
            }
            else
            {
                MensajeError("No se seleccionó Cuenta Bancaria");
            }            

        }

        private void chekPORFECHA_CheckedChanged(object sender, EventArgs e)
        {
            dgvBanco.Columns.Clear();
            if (chekPORFECHA.Checked == true)
            {
                dtpFecha1.Enabled = true;
                dtpFecha2.Enabled = true;
                btnBuscarReg.Enabled = true;
            }
            else
            {
                dtpFecha1.Enabled = false;
                dtpFecha2.Enabled = false;
                btnBuscarReg.Enabled = false;
            }
        }

        private void dgvBanco_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvBanco.Rows.Count > 0)
            {
                btnImprimir.Enabled = true;
            }
            else
            {
                btnImprimir.Enabled = false;
            }
        }

        private void dgvBanco_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvBanco.Rows.Count > 0)
            {
                btnImprimir.Enabled = true;
            }
            else
            {
                btnImprimir.Enabled = false;
            }
        }
    }
}
