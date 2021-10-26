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
    public partial class FormLocalidad : Form
    {
        CN_Domicilio objeto = new CN_Domicilio();

        public FormLocalidad()
        {
            InitializeComponent();
        }

        private void FormLocalidad_Load(object sender, EventArgs e)
        {
            CargarComboBoxProvincia();
            cbProvincia.Focus();
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

        private void CargarComboBoxProvincia()
        {
            cbProvincia.DisplayMember = "DES_PROVINCIA";
            cbProvincia.ValueMember = "ID_PROVINCIA";
            cbProvincia.DataSource = objeto.CargaProvincia();
            cbProvincia.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbProvincia.SelectedIndex !=-1)
            {
                tbLocalidad.Text = "";
                tbLocalidad.Enabled = true;
                tbLocalidad.Focus();
            }
            else
            {
                tbLocalidad.Enabled = false;
                cbProvincia.Focus();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tbLocalidad.Text!= "")
            {
                string rpta = CN_Domicilio.ConsultaLocalidadExiste(Convert.ToInt32(this.cbProvincia.SelectedValue),this.tbLocalidad.Text.Trim());
                if (rpta == "OK")
                {
                    MensajeError("Ya existe Una Localidad con ese Nombre Para la Provincia elegida");
                }
                else
                {
                    if (rpta == "NO")
                    {
                        AgregaLocalidad();
                    }
                    else
                    {
                        MensajeError(rpta);
                    }
                }
            }
            else
            {
                MensajeError("Por Favor Ingrese un Nombre");
            }
        }

        private void AgregaLocalidad()
        {            
            try
            {
                string Rpta = CN_Domicilio.InsertarLocalidad(this.tbLocalidad.Text.Trim(), Convert.ToInt32(this.cbProvincia.SelectedValue));

                if (Rpta.Equals("OK"))
                {
                    this.MensajeOk("Se Agregó Nueva Localidad, a continuación agregue un Nuevo Barrio");
                    this.Close();
                }
                else
                {
                    this.MensajeError(Rpta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
