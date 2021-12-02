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
        CN_Compras objeto = new CN_Compras();

        private DataTable DTDetalles;
        private decimal TotIva;
        private decimal Totales;
        public static int contadorFila = 0;
        private string comprobte;


        public FormCompras()
        {
            InitializeComponent();
        }       

        private void FormCompras_Load(object sender, EventArgs e)
        {
            fechaHoy();
            CrearTabla();
            CargarGrilla();
            BuscarUltimaCompra();
        }

        private void BuscarUltimaCompra()
        {
            int numFact = objeto.MostrarUltimaCompra();
            tbNumComp.Text = (numFact + 1).ToString();
        }

        private void fechaHoy()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;            
            dtpFecha1.Value = new DateTime(year, month, 1);
            dtpFecha2.Value = DateTime.Now;
            dtpFecha.Value = DateTime.Now;
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
            DTDetalles.Columns.Add("CANT", Type.GetType("System.Decimal"));
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

            this.dgvProveedor.Columns[0].Width = 80;
            this.dgvProveedor.Columns[1].Width = 100;
            this.dgvProveedor.Columns[2].Width = 90;
            this.dgvProveedor.Columns[3].Width = 90;
            this.dgvProveedor.Columns[4].Width = 150;
            this.dgvProveedor.Columns[5].Width = 110;
        }

        private void CargarGrillaProductos()
        {
            CN_Productos obj = new CN_Productos();
            this.dgvProductos.DataSource = obj.MostrarProducto();

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

        private void dgvProveedor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCuit.Text = dgvProveedor.CurrentRow.Cells[0].Value.ToString();
            tbProveedor.Text = dgvProveedor.CurrentRow.Cells[1].Value.ToString();
            this.dgvProveedor.Columns.Clear();
            panelProveedores.Enabled = false; 
            tabCompras.SelectedTab = tabNuevaCompra;
            tbBuscaProveedor.Text = "";

        }

        private void dgvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIDprod.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            tbProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            tbIVACompra.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
            tbImporteCompra.Text = dgvProductos.CurrentRow.Cells[6].Value.ToString();
            this.dgvProductos.Columns.Clear();
            panelProductos.Enabled = false;
            tabCompras.SelectedTab = tabNuevaCompra;
            tbBuscaProductos.Text = "";
            tbCantidad.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            BuscarUltimaCompra();
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
            this.dgvProveedor.Columns.Clear();
            this.dgvProductos.Columns.Clear();

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
            this.dgvProductos.Columns.Clear();
            this.dgvProveedor.Columns.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbCantidad.Text != "" && tbCantidad.Text != "0" && tbCantidad.Text != "0," && tbCantidad.Text != "," && tbCantidad.Text != "0,0" && tbCantidad.Text != "0,00")
            {
                if(tbProducto.Text != "")
                {
                    InsertarEnDetalle();
                }
                else
                {
                    this.MensajeError("Por favor, seleccione un producto de la lista");
                }
            }
            else
            {
                this.MensajeError("La cantidad debe ser mayor a 0");
            }            
        }

        private void InsertarEnDetalle()
        {
            bool existe = false;
            int numeroFila = 0;

            if (contadorFila == 0)
            {
                DataRow row = DTDetalles.NewRow();

                row["PRODUCTO"] = Convert.ToString(tbProducto.Text);
                row["CANT"] = Convert.ToDecimal(tbCantidad.Text);
                row["IDPRODUCTO"] = Convert.ToInt32(tbIDprod.Text);
                row["PRECIO"] = Convert.ToDecimal(tbImporteCompra.Text);
                row["IVA"] = Convert.ToDecimal(tbSubtotalIVA.Text);
                row["SUBTOTAL"] = Convert.ToDecimal(tbSubtotal.Text);

                TotIva += Convert.ToDecimal(row["IVA"].ToString());
                tbTotalIVA.Text = TotIva.ToString("0.00");

                Totales += Convert.ToDecimal(row["SUBTOTAL"].ToString());
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
                    dgvDetComp.Rows[numeroFila].Cells[1].Value = Convert.ToDecimal(tbCantidad.Text) + Convert.ToDecimal(dgvDetComp.Rows[numeroFila].Cells[1].Value);

                    decimal importeSubtotal = (Convert.ToDecimal(dgvDetComp.Rows[numeroFila].Cells[1].Value)) * (Convert.ToDecimal(dgvDetComp.Rows[numeroFila].Cells[3].Value));
                    tbSubtotal.Text = importeSubtotal.ToString("0.00");
                    dgvDetComp.Rows[numeroFila].Cells[5].Value = Convert.ToDecimal(tbSubtotal.Text);

                    decimal importeIVA = importeSubtotal - (importeSubtotal / (((Convert.ToDecimal(tbIVACompra.Text)) / 100) + 1));
                    tbSubtotalIVA.Text = importeIVA.ToString("0.00");
                    dgvDetComp.Rows[numeroFila].Cells[4].Value = Convert.ToDecimal(tbSubtotalIVA.Text);

                    Totales = 0;
                    TotIva = 0;

                    foreach (DataGridViewRow r in dgvDetComp.Rows)
                    {
                        TotIva += Convert.ToDecimal(r.Cells["IVA"].Value);
                        Totales += Convert.ToDecimal(r.Cells["SUBTOTAL"].Value);
                    }

                    tbTotalFact.Text = Totales.ToString("0.00");
                    tbTotalIVA.Text = TotIva.ToString("0.00");

                    LimpiarDatosCarga();
                }
                else
                {
                    DataRow row = DTDetalles.NewRow();

                    row["PRODUCTO"] = Convert.ToString(tbProducto.Text);
                    row["CANT"] = Convert.ToDecimal(tbCantidad.Text);
                    row["IDPRODUCTO"] = Convert.ToInt32(tbIDprod.Text);
                    row["PRECIO"] = Convert.ToDecimal(tbImporteCompra.Text);
                    row["IVA"] = Convert.ToDecimal(tbSubtotalIVA.Text);
                    row["SUBTOTAL"] = Convert.ToDecimal(tbSubtotal.Text);

                    TotIva += Convert.ToDecimal(row["IVA"].ToString());
                    tbTotalIVA.Text = TotIva.ToString("0.00");

                    Totales += Convert.ToDecimal(row["SUBTOTAL"].ToString());
                    tbTotalFact.Text = Totales.ToString("0.00");

                    DTDetalles.Rows.Add(row);
                    LimpiarDatosCarga();
                    contadorFila++;
                }
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

                    TotIva -= Convert.ToDecimal(row["IVA"].ToString());
                    tbTotalIVA.Text = TotIva.ToString("0.00");

                    Totales -= Convert.ToDecimal(row["SUBTOTAL"].ToString());
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
            if (tbCantidad.Text == "00")
            {
                tbCantidad.Text = "0";
                tbCantidad.Select(tbCantidad.Text.Length, 0);
            }
            if(tbCantidad.Text == ",")
            {
                tbCantidad.Text = "0,";
                tbCantidad.Select(tbCantidad.Text.Length, 0);
            }
            if(tbCantidad.Text == "0,00")
            {
                tbCantidad.Text = "0,0";
                tbCantidad.Select(tbCantidad.Text.Length, 0);
            }

            if (tbImporteCompra.Text != "" && tbCantidad.Text != "" && tbCantidad.Text != "0" && tbCantidad.Text != "0,00" && tbCantidad.Text != ",")
            {
                decimal importeSubtotal = (Convert.ToDecimal(tbCantidad.Text)) * (Convert.ToDecimal(tbImporteCompra.Text));
                tbSubtotal.Text = importeSubtotal.ToString("0.00");
                decimal importeIVA = importeSubtotal - (importeSubtotal / (((Convert.ToDecimal(tbIVACompra.Text)) / 100) + 1));
                tbSubtotalIVA.Text = importeIVA.ToString("0.00");
            }
        }

        private void tbImporteCompra_TextChanged(object sender, EventArgs e)
        {
            if (tbImporteCompra.Text != "" && tbCantidad.Text != "" && tbCantidad.Text != "0" && tbCantidad.Text != "0,00" && tbCantidad.Text != ",")
            {
                decimal importeSubtotal = (Convert.ToDecimal(tbCantidad.Text)) * (Convert.ToDecimal(tbImporteCompra.Text));
                tbSubtotal.Text = importeSubtotal.ToString("0.00");
                decimal importeIVA = importeSubtotal - (importeSubtotal / (((Convert.ToDecimal(tbIVACompra.Text)) / 100) + 1));
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
                                comprobte = tbNumComp.Text;
                                if (tbNumComp.Text.Length.ToString().Equals("1"))
                                {
                                    comprobte = "0000" + comprobte;
                                }
                                if (tbNumComp.Text.Length.ToString().Equals("2"))
                                {
                                    comprobte = "000" + comprobte;
                                }
                                if (tbNumComp.Text.Length.ToString().Equals("3"))
                                {
                                    comprobte = "00" + comprobte;
                                }
                                if (tbNumComp.Text.Length.ToString().Equals("4"))
                                {
                                    comprobte = "0" + comprobte;
                                }

                                string estado = "ACTIVO";

                                rpta = CN_Compras.Insertar(comprobte, dtpFecha.Value, estado, tbCuit.Text, Convert.ToInt32(UserLoginCache.UserId), DTDetalles);


                                if (rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Se Generó con éxito el Comprobante");

                                    rpta = CN_CtaCte.InsertarP(tbCuit.Text, dtpFecha.Value, comprobte, "FACTURA DE COMPRA", 0,Convert.ToDecimal(tbTotalFact.Text), 0, 0, 0, Convert.ToDecimal(tbTotalFact.Text)*-1, 0, 0, "N", estado);
                                    if (rpta.Equals("OK"))
                                    {
                                        this.MensajeOk("Se registro en cuenta corriente");

                                    }
                                    else
                                    {
                                        this.MensajeError(rpta);
                                    }

                                    limpiarCampos();
                                    CargarGrilla();
                                    DTDetalles.Rows.Clear();
                                    tabCompras.SelectedTab = tabListadoCompras;
                                    BuscarUltimaCompra();
                                    PoneACeroConstructores();
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

        private void PoneACeroConstructores()
        {
            TotIva = 0;
            Totales = 0;
            contadorFila = 0;
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


                        string rpta = CN_CtaCte.AnularRegistroCtaCteP(dgvCompras.CurrentRow.Cells["NUM_COMPRA"].Value.ToString(), "FACTURA DE COMPRA");
                        if (rpta.Equals("OK"))
                        {
                            MessageBox.Show("Se QUITO EL REGISTO DE LA CTA CTE");
                        }
                        else
                        {
                            this.MensajeError(rpta);
                        }

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
            foreach (DataGridViewRow MyRow in dgvProductos.Rows)
            {
                if (Convert.ToDecimal(MyRow.Cells[8].Value) <= Convert.ToDecimal(MyRow.Cells[9].Value))
                {
                    MyRow.DefaultCellStyle.BackColor = Color.Orange;
                    MyRow.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void chekVerAnulados_CheckedChanged_1(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void tbProducto_TextChanged(object sender, EventArgs e)
        {
            if (tbProducto.Text != "")
            {
                tbCantidad.Text = "1";
            }
        }
    }
}
