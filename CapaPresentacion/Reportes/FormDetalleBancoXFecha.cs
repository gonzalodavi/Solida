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
    public partial class FormDetalleBancoXFecha : Form
    {
        private int _Id;
        private DateTime _Fecha1;
        private DateTime _Fecha2;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public DateTime Fecha1
        {
            get { return _Fecha1; }
            set { _Fecha1 = value; }
        }

        public DateTime Fecha2
        {
            get { return _Fecha2; }
            set { _Fecha2 = value; }
        }

        public FormDetalleBancoXFecha()
        {
            InitializeComponent();
        }

        private void FormDetalleBancoXFecha_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.InformeDetalleBancoxFecha' Puede moverla o quitarla según sea necesario.
            this.InformeDetalleBancoxFechaTableAdapter.Fill(this.dsPrincipal.InformeDetalleBancoxFecha,Id,Fecha1,Fecha2);

            this.reportViewer1.RefreshReport();
        }
    }
}
