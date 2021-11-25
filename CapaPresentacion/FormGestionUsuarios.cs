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
                    if (Editar == false)
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

                    if (Editar == true)
                    {
                        if (MessageBox.Show("¿Desea modificar el usuario seleccionado?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            try
                            {
                                objetoCN.EditarUsuarios(tbUsuario.Text, tbClave.Text, tbNombre.Text, tbApellido.Text, cbRoles.Text, tbEmail.Text, idUsuario);
                                MessageBox.Show("Se modificaron correctamente los datos del usuario");
                                
                                Editar = false;
                                limpiarCampos();
                                MostrarUsuarios();
                                DeshabilitarEdicion();
                                lblNuevoOModUser.Text = "Nuevo Usuario";
                                lblNuevoOModUser.Visible = false;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("No se puedo modificar los datos debido a: \n\n" + ex);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La clave ingresada debe contener al menos 5 caracteres");
                }

            }
            else
            {
                MessageBox.Show("Existe algun campo vacío.\nPara modificar o editar un usuario debe completar todos sus datos");
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
            Editar = false;
        }

        private void btnModificarUser_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                Editar = true;
                HabilitarEdicion();
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

        private void dgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {  
            if (this.dgvUsuarios.Columns[e.ColumnIndex].Name == "CLAVE")
            {
                e.Value = new string('*', 4);
            }
        }

        private void btnEliminarUser_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0) 
            {
                if (MessageBox.Show("¿Desea ELIMINAR permanentemente el usuario seleccionado?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    idUsuario = dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString();
                    objetoCN.EliminarUsuario(idUsuario);
                    MessageBox.Show("Se eliminó correctamente el usuario seleccionado");
                    MostrarUsuarios();
                }                
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            btnModificarUser.Enabled = true;
            btnEliminarUser.Enabled = true;
            limpiarCampos();
            DeshabilitarEdicion();
            lblNuevoOModUser.Text = "Nuevo Usuario";
            lblNuevoOModUser.Visible = false;
        }
        

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarEdicion();
            tbUsuario.Focus();
            lblNuevoOModUser.Text = "Nuevo Usuario";
            lblNuevoOModUser.Visible = true;
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
            cbRoles.SelectedIndex = -1;
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
            cbRoles.SelectedIndex = -1;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
