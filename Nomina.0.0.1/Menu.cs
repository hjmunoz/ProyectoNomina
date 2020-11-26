using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina._0._0._1
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formnomina creacion = new formnomina();
            creacion.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comprobanteDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
