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
    public partial class FormEmpresa : Form
    {
        public FormEmpresa()
        {
            InitializeComponent();
        }

        private void FormEmpresa_Load(object sender, EventArgs e)
        {
            CargarSucursales();
            CargarCampos();
            CargaTextBox();
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

        private void CargarCampos()
        {
            this.dgvEmpresa.DataSource = CN_Empresa.Mostrar();
        }
        private void CargaTextBox()
        {
            tbRazonSocial.Text = dgvEmpresa.CurrentRow.Cells[1].Value.ToString();
            tbApellidoyNombre.Text = dgvEmpresa.CurrentRow.Cells[2].Value.ToString();
            tbDniCuit.Text = dgvEmpresa.CurrentRow.Cells[3].Value.ToString();
            dtpFecha.Value = Convert.ToDateTime(dgvEmpresa.CurrentRow.Cells[4].Value.ToString());
            tbIIBB.Text = dgvEmpresa.CurrentRow.Cells[5].Value.ToString();
            cbCondIVA.Text = dgvEmpresa.CurrentRow.Cells[6].Value.ToString();
            tbProvincia.Text = dgvEmpresa.CurrentRow.Cells[7].Value.ToString();
            tbLocalidad.Text = dgvEmpresa.CurrentRow.Cells[8].Value.ToString();
            tbCodPostal.Text = dgvEmpresa.CurrentRow.Cells[9].Value.ToString();
            tbDireccion.Text = dgvEmpresa.CurrentRow.Cells[10].Value.ToString();
            cbSucursal.SelectedValue = Convert.ToInt32(dgvEmpresa.CurrentRow.Cells[11].Value.ToString());
        }

        private void CargarSucursales()
        {
            cbSucursal.DataSource = CN_Empresa.MostrarSucursales();
            cbSucursal.DisplayMember = "NOMBRE_SUCURSAL";
            cbSucursal.ValueMember = "ID_SUCURSAL";
            //cbSucursal.SelectedIndex = -1;            
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
                        rpta = CN_Empresa.GuardarDatos(tbRazonSocial.Text, tbApellidoyNombre.Text, tbDniCuit.Text, dtpFecha.Value, tbIIBB.Text, cbCondIVA.Text, tbProvincia.Text, tbLocalidad.Text, tbCodPostal.Text, tbDireccion.Text, Convert.ToInt32(cbSucursal.SelectedValue));

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
                        rpta = CN_Empresa.GuardarDatos(tbRazonSocial.Text, tbApellidoyNombre.Text, tbDniCuit.Text, dtpFecha.Value, tbIIBB.Text, cbCondIVA.Text, tbProvincia.Text, tbLocalidad.Text, tbCodPostal.Text, tbDireccion.Text, Convert.ToInt32(cbSucursal.SelectedValue));

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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregaSucursal_Click(object sender, EventArgs e)
        {
            int Suc = Convert.ToInt32(cbSucursal.SelectedValue);
            Form formBG = new Form();
            using (FormSucursales mm = new FormSucursales())
            {
                formBG.StartPosition = FormStartPosition.Manual;
                formBG.FormBorderStyle = FormBorderStyle.None;
                formBG.Opacity = .70d;
                formBG.BackColor = Color.Black;
                formBG.WindowState = FormWindowState.Maximized;
                formBG.TopMost = true;
                formBG.Location = this.Location;
                formBG.ShowInTaskbar = false;
                formBG.Show();

                mm.Owner = formBG;
                mm.ShowDialog();

                formBG.Dispose();
            }
            CargarSucursales();            
            cbSucursal.SelectedValue = Suc;
        }
    }
}
