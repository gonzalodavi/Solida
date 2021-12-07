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
    public partial class FormListadoCheques : Form
    {
        private string _Estado;

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
        public FormListadoCheques()
        {
            InitializeComponent();
        }

        private void FormListadoCheques_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.Mostrar_Cheques' Puede moverla o quitarla según sea necesario.
            this.Mostrar_ChequesTableAdapter.Fill(this.dsPrincipal.Mostrar_Cheques,Estado);

            this.reportViewer1.RefreshReport();
        }
    }
}
