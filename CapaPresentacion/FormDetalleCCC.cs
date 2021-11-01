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
    public partial class FormDetalleCCC : Form
    {
        CN_CtaCte objeto = new CN_CtaCte();
        public FormDetalleCCC()
        {
            InitializeComponent();
        }
        private void FormDetalleCCC_Load(object sender, EventArgs e)
        {
            fechaHoy();
            CargarComboBoxClientes();
            CargarComboBoxProveedores();
        }

        private void fechaHoy()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;        
            dtpFecha1.Value = new DateTime(year, month, 1); 
            dtpFecha2.Value = DateTime.Now;
            dtpFecha1Prov.Value = new DateTime(year, month, 1);
            dtpFecha2Prov.Value = DateTime.Now;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cbCliente.SelectedIndex == -1)
            {
                MensajeError("Seleccione un cliente Por Favor");
            }
            else
            {
                CargarDetalleCtaCte();
            }
        }

        private void btnBuscarProv_Click(object sender, EventArgs e)
        {
            if (cbProveedores.SelectedIndex == -1)
            {
                MensajeError("Seleccione un proveedor Por Favor");
            }
            else
            {
                CargarDetalleCtaCteP();
            }
        }

        private void CargarDetalleCtaCte()
        {
            if (chekFecha.Checked == true)
            {
                this.dgvDetCtaCte.DataSource = CN_CtaCte.MostrarDetalleCtaCte(cbCliente.SelectedValue.ToString(), dtpFecha1.Value.ToString("dd/MM/yyyy"), dtpFecha2.Value.ToString("dd/MM/yyyy"));
                OcultaYAcomodaTabla();
                CargaSaldoCtaCte();
            }
            else
            {
                this.dgvDetCtaCte.DataSource = CN_CtaCte.MostrarDetalleCtaCteCompleto(cbCliente.SelectedValue.ToString());
                OcultaYAcomodaTabla();
                CargaSaldoCtaCte();
            }
        }

        private void CargarDetalleCtaCteP()
        {
            if (chekFechaProv.Checked == true)
            {
                this.dgvDetCtaCteProveedores.DataSource = CN_CtaCte.MostrarDetalleCtaCteP(cbProveedores.SelectedValue.ToString(), dtpFecha1Prov.Value.ToString("dd/MM/yyyy"), dtpFecha2Prov.Value.ToString("dd/MM/yyyy"));
                OcultaYAcomodaTablaP();
                CargaSaldoCtaCteP();
            }
            else
            {
                this.dgvDetCtaCteProveedores.DataSource = CN_CtaCte.MostrarDetalleCtaCteCompletoP(cbProveedores.SelectedValue.ToString());
                OcultaYAcomodaTablaP();
                CargaSaldoCtaCteP();
            }
        }

        private void OcultaYAcomodaTabla()
        {
            this.dgvDetCtaCte.Columns[0].Visible = false;
            this.dgvDetCtaCte.Columns[4].Visible = false;
            this.dgvDetCtaCte.Columns[5].Visible = false;

            
            this.dgvDetCtaCte.Columns[1].Width = 50;
            this.dgvDetCtaCte.Columns[2].Width = 35;
            this.dgvDetCtaCte.Columns[3].Width = 100;
            this.dgvDetCtaCte.Columns[6].Width = 80;
            this.dgvDetCtaCte.Columns[7].Width = 100;
        }
        private void OcultaYAcomodaTablaP()
        {
            this.dgvDetCtaCteProveedores.Columns[0].Visible = false;
            this.dgvDetCtaCteProveedores.Columns[4].Visible = false;
            this.dgvDetCtaCteProveedores.Columns[5].Visible = false;


            this.dgvDetCtaCteProveedores.Columns[1].Width = 50;
            this.dgvDetCtaCteProveedores.Columns[2].Width = 35;
            this.dgvDetCtaCteProveedores.Columns[3].Width = 100;
            this.dgvDetCtaCteProveedores.Columns[6].Width = 80;
            this.dgvDetCtaCteProveedores.Columns[7].Width = 100;
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

            if (saldo != suma)
            {
                if(chekFecha.Checked == true)
                {
                    MessageBox.Show("Existen Comprobantes fuera del rango de fechas");
                }
                else
                {
                    MessageBox.Show("Existe Inconsistencias de sumas iguales en la Cuenta Corriente");
                }
            }

            this.lblSaldo.Text = saldo.ToString();

        }

        private void CargaSaldoCtaCteP()
        {

            CN_CtaCte obsaldo1 = new CN_CtaCte();

            decimal suma = 0;
            foreach (DataGridViewRow row in dgvDetCtaCteProveedores.Rows)
            {
                if (row.Cells["IMPORTE"].Value != null)
                    suma += (Decimal)row.Cells["IMPORTE"].Value;
            }
            decimal saldo = obsaldo1.MostrarSaldoP(cbProveedores.SelectedValue.ToString());

            if (saldo != suma)
            {
                if (chekFechaProv.Checked == true)
                {
                    MessageBox.Show("Existen Comprobantes fuera del rango de fechas");
                }
                else
                {
                    MessageBox.Show("Existe Inconsistencias de sumas iguales en la Cuenta Corriente");
                }
            }

            this.lblSaldoProv.Text = saldo.ToString();

        }

        private void CargarComboBoxClientes()
        {            
            cbCliente.DataSource = objeto.CargaClientes();
            cbCliente.DisplayMember = "NOMBRE";
            cbCliente.ValueMember = "DNI";
            cbCliente.SelectedIndex = -1;
        }

        private void CargarComboBoxProveedores()
        {
            cbProveedores.DataSource = objeto.CargaProveedores();
            cbProveedores.DisplayMember = "NOMBRE";
            cbProveedores.ValueMember = "CUIL_CUIT";
            cbProveedores.SelectedIndex = -1;
        }



        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (cbCliente.SelectedIndex != -1)
            {
                FormDetalleCtaCteClienteSimple form = new FormDetalleCtaCteClienteSimple();
                form.Dni = cbCliente.SelectedValue.ToString();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se selecciono Ningun Cliente");
            }
        }
        private void btnImprimirProv_Click(object sender, EventArgs e)
        {
            /*CONFIGURAR IGUAL AL DE CLIENTES*/
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvDetCtaCte.SelectedRows.Count > 0)
            {
                dgvDetCtaCte.Columns.Clear();
            }
        }

        private void cbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvDetCtaCteProveedores.SelectedRows.Count > 0)
            {
                dgvDetCtaCteProveedores.Columns.Clear();
            }
        }

        private void chekFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chekFecha.Checked == false)
            {
                dtpFecha1.Enabled = false;
                dtpFecha2.Enabled = false;
            }
            else
            {
                dtpFecha1.Enabled = true;
                dtpFecha2.Enabled = true;
            }
        }

        private void chekFechaProv_CheckedChanged(object sender, EventArgs e)
        {
            if (chekFechaProv.Checked == false)
            {
                dtpFecha1Prov.Enabled = false;
                dtpFecha2Prov.Enabled = false;
            }
            else
            {
                dtpFecha1Prov.Enabled = true;
                dtpFecha2Prov.Enabled = true;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
