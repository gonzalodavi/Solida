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
    public partial class FormModelo : Form
    {
        private bool Editar = false;
        CN_Tablas objeto = new CN_Tablas();
     
        public FormModelo()
        {
            InitializeComponent();
        }


        private void FormModelo_Load(object sender, EventArgs e)
        {
            CargarGrillaModelos();
            AcomodaTabla();
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

        private void CargarGrillaModelos()
        {
            dgvModelo.DataSource = objeto.CargarModelos();
            //dgvRubros.Columns[0].Visible = false;            
        }

        private void AcomodaTabla()
        {
            this.dgvModelo.Columns[0].Width = 70;
        }

        private void DeshabilitarEdicion()
        {
            btnNuevo.Enabled = true;
            btnModModelo.Enabled = true;
            btnEliminaModelo.Enabled = true;
            dgvModelo.Enabled = true;
            lblModelo.Text = "";
            tbModelo.Enabled = false;
            Editar = false;
            tbModelo.Text = "";
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptaModelo_Click(object sender, EventArgs e)
        {
            if (tbModelo.Text != "")
            {
                try
                {
                    string rpta = CN_Tablas.ConsultaModeloExiste(this.tbModelo.Text.Trim());
                    if (rpta == "OK")
                    {
                        MensajeError("Ya existe un Modelo con ese Nombre");
                    }
                    else
                    {
                        if (rpta == "NO")
                        {
                            if (Editar == false)
                            {
                                if (MessageBox.Show("¿Desea Registrar el Nuevo Modelo?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    objeto.NuevoModelo(tbModelo.Text);
                                    MessageBox.Show("Nuevo Modelo Agregado");
                                    DeshabilitarEdicion();
                                    CargarGrillaModelos();
                                    AcomodaTabla();
                                }
                            }
                            else
                            {
                                if (MessageBox.Show("¿Desea Modificar el Modelo Seleccionado?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    string idModelo = dgvModelo.CurrentRow.Cells["ID"].Value.ToString();
                                    objeto.ModificarModelo(tbModelo.Text, idModelo);
                                    MessageBox.Show("Se Modificaron los datos del Modelo");
                                    DeshabilitarEdicion();
                                    CargarGrillaModelos();
                                    AcomodaTabla();
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
                    MessageBox.Show("No se puedo realizar el ingreso de datos debido a: \n\n" + ex);
                }
            }
            else
            {
                MessageBox.Show("El Nombre del Modelo esta vacío");
            }
        }

        private void btnCancelaModelo_Click(object sender, EventArgs e)
        {
            DeshabilitarEdicion();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnEliminaModelo.Enabled = false;
            btnModModelo.Enabled = false;
            dgvModelo.Enabled = false;
            lblModelo.Text = "Nuevo Modelo";
            tbModelo.Enabled = true;
            tbModelo.Text = "";
            tbModelo.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvModelo.SelectedRows.Count > 0)
            {
                btnModModelo.Enabled = false;
                btnEliminaModelo.Enabled = false;
                btnNuevo.Enabled = false;
                dgvModelo.Enabled = false;
                lblModelo.Text = "Modificar Rubro";
                tbModelo.Enabled = true;
                tbModelo.Text = dgvModelo.CurrentRow.Cells["MODELO"].Value.ToString();
                Editar = true;
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnElimiarDom_Click(object sender, EventArgs e)
        {
            if (dgvModelo.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Desea Eliminar el Modelo Seleccionado?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        string idModelo = dgvModelo.CurrentRow.Cells["ID"].Value.ToString();
                        objeto.EliminarModelo(idModelo);
                        MessageBox.Show("Se eliminó correctamente el Modelo seleccionado");
                        CargarGrillaModelos();
                        AcomodaTabla();
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
    }
}
