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
            AcomodaTabla();
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
        
        private void CargarGrillaRubros()
        {
            dgvRubros.DataSource = objeto.CargarRubros();
            //dgvRubros.Columns[0].Visible = false;            
        }

        private void AcomodaTabla()
        {
            this.dgvRubros.Columns[0].Width = 70;
        }

        private void DeshabilitarEdicion()
        {
            btnModRubro.Enabled = true;
            btnEliminaRubro.Enabled = true;
            btnNuevo.Enabled = true;
            dgvRubros.Enabled = true;
            lblRubro.Text = "";
            tbRubro.Enabled = false;
            Editar = false;
            tbRubro.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnAceptaRubro_Click(object sender, EventArgs e)
        {
            if (tbRubro.Text != "")
            {
                try
                {
                    string rpta = CN_Tablas.ConsultaRubroExiste(this.tbRubro.Text.Trim());
                    if (rpta == "OK")
                    {
                        MensajeError("Ya existe un Rubro con ese Nombre");
                    }
                    else
                    {
                        if (rpta == "NO")
                        {
                            if (Editar == false)
                            {
                                if (MessageBox.Show("¿Desea Registrar el Rubro?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    objeto.NuevoRubro(tbRubro.Text);
                                    MessageBox.Show("Nuevo Rubro Agregado");
                                    DeshabilitarEdicion();
                                    CargarGrillaRubros();
                                    AcomodaTabla();
                                }                                
                            }
                            else
                            {
                                if (MessageBox.Show("¿Desea Modificar el Rubro Seleccionado?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    string idRubro = dgvRubros.CurrentRow.Cells["ID"].Value.ToString();
                                    objeto.ModificarRubro(tbRubro.Text, idRubro);
                                    MessageBox.Show("Se Modificaron los datos del Rubro");
                                    DeshabilitarEdicion();
                                    CargarGrillaRubros();
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
                MessageBox.Show("El Nombre del Rubro esta vacío");
            }
        }


        private void btnCancelaRubro_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Desea Cancelar la Operación?", "¡Atencion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            try
            {
                if (Opcion == DialogResult.OK)
                {
                    DeshabilitarEdicion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnModRubro.Enabled = false;
            btnEliminaRubro.Enabled = false;
            btnNuevo.Enabled = false;
            dgvRubros.Enabled = false;
            lblRubro.Text = "Nuevo Rubro";
            tbRubro.Enabled = true;
            tbRubro.Text = "";
            tbRubro.Focus();
        }

        private void btnModRubro_Click(object sender, EventArgs e)
        {
            if (dgvRubros.SelectedRows.Count > 0)
            {
                btnModRubro.Enabled = false;
                btnEliminaRubro.Enabled = false;
                btnNuevo.Enabled = false;
                dgvRubros.Enabled = false;
                lblRubro.Text = "Modificar Rubro";
                tbRubro.Enabled = true;
                tbRubro.Text = dgvRubros.CurrentRow.Cells["RUBRO"].Value.ToString();
                Editar = true;
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
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
