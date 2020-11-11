using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA
{
    public class GastosGanancias
    {
        public DataTable Tabla2 = new DataTable();


        public GastosGanancias()
        {
            Tabla2.TableName = "Lista";
            Tabla2.Columns.Add("Fecha", typeof(DateTime));
            Tabla2.Columns.Add("Gastos Totales", typeof(decimal));
            Tabla2.Columns.Add("Ingresos Brutos", typeof(decimal));
            Tabla2.Columns.Add("Ingresos Netos", typeof(decimal));
        }

        public void CrearRegistro(DateTime Fecha, decimal TotalGastos, decimal Cobranzas, decimal TotalNeto)
        {
            Tabla2.Rows.Add();
            Tabla2.Rows[Tabla2.Rows.Count - 1]["Fecha"] = Fecha;
            Tabla2.Rows[Tabla2.Rows.Count - 1]["Gastos Totales"] = TotalGastos;
            Tabla2.Rows[Tabla2.Rows.Count - 1]["Ingresos Brutos"] = Cobranzas;
            Tabla2.Rows[Tabla2.Rows.Count - 1]["Ingresos Netos"] = TotalNeto;

        }

        public void GuardarTabla()
        {
            Tabla2.WriteXml(@"lista.xml");
        }

        public void VerTabla()
        {
            Tabla2.ReadXml(@"lista.xml");
        }
    }
}
