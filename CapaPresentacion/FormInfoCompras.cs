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
        

        public FormInfoCompras()
        {
            InitializeComponent();
        }
        private void FormInfoCompras_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
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

        
    }
}
