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
    public partial class FormInfoCompras : Form
    {
        private bool SiFecha = false;

        public FormInfoCompras()
        {
            InitializeComponent();
        }
        private void FormInfoCompras_Load(object sender, EventArgs e)
        {
            FechaHoy();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            this.dgvCompras.DataSource = CN_Compras.Mostrar();
            this.dgvCompras.Columns[0].Visible = false;
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

        private void ImprimeInformeTotal()
        {
            DateTime fechaInicial = new DateTime(1753, 1, 1);
            DateTime fehcaFinal = DateTime.Now;

            if (rbCantidad.Checked == true)
            {
                FormTop20ProdCompCant form = new FormTop20ProdCompCant();
                form.FechaInicio = fechaInicial.ToString("dd/MM/yyyy");
                form.FechaFin = fehcaFinal.ToString("dd/MM/yyyy");
                form.ShowDialog();
            }
            if (rbImporte.Checked == true)
            {
                FormTop20ProdCompImporte form = new FormTop20ProdCompImporte();
                form.FechaInicio = fechaInicial.ToString("dd/MM/yyyy");
                form.FechaFin = fehcaFinal.ToString("dd/MM/yyyy");
                form.ShowDialog();
            }
        }

        private void ImprimeInformeEntreFechas()
        {
            if (rbCantidad.Checked == true)
            {
                FormTop20ProdCompCant form = new FormTop20ProdCompCant();
                form.FechaInicio = dtpFecha1.Value.ToString("dd/MM/yyyy");
                form.FechaFin = dtpFecha2.Value.ToString("dd/MM/yyyy");
                form.ShowDialog();
            }
            if (rbImporte.Checked == true)
            {
                FormTop20ProdCompImporte form = new FormTop20ProdCompImporte();
                form.FechaInicio = dtpFecha1.Value.ToString("dd/MM/yyyy");
                form.FechaFin = dtpFecha2.Value.ToString("dd/MM/yyyy");
                form.ShowDialog();
            }
        }

        private void btnBuscarReg_Click(object sender, EventArgs e)
        {
            BuscarRegistros();
        }

        private void BuscarRegistros()
        {
            dgvCompras.DataSource = CN_Compras.BuscarRegistros(dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
            this.dgvCompras.Columns[0].Visible = false;
        }

        private void chekPorFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chekPorFecha.Checked == true)
            {
                dtpFecha1.Enabled = true;
                dtpFecha2.Enabled = true;
                SiFecha = true;
                btnBuscar.Enabled = true;
            }
            else
            {
                dtpFecha1.Enabled = false;
                dtpFecha2.Enabled = false;
                SiFecha = false;
                btnBuscar.Enabled = false;
            }
        }

        private void dgvCompras_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCompras.SelectedRows.Count > 0)
            {
                FormReporteCompra form = new FormReporteCompra();
                form.IdCompra = Convert.ToInt32(this.dgvCompras.CurrentRow.Cells["ID_COMPRA"].Value);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por Favor seleccione un comprobante");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
