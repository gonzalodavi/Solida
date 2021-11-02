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

        public FormSucursales()
        {
            InitializeComponent();
        }

        private void dgvAlicuota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            rbEmpresa.Checked = true;
            //CargarGrillaSucursales();
            CargarCampos();
            CargaTextBox();
            CargarSucursales();
        }
        

        private void CargarCampos()
        {
            this.dgvEmpresa.DataSource = CN_Empresa.Mostrar();
        }
        private void CargaTextBox()
        {
            tbRazonSocial.Text = dgvEmpresa.CurrentRow.Cells[1].Value.ToString();
            tbApellidoyNombre.Text = dgvEmpresa.CurrentRow.Cells[2].Value.ToString();
            tbDniCuit.Text = dgvEmpresa.CurrentRow.Cells[3].Value.ToString();
            dtpFecha.Text = dgvEmpresa.CurrentRow.Cells[4].Value.ToString();
            tbIIBB.Text = dgvEmpresa.CurrentRow.Cells[5].Value.ToString();
            cbCondIVA.Text = dgvEmpresa.CurrentRow.Cells[6].Value.ToString();
            tbProvincia.Text = dgvEmpresa.CurrentRow.Cells[7].Value.ToString();
            tbLocalidad.Text = dgvEmpresa.CurrentRow.Cells[8].Value.ToString();
            tbCodPostal.Text = dgvEmpresa.CurrentRow.Cells[9].Value.ToString();
            tbDireccion.Text = dgvEmpresa.CurrentRow.Cells[10].Value.ToString();
        }

        private void CargarSucursales()
        {
            this.dgvSucursal.DataSource = CN_Empresa.MostrarSucursales();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbRazonSocial.Text == "" || tbApellidoyNombre.Text == "" || tbDniCuit.Text == "" || tbIIBB.Text == "" || tbLocalidad.Text == "" || tbDireccion.Text == "" || tbCodPostal.Text == "")
            {
                try
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Existen algunos campos vacios. Desea Guardar los cambios de todas formas?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    string rpta = "";
                    if (Opcion == DialogResult.OK)
                    {
                        rpta = CN_Empresa.GuardarDatos(tbRazonSocial.Text,tbApellidoyNombre.Text,tbDniCuit.Text, dtpFecha.Value,tbIIBB.Text,cbCondIVA.Text,tbProvincia.Text,tbLocalidad.Text,tbCodPostal.Text,tbDireccion.Text);

                        if (rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Guardaron Correctamente los datos de la Empresa");                            
                            CargarCampos();
                            CargaTextBox();
                        }
                        else
                        {
                            this.MensajeError(rpta);
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
                try
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Desea Modificar los Datos de la Empresa?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    string rpta = "";
                    if (Opcion == DialogResult.OK)
                    {
                        rpta = CN_Empresa.GuardarDatos(tbRazonSocial.Text, tbApellidoyNombre.Text, tbDniCuit.Text, dtpFecha.Value, tbIIBB.Text, cbCondIVA.Text, tbProvincia.Text, tbLocalidad.Text, tbCodPostal.Text, tbDireccion.Text);

                        if (rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Guardaron Correctamente los datos de la Empresa");
                            CargarCampos();
                            CargaTextBox();
                        }
                        else
                        {
                            this.MensajeError(rpta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }           
        }

        private void btnRegistrarSucursal_Click(object sender, EventArgs e)
        {
            if (tbNuevaSucursal.Text != "")
            {
                try
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Desea Agregar Nueva Sucursal?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    string rpta = "";
                    if (Opcion == DialogResult.OK)
                    {
                        rpta = CN_Empresa.GuardarSucursal(tbNuevaSucursal.Text);

                        if (rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Registro Nueva Sucursal");
                            CargarSucursales();
                            tbNuevaSucursal.Text = "";
                        }
                        else
                        {
                            this.MensajeError(rpta);
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void chekEmpresa_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            CargarCampos();
            CargaTextBox();
            panelEmpresa.Enabled = true;
            panelSucursal.Enabled = false;
        }

        private void rbSucursal_CheckedChanged(object sender, EventArgs e)
        {
            CargarSucursales();
            panelEmpresa.Enabled = false;
            panelSucursal.Enabled = true;
        }
    }
}
