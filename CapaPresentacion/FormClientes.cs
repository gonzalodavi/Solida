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


namespace CapaPresentacion
{
    public partial class FormClientes : FormBase
    {
        CN_Domicilio objeto = new CN_Domicilio();

        private bool Editar = false;
        private bool EditarDom = false;
        

        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            CargarGrillaDomicilios();
            CargarComboBoxProvincia();
            limpiarCampos();
            cbDNICUIT.Text = "DNI";
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
            this.dgvClientes.DataSource = CN_Cliente.Mostrar();
            this.dgvClientes.Columns[5].Visible = false;
            this.dgvClientes.Columns[6].Visible = false;
            this.dgvClientes.Columns[7].Visible = false;

            this.dgvClientes.Columns[0].Width = 50;
            this.dgvClientes.Columns[1].Width = 80;
            this.dgvClientes.Columns[2].Width = 80;
            this.dgvClientes.Columns[3].Width = 50;
            this.dgvClientes.Columns[4].Width = 200;
        }

        private void CargarGrillaDomicilios()
        {            
            this.dgvDomicilios.DataSource = CN_Domicilio.Mostrar();
            this.dgvDomicilios.Columns[0].Visible = false;
            this.dgvDomicilios.Columns[3].Visible = false;
            this.dgvDomicilios.Columns[4].Visible = false;
            this.dgvDomicilios.Columns[6].Visible = false;
           
            //dgvDomicilios.Columns[1].Width = 200;
            //this.dgvDomicilios.Columns[2].Width = 30;
            //this.dgvDomicilios.Columns[5].Width = 90;
            //this.dgvDomicilios.Columns[7].Width = 100;
        }

        private void CargarDomicilio()
        {
            this.dgvDomCompleto.DataSource = CN_Domicilio.MostrarDomicilioEnGrilla(Convert.ToInt32(tbIdDom.Text));
        }

