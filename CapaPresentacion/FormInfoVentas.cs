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
    public partial class FormInfoVentas : Form
    {
        private bool SiFecha = false;

        public FormInfoVentas()
        {
            InitializeComponent();
        }

        private void FormInfoVentas_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            FechaHoy();
        }

        private void CargarGrilla()
        {
            this.dgvVentas.DataSource = CN_Ventas.Mostrar();
            this.dgvVentas.Columns[0].Visible = false;
        }

        private void FechaHoy()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            dtpFecha1.Value = new DateTime(year, month, 1);
            dtpFecha2.Value = DateTime.Now;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (SiFecha == true)
            {
                ImprimeInformeEntreFechas();
            }
            else
            {
                ImprimeInformeTotal();
            }            
        }

        private void ImprimeInformeEntreFechas()
        {
            if (rbCantidad.Checked == true)
            {
                FormTop20ProdVendCant form = new FormTop20ProdVendCant();
                form.FechaInicio = dtpFecha1.Value.ToString("dd/MM/yyyy");
                form.FechaFin = dtpFecha2.Value.ToString("dd/MM/yyyy");
                form.ShowDialog();
            }
            if (rbImporte.Checked == true)
            {
                FormTop20ProdVendPrecio form = new FormTop20ProdVendPrecio();
                form.FechaInicio = dtpFecha1.Value.ToString("dd/MM/yyyy");
                form.FechaFin = dtpFecha2.Value.ToString("dd/MM/yyyy");
                form.ShowDialog();
            }
        }

        private void ImprimeInformeTotal()
        {            
            DateTime fechaInicial = new DateTime(1753, 1, 1);
            DateTime fehcaFinal = DateTime.Now;

            if (rbCantidad.Checked == true)
            {
                FormTop20ProdVendCant form = new FormTop20ProdVendCant();
                form.FechaInicio = fechaInicial.ToString("dd/MM/yyyy");
                form.FechaFin = fehcaFinal.ToString("dd/MM/yyyy");
                form.ShowDialog();
            }
            if (rbImporte.Checked == true)
            {
                FormTop20ProdVendPrecio form = new FormTop20ProdVendPrecio();
                form.FechaInicio = fechaInicial.ToString("dd/MM/yyyy");
                form.FechaFin = fehcaFinal.ToString("dd/MM/yyyy");
                form.ShowDialog();
            }
        }

        private void chekPorFecha_CheckedChanged(object sender, EventArgs e)
        {
            if(chekPorFecha.Checked == true)
            {
                dtpFecha1.Enabled = true;
                dtpFecha2.Enabled = true;
                SiFecha = true;
            }
            else
            {
                dtpFecha1.Enabled = false;
                dtpFecha2.Enabled = false;
                SiFecha = false;
            }
        }

        private void btnVerFactura_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                FormReporteVenta form = new FormReporteVenta();
                form.IdVenta = Convert.ToInt32(this.dgvVentas.CurrentRow.Cells["ID_VENTA"].Value);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por Favor seleccione un comprobante");
            }
        }

        private void dgvVentas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow MyRow in dgvVentas.Rows)
            {
                if (MyRow.Cells[5].Value.ToString() == "0")
                {
                    MyRow.Cells[5].Value = "Consumidor Final";
                }
            }
        }
    }
}
