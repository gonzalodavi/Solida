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
    public partial class FormReciboDePago : Form
    {
        CN_CtaCte objeto = new CN_CtaCte();
        CN_Recibo objeto1 = new CN_Recibo();
        CN_CuentaBancaria objetoBanco = new CN_CuentaBancaria();

        private decimal importeFactura = 0;
        private decimal importeEfectivo = 0;
        private decimal importeValores = 0;
        private decimal importeBanco = 0;
        private DataTable DTDetalles, DTDetallesBco;
        public static int contadorFila = 0, contadorFilaBco;

        private string detalleTransf = "", detalleValores = "";
        

        public FormReciboDePago()
        {
            InitializeComponent();
        }

        private void FormReciboDePago_Load(object sender, EventArgs e)
        {
            ConsultaPorCheque();
            ConsultaPorTransferencia();
            fechaHoy();
            BuscaNumeroRecibo();
            CrearTabla();
            CrearTablaBco();
            CargarComboBoxCuentas();                
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

        private void CargarComboBoxCuentas()
        {
            cbCuentaBanco.DataSource = objetoBanco.CargaCuentasBanco();
            cbCuentaBanco.DisplayMember = "NOMBRE";
            cbCuentaBanco.ValueMember = "ID_BANCO";
            cbCuentaBanco.SelectedIndex = -1;
        }

        private void CrearTabla()
        {
            DTDetalles = new DataTable();
            DTDetalles.Columns.Add("ID_CHEQUE", Type.GetType("System.Int32"));              //0
            DTDetalles.Columns.Add("NUM_CHEQUE", Type.GetType("System.String"));            //1
            DTDetalles.Columns.Add("FECHA_EMISION", Type.GetType("System.DateTime"));       //2
            DTDetalles.Columns.Add("FECHA_CREDITO", Type.GetType("System.DateTime"));       //3
            DTDetalles.Columns.Add("BANCO", Type.GetType("System.String"));                 //4
            DTDetalles.Columns.Add("TITULAR", Type.GetType("System.String"));               //5
            DTDetalles.Columns.Add("BENEF", Type.GetType("System.String"));                 //6
            DTDetalles.Columns.Add("IMPORTE", Type.GetType("System.Decimal"));              //7


            this.dgvValores.DataSource = DTDetalles;

            dgvValores.Columns["ID_CHEQUE"].Visible = false;
            dgvValores.Columns["FECHA_EMISION"].Visible = false;
            dgvValores.Columns["TITULAR"].Visible = false;
            dgvValores.Columns["BENEF"].Visible = false;
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
            dgvTransferencias.Columns["TITULAR"].Visible = false;               //5
        }

        private void AcomodaTabla()
        {
            this.dgvValores.Columns["NUM_CHEQUE"].Width = 50;
            this.dgvValores.Columns["FECHA_CREDITO"].Width = 50;
            this.dgvValores.Columns["BANCO"].Width = 90;
            this.dgvValores.Columns["IMPORTE"].Width = 80;
        }

        private void AcomodaTablaTransferencia()
        {
            this.dgvTransferencias.Columns["NUM_TRANSF"].Width = 50;
            this.dgvTransferencias.Columns["FECHA_TRANSF"].Width = 50;
            this.dgvTransferencias.Columns["CTA_BCO"].Width = 90;
            this.dgvTransferencias.Columns["IMPORTE"].Width = 80;
        }

        private void BuscaNumeroRecibo()
        {
            int numRecibo = objeto1.MostrarUltimoRecibo();
            tbNumRecibo.Text = (numRecibo + 1).ToString();
        }

        private void fechaHoy()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            dtpFechaRecibo.Value = DateTime.Now;
            dtpCheqEmision.Value = DateTime.Now;
            dtpCheqCredito.Value = DateTime.Now;
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


        private void btnSalir_Click(object sender, EventArgs e)
        {
            ConsultaPorCheque();
            ConsultaPorTransferencia();
            this.Close();
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
        

        private void HaceCalculo()
        {  
            if (tbTotalAPagar.Text != "0,00")
            {
                importeFactura = Convert.ToDecimal(tbTotalAPagar.Text.Trim());
            }            

            if (tbEfectivo.Text != "0,00" && tbEfectivo.Text != "" && tbEfectivo.Text != "," && tbEfectivo.Text != "0")
            {                
                importeEfectivo = Convert.ToDecimal(tbEfectivo.Text.Trim());                
            }
            else
            {
                importeEfectivo = 0;
            }

            if (tbValores.Text != "0,00")
            {
                importeValores = Convert.ToDecimal(tbValores.Text.Trim());
            }
            else
            {
                importeValores = 0;
            }

            if (tbBanco.Text != "0,00")
            {
                importeBanco = Convert.ToDecimal(tbBanco.Text.Trim());
            }
            else
            {
                importeBanco = 0;
            }

            decimal importeAbonado = importeEfectivo + importeValores + importeBanco;

            if(importeAbonado > 0)
            {
                tbTotalPagado.Text = importeAbonado.ToString("0.00");
            }
            else
            {
                tbTotalPagado.Text = "0,00";
            }
            

            if (importeAbonado > importeFactura)
            {
                lblErrorLimiteAbonado.Visible = true;
            }
            else
            {
                lblErrorLimiteAbonado.Visible = false;                            
            }
            
            if(chekCambioJusto.Checked == false)
            {
                decimal dinero = 0, vuelto = 0;
                if (tbDineroEntregado.Text != "0,00" && tbDineroEntregado.Text != "" && tbDineroEntregado.Text != "," && tbDineroEntregado.Text != "0")
                {
                    dinero = Convert.ToDecimal(tbDineroEntregado.Text.Trim());
                }

                if (dinero > 0)
                {
                    vuelto = dinero - importeEfectivo;
                    tbVuelto.Text = vuelto.ToString("0.00");
                }
                else
                {
                    tbVuelto.Text = "0,00";
                }
            }
        }

        private void tbTotalAPagar_TextChanged(object sender, EventArgs e)
        {
            HaceCalculo();
        }

        private void tbEfectivo_TextChanged(object sender, EventArgs e)
        {
            HaceCalculo();
            
        }

        private void tbValores_TextChanged(object sender, EventArgs e)
        {
            HaceCalculo();
        }

        private void tbBanco_TextChanged(object sender, EventArgs e)
        {
            HaceCalculo();
        }

        private void btnGuardarValores_Click(object sender, EventArgs e)
        {           
            detalleValores = "";
            if (dgvValores.Rows.Count > 0)
            {
                foreach (DataGridViewRow ElRow in dgvValores.Rows)
                {
                    string DetNumCheq = ElRow.Cells["NUM_CHEQUE"].Value.ToString();
                    string DetNomBan = ElRow.Cells["BANCO"].Value.ToString();
                    string DetFecC = Convert.ToDateTime(ElRow.Cells["FECHA_CREDITO"].Value).ToString("yyyy-MM-dd");
                    string DetImporte = ElRow.Cells["IMPORTE"].Value.ToString();

                    if (DetNomBan != "" && DetImporte != "" && DetNumCheq != "")
                    {
                        detalleValores += "Valor Nº " + DetNumCheq + " de Banco " + DetNomBan + " al " + DetFecC + " con importe $" + DetImporte + "\r\n";
                    }
                }
                tbValores.Text = tbCheqTotal.Text;
                tabRecibos.SelectedTab = tabNuevoRecibo;
            }
            else
            {
                DialogResult opcion;
                opcion = MessageBox.Show("No se cargo ningun cheque, Desea ir al Recibo?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    tbValores.Text = "0,00";
                    tabRecibos.SelectedTab = tabNuevoRecibo;
                }
            }
        }

        private void btnAgregaCheques_Click(object sender, EventArgs e)
        {
            if (tbCheqNumero.Text != "" && tbCheqBanco.Text != "" && tbCheqTitular.Text != "" && tbCheqBenef.Text != "" && tbCheqImporte.Text != "")
            {
                Decimal importe = 0;
                if (tbCheqImporte.Text != "," && tbCheqImporte.Text != "")
                {
                    importe = Convert.ToDecimal(tbCheqImporte.Text.ToString());
                }

                tbImporteCheq.Text = importe.ToString("0.00");

                if (tbImporteCheq.Text == "0,00")
                {
                    MensajeError("El importe del cheque tiene que ser superior a 0");
                }
                else
                {
                    InsertarCheque();
                    AcomodaTabla();
                    SumaCheques();
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos");
            }
        }

        private void SumaCheques()
        {
            decimal suma = 0;
            foreach (DataGridViewRow row in dgvValores.Rows)
            {
                if (row.Cells["IMPORTE"].Value != null)
                    suma += (Decimal)row.Cells["IMPORTE"].Value;
            }
            tbCheqTotal.Text = suma.ToString("0.00");
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

        

        private void btnAgregaValores_Click(object sender, EventArgs e)
        {
            tabRecibos.SelectedTab = tabValores;
            tbCheqNumero.Focus();
        }

        private void btnAgregaTransf_Click(object sender, EventArgs e)
        {
            if (tbTransfImporte.Text != "" && cbCuentaBanco.SelectedIndex != -1)
            {
                Decimal importe = 0;
                if (tbTransfImporte.Text != "," && tbTransfImporte.Text != "")
                {
                    importe = Convert.ToDecimal(tbTransfImporte.Text.ToString());
                }

                tbImporteTransf.Text = importe.ToString("0.00");

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
                    decimal Import = Convert.ToDecimal(tbTransfImporte.Text);
                    string estad = "PENDIENTE";

                    string respta1 = CN_Banco.Insertar(tbNumRecibo.Text, "RECIBO DE PAGO", numTransf, fec, IdBco, Bco, Titu, Import, estad);

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
                        row["IMPORTE"] = Import;

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
                        decimal Import = Convert.ToDecimal(tbTransfImporte.Text);
                        string estad = "PENDIENTE";

                        string respta2 = CN_Banco.Insertar(tbNumRecibo.Text, "RECIBO DE PAGO", numTransf, fec, IdBco, Bco, Titu, Import, estad);

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
                            row["IMPORTE"] = Import;

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

        private void btnAceptaRecibo_Click(object sender, EventArgs e)
        {            
            if (tbTotalPagado.Text != "0,00")
            {
                Decimal pagado = Convert.ToDecimal(tbTotalPagado.Text.ToString());
                Decimal apagar = Convert.ToDecimal(tbTotalAPagar.Text.ToString());
                if (pagado == apagar)
                {
                    HacerRecibo();
                }
                else
                {
                    if (pagado < apagar)
                    {
                        MensajeError("No se permiten pagos parciales en operaciones de CONTADO");
                    }
                    else
                    {
                        MensajeError("No se permiten pagos Superiores al Facturado en operaciones de CONTADO");
                    }
                }
            }
            else
            {
                MensajeError("No se puede hacer un recibo igual o menor a $0");
            }
        }

        private void HacerRecibo()
        {
            try
            {
                string detalleRecibo = tbDetalleRecibo.Text + detalleValores + detalleTransf;
                decimal ImporteTotal = importeEfectivo + importeBanco + importeValores;
                string estado = "ACTIVO";
                string rpta = CN_Recibo.Insertar(tbNumRecibo.Text, dtpFechaRecibo.Value, tbDNI.Text, Convert.ToInt32(UserLoginCache.UserId), importeEfectivo, importeValores, importeBanco,ImporteTotal, detalleRecibo, estado);
                decimal debe = 0, haber = ImporteTotal;

                if (rpta.Equals("OK"))
                {
                    this.MensajeOk("Se Generó con éxito el RECIBO");
                    if(importeValores > 0)
                    {
                        string rptActCheq = CN_Cheque.ActivarChequesPendientes("PENDIENTE", "ACTIVO");
                        if (rptActCheq.Equals("OK"))
                        {
                            this.MensajeOk("Se ACTIVARON LOS CHEQUES");
                        }
                        else
                        {
                            this.MensajeError(rptActCheq);
                        }
                    }

                    if(importeBanco > 0)
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

                    rpta = CN_CtaCte.Insertar(tbDNI.Text, dtpFechaRecibo.Value, tbNumRecibo.Text, "RECIBO DE PAGO", debe, haber, importeValores, importeEfectivo, importeBanco, (debe - haber), ImporteTotal, 0, "S", estado);
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se Cargo recibo en CTA CTE");

                        rpta = CN_CtaCte.Modificar(tbNumFact.Text, "FACTURA DE VENTA", importeValores, importeEfectivo, importeBanco, ImporteTotal,ImporteTotal, "S");
                        if (rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Modifico la asignacion en cta cte.");
                            this.Close();
                        }
                        else
                        {
                            MensajeError(rpta);
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                }
                else
                {
                    this.MensajeError(rpta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnQuitaCheques_Click(object sender, EventArgs e)
        {
            if (dgvValores.SelectedRows.Count > 0)
            {
                try
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("Desea ELIMINAR el CHEQUE seleccionado?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {

                        int idCheq = Convert.ToInt32(dgvValores.CurrentRow.Cells["ID_CHEQUE"].Value.ToString());
                        string rpta = CN_Cheque.EliminarCheq(idCheq);
                        if (rpta.Equals("OK"))
                        {
                            int IndiceFila = dgvValores.CurrentCell.RowIndex;
                            DataRow row = DTDetalles.Rows[IndiceFila];

                            DTDetalles.Rows.Remove(row);
                            tbCheqImporte.Text = "0,00";
                            tbImporteCheq.Text = "";
                            contadorFila--;
                            AcomodaTabla();
                            SumaCheques();
                            MessageBox.Show("Se elimino el cheque de la lista");
                        }
                        else
                        {
                            MensajeError("No se pudo eliminar el cheque por: \n\n" + rpta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MensajeError("No se pudo ejecutar la operacion:\n\n" + ex);
                }
            }
            else
            {
                MessageBox.Show("No existen cheques cargados");
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
                    MensajeError("No se pudo ejecutar la operacion:\n\n" + ex);
                }
            }
            else
            {
                MessageBox.Show("No existen cheques cargados");
            }
        }

        private void btnCancelaRecibo_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea Cancelar el Pago de la FACTURA?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                ConsultaPorTransferencia();
                ConsultaPorCheque();
                this.Close();
            }
        }

        private void tbCheqNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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

        private void tbCheqImporte_KeyPress(object sender, KeyPressEventArgs e)
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

        private void chekCambioJusto_CheckedChanged(object sender, EventArgs e)
        {
            if (chekCambioJusto.Checked == true)
            {
                tbDineroEntregado.Text = "0,00";
                tbVuelto.Text = "0,00";
                tbDineroEntregado.Enabled = false;
            }
            else
            {
                tbDineroEntregado.Text = "0,00";
                tbDineroEntregado.Enabled = true;
            }
        }

        private void tbDineroEntregado_TextChanged(object sender, EventArgs e)
        {
            HaceCalculo();
        }

        private void btnGuardarTransf_Click(object sender, EventArgs e)
        {            
            detalleTransf = "";
            if (dgvTransferencias.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow ElRow in dgvTransferencias.Rows)
                {
                    string numtra = ElRow.Cells["NUM_TRANSF"].Value.ToString();
                    string DetNumTransf = "";
                    if (numtra!= "")
                    {
                        DetNumTransf = "Nº "+numtra + " ";
                    }
                    string DetNom = ElRow.Cells["TITULAR"].Value.ToString();
                    string DetImporte = ElRow.Cells["IMPORTE"].Value.ToString();

                    if (DetNom != "" && DetImporte != "")
                    {
                        detalleTransf += "Transferencia " + DetNumTransf + "de " + DetNom + " por $" + DetImporte + "\r\n";
                    }
                }
                tbBanco.Text = tbTransfTotal.Text;
                tabRecibos.SelectedTab = tabNuevoRecibo;
            }
            else
            {
                DialogResult opcion;
                opcion = MessageBox.Show("No se cargo ninguna Transferencia, Desea ir al Recibo?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    tbBanco.Text = "0,00";
                    tabRecibos.SelectedTab = tabNuevoRecibo;
                }
            }
        }

        private void btnIrTransf_Click(object sender, EventArgs e)
        {
            tabRecibos.SelectedTab = tabTransferencias;
            tbNumRecibo.Focus();
        }

        private void InsertarCheque()
        {
            try
            {
                bool existe = false;

                if (contadorFila == 0)
                {
                    string numcheq = Convert.ToString(tbCheqNumero.Text);
                    DateTime fecE = Convert.ToDateTime(dtpCheqEmision.Text);
                    DateTime fecC = Convert.ToDateTime(dtpCheqCredito.Text);
                    string Bco = Convert.ToString(tbCheqBanco.Text);
                    string Titu = Convert.ToString(tbCheqTitular.Text);
                    string Bene = Convert.ToString(tbCheqBenef.Text);
                    decimal Import = Convert.ToDecimal(tbCheqImporte.Text);
                    string estad = "PENDIENTE";

                    string rpta1 = CN_Cheque.Insertar(tbNumRecibo.Text, "RECIBO DE PAGO", numcheq, fecE, fecC, Bco, Titu, Bene, Import, estad);

                    if (rpta1.Equals("OK"))
                    {
                        int id = CN_Cheque.ConsultaUltimoCheque();

                        DataRow row = DTDetalles.NewRow();

                        row["ID_CHEQUE"] = id;
                        row["NUM_CHEQUE"] = numcheq;
                        row["FECHA_EMISION"] = fecE;
                        row["FECHA_CREDITO"] = fecC;
                        row["BANCO"] = Bco;
                        row["TITULAR"] = Titu;
                        row["BENEF"] = Bene;
                        row["IMPORTE"] = Import;

                        DTDetalles.Rows.Add(row);

                        tbCheqImporte.Text = "0,00";
                        tbImporteCheq.Text = "";
                        tbCheqNumero.Text = (Convert.ToInt64(tbCheqNumero.Text) + 1).ToString();
                        contadorFila++;
                    }
                    else
                    {
                        MensajeError(rpta1);
                    }
                }
                else
                {
                    foreach (DataGridViewRow Fila in dgvValores.Rows)
                    {
                        if (Fila.Cells[1].Value.ToString() == tbCheqNumero.Text && Fila.Cells[4].Value.ToString() == tbCheqBanco.Text)
                        {
                            existe = true;
                        }
                    }
                    if (existe == true)
                    {
                        MensajeError("El cheque a ingresar ya existe");
                    }
                    else
                    {
                        string numcheq = Convert.ToString(tbCheqNumero.Text);
                        DateTime fecE = Convert.ToDateTime(dtpCheqEmision.Text);
                        DateTime fecC = Convert.ToDateTime(dtpCheqCredito.Text);
                        string Bco = Convert.ToString(tbCheqBanco.Text);
                        string Titu = Convert.ToString(tbCheqTitular.Text);
                        string Bene = Convert.ToString(tbCheqBenef.Text);
                        decimal Import = Convert.ToDecimal(tbCheqImporte.Text);
                        string estad = "PENDIENTE";

                        string rpta1 = CN_Cheque.Insertar(tbNumRecibo.Text, "RECIBO DE PAGO", numcheq, fecE, fecC, Bco, Titu, Bene, Import, estad);

                        if (rpta1.Equals("OK"))
                        {
                            int id = CN_Cheque.ConsultaUltimoCheque();

                            DataRow row = DTDetalles.NewRow();

                            row["ID_CHEQUE"] = id;
                            row["NUM_CHEQUE"] = numcheq;
                            row["FECHA_EMISION"] = fecE;
                            row["FECHA_CREDITO"] = fecC;
                            row["BANCO"] = Bco;
                            row["TITULAR"] = Titu;
                            row["BENEF"] = Bene;
                            row["IMPORTE"] = Import;

                            DTDetalles.Rows.Add(row);

                            tbCheqImporte.Text = "0,00";
                            tbImporteCheq.Text = "";
                            tbCheqNumero.Text = (Convert.ToInt64(tbCheqNumero.Text) + 1).ToString();
                            contadorFila++;
                        }
                        else
                        {
                            MensajeError(rpta1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MensajeError("No se pudo cargar los datos por:\n\n" + ex);
            }
        }
    }
}
