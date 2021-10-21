using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormTop20ProdCompImporte : Form
    {
        private string _FechaInicio;
        private string _FechaFin;

        public string FechaInicio
        {
            get { return _FechaInicio; }
            set { _FechaInicio = value; }
        }
        public string FechaFin
        {
            get { return _FechaFin; }
            set { _FechaFin = value; }
        }
        public FormTop20ProdCompImporte()
        {
            InitializeComponent();
        }

        private void FormTop20ProdCompImporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.RPT_Prod_Compra_Precio' Puede moverla o quitarla según sea necesario.
            this.RPT_Prod_Compra_PrecioTableAdapter.Fill(this.dsPrincipal.RPT_Prod_Compra_Precio,FechaInicio,FechaFin);

            this.reportViewer1.RefreshReport();
        }
    }
}
