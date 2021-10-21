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
    public partial class FormDetalleCtaCteClienteSimple : Form
    {
        private string _Dni;

        public string Dni
        {
            get { return _Dni; }
            set { _Dni = value; }
        }
        public FormDetalleCtaCteClienteSimple()
        {
            InitializeComponent();
        }

        private void FormDetalleCtaCteClienteSimple_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.ReporteSimpleCtaCte' Puede moverla o quitarla según sea necesario.
            this.ReporteSimpleCtaCteTableAdapter.Fill(this.dsPrincipal.ReporteSimpleCtaCte,Dni);
            this.reportViewer1.RefreshReport();
        }
    }
}
