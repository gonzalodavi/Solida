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
    public partial class FormOPagos : Form
    {
        CN_CtaCte objeto = new CN_CtaCte();
        CN_Recibo objeto1 = new CN_Recibo();
        CN_CuentaBancaria objetoBanco = new CN_CuentaBancaria();

        public static int contadorFila = 0, contadorFilaBco = 0;
        private string detalleTransf = "", detalleValores = "";
        private DataTable DTDetalles, DTDetallesBco, DTCheque;

        public FormOPagos()
        {
            InitializeComponent();
        }

        private void FormOPagos_Load(object sender, EventArgs e)
        {
            ConsultaPorChequeSelecc();
            ConsultaPorTransferencia();
            ConsultaPorCheque();
            fechaHoy();
            CargarComboBoxProveedores();
            CargarGrillaOPagos();
            CargaGrillaCheques();
            CargaGrillaChequesSelect();
            CargaSaldoCtaCte();
            CrearTablaBco();
            BuscaNumeroOPago();
            CargarComboBoxCuentas();
        }

        

        private void CargaGrillaCheques()
        {
            this.dgvCheques.DataSource = CN_Cheque.MostrarXFecha("ACTIVO");
            this.dgvCheques.Columns[0].Visible = false;
            this.dgvCheques.Columns[1].Visible = false;
            this.dgvCheques.Columns[2].Visible = false;
            this.dgvCheques.Columns[8].Visible = false;
            this.dgvCheques.Columns[10].Visible = false;

            CantidadYSuma();
            
            /*this.dgvValores.Columns[3].Width = 80;
            this.dgvValores.Columns[4].Width = 80;
            this.dgvValores.Columns[5].Width = 80;
            this.dgvValores.Columns[6].Width = 90;
            this.dgvValores.Columns[7].Width = 100;
            this.dgvValores.Columns[9].Width = 100;*/
        }

        private void CargaGrillaChequesSelect()
        {
            this.dgvValoresSeleccionados.DataSource = CN_Cheque.MostrarXFecha("SELECCIONADO");
            this.dgvValoresSeleccionados.Columns[0].Visible = false;
            this.dgvValoresSeleccionados.Columns[1].Visible = false;
            this.dgvValoresSeleccionados.Columns[2].Visible = false;
            this.dgvValoresSeleccionados.Columns[8].Visible = false;
            this.dgvValoresSeleccionados.Columns[10].Visible = false;

            CantidadYSumaSeleccionados();

            /*this.dgvValoresSeleccionados.Columns[3].Width = 80;
            this.dgvValoresSeleccionados.Columns[4].Width = 80;
            this.dgvValoresSeleccionados.Columns[5].Width = 80;
            this.dgvValoresSeleccionados.Columns[6].Width = 90;
            this.dgvValoresSeleccionados.Columns[7].Width = 100;
            this.dgvValoresSeleccionados.Columns[9].Width = 100;*/
        }

        private void CargarComboBoxCuentas()
        {
            cbCuentaBanco.DataSource = objetoBanco.CargaCuentasBanco();
            cbCuentaBanco.DisplayMember = "NOMBRE";
            cbCuentaBanco.ValueMember = "ID_BANCO";
            cbCuentaBanco.SelectedIndex = -1;
        }

        private void fechaHoy()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            dtpFechaRecibo.Value = DateTime.Now;
            dtpFecha1.Value = new DateTime(year, month, 1);
            dtpFecha2.Value = DateTime.Now;
            dtpTransferencia.Value = DateTime.Now;
        }

        private void CargarGrillaOPagos()
        {
            if (chekVerAnulados.Checked == false)
            {
                this.dgvOPago.DataSource = CN_Recibo.MostrarOP();
                this.dgvOPago.Columns[0].Visible = false;
                this.dgvOPago.Columns[3].Visible = false;
                this.dgvOPago.Columns[7].Visible = false;

                this.dgvOPago.Columns[1].Width = 80;
                this.dgvOPago.Columns[2].Width = 50;
                this.dgvOPago.Columns[4].Width = 100;
                this.dgvOPago.Columns[5].Width = 100;
                this.dgvOPago.Columns[6].Width = 80;
            }
            else
            {
                this.dgvOPago.DataSource = CN_Recibo.MostrarAnuladosOP();
                this.dgvOPago.Columns[0].Visible = false;
                this.dgvOPago.Columns[3].Visible = false;
                this.dgvOPago.Columns[7].Visible = false;

                this.dgvOPago.Columns[1].Width = 80;
                this.dgvOPago.Columns[2].Width = 50;
                this.dgvOPago.Columns[4].Width = 100;
                this.dgvOPago.Columns[5].Width = 100;
                this.dgvOPago.Columns[6].Width = 80;
            }
        }
        private void CrearTablaBco()
        {
            DTDetallesBco = new DataTable();
            DTDetallesBco.Columns.Add("ID_TRANSF", Type.GetType("System.Int32"));              //0
            DTDetallesBco.Columns.Add("NUM_TRANSF", Type.GetType("System.String"));            //1
            DTDetallesBco.Columns.Add("FECHA_TRANSF", Type.GetType("System.DateTime"));        //2
            DTDetallesBco.Columns.Add("ID_BANCO", Type.GetType("System.Int32"));               //3
            DTDetallesBco.Columns.Add("CTA_BCO", Type.GetType("System.String"));               //4
            DTDetallesBco.Columns.Add("TITULAR", Type.GetType("System.String"));               //5
            DTDetallesBco.Columns.Add("IMPORTE", Type.GetType("System.Decimal"));              //6


            this.dgvTransferencias.DataSource = DTDetallesBco;

            dgvTransferencias.Columns["ID_TRANSF"].Visible = false;              //0
            dgvTransferencias.Columns["ID_BANCO"].Visible = false;               //3
            //dgvTransferencias.Columns["TITULAR"].Visible = false;               //5
        }

        private void ConsultaPorTransferencia()
        {
            string rpta = CN_Banco.ConsultaSiExisteTransf("PENDIENTE");
            if (rpta.Equals("OK"))
            {

            }
            else
            {
                if (rpta.Equals("NO"))
                {
                    //MensajeOk("No Hay Cheques COMO PENDIENTES");
                }
                else
                {
                    // MensajeError(rpta);
                }
            }
        }

        private void ConsultaPorCheque()
        {
            string rpta = CN_Cheque.ConsultaSiExisteCheque("PENDIENTE");
            if (rpta.Equals("OK"))
            {

            }
            else
            {
                if (rpta.Equals("NO"))
                {
                    //MensajeOk("No Hay Cheques COMO PENDIENTES");
                }
                else
                {
                    // MensajeError(rpta);
                }
            }
        }

        private void ConsultaPorChequeSelecc()
        {
            try
            {
                string rpta = CN_Cheque.ConsultaEstadoCheque("SELECCIONADO");
                if (rpta.Equals("OK"))
                {
                    string rpta1 = CN_Cheque.ModificarEstadoCheque("SELECCIONADO", "ACTIVO",0);
                    if (rpta1.Equals("OK"))
                    {
                        //MensajeOk("Cheques ENCONTRADOS SUELTOS VOLVIERON A CARTERA");
                    }
                    else
                    {
                        //MensajeError(rpta1);
                    }
                }
                else
                {
                    if (rpta.Equals("NO"))
                    {
                        //MensajeOk("No Hay Cheques COMO PENDIENTES");
                    }
                    else
                    {
                        //MensajeError(rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MensajeError("No se pudo ejecutar la operacion:\n\n" + ex);
            }
        }        

        private void CantidadYSuma()
        {
            try
            {                
                if (dgvCheques.Rows.Count > 0)
                {
                    string total = CN_Cheque.TotalCheques("ACTIVO");
                    int cantidad = CN_Cheque.CantidadCheques("ACTIVO");
                    tbCANTCheq.Text = cantidad.ToString();
                    tbSUMACheq.Text = Convert.ToDecimal(total).ToString("0.00");
                }
                else
                {
                    tbCANTCheq.Text = "0";
                    tbSUMACheq.Text = "0,00";
                }
            }
            catch (Exception ex)
            {
                MensajeError("No se pudo ejecutar la operacion:\n\n" + ex);
            }
        }
        private void CantidadYSumaSeleccionados()
        {
            try
            {
                if (dgvValoresSeleccionados.Rows.Count > 0)
                {
                    string total = CN_Cheque.TotalCheques("SELECCIONADO");
                    tbCheqTotal.Text = Convert.ToDecimal(total).ToString("0.00");
                }
                else
                {                    
                    tbCheqTotal.Text = "0,00";
                }               
            }
            catch (Exception ex)
            {
                MensajeError("No se pudo ejecutar la operacion:\n\n" + ex);
            }
        }

        private void ResetOPago()
        {
            tbBanco.Text = "0,00";
            tbValores.Text = "0,00";
            tbEfectivo.Text = "0,00";
            lblTotalOPago.Text = "0,00";
            tbDetalleOPago.Text = "";
            tbNumOPago.Text = "";
            cbProveedor.SelectedIndex = -1;
            CargaGrillaChequesSelect();
            CargaGrillaCheques();
            BuscaNumeroOPago();
        }

        private void BuscaNumeroOPago()
        {
            int numOPago = objeto1.MostrarUltimaOPago();
            tbNumOPago.Text = (numOPago + 1).ToString();
        }


        private void CargarComboBoxProveedores()
        {
            cbProveedor.DataSource = objeto.CargaProveedores();
            cbProveedor.DisplayMember = "NOMBRE";
            cbProveedor.ValueMember = "CUIL_CUIT";
            cbProveedor.SelectedIndex = -1;
        }


        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProveedor.SelectedIndex != -1)
            {
                CargaGrillaCtaCte(cbProveedor.SelectedValue.ToString());
                CargaSaldoCtaCte();
                tbTitTransf.Text = cbProveedor.Text;
            }else
            {
                tbTitTransf.Text = "";
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


        private void CargaGrillaCtaCte(string cuit)
        {
            this.dgvDetCtaCte.DataSource = CN_CtaCte.MostrarDetalleCtaCteCompletoP(cuit);
            AcomodaTablaCtaCte();
        }

        private void AcomodaTablaCtaCte()
        {
            this.dgvDetCtaCte.Columns[0].Visible = false;
            this.dgvDetCtaCte.Columns[6].Visible = false;

            /*this.dgvValores.Columns["FECHA_EMISION"].Width = 50;
            this.dgvValores.Columns["FECHA_CREDITO"].Width = 50;
            this.dgvValores.Columns["FECHA_EMISION"].Width = 50;
            this.dgvValores.Columns["BANCO"].Width = 90;
            this.dgvValores.Columns["TITULAR"].Width = 100;
            this.dgvValores.Columns["BENEF"].Width = 100;
            this.dgvValores.Columns["IMPORTE"].Width = 80;*/
        }

        private void AcomodaTablaTransferencia()
        {
            this.dgvTransferencias.Columns["NUM_TRANSF"].Width = 70;
            this.dgvTransferencias.Columns["FECHA_TRANSF"].Width = 80;
            this.dgvTransferencias.Columns["CTA_BCO"].Width = 140;
            this.dgvTransferencias.Columns["TITULAR"].Width = 120;
            this.dgvTransferencias.Columns["IMPORTE"].Width = 80;
        }

        private void CargaSaldoCtaCte()
        {
            if (cbProveedor.SelectedIndex != -1)
            {
                CN_CtaCte obsaldo = new CN_CtaCte();

                decimal suma = 0;
                foreach (DataGridViewRow row in dgvDetCtaCte.Rows)
                {
                    if (row.Cells["IMPORTE"].Value != null)
                        suma += (Decimal)row.Cells["IMPORTE"].Value;
                }
                decimal saldo = obsaldo.MostrarSaldoP(cbProveedor.SelectedValue.ToString());

                this.lblSaldo.Text = saldo.ToString();
            }
            else
            {
                this.lblSaldo.Text = "0,00";
            }
        }




        private void btnAceptaOPago_Click(object sender, EventArgs e)
        {
            agregaOPago();
        }

        private void agregaOPago()
        {
            if (cbProveedor.SelectedIndex != -1)
            {
                if (lblTotalOPago.Text != "")
                {
                    decimal totopag = Convert.ToDecimal(lblTotalOPago.Text);
                    if (totopag <= 0)
                    {
                        MensajeError("Por Favor Ingrese un Importe");
                    }
                    else
                    {
                        if (tbNumOPago.Text == "" || tbNumOPago.Text == "0")
                        {
                            MensajeError("Por Favor Ingrese un Numero de Comprobante");
                        }
                        else
                        {
                            try
                            {
                                Decimal efectivo = 0, valores = 0, banco = 0;
                                if (tbEfectivo.Text != "," && tbEfectivo.Text != "")
                                {
                                    efectivo = Convert.ToDecimal(tbEfectivo.Text.ToString());
                                }
                                if (tbValores.Text != "," && tbValores.Text != "")
                                {
                                    valores = Convert.ToDecimal(tbValores.Text.ToString());
                                }
                                if (tbBanco.Text != "," && tbBanco.Text != "")
                                {
                                    banco = Convert.ToDecimal(tbBanco.Text.ToString());
                                }
                                Decimal Suma = efectivo + valores + banco;

                                lblTotalOPago.Text = Suma.ToString("0.00");

                                string rpta = "";
                                string rpta1 = "";

                                DialogResult Opcion;
                                string DetalleComprobante = tbDetalleOPago.Text + "\r\n" + detalleValores + detalleTransf;
                                Opcion = MessageBox.Show("Desea Generar Nuevo Comprobante?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (Opcion == DialogResult.OK)
                                {
                                    string Estado = "ACTIVO";
                                    rpta = CN_Recibo.InsertarOP(tbNumOPago.Text, dtpFechaRecibo.Value, cbProveedor.SelectedValue.ToString(), Convert.ToInt32(UserLoginCache.UserId), efectivo, valores, banco, Suma, DetalleComprobante, Estado);
                                    decimal debe = Suma, haber = 0;

                                    if (rpta.Equals("OK"))
                                    {
                                        this.MensajeOk("Se Generó con éxito el Comprobante");
                                        int idOPago = objeto1.BuscarUltimoIDOPago();

                                        if (efectivo > 0)
                                        {
                                            string res1 = "";
                                            try
                                            {
                                                res1 = CN_Caja.Insertar(tbNumOPago.Text, "ORDEN DE PAGO", dtpFechaRecibo.Value, cbProveedor.Text, cbProveedor.SelectedValue.ToString(), "ACTIVO", 0, efectivo, -1 * efectivo);
                                                if (res1.Equals("OK"))
                                                {
                                                    MensajeOk("Se Inserto el Movimiento de Caja");
                                                }
                                                else
                                                {
                                                    MensajeError(res1);
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message + ex.StackTrace);
                                            }
                                        }

                                        if (valores > 0)
                                        {
                                            string rptActCheq = CN_Cheque.ModificarEstadoCheque("SELECCIONADO", "PAGADO", idOPago);

                                            if (rptActCheq.Equals("OK"))
                                            {
                                                // MensajeOk("Cheques ESTADO: PAGADO");
                                            }
                                            else
                                            {
                                                // MensajeError(rpta1);
                                            }
                                        }


                                        if (banco > 0)
                                        {
                                            string rptActTransf = CN_Banco.ActivarTransfPendientes("PENDIENTE", "ACTIVO");
                                            if (rptActTransf.Equals("OK"))
                                            {
                                                this.MensajeOk("Se ACTIVARON LAS TRANSFERENCIAS");
                                            }
                                            else
                                            {
                                                this.MensajeError(rptActTransf);
                                            }
                                        }

                                        rpta = CN_CtaCte.InsertarP(cbProveedor.SelectedValue.ToString(), dtpFechaRecibo.Value, tbNumOPago.Text, "ORDEN DE PAGO", debe, haber, valores, efectivo, banco, (debe - haber), 0, 0, "N", Estado);
                                        if (rpta.Equals("OK"))
                                        {
                                            //this.MensajeOk("Se registro en cuenta corriente");
                                        }
                                        else
                                        {
                                            this.MensajeError(rpta);
                                        }
                                        ResetOPago();
                                        CargarGrillaOPagos();
                                        tabOrdenPagos.SelectedTab = tabConsultaOPagos;
                                    }
                                    else
                                    {
                                        this.MensajeError(rpta);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message + ex.StackTrace);
                            }
                        }
                    }
                }
                else
                {
                    MensajeError("Por Favor, Ingrese un Importe");
                }
            }
            else
            {
                MensajeError("Por Favor, Seleccione un Proveedor");
            }
        }

        private void btnActualizaLista_Click(object sender, EventArgs e)
        {
            CargarGrillaOPagos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarRegistros();
        }

        private void BuscarRegistros()
        {
            if (chekVerAnulados.Checked == false)
            {
                dgvOPago.DataSource = CN_Recibo.BuscarRegistrosOP(dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
                this.dgvOPago.Columns[0].Visible = false;
            }
            else
            {
                dgvOPago.DataSource = CN_Recibo.BuscarRegistrosAnuladosOP(dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
                this.dgvOPago.Columns[0].Visible = false;
            }
        }

        private void chekVerAnulados_CheckedChanged(object sender, EventArgs e)
        {
            if (chekVerAnulados.Checked == true)
            {
                btnImprimir.Enabled = false;
            }
            else
            {
                btnImprimir.Enabled = true;
            }
            CargarGrillaOPagos();
        }

        private void tbEfectivo_Leave(object sender, EventArgs e)
        {
            Decimal efectivo = 0, valores = 0, banco = 0;
            if (tbEfectivo.Text != "," && tbEfectivo.Text != "")
            {
                efectivo = Convert.ToDecimal(tbEfectivo.Text.ToString());
            }
            if (tbValores.Text != "," && tbValores.Text != "")
            {
                valores = Convert.ToDecimal(tbValores.Text.ToString());
            }
            if (tbBanco.Text != "," && tbBanco.Text != "")
            {
                banco = Convert.ToDecimal(tbBanco.Text.ToString());
            }
            Decimal Suma = efectivo + valores + banco;
            lblTotalOPago.Text = Suma.ToString("0.00");
        }

        private void tbValores_Leave(object sender, EventArgs e)
        {
            Decimal efectivo = 0, valores = 0, banco = 0;
            if (tbEfectivo.Text != "," && tbEfectivo.Text != "")
            {
                efectivo = Convert.ToDecimal(tbEfectivo.Text.ToString());
            }
            if (tbValores.Text != "," && tbValores.Text != "")
            {
                valores = Convert.ToDecimal(tbValores.Text.ToString());
            }
            if (tbBanco.Text != "," && tbBanco.Text != "")
            {
                banco = Convert.ToDecimal(tbBanco.Text.ToString());
            }
            Decimal Suma = efectivo + valores + banco;
            lblTotalOPago.Text = Suma.ToString("0.00");
        }

        private void tbBanco_Leave(object sender, EventArgs e)
        {
            Decimal efectivo = 0, valores = 0, banco = 0;
            if (tbEfectivo.Text != "," && tbEfectivo.Text != "")
            {
                efectivo = Convert.ToDecimal(tbEfectivo.Text.ToString());
            }
            if (tbValores.Text != "," && tbValores.Text != "")
            {
                valores = Convert.ToDecimal(tbValores.Text.ToString());
            }
            if (tbBanco.Text != "," && tbBanco.Text != "")
            {
                banco = Convert.ToDecimal(tbBanco.Text.ToString());
            }
            Decimal Suma = efectivo + valores + banco;
            lblTotalOPago.Text = Suma.ToString("0.00");
        }

        private void tbEfectivo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbValores_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbBanco_KeyPress(object sender, KeyPressEventArgs e)
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
            if (dgvOPago.SelectedRows.Count > 0)
            {
                FormReporteOPago form = new FormReporteOPago();
                form.IdOPago = Convert.ToInt32(this.dgvOPago.CurrentRow.Cells["ID_OPAGO"].Value);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por Favor seleccione un comprobante");
            }
        }

        private void tbNumOPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ConsultaPorTransferencia();
            ConsultaPorChequeSelecc();
            this.Close();
        }

        private void btnAgregaCheques_Click(object sender, EventArgs e)
        {
            if (dgvCheques.SelectedRows.Count > 0)
            {
                SeleccionaCheques();
                CargaGrillaCheques();
                CargaGrillaChequesSelect();
            }
            else
            {
                MensajeError("No existen Cheques para Agregar la Lista");
            }
        }

        private void SeleccionaCheques()
        {
            try
            {
                CN_Cheque.ModificarCheque(Convert.ToInt32(dgvCheques.CurrentRow.Cells["ID_CHEQUE"].Value.ToString()), "ACTIVO", "SELECCIONADO");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnQuitaCheque_Click(object sender, EventArgs e)
        {
            if (dgvValoresSeleccionados.SelectedRows.Count > 0)
            {                
                QuitaCheques();
                CargaGrillaCheques();
                CargaGrillaChequesSelect();
            }
            else
            {
                MensajeError("No existen Cheques a Eliminar de la Lista");
            }
        }

        private void QuitaCheques()
        {
            try
            {
                CN_Cheque.ModificarCheque(Convert.ToInt32(dgvValoresSeleccionados.CurrentRow.Cells["ID_CHEQUE"].Value.ToString()), "SELECCIONADO", "ACTIVO");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnGuardarValores_Click(object sender, EventArgs e)
        {
            detalleValores = "";
            if (dgvValoresSeleccionados.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow ElRow in dgvValoresSeleccionados.Rows)
                {
                    string DetNumCheq = ElRow.Cells["NUM_CHEQUE"].Value.ToString();
                    string DetNomBan = ElRow.Cells["NOM_BANCO"].Value.ToString();
                    string DetFecC = Convert.ToDateTime(ElRow.Cells["FECHA_CREDITO"].Value).ToString("yyyy-MM-dd");
                    string DetImporte = ElRow.Cells["IMPORTE"].Value.ToString();

                    if (DetNomBan != "" && DetImporte != "" && DetNumCheq != "")
                    {
                        detalleValores += "Valor Nº " + DetNumCheq + " de Banco " + DetNomBan + " al " + DetFecC + " con importe $" + DetImporte + " // ";
                    }
                }
                
                tbValores.Text = tbCheqTotal.Text;
                tabOrdenPagos.SelectedTab = tabNuevaOPago;
            }
            else
            {
                DialogResult opcion;
                opcion = MessageBox.Show("No se cargo ningun cheque, Desea ir al Pago?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    tbValores.Text = "0,00";
                    tabOrdenPagos.SelectedTab = tabNuevaOPago;
                }
            }
        }

        private void tbValores_TextChanged(object sender, EventArgs e)
        {

            Decimal efectivo = 0, valores = 0, banco = 0;
            if (tbEfectivo.Text != "," && tbEfectivo.Text != "")
            {
                efectivo = Convert.ToDecimal(tbEfectivo.Text.ToString());
            }
            if (tbValores.Text != "," && tbValores.Text != "")
            {
                valores = Convert.ToDecimal(tbValores.Text.ToString());
            }
            if (tbBanco.Text != "," && tbBanco.Text != "")
            {
                banco = Convert.ToDecimal(tbBanco.Text.ToString());
            }
            Decimal Suma = efectivo + valores + banco;
            lblTotalOPago.Text = Suma.ToString("0.00");
        }

        private void lblTotalOPago_TextChanged(object sender, EventArgs e)
        {
            if (lblTotalOPago.Text != "")
            {
                Decimal importePend = Convert.ToDecimal(lblTotalOPago.Text);
                if (importePend > 0)
                {
                    Decimal saldo = Convert.ToDecimal(lblSaldo.Text) + Convert.ToDecimal(lblTotalOPago.Text);
                    if (saldo == 0)
                    {
                        lblSaldoPendiente.Text = "0,00";
                    }
                    lblSaldoPendiente.Text = saldo.ToString("0.00");
                }
                else
                {
                    lblSaldoPendiente.Text = "";
                }
            }
            else
            {
                lblSaldoPendiente.Text = "";
            }
        }

        private void btnAgregaValores_Click(object sender, EventArgs e)
        {
            tabOrdenPagos.SelectedTab = tabValores;
        }

        private void btnAgregaTransf_Click(object sender, EventArgs e)
        {
            tabOrdenPagos.SelectedTab = tabTransferencias;
        }

        private void tbTransfImporte_TextChanged(object sender, EventArgs e)
        {
            Decimal importeT = 0;
            if (tbTransfImporte.Text != "," && tbTransfImporte.Text != "")
            {
                importeT = Convert.ToDecimal(tbTransfImporte.Text.Trim());
            }

            tbImporteTransf.Text = importeT.ToString("0.00");
        }

        private void tbNumTransf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbTransfImporte_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnEliminaTransf_Click(object sender, EventArgs e)
        {
            if (dgvTransferencias.SelectedRows.Count > 0)
            {
                try
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("Desea ELIMINAR la Transferencia seleccionada?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        int idTransferencia = Convert.ToInt32(dgvTransferencias.CurrentRow.Cells["ID_TRANSF"].Value.ToString());
                        string rpta = CN_Banco.EliminarTransf(idTransferencia);
                        if (rpta.Equals("OK"))
                        {
                            int IndiceFila = dgvTransferencias.CurrentCell.RowIndex;
                            DataRow row = DTDetallesBco.Rows[IndiceFila];

                            DTDetallesBco.Rows.Remove(row);
                            tbTransfImporte.Text = "0,00";
                            tbImporteTransf.Text = "";
                            contadorFilaBco--;
                            AcomodaTablaTransferencia();
                            SumaTransferencias();
                            MessageBox.Show("Se elimino la transferencia de la lista");
                        }
                        else
                        {
                            MensajeError("No se pudo eliminar la transferencia por: \n\n" + rpta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MensajeError("No se pudo ejecutar la operacion: \n\n" + ex);
                }
            }
            else
            {
                MessageBox.Show("No existen cheques cargados");
            }
        }

        private void btnGuardarTransf_Click(object sender, EventArgs e)
        {            
            detalleTransf = "";
            if (dgvTransferencias.Rows.Count > 0)
            {
                foreach (DataGridViewRow ElRow in dgvTransferencias.Rows)
                {
                    string numtra = ElRow.Cells["NUM_TRANSF"].Value.ToString();
                    string DetNumTransf = "";
                    if (numtra != "")
                    {
                        DetNumTransf = "Nº " + numtra + " ";
                    }
                    string DetNom = ElRow.Cells["TITULAR"].Value.ToString();
                    string DetImporte = ElRow.Cells["IMPORTE"].Value.ToString();

                    if (DetNom != "" && DetImporte != "")
                    {
                        detalleTransf += "Transferencia " + DetNumTransf + "de " + DetNom + " por $" + DetImporte + "\r\n";
                    }
                }
                tbBanco.Text = tbTransfTotal.Text;
                tabOrdenPagos.SelectedTab = tabNuevaOPago;
            }
            else
            {
                DialogResult opcion;
                opcion = MessageBox.Show("No se cargo ninguna Transferencia, Desea ir a la Orden de Pago?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    tbBanco.Text = "0,00";
                    tabOrdenPagos.SelectedTab = tabNuevaOPago;
                }
            }
        }

        private void tbBanco_TextChanged(object sender, EventArgs e)
        {
            Decimal efectivo = 0, valores = 0, banco = 0;
            if (tbEfectivo.Text != "," && tbEfectivo.Text != "")
            {
                efectivo = Convert.ToDecimal(tbEfectivo.Text.ToString());
            }
            if (tbValores.Text != "," && tbValores.Text != "")
            {
                valores = Convert.ToDecimal(tbValores.Text.ToString());
            }
            if (tbBanco.Text != "," && tbBanco.Text != "")
            {
                banco = Convert.ToDecimal(tbBanco.Text.ToString());
            }
            Decimal Suma = efectivo + valores + banco;
            lblTotalOPago.Text = Suma.ToString("0.00");
        }

        private void tbEfectivo_TextChanged(object sender, EventArgs e)
        {
            if (tbEfectivo.Text == "00")
            {
                tbEfectivo.Text = "0";
                tbEfectivo.Select(tbEfectivo.Text.Length, 0);
            }
            if (tbEfectivo.Text == ",")
            {
                tbEfectivo.Text = "0,";
                tbEfectivo.Select(tbEfectivo.Text.Length, 0);
            }
            if (tbEfectivo.Text == "0,00")
            {
                tbEfectivo.Text = "0,0";
                tbEfectivo.Select(tbEfectivo.Text.Length, 0);
            }

            Decimal efectivo = 0, valores = 0, banco = 0;
            if (tbEfectivo.Text != "," && tbEfectivo.Text != "")
            {
                efectivo = Convert.ToDecimal(tbEfectivo.Text.ToString());
            }
            if (tbValores.Text != "," && tbValores.Text != "")
            {
                valores = Convert.ToDecimal(tbValores.Text.ToString());
            }
            if (tbBanco.Text != "," && tbBanco.Text != "")
            {
                banco = Convert.ToDecimal(tbBanco.Text.ToString());
            }
            Decimal Suma = efectivo + valores + banco;
            lblTotalOPago.Text = Suma.ToString("0.00");
        }

        private void btnNuevaOPago_Click(object sender, EventArgs e)
        {
            tabOrdenPagos.SelectedTab = tabNuevaOPago;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvOPago.SelectedRows.Count > 0)
            {
                if (dgvOPago.CurrentRow.Cells[7].Value.ToString() != "ANULADO")
                {
                    string numComprob = dgvOPago.CurrentRow.Cells[2].Value.ToString();

                    DialogResult opcion;
                    opcion = MessageBox.Show("Desea ANULAR el comprobante seleccionado?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        CN_Recibo objetoCN = new CN_Recibo();
                        int idOPago = Convert.ToInt32(dgvOPago.CurrentRow.Cells["ID_OPAGO"].Value.ToString());
                        objetoCN.AnularOPago(idOPago);

                        MessageBox.Show("SE ANULÓ CORRECTAMENTE LA ORDEN DE PAGO SELECCIONADA");

                        string rptaID = CN_Cheque.EstadoCheque("PAGADO", "ACTIVO", idOPago);

                        string rpta = CN_CtaCte.AnularRegistroCtaCteP(dgvOPago.CurrentRow.Cells[2].Value.ToString(), "ORDEN DE PAGO");
                        if (rpta.Equals("OK"))
                        {
                            MessageBox.Show("Se QUITO EL REGISTO DE LA CTA CTE");
                        }
                        else
                        {
                            this.MensajeError(rpta);
                        }

                        string rpt = CN_Banco.Anular_TransfRealizadas(numComprob);
                        if (rpt.Equals("OK"))
                        {
                            this.MensajeOk("Se ANULARON las TRANSFERENCIAS de la Orden de Pago");
                        }

                        string rptCaja = CN_Caja.Anular_CajaMovRealizado(numComprob);
                        if (rptCaja.Equals("OK"))
                        {
                            this.MensajeOk("Se Anulo el movimiento de CAJA");
                        }


                        CargarGrillaOPagos();
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

        private void tbTransfImporte_Leave(object sender, EventArgs e)
        {
            Decimal importeT = 0;
            if (tbTransfImporte.Text != "," && tbTransfImporte.Text != "")
            {
                importeT = Convert.ToDecimal(tbTransfImporte.Text.Trim());
            }

            tbImporteTransf.Text = importeT.ToString("0.00");
        }

        private void btnAgregaTransfBco_Click(object sender, EventArgs e)
        {
            if (tbTransfImporte.Text != "" && cbCuentaBanco.SelectedIndex != -1)
            {
                if (tbImporteTransf.Text == "0,00")
                {
                    MensajeError("El importe de la transferencia tiene que ser superior a 0");
                }
                else
                {
                    InsertarTransferencia();
                    AcomodaTablaTransferencia();
                    SumaTransferencias();
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete los campos requeridos");
            }
        }

        private void InsertarTransferencia()
        {
            try
            {
                bool existe = false;

                if (contadorFilaBco == 0)
                {
                    string numTransf = Convert.ToString(tbNumTransf.Text);
                    DateTime fec = Convert.ToDateTime(dtpTransferencia.Text);
                    int IdBco = Convert.ToInt32(cbCuentaBanco.SelectedValue);
                    string Bco = Convert.ToString(cbCuentaBanco.Text);
                    string Titu = Convert.ToString(tbTitTransf.Text);
                    decimal debe = 0;
                    decimal haber = Convert.ToDecimal(tbTransfImporte.Text);
                    decimal Import = debe - haber;
                    string estad = "PENDIENTE";

                    string respta1 = CN_Banco.Insertar(tbNumOPago.Text, "ORDEN DE PAGO", numTransf, fec, IdBco, Bco, Titu, debe, haber, Import, estad);

                    if (respta1.Equals("OK"))
                    {
                        int id = CN_Banco.ConsultaUltimaTransf();

                        DataRow row = DTDetallesBco.NewRow();

                        row["ID_TRANSF"] = id;
                        row["NUM_TRANSF"] = numTransf;
                        row["FECHA_TRANSF"] = fec;
                        row["ID_BANCO"] = IdBco;
                        row["CTA_BCO"] = Bco;
                        row["TITULAR"] = Titu;
                        row["IMPORTE"] = haber;

                        DTDetallesBco.Rows.Add(row);

                        tbTransfImporte.Text = "0,00";
                        tbImporteTransf.Text = "";
                        tbNumTransf.Text = "";
                        contadorFilaBco++;
                    }
                    else
                    {
                        MensajeError(respta1);
                    }
                }
                else
                {
                    foreach (DataGridViewRow Fila1 in dgvTransferencias.Rows)
                    {
                        if (Fila1.Cells[1].Value.ToString() == tbNumTransf.Text && Fila1.Cells[5].Value.ToString() == tbTitTransf.Text)
                        {
                            existe = true;
                        }
                    }
                    if (existe == true)
                    {
                        MensajeError("La Transferencia a ingresar ya existe");
                    }
                    else
                    {
                        string numTransf = Convert.ToString(tbNumTransf.Text);
                        DateTime fec = Convert.ToDateTime(dtpTransferencia.Text);
                        int IdBco = Convert.ToInt32(cbCuentaBanco.SelectedValue);
                        string Bco = Convert.ToString(cbCuentaBanco.Text);
                        string Titu = Convert.ToString(tbTitTransf.Text);
                        decimal debe = 0;
                        decimal haber = Convert.ToDecimal(tbTransfImporte.Text);
                        decimal Import = debe - haber;
                        string estad = "PENDIENTE";

                        string respta2 = CN_Banco.Insertar(tbNumOPago.Text, "ORDEN DE PAGO", numTransf, fec, IdBco, Bco, Titu, debe, haber, Import, estad);

                        if (respta2.Equals("OK"))
                        {
                            int id = CN_Banco.ConsultaUltimaTransf();

                            DataRow row = DTDetallesBco.NewRow();

                            row["ID_TRANSF"] = id;
                            row["NUM_TRANSF"] = numTransf;
                            row["FECHA_TRANSF"] = fec;
                            row["ID_BANCO"] = IdBco;
                            row["CTA_BCO"] = Bco;
                            row["TITULAR"] = Titu;
                            row["IMPORTE"] = haber;

                            DTDetallesBco.Rows.Add(row);

                            tbTransfImporte.Text = "0,00";
                            tbImporteTransf.Text = "";
                            tbNumTransf.Text = "";
                            contadorFilaBco++;
                        }
                        else
                        {
                            MensajeError(respta2);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MensajeError("No se pudo cargar los datos por:\n\n" + ex);
            }
        }

        private void SumaTransferencias()
        {
            decimal suma = 0;
            foreach (DataGridViewRow row in dgvTransferencias.Rows)
            {
                if (row.Cells["IMPORTE"].Value != null)
                    suma += (Decimal)row.Cells["IMPORTE"].Value;
            }
            tbTransfTotal.Text = suma.ToString("0.00");
        }
    }
}
