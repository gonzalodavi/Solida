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
    public partial class FormDetalleDeCaja : Form
    {
        public FormDetalleDeCaja()
        {
            InitializeComponent();
        }

        private void FormDetalleDeCaja_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.InformeDetalleCaja' Puede moverla o quitarla según sea necesario.
            this.InformeDetalleCajaTableAdapter.Fill(this.dsPrincipal.InformeDetalleCaja);

            this.reportViewer1.RefreshReport();
        }
    }
}
