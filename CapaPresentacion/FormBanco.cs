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
    public partial class FormBanco : Form
    {

        CN_Domicilio objeto = new CN_Domicilio();
        private bool Editar = false;


        public FormBanco()
        {
            InitializeComponent();
        }

        private void FormBanco_Load(object sender, EventArgs e)
        {
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
            this.dgvCuentasBanco.DataSource = CN_CuentaBancaria.Mostrar();
           
            this.dgvCuentasBanco.Columns[0].Visible = false;            
            
            this.dgvCuentasBanco.Columns[1].Width = 35;
            this.dgvCuentasBanco.Columns[2].Width = 55;
            this.dgvCuentasBanco.Columns[3].Width = 15;
            this.dgvCuentasBanco.Columns[4].Width = 65;
            this.dgvCuentasBanco.Columns[5].Width = 60;
            this.dgvCuentasBanco.Columns[6].Width = 150;
        }


        private void limpiarCampos()
        {
            tbNumeroCuenta.Text = "";
            tbEntidadBancaria.Text = "";
            tbTitular.Text = "";
            tbCBU.Text = "";
            tbAlias.Text = "";
            tbID.Text = "";
            lblSubtitulo.Text = "";
        }

        private void habilitaCampos()
        {
            tbNumeroCuenta.Enabled = true;
            tbEntidadBancaria.Enabled = true;
            rbCA.Enabled = true;
            rbCC.Enabled = true;
            tbTitular.Enabled = true;
            tbCBU.Enabled = true;
            tbAlias.Enabled = true;
            btnCancela.Enabled = true;
            btnAceptar.Enabled = true;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            dgvCuentasBanco.Enabled = false;
            lblO1.Visible = true;
            lblO2.Visible = true;
            lblO3.Visible = true;
            lblO4.Visible = true;
            lblO5.Visible = true;
            lblCamposObligatorios.Visible = true;
        }

        private void deshabilitaCampos()
        {
            tbNumeroCuenta.Enabled = false;
            tbEntidadBancaria.Enabled = false;
            rbCA.Enabled = false;
            rbCC.Enabled = false;
            tbTitular.Enabled = false;
            tbCBU.Enabled = false;
            tbAlias.Enabled = false;
            btnCancela.Enabled = false;
            btnAceptar.Enabled = false;
            lblSubtitulo.Text = "";
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            dgvCuentasBanco.Enabled = true;
            Editar = false;
            lblO1.Visible = false;
            lblO2.Visible = false;
            lblO3.Visible = false;
            lblO4.Visible = false;
            lblO5.Visible = false;
            lblCamposObligatorios.Visible = false;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tbNumeroCuenta.Text == "" || tbEntidadBancaria.Text == "" || tbTitular.Text == "" || tbCBU.Text == "" || tbAlias.Text == "")
            {
                MensajeError("Existen campos vacios, por favor, complete todos los datos");
            }
            else
            {
                agregarNuevaCuenta();                
            }
        }


        private void agregarNuevaCuenta()
        {
            try
            {
                string tipoCta = "";
                if (rbCA.Checked == true)
                {
                    tipoCta = "CA";
                }
                if (rbCC.Checked == true)
                {
                    tipoCta = "CC";
                }

                if (Editar == false)
                {
                    string Rpta = "";
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Confirma la operacion?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.OK)
                    {
                        

                        Rpta = CN_CuentaBancaria.Insertar(tbNumeroCuenta.Text.Trim(),tbEntidadBancaria.Text.Trim(),tipoCta,tbTitular.Text.Trim(),tbCBU.Text.Trim(),tbAlias.Text.Trim());
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se insertó correctamente la nueva Cuenta Bancaria");
                            rbCA.Checked = true;
                            limpiarCampos();
                            deshabilitaCampos();
                            CargarGrilla();
                        }
                        else
                        {
                            this.MensajeError(Rpta);
                        }
                    }
                }
                if (Editar == true)
                {
                    int nroCuenta = Convert.ToInt32(tbID.Text.ToString());
                    string Rpta = "";
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Desea Modificar los datos de la Cuenta Bancaria?", "SOLIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.OK)
                    {
                        Rpta = CN_CuentaBancaria.Modificar(nroCuenta,tbNumeroCuenta.Text.Trim(), tbEntidadBancaria.Text.Trim(), tipoCta, tbTitular.Text.Trim(), tbCBU.Text.Trim(), tbAlias.Text.Trim());
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se modificaron correctamente los datos de la Cuenta Bancaria");
                            rbCA.Checked = true;
                            limpiarCampos();
                            deshabilitaCampos();
                            CargarGrilla();
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

        private void btnCancela_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Desea Cancelar la Operación?", "¡Atencion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            try
            {
                if (Opcion == DialogResult.OK)
                {
                    rbCA.Checked = true;
                    limpiarCampos();
                    deshabilitaCampos();
                }
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message + ex.StackTrace);
            }            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            habilitaCampos();
            tbNumeroCuenta.Focus();
            rbCA.Checked = true;
            lblSubtitulo.Text = "Nueva Cuenta Bancaria";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCuentasBanco.SelectedRows.Count > 0)
            {
                Editar = true;
                limpiarCampos();
                habilitaCampos();
                lblSubtitulo.Text = "Modificar Cuenta Bancaria";
                tbID.Text = dgvCuentasBanco.CurrentRow.Cells["ID_BANCO"].Value.ToString();
                tbNumeroCuenta.Text = dgvCuentasBanco.CurrentRow.Cells["NRO_CTA"].Value.ToString();
                tbEntidadBancaria.Text = dgvCuentasBanco.CurrentRow.Cells["NOMBRE_BANCO"].Value.ToString();
                if (dgvCuentasBanco.CurrentRow.Cells["TIPO_CTA"].Value.ToString() == "CA")
                {
                    rbCA.Checked = true;
                }
                else
                {
                    if (dgvCuentasBanco.CurrentRow.Cells["TIPO_CTA"].Value.ToString() == "CC")
                    {
                        rbCC.Checked = true;
                    }
                }
                tbTitular.Text = dgvCuentasBanco.CurrentRow.Cells["TITULAR_CTA"].Value.ToString();
                tbCBU.Text = dgvCuentasBanco.CurrentRow.Cells["CBU_CTA"].Value.ToString();
                tbAlias.Text = dgvCuentasBanco.CurrentRow.Cells["ALIAS_CTA"].Value.ToString();
            }
            else
            {
                MensajeError("Seleccione una cuenta para modificar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCuentasBanco.SelectedRows.Count > 0)
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea Eliminar la cuenta de Banco seleccionada", "¡Atencion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                try
                {
                    string Rpta = "";
                    int idCuenta = Convert.ToInt32(dgvCuentasBanco.CurrentRow.Cells["ID_BANCO"].Value.ToString());
                    if (Opcion == DialogResult.OK)
                    {

                        Rpta = CN_CuentaBancaria.Eliminar(idCuenta);

                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Eliminó Correctamente la Cuenta Bancaria seleccionada");
                        }
                        else
                        {
                            this.MensajeError(Rpta);
                        }
                        limpiarCampos();
                        CargarGrilla();
                    }
                }
                catch (Exception ex)
                {
                    MensajeError(ex.Message + ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void tbNumeroCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbCBU_KeyPress(object sender, KeyPressEventArgs e)
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
