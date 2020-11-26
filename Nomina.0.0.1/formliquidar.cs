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
    public partial class formliquidar : Form
    {
        public formliquidar()
        {
            InitializeComponent();
        }

        private void txtdias_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtdias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txthrn.Focus();
                e.Handled = true;
            }
        }

        private void txtrn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txthed.Focus();
                e.Handled = true;
            }
        }

        private void txthed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txthen.Focus();
                e.Handled = true;
            }
        }

        private void txthen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnliquidar.Focus();
                e.Handled = true;
            }
        }

        private void txthod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txthedd.Focus();
                e.Handled = true;
            }
        }

        private void txthedd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txthedn.Focus();
                e.Handled = true;
            }
        }

        private void txthend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnliquidar.Focus();
                e.Handled = true;
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void formliquidar_Load(object sender, EventArgs e)
        {

        }

        private void btnliquidar_Click(object sender, EventArgs e)
            
        {

            double comisiones, neto, total_devengado, total_extras, hrn, hedn, hed, hen, hedd, auxilio_dias, dhrn, dhedn, dhedd, dhed, dhen, valor_hora, dias, salario_dias, salario, auxilio_transporte, aportes_salud, aportes_pension;
            double fdsp, total_seguridad, arp, nivel, prestaciones, aportes, vacaciones, intereses_cesan, cesantias, prima, icbf, caja_compensacion, salud8, pension12, sena;
            salario = Convert.ToInt32(txtsalario.Text);
            if (salario < 1755606)
            {
                
                dias = Convert.ToInt32(txtdias.Text);
                dhed = Convert.ToInt32(txthed.Text);
                dhen = Convert.ToInt32(txthen.Text);
                dhedd = Convert.ToInt32(txthedd.Text);
                dhedn = Convert.ToInt32(txthedn.Text);
                dhrn = Convert.ToInt32(txthrn.Text);
                comisiones = Convert.ToInt32(txtcomisiones.Text);
                auxilio_transporte = Convert.ToInt32(txtauxilio.Text);
                nivel = Convert.ToInt32(txtnivel.Text);
                valor_hora = salario / 240;
                salario_dias = salario / 30 * dias;
                auxilio_dias = auxilio_transporte / 30 * dias;
                hed = 1.25 * valor_hora * dhed;
                hen = 1.75 * valor_hora * dhen;
                hedd = 2 * valor_hora * dhedd;
                hedn = 2.5 * valor_hora * dhedn;
                hrn = 1.35 * valor_hora * dhrn;
                total_extras = hed + hen + hedd + hedn + hrn + comisiones;
                aportes_salud = (salario + total_extras) * 4 / 100;
                aportes_pension = (salario + total_extras) * 4 / 100;
                salud8 = (salario + total_extras) * 8.5 / 100;
                pension12 = (salario + total_extras) * 12 / 100;
                sena = (salario + total_extras) * 2 / 100;
                caja_compensacion = (salario + total_extras) * 4 / 100;
                icbf = (salario + total_extras) * 3 / 100;
                aportes = sena + caja_compensacion + icbf;
                prima = (salario + total_extras + auxilio_dias) * 8.33 / 100;
                cesantias = (salario + total_extras + auxilio_dias) * 8.33 / 100;
                intereses_cesan = cesantias * 12 / 100;
                vacaciones = (salario + total_extras) * 4.17 / 100;
                prestaciones = prima + cesantias + intereses_cesan + vacaciones;
                total_devengado = total_extras + salario_dias + auxilio_dias;
                neto = total_devengado - (aportes_pension + aportes_salud);
                lblhrn.Text = hrn.ToString();
                lblhed.Text = hed.ToString();
                lblhen.Text = hen.ToString();
                lblhedd.Text = hedd.ToString();
                lblhedn.Text = hedn.ToString();
                lbltotalextra.Text = total_extras.ToString();
                lblauxilio.Text = auxilio_dias.ToString();
                lbltotaldeve.Text = total_devengado.ToString();
                lblsalud.Text = aportes_salud.ToString();
                lblpension.Text = aportes_pension.ToString();
                lblsueldo.Text = salario_dias.ToString();
                lblcomisiones.Text = comisiones.ToString();
                lblneto.Text = neto.ToString();
                lblsalud8.Text = salud8.ToString();
                lblpension12.Text = pension12.ToString();
                lblsena.Text = sena.ToString();
                lblcaja.Text = caja_compensacion.ToString();
                lblicbf.Text = icbf.ToString();
                lblprima.Text = prima.ToString();
                lblcesantias.Text = cesantias.ToString();
                lblintecesantias.Text = intereses_cesan.ToString();
                lblvacaciones.Text = vacaciones.ToString();
                lblprestaciones.Text = prestaciones.ToString();
                lblaportes.Text = aportes.ToString();

                if (txtnivel.Text == Convert.ToString(1))
                {
                    arp = (salario + total_extras) * 0.522 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(2))
                {
                    arp = (salario + total_extras) * 1.044 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(3))
                {
                    arp = (salario + total_extras) * 2.436 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(4))
                {

                    arp = (salario + total_extras) * 4.350 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else
                {
                    arp = (salario + total_extras) * 6.960 / 100;
                    lblarl5.Text = arp.ToString();
                }
                total_seguridad = salud8 + pension12 + arp;
                lbltotalseguridad.Text = total_seguridad.ToString();
            }
            else if (salario > 1755606 && salario < 3511212)
            {
                dias = Convert.ToInt32(txtdias.Text);
                dhed = Convert.ToInt32(txthed.Text);
                dhen = Convert.ToInt32(txthen.Text);
                dhedd = Convert.ToInt32(txthedd.Text);
                dhedn = Convert.ToInt32(txthedn.Text);
                dhrn = Convert.ToInt32(txthrn.Text);
                comisiones = Convert.ToInt32(txtcomisiones.Text);
                auxilio_transporte = Convert.ToInt32(txtauxilio.Text);
                nivel = Convert.ToInt32(txtnivel.Text);
                valor_hora = salario / 240;
                salario_dias = salario / 30 * dias;
                auxilio_dias = auxilio_transporte / 30 * dias;
                hed = 1.25 * valor_hora * dhed;
                hen = 1.75 * valor_hora * dhen;
                hedd = 2 * valor_hora * dhedd;
                hedn = 2.5 * valor_hora * dhedn;
                hrn = 1.35 * valor_hora * dhrn;
                total_extras = hed + hen + hedd + hedn + hrn + comisiones;
                aportes_salud = (salario + total_extras) * 4 / 100;
                aportes_pension = (salario + total_extras) * 4 / 100;
                salud8 = (salario + total_extras) * 8.5 / 100;
                pension12 = (salario + total_extras) * 12 / 100;
                sena = (salario + total_extras) * 2 / 100;
                caja_compensacion = (salario + total_extras) * 4 / 100;
                icbf = (salario + total_extras) * 3 / 100;
                aportes = sena + caja_compensacion + icbf;
                prima = (salario + total_extras) * 8.33 / 100;
                cesantias = (salario + total_extras) * 8.33 / 100;
                intereses_cesan = cesantias * 12 / 100;
                vacaciones = (salario + total_extras) * 4.17 / 100;
                prestaciones = prima + cesantias + intereses_cesan + vacaciones;
                total_devengado = total_extras + salario_dias;
                neto = total_devengado - (aportes_pension + aportes_salud);
                lblhrn.Text = hrn.ToString();
                lblhed.Text = hed.ToString();
                lblhen.Text = hen.ToString();
                lblhedd.Text = hedd.ToString();
                lblhedn.Text = hedn.ToString();
                lbltotalextra.Text = total_extras.ToString();
                lblauxilio.Text = 0.ToString();
                lbltotaldeve.Text = total_devengado.ToString();
                lblsalud.Text = aportes_salud.ToString();
                lblpension.Text = aportes_pension.ToString();
                lblsueldo.Text = salario_dias.ToString();
                lblcomisiones.Text = comisiones.ToString();
                lblneto.Text = neto.ToString();
                lblsalud8.Text = salud8.ToString();
                lblpension12.Text = pension12.ToString();
                lblsena.Text = sena.ToString();
                lblcaja.Text = caja_compensacion.ToString();
                lblicbf.Text = icbf.ToString();
                lblprima.Text = prima.ToString();
                lblcesantias.Text = cesantias.ToString();
                lblintecesantias.Text = intereses_cesan.ToString();
                lblvacaciones.Text = vacaciones.ToString();
                lblprestaciones.Text = prestaciones.ToString();
                lblaportes.Text = aportes.ToString();

                if (txtnivel.Text == Convert.ToString(1))
                {
                    arp = (salario + total_extras) * 0.522 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(2))
                {
                    arp = (salario + total_extras) * 1.044 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(3))
                {
                    arp = (salario + total_extras) * 2.436 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(4))
                {

                    arp = (salario + total_extras) * 4.350 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else
                {
                    arp = (salario + total_extras) * 6.960 / 100;
                    lblarl5.Text = arp.ToString();
                }
                total_seguridad = salud8 + pension12 + arp;
                lbltotalseguridad.Text = total_seguridad.ToString();
            }
            else if (salario > 3511212 && salario < 14044848)
            {
                dias = Convert.ToInt32(txtdias.Text);
                dhed = Convert.ToInt32(txthed.Text);
                dhen = Convert.ToInt32(txthen.Text);
                dhedd = Convert.ToInt32(txthedd.Text);
                dhedn = Convert.ToInt32(txthedn.Text);
                dhrn = Convert.ToInt32(txthrn.Text);
                comisiones = Convert.ToInt32(txtcomisiones.Text);
                auxilio_transporte = Convert.ToInt32(txtauxilio.Text);
                nivel = Convert.ToInt32(txtnivel.Text);
                valor_hora = salario / 240;
                salario_dias = salario / 30 * dias;
                auxilio_dias = auxilio_transporte / 30 * dias;
                hed = 1.25 * valor_hora * dhed;
                hen = 1.75 * valor_hora * dhen;
                hedd = 2 * valor_hora * dhedd;
                hedn = 2.5 * valor_hora * dhedn;
                hrn = 1.35 * valor_hora * dhrn;
                total_extras = hed + hen + hedd + hedn + hrn + comisiones;
                aportes_salud = (salario + total_extras) * 4 / 100;
                aportes_pension = (salario + total_extras) * 4 / 100;
                salud8 = (salario + total_extras) * 8.5 / 100;
                pension12 = (salario + total_extras) * 12 / 100;
                sena = (salario + total_extras) * 2 / 100;
                caja_compensacion = (salario + total_extras) * 4 / 100;
                icbf = (salario + total_extras) * 3 / 100;
                aportes = sena + caja_compensacion + icbf;
                prima = (salario + total_extras) * 8.33 / 100;
                cesantias = (salario + total_extras) * 8.33 / 100;
                intereses_cesan = cesantias * 12 / 100;
                vacaciones = (salario + total_extras) * 4.17 / 100;
                prestaciones = prima + cesantias + intereses_cesan + vacaciones;
                total_devengado = total_extras + salario_dias;
                neto = total_devengado - (aportes_pension + aportes_salud);
                fdsp = salario * 1 / 100;
                lblhrn.Text = hrn.ToString();
                lblhed.Text = hed.ToString();
                lblhen.Text = hen.ToString();
                lblhedd.Text = hedd.ToString();
                lblhedn.Text = hedn.ToString();
                lbltotalextra.Text = total_extras.ToString();
                lblauxilio.Text = 0.ToString();
                lbltotaldeve.Text = total_devengado.ToString();
                lblsalud.Text = aportes_salud.ToString();
                lblpension.Text = aportes_pension.ToString();
                lblsueldo.Text = salario_dias.ToString();
                lblcomisiones.Text = comisiones.ToString();
                lblneto.Text = neto.ToString();
                lblsalud8.Text = salud8.ToString();
                lblpension12.Text = pension12.ToString();
                lblsena.Text = sena.ToString();
                lblcaja.Text = caja_compensacion.ToString();
                lblicbf.Text = icbf.ToString();
                lblprima.Text = prima.ToString();
                lblcesantias.Text = cesantias.ToString();
                lblintecesantias.Text = intereses_cesan.ToString();
                lblvacaciones.Text = vacaciones.ToString();
                lblprestaciones.Text = prestaciones.ToString();
                lblaportes.Text = aportes.ToString();
                lblfondo.Text = fdsp.ToString();

                if (txtnivel.Text == Convert.ToString(1))
                {
                    arp = (salario + total_extras) * 0.522 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(2))
                {
                    arp = (salario + total_extras) * 1.044 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(3))
                {
                    arp = (salario + total_extras) * 2.436 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(4))
                {

                    arp = (salario + total_extras) * 4.350 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else
                {
                    arp = (salario + total_extras) * 6.960 / 100;
                    lblarl5.Text = arp.ToString();
                }
                total_seguridad = salud8 + pension12 + arp;
                lbltotalseguridad.Text = total_seguridad.ToString();
            }
            else if (salario > 14922651 && salario < 15800454)
            {
                dias = Convert.ToInt32(txtdias.Text);
                dhed = Convert.ToInt32(txthed.Text);
                dhen = Convert.ToInt32(txthen.Text);
                dhedd = Convert.ToInt32(txthedd.Text);
                dhedn = Convert.ToInt32(txthedn.Text);
                dhrn = Convert.ToInt32(txthrn.Text);
                comisiones = Convert.ToInt32(txtcomisiones.Text);
                auxilio_transporte = Convert.ToInt32(txtauxilio.Text);
                nivel = Convert.ToInt32(txtnivel.Text);
                valor_hora = salario / 240;
                salario_dias = salario / 30 * dias;
                auxilio_dias = auxilio_transporte / 30 * dias;
                hed = 1.25 * valor_hora * dhed;
                hen = 1.75 * valor_hora * dhen;
                hedd = 2 * valor_hora * dhedd;
                hedn = 2.5 * valor_hora * dhedn;
                hrn = 1.35 * valor_hora * dhrn;
                total_extras = hed + hen + hedd + hedn + hrn + comisiones;
                aportes_salud = (salario + total_extras) * 4 / 100;
                aportes_pension = (salario + total_extras) * 4 / 100;
                salud8 = (salario + total_extras) * 8.5 / 100;
                pension12 = (salario + total_extras) * 12 / 100;
                sena = (salario + total_extras) * 2 / 100;
                caja_compensacion = (salario + total_extras) * 4 / 100;
                icbf = (salario + total_extras) * 3 / 100;
                aportes = sena + caja_compensacion + icbf;
                prima = (salario + total_extras) * 8.33 / 100;
                cesantias = (salario + total_extras) * 8.33 / 100;
                intereses_cesan = cesantias * 12 / 100;
                vacaciones = (salario + total_extras) * 4.17 / 100;
                prestaciones = prima + cesantias + intereses_cesan + vacaciones;
                total_devengado = total_extras + salario_dias;
                neto = total_devengado - (aportes_pension + aportes_salud);
                fdsp = salario * 1.4 / 100;
                lblhrn.Text = hrn.ToString();
                lblhed.Text = hed.ToString();
                lblhen.Text = hen.ToString();
                lblhedd.Text = hedd.ToString();
                lblhedn.Text = hedn.ToString();
                lbltotalextra.Text = total_extras.ToString();
                lblauxilio.Text = 0.ToString();
                lbltotaldeve.Text = total_devengado.ToString();
                lblsalud.Text = aportes_salud.ToString();
                lblpension.Text = aportes_pension.ToString();
                lblsueldo.Text = salario_dias.ToString();
                lblcomisiones.Text = comisiones.ToString();
                lblneto.Text = neto.ToString();
                lblsalud8.Text = salud8.ToString();
                lblpension12.Text = pension12.ToString();
                lblsena.Text = sena.ToString();
                lblcaja.Text = caja_compensacion.ToString();
                lblicbf.Text = icbf.ToString();
                lblprima.Text = prima.ToString();
                lblcesantias.Text = cesantias.ToString();
                lblintecesantias.Text = intereses_cesan.ToString();
                lblvacaciones.Text = vacaciones.ToString();
                lblprestaciones.Text = prestaciones.ToString();
                lblaportes.Text = aportes.ToString();
                lblfondo.Text = fdsp.ToString();

                if (txtnivel.Text == Convert.ToString(1))
                {
                    arp = (salario + total_extras) * 0.522 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(2))
                {
                    arp = (salario + total_extras) * 1.044 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(3))
                {
                    arp = (salario + total_extras) * 2.436 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(4))
                {

                    arp = (salario + total_extras) * 4.350 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else
                {
                    arp = (salario + total_extras) * 6.960 / 100;
                    lblarl5.Text = arp.ToString();
                }
                total_seguridad = salud8 + pension12 + arp;
                lbltotalseguridad.Text = total_seguridad.ToString();
            }
            else if (salario > 15800454 && salario < 16678257)
            {
                dias = Convert.ToInt32(txtdias.Text);
                dhed = Convert.ToInt32(txthed.Text);
                dhen = Convert.ToInt32(txthen.Text);
                dhedd = Convert.ToInt32(txthedd.Text);
                dhedn = Convert.ToInt32(txthedn.Text);
                dhrn = Convert.ToInt32(txthrn.Text);
                comisiones = Convert.ToInt32(txtcomisiones.Text);
                auxilio_transporte = Convert.ToInt32(txtauxilio.Text);
                nivel = Convert.ToInt32(txtnivel.Text);
                valor_hora = salario / 240;
                salario_dias = salario / 30 * dias;
                auxilio_dias = auxilio_transporte / 30 * dias;
                hed = 1.25 * valor_hora * dhed;
                hen = 1.75 * valor_hora * dhen;
                hedd = 2 * valor_hora * dhedd;
                hedn = 2.5 * valor_hora * dhedn;
                hrn = 1.35 * valor_hora * dhrn;
                total_extras = hed + hen + hedd + hedn + hrn + comisiones;
                aportes_salud = (salario + total_extras) * 4 / 100;
                aportes_pension = (salario + total_extras) * 4 / 100;
                salud8 = (salario + total_extras) * 8.5 / 100;
                pension12 = (salario + total_extras) * 12 / 100;
                sena = (salario + total_extras) * 2 / 100;
                caja_compensacion = (salario + total_extras) * 4 / 100;
                icbf = (salario + total_extras) * 3 / 100;
                aportes = sena + caja_compensacion + icbf;
                prima = (salario + total_extras) * 8.33 / 100;
                cesantias = (salario + total_extras) * 8.33 / 100;
                intereses_cesan = cesantias * 12 / 100;
                vacaciones = (salario + total_extras) * 4.17 / 100;
                prestaciones = prima + cesantias + intereses_cesan + vacaciones;
                total_devengado = total_extras + salario_dias;
                neto = total_devengado - (aportes_pension + aportes_salud);
                fdsp = salario * 1.6 / 100;
                lblhrn.Text = hrn.ToString();
                lblhed.Text = hed.ToString();
                lblhen.Text = hen.ToString();
                lblhedd.Text = hedd.ToString();
                lblhedn.Text = hedn.ToString();
                lbltotalextra.Text = total_extras.ToString();
                lblauxilio.Text = 0.ToString();
                lbltotaldeve.Text = total_devengado.ToString();
                lblsalud.Text = aportes_salud.ToString();
                lblpension.Text = aportes_pension.ToString();
                lblsueldo.Text = salario_dias.ToString();
                lblcomisiones.Text = comisiones.ToString();
                lblneto.Text = neto.ToString();
                lblsalud8.Text = salud8.ToString();
                lblpension12.Text = pension12.ToString();
                lblsena.Text = sena.ToString();
                lblcaja.Text = caja_compensacion.ToString();
                lblicbf.Text = icbf.ToString();
                lblprima.Text = prima.ToString();
                lblcesantias.Text = cesantias.ToString();
                lblintecesantias.Text = intereses_cesan.ToString();
                lblvacaciones.Text = vacaciones.ToString();
                lblprestaciones.Text = prestaciones.ToString();
                lblaportes.Text = aportes.ToString();
                lblfondo.Text = fdsp.ToString();

                if (txtnivel.Text == Convert.ToString(1))
                {
                    arp = (salario + total_extras) * 0.522 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(2))
                {
                    arp = (salario + total_extras) * 1.044 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(3))
                {
                    arp = (salario + total_extras) * 2.436 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(4))
                {

                    arp = (salario + total_extras) * 4.350 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else
                {
                    arp = (salario + total_extras) * 6.960 / 100;
                    lblarl5.Text = arp.ToString();
                }
                total_seguridad = salud8 + pension12 + arp;
                lbltotalseguridad.Text = total_seguridad.ToString();
            }
            else if (salario > 16678257 && salario < 17556060)
            {
                dias = Convert.ToInt32(txtdias.Text);
                dhed = Convert.ToInt32(txthed.Text);
                dhen = Convert.ToInt32(txthen.Text);
                dhedd = Convert.ToInt32(txthedd.Text);
                dhedn = Convert.ToInt32(txthedn.Text);
                dhrn = Convert.ToInt32(txthrn.Text);
                comisiones = Convert.ToInt32(txtcomisiones.Text);
                auxilio_transporte = Convert.ToInt32(txtauxilio.Text);
                nivel = Convert.ToInt32(txtnivel.Text);
                valor_hora = salario / 240;
                salario_dias = salario / 30 * dias;
                auxilio_dias = auxilio_transporte / 30 * dias;
                hed = 1.25 * valor_hora * dhed;
                hen = 1.75 * valor_hora * dhen;
                hedd = 2 * valor_hora * dhedd;
                hedn = 2.5 * valor_hora * dhedn;
                hrn = 1.35 * valor_hora * dhrn;
                total_extras = hed + hen + hedd + hedn + hrn + comisiones;
                aportes_salud = (salario + total_extras) * 4 / 100;
                aportes_pension = (salario + total_extras) * 4 / 100;
                salud8 = (salario + total_extras) * 8.5 / 100;
                pension12 = (salario + total_extras) * 12 / 100;
                sena = (salario + total_extras) * 2 / 100;
                caja_compensacion = (salario + total_extras) * 4 / 100;
                icbf = (salario + total_extras) * 3 / 100;
                aportes = sena + caja_compensacion + icbf;
                prima = (salario + total_extras) * 8.33 / 100;
                cesantias = (salario + total_extras) * 8.33 / 100;
                intereses_cesan = cesantias * 12 / 100;
                vacaciones = (salario + total_extras) * 4.17 / 100;
                prestaciones = prima + cesantias + intereses_cesan + vacaciones;
                total_devengado = total_extras + salario_dias;
                neto = total_devengado - (aportes_pension + aportes_salud);
                fdsp = salario * 1.8 / 100;
                lblhrn.Text = hrn.ToString();
                lblhed.Text = hed.ToString();
                lblhen.Text = hen.ToString();
                lblhedd.Text = hedd.ToString();
                lblhedn.Text = hedn.ToString();
                lbltotalextra.Text = total_extras.ToString();
                lblauxilio.Text = 0.ToString();
                lbltotaldeve.Text = total_devengado.ToString();
                lblsalud.Text = aportes_salud.ToString();
                lblpension.Text = aportes_pension.ToString();
                lblsueldo.Text = salario_dias.ToString();
                lblcomisiones.Text = comisiones.ToString();
                lblneto.Text = neto.ToString();
                lblsalud8.Text = salud8.ToString();
                lblpension12.Text = pension12.ToString();
                lblsena.Text = sena.ToString();
                lblcaja.Text = caja_compensacion.ToString();
                lblicbf.Text = icbf.ToString();
                lblprima.Text = prima.ToString();
                lblcesantias.Text = cesantias.ToString();
                lblintecesantias.Text = intereses_cesan.ToString();
                lblvacaciones.Text = vacaciones.ToString();
                lblprestaciones.Text = prestaciones.ToString();
                lblaportes.Text = aportes.ToString();
                lblfondo.Text = fdsp.ToString();

                if (txtnivel.Text == Convert.ToString(1))
                {
                    arp = (salario + total_extras) * 0.522 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(2))
                {
                    arp = (salario + total_extras) * 1.044 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(3))
                {
                    arp = (salario + total_extras) * 2.436 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(4))
                {

                    arp = (salario + total_extras) * 4.350 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else
                {
                    arp = (salario + total_extras) * 6.960 / 100;
                    lblarl5.Text = arp.ToString();
                }
                total_seguridad = salud8 + pension12 + arp;
                lbltotalseguridad.Text = total_seguridad.ToString();
            }
            else if (salario > 17556060)
            {
                dias = Convert.ToInt32(txtdias.Text);
                dhed = Convert.ToInt32(txthed.Text);
                dhen = Convert.ToInt32(txthen.Text);
                dhedd = Convert.ToInt32(txthedd.Text);
                dhedn = Convert.ToInt32(txthedn.Text);
                dhrn = Convert.ToInt32(txthrn.Text);
                comisiones = Convert.ToInt32(txtcomisiones.Text);
                auxilio_transporte = Convert.ToInt32(txtauxilio.Text);
                nivel = Convert.ToInt32(txtnivel.Text);
                valor_hora = salario / 240;
                salario_dias = salario / 30 * dias;
                auxilio_dias = auxilio_transporte / 30 * dias;
                hed = 1.25 * valor_hora * dhed;
                hen = 1.75 * valor_hora * dhen;
                hedd = 2 * valor_hora * dhedd;
                hedn = 2.5 * valor_hora * dhedn;
                hrn = 1.35 * valor_hora * dhrn;
                total_extras = hed + hen + hedd + hedn + hrn + comisiones;
                aportes_salud = (salario + total_extras) * 4 / 100;
                aportes_pension = (salario + total_extras) * 4 / 100;
                salud8 = (salario + total_extras) * 8.5 / 100;
                pension12 = (salario + total_extras) * 12 / 100;
                sena = (salario + total_extras) * 2 / 100;
                caja_compensacion = (salario + total_extras) * 4 / 100;
                icbf = (salario + total_extras) * 3 / 100;
                aportes = sena + caja_compensacion + icbf;
                prima = (salario + total_extras) * 8.33 / 100;
                cesantias = (salario + total_extras) * 8.33 / 100;
                intereses_cesan = cesantias * 12 / 100;
                vacaciones = (salario + total_extras) * 4.17 / 100;
                prestaciones = prima + cesantias + intereses_cesan + vacaciones;
                total_devengado = total_extras + salario_dias;
                neto = total_devengado - (aportes_pension + aportes_salud);
                fdsp = salario * 2 / 100;
                lblhrn.Text = hrn.ToString();
                lblhed.Text = hed.ToString();
                lblhen.Text = hen.ToString();
                lblhedd.Text = hedd.ToString();
                lblhedn.Text = hedn.ToString();
                lbltotalextra.Text = total_extras.ToString();
                lblauxilio.Text = 0.ToString();
                lbltotaldeve.Text = total_devengado.ToString();
                lblsalud.Text = aportes_salud.ToString();
                lblpension.Text = aportes_pension.ToString();
                lblsueldo.Text = salario_dias.ToString();
                lblcomisiones.Text = comisiones.ToString();
                lblneto.Text = neto.ToString();
                lblsalud8.Text = salud8.ToString();
                lblpension12.Text = pension12.ToString();
                lblsena.Text = sena.ToString();
                lblcaja.Text = caja_compensacion.ToString();
                lblicbf.Text = icbf.ToString();
                lblprima.Text = prima.ToString();
                lblcesantias.Text = cesantias.ToString();
                lblintecesantias.Text = intereses_cesan.ToString();
                lblvacaciones.Text = vacaciones.ToString();
                lblprestaciones.Text = prestaciones.ToString();
                lblaportes.Text = aportes.ToString();
                lblfondo.Text = fdsp.ToString();

                if (txtnivel.Text == Convert.ToString(1))
                {
                    arp = (salario + total_extras) * 0.522 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(2))
                {
                    arp = (salario + total_extras) * 1.044 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(3))
                {
                    arp = (salario + total_extras) * 2.436 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else if (txtnivel.Text == Convert.ToString(4))
                {

                    arp = (salario + total_extras) * 4.350 / 100;
                    lblarl5.Text = arp.ToString();
                }
                else
                {
                    arp = (salario + total_extras) * 6.960 / 100;
                    lblarl5.Text = arp.ToString();
                }
                total_seguridad = salud8 + pension12 + arp;
                lbltotalseguridad.Text = total_seguridad.ToString();
            }
        }

        private void txtcomisiones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtdias.Focus();
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmcompropago comprobante = new frmcompropago();
            comprobante.lblnombreempleado.Text = txtnombre2.Text +" "+ txtapellidos.Text;
            comprobante.lblcedula.Text = txtidentificacion.Text;
            comprobante.lblsueldo.Text = txtdias.Text;
            comprobante.lbldireccion.Text = txtdireccion.Text;
            comprobante.lblcuenta.Text = txtcuenta.Text;
            comprobante.lblsalariocom.Text = txtsalario.Text;
            comprobante.lblauxiliotp.Text = txtdias.Text;
            comprobante.lblsueldopag.Text = lblsueldo.Text;
            comprobante.lblauxiliopag.Text = lblauxilio.Text;
            comprobante.lbltotal.Text = lbltotaldeve.Text;
            comprobante.lblsaludcom.Text = lblsalud.Text;
            comprobante.lblpensioncom.Text = lblpension.Text;
            int totaldedu = Convert.ToInt32(lblsalud.Text) + Convert.ToInt32(lblpension.Text);
            comprobante.lbltotaldedu.Text = totaldedu.ToString();
            comprobante.lbltotalapagar.Text = lblneto.Text;
            comprobante.Show();


        }

        private void txtidentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToInt32(Keys.Enter))
            {
                txtdireccion.Focus();
                e.Handled = true;
            }
        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToInt32(Keys.Enter))
            {
                txtcuenta.Focus();
                e.Handled = true;
            }
        }

        private void txtcuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToInt32(Keys.Enter))
            {
                txtsalario.Focus();
                e.Handled = true;
            }
        }
    }
}
