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
    public partial class FormDetalleBanco : Form
    {
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public FormDetalleBanco()
        {
            InitializeComponent();
        }

        private void FormDetalleBanco_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.InformeDetalleBanco' Puede moverla o quitarla según sea necesario.
            this.InformeDetalleBancoTableAdapter.Fill(this.dsPrincipal.InformeDetalleBanco,Id);

            this.reportViewer1.RefreshReport();
        }
    }
}
