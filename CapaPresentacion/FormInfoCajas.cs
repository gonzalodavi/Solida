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
    public partial class FormInfoCajas : Form
    {
        public FormInfoCajas()
        {
            InitializeComponent();
        }

        private void FormInfoCajas_Load(object sender, EventArgs e)
        {
            fechaHoy();
            CargarDetalleCaja();
            CargaSaldos();
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

        private void CargarDetalleCaja()
        {
            this.dgvCaja.DataSource = CN_Caja.MostrarDetalleCaja();
            this.dgvCaja.Columns[0].Visible = false;
            this.dgvCaja.Columns[4].Visible = false;

            this.dgvCaja.Columns[1].Width = 50;
            this.dgvCaja.Columns[2].Width = 90;
            this.dgvCaja.Columns[3].Width = 90;
            this.dgvCaja.Columns[5].Width = 60;
            this.dgvCaja.Columns[6].Width = 60;
            this.dgvCaja.Columns[7].Width = 90;
        }

        private void CargarDetalleCajaxFecha()
        {
            this.dgvCaja.DataSource = CN_Caja.MostrarDetalleCajaxFecha(dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
            this.dgvCaja.Columns[0].Visible = false;
            this.dgvCaja.Columns[4].Visible = false;

            this.dgvCaja.Columns[1].Width = 50;
            this.dgvCaja.Columns[2].Width = 90;
            this.dgvCaja.Columns[3].Width = 90;
            this.dgvCaja.Columns[5].Width = 60;
            this.dgvCaja.Columns[6].Width = 60;
            this.dgvCaja.Columns[7].Width = 90;
        }

        private void CargaSaldoAnterior()
        {
            if (dgvCaja.Rows.Count > 0)
            {
                try
                {
                    string saldoA = CN_Caja.SaldoAnterior(dtpFecha1.Value.ToString("dd/MM/yyyy"));
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

        private void CargaSaldos()
        {
            if (dgvCaja.Rows.Count > 0)
            {
                try
                {
                    string Ssaldo = CN_Caja.TotalImporte();
                    string Sdebe = CN_Caja.TotalDebe();
                    string Shaber = CN_Caja.TotalHaber();
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
                        this.MensajeError("Existen Inconsistencias en EL LIBRO DE CAJA");
                    }

                }
                catch (Exception ex)
                {
                    this.MensajeError("No se pudo ejecutar la operacion:\n\n" + ex);
                }
            }
            else
            {
                this.MensajeAviso("No Existen Movimientos en el LIBRO DE CAJA");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvCaja.Rows.Count > 0)
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

        private void ImprimirDetalleCompleto()
        {
            FormDetalleDeCaja form = new FormDetalleDeCaja();
            form.ShowDialog();
        }

        private void ImprimirDetallexFecha()
        {
            FormDetalleDeCajaXFecha form = new FormDetalleDeCajaXFecha();
            form.Fecha1 = dtpFecha1.Value;
            form.Fecha2 = dtpFecha2.Value;
            form.ShowDialog();
        }

        private void chekCLASIFICA_CheckedChanged(object sender, EventArgs e)
        {
            if (chekCLASIFICA.Checked == true)
            {
                //dgvCaja.ClearSelection();
                lblOPagos.Visible = true;
                lblRecibos.Visible = true;                

                foreach (DataGridViewRow MyRow in dgvCaja.Rows)
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
                foreach (DataGridViewRow MyRow in dgvCaja.Rows)
                {
                    MyRow.DefaultCellStyle.BackColor = Color.FromArgb(12, 52, 119);
                    MyRow.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void chekPORFECHA_CheckedChanged(object sender, EventArgs e)
        {
            dgvCaja.Columns.Clear();
            if(chekPORFECHA.Checked == true)
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            chekPORFECHA.Checked = false;
            CargarDetalleCaja();
            CargaSaldos();
            tbSaldoAnterior.Text = "";
        }

        private void btnBuscarReg_Click(object sender, EventArgs e)
        {
            if (dtpFecha1.Value <= dtpFecha2.Value)
            {
                CargarDetalleCajaxFecha();
                CargaSaldos();
                CargaSaldoAnterior();
            }
            else
            {
                MensajeError("No se permite que la fecha de inicio sea superior a la fecha final");
            }            
        }

        private void dgvCaja_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvCaja.Rows.Count > 0)
            {
                btnImprimir.Enabled = true;
            }
            else
            {
                btnImprimir.Enabled = false;
            }
        }

        private void dgvCaja_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvCaja.Rows.Count > 0)
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
