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
    public partial class FormReporteProductos : Form
    {
        public FormReporteProductos()
        {
            InitializeComponent();
        }

        private void FormReporteProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.MostrarProductos' Puede moverla o quitarla según sea necesario.
            this.MostrarProductosTableAdapter.Fill(this.dsPrincipal.MostrarProductos);
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.ReporteCompra' Puede moverla o quitarla según sea necesario.

            this.reportViewer1.RefreshReport();
        }
    }
}
