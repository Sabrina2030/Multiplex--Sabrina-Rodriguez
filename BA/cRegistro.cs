using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BA
{

    public class cRegistro
    {
        #region Propiedades

        //propiedades de la clase

        public string Numero = "";
        public string Nombre = "";
        public string Domicilio = "";
        public string Telefono = "";
        public string Sector = "";
        public string Plan = "";
        public string Mes = "";
        public decimal Pago = 0;
        public decimal Total = 0;


        public decimal[] Pagos = new decimal[100];
        public int Indice = 0;
        #endregion

        #region Metodos

        //Metodos
        public void ArregloDePago()
        {
            Pagos[Indice] = Pago;
            Indice = Indice + 1;
        }
        public void CalculoPagos()
        {
            decimal SumaTotal = 0;

            for (int i=0; i< Indice; i++)
            {
                             
               SumaTotal = SumaTotal + Pagos[i];
                
            }
            Total = SumaTotal; 
        }
        #endregion
    }
}        
     
