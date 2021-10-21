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
    public partial class FormReporteRemito : Form
    {
        private int _IdRemito;

        public int IdRemito
        {
            get { return _IdRemito; }
            set { _IdRemito = value; }
        }

        public FormReporteRemito()
        {
            InitializeComponent();
        }

        private void FormReporteRemito_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.ReporteRemito' Puede moverla o quitarla según sea necesario.
            this.ReporteRemitoTableAdapter.Fill(this.dsPrincipal.ReporteRemito,IdRemito);

            this.reportViewer1.RefreshReport();
        }
    }
}
