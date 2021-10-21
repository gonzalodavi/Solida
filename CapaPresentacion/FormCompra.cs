using CapaEntidades;
using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormCompra : Form
    {
        readonly CE_Compras objetoCE = new CE_Compras();
        readonly CN_Compras2 objetoCN = new CN_Compras2();
        CN_Compras objeto = new CN_Compras();


        private DataTable DTDetalles;



        private double TotIva;
        private double Totales;

        public FormCompra()
        {
            InitializeComponent();
        }
        private void FormCompra_Load(object sender, EventArgs e)
        {
            CrearTabla();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static int contadorFila = 0;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbCantidad.Text != "" && tbProducto.Text != "")
            {
                bool existe = false;
                int numeroFila = 0;

                if (contadorFila == 0)
                {
                    DataRow row = DTDetalles.NewRow();

                    row["CANT"] = Convert.ToInt32(tbCantidad.Text);
                    row["PRODUCTO"] = Convert.ToString(tbProducto.Text);
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
                        if (Fila.Cells[1].Value.ToString() == tbProducto.Text)
                        {
                            existe = true;
                            numeroFila = Fila.Index;
                        }                        
                    }
                    if (existe == true)
                    {
                        dgvDetComp.Rows[numeroFila].Cells[0].Value = Convert.ToInt32(tbCantidad.Text) + Convert.ToInt32(dgvDetComp.Rows[numeroFila].Cells[0].Value);
                        
                        double importeSubtotal = (Convert.ToDouble(dgvDetComp.Rows[numeroFila].Cells[0].Value)) * (Convert.ToDouble(dgvDetComp.Rows[numeroFila].Cells[2].Value));
                        tbSubtotal.Text = importeSubtotal.ToString("0.00");
                        dgvDetComp.Rows[numeroFila].Cells[4].Value = Convert.ToDecimal(tbSubtotal.Text);

                        double importeIVA = importeSubtotal - (importeSubtotal / (((Convert.ToDouble(tbIVACompra.Text)) / 100) + 1));
                        tbSubtotalIVA.Text = importeIVA.ToString("0.00");
                        dgvDetComp.Rows[numeroFila].Cells[3].Value = Convert.ToDecimal(tbSubtotalIVA.Text);

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

                        row["CANT"] = Convert.ToInt32(tbCantidad.Text);
                        row["PRODUCTO"] = Convert.ToString(tbProducto.Text);
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

        private void cbProveedor_TextChanged(object sender, EventArgs e)
        {
            /*if (cbProveedor.Text == "")
            {
                tbCuit.Text ="";
                tbDireccion.Text = "";
            }
            else
            {
                string cadena = cbProveedor.SelectedValue.ToString();
                tbDireccion.Text = objeto.ConsultaDomicilio(cadena);
                tbCuit.Text = cadena;
            }*/
        }


        private void CrearTabla()
        {
            DTDetalles = new DataTable();
            DTDetalles.Columns.Add("CANT", Type.GetType("System.Int32"));
            DTDetalles.Columns.Add("PRODUCTO", Type.GetType("System.String"));
            DTDetalles.Columns.Add("PRECIO", Type.GetType("System.Decimal"));
            DTDetalles.Columns.Add("IVA", Type.GetType("System.Decimal"));
            DTDetalles.Columns.Add("SUBTOTAL", Type.GetType("System.Decimal"));

            dgvDetComp.DataSource = DTDetalles;

            dgvDetComp.Columns[0].Width = 25;
            dgvDetComp.Columns[2].Width = 50;
            dgvDetComp.Columns[3].Width = 50;
            dgvDetComp.Columns[4].Width = 80;
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

        private void btnSelProd_Click(object sender, EventArgs e)
        {
            FormProductos listadoProductos = new FormProductos();
            AddOwnedForm(listadoProductos);
            listadoProductos.ShowDialog();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbProveedor.Text != "" && tbNumComp.Text != "")
                {
                    if (dgvDetComp.SelectedRows.Count > 0)
                    {
                        if (MessageBox.Show("¿Esta seguro de Generar Comprobante?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            objetoCE.NumeroCompras = tbNumComp.Text.Trim();
                            objetoCE.Fecha = dtpFecha.Value;
                            objetoCE.Estado = "ACTIVO";
                            objetoCE.Cuit = tbCuit.Text;

                            CN_Compras2.InsertarCompras(objetoCE, DTDetalles);
                            MessageBox.Show("Su comprobante se guardó correctamente");
                            Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("No existen productos cargados");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un Cliente y Numero de Comprobante");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar los datos por:\n\n" + ex);
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

        private void cbProducto_TextChanged(object sender, EventArgs e)
        {


        }


        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscaProveedor_Click(object sender, EventArgs e)
        {
            FormProveedor listadoProveedor = new FormProveedor();
            AddOwnedForm(listadoProveedor);
            listadoProveedor.ShowDialog();
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

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
