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
using CapaPresentacion;

namespace CapaPresentacion
{
    public partial class FormProveedor : Form
    {
        CN_Domicilio objeto = new CN_Domicilio();

        private bool Editar = false;
        private bool EditarDom = false;


        public FormProveedor()
        {
            InitializeComponent();
        }


        private void FormProveedor_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            CargarGrillaDomicilios();
            CargarComboBoxProvincia();
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

        
        private void CargarGrillaDomicilios()
        {
            this.dgvDomicilios.DataSource = CN_Domicilio.Mostrar();
            this.dgvDomicilios.Columns[0].Visible = false;
            this.dgvDomicilios.Columns[3].Visible = false;
            this.dgvDomicilios.Columns[4].Visible = false;
            this.dgvDomicilios.Columns[6].Visible = false;
        }


        private void CargarDomicilio()
        {
            this.dgvDomCompleto.DataSource = CN_Domicilio.MostrarDomicilioEnGrilla(Convert.ToInt32(tbIdDom.Text));
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
            }
            else
            {
                panelDomicilio.Enabled = true;
            }
        }



        private void limpiarCampos()
        {
            cbPreF.Enabled = true;
            cbSuF.Enabled = true;
            tbCuit.Enabled = true;
            cbPreF.SelectedIndex = -1;
            cbSuF.SelectedIndex = -1;
            tbCuit.Text = "";
            tbEmpresa.Text = "";
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbTel.Text = "";
            tbMail.Text = "";
            tbDireccion.Text = "";
            tbDescripcion.Text = "";
            tbIdDom.Text = "";
            btnSeleccionaDireccion.Text = "SELECCIONAR DIRECCION";
            tbCalle.Text = "";
            tbNro.Text = "";
            tbPiso.Text = "";
            tbDpto.Text = "";
            lblErrorApe.Visible = false;
            lblErrorCUIT.Visible = false;
            lblErrorDire.Visible = false;
            lblErrorEmpresa.Visible = false;
            lblErrorNom.Visible = false;
            Editar = false;

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
        }


        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            tabProveedor.SelectedTab = tabPMant;
        }


        private void btAceptar_Click(object sender, EventArgs e)
        {
            agregaNuevoProveedor();
        }

        private void agregaNuevoProveedor()
        {
            if (tbCuit.Text != "" && tbEmpresa.Text != "" && tbNombre.Text != "" && tbApellido.Text != "" && tbMail.Text != "" && tbTel.Text != "" && tbIdDom.Text != "")
            {
                if (Editar == false)
                {
                    string Rpta = "";

                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Desea registrar Nuevo Proveedor?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.OK)
                    {
                        int nroiddireccion = Convert.ToInt32(this.tbIdDom.Text.Trim());

                        if (tbIdDom.Text == "")
                        {
                            nroiddireccion = 0;
                        }
                        string numcuit = cbPreF.Text + this.tbCuit.Text.Trim() + cbSuF.Text;

                        Rpta = CN_Proveedor.Insertar(numcuit, this.tbEmpresa.Text.Trim(), this.tbNombre.Text.Trim(), this.tbApellido.Text.Trim(), this.tbMail.Text.Trim(), this.tbTel.Text.Trim(), nroiddireccion, this.tbDescripcion.Text.Trim());
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se insertó correctamente el nuevo Proveedor");
                            dgvProveedor.Enabled = true;
                            CargarGrilla();
                            limpiarCampos();
                            tabProveedor.SelectedTab = tabPConsulta;
                        }
                        else
                        {
                            this.MensajeError(Rpta);
                        }
                    }
                }
                if (Editar == true)
                {
                    string Rpta = "";

                    DialogResult Opcion;

                    Opcion = MessageBox.Show("¿Desea Modificar los datos del Proveedor?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.OK)
                    {
                        int nroiddireccion = Convert.ToInt32(this.tbIdDom.Text.Trim());

                        if (tbIdDom.Text == "")
                        {
                            nroiddireccion = 0;
                        }

                        string numcuit = cbPreF.Text + this.tbCuit.Text.Trim() + cbSuF.Text;

                        Rpta = CN_Proveedor.Modificar(numcuit, this.tbEmpresa.Text.Trim(), this.tbNombre.Text.Trim(), this.tbApellido.Text.Trim(), this.tbMail.Text.Trim(), this.tbTel.Text.Trim(), nroiddireccion, this.tbDescripcion.Text.Trim());
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se modificaron correctamente los datos del Proveedor");
                            dgvProveedor.Enabled = true;
                            CargarGrilla();
                            LimpiarTabDomicilio();
                            limpiarCampos();
                            tabProveedor.SelectedTab = tabPConsulta;
                            lblSubTitutlo.Text = "Nuevo Proveedor";
                            dgvProveedor.Enabled = true;
                            Editar = false;
                            EditarDom = false;
                        }
                        else
                        {
                            this.MensajeError(Rpta);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Existe algun campo vacío.\nPara Agregar o Editar un Proveedor debe completar todos sus datos");
            }
        }

        private void btnModificarProv_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count > 0)
            {
                string cuit = dgvProveedor.CurrentRow.Cells["CUIT"].Value.ToString();
                tabProveedor.SelectedTab = tabPMant;
                lblSubTitutlo.Text = "Modificar Proveedor";
                limpiarCampos();

                string cadena = cuit;
                string doscaracteres = cadena.Substring(0, 2);
                cbPreF.Text = doscaracteres;
                string ultimocaracter = cadena.Substring(cadena.Length - 1, 1);
                cbSuF.Text = ultimocaracter;
                string cadena2 = cadena.Remove(0, 2);
                cuit = cadena2.Remove(8, 1);

                tbCuit.Enabled = false;
                cbSuF.Enabled = false;
                cbPreF.Enabled = false;

                tbCuit.Text = cuit;

                tbEmpresa.Text = dgvProveedor.CurrentRow.Cells["EMPRESA"].Value.ToString();
                tbNombre.Text = dgvProveedor.CurrentRow.Cells["NOMBRE"].Value.ToString();
                tbApellido.Text = dgvProveedor.CurrentRow.Cells["APELLIDO"].Value.ToString();
                tbMail.Text = dgvProveedor.CurrentRow.Cells["MAIL"].Value.ToString();
                tbTel.Text = dgvProveedor.CurrentRow.Cells["TEL"].Value.ToString();
                tbIdDom.Text = dgvProveedor.CurrentRow.Cells["IDDOM"].Value.ToString();
                tbDescripcion.Text = dgvProveedor.CurrentRow.Cells["DESCRIPCION"].Value.ToString();                  

                CN_Domicilio Odir = new CN_Domicilio();
                tbDireccion.Text = Odir.BuscarDomicilio(Convert.ToInt32(tbIdDom.Text));

                CargarDomicilio();
                dgvProveedor.Enabled = false;
                Editar = true;
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
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
                    tabProveedor.SelectedTab = tabPConsulta;
                    dgvProveedor.Enabled = true;
                    lblSubTitutlo.Text = "Nuevo Proveedor";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            /*EditarDom = false;
            tbCuit.Enabled = true;            
            Editar = false;
            btnEliminar.Visible = true;
            btnModificar.Visible = true;*/
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count > 0)
            {
                string Rpta = "";
                string cuitProveedor = dgvProveedor.CurrentRow.Cells["CUIT"].Value.ToString();
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea Eliminar el Proveedor seleccionado", "¡Atencion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                try
                {
                    if (Opcion == DialogResult.OK)
                    {

                        Rpta = CN_Proveedor.Eliminar(cuitProveedor);

                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Eliminó Correctamente el proveedor con Nº CUIT: "+cuitProveedor);
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }

                
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void btnActualizaLista_Click(object sender, EventArgs e)
        {
            CargarGrilla();
            tbBusca.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarProveedor();
        }


        private void buscarProveedor()
        {
            if (tbBusca.Text == "")
            {
                CargarGrilla();
                MessageBox.Show("Para Buscar un proveedor debe ingresar su CUIT o Nombre de Empresa");
            }
            else
            {
                CN_Proveedor objetob = new CN_Proveedor();
                dgvProveedor.DataSource = objetob.BuscarProveedor(tbBusca.Text);
                if (dgvProveedor.SelectedRows.Count < 1)
                {
                    CN_Proveedor objA = new CN_Proveedor();
                    dgvProveedor.DataSource = objetob.BuscarProveedorCuit(tbBusca.Text);
                    if (dgvProveedor.SelectedRows.Count < 1)
                    {                        
                        MessageBox.Show("No existen registros");
                    }                        
                }
            }
        }


        private void btnSeleccionaDireccion_Click(object sender, EventArgs e)
        {
            tabProveedor.SelectedTab = tabListaDom;
        }


        private void btnNuevaDireccion_Click(object sender, EventArgs e)
        {
            LimpiarTabDomicilio();
            tabProveedor.SelectedTab = tabManDomicilios;
        }

        private void btnAceptaDom_Click(object sender, EventArgs e)
        {            
            if (tbCalle.Text != "")
            {
                if (cbLocalidad.Text != "")
                {
                    if (cbBarrio.Text != "")
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
                                        CargarGrillaDomicilios();
                                        CargarDomicilio();
                                        this.MensajeOk("Se Insertó de forma correcta el registro");
                                        LimpiarTabDomicilio();
                                        tabProveedor.SelectedTab = tabPMant;
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
                                        this.MensajeOk("Se Modificaron los datos del Domicilio");
                                        LimpiarTabDomicilio();
                                        CargarGrillaDomicilios();
                                        tabProveedor.SelectedTab = tabPMant;
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
                        MensajeError("Seleccione un Barrio");
                    }
                }
                else
                {
                    MensajeError("Seleccione una Localidad");
                }
            }
            else
            {
                MensajeError("Por Favor Ingrese el Nombre de la Calle");
            }          
        }

        private void btnCancelaDom_Click(object sender, EventArgs e)
        {
            dgvDomicilios.Enabled = true;
            tabProveedor.SelectedTab = tabListaDom;
            LimpiarTabDomicilio();
        }

        private void btnModificaDom_Click(object sender, EventArgs e)
        {
            if (dgvDomicilios.SelectedRows.Count > 0)
            {
                string loc = dgvDomicilios.CurrentRow.Cells["LOCALIDAD"].Value.ToString();
                string bar = dgvDomicilios.CurrentRow.Cells["BARRIO"].Value.ToString();
                string calle = dgvDomicilios.CurrentRow.Cells["CALLE"].Value.ToString();
                string nro = dgvDomicilios.CurrentRow.Cells["NRO"].Value.ToString();
                string piso = dgvDomicilios.CurrentRow.Cells["PISO"].Value.ToString();
                string dpto = dgvDomicilios.CurrentRow.Cells["DPTO"].Value.ToString();


                tabProveedor.SelectedTab = tabManDomicilios;
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

            }
            else
            {
                MensajeError("Seleccione una Direccion de la lista para modificar");
            }
        }

        private void btnEliminaDom_Click(object sender, EventArgs e)
        {
            if (dgvDomicilios.SelectedRows.Count > 0)
            {
                string Rpta = "";
                int iddomisele = Convert.ToInt32(dgvDomicilios.CurrentRow.Cells["ID"].Value.ToString());
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea Eliminar el Domicilio seleccionado", "¡Atencion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                try
                {
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

        private void btnActualizaListaDom_Click(object sender, EventArgs e)
        {
            CargarGrillaDomicilios();
            tbBuscarDomicilio.Text = "";
        }

        private void btnBuscaDom_Click(object sender, EventArgs e)
        {
            BuscarDomicilios();
        }

        private void BuscarDomicilios()
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


        private void dgvDomicilios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIdDom.Text = dgvDomicilios.CurrentRow.Cells["ID"].Value.ToString();
            tbDireccion.Text = dgvDomicilios.CurrentRow.Cells["CALLE"].Value.ToString() + " " + dgvDomicilios.CurrentRow.Cells["NRO"].Value.ToString(); ;
            tabProveedor.SelectedTab = tabPMant;
        }


        private void tbCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
                

        private void panelCUIT_Leave(object sender, EventArgs e)
        {
            var cadena = tbCuit.Text;

            if (cadena.Length < 8 || cbPreF.SelectedIndex == -1 || cbSuF.SelectedIndex == -1)
            {
                lblErrorCUIT.Visible = true;
            }
            else
            {
                lblErrorCUIT.Visible = false;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void tbEmpresa_Leave(object sender, EventArgs e)
        {
            if (tbEmpresa.Text == "")
            {
                lblErrorEmpresa.Visible = true;
            }
            else
            {
                lblErrorEmpresa.Visible = false;
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
    }
}
