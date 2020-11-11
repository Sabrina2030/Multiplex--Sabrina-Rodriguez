using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BA
{
    public class Reclamos 
    {
        public DataTable TablaR = new DataTable();


        public string Numero = "";
        public string Nombre = "";
        public string Direccion = "";
        public string Telefono = "";
        public string MotivoContacto = "";
        public string Detalle = "";
        public string Estado = "";


        public Reclamos()
        {
            TablaR.TableName = "Lista";
            TablaR.Columns.Add("Numero Abonado", typeof(string));
            TablaR.Columns.Add("Nombre Abonado", typeof(string));
            TablaR.Columns.Add("Direccion", typeof(string));
            TablaR.Columns.Add("Telefono", typeof(string));
            TablaR.Columns.Add("Motivo de contacto", typeof(string));
            TablaR.Columns.Add("Detalle", typeof(string));
            TablaR.Columns.Add("Estado", typeof(string));
        }

        public void InsertReclamo()
        {
            TablaR.Rows.Add();
            TablaR.Rows[TablaR.Rows.Count - 1]["NUMERO ABONADO"] = Numero;
            TablaR.Rows[TablaR.Rows.Count - 1]["NOMBRE ABONADO"] = Nombre;
            TablaR.Rows[TablaR.Rows.Count - 1]["DIRECCION"] = Direccion;
            TablaR.Rows[TablaR.Rows.Count - 1]["TELEFONO"] = Telefono;
            TablaR.Rows[TablaR.Rows.Count - 1]["MOTIVO DE CONTACTO"] = MotivoContacto;
            TablaR.Rows[TablaR.Rows.Count - 1]["DETALLE"] = Detalle;
            TablaR.Rows[TablaR.Rows.Count - 1]["ESTADO"] = Estado;
        }

        public void GuardarTabla()
        {
            TablaR.WriteXml(@"lista.xml");
        }

        public void VerTabla()
        {
            TablaR.ReadXml(@"lista.xml");
        }
    }
}
