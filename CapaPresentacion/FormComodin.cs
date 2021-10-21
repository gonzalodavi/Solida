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
    public partial class FormComodin : FormBase
    {
        public FormComodin()
        {
            InitializeComponent();
        }

        private void FormComodin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBase pete = new FormBase();
            pete.Show();
        }
    }
}
