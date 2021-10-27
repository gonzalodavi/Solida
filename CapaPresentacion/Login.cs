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
using System.Security.Cryptography;

namespace Presentacion
{
    public partial class Login : Form
    {

        

        public Login()
        {
            InitializeComponent();

            /*this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;*/
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        
       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (tBusuario.Text != "")
            {
                if(tBclave.Text!= "")
                {
                    ModeloUsuario user = new ModeloUsuario();
                    var loginValido = user.LoginUser(tBusuario.Text, tBclave.Text);
                    if (loginValido == true)
                    {
                        FormularioPrincipal mainMenu = new FormularioPrincipal();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        mensajeError("Usuario o clave incorrecto");
                        tBusuario.Clear();
                        tBclave.Clear();
                    }
                }
                else
                {
                    mensajeError("Por favor ingrese clave");
                }
            }
            else
            {
                mensajeError("Por favor ingrese usuario");
            }
            
        }
        private void mensajeError(string msj)
        {
            lError.Text = "     " + msj;
            lError.Visible = true;
        }



        private void Logout (object sender, FormClosedEventArgs e)
        {
            tBclave.Clear();
            tBusuario.Clear();
            lError.Visible = false;
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRecupera_Click(object sender, EventArgs e)
        {
            Form formBG2 = new Form();
            using (FormRecuperoClave mm = new FormRecuperoClave())
            {
                formBG2.StartPosition = FormStartPosition.Manual;
                formBG2.FormBorderStyle = FormBorderStyle.None;
                formBG2.Opacity = .70d;
                formBG2.BackColor = Color.Black;
                formBG2.WindowState = FormWindowState.Maximized;
                formBG2.TopMost = true;
                formBG2.Location = this.Location;
                formBG2.ShowInTaskbar = false;
                formBG2.Show();

                mm.Owner = formBG2;
                mm.ShowDialog();

                formBG2.Dispose();
            }

        }



        private void btnRecupera_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnRecupera.ForeColor = Color.LightGreen;
        }

        private void btnRecupera_MouseLeave(object sender, EventArgs e)
        {
            this.btnRecupera.ForeColor = Color.White;
        }
    }
}
