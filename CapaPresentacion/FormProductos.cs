using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class FormProductos : Form
    {
        CN_Productos objeto = new CN_Productos();
        private bool Editar = false;
        private string resultado = "";
        

        public FormProductos()
        {
            InitializeComponent();
        }
        private void FormProductos_Load(object sender, EventArgs e)
        {
            CargaRubrosComboBox();
            CargaAlicComboBox();
            CargaMarcaComboBox();
            CargaModeloComboBox();
            CargarGrilla();
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

        private void CargarGrilla()
        {
            CN_Productos objeto = new CN_Productos();
            dgvProductos.DataSource = objeto.MostrarProducto();

            //dgvProductos.Columns[0].Visible = false;
            //dgvProductos.Columns[1].Visible = false;
            dgvProductos.Columns[2].Visible = false;
            //dgvProductos.Columns[3].Visible = false;
            dgvProductos.Columns[4].Visible = false;
            //dgvProductos.Columns[5].Visible = false;
            //dgvProductos.Columns[6].Visible = false;
            //dgvProductos.Columns[7].Visible = false;
            dgvProductos.Columns[8].Visible = false;
            //dgvProductos.Columns[9].Visible = false;
            //dgvProductos.Columns[10].Visible = false;

            this.dgvProductos.Columns[0].Width = 40;
            this.dgvProductos.Columns[1].Width = 150;
            this.dgvProductos.Columns[3].Width = 100;
            this.dgvProductos.Columns[5].Width = 70;
            this.dgvProductos.Columns[6].Width = 70;
            this.dgvProductos.Columns[7].Width = 40;
            this.dgvProductos.Columns[9].Width = 100;
            this.dgvProductos.Columns[10].Width = 100;

            


        }

        private void CargaRubrosComboBox()
        {
            cbRubro.DataSource = objeto.CargaComboBoxRubro();
            cbRubro.DisplayMember = "RUBRO";
            cbRubro.ValueMember = "ID";
            cbRubro.SelectedIndex = -1;            
        }

        private void CargaAlicComboBox()
        {
            cbAli.DataSource = objeto.CargaComboBoxAlicuota();
            cbAli.DisplayMember = "ALICUOTA";
            cbAli.ValueMember = "ID";
            cbAli.Text = "21";
        }
        private void CargaMarcaComboBox()
        {
            cbMarca.DataSource = objeto.CargaComboBoxMarca();
            cbMarca.DisplayMember = "MARCA";
            cbMarca.ValueMember = "ID";
            cbMarca.SelectedIndex = -1;           
        }
        private void CargaModeloComboBox()
        {
            cbModelo.DataSource = objeto.CargaComboBoxModelo();
            cbModelo.DisplayMember = "MODELO";
            cbModelo.ValueMember = "ID";
            cbModelo.SelectedIndex = -1;
        }

        private void limpiarCampos()
        {
            lblSubTitutlo.Text = "Ingrese Nuevo Producto";
            tbID.Text = "";
            tbDescripcion.Text = "";
            tbCodBarra.Text = "";
            tbBusca.Text = "";
            tbCosto.Text = "";
            tbGanancia.Text = "";                         
            tbStock.Text = "";
            tbStockMin.Text = "";            
            tbVenta.Text = "";
            cbAli.Text = "21";
            cbMarca.SelectedIndex = -1;
            cbModelo.SelectedIndex = -1;
            cbRubro.SelectedIndex = -1;
        }     

        private void haceCalculo()
        {
            decimal costo = 0, ganancia = 0, importe = 0;

            if (tbCosto.Text != "")
            {
                costo = Convert.ToDecimal(tbCosto.Text);
                if (tbGanancia.Text != "")
                {
                    ganancia = Convert.ToDecimal(tbGanancia.Text);
                    importe = costo * ((ganancia / 100) + 1);
                    resultado = importe.ToString("0.00");
                }
            }
        }
        private void haceCalculoInverso()
        {
            decimal costo = 0, venta = 0, importe = 0;

            if (tbVenta.Text != "")
            {
                venta = Convert.ToDecimal(tbVenta.Text);
                if (tbCosto.Text != "")
                {
                    costo = Convert.ToDecimal(tbCosto.Text);
                    importe = venta / ((costo / 100) + 1);
                    resultado = importe.ToString("0.00");
                }
            }
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
                if(dgvProductos.SelectedRows.Count < 1)
                {
                    CN_Productos objetoa = new CN_Productos();
                    dgvProductos.DataSource = objetoa.BuscarProductosNom(tbBusca.Text);
                    /*if (dgvProductos.SelectedRows.Count < 1)
                    {
                        CargarGrilla();
                        MessageBox.Show("No existen registros");
                    }        */                               
                }
            }
        }     


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                limpiarCampos();
                lblSubTitutlo.Text = "Modificación del Producto";                
                CargaAlicComboBox();
                CargaMarcaComboBox();
                CargaModeloComboBox();
                CargaRubrosComboBox();

                tbID.Text = dgvProductos.CurrentRow.Cells["ID"].Value.ToString();
                tbDescripcion.Text = dgvProductos.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                tbCodBarra.Text = dgvProductos.CurrentRow.Cells["COD_BARRA"].Value.ToString();
                tbCosto.Text = dgvProductos.CurrentRow.Cells["PRECIO_COSTO"].Value.ToString();
                tbVenta.Text = dgvProductos.CurrentRow.Cells["PRECIO_VTA"].Value.ToString();
                tbStock.Text = dgvProductos.CurrentRow.Cells["STOCK"].Value.ToString();
                tbStockMin.Text = dgvProductos.CurrentRow.Cells["STOCK_MIN"].Value.ToString();
                cbAli.Text = dgvProductos.CurrentRow.Cells["ALIC"].Value.ToString();
                cbMarca.Text = dgvProductos.CurrentRow.Cells["MARCA"].Value.ToString();
                cbModelo.Text = dgvProductos.CurrentRow.Cells["MODELO"].Value.ToString();
                cbRubro.Text = dgvProductos.CurrentRow.Cells["RUBRO"].Value.ToString();
                haceCalculoInverso();
                tbGanancia.Text = resultado;
                resultado = "";
                Editar = true;
                tabProductos.SelectedTab = tabNuevoProducto;
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            tabProductos.SelectedTab = tabNuevoProducto;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarProductos();
        }

        private void btnActualizaListaProd_Click(object sender, EventArgs e)
        {
            tbBusca.Text = "";
            CargarGrilla();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {            
            limpiarCampos();
            Editar = false;
            tabProductos.SelectedTab = tabConsultaProducto;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                string idProd = dgvProductos.CurrentRow.Cells["ID"].Value.ToString();
                try
                {
                    string rpta = CN_Productos.ConsultaProductoExisteEnCompra(Convert.ToInt32(idProd));
                    if (rpta == "OK")
                    {
                        this.MensajeError("No se permite eliminar un Producto utilizado en Compras");
                    }
                    else
                    {
                        if (rpta == "NO")
                        {
                            rpta = CN_Productos.ConsultaProductoExisteEnRemito(Convert.ToInt32(idProd));
                            if (rpta == "OK")
                            {
                                this.MensajeError("No se permite eliminar un Producto utilizado en Remitos");
                            }
                            else
                            {
                                if (rpta == "NO")
                                {
                                    rpta = CN_Productos.ConsultaProductoExisteEnVta(Convert.ToInt32(idProd));
                                    if (rpta == "OK")
                                    {
                                        this.MensajeError("No se permite eliminar un Producto utilizado en Ventas");
                                    }
                                    else
                                    {
                                        if (rpta == "NO")
                                        {
                                            if (MessageBox.Show("¿Desea ELIMINAR el Producto seleccionado?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                            {
                                                objeto.EliminarProducto(idProd);
                                                MessageBox.Show("Se eliminó correctamente el Producto seleccionado");
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
                                    MensajeError(rpta);
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
                    MessageBox.Show("No se pudo realizar la operacion: " + ex);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
            limpiarCampos();
            Editar = false;
        }

        private void dgvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*FormCompra datosproducto = Owner as FormCompra;
            datosproducto.tbProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            datosproducto.tbImporteCompra.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
            datosproducto.tbIVACompra.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
            datosproducto.tbIDprod.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            Close();*/
        }

        private void tbCosto_TextChanged(object sender, EventArgs e)
        {
            haceCalculo();
            tbVenta.Text = resultado;
            resultado = "";
        }

        private void tbGanancia_Leave(object sender, EventArgs e)
        {
            haceCalculo();
            tbVenta.Text = resultado;
            resultado = "";
        }

        private void tbGanancia_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbCosto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (tbDescripcion.Text != "" && tbCosto.Text != "" && cbRubro.Text != "" && cbAli.Text != "")
            {
                if (Editar == false)
                {
                    if (MessageBox.Show("¿Desea Registrar el Producto?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {                        
                        if (tbStock.Text == "")
                        {
                            tbStock.Text = "0";
                        }
                        if (tbStockMin.Text == "")
                        {
                            tbStockMin.Text = "0";
                        }
                        try
                        {
                            objeto.AgregarProducto(tbDescripcion.Text, tbCodBarra.Text, Convert.ToInt32(cbRubro.SelectedValue), Convert.ToInt32(cbAli.SelectedValue), tbCosto.Text, tbVenta.Text, tbStock.Text, tbStockMin.Text, Convert.ToInt32(cbModelo.SelectedValue), Convert.ToInt32(cbMarca.SelectedValue));
                            MessageBox.Show("Nuevo Producto Agregado");

                            Editar = false;
                            CargarGrilla();
                            limpiarCampos();
                            CargarGrilla();
                            CargaModeloComboBox();
                            CargaMarcaComboBox();
                            CargaAlicComboBox();
                            CargaRubrosComboBox();
                            tabProductos.SelectedTab = tabConsultaProducto;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se puedo realizar el ingreso de datos debido a: \n\n" + ex);
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("¿Desea Modificar el Producto Seleccionado?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            objeto.ModificarProducto(tbID.Text, tbDescripcion.Text, tbCodBarra.Text, Convert.ToInt32(cbRubro.SelectedValue), Convert.ToInt32(cbAli.SelectedValue), tbCosto.Text, tbVenta.Text, tbStock.Text, tbStockMin.Text, Convert.ToInt32(cbModelo.SelectedValue), Convert.ToInt32(cbMarca.SelectedValue));
                            limpiarCampos();
                            CargarGrilla();
                            CargaModeloComboBox();
                            CargaMarcaComboBox();
                            CargaAlicComboBox();
                            CargaRubrosComboBox();
                            Editar = false;
                            MessageBox.Show("Se Modificaron los datos del Producto");
                            btnModificar.Visible = true;
                            btnEliminar.Visible = true;
                            lblSubTitutlo.Text = "Ingrese Nuevo Producto";
                            tabProductos.SelectedTab = tabConsultaProducto;

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
                MessageBox.Show("Existen Campos vacíos");
            }
        }


        private void tbStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbStockMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FormReporteProductos form = new FormReporteProductos();
            form.ShowDialog();
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow MyRow in dgvProductos.Rows)
            {
                if (Convert.ToInt32(MyRow.Cells[7].Value) <= Convert.ToInt32(MyRow.Cells[8].Value))
                {
                    MyRow.DefaultCellStyle.BackColor = Color.Orange;
                    MyRow.DefaultCellStyle.ForeColor = Color.Red;
                }
            }

            /*   if (this.dgvProductos.Columns[e.ColumnIndex].Name == "STOCK")
               {
                   int stockmin = Convert.ToInt32(this.dgvProductos.Columns[e.ColumnIndex].Name == "STOCK_MIN");
                   if (Convert.ToInt32(e.Value) <= stockmin)
                   {
                       e.CellStyle.ForeColor = Color.Red;
                       e.CellStyle.BackColor = Color.Orange;
                   }
               }*/

        }

        private void btnAgregaRubro_Click(object sender, EventArgs e)
        {            
            Form formBG = new Form();
            using (FormRubros mm = new FormRubros())
            {
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
            CargaRubrosComboBox();
            cbRubro.SelectedIndex = -1;
        }

        private void btnAgregaMarca_Click(object sender, EventArgs e)
        {
            Form formBG = new Form();
            using (FormMarcas mm = new FormMarcas())
            {
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
            CargaMarcaComboBox();
            cbMarca.SelectedIndex = -1;
        }

        private void btnAgregaModelo_Click(object sender, EventArgs e)
        {
            Form formBG = new Form();
            using (FormModelo mm = new FormModelo())
            {
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
            CargaModeloComboBox();
            cbModelo.SelectedIndex = -1;
        } 
        
    }
}
