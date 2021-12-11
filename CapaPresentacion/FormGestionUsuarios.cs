using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaComun.Cache;
using CapaNegocio;
using CapaPresentacion;

namespace Presentacion
{
    public partial class FormGestionUsuarios : Form
    {
        CN_Usuarios objetoCN = new CN_Usuarios();
        private string idUsuario = null;
        private bool Editar = false;

        public FormGestionUsuarios()
        {
            InitializeComponent();
        }

        private void FormGestionUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
            CargaElComboBox();
        }

        private void CargaElComboBox()
        {
            cbRoles.DataSource = objetoCN.CargarComboBox();
            cbRoles.DisplayMember = "nombre_Rol";
            cbRoles.Text = "";
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



        private void MostrarUsuarios()
        {
            this.dgvUsuarios.DataSource = CN_Usuarios.MostrarUsuarios();
            this.dgvUsuarios.Columns[0].Visible = false;
            this.dgvUsuarios.Columns[2].Visible = false;

            this.dgvUsuarios.Columns[1].Width = 50;
            this.dgvUsuarios.Columns[3].Width = 50;
            this.dgvUsuarios.Columns[4].Width = 50;
            this.dgvUsuarios.Columns[5].Width = 50;
            this.dgvUsuarios.Columns[6].Width = 200;
        }

        private void btnAgregarUser_Click(object sender, EventArgs e)
        {
            if(tbUsuario.Text !="" && tbClave.Text != "" && tbNombre.Text != "" && tbApellido.Text != "" && cbRoles.Text != "" && tbEmail.Text != "")
            {
                if (tbClave.Text.Length >= 5)
                {
                    try
                    {
                        string rpta = CN_Usuarios.ConsultaExisteNombreUser(this.tbUsuario.Text.Trim(), Convert.ToInt32(idUsuario));
                        if (rpta == "OK")
                        {
                            MensajeError("Ya existe un USUARIO con ese nombre");
                        }
                        else
                        {
                            if (rpta == "NO")
                            {
                                if (Editar == false)
                                {
                                    AgregaUsuario();
                                }

                                if (Editar == true)
                                {
                                    EditaUsuario();
                                }
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
                    MessageBox.Show("La clave ingresada debe contener al menos 5 caracteres");
                }

            }
            else
            {
                MessageBox.Show("Existen campos vacíos.\n\nPara Agregar o Editar Usuarios debe completar todos sus datos");
                if(tbUsuario.Text == "")
                {
                    lblErrorUsuario.Visible = true;
                }
                if (tbClave.Text == "")
                {
                    lblErrorClave.Visible = true;
                }
                if (cbRoles.SelectedIndex == -1)
                {
                    lblErrorRol.Visible = true;
                }
                if (tbNombre.Text == "")
                {
                    lblErrorNombre.Visible = true;
                }
                if (tbApellido.Text == "")
                {
                    lblErrorApellido.Visible = true;
                }
                if (tbEmail.Text == "")
                {
                    lblErrorMail.Visible = true;
                }
            }            
        }

        private void EditaUsuario()
        {
            if (MessageBox.Show("¿Desea modificar el usuario seleccionado?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    objetoCN.EditarUsuarios(tbUsuario.Text, tbClave.Text, tbNombre.Text, tbApellido.Text, cbRoles.Text, tbEmail.Text, idUsuario);
                    MessageBox.Show("Se modificaron correctamente los datos del usuario");

                    MostrarUsuarios();
                    DeshabilitarEdicion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puedo modificar los datos debido a: \n\n" + ex);
                }
            }
        }

        private void AgregaUsuario()
        {
            if (MessageBox.Show("¿Desea registrar los datos del nuevo usuario?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    objetoCN.InsertarUsuarios(tbUsuario.Text, tbClave.Text, tbNombre.Text, tbApellido.Text, cbRoles.Text, tbEmail.Text);
                    MessageBox.Show("Se insertó correctamente el nuevo usuario");
                    limpiarCampos();
                    MostrarUsuarios();
                    DeshabilitarEdicion();
                    lblNuevoOModUser.Text = "Nuevo Usuario";
                    lblNuevoOModUser.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puedo insertar los datos debido a: \n\n" + ex);
                }
            }
        }

        private void limpiarCampos()
        {            
            tbApellido.Text = "";
            tbClave.Text = "";
            tbNombre.Text = "";
            cbRoles.Text = "";
            tbUsuario.Text = "";
            tbEmail.Text = "";
            cbRoles.SelectedIndex = -1;
            lblErrorApellido.Visible = false;
            lblErrorClave.Visible = false;
            lblErrorMail.Visible = false;
            lblErrorNombre.Visible = false;
            lblErrorRol.Visible = false;
            lblErrorUsuario.Visible = false;
            Editar = false;
            idUsuario = null;
        }


        private void btnCancela_Click(object sender, EventArgs e)
        {
            DeshabilitarEdicion();
            lblNuevoOModUser.Text = "Nuevo Usuario";
            lblNuevoOModUser.Visible = false;
        }        


        private void HabilitarEdicion()
        {
            dgvUsuarios.Enabled = false;
            btnNuevo.Enabled = false;
            btnModificarUser.Enabled = false;
            btnEliminarUser.Enabled = false;
            tbApellido.Enabled = true;
            tbClave.Enabled = true;
            tbEmail.Enabled = true;
            tbNombre.Enabled = true;
            tbUsuario.Enabled = true;
            cbRoles.Enabled = true;
            limpiarCampos();
            btnCancela.Enabled = true;
            btnAgregarUser.Enabled = true;
        }

        private void DeshabilitarEdicion()
        {
            dgvUsuarios.Enabled = true;
            btnNuevo.Enabled = true;
            btnModificarUser.Enabled = true;
            btnEliminarUser.Enabled = true;
            tbApellido.Enabled = false;
            tbClave.Enabled = false;
            tbEmail.Enabled = false;
            tbNombre.Enabled = false;
            tbUsuario.Enabled = false;
            cbRoles.Enabled = false;
            limpiarCampos();
            btnCancela.Enabled = false;
            btnAgregarUser.Enabled = false;
            lblNuevoOModUser.Text = "Nuevo Usuario";
            lblNuevoOModUser.Visible = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRoles.SelectedIndex != -1)
            {
                lblErrorRol.Visible = false;
            }
            else
            {
                lblErrorRol.Visible = true;
            }
        }

        private void cbRoles_Leave(object sender, EventArgs e)
        {
            if (cbRoles.SelectedIndex != -1)
            {
                lblErrorRol.Visible = false;
            }
            else
            {
                lblErrorRol.Visible = true;
            }
        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            if (tbUsuario.Text != "")
            {
                lblErrorUsuario.Visible = false;
            }
            else
            {
                lblErrorUsuario.Visible = true;
            }
        }

        private void tbUsuario_Leave(object sender, EventArgs e)
        {
            if (tbUsuario.Text != "")
            {
                lblErrorUsuario.Visible = false;
            }
            else
            {
                lblErrorUsuario.Visible = true;
            }
        }

        private void tbClave_TextChanged(object sender, EventArgs e)
        {
            if (tbClave.Text != "")
            {
                lblErrorClave.Visible = false;
            }
            else
            {
                lblErrorClave.Visible = true;
            }
        }

        private void tbClave_Leave(object sender, EventArgs e)
        {
            if (tbClave.Text != "")
            {
                lblErrorClave.Visible = false;
            }
            else
            {
                lblErrorClave.Visible = true;
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            if (tbNombre.Text != "")
            {
                lblErrorNombre.Visible = false;
            }
            else
            {
                lblErrorNombre.Visible = true;
            }
        }

        private void tbNombre_Leave(object sender, EventArgs e)
        {
            if (tbNombre.Text != "")
            {
                lblErrorNombre.Visible = false;
            }
            else
            {
                lblErrorNombre.Visible = true;
            }
        }

        private void tbApellido_TextChanged(object sender, EventArgs e)
        {
            if (tbApellido.Text != "")
            {
                lblErrorApellido.Visible = false;
            }
            else
            {
                lblErrorApellido.Visible = true;
            }
        }

        private void tbApellido_Leave(object sender, EventArgs e)
        {
            if (tbApellido.Text != "")
            {
                lblErrorApellido.Visible = false;
            }
            else
            {
                lblErrorApellido.Visible = true;
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (tbEmail.Text != "")
            {
                lblErrorMail.Visible = false;
            }
            else
            {
                lblErrorMail.Visible = true;
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text != "")
            {
                lblErrorMail.Visible = false;
            }
            else
            {
                lblErrorMail.Visible = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarEdicion();
            tbUsuario.Focus();
            lblNuevoOModUser.Text = "Nuevo Usuario";
            lblNuevoOModUser.Visible = true;
        }

        private void btnModificarUser_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                HabilitarEdicion();
                Editar = true;
                lblNuevoOModUser.Text = "Modificar Usuario";
                lblNuevoOModUser.Visible = true;
                tbUsuario.Text = dgvUsuarios.CurrentRow.Cells["USUARIO"].Value.ToString();
                tbClave.Text = dgvUsuarios.CurrentRow.Cells["CLAVE"].Value.ToString();
                tbNombre.Text = dgvUsuarios.CurrentRow.Cells["NOMBRE"].Value.ToString();
                tbApellido.Text = dgvUsuarios.CurrentRow.Cells["APELLIDO"].Value.ToString();
                cbRoles.Text = dgvUsuarios.CurrentRow.Cells["ROL"].Value.ToString();
                tbEmail.Text = dgvUsuarios.CurrentRow.Cells["EMAIL"].Value.ToString();
                idUsuario = dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void btnEliminarUser_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int idU = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["ID"].Value);
                if (idU == 1)
                {
                    MensajeError("No se permite eliminar este usuario");
                }
                else
                {
                    try
                    {
                        string rpta = CN_Usuarios.ConsultaSiExisteUserEnComprob("BuscarSiExisteUserCmpras", idU);
                        if (rpta == "OK")
                        {
                            this.MensajeError("No se puede eliminar un Usuario que efectuo comprobantes");
                        }
                        else
                        {
                            if (rpta == "NO")
                            {
                                rpta = CN_Usuarios.ConsultaSiExisteUserEnComprob("BuscarSiExisteUserNotas", idU);
                                if (rpta == "OK")
                                {
                                    this.MensajeError("No se puede eliminar un Usuario que efectuo comprobantes");
                                }
                                else
                                {
                                    if (rpta == "NO")
                                    {
                                        rpta = CN_Usuarios.ConsultaSiExisteUserEnComprob("BuscarSiExisteUserOPago", idU);
                                        if (rpta == "OK")
                                        {
                                            this.MensajeError("No se puede eliminar un Usuario que efectuo comprobantes");
                                        }
                                        else
                                        {
                                            if (rpta == "NO")
                                            {
                                                rpta = CN_Usuarios.ConsultaSiExisteUserEnComprob("BuscarSiExisteUserRec", idU);
                                                if (rpta == "OK")
                                                {
                                                    this.MensajeError("No se puede eliminar un Usuario que efectuo comprobantes");
                                                }
                                                else
                                                {
                                                    if (rpta == "NO")
                                                    {
                                                        rpta = CN_Usuarios.ConsultaSiExisteUserEnComprob("BuscarSiExisteUserRem", idU);
                                                        if (rpta == "OK")
                                                        {
                                                            this.MensajeError("No se puede eliminar un Usuario que efectuo comprobantes");
                                                        }
                                                        else
                                                        {
                                                            if (rpta == "NO")
                                                            {
                                                                rpta = CN_Usuarios.ConsultaSiExisteUserEnComprob("BuscarSiExisteUserVtas", idU);
                                                                if (rpta == "OK")
                                                                {
                                                                    this.MensajeError("No se puede eliminar un Usuario que efectuo comprobantes");
                                                                }
                                                                else
                                                                {
                                                                    if (rpta == "NO")
                                                                    {
                                                                        if (MessageBox.Show("¿Desea ELIMINAR permanentemente el usuario seleccionado?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                                                        {
                                                                            idUsuario = idU.ToString();
                                                                            objetoCN.EliminarUsuario(idUsuario);
                                                                            MessageBox.Show("Se eliminó correctamente el usuario seleccionado");
                                                                            MostrarUsuarios();
                                                                            idUsuario = null;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        MensajeError(rpta);
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                MensajeError(rpta);
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MensajeError(rpta);
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MensajeError(rpta);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MensajeError(rpta);
                                    }
                                }
                            }
                            else
                            {
                                MensajeError(rpta);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo realizar la operacion: " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }
    }
}
