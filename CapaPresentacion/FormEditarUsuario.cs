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
        CN_Usuarios objetoCN = new CN_Usuarios();

        public FormEditarUsuario()
        {
            InitializeComponent();
        }

        //Mostrar Mensaje de Confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SOLIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SOLIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }


        private void reset()
        {
            cargarDatosUsuario();            
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tBUsuario.Text != "" && tBNombre.Text != "" && tBApellido.Text != "" && tBEmail.Text != "" && tBClaveActual.Text != "")
            {
                try
                {
                    string rpta = CN_Usuarios.ConsultaExisteNombreUser(this.tBUsuario.Text.Trim(), UserLoginCache.UserId);
                    if (rpta == "OK")
                    {
                        MensajeError("Ya existe un USUARIO con ese nombre");
                    }
                    else
                    {
                        if (rpta == "NO")
                        {
                            ModificarPerfilUsuario();
                        }
                        else
                        {
                            MensajeError(rpta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else
            {
                MensajeError("Existen campos vacíos, Por favor complete todos los campos");
            }
        }


        private void ModificarPerfilUsuario()
        {
            if (tBClaveActual.Text != "")
            {

                if (tBClaveNueva.Text == tBClaveConfirma.Text)
                {
                    if (tBClaveActual.Text == UserLoginCache.Clave)
                    {
                        var modeloUsuario = new ModeloUsuario(userID: UserLoginCache.UserId, user: tBUsuario.Text, pass: tBClaveActual.Text, nombre: tBNombre.Text, apellido: tBApellido.Text, email: tBEmail.Text);
                        var result = modeloUsuario.editarPerfilUsuario();
                        MessageBox.Show(result);
                        reset();
                        this.Close();
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
                        var modeloUsuario = new ModeloUsuario(userID: UserLoginCache.UserId, user: tBUsuario.Text, pass: tBClaveNueva.Text, nombre: tBNombre.Text, apellido: tBApellido.Text, email: tBEmail.Text);
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
                        this.Close();
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
       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
