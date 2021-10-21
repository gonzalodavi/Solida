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
using CapaComun.Cache;


namespace CapaPresentacion
{
    public partial class FormRemitos : FormBase
    {
        private DataTable DTDetallesRemito;


        public FormRemitos()
        {
            InitializeComponent();
        }

        private void FormRemitos_Load(object sender, EventArgs e)
        {
            CrearTabla();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            if (chekVerAnulados.Checked == false)
            {
                this.dgvRemitos.DataSource = CN_Remito.Mostrar();
                this.dgvRemitos.Columns[0].Visible = false;
            }
            else
            {
                this.dgvRemitos.DataSource = CN_Remito.MostrarAnulados();
                this.dgvRemitos.Columns[0].Visible = false;
            }            
            
        }

        private void CargarGrillaProveedores()
        {
            this.dgvProveedor.DataSource = CN_Proveedor.Mostrar();
            this.dgvProveedor.Columns[6].Visible = false;
            this.dgvProveedor.Columns[7].Visible = false;
        }
        

        private void CargarGrillaProductos()
        {
            CN_Productos obj = new CN_Productos();
            this.dgvProductos.DataSource = obj.MostrarProducto();
            
            //this.dgvProveedor.Columns[6].Visible = false;
            //this.dgvProveedor.Columns[7].Visible = false;
        }

        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SOLIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ResetRemito()
        {
            DTDetallesRemito.Rows.Clear();
            LimpiarCamposProductos();
            LimpiarEncabezadoRemito();
        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SOLIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CrearTabla()
        {
            this.DTDetallesRemito = new DataTable("Detalle");
            this.DTDetallesRemito.Columns.Add("ID_PRODUCTO", Type.GetType("System.Int32"));
            this.DTDetallesRemito.Columns.Add("PRODUCTO", Type.GetType("System.String"));
            this.DTDetallesRemito.Columns.Add("CANTIDAD", Type.GetType("System.Int32"));
            


            dgvDetRem.DataSource = DTDetallesRemito;

            //dgvDetRem.Columns["ID_PRODUCTO"].Visible = false;
            //dgvDetRem.Columns["ID"].Width = 80;
            //dgvDetRem.Columns["CANTIDAD"].Width = 90;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarPC_Click(object sender, EventArgs e)
        {
            panelProveedores.Enabled = true;
            tabRemitos.SelectedTab = tabProveedores;
            CargarGrillaProveedores();
        }

        private void btnBuscaProducto_Click(object sender, EventArgs e)
        {
            panelProductos.Enabled = true;
            tabRemitos.SelectedTab = tabProductos;
            CargarGrillaProductos();
            OcultarColumnas();
        }

        private void OcultarColumnas()
        {
            this.dgvProductos.Columns[0].Visible = false;
            this.dgvProductos.Columns[2].Visible = false;
            this.dgvProductos.Columns[4].Visible = false;
            this.dgvProductos.Columns[5].Visible = false;
            this.dgvProductos.Columns[6].Visible = false;
            this.dgvProductos.Columns[8].Visible = false;
        }

        public static int contadorFila = 0;

        private void btnAgrega_Click(object sender, EventArgs e)
        {
            if (tbCantidad.Text != "" && tbProducto.Text != "<= SELECCIONE PRODUCTO")
            {
                bool existe = false;
                int numeroFila = 0;

                if (contadorFila == 0)
                {
                    DataRow row = DTDetallesRemito.NewRow();

                    row["ID_PRODUCTO"] = Convert.ToInt32(tbIDProducto.Text);
                    row["PRODUCTO"] = Convert.ToString(tbProducto.Text);
                    row["CANTIDAD"] = Convert.ToInt32(tbCantidad.Text);
                    //dgvDetRem.Columns[3].Visible = false;

                    DTDetallesRemito.Rows.Add(row);
                    LimpiarCamposProductos();
                    contadorFila++;
                }
                else
                {
                    foreach (DataGridViewRow Fila in dgvDetRem.Rows)
                    {
                        if (Fila.Cells[1].Value.ToString() == tbProducto.Text)
                        {
                            existe = true;
                            numeroFila = Fila.Index;
                        }
                    }
                    if (existe == true)
                    {
                        dgvDetRem.Rows[numeroFila].Cells[2].Value = Convert.ToInt32(tbCantidad.Text) + Convert.ToInt32(dgvDetRem.Rows[numeroFila].Cells[2].Value);
                        LimpiarCamposProductos();
                    }
                    else
                    {
                        DataRow row = DTDetallesRemito.NewRow();

                        row["ID_PRODUCTO"] = Convert.ToInt32(tbIDProducto.Text);
                        row["PRODUCTO"] = Convert.ToString(tbProducto.Text);
                        row["CANTIDAD"] = Convert.ToInt32(tbCantidad.Text);

                        DTDetallesRemito.Rows.Add(row);
                        LimpiarCamposProductos();
                        contadorFila++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto de la lista y la cantidad deseada");
            }
        }

        private void LimpiarCamposProductos()
        {
            tbCantidad.Text = "";
            tbIDProducto.Text = "";
            tbProducto.Text = "<= SELECCIONE PRODUCTO";
        }
        private void LimpiarEncabezadoRemito()
        {
            tbDestinatario.Text = "<= SELECCIONE PROVEEDOR";
            tbNumRemito.Text = "";
            tbIdDestinatario.Text = "";
            rbEntrada.Checked = false;
            rbSalida.Checked = false;
            dtpFecha.Value = DateTime.Now;
        }


        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetRem.SelectedRows.Count > 0)
            {
                try
                {
                    int IndiceFila = dgvDetRem.CurrentCell.RowIndex;
                    DataRow row = DTDetallesRemito.Rows[IndiceFila];

                    DTDetallesRemito.Rows.Remove(row);

                    MessageBox.Show("Se elimino el producto del detalle");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar los datos por:\n\n" + ex);
                }
            }
            else
            {
                MessageBox.Show("No existen productos cargados");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvDetRem.SelectedRows.Count > 0)
            {
                if (rbEntrada.Checked == false && rbSalida.Checked == false)
                {
                    MensajeError("Seleccione Tipo de Remito (ENTRADA / SALIDA)");
                }
                else
                {
                    try
                    {
                        string rpta = "";
                        if (this.tbIdDestinatario.Text == string.Empty)
                        {
                            MensajeError("Seleccione Un Proveedor");
                        }
                        else
                        {
                            if (this.tbNumRemito.Text == string.Empty)
                            {
                                MensajeError("Ingrese Numero de Remito");
                            }
                            else
                            {
                                DialogResult Opcion;
                                Opcion = MessageBox.Show("Desea Generar Nuevo Comprobante?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (Opcion == DialogResult.OK)
                                {
                                    string tiporemito;
                                    if (rbEntrada.Checked == true)
                                    {
                                        tiporemito = "ENTRADA";
                                    }
                                    else
                                    {
                                        tiporemito = "SALIDA";
                                    }

                                    string estado = "ACTIVO";
                                    rpta = CN_Remito.Insertar(tiporemito, tbNumRemito.Text, tbIdDestinatario.Text, Convert.ToInt32(UserLoginCache.UserId), dtpFecha.Value,estado, DTDetallesRemito);


                                    if (rpta.Equals("OK"))
                                    {
                                        this.MensajeOk("Se Generó con éxito el Comprobante");

                                        ResetRemito();
                                        CargarGrilla();
                                        tabRemitos.SelectedTab = tabListadoRemitos;
                                    }
                                    else
                                    {
                                        this.MensajeError(rpta);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
            }
            else
            {
                MensajeError("Agregue un Producto y su Cantidad al Detalle");
            }

        }

        private void dgvProveedor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIdDestinatario.Text = dgvProveedor.CurrentRow.Cells["CUIT"].Value.ToString();
            tbDestinatario.Text = dgvProveedor.CurrentRow.Cells["EMPRESA"].Value.ToString()+" - "+ dgvProveedor.CurrentRow.Cells["APELLIDO"].Value.ToString() + ", " + dgvProveedor.CurrentRow.Cells["NOMBRE"].Value.ToString();
            tabRemitos.SelectedTab = tabRemito;
            panelProveedores.Enabled = false;
        }     

       

        private void dgvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIDProducto.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            tbProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            tabRemitos.SelectedTab = tabRemito;
            panelProveedores.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabRemitos.SelectedTab = tabRemito;
        }

        private void btnBuscarReg_Click(object sender, EventArgs e)
        {
            BuscarRegistros();
        }

        private void BuscarRegistros()
        {
            if (chekVerAnulados.Checked == false)
            {
                dgvRemitos.DataSource = CN_Remito.BuscarRegistros(dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
                this.dgvRemitos.Columns[0].Visible = false;
            }
            else
            {
                dgvRemitos.DataSource = CN_Remito.BuscarRegistrosAnulados(dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
                this.dgvRemitos.Columns[0].Visible = false;
            }
                
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (dgvRemitos.SelectedRows.Count > 0)
            {
                if(dgvRemitos.CurrentRow.Cells[6].Value.ToString()!= "ANULADO")
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("Desea ANULAR el comprobante seleccionado?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        CN_Remito objetoCN = new CN_Remito();
                        int idRemito = Convert.ToInt32(dgvRemitos.CurrentRow.Cells[0].Value.ToString());
                        string tipoRemito = dgvRemitos.CurrentRow.Cells[2].Value.ToString();
                        if (tipoRemito == "ENTRADA")
                        {
                            objetoCN.AnularComprobanteEntrada(idRemito, tipoRemito);
                        }
                        else
                        {
                            objetoCN.AnularComprobanteSalida(idRemito, tipoRemito);
                        }
                        MessageBox.Show("El Comprobante se ANULÓ CORRECTAMENTE");
                        CargarGrilla();
                    }
                }
                else
                {
                    MensajeError("EL COMPROBANTE SELECCIONADO SE ENCUENTRA ANULADO");
                }
                
            }
            else
            {
                MessageBox.Show("Por Favor seleccione un comprobante");
            }
        }

        private void chekVerAnuladas_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvRemitos.SelectedRows.Count > 0)
            {
                FormReporteRemito form = new FormReporteRemito();
                form.IdRemito = Convert.ToInt32(this.dgvRemitos.CurrentRow.Cells["ID_REMITO"].Value);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por Favor seleccione un comprobante");
            }
        }

        private void btnBuscaProd_Click(object sender, EventArgs e)
        {
            BuscarProductos();
        }

        private void BuscarProductos()
        {
            if (tbBuscaProductos.Text == "")
            {
                CargarGrilla();
                MessageBox.Show("Para Buscar un producto debe ingresar su codigo de barras o su Nombre");
            }
            else
            {
                CN_Productos objetob = new CN_Productos();
                dgvProductos.DataSource = objetob.BuscarProductos(tbBuscaProductos.Text);
                if (dgvProductos.SelectedRows.Count < 1)
                {
                    CN_Productos objetoa = new CN_Productos();
                    dgvProductos.DataSource = objetoa.BuscarProductosNom(tbBuscaProductos.Text);
                    /*if (dgvProductos.SelectedRows.Count < 1)
                    {
                        CargarGrilla();
                        MessageBox.Show("No existen registros");
                    }        */
                }
            }
        }

        private void btnActualizaListaProd_Click(object sender, EventArgs e)
        {
            CargarGrillaProductos();
            btnBuscaProd.Text = "";
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            BuscarProveedores();
        }

        private void BuscarProveedores()
        {
            if (tbBuscaProveedor.Text == "")
            {
                CargarGrilla();
                MessageBox.Show("Para Buscar un proveedor debe ingresar su CUIT o Nombre de Empresa");
            }
            else
            {
                CN_Proveedor objetob = new CN_Proveedor();
                dgvProveedor.DataSource = objetob.BuscarProveedor(tbBuscaProveedor.Text);
                if (dgvProveedor.SelectedRows.Count < 1)
                {
                    CN_Proveedor objA = new CN_Proveedor();
                    dgvProveedor.DataSource = objetob.BuscarProveedorCuit(tbBuscaProveedor.Text);
                    if (dgvProveedor.SelectedRows.Count < 1)
                    {
                        MessageBox.Show("No existen registros");
                    }
                }
            }
        }

        private void btnActualizaListaProv_Click(object sender, EventArgs e)
        {
            CargarGrillaProveedores();
            tbBuscaProveedor.Text = "";
        }
    }
}
