using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio;

namespace Presentacion
{
    public partial class FormRecuperoClave : Form
    {
        public FormRecuperoClave()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void mensajeRes(string msj)
        {
            lblResultado.Text = "     " + msj;
            lblResultado.Visible = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var usuario = new ModeloUsuario();
            var resultado = usuario.recuperarClave(tBUsuarioMail.Text);
            mensajeRes(resultado);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
