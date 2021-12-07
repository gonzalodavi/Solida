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
            CargarDetalleCtaBco();
            if(dgvBanco.Rows.Count > 0)
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

                    if ((debe-haber) == saldo)
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
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (cbCtaBancaria.SelectedIndex != -1)
            {
                FormDetalleBanco form = new FormDetalleBanco();
                form.Id = Convert.ToInt32(cbCtaBancaria.SelectedValue);
                form.ShowDialog();
            }
            else
            {
                MensajeError("No se seleccionó Cuenta Bancaria");
            }
        }
    }
}
