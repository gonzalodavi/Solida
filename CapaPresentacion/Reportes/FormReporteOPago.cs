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
    public partial class FormReporteOPago : Form
    {
        private int _IdOPago;

        public int IdOPago
        {
            get { return _IdOPago; }
            set { _IdOPago = value; }
        }
        public FormReporteOPago()
        {
            InitializeComponent();
        }

        private void FormReporteOPago_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.ReporteOPago' Puede moverla o quitarla según sea necesario.
            this.ReporteOPagoTableAdapter.Fill(this.dsPrincipal.ReporteOPago,IdOPago);

            this.reportViewer1.RefreshReport();
        }
    }
}
