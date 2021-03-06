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
using CapaComun.Cache;

namespace CapaPresentacion
{
    public partial class FormProductos : Form
    {
        CN_Productos objeto = new CN_Productos();
        private bool Editar = false;
        private string resultado = "";
        private decimal stockA=0, stockM=0,res=0;

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
            CargarComboBoxUnidadesdeMedida();
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

        private void CargaRubrosComboBox()
        {
            cbRubro.DataSource = objeto.CargaComboBoxRubro();
            cbRubro.DisplayMember = "RUBRO";
            cbRubro.ValueMember = "ID";
            cbRubro.SelectedIndex = -1;
            lblErrorRubro.Visible = false;
        }

        private void CargaAlicComboBox()
        {
            cbAli.DataSource = objeto.CargaComboBoxAlicuota();
            cbAli.DisplayMember = "ALICUOTA";
            cbAli.ValueMember = "ID";
            cbAli.Text = "21";
            lblErrorAlic.Visible = false;
        }

        private void CargaMarcaComboBox()
        {
            cbMarca.DataSource = objeto.CargaComboBoxMarca();
            cbMarca.DisplayMember = "MARCA";
            cbMarca.ValueMember = "ID";
            cbMarca.SelectedIndex = -1;
            lblErrorMarca.Visible = false;
        }

        private void CargaModeloComboBox()
        {
            cbModelo.DataSource = objeto.CargaComboBoxModelo();
            cbModelo.DisplayMember = "MODELO";
            cbModelo.ValueMember = "ID";
            cbModelo.SelectedIndex = -1;
            lblErrorModelo.Visible = false;
        }

        private void CargarComboBoxUnidadesdeMedida()
        {
            cbUdeMed.DataSource = objeto.CargarComboBoxUnidades();
            cbUdeMed.DisplayMember = "DES_UNIDAD";
            cbUdeMed.ValueMember = "ID_UNIDAD";
            cbUdeMed.SelectedIndex = -1;
            lblErrorUniMed.Visible = false;
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
            cbUdeMed.SelectedIndex = -1;
            lblErrorAlic.Visible = false;
            lblErrorDescripcion.Visible = false;
            lblErrorGanancia.Visible = false;
            lblErrorMarca.Visible = false;
            lblErrorModelo.Visible = false;
            lblErrorPrecioCosto.Visible = false;
            lblErrorRubro.Visible = false;
            lblErrorUniMed.Visible = false;
            panelDesbloq.Visible = false;
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


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarProductos();
        }



        private void btnCancela_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Desea Cancelar la Operación?", "¡Atencion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            try
            {
                if (Opcion == DialogResult.OK)
                {
                    limpiarCampos();
                    Editar = false;
                    stockM = 0;
                    stockA = 0;
                    tabProductos.SelectedTab = tabConsultaProducto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }            
        }



        private void tbCosto_TextChanged(object sender, EventArgs e)
        {
            if (tbCosto.Text != "")
            {
                lblErrorPrecioCosto.Visible = false;
            }
            else
            {
                lblErrorPrecioCosto.Visible = true;
            }

            if (tbCosto.Text == "00")
            {
                tbCosto.Text = "0";
                tbCosto.Select(tbCosto.Text.Length, 0);
            }
            if (tbCosto.Text == ",")
            {
                tbCosto.Text = "0,";
                tbCosto.Select(tbCosto.Text.Length, 0);
            }
            if (tbCosto.Text == "0,00")
            {
                tbCosto.Text = "0,0";
                tbCosto.Select(tbCosto.Text.Length, 0);
            }
            haceCalculo();
            tbVenta.Text = resultado;
            resultado = "";
        }

        private void tbGanancia_Leave(object sender, EventArgs e)
        {
            if (tbGanancia.Text != "")
            {
                lblErrorGanancia.Visible = false;
            }
            else
            {
                lblErrorGanancia.Visible = true;
            }

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
            if (tbDescripcion.Text != "" && cbRubro.Text != "" && cbMarca.Text != "" && cbModelo.Text != "" && cbUdeMed.Text != "" && cbAli.Text != "" && tbCosto.Text != "" && tbGanancia.Text != "")
            {
                if (Editar == false)
                {
                    string rpta = CN_Productos.ConsultaSiExisteProducto(tbDescripcion.Text.Trim(), Convert.ToInt32(cbMarca.SelectedValue), Convert.ToInt32(cbUdeMed.SelectedValue));
                    if (rpta == "OK")
                    {
                        this.MensajeError("Ya Existe un Producto con ese Nombre, Unidad de Medida y Marca");
                    }
                    else
                    {
                        if (rpta == "NO")
                        {
                            AgregaProducto();
                        }
                        else
                        {
                            MensajeError(rpta);
                        }
                    }
                }
                else
                {
                    AgregaProducto();
                }
            }
            else
            {
                MessageBox.Show("Existen Campos vacíos");

                if (tbDescripcion.Text == "")
                {
                    lblErrorDescripcion.Visible = true;
                }
                if (cbRubro.SelectedIndex == -1)
                {
                    lblErrorRubro.Visible = true;
                }
                if (cbMarca.SelectedIndex == -1)
                {
                    lblErrorMarca.Visible = true;
                }
                if (cbModelo.SelectedIndex == -1)
                {
                    lblErrorModelo.Visible = true;
                }
                if (cbUdeMed.SelectedIndex == -1)
                {
                    lblErrorUniMed.Visible = true;
                }
                if (cbAli.SelectedIndex == -1)
                {
                    lblErrorAlic.Visible = true;
                }
                if (tbCosto.Text == "")
                {
                    lblErrorPrecioCosto.Visible = true;
                }
                if (tbGanancia.Text == "")
                {
                    lblErrorGanancia.Visible = true;
                }
            }            
        }

