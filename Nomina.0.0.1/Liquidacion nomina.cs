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
    public partial class formnomina : Form
    {
        public formnomina()
        {
            InitializeComponent();
        }

        private void formnomina_Load(object sender, EventArgs e)
        {
            
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtapellidos.Focus();
                e.Handled = true;
            }
        }

        private void txtapellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtidentificacion.Focus();
                e.Handled = true;
            }
        }

        private void txtidentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtdireccion.Focus();
                e.Handled = true;
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txthrncre.Focus();
                e.Handled = true;
            }
        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txthedcre.Focus();
                e.Handled = true;
            }
        }

        private void txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txthencre.Focus();
                e.Handled = true;
            }
        }

        private void txtciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtheddcre.Focus();
                e.Handled = true;
            }
        }

        private void txteps_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txthedncre.Focus();
                e.Handled = true;
            }
        }

        private void txtpension_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnguardar.Focus();
                e.Handled = true;
            }
        }

        private void txtcargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtauxilio.Focus();
                e.Handled = true;
            }
        }

        private void txttipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtsalario.Focus();
                e.Handled = true;
            }
        }

        private void txtsalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtcomisiones.Focus();
                e.Handled = true;
            }
        }

        private void txtauxilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtnivel.Focus();
                e.Handled = true;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            dgempleados.Rows.Add(txtnombre.Text, txtapellidos.Text, txtidentificacion.Text,txtdireccion.Text, txtcuenta.Text, txtsalario.Text, txtcomisiones.Text, txtauxilio.Text, txtnivel.Text, 
                                 txtdiaslabo.Text, txthrncre.Text, txthedcre.Text, txthencre.Text, txtheddcre.Text, txthedncre.Text, txtauxilio.Text, txtnivel.Text);
            txtnombre.Text = "";
            txtapellidos.Text = "";
            txtidentificacion.Text = "";
            txtdireccion.Text = "";
            txtcuenta.Text = "";
            txtsalario.Text = "";
            txtcomisiones.Text = "";
            txtauxilio.Text = "";
            txtnivel.Text = "";
            txtdiaslabo.Text = "";
            txthrncre.Text = "";
            txthedcre.Text = "";
            txthencre.Text = "";
            txtheddcre.Text = "";
            txthedncre.Text = "";
            txtauxilio.Text = "";
            txtnivel.Text = "";
            txtnombre.Focus();
        }

        private void btneliminar_Click(object sender, EventArgs e)

        {
            if (this.dgempleados.SelectedRows.Count > 0)
            {
                dgempleados.Rows.RemoveAt(this.dgempleados.SelectedRows[0].Index);
            }
        }

        private void dgempleados_Click(object sender, EventArgs e)
        {

        }

        public 

         void Dgempleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgempleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtnombre.Text = dgempleados.CurrentRow.Cells[0].Value.ToString();
                txtapellidos.Text = dgempleados.CurrentRow.Cells[1].Value.ToString();
                txtidentificacion.Text = dgempleados.CurrentRow.Cells[2].Value.ToString();
                txtdireccion.Text = dgempleados.CurrentRow.Cells[3].Value.ToString();
                txtcuenta.Text = dgempleados.CurrentRow.Cells[4].Value.ToString();
                txtsalario.Text = dgempleados.CurrentRow.Cells[5].Value.ToString();
                txtcomisiones.Text = dgempleados.CurrentRow.Cells[6].Value.ToString();
                txtauxilio.Text = dgempleados.CurrentRow.Cells[7].Value.ToString();
                txtnivel.Text = dgempleados.CurrentRow.Cells[8].Value.ToString();
                txtdiaslabo.Text = dgempleados.CurrentRow.Cells[9].Value.ToString();
                txthrncre.Text = dgempleados.CurrentRow.Cells[10].Value.ToString();
                txthedcre.Text = dgempleados.CurrentRow.Cells[11].Value.ToString();
                txthencre.Text = dgempleados.CurrentRow.Cells[12].Value.ToString();
                txtheddcre.Text = dgempleados.CurrentRow.Cells[13].Value.ToString();
                txthedncre.Text = dgempleados.CurrentRow.Cells[14].Value.ToString();   
            }
            catch 
            { 
            
            }
        }

        private void btnliquidar_Click(object sender, EventArgs e)
        {
            formliquidar fliquidar = new formliquidar();
            fliquidar.txtnombre2.Text = txtnombre.Text;
            fliquidar.txtapellidos.Text = txtapellidos.Text;
            fliquidar.txtidentificacion.Text = txtidentificacion.Text;
            fliquidar.txtdireccion.Text = txtdireccion.Text;
            fliquidar.txtcuenta.Text = txtcuenta.Text;
            fliquidar.txtsalario.Text = txtsalario.Text;
            fliquidar.txtauxilio.Text = txtauxilio.Text;
            fliquidar.txtnivel.Text = txtnivel.Text;
            fliquidar.txtdias.Text = txtdiaslabo.Text;
            fliquidar.txthrn.Text = txthrncre.Text;
            fliquidar.txthed.Text = txthedcre.Text;
            fliquidar.txthen.Text = txthencre.Text;
            fliquidar.txthedd.Text = txtheddcre.Text;
            fliquidar.txthedn.Text = txthedncre.Text;
            fliquidar.txtcomisiones.Text = txtcomisiones.Text;
            fliquidar.Show();
            fliquidar.txthen.Focus();
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void txtnivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtdiaslabo.Focus();
                e.Handled = true;
            }
        }

        private void txtdireccion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtcuenta.Focus();
                e.Handled = true;
            }
        }

        private void txtcuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtsalario.Focus();
                e.Handled = true;
            }
        }
    }
}
