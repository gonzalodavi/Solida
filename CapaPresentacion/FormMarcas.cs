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
    public partial class FormMarcas : Form
    {
        private bool Editar = false;
        CN_Tablas objeto = new CN_Tablas();

        public FormMarcas()
        {
            InitializeComponent();
        }

        private void FormMarcas_Load(object sender, EventArgs e)
        {
            CargarGrillaMarcas();
            AcomodarTabla();
        }

        private void AcomodarTabla()
        {
            this.dgvMarca.Columns[0].Width = 70;
        }

        private void CargarGrillaMarcas()
        {
            dgvMarca.DataSource = objeto.CargarMarcas();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btnAceptaMarca_Click(object sender, EventArgs e)
        {
            if (tbMarca.Text != "")
            {
                try
                {
                    string rpta = CN_Tablas.ConsultaMarcaExiste(this.tbMarca.Text.Trim());
                    if (rpta == "OK")
                    {
                        MensajeError("Ya existe una Marca con ese Nombre");
                    }
                    else
                    {
                        if (rpta == "NO")
                        {
                            if (Editar == false)
                            {
                                if (MessageBox.Show("¿Desea Registrar La Nueva Marca?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    objeto.NuevaMarca(tbMarca.Text);
                                    MessageBox.Show("Nueva Marca Agregado");
                                    DeshabilitarEdicion();
                                    CargarGrillaMarcas();
                                    AcomodarTabla();
                                }
                            }
                            else
                            {
                                if (MessageBox.Show("¿Desea Modificar la Marca Seleccionada?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    string idMarca = dgvMarca.CurrentRow.Cells["ID"].Value.ToString();
                                    objeto.ModificarMarca(tbMarca.Text, idMarca);
                                    MessageBox.Show("Se Modificaron los datos de la Marca");
                                    DeshabilitarEdicion();
                                    CargarGrillaMarcas();
                                    AcomodarTabla();
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
                    MensajeError("No se puedo realizar el ingreso de datos debido a: \n\n" + ex);
                }
            }
            else
            {
                MensajeError("El Nombre de la Marca esta vacía");
            }            
        }

        private void btnCancelaMarca_Click(object sender, EventArgs e)
        {
            DeshabilitarEdicion();
        }

        private void DeshabilitarEdicion()
        {
            btnModMarca.Enabled = true;
            btnEliminaMarca.Enabled = true;
            btnNueva.Enabled = true;
            dgvMarca.Enabled = true;
            lblMarca.Text = "";
            tbMarca.Enabled = false;
            Editar = false;
            tbMarca.Text = "";
        }

        private void btnEliminaMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarca.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Desea Eliminar la Marca seleccionada?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        string idMarca = dgvMarca.CurrentRow.Cells["ID"].Value.ToString();
                        objeto.EliminarMarca(idMarca);
                        MessageBox.Show("Se eliminó correctamente la Marca seleccionada");
                        CargarGrillaMarcas();
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

        private void btnModMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarca.SelectedRows.Count > 0)
            {
                btnModMarca.Enabled = false;
                btnEliminaMarca.Enabled = false;
                btnNueva.Enabled = false;
                dgvMarca.Enabled = false;
                lblMarca.Text = "Modificar Marca";
                tbMarca.Enabled = true;
                tbMarca.Text = dgvMarca.CurrentRow.Cells["MARCA"].Value.ToString();
                Editar = true;
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            btnModMarca.Enabled = false;
            btnEliminaMarca.Enabled = false;
            btnNueva.Enabled = false;
            dgvMarca.Enabled = false;
            lblMarca.Text = "Nueva Marca";
            tbMarca.Enabled = true;
            tbMarca.Text = "";
            tbMarca.Focus();
        }        
    }
}