        private void dgvDomicilios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIdDom.Text = dgvDomicilios.CurrentRow.Cells["ID"].Value.ToString();
            tbDireccion.Text = dgvDomicilios.CurrentRow.Cells["CALLE"].Value.ToString() + " " + dgvDomicilios.CurrentRow.Cells["NRO"].Value.ToString(); ;
            tabClientes.SelectedTab = tabNuevoCliente;
        }

        //CARGAR LOS COMBOBOX DE BARRIO, LOCALIDAD Y PROVINCIA

        private void CargarComboBoxProvincia()
        {
            cbProvincia.DisplayMember = "DES_PROVINCIA";
            cbProvincia.ValueMember = "ID_PROVINCIA";
            cbProvincia.DataSource = objeto.CargaProvincia();
            cbProvincia.SelectedIndex = -1;
            cbLocalidad.SelectedIndex = -1;
            cbLocalidad.DataSource = null;
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvincia.SelectedIndex != -1)
            {
                cbBarrio.DataSource = null;
                panelDomicilio.Enabled = false;
                CargarComboBoxLocalidad();
                lblErrorProvincia.Visible = false;
            }
            else
            {
                lblErrorProvincia.Visible = true;
            }            
        }

        private void CargarComboBoxLocalidad()
        {
            if (cbProvincia.SelectedIndex != -1)
            {
                int idp = Convert.ToInt32(cbProvincia.SelectedValue);
                cbLocalidad.DisplayMember = "DES_LOCALIDAD";
                cbLocalidad.ValueMember = "ID_LOCALIDAD";
                cbLocalidad.DataSource = CN_Domicilio.CargaLocalidadEnComboBox(idp);
                cbLocalidad.SelectedIndex = -1;
                cbBarrio.DataSource = null;
            }
        }

        private void cbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLocalidad.SelectedIndex != -1)
            {
                cbBarrio.DataSource = null;
                panelDomicilio.Enabled = false;
                CargarComboBoxBarrio();
                lblErrorLocalidad.Visible = false;
            }
            else
            {
                lblErrorLocalidad.Visible = true;
            }
        }

        private void CargarComboBoxBarrio()
        {
            if (cbLocalidad.SelectedIndex != -1)
            {
                int idl = Convert.ToInt32(cbLocalidad.SelectedValue);
                cbBarrio.DisplayMember = "DES_BARRIO";
                cbBarrio.ValueMember = "ID_BARRIO";
                cbBarrio.DataSource = CN_Domicilio.CargaBarrio(idl);
                cbBarrio.SelectedIndex = -1;
            }
        }      

        private void cbBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBarrio.SelectedIndex == -1)
            {
                panelDomicilio.Enabled = false;
                lblErrorBarrio.Visible = true;
            }
            else
            {
                panelDomicilio.Enabled = true;
                lblErrorBarrio.Visible = false;
            }            
        }


        private void LimpiarTabDomicilio()
        {
            cbProvincia.SelectedIndex = -1;
            lblSeleDom.Text = "Nuevo Domicilio";
            tbCalle.Text = "";
            tbNro.Text = "";
            tbPiso.Text = "";
            tbDpto.Text = "";
            cbProvincia.SelectedIndex = -1;
            tbProvinciaSeleccionada.Visible = false;            
            tbProvinciaSeleccionada.Text = "";
            cbLocalidad.DataSource = null;
            cbBarrio.DataSource = null;
            lblErrorProvincia.Visible = false;
            lblErrorLocalidad.Visible = false;
            lblErrorBarrio.Visible = false;
            lblErrorCalle.Visible = false;
        }

        private void limpiarCampos()
        {
            tbDNI.Text = "";
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbTel.Text = "";
            tbEmpresa.Text = "";
            tbMail.Text = "";
            cbCondIVA.Text = "";
            tbDireccion.Text = "";
            tbIdDom.Text = "";
            lblSubTitutlo.Text = "";
            tbDNI.Enabled = true;
            cbDNICUIT.Enabled = true;
            cbDNICUIT.Text = "DNI";
            cbCondIVA.SelectedIndex = -1;
            lblErrorApe.Visible = false;
            lblErrorDire.Visible = false;
            lblErrorDNI.Visible = false;
            lblErrorIVA.Visible = false;
            lblErrorNom.Visible = false;
            lblErrorProvincia.Visible = false;
            lblErrorLocalidad.Visible = false;
            lblErrorBarrio.Visible = false;
            lblErrorCalle.Visible = false;
            Editar = false;
        }


          

        private void btAceptar_Click(object sender, EventArgs e)
        {
            var cadena1 = tbDNI.Text;

            if (cadena1.Length < 8 && cbDNICUIT.Text == "CUIT")
            {
                MessageBox.Show("El CUIT debe contener 11 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblErrorDNI.Visible = true;
            }
            else
            {
                lblErrorDNI.Visible = false;

                if (cadena1.Length < 8 && cbDNICUIT.Text == "DNI")
                {
                    MessageBox.Show("El DNI debe contener 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblErrorDNI.Visible = true;
                }
                else
                {
                    lblErrorDNI.Visible = false;
                    if (tbApellido.Text == "")
                    {
                        MensajeError("Por Favor, Ingrese un Apellido para agregar Nuevo Cliente.");
                        lblErrorApe.Visible = true;
                    }
                    else
                    {
                        lblErrorApe.Visible = false;
                        if (tbNombre.Text == "")
                        {
                            MensajeError("Por Favor, Ingrese un Nombre para agregar Nuevo Cliente.");
                            lblErrorNom.Visible = true;
                        }
                        else
                        {
                            lblErrorNom.Visible = false;
                            agregarCliente();
                        }
                    }
                }
            }            
        }

        private void agregarCliente()
        {
            if (cbCondIVA.SelectedIndex == -1)
            {
                MensajeError("Seleccione una condicion de IVA del cliente a cargar");
                lblErrorIVA.Visible = true;
            }
            else
            {
                lblErrorIVA.Visible = false;

                if (tbIdDom.Text == "")
                {
                    MensajeError("Por Favor, Seleccione o Agregue una Nueva Dirección");
                    lblErrorDire.Visible = true;
                }
                else
                {
                    lblErrorDire.Visible = false;
                    if (Editar == false)
                    {
                        try
                        {
                            string dnicuit = this.tbDNI.Text.Trim();

                            if (cbDNICUIT.Text == "CUIT")
                            {
                                dnicuit = cbPreF.Text + this.tbDNI.Text.Trim() + cbSuF.Text;
                            }
                                                        
                            string rptC = CN_Cliente.ConsultaClienteExisteEnCbtes(dnicuit, "BuscarSiExisteCliente");
                            if (rptC == "OK")
                            {
                                this.MensajeError("Ya existe un Cliente con ese DNI/CUIT");
                            }
                            else
                            {
                                if (rptC == "NO")
                                {
                                    string Rpta = "";
                                    int nroiddireccion = 0;
                                    DialogResult Opcion;
                                    Opcion = MessageBox.Show("Desea registrar un Nuevo Cliente?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                    if (Opcion == DialogResult.OK)
                                    {
                                        if (tbIdDom.Text == "")
                                        {
                                            nroiddireccion = 0;
                                        }
                                        else
                                        {
                                            nroiddireccion = Convert.ToInt32(this.tbIdDom.Text.Trim());
                                        }

                                        Rpta = CN_Cliente.Insertar(dnicuit, this.tbNombre.Text.Trim(), this.tbApellido.Text.Trim(), this.tbTel.Text.Trim(), this.tbMail.Text.Trim(), this.cbCondIVA.Text.Trim(), this.tbEmpresa.Text.Trim(), nroiddireccion);
                                        if (Rpta.Equals("OK"))
                                        {
                                            this.MensajeOk("Se insertó correctamente el nuevo Cliente");

                                            dgvClientes.Enabled = true;
                                            CargarGrilla();
                                            LimpiarTabDomicilio();
                                            limpiarCampos();
                                            tabClientes.SelectedTab = tabConsulta;
                                        }
                                        else
                                        {
                                            this.MensajeError(Rpta);
                                        }
                                    }
                                }
                                else
                                {
                                    MensajeError(rptC);
                                }                                
                            }                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + ex.StackTrace);
                        }

                    }
                    if (Editar == true)
                    {
                        try
                        {
                            string Rpta = "";
                            DialogResult Opcion;
                            int nroiddireccion = 0;
                            Opcion = MessageBox.Show("¿Desea Modificar los datos del Cliente?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (Opcion == DialogResult.OK)
                            {
                                if (tbIdDom.Text == "")
                                {
                                    nroiddireccion = 0;
                                }
                                else
                                {
                                    nroiddireccion = Convert.ToInt32(this.tbIdDom.Text.Trim());
                                }
                                string dnicuit = this.tbDNI.Text.Trim();

                                if (cbDNICUIT.Text == "CUIT")
                                {
                                    dnicuit = cbPreF.Text + this.tbDNI.Text.Trim() + cbSuF.Text;
                                }

                                Rpta = CN_Cliente.Modificar(dnicuit, this.tbNombre.Text.Trim(), this.tbApellido.Text.Trim(), this.tbTel.Text.Trim(), this.tbMail.Text.Trim(), this.cbCondIVA.Text.Trim(), this.tbEmpresa.Text.Trim(), nroiddireccion);
                                if (Rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Se modificaron correctamente los datos del Cliente");
                                    dgvClientes.Enabled = true;
                                    CargarGrilla();
                                    LimpiarTabDomicilio();
                                    limpiarCampos();
                                    tabClientes.SelectedTab = tabConsulta;
                                    lblSubTitutlo.Text = "Nuevo Cliente";
                                    dgvClientes.Enabled = true;
                                    Editar = false;
                                    EditarDom = false;
                                }
                                else
                                {
                                    this.MensajeError(Rpta);
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
                    tabClientes.SelectedTab = tabConsulta;
                    dgvClientes.Enabled = true;
                    lblSubTitutlo.Text = "Nuevo Cliente";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarCliente();
        }

        private void buscarCliente()
        {
            if (tbBusca.Text == "")
            {
                CargarGrilla();
                MessageBox.Show("Para Buscar un cliente debe ingresar su DNI o Nombre");
            }
            else
            {
                CN_Cliente objetob = new CN_Cliente();
                dgvClientes.DataSource = objetob.BuscarClientesxNom(tbBusca.Text);
                if (dgvClientes.SelectedRows.Count < 1)
                {
                    CN_Cliente objA = new CN_Cliente();
                    dgvClientes.DataSource = objetob.BuscarClientexDNI(tbBusca.Text);
                    if (dgvClientes.SelectedRows.Count < 1)
                    {
                        MessageBox.Show("No existen registros");
                    }
                }
            }
        }

       
        private void btnSeleccionaDireccion_Click(object sender, EventArgs e)
        {
           
        }


        private void btnAceptaDom_Click(object sender, EventArgs e)
        {
            if(cbProvincia.SelectedIndex != -1)
            {
                if (cbLocalidad.SelectedIndex != -1)
                {
                    if (cbBarrio.SelectedIndex != -1)
                    {
                        if (tbCalle.Text != "")
                        {
                            try
                            {
                                string Rpta = "";

                                DialogResult Opcion;
                                if (EditarDom == false)
                                {
                                    Opcion = MessageBox.Show("Desea Agregar Nuevo Domicilio?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                                    if (Opcion == DialogResult.OK)
                                    {
                                        int nroidbar = Convert.ToInt32(cbBarrio.SelectedValue);
                                        int nrocalle = Convert.ToInt32(this.tbNro.Text.Trim());
                                        if (tbNro.Text == "")
                                        {
                                            nrocalle = 0;
                                        }
                                        Rpta = CN_Domicilio.Insertar(this.tbCalle.Text.Trim(), nrocalle, this.tbPiso.Text.Trim(), this.tbDpto.Text.Trim(), nroidbar);
                                        if (Rpta.Equals("OK"))
                                        {
                                            tbDireccion.Text = this.tbCalle.Text + " " + this.tbNro.Text;
                                            int idDomi = CN_Domicilio.Consultar();
                                            tbIdDom.Text = idDomi.ToString();
                                            CargarDomicilio();
                                            CargarGrillaDomicilios();
                                            this.MensajeOk("Se Insertó de forma correcta el registro");
                                            LimpiarTabDomicilio();
                                            tabClientes.SelectedTab = tabNuevoCliente;
                                        }
                                        else
                                        {
                                            this.MensajeError(Rpta);
                                        }
                                    }
                                }
                                else
                                {
                                    Opcion = MessageBox.Show("Desea Modificar El Domicilio?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                    if (Opcion == DialogResult.OK)
                                    {
                                        int nroidbar = Convert.ToInt32(cbBarrio.SelectedValue);
                                        int nrocalle = Convert.ToInt32(this.tbNro.Text.Trim());
                                        if (tbNro.Text == "")
                                        {
                                            nrocalle = 0;
                                        }
                                        Rpta = CN_Domicilio.Modificar(Convert.ToInt32(this.tbIdDom.Text.Trim()), this.tbCalle.Text.Trim(), nrocalle, this.tbPiso.Text.Trim(), this.tbDpto.Text.Trim(), nroidbar);
                                        if (Rpta.Equals("OK"))
                                        {
                                            tbDireccion.Text = this.tbCalle.Text + " " + this.tbNro.Text;
                                            CargarDomicilio();
                                            CargarGrillaDomicilios();
                                            this.MensajeOk("Se Modificaron los datos del Domicilio");
                                            LimpiarTabDomicilio();
                                            tabClientes.SelectedTab = tabNuevoCliente;
                                            EditarDom = false;
                                        }
                                        else
                                        {
                                            this.MensajeError(Rpta);
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
                            MensajeError("Complete un Nombre de Calle");
                            lblErrorCalle.Visible = true;
                        }
                    }
                    else
                    {
                        MensajeError("Seleccione un Barrio");
                        lblErrorBarrio.Visible = true;
                    }
                }
                else
                {
                    MensajeError("Seleccione una Localidad");
                    lblErrorLocalidad.Visible = true;
                }
            }
            else
            {
                MensajeError("Seleccione una Provincia");
                lblErrorProvincia.Visible = true;
            }
        }

        private void btnCancelaDom_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Desea Cancelar la Operación?", "¡Atencion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            try
            {
                if (Opcion == DialogResult.OK)
                {
                    LimpiarTabDomicilio();
                    dgvDomicilios.Enabled = true;
                    tabClientes.SelectedTab = tabListaDom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }           
        }

        private void btnBuscaDom_Click(object sender, EventArgs e)
        {
            BuscarDomicilio();
        }
                

        private void BuscarDomicilio()
        {
            if (tbBuscarDomicilio.Text == "")
            {
                CargarGrilla();
                MessageBox.Show("Para Buscar un domicilio debe ingresar su calle");
            }
            else
            {
                CN_Domicilio objetob = new CN_Domicilio();
                dgvDomicilios.DataSource = objetob.BuscaUnDomicilio(tbBuscarDomicilio.Text);
                if (dgvDomicilios.SelectedRows.Count < 1)
                {
                    MessageBox.Show("No existen registros");
                }
            }
        }

        private void tbDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cbDNICUIT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDNICUIT.Text == "DNI")
            {
                cbPreF.Enabled = false;
                cbSuF.Enabled = false;
                tbDNI.Text = "";
                cbSuF.SelectedIndex = -1;
                cbPreF.SelectedIndex = -1;
            }
            if (cbDNICUIT.Text == "CUIT")
            {
                cbPreF.Enabled = true;
                cbSuF.Enabled = true;
                tbDNI.Text = "";
                cbSuF.SelectedIndex = 0;
                cbPreF.SelectedIndex = 0;
            }
        }

        

        private void tbDNI_Leave(object sender, EventArgs e)
        {
            var cadena = tbDNI.Text;

            if (cadena.Length < 8)
            {
                lblErrorDNI.Visible = true;
            }
            else
            {
                lblErrorDNI.Visible = false;
            }
        }        

        private void tbApellido_Leave(object sender, EventArgs e)
        {
            if (tbApellido.Text == "")
            {
                lblErrorApe.Visible = true;
            }
            else
            {
                lblErrorApe.Visible = false;
            }
        }


        private void tbNombre_Leave(object sender, EventArgs e)
        {
            if (tbNombre.Text == "")
            {
                lblErrorNom.Visible = true;
            }
            else
            {
                lblErrorNom.Visible = false;
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            if (tbNombre.Text == "")
            {
                lblErrorNom.Visible = true;
            }
            else
            {
                lblErrorNom.Visible = false;
            }
        }

        private void cbCondIVA_Leave(object sender, EventArgs e)
        {
            if (cbCondIVA.SelectedIndex == -1)
            {
                lblErrorIVA.Visible = true;
            }
            else
            {
                lblErrorIVA.Visible = false;
            }
        }

        private void tbDireccion_Leave(object sender, EventArgs e)
        {
            if (tbDireccion.Text == "")
            {
                lblErrorDire.Visible = true;
            }
            else
            {
                lblErrorDire.Visible = false;
            }
        }

        private void tbDireccion_TextChanged(object sender, EventArgs e)
        {
            if (tbDireccion.Text == "")
            {
                lblErrorDire.Visible = true;
            }
            else
            {
                lblErrorDire.Visible = false;
            }
        }

        private void btnSeleccionaDireccion_Leave(object sender, EventArgs e)
        {
            if (tbDireccion.Text == "")
            {
                lblErrorDire.Visible = true;
            }
            else
            {
                lblErrorDire.Visible = false;
            }
        }
        private void tbApellido_TextChanged(object sender, EventArgs e)
        {
            if (tbApellido.Text == "")
            {
                lblErrorApe.Visible = true;
            }
            else
            {
                lblErrorApe.Visible = false;
            }
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbNombre.Text == "")
            {
                lblErrorNom.Visible = true;
            }
            else
            {
                lblErrorNom.Visible = false;
            }
        }

        private void cbCondIVA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCondIVA.SelectedIndex == -1)
            {
                lblErrorIVA.Visible = true;
            }
            else
            {
                lblErrorIVA.Visible = false;
            }
        }

        private void btnAgregaLoc_Click(object sender, EventArgs e)
        {
            int Provi = Convert.ToInt32(cbProvincia.SelectedValue);
            Form formBG = new Form();
            using (FormLocalidad mm = new FormLocalidad())
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
            cbProvincia.SelectedIndex = -1;
            cbProvincia.SelectedValue = Provi;
        }

        private void btnAgregaBarr_Click(object sender, EventArgs e)
        {
            int Provi = Convert.ToInt32(cbProvincia.SelectedValue);
            int Loca = Convert.ToInt32(cbLocalidad.SelectedValue);
            Form formBG1 = new Form();
            using (FormBarrio mm = new FormBarrio())
            {
                formBG1.StartPosition = FormStartPosition.Manual;
                formBG1.FormBorderStyle = FormBorderStyle.None;
                formBG1.Opacity = .70d;
                formBG1.BackColor = Color.Black;
                formBG1.WindowState = FormWindowState.Maximized;
                formBG1.TopMost = true;
                formBG1.Location = this.Location;
                formBG1.ShowInTaskbar = false;
                formBG1.Show();

                mm.Owner = formBG1;
                mm.ShowDialog();

                formBG1.Dispose();
            }
            cbProvincia.SelectedIndex = -1;
            cbProvincia.SelectedValue = Provi;
            cbLocalidad.SelectedIndex = -1;
            cbLocalidad.SelectedValue = Loca;
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbDNI_TextChanged(object sender, EventArgs e)
        {
            var cadena = tbDNI.Text;

            if (cadena.Length < 8)
            {
                lblErrorDNI.Visible = true;
            }
            else
            {
                lblErrorDNI.Visible = false;
            }
        }

        private void cbProvincia_Leave(object sender, EventArgs e)
        {
            if (cbProvincia.SelectedIndex == -1)
            {
                lblErrorProvincia.Visible = true;
            }
            else
            {
                lblErrorProvincia.Visible = false;
            }
        }

        private void cbLocalidad_Leave(object sender, EventArgs e)
        {
            if (cbLocalidad.SelectedIndex == -1)
            {
                lblErrorLocalidad.Visible = true;
            }
            else
            {
                lblErrorLocalidad.Visible = false;
            }
        }

        private void cbBarrio_Leave(object sender, EventArgs e)
        {
            if (cbBarrio.SelectedIndex == -1)
            {
                lblErrorBarrio.Visible = true;
            }
            else
            {
                lblErrorBarrio.Visible = false;
            }
        }

        private void tbCalle_TextChanged(object sender, EventArgs e)
        {
            if (tbCalle.Text == "")
            {
                lblErrorCalle.Visible = true;
            }
            else
            {
                lblErrorCalle.Visible = false;
            }
        }

        private void tbCalle_Leave(object sender, EventArgs e)
        {
            if (tbCalle.Text == "")
            {
                lblErrorCalle.Visible = true;
            }
            else
            {
                lblErrorCalle.Visible = false;
            }
        }

        private void tbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            tabClientes.SelectedTab = tabNuevoCliente;
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                string cuit = dgvClientes.CurrentRow.Cells["DNI/CUIT"].Value.ToString();
                tabClientes.SelectedTab = tabNuevoCliente;
                lblSubTitutlo.Text = "Modificar Cliente";
                limpiarCampos();

                tbDNI.Enabled = false;
                if (cuit.Length > 8)
                {
                    cbDNICUIT.Text = "CUIT";
                    string cadena = cuit;
                    string doscaracteres = cadena.Substring(0, 2);
                    cbPreF.Text = doscaracteres;
                    string ultimocaracter = cadena.Substring(cadena.Length - 1, 1);
                    cbSuF.Text = ultimocaracter;
                    string cadena2 = cadena.Remove(0, 2);
                    cuit = cadena2.Remove(8, 1);
                }
                else
                {
                    cbDNICUIT.Text = "DNI";
                }
                cbDNICUIT.Enabled = false;
                cbSuF.Enabled = false;
                cbPreF.Enabled = false;
                tbDNI.Text = cuit;
                tbNombre.Text = dgvClientes.CurrentRow.Cells["NOMBRE"].Value.ToString();
                tbApellido.Text = dgvClientes.CurrentRow.Cells["APELLIDO"].Value.ToString();
                tbTel.Text = dgvClientes.CurrentRow.Cells["TEL"].Value.ToString();
                tbMail.Text = dgvClientes.CurrentRow.Cells["MAIL"].Value.ToString();
                cbCondIVA.Text = dgvClientes.CurrentRow.Cells["COND_IVA"].Value.ToString();
                tbEmpresa.Text = dgvClientes.CurrentRow.Cells["RAZON_SOCIAL"].Value.ToString();
                tbIdDom.Text = dgvClientes.CurrentRow.Cells["IDDOM"].Value.ToString();

                CN_Domicilio Odir = new CN_Domicilio();
                tbDireccion.Text = Odir.BuscarDomicilio(Convert.ToInt32(tbIdDom.Text));

                CargarDomicilio();
                dgvClientes.Enabled = false;
                Editar = true;
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvClientes.SelectedRows.Count > 0)
            {
                try
                {
                    string cuitCliente = dgvClientes.CurrentRow.Cells["DNI/CUIT"].Value.ToString();
                    string rptC = CN_Cliente.ConsultaClienteExisteEnCbtes(cuitCliente, "BuscarClienteEnVta");
                    if (rptC == "OK")
                    {
                        this.MensajeError("No se permite eliminar un Cliente utilizado en un comprobante");
                    }
                    else
                    {
                        if (rptC == "NO")
                        {
                            rptC = CN_Cliente.ConsultaClienteExisteEnCbtes(cuitCliente, "BuscarClienteEnRecibo");
                            if (rptC == "OK")
                            {
                                this.MensajeError("No se permite eliminar un Cliente utilizado en un comprobante");
                            }
                            else
                            {
                                if (rptC == "NO")
                                {
                                    rptC = CN_Cliente.ConsultaClienteExisteEnCbtes(cuitCliente, "BuscarClienteEnNota");
                                    if (rptC == "OK")
                                    {
                                        this.MensajeError("No se permite eliminar un Cliente utilizado en un comprobante");
                                    }
                                    else
                                    {
                                        if (rptC == "NO")
                                        {
                                            string Rpta = "";

                                            DialogResult Opcion;
                                            Opcion = MessageBox.Show("Desea Eliminar el Cliente seleccionado", "¡Atencion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


                                            if (Opcion == DialogResult.OK)
                                            {

                                                Rpta = CN_Cliente.Eliminar(cuitCliente);

                                                if (Rpta.Equals("OK"))
                                                {
                                                    this.MensajeOk("Se Eliminó Correctamente el Cliente con Nº DNI/CUIT: " + cuitCliente);
                                                }
                                                else
                                                {
                                                    this.MensajeError(Rpta);
                                                }
                                                LimpiarTabDomicilio();
                                                limpiarCampos();
                                                CargarGrilla();
                                            }
                                        }
                                        else
                                        {
                                            MensajeError(rptC);
                                        }
                                    }
                                }
                                else
                                {
                                    MensajeError(rptC);
                                }
                            }
                        }
                        else
                        {
                            MensajeError(rptC);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MensajeError(ex.Message + ex.StackTrace);
                }
            }
            else
            {
                MensajeError("Seleccione un Cliente por favor");
            }
        }

        private void btnNuevaDire_Click(object sender, EventArgs e)
        {
            LimpiarTabDomicilio();
            dgvDomicilios.Enabled = false;
            tabClientes.SelectedTab = tabNuevoDom;
        }

        private void btnModificarDom_Click(object sender, EventArgs e)
        {
            if (dgvDomicilios.SelectedRows.Count > 0)
            {
                string loc = dgvDomicilios.CurrentRow.Cells["LOCALIDAD"].Value.ToString();
                string bar = dgvDomicilios.CurrentRow.Cells["BARRIO"].Value.ToString();
                string calle = dgvDomicilios.CurrentRow.Cells["CALLE"].Value.ToString();
                string nro = dgvDomicilios.CurrentRow.Cells["NRO"].Value.ToString();
                string piso = dgvDomicilios.CurrentRow.Cells["PISO"].Value.ToString();
                string dpto = dgvDomicilios.CurrentRow.Cells["DPTO"].Value.ToString();


                tabClientes.SelectedTab = tabNuevoDom;
                EditarDom = true;
                lblSeleDom.Text = "Modificar Domicilio";
                tbIdDom.Text = dgvDomicilios.CurrentRow.Cells["ID"].Value.ToString();

                cbProvincia.Text = dgvDomicilios.CurrentRow.Cells["PROVINCIA"].Value.ToString();
                cbLocalidad.Text = loc;
                cbBarrio.Text = bar;
                panelDomicilio.Enabled = true;
                tbCalle.Text = calle;
                tbNro.Text = nro;
                tbPiso.Text = piso;
                tbDpto.Text = dgvDomicilios.CurrentRow.Cells["DPTO"].Value.ToString();
                /*
                string elid1 = dgvLocalidad.CurrentRow.Cells["ID_LOCALIDAD"].Value.ToString();
                int numero1 = Convert.ToInt32(elid1);
                this.dgvBarrio.DataSource = CN_Domicilio.CargaBarrio(numero1);
                this.dgvBarrio.Columns[0].Visible = false;
                this.dgvBarrio.Columns[2].Visible = false;

                this.dgvBarrio.Columns[1].Width = 110;
                this.dgvBarrio.Columns[3].Width = 100;
                this.dgvBarrio.DataSource = CN_Domicilio.CargaBarrio(0);
                foreach (DataGridViewRow row1 in dgvBarrio.Rows)
                {
                    if (dgvBarrio.CurrentRow.Cells["DES_BARRIO"].Value.ToString()== bar)
                    {
                        row1.Selected = true;
                    }
                }
                panelDomicilio.Enabled = true;
                tbCalle.Text = dgvDomicilios.CurrentRow.Cells["CALLE"].Value.ToString();
                tbNro.Text = dgvDomicilios.CurrentRow.Cells["NRO"].Value.ToString();
                tbPiso.Text = dgvDomicilios.CurrentRow.Cells["PISO"].Value.ToString();
                tbDpto.Text = dgvDomicilios.CurrentRow.Cells["DPTO"].Value.ToString();
                dgvDomicilios.Enabled = false;  */
            }
            else
            {
                MensajeError("Seleccione una Direccion de la lista para modificar");
            }
        }

        private void btnElimiarDom_Click(object sender, EventArgs e)
        {
            if (dgvDomicilios.SelectedRows.Count > 0)
            {
                try
                {
                    string Rpta = "";
                    int iddomisele = Convert.ToInt32(dgvDomicilios.CurrentRow.Cells["ID"].Value.ToString());

                    string rpta = CN_Domicilio.ConsultaDomicilioSiExiste(iddomisele, "BuscarDomicilioEnCliente");
                    if (rpta == "OK")
                    {
                        this.MensajeError("No se permite eliminar un Domicilio utilizado por Cliente/Proveedor");
                    }
                    else
                    {
                        if (rpta == "NO")
                        {
                            rpta = CN_Domicilio.ConsultaDomicilioSiExiste(iddomisele, "BuscarDomicilioEnProveedor");
                            if (rpta == "OK")
                            {
                                this.MensajeError("No se permite eliminar un Domicilio utilizado por Cliente/Proveedor");
                            }
                            else
                            {
                                if (rpta == "NO")
                                {
                                    DialogResult Opcion;
                                    Opcion = MessageBox.Show("Desea Eliminar el Domicilio seleccionado", "¡Atencion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                    if (Opcion == DialogResult.OK)
                                    {
                                        Rpta = CN_Domicilio.Eliminar(iddomisele);

                                        if (Rpta.Equals("OK"))
                                        {
                                            this.MensajeOk("Se Eliminó Correctamente el domicilio seleccionado");
                                        }
                                        else
                                        {
                                            this.MensajeError(Rpta);
                                        }
                                        LimpiarTabDomicilio();
                                        CargarGrillaDomicilios();
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
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else
            {
                MensajeError("Seleccione una Direccion de la lista para eliminar");
            }
        }

        private void btnActualizarDir_Click(object sender, EventArgs e)
        {
            CargarGrillaDomicilios();
            tbBuscarDomicilio.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
            tbBusca.Text = "";
        }

        private void btnSeleccionaDir_Click(object sender, EventArgs e)
        {
            tabClientes.SelectedTab = tabListaDom;
        }
    }
}
