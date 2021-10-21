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
    public partial class FormReporteVenta : Form
    {
        private int _IdVenta;
        public int IdVenta
        {
            get { return _IdVenta; }
            set { _IdVenta = value; }
        }
        public FormReporteVenta()
        {
            InitializeComponent();
        }

        private void FormReporteVenta_Load(object sender, EventArgs e)
        {
            try
            {
                this.ReporteVentasTableAdapter.Fill(this.dsPrincipal.ReporteVentas, IdVenta);
                this.DatosEmpresaTableAdapter.Fill(this.bd2DataSet.DatosEmpresa);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
