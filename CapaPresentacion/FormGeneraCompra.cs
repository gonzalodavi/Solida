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
    public partial class FormGeneraCompra : Form
    {

        public int IDCOMPRAS;

        public FormGeneraCompra()
        {
            InitializeComponent();
        }

        private void GenerarComprobantes(int idcompra)
        {
            CN_GenerarComprobanteCompra generarComprobantes = new CN_GenerarComprobanteCompra();
            generarComprobantes.GenerarComprobantes(idcompra);

            CN_GenerarComprobanteCompraBindingSource.DataSource = generarComprobantes.generarComprobantes;
            reportViewer1.RefreshReport();
        }

        private void FormGeneraCompra_Load(object sender, EventArgs e)
        {
            GenerarComprobantes(IDCOMPRAS);         
        }
    }
}
