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
    public partial class FormCheques : Form
    {
        private string estado = "";
        public FormCheques()
        {
            InitializeComponent();
        }

        private void FormCheques_Load(object sender, EventArgs e)
        {
            cbEstadoCheques.Text = "ACTIVO";
            CargarGrillaChequesXFecha();
            CantidadYSuma();
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

        private void CantidadYSuma()
        {
            if (dgvCheques.Rows.Count > 0)
            {
                try
                {
                    string total = CN_Cheque.TotalCheques(estado);
                    int cantidad = CN_Cheque.CantidadCheques(estado);
                    tbCantidadCheques.Text = cantidad.ToString();
                    tbTotalCheques.Text = Convert.ToDecimal(total).ToString("0.00");
                }
                catch (Exception ex)
                {
                    MensajeError("No se pudo ejecutar la operacion:\n\n" + ex);
                }
            }
            else
            {
                tbCantidadCheques.Text = "0";
                tbTotalCheques.Text = "0,00";
            }            
        }

        

        private void CargarGrillaChequesXFecha()
        {
            this.dgvCheques.DataSource = CN_Cheque.Mostrar(estado);
            this.dgvCheques.Columns[0].Visible = false;
            this.dgvCheques.Columns[1].Visible = false;
            this.dgvCheques.Columns[2].Visible = false;
            this.dgvCheques.Columns[8].Visible = false;
            this.dgvCheques.Columns[10].Visible = false;

            this.dgvCheques.Columns[3].Width = 80;
            this.dgvCheques.Columns[4].Width = 80;
            this.dgvCheques.Columns[5].Width = 80;
            this.dgvCheques.Columns[6].Width = 90;
            this.dgvCheques.Columns[7].Width = 100;
            this.dgvCheques.Columns[9].Width = 100;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCheques_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void chekCLASIFICA_CheckedChanged(object sender, EventArgs e)
        {
            if (chekCLASIFICA.Checked == true)
            {
                dgvCheques.ClearSelection();
                lblCobrar.Visible = true;
                lblVencer.Visible = true;
                lblVencido.Visible = true;

                foreach (DataGridViewRow MyRow in dgvCheques.Rows)
                {
                    if (Convert.ToDateTime(MyRow.Cells[5].Value) <= DateTime.Now && Convert.ToDateTime(MyRow.Cells[5].Value).AddDays(25) >= DateTime.Now)
                    {
                        MyRow.DefaultCellStyle.BackColor = Color.Green;
                        MyRow.DefaultCellStyle.ForeColor = Color.Gold;
                    }
                    else
                    {
                        if (Convert.ToDateTime(MyRow.Cells[5].Value).AddDays(25) <= DateTime.Now && Convert.ToDateTime(MyRow.Cells[5].Value).AddDays(30) > DateTime.Now)
                        {
                            MyRow.DefaultCellStyle.BackColor = Color.Gold;
                            MyRow.DefaultCellStyle.ForeColor = Color.Maroon;
                        }
                        else
                        {
                            if (Convert.ToDateTime(MyRow.Cells[5].Value).AddDays(30) < DateTime.Now)
                            {
                                MyRow.DefaultCellStyle.BackColor = Color.Orange;
                                MyRow.DefaultCellStyle.ForeColor = Color.Red;
                            }

                        }
                    }
                }
            }
            else
            {
                lblCobrar.Visible = false;
                lblVencer.Visible = false;
                lblVencido.Visible = false;
                foreach (DataGridViewRow MyRow in dgvCheques.Rows)
                {
                    MyRow.DefaultCellStyle.BackColor = Color.FromArgb(12, 52, 119);
                    MyRow.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvCheques.Rows.Count > 0)
            {
                FormListadoCheques form = new FormListadoCheques();
                form.Estado = estado;
                form.ShowDialog();
            }
            else
            {
                MensajeError("No existen Cheques Disponibles");
            }
        }

        private void cbEstadoCheques_SelectedIndexChanged(object sender, EventArgs e)
        {
            chekCLASIFICA.Checked = false;
            if(cbEstadoCheques.Text == "ACTIVO")
            {
                estado = "ACTIVO";
                CargarGrillaChequesXFecha();
                CantidadYSuma();
                lblSubtitulo.Text = "Valores en Cartera Disponibles";
            }
            else
            {
                estado = "PAGADO";
                CargarGrillaChequesXFecha();
                CantidadYSuma();
                lblSubtitulo.Text = "Valores en Cartera Entregados a Proveedores";
            }
        }
    }
}
