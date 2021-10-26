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
    public partial class FormBarrio : Form
    {
        CN_Domicilio objeto = new CN_Domicilio();

        public FormBarrio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBarrio_Load(object sender, EventArgs e)
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
        private void CargarComboBoxLocalidad()
        {
            if (cbProvincia.SelectedIndex != -1)
            {
                int idp = Convert.ToInt32(cbProvincia.SelectedValue);
                cbLocalidad.DisplayMember = "DES_LOCALIDAD";
                cbLocalidad.ValueMember = "ID_LOCALIDAD";
                cbLocalidad.DataSource = CN_Domicilio.CargaLocalidadEnComboBox(idp);
                cbLocalidad.SelectedIndex = -1;                
            }
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvincia.SelectedIndex != -1)
            {
                cbLocalidad.Enabled = true;
                string elid = cbProvincia.SelectedValue.ToString();
                int numero = Convert.ToInt32(elid);
                CargarComboBoxLocalidad();             
            }
            else
            {
                cbLocalidad.SelectedIndex = -1;
                cbLocalidad.Enabled = false;
                tbBarrio.Text = "";
                tbCodPostal.Text = "";
                tbBarrio.Enabled = false;
                tbCodPostal.Enabled = false;                
            }
        }

        private void cbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbLocalidad.SelectedIndex != -1)
            {
                tbBarrio.Text = "";
                tbCodPostal.Text = "";
                tbBarrio.Enabled = true;
                tbCodPostal.Enabled = true;
            }
            else
            {
                tbBarrio.Text = "";
                tbCodPostal.Text = "";
                tbBarrio.Enabled = false;
                tbCodPostal.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (tbBarrio.Text != "" && tbCodPostal.Text != "")
            {
                string rpta = CN_Domicilio.ConsultaBarrioExiste(Convert.ToInt32(this.cbLocalidad.SelectedValue), this.tbBarrio.Text.Trim());
                if (rpta == "OK")
                {
                    MensajeError("Ya existe Un Barrio con ese Nombre Para la Localidad elegida");
                }
                else
                {
                    if (rpta == "NO")
                    {
                        AgregaBarrio();
                    }
                    else
                    {
                        MensajeError(rpta);
                    }
                }
            }
            else
            {
                MensajeError("Por Favor Ingrese un Nombre de Barrio y Codigo Postal");
            }
        }
        

        private void AgregaBarrio()
        {
            try
            {
                string Rpta = CN_Domicilio.InsertarBarrio(this.tbBarrio.Text.Trim(), Convert.ToInt32(this.cbLocalidad.SelectedValue), this.tbCodPostal.Text.Trim());

                if (Rpta.Equals("OK"))
                {
                    this.MensajeOk("Se Agregó Nuevo Barrio, a continuació busquelo en la lista");
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
