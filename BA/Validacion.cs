using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BA
{
    public class Validacion
    {
       public bool SoloDecimal(TextBox txtPago)
        {
            try
            {
                decimal d = Convert.ToDecimal(txtPago.Text);
                return true; 
            }
            catch(Exception)
            {
                txtPago.Text = "0";
                txtPago.Select(0, txtPago.Text.Length);
                return false;
            }
        }
        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar)) //teclas numericas 
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))//tecla de control como la de borrar 
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))//tecla de espacio no permitida  
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
