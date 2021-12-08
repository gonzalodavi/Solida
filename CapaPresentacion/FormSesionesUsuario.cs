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
        private void FormSesionesUsuario_Load(object sender, EventArgs e)
        {
            fechaHoy();
            MostrarRegistros();
        }

        private void fechaHoy()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            dtpFecha1.Value = new DateTime(year, month, 1);
            dtpFecha2.Value = DateTime.Now;
        }


        private void MostrarRegistros()
        {
            CN_Usuarios objeto = new CN_Usuarios();
            dgvSesiones.DataSource = objeto.MostrarSesiones();
        }

        private void BuscarRegistros()
        {
            CN_Usuarios objeto = new CN_Usuarios();
            dgvSesiones.DataSource = objeto.BuscarSesiones(dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
        }

        
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chekXFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chekXFecha.Checked == true)
            {
                dtpFecha1.Enabled = true;
                dtpFecha2.Enabled = true;
                btnBuscarReg.Enabled = true;
            }
            else
            {
                dtpFecha1.Enabled = false;
                dtpFecha2.Enabled = false;
                btnBuscarReg.Enabled = false;
            }
        }

        private void btnBuscarReg_Click(object sender, EventArgs e)
        {
            BuscarRegistros();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarRegistros();
        }
    }
}