        private void AgregaProducto()
        {
            decimal costo = 0, ganancia = 0, importe = 0;

            if (tbCosto.Text != "")
            {
                costo = Convert.ToDecimal(tbCosto.Text);
                if (tbGanancia.Text != "")
                {
                    ganancia = Convert.ToDecimal(tbGanancia.Text);
                    importe = costo * ((ganancia / 100) + 1);
                    res = importe;
                    resultado = importe.ToString("0.00");
                }
            }

            if (res > 0)
            {
                resultado = "";
                res = 0;
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
                            objeto.AgregarProducto(tbDescripcion.Text, tbCodBarra.Text, Convert.ToInt32(cbRubro.SelectedValue), Convert.ToInt32(cbAli.SelectedValue), tbCosto.Text, tbVenta.Text, stockA.ToString("0.00"), stockM.ToString("0.00"), Convert.ToInt32(cbModelo.SelectedValue), Convert.ToInt32(cbMarca.SelectedValue), Convert.ToInt32(cbUdeMed.SelectedValue));
                            MessageBox.Show("Nuevo Producto Agregado");
                            stockM = 0;
                            stockA = 0;
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
                            objeto.ModificarProducto(tbID.Text, tbDescripcion.Text, tbCodBarra.Text, Convert.ToInt32(cbRubro.SelectedValue), Convert.ToInt32(cbAli.SelectedValue), tbCosto.Text, tbVenta.Text, tbStock.Text, tbStockMin.Text, Convert.ToInt32(cbModelo.SelectedValue), Convert.ToInt32(cbMarca.SelectedValue), Convert.ToInt32(cbUdeMed.SelectedValue));
                            stockM = 0;
                            stockA = 0;
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
                MensajeError("Los Productos a Cargar deben ser superior a $0 de costo");
                resultado = "";
                res = 0;
            }
        }

        private void tbStock_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbStockMin_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FormReporteProductos form = new FormReporteProductos();
            form.ShowDialog();
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

        private void tbStockMin_TextChanged(object sender, EventArgs e)
        {
            if (tbStockMin.Text == "00")
            {
                tbStockMin.Text = "0";
                tbStockMin.Select(tbStockMin.Text.Length, 0);
            }
            if (tbStockMin.Text == ",")
            {
                tbStockMin.Text = "0,";
                tbStockMin.Select(tbStockMin.Text.Length, 0);
            }
            if (tbStockMin.Text == "0,00")
            {
                tbStockMin.Text = "0,0";
                tbStockMin.Select(tbStockMin.Text.Length, 0);
            }
            if (tbStockMin.Text != "0" && tbStockMin.Text != "0,00" && tbStockMin.Text != "," && tbStockMin.Text != "")
            {
                stockM = Convert.ToDecimal(tbStockMin.Text.Trim());
            }
            else
            {
                stockM = 0;
            }
        }

