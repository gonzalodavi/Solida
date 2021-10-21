using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormInfoVentas : Form
    {
        public FormInfoVentas()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
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
    }
}
