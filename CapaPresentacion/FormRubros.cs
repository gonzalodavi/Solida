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
    public partial class FormRubros : Form
    {
        private bool Editar = false;
        CN_Tablas objeto = new CN_Tablas();

        public FormRubros()
        {
            InitializeComponent();
        }

        private void FormRubros_Load(object sender, EventArgs e)
        {
            CargarGrillaRubros();
            AcomodaTablaRubro();
        }

        private void AcomodaTablaRubro()
        {
            this.dgvRubros.Columns[0].Width = 70;
            
        }

        private void CargarGrillaRubros()
        {
            dgvRubros.DataSource = objeto.CargarRubros();
            //dgvRubros.Columns[0].Visible = false;            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptaRubro_Click(object sender, EventArgs e)
        {
            if (tbRubro.Text != "")
            {
                if (Editar == false)
                {
                    if (MessageBox.Show("¿Desea Registrar el Rubro?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            objeto.NuevoRubro(tbRubro.Text);
                            MessageBox.Show("Nuevo Rubro Agregado");
                            Editar = false;
                            CargarGrillaRubros();
                            tbRubro.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se puedo realizar el ingreso de datos debido a: \n\n" + ex);
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("¿Desea Modificar el Rubro Seleccionado?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            string idRubro = dgvRubros.CurrentRow.Cells["ID"].Value.ToString();
                            objeto.ModificarRubro(tbRubro.Text, idRubro);
                            MessageBox.Show("Se Modificaron los datos del Rubro");
                            Editar = false;
                            CargarGrillaRubros();
                            dgvRubros.Enabled = true;
                            tbRubro.Text = "";
                            btnModRubro.Visible = true;
                            btnEliminaRubro.Visible = true;
                            lblRubro.Text = "Ingrese Nuevo Producto";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se puedo realizar el ingreso de datos debido a: \n\n" + ex);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("El Nombre del Rubro esta vacío");
            }
        }

        private void btnCancelaRubro_Click(object sender, EventArgs e)
        {
            btnModRubro.Visible = true;
            btnEliminaRubro.Visible = true;
            dgvRubros.Enabled = true;
            lblRubro.Text = "Ingrese Nuevo Rubro";
            Editar = false;
            tbRubro.Text = "";
        }

        private void btnEliminaRubro_Click(object sender, EventArgs e)
        {
            if (dgvRubros.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Desea Eliminar el Rubro seleccionado?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        string idRubro = dgvRubros.CurrentRow.Cells["ID"].Value.ToString();
                        objeto.EliminarRubro(idRubro);
                        MessageBox.Show("Se eliminó correctamente el Rubro seleccionado");
                        CargarGrillaRubros();
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

        private void btnModRubro_Click(object sender, EventArgs e)
        {
            if (dgvRubros.SelectedRows.Count > 0)
            {
                btnModRubro.Visible = false;
                btnEliminaRubro.Visible = false;
                dgvRubros.Enabled = false;
                lblRubro.Text = "Modificación del Rubro";
                tbRubro.Text = dgvRubros.CurrentRow.Cells["RUBRO"].Value.ToString();
                Editar = true;
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }


    }
}