        private void cbRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRubro.SelectedIndex != -1)
            {                
                lblErrorRubro.Visible = false;
            }
            else
            {
                lblErrorRubro.Visible = true;
            }
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMarca.SelectedIndex != -1)
            {
                lblErrorMarca.Visible = false;
            }
            else
            {
                lblErrorMarca.Visible = true;
            }
        }

        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbModelo.SelectedIndex != -1)
            {
                lblErrorModelo.Visible = false;
            }
            else
            {
                lblErrorModelo.Visible = true;
            }
        }

        private void cbUdeMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUdeMed.SelectedIndex != -1)
            {
                lblErrorUniMed.Visible = false;
            }
            else
            {
                lblErrorUniMed.Visible = true;
            }
        }

        private void cbAli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAli.SelectedIndex != -1)
            {
                lblErrorAlic.Visible = false;
            }
            else
            {
                lblErrorAlic.Visible = true;
            }
        }

        private void tbDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (tbDescripcion.Text != "")
            {
                lblErrorDescripcion.Visible = false;
            }
            else
            {
                lblErrorDescripcion.Visible = true;
            }
        }

        private void cbRubro_Leave(object sender, EventArgs e)
        {
            if (cbRubro.SelectedIndex != -1)
            {
                lblErrorRubro.Visible = false;
            }
            else
            {
                lblErrorRubro.Visible = true;
            }
        }

        private void cbMarca_Leave(object sender, EventArgs e)
        {
            if (cbMarca.SelectedIndex != -1)
            {
                lblErrorMarca.Visible = false;
            }
            else
            {
                lblErrorMarca.Visible = true;
            }
        }

        private void cbModelo_Leave(object sender, EventArgs e)
        {
            if (cbModelo.SelectedIndex != -1)
            {
                lblErrorModelo.Visible = false;
            }
            else
            {
                lblErrorModelo.Visible = true;
            }
        }

        private void cbUdeMed_Leave(object sender, EventArgs e)
        {
            if (cbUdeMed.SelectedIndex != -1)
            {
                lblErrorUniMed.Visible = false;
            }
            else
            {
                lblErrorUniMed.Visible = true;
            }
        }

        private void cbAli_Leave(object sender, EventArgs e)
        {
            if (cbAli.SelectedIndex != -1)
            {
                lblErrorAlic.Visible = false;
            }
            else
            {
                lblErrorAlic.Visible = true;
            }
        }

        private void tbCosto_Leave(object sender, EventArgs e)
        {
            if (tbCosto.Text != "")
            {
                lblErrorPrecioCosto.Visible = false;
            }
            else
            {
                lblErrorPrecioCosto.Visible = true;
            }
        }

        private void tbDescripcion_Leave(object sender, EventArgs e)
        {
            if (tbDescripcion.Text != "")
            {
                lblErrorDescripcion.Visible = false;
            }
            else
            {
                lblErrorDescripcion.Visible = true;
            }
        }

        private void btnCancelaDesbloq_Click(object sender, EventArgs e)
        {
            panelDesbloq.Visible = false;
            tbClaveDebloq.Text = "";
            tbClaveDebloq.Visible = false;
            btnAceptaClave.Visible = false;
            btnCancelaDesbloq.Visible = false;
            btnDesbloq.Visible = true;
        }

        private void btnDesbloq_Click(object sender, EventArgs e)
        {
            if (tbStock.Enabled == true) 
            {
                tbStock.Enabled = false;
                btnDesbloq.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            }
            else
            {
                if (UserLoginCache.Rango == "Administrador")
                {
                    panelDesbloq.Visible = true;
                    tbClaveDebloq.Text = "";
                    tbClaveDebloq.Visible = true;
                    btnAceptaClave.Visible = true;
                    btnCancelaDesbloq.Visible = true;
                    btnDesbloq.Visible = false;
                    tbClaveDebloq.Focus();
                }
                else
                {
                    MensajeError("No tiene permisos para modificar el Stock");
                }
            }
            
        }

        private void btnAceptaClave_Click(object sender, EventArgs e)
        {
            if (UserLoginCache.Clave == tbClaveDebloq.Text)
            {
                panelDesbloq.Visible = false;
                tbClaveDebloq.Text = "";
                tbClaveDebloq.Visible = false;
                btnAceptaClave.Visible = false;
                btnCancelaDesbloq.Visible = false;
                btnDesbloq.Visible = true;
                btnDesbloq.IconChar = FontAwesome.Sharp.IconChar.Lock;
                tbStock.Enabled = true;
                MensajeOk(UserLoginCache.Nombre+" "+ UserLoginCache.Apellido + " Ahora puede MODIFICAR el STOCK de PRODUCTOS");
            }
            else
            {
                MensajeError("CLAVE INCORRECTA");
            }            
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
                cbUdeMed.SelectedValue = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID_UNIDAD"].Value);
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            stockM = 0;
            stockA = 0;
            tabProductos.SelectedTab = tabNuevoProducto;
        }

        private void btnActualizarListaProd_Click(object sender, EventArgs e)
        {
            tbBusca.Text = "";
            CargarGrilla();
        }

        private void tbGanancia_TextChanged(object sender, EventArgs e)
        {
            if (tbGanancia.Text != "")
            {
                lblErrorGanancia.Visible = false;
            }
            else
            {
                lblErrorGanancia.Visible = true;
            }

            if (tbGanancia.Text == "00")
            {
                tbGanancia.Text = "0";
                tbGanancia.Select(tbGanancia.Text.Length, 0);
            }
            if (tbGanancia.Text == ",")
            {
                tbGanancia.Text = "0,";
                tbGanancia.Select(tbGanancia.Text.Length, 0);
            }
            if (tbGanancia.Text == "0,00")
            {
                tbGanancia.Text = "0,0";
                tbGanancia.Select(tbGanancia.Text.Length, 0);
            }
            haceCalculo();
            tbVenta.Text = resultado;
            resultado = "";
        }

        private void tbStock_TextChanged(object sender, EventArgs e)
        {
            if (tbStock.Text == "00")
            {
                tbStock.Text = "0";
                tbStock.Select(tbStock.Text.Length, 0);
            }
            if (tbStock.Text == ",")
            {
                tbStock.Text = "0,";
                tbStock.Select(tbStock.Text.Length, 0);
            }
            if (tbStock.Text == "0,00")
            {
                tbStock.Text = "0,0";
                tbStock.Select(tbStock.Text.Length, 0);
            }
            if (tbStock.Text !="0" && tbStock.Text != "0,00" && tbStock.Text != "," && tbStock.Text != "")
            {
                stockA = Convert.ToDecimal(tbStock.Text.Trim());
            }
            else
            {
                stockA = 0;
            }
        }
    }
}
