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
    public partial class frminicio : Form
    {
        int i;
        public frminicio()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtcontraseña.Focus();
                e.Handled = true;

            }
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btningresar.Focus();
                e.Handled = true;
            }
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            
            string Usuario = "Hector";
            string Usuario1 = "HECTOR";
            string Usuario2 = "hector";
            string Contraseña = "1234";
            while (i < 3)
            {

                if (txtusuario.Text == Usuario || txtusuario.Text == Usuario1 || txtusuario.Text == Usuario2 )
                {
                    if (txtcontraseña.Text == Contraseña)
                    {
                        MessageBox.Show("Bienvenido");
                        this.Hide();

                        frmmenu menu = new frmmenu();
                        menu.Show();

                    }

                    else
                    {
                        MessageBox.Show("Usuario o contraseña invalida");
                        i = i + 1;
                    }
                    if (i == 3)
                    {
                        MessageBox.Show("Usuario sera bloqueado");
                    }
                }
                

                break;
            }
            
            
        }
    }
}
