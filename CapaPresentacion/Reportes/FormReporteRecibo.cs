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
    public partial class FormReporteRecibo : Form
    {
        private int _IdRecibo;

        public int IdRecibo
        {
            get { return _IdRecibo; }
            set { _IdRecibo = value; }
        }
        public FormReporteRecibo()
        {
            InitializeComponent();
        }

        private void FormReporteRecibo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.ReporteRecibo' Puede moverla o quitarla según sea necesario.
            this.ReporteReciboTableAdapter.Fill(this.dsPrincipal.ReporteRecibo,IdRecibo);

            this.reportViewer1.RefreshReport();
        }
    }
}
