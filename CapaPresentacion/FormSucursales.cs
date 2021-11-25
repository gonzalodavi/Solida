using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class FormSucursales : Form
    {
        CN_Empresa objeto = new CN_Empresa();
        private bool Editar = false;

        public FormSucursales()
        {
            InitializeComponent();
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SOLIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SOLIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormSucursales_Load(object sender, EventArgs e)
        {    
            CargarSucursales();
        }

        private void CargarSucursales()
        {
            this.dgvSucursal.DataSource = CN_Empresa.MostrarSucursales();
        }


        private void btnRegistrarSucursal_Click(object sender, EventArgs e)
        {
            if (tbNuevaSucursal.Text != "")
            {
                try
                {
                    string rpta = CN_Empresa.ConsultaSucursalExiste(this.tbNuevaSucursal.Text.Trim());
                    if (rpta == "OK")
                    {
                        MensajeError("Ya existe esa Sucursal");
                    }
                    else
                    {
                        if (rpta == "NO")
                        {
                            if (Editar == false)
                            {
                                DialogResult Opcion;
                                Opcion = MessageBox.Show("Desea Agregar Nueva Sucursal?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                string rpta1 = "";
                                if (Opcion == DialogResult.OK)
                                {
                                    rpta1 = CN_Empresa.GuardarSucursal(tbNuevaSucursal.Text);

                                    if (rpta1.Equals("OK"))
                                    {
                                        this.MensajeOk("Se Registro Nueva Sucursal");
                                        DeshabilitarEdicion();
                                        CargarSucursales();                                        
                                    }
                                    else
                                    {
                                        this.MensajeError(rpta1);
                                    }
                                }
                            }
                            else
                            {
                                if (MessageBox.Show("¿Desea Modificar la Sucursal Seleccionada?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    string idSuc = dgvSucursal.CurrentRow.Cells["ID_SUCURSAL"].Value.ToString();
                                    objeto.Modificar(tbNuevaSucursal.Text, idSuc);
                                    MessageBox.Show("Se Modificaron los datos de la sucursal");
                                    DeshabilitarEdicion();
                                    CargarSucursales();
                                    Editar = false;
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
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else
            {
                this.MensajeError("Ingrese una sucursal");
            }
        }

        private void tbNuevaSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            btnMod.Enabled = false;
            btnElim.Enabled = false;
            btnNueva.Enabled = false;
            dgvSucursal.Enabled = false;
            lblSubtitulo.Text = "Nueva Sucursal";
            tbNuevaSucursal.Enabled = true;
            tbNuevaSucursal.Text = "";
            tbNuevaSucursal.Focus();

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            DeshabilitarEdicion();
            Editar = false;
        }
        private void DeshabilitarEdicion()
        {
            btnMod.Enabled = true;
            btnElim.Enabled = true;
            btnNueva.Enabled = true;
            dgvSucursal.Enabled = true;
            lblSubtitulo.Text = "";
            tbNuevaSucursal.Enabled = false;
            Editar = false;
            tbNuevaSucursal.Text = "";
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            if (dgvSucursal.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Desea Eliminar la Sucursal Seleccionada?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        string id = dgvSucursal.CurrentRow.Cells["ID_SUCURSAL"].Value.ToString();
                        objeto.Eliminar(id);
                        MensajeOk("Se eliminó correctamente la Sucursal seleccionada");
                        CargarSucursales();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puedo realizar la eliminación debido a: \n\n" + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (dgvSucursal.SelectedRows.Count > 0)
            {
                btnMod.Enabled = false;
                btnElim.Enabled = false;
                btnNueva.Enabled = false;
                dgvSucursal.Enabled = false;
                lblSubtitulo.Text = "Modificar Sucursal";
                tbNuevaSucursal.Enabled = true;
                tbNuevaSucursal.Text = dgvSucursal.CurrentRow.Cells["NOMBRE_SUCURSAL"].Value.ToString();
                Editar = true;
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
    }
}
