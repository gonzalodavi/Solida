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
    public partial class FormRecibos : Form
    {
        CN_CtaCte objeto = new CN_CtaCte();
        CN_Recibo objeto1 = new CN_Recibo();
        private DataTable DTDetalles;
        public static int contadorFila = 0;

        public FormRecibos()
        {
            InitializeComponent();
        }

        private void FormRecibos_Load(object sender, EventArgs e)
        {
            ConsultaPorCheque();
            fechaHoy();
            CargarComboBoxClientes();
            CargarGrillaRecibos();
            CargaSaldoCtaCte();
            BuscaNumeroRecibo();
            CrearTabla();
        }

        private void fechaHoy()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;            
            dtpFechaRecibo.Value = DateTime.Now;
            dtpFecha1.Value = new DateTime(year,month,1);
            dtpFecha2.Value = DateTime.Now;
            dtpCheqEmision.Value = DateTime.Now;
            dtpCheqCredito.Value = DateTime.Now;            
        }

        private void BuscaNumeroRecibo()
        {
            int numRecibo = objeto1.MostrarUltimoRecibo();
            tbNumRecibo.Text = (numRecibo + 1).ToString();
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

        private void CargarComboBoxClientes()
        {
            cbCliente.DataSource = objeto.CargaClientes();
            cbCliente.DisplayMember = "NOMBRE";
            cbCliente.ValueMember = "DNI";
            cbCliente.Text = "Consumidor Final";            
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

        

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ConsultaPorCheque();
            this.Close();
        }

        /*private void EliminarChequesPendientes()
        {
            try
            {
                CN_Cheque ob = new CN_Cheque();
                string rpta = ob.Eliminar_Cheques();
                if (rpta.Equals("OK"))
                {
                    MensajeOk("Se Eliminaron Cheques Pendientes");
                }
                else
                {
                    MensajeError(rpta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }*/

        private void btnAceptaRecibo_Click(object sender, EventArgs e)
        {
            if (lblTotalRecibo.Text != "")
            {
                decimal totrec = Convert.ToDecimal(lblTotalRecibo.Text);
                if (totrec <= 0 || tbNumRecibo.Text == "")
                {
                    MensajeError("Ingrese Importe y numero de Recibo");
                }
                else
                {
                    try
                    {
                        DialogResult Opcion;

                        Opcion = MessageBox.Show("Desea Generar Nuevo Comprobante?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (Opcion == DialogResult.OK)
                        {

                            Decimal efectivo = 0, valores = 0, banco = 0;

                            if (tbValores.Text != "," && tbValores.Text != "")
                            {
                                valores = Convert.ToDecimal(tbValores.Text.ToString());
                            }                            

                            if (tbEfectivo.Text != "," && tbEfectivo.Text != "")
                            {
                                efectivo = Convert.ToDecimal(tbEfectivo.Text.ToString());
                            }

                            if (tbBanco.Text != "," && tbBanco.Text != "")
                            {
                                banco = Convert.ToDecimal(tbBanco.Text.ToString());
                            }

                            Decimal Suma = efectivo + valores + banco;

                            lblTotalRecibo.Text = Suma.ToString("0.00");

                            string rpta = "";
                            string rpta1 = "";

                            string Estado = "ACTIVO";
                            rpta = CN_Recibo.Insertar(tbNumRecibo.Text, dtpFechaRecibo.Value, cbCliente.SelectedValue.ToString(), Convert.ToInt32(UserLoginCache.UserId), efectivo, valores, banco, Suma, tbDetalleRecibo.Text, Estado);
                            decimal debe = 0, haber = Suma;

                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Generó con éxito el Comprobante");
                                if (valores > 0)
                                {
                                    
                                    rpta1 = CN_Cheque.ModificarEstadoCheque("PENDIENTE","ACTIVO");

                                    if (rpta1.Equals("OK"))
                                    {
                                        //MensajeOk("Cheques Activos");
                                    }
                                    else
                                    {
                                        MensajeError(rpta1);
                                    }
                                }
                                rpta = CN_CtaCte.Insertar(cbCliente.SelectedValue.ToString(), dtpFechaRecibo.Value, tbNumRecibo.Text, "RECIBO DE PAGO", debe, haber, valores, efectivo, banco, (debe - haber), 0, 0, "N", Estado);
                                if (rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Se registro en cuenta corriente");
                                }
                                else
                                {
                                    this.MensajeError(rpta);
                                }
                                ResetRecibo();
                                CargarGrillaRecibos();
                                tabRecibos.SelectedTab = tabConsultaRecibos;
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
            else
            {
                MensajeError("Por Favor Ingrese un Importe");
            }                   
        }

        private void ResetRecibo()
        {
            tbBanco.Text = "0,00";
            tbValores.Text = "0,00";
            tbEfectivo.Text = "0,00";
            lblTotalRecibo.Text = "0,00";
            tbDetalleRecibo.Text = "";
            tbNumRecibo.Text = "";
            tbCheqBanco.Text = "";
            tbCheqBenef.Text = "";
            tbCheqImporte.Text = "0,00";
            tbCheqNumero.Text = "";
            tbCheqTitular.Text = "";
            tbCheqTotal.Text = "";
            dgvValores.Columns.Clear();
            cbCliente.Text = "Consumidor Final";
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
            lblTotalRecibo.Text = Suma.ToString("0.00");
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
            lblTotalRecibo.Text = Suma.ToString("0.00");
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
            lblTotalRecibo.Text = Suma.ToString("0.00");
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

        private void btnActualizaLista_Click(object sender, EventArgs e)
        {
            CargarGrillaRecibos();
        }

        private void CargarGrillaRecibos()
        {
            if (chekVerAnulados.Checked == false)
            {
                this.dgvRecibos.DataSource = CN_Recibo.Mostrar();
                this.dgvRecibos.Columns[0].Visible = false;
                this.dgvRecibos.Columns[3].Visible = false;
                this.dgvRecibos.Columns[7].Visible = false;

                this.dgvRecibos.Columns[1].Width = 80;
                this.dgvRecibos.Columns[2].Width = 50;
                this.dgvRecibos.Columns[4].Width = 100;
                this.dgvRecibos.Columns[5].Width = 100;
                this.dgvRecibos.Columns[6].Width = 80;

            }
            else
            {
                this.dgvRecibos.DataSource = CN_Recibo.MostrarAnulados();
                this.dgvRecibos.Columns[0].Visible = false;
                this.dgvRecibos.Columns[3].Visible = false;
                this.dgvRecibos.Columns[7].Visible = false;

                this.dgvRecibos.Columns[1].Width = 80;
                this.dgvRecibos.Columns[2].Width = 50;
                this.dgvRecibos.Columns[4].Width = 100;
                this.dgvRecibos.Columns[5].Width = 100;
                this.dgvRecibos.Columns[6].Width = 80;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRecibos.SelectedRows.Count > 0)
            {
                if (dgvRecibos.CurrentRow.Cells[7].Value.ToString() != "ANULADO")
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("Desea ANULAR el comprobante seleccionado?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        CN_Recibo objetoCN = new CN_Recibo();
                        int idRecibo = Convert.ToInt32(dgvRecibos.CurrentRow.Cells[0].Value.ToString());
                        objetoCN.AnularRecibo(idRecibo);

                        MessageBox.Show("SE ANULÓ CORRECTAMENTE EL RECIBO SELECCIONADO");
                        string rpta = CN_CtaCte.AnularRegistroCtaCte(dgvRecibos.CurrentRow.Cells[2].Value.ToString(), "RECIBO DE PAGO");
                        if (rpta.Equals("OK"))
                        {
                            MessageBox.Show("Se QUITO EL REGISTO DE LA CTA CTE");
                        }
                        else
                        {
                            this.MensajeError(rpta);
                        }
                        CargarGrillaRecibos();
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

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            tabRecibos.SelectedTab = tabNuevoRecibo;
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaGrillaCtaCte(cbCliente.SelectedValue.ToString());
            CargaSaldoCtaCte();
        }

        private void CargaGrillaCtaCte(string dni)
        {
            this.dgvDetCtaCte.DataSource = CN_CtaCte.MostrarDetalleCtaCteCompleto(dni);
        }

        private void CargaSaldoCtaCte()
        {
            CN_CtaCte obsaldo = new CN_CtaCte();

            decimal suma = 0;
            foreach (DataGridViewRow row in dgvDetCtaCte.Rows)
            {
                if (row.Cells["IMPORTE"].Value != null)
                    suma += (Decimal)row.Cells["IMPORTE"].Value;
            }
            decimal saldo = obsaldo.MostrarSaldo(cbCliente.SelectedValue.ToString());

            this.lblSaldo.Text = saldo.ToString();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvRecibos.SelectedRows.Count > 0)
            {
                FormReporteRecibo form = new FormReporteRecibo();
                form.IdRecibo = Convert.ToInt32(this.dgvRecibos.CurrentRow.Cells["ID_RECIBO"].Value);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por Favor seleccione un comprobante");
            }
        }

        private void tbNumRecibo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarRegistros();
        }

        private void BuscarRegistros()
        {
            if (chekVerAnulados.Checked == false)
            {
                dgvRecibos.DataSource = CN_Recibo.BuscarRegistros(dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
                this.dgvRecibos.Columns[0].Visible = false;
            }
            else
            {
                dgvRecibos.DataSource = CN_Recibo.BuscarRegistrosAnulados(dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
                this.dgvRecibos.Columns[0].Visible = false;
            }
        }

        private void chekVerAnulados_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrillaRecibos();
        }

        private void CrearTabla()
        {
            DTDetalles = new DataTable();
            DTDetalles.Columns.Add("ID_CHEQUE", Type.GetType("System.Int32"));
            DTDetalles.Columns.Add("NUM_CHEQUE", Type.GetType("System.String"));
            DTDetalles.Columns.Add("FECHA_EMISION", Type.GetType("System.DateTime"));
            DTDetalles.Columns.Add("FECHA_CREDITO", Type.GetType("System.DateTime"));
            DTDetalles.Columns.Add("BANCO", Type.GetType("System.String"));
            DTDetalles.Columns.Add("TITULAR", Type.GetType("System.String"));
            DTDetalles.Columns.Add("BENEF", Type.GetType("System.String"));
            DTDetalles.Columns.Add("IMPORTE", Type.GetType("System.Decimal"));

            
            this.dgvValores.DataSource = DTDetalles;

            dgvValores.Columns["ID_CHEQUE"].Visible = false;

            /*this.dgvDetComp.Columns["PRODUCTO"].Visible = false;
            this.dgvDetComp.Columns["PRECIO"].Width = 50;
            this.dgvDetComp.Columns["IVA"].Width = 50;
            this.dgvDetComp.Columns["SUBTOTAL"].Width = 80;*/
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

                if(tbImporteCheq.Text == "0,00")
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

        private void AcomodaTabla()
        {
            this.dgvValores.Columns["NUM_CHEQUE"].Width = 50;
            this.dgvValores.Columns["FECHA_EMISION"].Width = 50;
            this.dgvValores.Columns["FECHA_CREDITO"].Width = 50;
            this.dgvValores.Columns["FECHA_EMISION"].Width = 50;
            this.dgvValores.Columns["BANCO"].Width = 90;
            this.dgvValores.Columns["TITULAR"].Width = 100;
            this.dgvValores.Columns["BENEF"].Width = 100;
            this.dgvValores.Columns["IMPORTE"].Width = 80;
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
                        if (Fila.Cells[0].Value.ToString() == tbCheqNumero.Text && Fila.Cells[3].Value.ToString() == tbCheqBanco.Text)
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

        private void tbCheqImporte_Leave(object sender, EventArgs e)
        {
            Decimal importe = 0;
            if (tbCheqImporte.Text != "," && tbCheqImporte.Text != "")
            {
                importe = Convert.ToDecimal(tbCheqImporte.Text.ToString());
            }

            tbImporteCheq.Text = importe.ToString("0.00");
        }

        private void btnQuitar_Click(object sender, EventArgs e)
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

        private void btnAgregaValores_Click(object sender, EventArgs e)
        {           
            tabRecibos.SelectedTab = tabValores;
            tbCheqNumero.Focus();
        }

        private void btnGuardarValores_Click(object sender, EventArgs e)
        {
            if (dgvValores.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow ElRow in dgvValores.Rows)
                {
                    string DetNumCheq = ElRow.Cells["NUM_CHEQUE"].Value.ToString();
                    string DetNomBan = ElRow.Cells["BANCO"].Value.ToString();
                    string DetFecC = Convert.ToDateTime(ElRow.Cells["FECHA_CREDITO"].Value).ToString("yyyy-MM-dd");
                    string DetImporte = ElRow.Cells["IMPORTE"].Value.ToString();

                    if (DetNomBan != "" && DetImporte != "" && DetNumCheq != "")
                    {
                        tbDetalleRecibo.Text += "Valor Nº " + DetNumCheq + " de Banco " + DetNomBan + " al " + DetFecC + " con importe $"+DetImporte+ " // ";
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


        private void lblTotalRecibo_TextChanged_1(object sender, EventArgs e)
        {
            if(lblTotalRecibo.Text != "")
            {
                Decimal importePend = Convert.ToDecimal(lblTotalRecibo.Text);
                if (importePend > 0)
                {
                    Decimal saldo = Convert.ToDecimal(lblSaldo.Text) - Convert.ToDecimal(lblTotalRecibo.Text);
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
            lblTotalRecibo.Text = Suma.ToString("0.00");
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
            lblTotalRecibo.Text = Suma.ToString("0.00");
        }

        private void tbEfectivo_TextChanged(object sender, EventArgs e)
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
            lblTotalRecibo.Text = Suma.ToString("0.00");
        }

        private void btnAgregaTransf_Click(object sender, EventArgs e)
        {
            tabRecibos.SelectedTab = tabTransferencias;
        }
    }
}
