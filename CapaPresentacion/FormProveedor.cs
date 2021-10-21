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
        private string idProvSelec;
        private int NroProvincia;


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
        }
        private void CargarGrillaDomicilios()
        {
            this.dgvDomicilios.DataSource = CN_Domicilio.Mostrar();
            this.dgvDomicilios.Columns[0].Visible = false;
            this.dgvDomicilios.Columns[3].Visible = false;
            this.dgvDomicilios.Columns[4].Visible = false;
            this.dgvDomicilios.Columns[6].Visible = false;
            this.dgvDomicilios.Columns[8].Visible = false;
        }

        private void CargarDomicilio()
        {
            this.dgvDomCompleto.DataSource = CN_Domicilio.MostrarDomicilioEnGrilla(Convert.ToInt32(tbIdDom.Text));
        }


        private void limpiarCampos()
        {          
            CargarComboBoxProvincia();
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
            
            cbLoc.Text = ""; 
        }

        private void btnModificarProv_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count > 0)
            {
                tabProveedor.SelectedTab = tabPMant;
                lblSubTitutlo.Text = "Modificar Proveedor";
                limpiarCampos();                              
                
                tbCuit.Text = dgvProveedor.CurrentRow.Cells["CUIT"].Value.ToString();
                tbCuit.Enabled = false;
                
                cbLoc.Enabled = true;
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
            limpiarCampos();
            lblSubTitutlo.Text = "Nuevo Proveedor";
            EditarDom = false;
            tbCuit.Enabled = true;            
            cbLoc.Enabled = false;
            Editar = false;
            btnEliminar.Visible = true;
            btnModificar.Visible = true;
            dgvProveedor.Enabled = true;
            tabProveedor.SelectedTab = tabPConsulta;
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

                        Rpta = CN_Proveedor.Insertar(this.tbCuit.Text.Trim(), this.tbEmpresa.Text.Trim(), this.tbNombre.Text.Trim(), this.tbApellido.Text.Trim(), this.tbMail.Text.Trim(), this.tbTel.Text.Trim(), nroiddireccion, this.tbDescripcion.Text.Trim());
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

                        Rpta = CN_Proveedor.Modificar(this.tbCuit.Text.Trim(), this.tbEmpresa.Text.Trim(), this.tbNombre.Text.Trim(), this.tbApellido.Text.Trim(), this.tbMail.Text.Trim(), this.tbTel.Text.Trim(), nroiddireccion, this.tbDescripcion.Text.Trim());
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
                        LimpiarTabLocBar();
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

        /*private void dgvProveedor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormCompra datosProveedores = Owner as FormCompra;
            datosProveedores.tbCuit.Text = dgvProveedor.CurrentRow.Cells[0].Value.ToString();
            datosProveedores.tbProveedor.Text = dgvProveedor.CurrentRow.Cells[1].Value.ToString();
            datosProveedores.tbDireccion.Text = dgvProveedor.CurrentRow.Cells[6].Value.ToString() + " " + dgvProveedor.CurrentRow.Cells[7].Value.ToString() + ", " + dgvProveedor.CurrentRow.Cells[10].Value.ToString() + " (" + dgvProveedor.CurrentRow.Cells[11].Value.ToString() + "), " + dgvProveedor.CurrentRow.Cells[12].Value.ToString() + ", " + dgvProveedor.CurrentRow.Cells[13].Value.ToString();
            Close();
        }*/


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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarProveedor();
        }

        private void btnActualizaLista_Click(object sender, EventArgs e)
        {
            CargarGrilla();
            tbBusca.Text = "";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        private void btnAceptaDom_Click(object sender, EventArgs e)
        {            
            if (tbCalle.Text != "" && cbProvincia.Text != "")
            {
                if (dgvLocalidad.Rows.Count > 0)
                {
                    if (dgvBarrio.Rows.Count > 0)
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
                                    int nroidbar = Convert.ToInt32(dgvBarrio.CurrentRow.Cells["ID_BARRIO"].Value.ToString());
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
                                    int nroidbar = Convert.ToInt32(dgvBarrio.CurrentRow.Cells["ID_BARRIO"].Value.ToString());
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
                MensajeError("Faltan ingresar Datos");
            }          
        }

        private void btnLimpiarProvLocBar_Click(object sender, EventArgs e)
        {
            LimpiarTabLocBar();            
        }

        private void LimpiarTabLocBar()
        {
            CargarComboBoxProvincia();
            tbNuevoBarrio.Text = "";
            tbNuevoCodPos.Text = "";
            tbLocalidad.Text = "";   
        }

        private void LimpiarTabDomicilio()
        {
            lblSeleDom.Text = "Selección de Domicilio";
            tbCalle.Text = "";
            tbNro.Text = "";
            tbPiso.Text = "";
            tbDpto.Text = "";
            cbProvincia.SelectedIndex = 1;
            tbProvinciaSeleccionada.Visible = false;
            tbLocalidadSeleccionada.Visible = false;
            tbBarrioSeleccionado.Visible = false;
            tbProvinciaSeleccionada.Text = "";
            tbLocalidadSeleccionada.Text = "";
            tbBarrioSeleccionado.Text = "";
        }


        private void btnSeleccionaDireccion_Click(object sender, EventArgs e)
        {
            tabProveedor.SelectedTab = tabListaDom;            
        }

        private void btnAgregaBarrio_Click(object sender, EventArgs e)
        {
            if (dgvLocalidad.SelectedRows.Count > 0)
            {
                tabProveedor.SelectedTab = tabLocalidad;
               
                cbProvT4.Text = cbProvincia.Text;
                //cbLocaT4.Text = dgvLocalidad.CurrentRow.Cells["DES_LOCALIDAD"].Value.ToString();
            }
            else
            {
                MensajeError("Por Favor Seleccione una Provincia y una Localidad");
            }
        }

        private void btnAgregaLoc_Click(object sender, EventArgs e)
        {
            if (cbProvincia.Text != "")
            {
                tabProveedor.SelectedTab = tabLocalidad;
                cbProvT4.Text = cbProvincia.Text;
            }
            else
            {
                MensajeError("Por Favor Seleccione una Provincia");
            }
        }

        

       

        private void btnAceptaLoc_Click(object sender, EventArgs e)
        {
            if (cbProvT4.Text!= "")
            {
                if (tbLocalidad.Text != "")
                {
                    try
                    {
                        string Rpta = "";

                        DialogResult Opcion;
                        Opcion = MessageBox.Show("Desea Agregar la Nueva Localidad?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (Opcion == DialogResult.OK)
                        {
                            int nroidprov = Convert.ToInt32(cbProvT4.SelectedValue);

                            Rpta = CN_Domicilio.InsertarLocalidad(this.tbLocalidad.Text.Trim(), nroidprov);
                            if (Rpta.Equals("OK"))
                            {
                                CargarComboBoxLocalidad(nroidprov);
                                cbLoc.Text = tbLocalidad.Text;
                                this.MensajeOk("Se Insertó de forma correcta el registro.\nAgregue un Barrio para la Localidad ingresada");
                                LimpiarTabLocBar();                                
                                tabProveedor.SelectedTab = tabBarrio;
                                tbNuevoBarrio.Focus();
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
                else
                {
                    MensajeError("Ingrese Nombre de la Localidad");
                }
            }
            else
            {
                MensajeError("Seleccione una Provincia");
            }
               
        }   






        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvincia.Text != "")
            {
                
                string elid = cbProvincia.SelectedValue.ToString();
                int numero = Convert.ToInt32(elid);
                this.dgvLocalidad.DataSource = CN_Domicilio.CargaLocalidad(numero);
                this.dgvLocalidad.Columns[0].Visible = false;
                this.dgvLocalidad.Columns[2].Visible = false;
                this.dgvBarrio.DataSource = CN_Domicilio.CargaBarrio(0);
            }

            /*validarProvincia();
            idProvSelec = cbProvincia.SelectedValue.ToString();
            NroProvincia = Convert.ToInt32(idProvSelec);
            CargarComboBoxLocalidad(NroProvincia);
            cbProvT4.Text = cbProvincia.Text;
            if (cbBarrio.Text == "")
            {
                tbCodPostal.Text = "";
            }
            else
            {
                idBarSele = cbBarrio.SelectedValue.ToString();
                NroBar = Convert.ToInt32(idBarSele);

                CN_Domicilio obje = new CN_Domicilio();
                tbCodPostal.Text = obje.CargarCodigoPostal(NroBar);
            }
            if(cbLoc.Text == "")
            {
                tbCodPostal.Text = "";
                idProvSelec = cbProvincia.SelectedValue.ToString();
                CargarComboBoxBarrio(NroLoc);
            }*/
        }

        private void cbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*validarLocalidad();
            idLocSelec = cbLoc.SelectedValue.ToString();
            NroLoc = Convert.ToInt32(idLocSelec);
            CargarComboBoxBarrio(NroLoc);
            cbLocaT4.Text = cbProvincia.Text;
            if (cbBarrio.Text == "")
            {
                tbCodPostal.Text = "";
            }
            else
            {
                idBarSele = cbBarrio.SelectedValue.ToString();
                NroBar = Convert.ToInt32(idBarSele);

                CN_Domicilio obje = new CN_Domicilio();
                tbCodPostal.Text = obje.CargarCodigoPostal(NroBar);
            }*/
        }






        //CARGAR LOS COMBOBOX DE LOCALIDAD Y PROVINCIA

        private void CargarComboBoxProvincia()
        {
            cbProvincia.DisplayMember = "DES_PROVINCIA";
            cbProvincia.ValueMember = "ID_PROVINCIA";
            cbProvincia.DataSource = objeto.CargaProvincia();

            cbProvT4.DisplayMember = "DES_PROVINCIA";
            cbProvT4.ValueMember = "ID_PROVINCIA";
            cbProvT4.DataSource = objeto.CargaProvincia();

            cbProvT5.DisplayMember = "DES_PROVINCIA";
            cbProvT5.ValueMember = "ID_PROVINCIA";
            cbProvT5.DataSource = objeto.CargaProvincia();
        }

        private void CargarComboBoxLocalidad(int NroProvincia)
        {
            cbLoc.DisplayMember = "DES_LOCALIDAD";
            cbLoc.ValueMember = "ID_LOCALIDAD";
            cbLoc.DataSource = CN_Domicilio.CargaLocalidadEnComboBox(NroProvincia);
        }

       
        private void btnCancelaDom_Click(object sender, EventArgs e)
        {
            EditarDom = false;
            LimpiarTabDomicilio();
        }

        

        private void dgvLocalidad_Click(object sender, EventArgs e)
        {
            if (dgvLocalidad.SelectedRows.Count > 0)
            {
                string elid = dgvLocalidad.CurrentRow.Cells["ID_LOCALIDAD"].Value.ToString();
                int numero = Convert.ToInt32(elid);
                this.dgvBarrio.DataSource = CN_Domicilio.CargaBarrio(numero);
                this.dgvBarrio.Columns[0].Visible = false;
                this.dgvBarrio.Columns[2].Visible = false;

            }
        }

        private void cbProvT5_SelectedIndexChanged(object sender, EventArgs e)
        {
            idProvSelec = cbProvT5.SelectedValue.ToString();
            NroProvincia = Convert.ToInt32(idProvSelec);
            CargarComboBoxLocalidad(NroProvincia);
        }

        private void btnAceptaBarrio_Click(object sender, EventArgs e)
        {
            if (cbProvT5.Text != "")
            {
                if (cbLoc.Text != "")
                {
                    if (tbNuevoBarrio.Text != "" && tbNuevoCodPos.Text != "")
                    {
                        try
                        {
                            string Rpta = "";

                            DialogResult Opcion;
                            Opcion = MessageBox.Show("Desea Agregar el Nuevo Barrio?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (Opcion == DialogResult.OK)
                            {
                                int nroidloc = Convert.ToInt32(cbLoc.SelectedValue.ToString());
                                Rpta = CN_Domicilio.InsertarBarrio(this.tbNuevoBarrio.Text.Trim(), nroidloc, this.tbNuevoCodPos.Text.Trim());
                                if (Rpta.Equals("OK"))
                                {
                                    //CargarComboBoxBarrio(nroidloc);
                                    //cbBarrio.Text = tbNuevoBarrio.Text;
                                    //tbCodPostal.Text = tbNuevoCodPos.Text;
                                    this.MensajeOk("Se Insertó de forma correcta el registro");
                                    LimpiarTabLocBar();

                                    tabProveedor.SelectedTab = tabManDomicilios;
                                    tbCalle.Focus();
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
                    else
                    {
                        MensajeError("Ingrese Nombre del Barrio y su Codigo Postal");
                    }
                }
                else
                {
                    MensajeError("No se selecciono Localidad");
                }
            }
            else
            {
                MensajeError("No se selecciono Provincia");
            }
        }

        private void btnCancelaLocalidad_Click(object sender, EventArgs e)
        {
            tabProveedor.SelectedTab = tabManDomicilios;
            tbLocalidad.Text = "";
            CargarComboBoxProvincia();
        }

        private void btnCancelaBarrio_Click(object sender, EventArgs e)
        {
            tabProveedor.SelectedTab = tabManDomicilios;
            tbNuevoBarrio.Text = "";
            tbNuevoCodPos.Text = "";
            CargarComboBoxProvincia();
        }

        private void btnModificaDom_Click(object sender, EventArgs e)
        {
            if (dgvDomicilios.SelectedRows.Count > 0)
            {
                dgvDomicilios.Enabled = false;
                tabProveedor.SelectedTab = tabManDomicilios;
                EditarDom = true;
                lblSeleDom.Text = "Modificar Domicilio";
                tbIdDom.Text = dgvDomicilios.CurrentRow.Cells["ID"].Value.ToString();
                tbProvinciaSeleccionada.Text = "ACTUAL: " + dgvDomicilios.CurrentRow.Cells["PROVINCIA"].Value.ToString();
                tbLocalidadSeleccionada.Text = "ACTUAL: " + dgvDomicilios.CurrentRow.Cells["LOCALIDAD"].Value.ToString();
                tbBarrioSeleccionado.Text = "ACTUAL: " + dgvDomicilios.CurrentRow.Cells["BARRIO"].Value.ToString();
                tbProvinciaSeleccionada.Visible = true;
                tbLocalidadSeleccionada.Visible = true;
                tbBarrioSeleccionado.Visible = true;
                tbCalle.Text = dgvDomicilios.CurrentRow.Cells["CALLE"].Value.ToString();
                tbNro.Text = dgvDomicilios.CurrentRow.Cells["NRO"].Value.ToString();
                tbPiso.Text = dgvDomicilios.CurrentRow.Cells["PISO"].Value.ToString();
                tbDpto.Text = dgvDomicilios.CurrentRow.Cells["DPTO"].Value.ToString();
                MessageBox.Show("Para modificar el domicilio debe seleccionar nuevamente: Provincia, Localidad y Barrio");
                dgvDomicilios.Enabled = false;
            }
            else
            {
                MensajeError("Seleccione una Direccion de la lista para modificar");
            }
        }

        private void btnNuevaDireccion_Click(object sender, EventArgs e)
        {
            LimpiarTabDomicilio();
            tabProveedor.SelectedTab = tabManDomicilios;
        }

        private void dgvDomicilios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIdDom.Text = dgvDomicilios.CurrentRow.Cells["ID"].Value.ToString();
            tbDireccion.Text = dgvDomicilios.CurrentRow.Cells["CALLE"].Value.ToString() + " " + dgvDomicilios.CurrentRow.Cells["NRO"].Value.ToString(); ;
            tabProveedor.SelectedTab = tabPMant;
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

        private void btnActualizaListaDom_Click(object sender, EventArgs e)
        {
            CargarGrillaDomicilios();
            tbBuscarDomicilio.Text = "";
        }
    }
}
