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
    public partial class FormDetalleCtaCteProveedorSimple : Form
    {
        private string _Cuit;

        public string Cuit
        {
            get { return _Cuit; }
            set { _Cuit = value; }
        }

        public FormDetalleCtaCteProveedorSimple()
        {
            InitializeComponent();
        }

        private void FormDetalleCtaCteProveedorSimple_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.ReporteSimpleCtaCteC' Puede moverla o quitarla según sea necesario.
            this.ReporteSimpleCtaCteCTableAdapter.Fill(this.dsPrincipal.ReporteSimpleCtaCteC, Cuit);

            this.reportViewer1.RefreshReport();
        }
    }
}
