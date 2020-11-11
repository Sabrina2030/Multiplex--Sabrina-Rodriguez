using BA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FE
{
    public partial class frmAbonados : Form
    {
        #region Propiedades
        //inicializacion de objetos
        cRegistro registro = new cRegistro();
        Validacion validar = new Validacion();
        Abonados abonados = new Abonados();


        //variables
        int n = 0;
        #endregion

        #region Constructor
        public frmAbonados()
        {
            InitializeComponent();
            CrearTabla();
            
        }
        #endregion

        #region Eventos
        //eventos

        //Validaciones de textbox
        private void txtPago_KeyUp(object sender, KeyEventArgs e)
        {
            validar.SoloDecimal((TextBox)sender);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtNumeroAb_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        //Botones
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
           //Validar datos

           if (txtNumeroAb.Text == "" || txtNombre.Text == "" || txtDomicilio.Text == "" || txtTelefono.Text == ""
                || cbSector.Text == "" || txtPlan.Text == "" || cbMes.Text == "" || txtPago.Text == "")
            {
                MessageBox.Show("Faltan datos de completar");
                txtNumeroAb.Focus();
            }
            else
            {
                registro.Numero = txtNumeroAb.Text;
                registro.Nombre = txtNombre.Text;
                registro.Domicilio = txtDomicilio.Text;
                registro.Sector = cbSector.Text;
                registro.Telefono = txtTelefono.Text;
                registro.Plan = txtPlan.Text;
                registro.Mes = cbMes.Text; 
                registro.Pago = decimal.Parse(txtPago.Text);

                MessageBox.Show("Se confirmaron los datos correctamente");

            }

            registro.ArregloDePago();

            CrearRegistro();
            Limpiar();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            abonados.GuardarTabla(); 
            MessageBox.Show("Se guardaron los datos correctamente");
            Limpiar();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            abonados.VerTabla();
            dataAbonados.DataSource = abonados.Tabla;

            for (int i = 0; i < abonados.Tabla.Rows.Count; i++)
            {
                registro.Pago = System.Convert.ToDecimal(abonados.Tabla.Rows[i]["Pago"].ToString());
                registro.ArregloDePago();
            }

        }

        //seleccionar celda
        private void dataAbonados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            if(n != -1) 
            {
                _ = (string)dataAbonados.Rows[n].Cells[1].Value;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dataAbonados.Rows.RemoveAt(n);
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
           registro.CalculoPagos(); 
           texTotalMes.Text = registro.Total.ToString();

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmGastos f = new frmGastos();
            f.txtCobranzas.Text = texTotalMes.Text;
            this.Hide();
            f.ShowDialog();
        }

        //Buscador

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            abonados.Tabla.DefaultView.RowFilter = $"Nombre LIKE '{txtBuscador.Text}%'";
        }
        #endregion

        #region Metodos
        //Metodos
        private void Limpiar()
        {
            txtNumeroAb.Text = "";
            txtNombre.Text = "";
            txtDomicilio.Text = "";
            txtTelefono.Text = "";
            txtPlan.Text = "";
            txtPago.Text = "0";
            texTotalMes.Text = "0";
            cbSector.Text = "";
            cbMes.Text = "";
                          
        }

        public void CrearTabla()
        {

          dataAbonados.DataSource = abonados.Tabla;
        }
        public void CrearRegistro()
        {
            abonados.CrearRegistro(registro.Numero,
                                   registro.Nombre,
                                   registro.Domicilio,
                                   registro.Telefono,
                                   registro.Sector,
                                   registro.Plan,
                                   registro.Mes,
                                   registro.Pago); 

        }



        #endregion

    }

}
