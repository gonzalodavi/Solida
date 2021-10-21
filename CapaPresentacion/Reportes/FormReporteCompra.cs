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
    public partial class FormReporteCompra : Form
    {
        private int _IdCompra;
        public int IdCompra
        {
            get { return _IdCompra; }
            set { _IdCompra =value; }
        }

        public FormReporteCompra()
        {
            InitializeComponent();
        }

        private void FormReporteCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.ReporteCompra' Puede moverla o quitarla según sea necesario.
            try
            {
                this.ReporteCompraTableAdapter.Fill(this.dsPrincipal.ReporteCompra, IdCompra);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }

        }
    }
}
