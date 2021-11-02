using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaComun.Cache;
using CapaNegocio;

namespace Presentacion
{
    public partial class FormEditarUsuario : Form
    {        

        public FormEditarUsuario()
        {
            InitializeComponent();
        }        

        

        private void FormEditarUsuario_Load(object sender, EventArgs e)
        {
            cargarDatosUsuario();
        }

        private void cargarDatosUsuario()
        {
            tBUsuario.Text = UserLoginCache.Usuario;
            tBNombre.Text = UserLoginCache.Nombre;
            tBApellido.Text = UserLoginCache.Apellido;
            tBEmail.Text = UserLoginCache.Email;
            tBRol.Text = UserLoginCache.Rango;

        }
        private void reset()
        {
            cargarDatosUsuario();            
        }

       

        private void btnGuardar_Click(object sender, EventArgs e)
        {            
            if (tBClaveActual.Text != "")
            {

                if (tBClaveNueva.Text == tBClaveConfirma.Text)
                {
                    if (tBClaveActual.Text == UserLoginCache.Clave)
                    {
                        var modeloUsuario = new ModeloUsuario(userID: UserLoginCache.UserId, user: tBUsuario.Text, pass: tBClaveActual.Text, nombre: tBNombre.Text, apellido: tBApellido.Text, rol: tBRol.Text, email: tBEmail.Text);
                        var result = modeloUsuario.editarPerfilUsuario();
                        MessageBox.Show(result);
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña actual es incorrecta");
                    }
                }
    
            }
            else
            {
                MessageBox.Show("Ingrese su clave para poder modificar su perfil");
            }

        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            btnCambiarClave.Visible = false;
            lblClaveNueva.Visible = true;
            lblConfirmaClave.Visible = true;
            tBClaveNueva.Visible = true;
            tBClaveConfirma.Visible = true;
            btnGuardar.Visible = false;
            btnRegresar.Visible = false;
            btnGuardaClave.Visible = true;
            btnCancelaClave.Visible = true;
            tBApellido.Enabled = false;
            tBEmail.Enabled = false;
            tBNombre.Enabled = false;
            tBUsuario.Enabled = false;

        }

        private void btnCancelaClave_Click(object sender, EventArgs e)
        {
            btnCambiarClave.Visible = true;
            lblClaveNueva.Visible = false;
            lblConfirmaClave.Visible = false;
            tBClaveNueva.Visible = false;
            tBClaveConfirma.Visible = false;
            btnGuardar.Visible = true;
            btnRegresar.Visible = true;
            btnGuardaClave.Visible = false;
            btnCancelaClave.Visible = false;
            tBApellido.Enabled = true;
            tBEmail.Enabled = true;
            tBNombre.Enabled = true;
            tBUsuario.Enabled = true;
        }

        private void btnGuardaClave_Click(object sender, EventArgs e)
        {
            if (tBClaveNueva.Text.Length >= 5)
            {
                if (tBClaveNueva.Text == tBClaveConfirma.Text)
                {
                    if (tBClaveActual.Text == UserLoginCache.Clave)
                    {
                        var modeloUsuario = new ModeloUsuario(userID: UserLoginCache.UserId, user: tBUsuario.Text, pass: tBClaveNueva.Text, nombre: tBNombre.Text, apellido: tBApellido.Text, rol: tBRol.Text, email: tBEmail.Text);
                        var result = modeloUsuario.cambiarClave();
                        MessageBox.Show(result);                        
                        btnCambiarClave.Visible = true;
                        lblClaveNueva.Visible = false;
                        lblConfirmaClave.Visible = false;
                        tBClaveNueva.Visible = false;
                        tBClaveConfirma.Visible = false;
                        btnGuardar.Visible = true;
                        btnRegresar.Visible = true;
                        btnGuardaClave.Visible = false;
                        btnCancelaClave.Visible = false;
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña actual es incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("Las claves no coinciden");
                }                
            }
            else
            {
                MessageBox.Show("La nueva clave debe contener al menos 5 caracteres");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
