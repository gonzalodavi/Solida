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
    public partial class FormInfoProductos : Form
    {

        CN_Productos objeto = new CN_Productos();

        public FormInfoProductos()
        {
            InitializeComponent();            
        }

        private void FormInfoProductos_Load(object sender, EventArgs e)
        {
            CargarComboBoxRubros();
            CargarGrilla();
            CargarCantidades();
        }

        private void CargarCantidades()
        {
            if (dgvProductos.Rows.Count > 0)
            {
                try
                {
                    int rubros = CN_Productos.CantidadRubros();
                    int productos = CN_Productos.CantidadProductos();
                    tbCantProd.Text = productos.ToString();
                    tbCantRubros.Text = rubros.ToString();
                }
                catch (Exception ex)
                {
                    MensajeError("No se pudo ejecutar la operacion:\n\n" + ex);
                }
            }
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


        private void CargarComboBoxRubros()
        {
            cbRubro.DataSource = objeto.CargaComboBoxRubro();
            cbRubro.DisplayMember = "RUBRO";
            cbRubro.ValueMember = "ID";
            cbRubro.SelectedIndex = -1;            
        }

        private void CargarGrilla()
        {
            if (chekRubro.Checked == false)
            {
                CN_Productos objeto = new CN_Productos();
                dgvProductos.DataSource = objeto.MostrarProducto();
                AcomodaTabla();
            }
            else
            {
                if (cbRubro.SelectedIndex != -1)
                {
                    CN_Productos objeto = new CN_Productos();
                    dgvProductos.DataSource = objeto.MostrarProductoRubros(Convert.ToInt32(cbRubro.SelectedValue));
                    AcomodaTabla();
                }
                else
                {
                    this.MensajeError("Seleccione un Rubro para Actualizar Lista");
                }                
            }
        }

        private void AcomodaTabla()
        {
            //dgvProductos.Columns[0].Visible = false;
            //dgvProductos.Columns[1].Visible = false;
            //dgvProductos.Columns[2].Visible = false;
            dgvProductos.Columns[3].Visible = false;
            //dgvProductos.Columns[4].Visible = false;
            dgvProductos.Columns[5].Visible = false;
            //dgvProductos.Columns[6].Visible = false;
            //dgvProductos.Columns[7].Visible = false;
            //dgvProductos.Columns[8].Visible = false;
            dgvProductos.Columns[9].Visible = false;
            //dgvProductos.Columns[10].Visible = false;
            //dgvProductos.Columns[11].Visible = false;
            dgvProductos.Columns[12].Visible = false;

            this.dgvProductos.Columns[0].Width = 40;
            this.dgvProductos.Columns[1].Width = 150;
            this.dgvProductos.Columns[2].Width = 30;
            this.dgvProductos.Columns[4].Width = 150;
            this.dgvProductos.Columns[5].Width = 100;
            this.dgvProductos.Columns[6].Width = 70;
            this.dgvProductos.Columns[7].Width = 70;
            this.dgvProductos.Columns[8].Width = 40;
            this.dgvProductos.Columns[10].Width = 100;
            this.dgvProductos.Columns[11].Width = 100;
        }

        private void chekRubro_CheckedChanged(object sender, EventArgs e)
        {
            tbBusca.Text = "";
            if(chekRubro.Checked == true)
            {
                cbRubro.SelectedIndex = -1;
                cbRubro.Enabled = true;
            }
            else
            {
                cbRubro.SelectedIndex = -1;
                cbRubro.Enabled = false;
                CargarGrilla();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(chekRubro.Checked == true)
            {
                BuscarProductosPorRubro();
            }
            else
            {
                BuscarProductos();
            }
        }

        private void BuscarProductosPorRubro()
        {
            if(cbRubro.SelectedIndex != -1)
            {
                try
                {
                    if (tbBusca.Text == "")
                    {
                        CargarGrilla();
                        this.MensajeError("Para Buscar un producto debe ingresar su codigo de barras o su Nombre");
                    }
                    else
                    {
                        CN_Productos objetob = new CN_Productos();
                        dgvProductos.DataSource = objetob.BuscarProductosxRubro(tbBusca.Text, Convert.ToInt32(cbRubro.SelectedValue));
                        AcomodaTabla();

                        if (dgvProductos.SelectedRows.Count < 1)
                        {
                            CN_Productos objetoa = new CN_Productos();
                            dgvProductos.DataSource = objetoa.BuscarProductosNomxRubro(tbBusca.Text, Convert.ToInt32(cbRubro.SelectedValue));
                            AcomodaTabla();

                            /*if (dgvProductos.SelectedRows.Count < 1)
                            {
                                CargarGrilla();
                                MessageBox.Show("No existen registros");
                            }        */
                        }
                    }

                }
                catch (Exception ex)
                {
                    MensajeError("No se pudo ejecutar la operacion:\n\n" + ex);
                }
            }
            else
            {
                this.MensajeError("Seleccione un Rubro");
            }
        }

        private void BuscarProductos()
        {
            try
            {
                if (tbBusca.Text == "")
                {
                    CargarGrilla();
                    this.MensajeError("Para Buscar un producto debe ingresar su codigo de barras o su Nombre");
                }
                else
                {
                    CN_Productos objetob = new CN_Productos();
                    dgvProductos.DataSource = objetob.BuscarProductos(tbBusca.Text);
                    AcomodaTabla();

                    if (dgvProductos.SelectedRows.Count < 1)
                    {
                        CN_Productos objetoa = new CN_Productos();
                        dgvProductos.DataSource = objetoa.BuscarProductosNom(tbBusca.Text);
                        AcomodaTabla();

                        /*if (dgvProductos.SelectedRows.Count < 1)
                        {
                            CargarGrilla();
                            MessageBox.Show("No existen registros");
                        }        */
                    }
                }
            }
            catch (Exception ex)
            {
                MensajeError("No se pudo ejecutar la operacion:\n\n" + ex);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizaListaProd_Click(object sender, EventArgs e)
        {
            tbBusca.Text = "";
            CargarGrilla();
        }

        private void cbRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRubro.SelectedIndex != -1)
            {
                CargarGrilla();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FormReporteProductos form = new FormReporteProductos();
            form.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            tbBusca.Text = "";
            CargarGrilla();
        }

        private void chekCLASIFICA_CheckedChanged(object sender, EventArgs e)
        {
            if (chekCLASIFICA.Checked == true)
            {
                dgvProductos.ClearSelection();
                

                foreach (DataGridViewRow MyRow in dgvProductos.Rows)
                {
                    if (Convert.ToDecimal(MyRow.Cells[8].Value) <= Convert.ToDecimal(MyRow.Cells[9].Value))
                    {
                        MyRow.DefaultCellStyle.BackColor = Color.Orange;
                        MyRow.DefaultCellStyle.ForeColor = Color.DarkRed;
                    }
                }
            }
            else
            {
               
                foreach (DataGridViewRow MyRow in dgvProductos.Rows)
                {
                    MyRow.DefaultCellStyle.BackColor = Color.FromArgb(12, 52, 119);
                    MyRow.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
    }
}
