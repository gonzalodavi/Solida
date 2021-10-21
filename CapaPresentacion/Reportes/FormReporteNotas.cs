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
    public partial class FormReporteNotas : Form
    {
        private int _IdNota;

        public int IdNota
        {
            get { return _IdNota; }
            set { _IdNota = value; }
        }
        public FormReporteNotas()
        {
            InitializeComponent();
        }

        private void FormReporteNotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.ReporteNotasDBCR' Puede moverla o quitarla según sea necesario.
            this.ReporteNotasDBCRTableAdapter.Fill(this.dsPrincipal.ReporteNotasDBCR, IdNota);

            this.reportViewer1.RefreshReport();
        }
    }
}
