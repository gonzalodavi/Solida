using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormTablas : Form
    {
        private bool Editar = false;        
        CN_Tablas objeto = new CN_Tablas();

        public FormTablas()
        {
            InitializeComponent();
        }

        private void FormRubros_Load(object sender, EventArgs e)
        {
            CargarGrillaRubros();
            CargarGrillaAlicuotas();
            CargarGrillaMarcas();
            CargarGrillaModelos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarGrillaRubros()
        {
            dgvRubros.DataSource = objeto.CargarRubros();
            //dgvRubros.Columns[0].Visible = false;
            dgvRubros.Columns[0].Width = 30;
        }

        private void CargarGrillaAlicuotas()
        {
            dgvAlicuota.DataSource = objeto.CargarAlicuotas();
            //dgvAlicuota.Columns[0].Visible = false;
           // dgvAlicuota.Columns[0].Width = 30;
        }

        private void CargarGrillaMarcas()
        {
            dgvMarca.DataSource = objeto.CargarMarcas();
            //dgvMarca.Columns[0].Visible = false;
            //dgvMarca.Columns[0].Width = 30;
        }

        private void CargarGrillaModelos()
        {
            dgvModelo.DataSource = objeto.CargarModelos();
            //dgvModelo.Columns[0].Visible = false;
            
           // dgvModelo.Columns[0].Width = 30;
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

        private void btnModAlic_Click(object sender, EventArgs e)
        {
            if (dgvAlicuota.SelectedRows.Count > 0)
            {
                btnModAlic.Visible = false;
                btnEliminaAlic.Visible = false;
                dgvAlicuota.Enabled = false;
                lblAlicuota.Text = "Modificación de Alicuota IVA";
                tbAlic.Text = dgvAlicuota.CurrentRow.Cells["ALICUOTA"].Value.ToString();
                Editar = true;
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
                btnModMarca.Visible = false;
                btnEliminaMarca.Visible = false;
                dgvMarca.Enabled = false;
                lblMarca.Text = "Modificación de la Marca";
                tbMarca.Text = dgvMarca.CurrentRow.Cells["MARCA"].Value.ToString();
                Editar = true;
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnModModelo_Click(object sender, EventArgs e)
        {
            if (dgvModelo.SelectedRows.Count > 0)
            {
                btnModModelo.Visible = false;
                btnEliminaModelo.Visible = false;
                dgvModelo.Enabled = false;
                lblModelo.Text = "Modificación del Modelo";
                tbModelo.Text = dgvModelo.CurrentRow.Cells["MODELO"].Value.ToString();
                Editar = true;
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnCancelaRubro_Click(object sender, EventArgs e)
        {
            reiniciaRubros();
        }

        private void btnCancelaAlic_Click(object sender, EventArgs e)
        {
            reiniciaAlicuotas();
        }

        private void btnCancelaMarca_Click(object sender, EventArgs e)
        {
            reiniciaMarcas();
        }

        private void btnCancelaModelo_Click(object sender, EventArgs e)
        {
            reiniciaModelos();
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

        private void btnAceptaAlic_Click(object sender, EventArgs e)
        {
            if (tbAlic.Text != "")
            {
                if (Editar == false)
                {
                    if (MessageBox.Show("¿Desea Registrar Alicuota?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            objeto.NuevaAlicuota(tbAlic.Text);
                            MessageBox.Show("Nuevo Valor de Alicuota agregado");
                            Editar = false;
                            CargarGrillaAlicuotas();
                            tbAlic.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se puedo realizar el ingreso de datos debido a: \n\n" + ex);
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("¿Desea Modificar el Valor de Alicuota seleccionado?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            string idAlic = dgvAlicuota.CurrentRow.Cells["ID"].Value.ToString();
                            objeto.ModificarAlicuota(tbAlic.Text, idAlic);
                            MessageBox.Show("Se Modificaron los datos de Alicuota IVA");
                            Editar = false;
                            CargarGrillaAlicuotas();
                            dgvAlicuota.Enabled = true;
                            tbAlic.Text = "";
                            btnModAlic.Visible = true;
                            btnEliminaAlic.Visible = true;
                            lblAlicuota.Text = "Ingrese Nueva Valor Alicuota";
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
                MessageBox.Show("El valor de Alicuota esta vacío");
            }
        }

        private void btnAceptaMarca_Click(object sender, EventArgs e)
        {
            if (tbMarca.Text != "")
            {
                if (Editar == false)
                {
                    if (MessageBox.Show("¿Desea Registrar la Marca?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            objeto.NuevaMarca(tbMarca.Text);
                            MessageBox.Show("Nueva Marca Agregada");
                            Editar = false;
                            CargarGrillaMarcas();
                            tbMarca.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se puedo realizar el ingreso de datos debido a: \n\n" + ex);
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("¿Desea Modificar la Marca seleccionada?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            string idMarca = dgvMarca.CurrentRow.Cells["ID"].Value.ToString();
                            objeto.ModificarMarca(tbMarca.Text, idMarca);
                            MessageBox.Show("Se Modificaron los datos de la Marca");
                            Editar = false;
                            CargarGrillaMarcas();
                            dgvMarca.Enabled = true;
                            tbMarca.Text = "";
                            btnModMarca.Visible = true;
                            btnEliminaMarca.Visible = true;
                            lblMarca.Text = "Ingrese Nueva Marca";
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
                MessageBox.Show("El Nombre de la Marca esta vacía");
            }
        }

        private void btnAceptaModelo_Click(object sender, EventArgs e)
        {
            if (tbModelo.Text != "")
            {
                if (Editar == false)
                {
                    if (MessageBox.Show("¿Desea Registrar el Modelo?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            objeto.NuevoModelo(tbModelo.Text);
                            MessageBox.Show("Nuevo Modelo Agregado");
                            Editar = false;
                            CargarGrillaModelos();
                            tbModelo.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se puedo realizar el ingreso de datos debido a: \n\n" + ex);
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("¿Desea Modificar el Modelo Seleccionado?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            string idModelo = dgvModelo.CurrentRow.Cells["ID"].Value.ToString();
                            objeto.ModificarModelo(tbModelo.Text, idModelo);
                            MessageBox.Show("Se Modificaron los datos del Modelo");
                            Editar = false;
                            CargarGrillaModelos();
                            dgvModelo.Enabled = true;
                            tbModelo.Text = "";
                            btnModModelo.Visible = true;
                            btnEliminaModelo.Visible = true;
                            lblModelo.Text = "Ingrese Nuevo Modelo";
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
                MessageBox.Show("El Nombre del Modelo esta vacío");
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

        private void btnEliminaAlic_Click(object sender, EventArgs e)
        {
            if (dgvAlicuota.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Desea Eliminar la Alicuota seleccionada?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        string idAlic = dgvAlicuota.CurrentRow.Cells["ID"].Value.ToString();
                        objeto.EliminarAlicuota(idAlic);
                        MessageBox.Show("Se eliminó correctamente la Alicuota de IVA");
                        CargarGrillaAlicuotas();
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

        private void btnEliminaModelo_Click(object sender, EventArgs e)
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

        private void reiniciaRubros()
        {
            btnModRubro.Visible = true;
            btnEliminaRubro.Visible = true;
            dgvRubros.Enabled = true;
            lblRubro.Text = "Ingrese Nuevo Rubro";
            Editar = false;
            tbRubro.Text = "";
        }

        private void reiniciaAlicuotas()
        {
            btnModAlic.Visible = true;
            btnEliminaAlic.Visible = true;
            dgvAlicuota.Enabled = true;
            lblAlicuota.Text = "Ingrese Nueva Alicuota IVA";
            Editar = false;
            tbAlic.Text = "";
        }

        private void reiniciaMarcas()
        {
            btnModMarca.Visible = true;
            btnEliminaMarca.Visible = true;
            dgvMarca.Enabled = true;
            lblMarca.Text = "Ingrese Nueva Marca";
            Editar = false;
            tbMarca.Text = "";
        }

        private void reiniciaModelos()
        {
            btnModModelo.Visible = true;
            btnEliminaModelo.Visible = true;
            dgvModelo.Enabled = true;
            lblModelo.Text = "Ingrese Nuevo Modelo";
            Editar = false;
            tbModelo.Text = "";
        }

        private void tbAlic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
