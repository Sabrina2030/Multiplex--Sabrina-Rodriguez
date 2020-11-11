using BA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FE
{
    public partial class frmGastos : Form 
    {
        #region Propiedades
        //instanciar ojbetos
        GastosTotales GastosObj = new GastosTotales();
        GastosGanancias gastos = new GastosGanancias();
        Validacion Validar = new Validacion();
       
        //variable para el metodo de borrar 
        int n = 0;

        #endregion
        #region Constructor
        public frmGastos()
        {
            InitializeComponent();

            CrearTabla2();

        }
        #endregion

        #region Eventos

        //Eventos

        private void txtTotalGastos_KeyUp(object sender, KeyEventArgs e)
        {
            Validar.SoloDecimal((TextBox)sender);
        }
        private void btnCofirmar_Click(object sender, EventArgs e)
        {
            try
            {
                GastosObj.Proveedores = txtProveedores.Text;
                GastosObj.Monto = System.Convert.ToDecimal(txtMonto.Text);
                GastosObj.TotalCobranzas = System.Convert.ToDecimal(txtCobranzas.Text);
            }
            catch
            {
                MessageBox.Show("Faltan datos de completar");
                txtProveedores.Focus();
            }

            GastosObj.AddMonto();
            GastosObj.AddGasto();
                        
            lblLista.Text = GastosObj.MostrarTodo();

            txtFecha.Text = GastosObj.Fecha.ToString("dd/MM/yyyy");

        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            LimpiarTextos();
            txtProveedores.Focus();

        }

        private void btnGastosTotales_Click(object sender, EventArgs e)
        {
            GastosObj.SumaTotales();
            txtTotalGastos.Text = GastosObj.TotalG.ToString("#,##0.00");
        }

        private void btnIngresosNetos_Click(object sender, EventArgs e)
        {
            txtFecha.Text = GastosObj.Fecha.ToString("dd/MM/yyyy");
            GastosObj.SumaNeto();
            txtTotal.Text = GastosObj.TotalNeto.ToString("#,##0.00");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            gastos.CrearRegistro(GastosObj.Fecha, GastosObj.TotalG, GastosObj.TotalCobranzas, GastosObj.TotalNeto);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            gastos.GuardarTabla();
            MessageBox.Show("Se guardaron los datos correctamente");

        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            gastos.VerTabla();
            dataGastos.DataSource = gastos.Tabla2;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dataGastos.Rows.RemoveAt(n);
            }
        }

        private void dataGastos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            if (n != -1)
            {
                _ = (string)dataGastos.Rows[n].Cells[1].Value;
            }
        }
        #endregion

        #region Metodos
        //Metodos
        private void LimpiarTextos()
        {
            txtProveedores.Text = "";
            txtMonto.Text = "0";
            txtTotalGastos.Text = "0";
            txtTotal.Text = "0";
            txtFecha.Text = "";
           
        }

        public void CrearTabla2()
        {
                   
            dataGastos.DataSource = gastos.Tabla2;
        }

        #endregion

    }
}
