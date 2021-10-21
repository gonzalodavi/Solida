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
    public partial class ListadoProductos1 : FormBase
    {
        public ListadoProductos1()
        {
            InitializeComponent();
        }

        private void ListadoProductos1_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            CN_Productos objeto = new CN_Productos();
            dgvProductos.DataSource = objeto.MostrarProducto();

            //dgvProductos.Columns[0].Visible = false;
            //dgvProductos.Columns[1].Visible = false;
            dgvProductos.Columns[2].Visible = false;
            dgvProductos.Columns[3].Visible = false;
            dgvProductos.Columns[4].Visible = false;
            dgvProductos.Columns[5].Visible = false;
            dgvProductos.Columns[6].Visible = false;
            //dgvProductos.Columns[7].Visible = false;
            dgvProductos.Columns[8].Visible = false;
            dgvProductos.Columns[9].Visible = false;
            dgvProductos.Columns[10].Visible = false;
        }

        private void dgvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormRemitos datos = Owner as FormRemitos;
            datos.tbIDProducto.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            datos.tbProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            Close();
        }

        private void btnActualizaLista_Click(object sender, EventArgs e)
        {
            CargarGrilla();
            tbBusca.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarProductos();
        }

        private void buscarProductos()
        {
            if (tbBusca.Text == "")
            {
                CargarGrilla();
                MessageBox.Show("Para Buscar un producto debe ingresar su codigo de barras o su Nombre");
            }
            else
            {
                CN_Productos objetob = new CN_Productos();
                dgvProductos.DataSource = objetob.BuscarProductos(tbBusca.Text);
                if (dgvProductos.SelectedRows.Count < 1)
                {
                    CN_Productos objetoa = new CN_Productos();
                    dgvProductos.DataSource = objetoa.BuscarProductosNom(tbBusca.Text);
                    if (dgvProductos.SelectedRows.Count < 1)
                    {                        
                        MessageBox.Show("No existen registros");
                    }
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
