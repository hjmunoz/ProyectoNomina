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
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
            tiempo.Enabled = true;
            tiempo.Interval = 3000;
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            tiempo.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }
    }
}
