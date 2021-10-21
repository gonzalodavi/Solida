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
    public partial class FormDetalleCCC : Form
    {
        CN_CtaCte objeto = new CN_CtaCte();
        public FormDetalleCCC()
        {
            InitializeComponent();
        }
        private void FormDetalleCCC_Load(object sender, EventArgs e)
        {
            CargarComboBoxClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDetalleCtaCte();            
        }        

        private void CargarDetalleCtaCte()
        {
            if (chekFecha.Checked == true)
            {
                this.dgvDetCtaCte.DataSource = CN_CtaCte.MostrarDetalleCtaCte(cbCliente.SelectedValue.ToString(), dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
                OcultaYAcomodaTabla();
                CargaSaldoCtaCte();
            }
            else
            {
                this.dgvDetCtaCte.DataSource = CN_CtaCte.MostrarDetalleCtaCteCompleto(cbCliente.SelectedValue.ToString());
                OcultaYAcomodaTabla();
                CargaSaldoCtaCte();
            }
        }

        private void OcultaYAcomodaTabla()
        {
            this.dgvDetCtaCte.Columns[0].Width = 60;

            this.dgvDetCtaCte.Columns[1].Width = 30;
            this.dgvDetCtaCte.Columns[2].Width = 80;

            this.dgvDetCtaCte.Columns[3].Width = 50;
            this.dgvDetCtaCte.Columns[4].Width = 50;
            this.dgvDetCtaCte.Columns[5].Width = 70;
        }

        private void CargaSaldoCtaCte()
        {
            
            CN_CtaCte obsaldo = new CN_CtaCte();
            
            decimal suma = 0;
            foreach (DataGridViewRow row in dgvDetCtaCte.Rows)
            {
                if (row.Cells["TOTAL"].Value != null)
                    suma += (Decimal)row.Cells["TOTAL"].Value;
            }
            decimal saldo = obsaldo.MostrarSaldo(cbCliente.SelectedValue.ToString());

            if (saldo != suma)
            {
                if(chekFecha.Checked == true)
                {
                    MessageBox.Show("Existen Comprobantes fuera del rango de fechas");
                }
                else
                {
                    MessageBox.Show("Existe Inconsistencias de sumas iguales en la Cuenta Corriente");
                }
            }

            this.lblSaldo.Text = saldo.ToString();

        }

        private void CargarComboBoxClientes()
        {            
            cbCliente.DataSource = objeto.CargaClientes();
            cbCliente.DisplayMember = "NOMBRE";
            cbCliente.ValueMember = "DNI";
            cbCliente.Text = "Consumidor Final";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chekFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chekFecha.Checked == false)
            {
                dtpFecha1.Enabled = false;
                dtpFecha2.Enabled = false;
            }
            else
            {
                dtpFecha1.Enabled = true;
                dtpFecha2.Enabled = true;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvDetCtaCte.SelectedRows.Count > 0)
            {
                FormDetalleCtaCteClienteSimple form = new FormDetalleCtaCteClienteSimple();
                form.Dni = cbCliente.SelectedValue.ToString();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No existen registros");
            }
        }
    }
}
