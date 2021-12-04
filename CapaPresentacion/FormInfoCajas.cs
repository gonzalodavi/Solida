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
    }
}
