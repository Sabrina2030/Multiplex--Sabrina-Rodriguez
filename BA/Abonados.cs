using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA
{
    public class Abonados 
    {
        public DataTable Tabla = new DataTable(); 


        public Abonados()
        {
            Tabla.TableName = "Lista";
            Tabla.Columns.Add("Telefono", typeof(string));
            Tabla.Columns.Add("Sector", typeof(string));
            Tabla.Columns.Add("Plan", typeof(string));
            Tabla.Columns.Add("Mes", typeof(string));
            Tabla.Columns.Add("Pago", typeof(decimal));
            Tabla.Columns.Add("Numero", typeof(string));
            Tabla.Columns.Add("Nombre", typeof(string));
            Tabla.Columns.Add("Domicilio", typeof(string));
        }

        public void CrearRegistro(string Numero,
                                  string Nombre,
                                  string Domicilio,
                                  string Telefono,
                                  string Sector,
                                  string Plan,
                                  string Mes,
                                  decimal Pago)
        {

            Tabla.Rows.Add();
            Tabla.Rows[Tabla.Rows.Count - 1]["Numero"] = Numero;
            Tabla.Rows[Tabla.Rows.Count - 1]["Nombre"] = Nombre;
            Tabla.Rows[Tabla.Rows.Count - 1]["Domicilio"] = Domicilio;
            Tabla.Rows[Tabla.Rows.Count - 1]["Telefono"] = Telefono;
            Tabla.Rows[Tabla.Rows.Count - 1]["Sector"] = Sector;
            Tabla.Rows[Tabla.Rows.Count - 1]["Plan"] = Plan;
            Tabla.Rows[Tabla.Rows.Count - 1]["Mes"] = Mes;
            Tabla.Rows[Tabla.Rows.Count - 1]["Pago"] = Pago;

        }

        public void GuardarTabla()
        {
            Tabla.WriteXml(@"lista.xml");
        }

        public void VerTabla()
        {
            Tabla.ReadXml(@"lista.xml");
        }

    }
}
