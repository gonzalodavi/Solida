using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaComun.Cache;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormCompras : Form
    {
        private DataTable DTDetalles;
        private double TotIva;
        private double Totales;
        public static int contadorFila = 0;


        public FormCompras()
        {
            InitializeComponent();
        }       

        private void FormCompras_Load(object sender, EventArgs e)
        {
            CrearTabla();
            CargarGrilla();
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

        private void CargarGrilla()
        {
            if (chekVerAnulados.Checked == false)
            {
                this.dgvCompras.DataSource = CN_Compras.Mostrar();
                this.dgvCompras.Columns[0].Visible = false;
            }
            else
            {
                this.dgvCompras.DataSource = CN_Compras.MostrarAnulados();
                this.dgvCompras.Columns[0].Visible = false;
            }
        }

        private void CrearTabla()
        {
            DTDetalles = new DataTable();
            DTDetalles.Columns.Add("PRODUCTO", Type.GetType("System.String"));
            DTDetalles.Columns.Add("CANT", Type.GetType("System.Int32"));
            DTDetalles.Columns.Add("IDPRODUCTO", Type.GetType("System.Int32"));
            DTDetalles.Columns.Add("PRECIO", Type.GetType("System.Decimal"));
            DTDetalles.Columns.Add("IVA", Type.GetType("System.Decimal"));
            DTDetalles.Columns.Add("SUBTOTAL", Type.GetType("System.Decimal"));

            dgvDetComp.DataSource = DTDetalles;
            dgvDetComp.Columns["IDPRODUCTO"].Visible = false;
            
            /*this.dgvDetComp.Columns["CANT"].Width = 25;
            this.dgvDetComp.Columns["PRODUCTO"].Visible = false;
            this.dgvDetComp.Columns["PRECIO"].Width = 50;
            this.dgvDetComp.Columns["IVA"].Width = 50;
            this.dgvDetComp.Columns["SUBTOTAL"].Width = 80;*/
        }

        private void btnBuscaProveedor_Click(object sender, EventArgs e)
        {
            panelProveedores.Enabled = true;
            tabCompras.SelectedTab = tabProveedores;
            CargarGrillaProveedores();
        }        

        private void btnSelProd_Click(object sender, EventArgs e)
        {
            panelProductos.Enabled = true;
            tabCompras.SelectedTab = tabProductos;
            CargarGrillaProductos();
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
            this.dgvProductos.Columns[0].Visible = false;
            this.dgvProductos.Columns[2].Visible = false;
            this.dgvProductos.Columns[4].Visible = false;
            this.dgvProductos.Columns[6].Visible = false;
            this.dgvProductos.Columns[8].Visible = false;

            this.dgvProductos.Columns[5].Width = 80;
            this.dgvProductos.Columns[7].Width = 50;
            this.dgvProductos.Columns[9].Width = 90;
            this.dgvProductos.Columns[10].Width = 90;
        }

        private void dgvProveedor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCuit.Text = dgvProveedor.CurrentRow.Cells[0].Value.ToString();
            tbProveedor.Text = dgvProveedor.CurrentRow.Cells[1].Value.ToString();
            panelProveedores.Enabled = false; 
            tabCompras.SelectedTab = tabNuevaCompra;
            tbBuscaProveedor.Text = "";
        }

        private void dgvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIDprod.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            tbProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            tbIVACompra.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
            tbImporteCompra.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
            panelProductos.Enabled = false;
            tabCompras.SelectedTab = tabNuevaCompra;
            tbBuscaProductos.Text = "";
            tbCantidad.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            tabCompras.SelectedTab = tabNuevaCompra;
        }

        private void limpiarCampos()
        {
            tbProveedor.Text = "";
            tbIDprod.Text = "";            
            tbCuit.Text = "";
            tbNumComp.Text = "";
            tbIDprod.Text = "";
            tbProducto.Text = "";
            tbCantidad.Text = "";
            tbImporteCompra.Text = "";
            tbIVACompra.Text = "";
            tbSubtotal.Text = "";
            tbSubtotalIVA.Text = "";
            tbTotalFact.Text = "";
            tbTotalIVA.Text = "";
            tbDescripcion.Text = "";
        }
        private void LimpiarDatosCarga()
        {
            tbCantidad.Text = "";
            tbProducto.Text = "";
            tbImporteCompra.Text = "";
            tbIVACompra.Text = "";
            tbSubtotal.Text = "";
            tbSubtotalIVA.Text = "";
            tbIDprod.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbCantidad.Text != "" && tbProducto.Text != "")
            {
                bool existe = false;
                int numeroFila = 0;

                if (contadorFila == 0)
                {
                    DataRow row = DTDetalles.NewRow();

                    row["PRODUCTO"] = Convert.ToString(tbProducto.Text);
                    row["CANT"] = Convert.ToInt32(tbCantidad.Text);
                    row["IDPRODUCTO"] = Convert.ToInt32(tbIDprod.Text);
                    row["PRECIO"] = Convert.ToDecimal(tbImporteCompra.Text);
                    row["IVA"] = Convert.ToDecimal(tbSubtotalIVA.Text);
                    row["SUBTOTAL"] = Convert.ToDecimal(tbSubtotal.Text);

                    TotIva += Convert.ToDouble(row["IVA"].ToString());
                    tbTotalIVA.Text = TotIva.ToString("0.00");

                    Totales += Convert.ToDouble(row["SUBTOTAL"].ToString());
                    tbTotalFact.Text = Totales.ToString("0.00");

                    DTDetalles.Rows.Add(row);
                    LimpiarDatosCarga();
                    contadorFila++;
                }
                else
                {
                    foreach (DataGridViewRow Fila in dgvDetComp.Rows)
                    {
                        if (Fila.Cells[2].Value.ToString() == tbIDprod.Text)
                        {
                            existe = true;
                            numeroFila = Fila.Index;
                        }
                    }
                    if (existe == true)
                    {
                        dgvDetComp.Rows[numeroFila].Cells[1].Value = Convert.ToInt32(tbCantidad.Text) + Convert.ToInt32(dgvDetComp.Rows[numeroFila].Cells[1].Value);

                        double importeSubtotal = (Convert.ToDouble(dgvDetComp.Rows[numeroFila].Cells[1].Value)) * (Convert.ToDouble(dgvDetComp.Rows[numeroFila].Cells[3].Value));
                        tbSubtotal.Text = importeSubtotal.ToString("0.00");
                        dgvDetComp.Rows[numeroFila].Cells[5].Value = Convert.ToDecimal(tbSubtotal.Text);

                        double importeIVA = importeSubtotal - (importeSubtotal / (((Convert.ToDouble(tbIVACompra.Text)) / 100) + 1));
                        tbSubtotalIVA.Text = importeIVA.ToString("0.00");
                        dgvDetComp.Rows[numeroFila].Cells[4].Value = Convert.ToDecimal(tbSubtotalIVA.Text);

                        Totales = 0;
                        TotIva = 0;

                        foreach (DataGridViewRow r in dgvDetComp.Rows)
                        {
                            TotIva += Convert.ToDouble(r.Cells["IVA"].Value);
                            Totales += Convert.ToDouble(r.Cells["SUBTOTAL"].Value);
                        }

                        tbTotalFact.Text = Totales.ToString("0.00");
                        tbTotalIVA.Text = TotIva.ToString("0.00");

                        LimpiarDatosCarga();
                    }
                    else
                    {
                        DataRow row = DTDetalles.NewRow();

                        row["PRODUCTO"] = Convert.ToString(tbProducto.Text);
                        row["CANT"] = Convert.ToInt32(tbCantidad.Text);
                        row["IDPRODUCTO"] = Convert.ToInt32(tbIDprod.Text);
                        row["PRECIO"] = Convert.ToDecimal(tbImporteCompra.Text);
                        row["IVA"] = Convert.ToDecimal(tbSubtotalIVA.Text);
                        row["SUBTOTAL"] = Convert.ToDecimal(tbSubtotal.Text);

                        TotIva += Convert.ToDouble(row["IVA"].ToString());
                        tbTotalIVA.Text = TotIva.ToString("0.00");

                        Totales += Convert.ToDouble(row["SUBTOTAL"].ToString());
                        tbTotalFact.Text = Totales.ToString("0.00");

                        DTDetalles.Rows.Add(row);
                        LimpiarDatosCarga();
                        contadorFila++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto de la lista y la cantidad deseada");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDetComp.SelectedRows.Count > 0)
            {
                try
                {
                    int IndiceFila = dgvDetComp.CurrentCell.RowIndex;
                    DataRow row = DTDetalles.Rows[IndiceFila];

                    TotIva -= Convert.ToDouble(row["IVA"].ToString());
                    tbTotalIVA.Text = TotIva.ToString("0.00");

                    Totales -= Convert.ToDouble(row["SUBTOTAL"].ToString());
                    tbTotalFact.Text = Totales.ToString("0.00");

                    DTDetalles.Rows.Remove(row);

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

        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {
            if (tbImporteCompra.Text != "" && tbCantidad.Text != "")
            {
                double importeSubtotal = (Convert.ToDouble(tbCantidad.Text)) * (Convert.ToDouble(tbImporteCompra.Text));
                tbSubtotal.Text = importeSubtotal.ToString("0.00");
                double importeIVA = importeSubtotal - (importeSubtotal / (((Convert.ToDouble(tbIVACompra.Text)) / 100) + 1));
                tbSubtotalIVA.Text = importeIVA.ToString("0.00");
            }
        }

        private void tbImporteCompra_TextChanged(object sender, EventArgs e)
        {
            if (tbCantidad.Text != "" && tbImporteCompra.Text != "")
            {
                double importeSubtotal = (Convert.ToDouble(tbCantidad.Text)) * (Convert.ToDouble(tbImporteCompra.Text));
                tbSubtotal.Text = importeSubtotal.ToString("0.00");
                double importeIVA = importeSubtotal - (importeSubtotal / (((Convert.ToDouble(tbIVACompra.Text)) / 100) + 1));
                tbSubtotalIVA.Text = importeIVA.ToString("0.00");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvDetComp.SelectedRows.Count > 0)
            {
                try
                {
                    string rpta = "";
                    if (this.tbCuit.Text == string.Empty)
                    {
                        MensajeError("Seleccione Un Proveedor");
                    }
                    else
                    {
                        if (this.tbNumComp.Text == string.Empty)
                        {
                            MensajeError("Ingrese Numero de Compra");
                        }
                        else
                        {
                            DialogResult Opcion;
                            Opcion = MessageBox.Show("Desea Generar Nuevo Comprobante?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (Opcion == DialogResult.OK)
                            {
                                string estado = "ACTIVO";
                                rpta = CN_Compras.Insertar(tbNumComp.Text, dtpFecha.Value, estado, tbCuit.Text, Convert.ToInt32(UserLoginCache.UserId), DTDetalles);


                                if (rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Se Generó con éxito el Comprobante");
                                    limpiarCampos();
                                    CargarGrilla();
                                    DTDetalles.Rows.Clear();
                                    tabCompras.SelectedTab = tabListadoCompras;
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
            else
            {
                MensajeError("Agregue un Producto y su Cantidad al Detalle");
            }
        }

        private void chekVerAnulados_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (dgvCompras.SelectedRows.Count > 0)
            {
                if (dgvCompras.CurrentRow.Cells[3].Value.ToString() != "ANULADO")
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("Desea ANULAR el comprobante seleccionado?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        CN_Compras objetoCN = new CN_Compras();
                        int idCompra = Convert.ToInt32(dgvCompras.CurrentRow.Cells[0].Value.ToString());
                        objetoCN.AnularComprobantes(idCompra);

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

        private void btnBuscarReg_Click(object sender, EventArgs e)
        {
            BuscarRegistros();
        }        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void BuscarRegistros()
        {
            if (chekVerAnulados.Checked == false)
            {
                dgvCompras.DataSource = CN_Compras.BuscarRegistros(dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
                this.dgvCompras.Columns[0].Visible = false;
            }
            else
            {
                dgvCompras.DataSource = CN_Compras.BuscarRegistrosAnulados(dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
                this.dgvCompras.Columns[0].Visible = false;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
            if (dgvCompras.SelectedRows.Count > 0)
            {
                FormReporteCompra form = new FormReporteCompra();
                form.IdCompra = Convert.ToInt32(this.dgvCompras.CurrentRow.Cells["ID_COMPRA"].Value);                
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por Favor seleccione un comprobante");
            }
        }

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnBuscaProd_Click(object sender, EventArgs e)
        {
            BuscaProductos();
        }

        private void BuscaProductos()
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
            tbBuscaProductos.Text = "";
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            BuscaProveedores();
        }

        private void BuscaProveedores()
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

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvProductos.Columns[e.ColumnIndex].Name == "STOCK")
            {
                if (Convert.ToInt32(e.Value) <= 10)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.BackColor = Color.Orange;
                }
            }
        }
    }
}
