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
    public partial class ListaProveedores1 : FormBase
    {
        CN_Proveedores objeto = new CN_Proveedores();
        public ListaProveedores1()
        {
            InitializeComponent();
        }

        private void ListaProveedores1_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            CN_Proveedor objeto = new CN_Proveedor();
            dgvProveedor.DataSource = objeto.MostrarProveedor();

            dgvProveedor.Columns[4].Visible = false;
            dgvProveedor.Columns[5].Visible = false;
            dgvProveedor.Columns[6].Visible = false;
            dgvProveedor.Columns[7].Visible = false;
            dgvProveedor.Columns[8].Visible = false;
            dgvProveedor.Columns[9].Visible = false;
            dgvProveedor.Columns[10].Visible = false;
            dgvProveedor.Columns[11].Visible = false;
            dgvProveedor.Columns[12].Visible = false;
            dgvProveedor.Columns[13].Visible = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProveedor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormRemitos datosRemito = Owner as FormRemitos;
            datosRemito.tbIdDestinatario.Text = dgvProveedor.CurrentRow.Cells[0].Value.ToString();
            datosRemito.tbDestinatario.Text = dgvProveedor.CurrentRow.Cells[1].Value.ToString();            
            Close();
        }

        private void buscarProveedor()
        {
            if (tbBusca.Text == "")
            {
                CargarGrilla();
                MessageBox.Show("Para Buscar un proveedor debe ingresar su CUIT o Nombre de Empresa");
            }
            else
            {
                CN_Proveedor objetob = new CN_Proveedor();
                dgvProveedor.DataSource = objetob.BuscarProveedor(tbBusca.Text);
                if (dgvProveedor.SelectedRows.Count < 1)
                {
                    CN_Proveedor objA = new CN_Proveedor();
                    dgvProveedor.DataSource = objetob.BuscarProveedorCuit(tbBusca.Text);
                    if (dgvProveedor.SelectedRows.Count < 1)
                    {
                        MessageBox.Show("No existen registros");
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarProveedor();
        }

        private void btnActualizaLista_Click(object sender, EventArgs e)
        {
            CargarGrilla();
            tbBusca.Text = "";
        }
    }
}
