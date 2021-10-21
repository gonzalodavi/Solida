using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormSesionesUsuario : Form
    {

        CN_Usuarios objetoCN = new CN_Usuarios();

        public FormSesionesUsuario()
        {
            InitializeComponent();
          
        }

        private void MostrarRegistros()
        {
            CN_Usuarios objeto = new CN_Usuarios();
            dgvSesiones.DataSource = objeto.MostrarSesiones();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSesionesUsuario_Load(object sender, EventArgs e)
        {
            MostrarRegistros();
        }
    }
}
