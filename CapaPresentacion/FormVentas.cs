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
using Microsoft.Reporting.WebForms;
using System.Net.Mail;
using System.IO;

namespace CapaPresentacion
{
    public partial class FormVentas : Form
    {
        CN_Recibo objeto1 = new CN_Recibo();
        CN_Ventas objeto = new CN_Ventas();
        private DataTable DTDetalles;
        private decimal TotIva;
        private decimal Totales;
        public static int contadorFila = 0;
        private string comprobte;
        private string nroRecibo;

        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            fechaHoy();
            CargarGrilla();
            CargarSucursal();
            CrearTabla();
            chekConsumidorFinal.Checked = true;
            BuscarUltimaVenta();
        }

        private void fechaHoy()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            dtpFecha1.Value = new DateTime(year, month, 1);
            dtpFecha2.Value = DateTime.Now;
            dtpFecha.Value = DateTime.Now;
        }

        private void BuscarUltimaVenta()
        {
            int numFact = objeto.MostrarUltimaVenta();
            tbNumComp.Text = (numFact + 1).ToString();
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

        private void PoneACeroConstructores()
        {
            TotIva = 0;
            Totales = 0;
            contadorFila = 0;
        }

        private void CargarGrilla()
        {
            if (chekVerAnulados.Checked == false)
            {
                this.dgvVentas.DataSource = CN_Ventas.Mostrar();
                this.dgvVentas.Columns[0].Visible = false;
                this.dgvVentas.Columns[1].Visible = false;
            }
            else
            {
                this.dgvVentas.DataSource = CN_Ventas.MostrarAnulados();
                this.dgvVentas.Columns[0].Visible = false;
                this.dgvVentas.Columns[1].Visible = false;
            }
        }

        private void limpiarCampos()
        {
            tbCliente.Text = "";
            tbIDprod.Text = "";
            tbDni.Text = "";
            tbNumComp.Text = "";
            tbIDprod.Text = "";
            tbProducto.Text = "";
            tbCantidad.Text = "";
            tbImporteVenta.Text = "";
            tbIVAVenta.Text = "";
            tbSubtotal.Text = "";
            tbSubtotalIVA.Text = "";
            tbTotalFact.Text = "";
            tbTotalIVA.Text = "";
            chekConsumidorFinal.Checked = false;
            chekConsumidorFinal.Checked = true;
            this.dgvClientes.Columns.Clear();
            this.dgvProductos.Columns.Clear();
        }

        private void LimpiarDatosCarga()
        {
            tbCantidad.Text = "";
            tbProducto.Text = "";
            tbImporteVenta.Text = "";
            tbIVAVenta.Text = "";
            tbSubtotal.Text = "";
            tbSubtotalIVA.Text = "";
            tbIDprod.Text = "";
            this.dgvClientes.Columns.Clear();
            this.dgvProductos.Columns.Clear();
        }

        private void CargarSucursal()
        {
            cbSucursal.DataSource = objeto.CargarSucursales();
            cbSucursal.DisplayMember = "NOMBRE_SUCURSAL";
            cbSucursal.ValueMember = "ID_SUCURSAL";
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

            dgvDetVent.DataSource = DTDetalles;
            dgvDetVent.Columns["IDPRODUCTO"].Visible = false;
                        
            /*this.dgvDetComp.Columns["PRODUCTO"].Visible = false;
            this.dgvDetComp.Columns["PRECIO"].Width = 50;
            this.dgvDetComp.Columns["IVA"].Width = 50;
            this.dgvDetComp.Columns["SUBTOTAL"].Width = 80;*/
        }

        private void chekConsumidorFinal_CheckedChanged(object sender, EventArgs e)
        {
            if (chekConsumidorFinal.Checked == true)
            {
                tbCliente.Text = "Consumidor Final";
                tbDni.Text = "0";
                rbContado.Checked = true;
                rbContado.Enabled = false;
                rbCtaCte.Enabled = false;
            }
            else
            {
                tbCliente.Text = "";
                tbDni.Text = "";
                rbContado.Enabled = true;
                rbCtaCte.Enabled = true;
            }
        }

        private void btnElijeCliente_Click(object sender, EventArgs e)
        {
            if(chekConsumidorFinal.Checked == true)
            {
                chekConsumidorFinal.Checked = false;
            }
            panelClientes.Enabled = true;
            lblPanelClientes.Visible = false;
            tabVentas.SelectedTab = tabClientes;

            CargarClientes();
        }

        private void CargarClientes()
        {
            this.dgvClientes.DataSource = CN_Cliente.Mostrar();
            this.OcultarColumnasClientes();
        }

        private void OcultarColumnasClientes()
        {
            this.dgvClientes.Columns[4].Visible = false;
            this.dgvClientes.Columns[5].Visible = false;
            this.dgvClientes.Columns[7].Visible = false;
        }

        private void btnSelProd_Click(object sender, EventArgs e)
        {
            tabVentas.SelectedTab = tabProductos;
            panelProductos.Enabled = true;
            lblPanelProductos.Visible = false;
            CargarProductos();
        }

        private void CargarProductos()
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            BuscarUltimaVenta();
            tabVentas.SelectedTab = tabNuevaVenta;
        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCliente.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString() + " " + dgvClientes.CurrentRow.Cells[1].Value.ToString();
            tbDni.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            tabVentas.SelectedTab = tabNuevaVenta;
            this.dgvClientes.Columns.Clear();
            panelClientes.Enabled = false;
            lblPanelClientes.Visible = true;
        }

        private void dgvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIDprod.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            tbProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            tbIVAVenta.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
            tbImporteVenta.Text = dgvProductos.CurrentRow.Cells[7].Value.ToString();
            tbStockProd.Text = dgvProductos.CurrentRow.Cells[8].Value.ToString();
            tabVentas.SelectedTab = tabNuevaVenta;
            this.dgvProductos.Columns.Clear();
            panelProductos.Enabled = false;
            lblPanelProductos.Visible = true;
            tbCantidad.Focus();
        }

        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {

            if (tbCantidad.Text == "00")
            {
                tbCantidad.Text = "0";
                tbCantidad.Select(tbCantidad.Text.Length, 0);
            }
            if (tbCantidad.Text == ",")
            {
                tbCantidad.Text = "0,";
                tbCantidad.Select(tbCantidad.Text.Length, 0);
            }
            if (tbCantidad.Text == "0,00")
            {
                tbCantidad.Text = "0,0";
                tbCantidad.Select(tbCantidad.Text.Length, 0);
            }

            if (tbImporteVenta.Text != "" && tbCantidad.Text != "" && tbCantidad.Text != "0" && tbCantidad.Text != "0,00" && tbCantidad.Text != ",")
            {
                decimal importeSubtotal = (Convert.ToDecimal(tbCantidad.Text)) * (Convert.ToDecimal(tbImporteVenta.Text));
                tbSubtotal.Text = importeSubtotal.ToString("0.00");
                decimal importeIVA = importeSubtotal - (importeSubtotal / (((Convert.ToDecimal(tbIVAVenta.Text)) / 100) + 1));
                tbSubtotalIVA.Text = importeIVA.ToString("0.00");
            }
        }

        private void tbImporteVenta_TextChanged(object sender, EventArgs e)
        {
            if (tbImporteVenta.Text != "" && tbCantidad.Text != "" && tbCantidad.Text != "0" && tbCantidad.Text != "0,00" && tbCantidad.Text != ",")
            {
                decimal importeSubtotal = (Convert.ToDecimal(tbCantidad.Text)) * (Convert.ToDecimal(tbImporteVenta.Text));
                tbSubtotal.Text = importeSubtotal.ToString("0.00");
                decimal importeIVA = importeSubtotal - (importeSubtotal / (((Convert.ToDecimal(tbIVAVenta.Text)) / 100) + 1));
                tbSubtotalIVA.Text = importeIVA.ToString("0.00");
            }
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {            
            if (tbCantidad.Text != "" && tbCantidad.Text != "0" && tbCantidad.Text != "0," && tbCantidad.Text != "," && tbCantidad.Text != "0,0" && tbCantidad.Text != "0,00")
            {   
                if(tbProducto.Text != "")
                {
                    if (Convert.ToDecimal(tbStockProd.Text) < Convert.ToDecimal(tbCantidad.Text))
                    {                        
                        DialogResult Opcion;
                        Opcion = MessageBox.Show("El Stock es Insufuciente\nDesea agregar de todos modos? ", "¡Atencion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (Opcion == DialogResult.OK)
                        {
                            InsertarEnDetalle();
                        }
                    }
                    else
                    {
                        InsertarEnDetalle();
                    }
                }
                else
                {
                    this.MensajeError("Por Favor, Seleccione un producto de la lista");
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
                row["PRECIO"] = Convert.ToDecimal(tbImporteVenta.Text);
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
                foreach (DataGridViewRow Fila in dgvDetVent.Rows)
                {
                    if (Fila.Cells[2].Value.ToString() == tbIDprod.Text)
                    {
                        existe = true;
                        numeroFila = Fila.Index;
                    }
                }
                if (existe == true)
                {
                    if (Convert.ToDecimal(tbStockProd.Text) < (Convert.ToDecimal(tbCantidad.Text) + Convert.ToDecimal(dgvDetVent.Rows[numeroFila].Cells[1].Value)))
                    {                        
                        DialogResult Opcion1;
                        Opcion1 = MessageBox.Show("El Stock es Insufuciente\nDesea agregar de todos modos? ", "¡Atencion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (Opcion1 == DialogResult.OK)
                        {
                            dgvDetVent.Rows[numeroFila].Cells[1].Value = Convert.ToDecimal(tbCantidad.Text) + Convert.ToDecimal(dgvDetVent.Rows[numeroFila].Cells[1].Value);

                            decimal importeSubtotal = (Convert.ToDecimal(dgvDetVent.Rows[numeroFila].Cells[1].Value)) * (Convert.ToDecimal(dgvDetVent.Rows[numeroFila].Cells[3].Value));
                            tbSubtotal.Text = importeSubtotal.ToString("0.00");
                            dgvDetVent.Rows[numeroFila].Cells[5].Value = Convert.ToDecimal(tbSubtotal.Text);

                            decimal importeIVA = importeSubtotal - (importeSubtotal / (((Convert.ToDecimal(tbIVAVenta.Text)) / 100) + 1));
                            tbSubtotalIVA.Text = importeIVA.ToString("0.00");
                            dgvDetVent.Rows[numeroFila].Cells[4].Value = Convert.ToDecimal(tbSubtotalIVA.Text);

                            Totales = 0;
                            TotIva = 0;

                            foreach (DataGridViewRow r in dgvDetVent.Rows)
                            {
                                TotIva += Convert.ToDecimal(r.Cells["IVA"].Value);
                                Totales += Convert.ToDecimal(r.Cells["SUBTOTAL"].Value);
                            }

                            tbTotalFact.Text = Totales.ToString("0.00");
                            tbTotalIVA.Text = TotIva.ToString("0.00");

                            LimpiarDatosCarga();
                        }
                    }
                    else
                    {
                        dgvDetVent.Rows[numeroFila].Cells[1].Value = Convert.ToDecimal(tbCantidad.Text) + Convert.ToDecimal(dgvDetVent.Rows[numeroFila].Cells[1].Value);

                        decimal importeSubtotal = (Convert.ToDecimal(dgvDetVent.Rows[numeroFila].Cells[1].Value)) * (Convert.ToDecimal(dgvDetVent.Rows[numeroFila].Cells[3].Value));
                        tbSubtotal.Text = importeSubtotal.ToString("0.00");
                        dgvDetVent.Rows[numeroFila].Cells[5].Value = Convert.ToDecimal(tbSubtotal.Text);

                        decimal importeIVA = importeSubtotal - (importeSubtotal / (((Convert.ToDecimal(tbIVAVenta.Text)) / 100) + 1));
                        tbSubtotalIVA.Text = importeIVA.ToString("0.00");
                        dgvDetVent.Rows[numeroFila].Cells[4].Value = Convert.ToDecimal(tbSubtotalIVA.Text);

                        Totales = 0;
                        TotIva = 0;

                        foreach (DataGridViewRow r in dgvDetVent.Rows)
                        {
                            TotIva += Convert.ToDecimal(r.Cells["IVA"].Value);
                            Totales += Convert.ToDecimal(r.Cells["SUBTOTAL"].Value);
                        }

                        tbTotalFact.Text = Totales.ToString("0.00");
                        tbTotalIVA.Text = TotIva.ToString("0.00");

                        LimpiarDatosCarga();
                    }
                }
                else
                {
                    DataRow row = DTDetalles.NewRow();

                    row["PRODUCTO"] = Convert.ToString(tbProducto.Text);
                    row["CANT"] = Convert.ToDecimal(tbCantidad.Text);
                    row["IDPRODUCTO"] = Convert.ToInt32(tbIDprod.Text);
                    row["PRECIO"] = Convert.ToDecimal(tbImporteVenta.Text);
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

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetVent.SelectedRows.Count > 0)
            {
                try
                {
                    int IndiceFila = dgvDetVent.CurrentCell.RowIndex;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvDetVent.SelectedRows.Count > 0)
            {
                try
                {
                    string rpta = "";
                    if (this.tbDni.Text == string.Empty)
                    {
                        MensajeError("Seleccione Un Cliente");
                    }
                    else
                    {
                        if (this.tbNumComp.Text == string.Empty)
                        {
                            MensajeError("Ingrese Numero de Comprobante");
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
                                rpta = CN_Ventas.Insertar(cbSucursal.Text,comprobte, dtpFecha.Value, estado, tbDni.Text, Convert.ToInt32(UserLoginCache.UserId), Convert.ToDecimal(tbTotalFact.Text), DTDetalles);


                                if (rpta.Equals("OK"))
                                {                                    
                                    this.MensajeOk("Se Generó con éxito La Factura");

                                    rpta = CN_CtaCte.Insertar(tbDni.Text,dtpFecha.Value, comprobte, "FACTURA DE VENTA",Convert.ToDecimal(tbTotalFact.Text),0,0,0,0, Convert.ToDecimal(tbTotalFact.Text),0,0,"N",estado);
                                    if (rpta.Equals("OK"))
                                    {
                                        this.MensajeOk("Se Inserto la FACTURA EN CTA CTE");

                                        if (rbContado.Checked == true)
                                        {
                                            AbreRecibo();
                                        }                                      
                                    }
                                    else
                                    {
                                        this.MensajeError(rpta);
                                    }                                   

                                    limpiarCampos();
                                    CargarGrilla();
                                    DTDetalles.Rows.Clear();
                                    BuscarUltimaVenta();
                                    tabVentas.SelectedTab = tabListadoVentas;
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
        

        private void btnBuscarReg_Click(object sender, EventArgs e)
        {
            BuscarRegistros();
        }

        private void BuscarRegistros()
        {
            if (chekVerAnulados.Checked == false)
            {
                dgvVentas.DataSource = CN_Ventas.BuscarRegistros(dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
                this.dgvVentas.Columns[0].Visible = false;
            }
            else
            {
                dgvVentas.DataSource = CN_Ventas.BuscarRegistrosAnulados(dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
                this.dgvVentas.Columns[0].Visible = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                if (dgvVentas.CurrentRow.Cells[4].Value.ToString() != "ANULADO")
                {
                    string numComprob = dgvVentas.CurrentRow.Cells[2].Value.ToString();

                    CN_Ventas ob = new CN_Ventas();
                    string rpta = ob.ConsultarSiVtaAsignada(numComprob);
                    if (rpta == "OK")
                    {
                        MensajeError("No se puede anular la VENTA porque tiene PAGOS imputados");
                    }
                    else
                    {
                        if (rpta == "NO")
                        {
                            DialogResult opcion;
                            opcion = MessageBox.Show("Desea ANULAR el comprobante seleccionado?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (opcion == DialogResult.OK)
                            {
                                CN_Ventas objetoCN = new CN_Ventas();
                                int idVenta = Convert.ToInt32(dgvVentas.CurrentRow.Cells[0].Value.ToString());
                                objetoCN.AnularComprobantes(idVenta);

                                MessageBox.Show("El Comprobante se ANULÓ CORRECTAMENTE");

                                string rpta1 = CN_CtaCte.AnularRegistroCtaCte(dgvVentas.CurrentRow.Cells[2].Value.ToString(), "FACTURA DE VENTA");
                                if (rpta1.Equals("OK"))
                                {
                                    MessageBox.Show("Se QUITO EL REGISTO DE LA CTA CTE");
                                }
                                else
                                {
                                    this.MensajeError(rpta1);
                                }

                                CargarGrilla();
                            }
                        }
                        else
                        {
                            MensajeError(rpta);
                        }
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                FormReporteVenta form = new FormReporteVenta();
                form.IdVenta = Convert.ToInt32(this.dgvVentas.CurrentRow.Cells["ID_VENTA"].Value);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por Favor seleccione un comprobante");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            CargarProductos();
            tbBuscaProductos.Text = "";
        }

        

        private void BuscarClientes()
        {
            if (tbBuscaCliente.Text == "")
            {
                CargarGrilla();
                MessageBox.Show("Para Buscar un cliente debe ingresar su DNI o Nombre");
            }
            else
            {
                CN_Cliente objetob = new CN_Cliente();
                dgvClientes.DataSource = objetob.BuscarClientesxNom(tbBuscaCliente.Text);
                if (dgvClientes.SelectedRows.Count < 1)
                {
                    CN_Cliente objA = new CN_Cliente();
                    dgvClientes.DataSource = objetob.BuscarClientexDNI(tbBuscaCliente.Text);
                    if (dgvClientes.SelectedRows.Count < 1)
                    {
                        MessageBox.Show("No existen registros");
                    }
                }
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarClientes();
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow MyRow in dgvProductos.Rows)
            {
                if (Convert.ToDecimal(MyRow.Cells[8].Value) <= Convert.ToDecimal(MyRow.Cells[9].Value))
                {                    
                    MyRow.DefaultCellStyle.BackColor = Color.Orange;
                    MyRow.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
            }           
        }

        private void tbProducto_TextChanged(object sender, EventArgs e)
        {
            if (tbProducto.Text != "") 
            {
                tbCantidad.Text = "1";
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

        private void tbNumComp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnActualizaListaProv_Click(object sender, EventArgs e)
        {
            tbBuscaCliente.Text = "";
            CargarClientes();
        }

        private void dgvVentas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow MyRow in dgvVentas.Rows)
            {
                if (MyRow.Cells[5].Value.ToString() == "0")
                {
                    MyRow.Cells[5].Value = "Consumidor Final";
                }
            }
        }

        private void chekVerAnulados_CheckedChanged(object sender, EventArgs e)
        {
            if(chekVerAnulados.Checked == true)
            {
                btnImprimir.Enabled = false;
            }
            else
            {
                btnImprimir.Enabled = true;
            }
            CargarGrilla();            
        }

        private void AbreRecibo()
        {
            Form formBG = new Form();
            using (FormReciboDePago mm = new FormReciboDePago())
            {
                mm.tbTotalAPagar.Text = tbTotalFact.Text;
                mm.NombreTitular = tbCliente.Text.Trim();
                mm.tbDetalleRecibo.Text = "PAGO FACTURA: " + cbSucursal.Text + "-" + comprobte + "\r\n";
                mm.tbDNI.Text = tbDni.Text;
                mm.tbCheqBenef.Text = "Quevedo Yolanda";
                mm.tbNumFact.Text = comprobte;
                if (chekConsumidorFinal.Checked == false)
                {
                    mm.tbTitTransf.Text = tbCliente.Text;
                    mm.tbCheqTitular.Text = tbCliente.Text;
                }

                formBG.StartPosition = FormStartPosition.Manual;
                formBG.FormBorderStyle = FormBorderStyle.None;
                formBG.Opacity = .70d;
                formBG.BackColor = Color.Black;
                formBG.WindowState = FormWindowState.Maximized;
                formBG.TopMost = true;
                formBG.Location = this.Location;
                formBG.ShowInTaskbar = false;
                formBG.Show();

                mm.Owner = formBG;
                mm.ShowDialog();

                formBG.Dispose();
            }            
        }


        private void chekBuscaXCuit_CheckedChanged(object sender, EventArgs e)
        {
            tbBuscaXCuit.Text = "";
            if (chekBuscaXCuit.Checked == true)
            {
                chekVerAnulados.Checked = false;
                CargarGrilla();
                btnBuscarReg.Enabled = false;
                dtpFecha1.Enabled = false;
                dtpFecha2.Enabled = false;
                tbBuscaXCuit.Enabled = true;
                chekVerAnulados.Enabled = false;
            }
            else
            {
                chekVerAnulados.Checked = false;
                CargarGrilla();
                btnBuscarReg.Enabled = true;
                dtpFecha1.Enabled = true;
                dtpFecha2.Enabled = true;
                tbBuscaXCuit.Enabled = false;
                chekVerAnulados.Enabled = true;
            }
        }

        private void tbBuscaXCuit_TextChanged(object sender, EventArgs e)
        {
            dgvVentas.DataSource = CN_Ventas.BuscarRegistrosxCuit(tbBuscaXCuit.Text.Trim());
            this.dgvVentas.Columns[0].Visible = false;
        }
    }
}
