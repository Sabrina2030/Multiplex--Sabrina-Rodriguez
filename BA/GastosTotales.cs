using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BA
{
    public class GastosTotales
    {
        #region Propiedades
        public DateTime Fecha;

        public string Proveedores = "";
        public decimal Monto = 0;
        public decimal TotalG = 0;
        public decimal TotalCobranzas = 0;
        public decimal TotalNeto = 0;

        public string[] ProvGast = new string[10];
        private int indice = 0;

        public decimal[] SumaTotal = new decimal[10];
        private int ind = 0;

        #endregion

        #region Constructor
        public GastosTotales()
        {
            Fecha = DateTime.Now;
         
        }
        #endregion


        #region Metodos
        //Metodos
        public string Renglones()
        {
            return Proveedores + " - " + Monto.ToString("#,##0.00");
        }
        
     
        public void AddGasto()
        {
            ProvGast[indice] = Renglones();
            indice = indice + 1;
          
        }

        public string MostrarTodo()
        {
            string Lista = "";

            for (int i = 0; i < indice; i++)
            {
                Lista = Lista + ProvGast[i] + "\r\n";
            }

            return Lista;

        }


        public void AddMonto()
        {
            SumaTotal[ind] = Monto;
            ind = ind + 1;
        }
        public void SumaTotales()
        {
            decimal Suma= 0; 
            for (int i = 0; i < ind; i++)
            {
                Suma = Suma + SumaTotal[i];
            }
            TotalG = Suma;
        }

        public void SumaNeto()
        {
            TotalNeto = TotalCobranzas - TotalG;
        }
        #endregion
    }
}
