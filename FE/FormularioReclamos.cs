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
    public partial class frmReclamos : Form
    {
        //Inicializacion de objetos
        Reclamos ReclamoObj = new Reclamos();

        //variable
        int poc;
        //Constructor
        public frmReclamos()
        {
            InitializeComponent();
            CrearTabla();
        }

        //Eventos
        private void btnReclamo_Click(object sender, EventArgs e)
        {
            try
            {
                ReclamoObj.Numero = txtNumeroAB.Text;
                ReclamoObj.Nombre = txtNombre.Text;
                ReclamoObj.Direccion = txtDireccion.Text;
                ReclamoObj.Telefono = txtTelefono.Text;

                if (rbSolicitud.Checked)
                {
                    ReclamoObj.MotivoContacto = "Solicitud";
                }
                if (rbConsulta.Checked)
                {
                    ReclamoObj.MotivoContacto = "Consulta";
                }
                if (rbReclamo.Checked)
                {
                    ReclamoObj.MotivoContacto = "Reclamo";
                }

                ReclamoObj.Detalle = txtDetalle.Text;
                ReclamoObj.Estado = cbEstado.Text;
               
                ReclamoObj.InsertReclamo();

            }
            catch
            {
                MessageBox.Show("Faltan datos de completar");
                txtNumeroAB.Focus();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            ReclamoObj.GuardarTabla();
            MessageBox.Show("Se guardaron los datos correctamente");
        }

        private void btVerReclamos_Click(object sender, EventArgs e)
        {
            ReclamoObj.VerTabla();
            dtgReclamos.DataSource = ReclamoObj.TablaR;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            string p, r, v, x, z, f;

            p = txtNumeroAB.Text;
            r = txtNombre.Text;
            v = txtDireccion.Text;
            x = txtTelefono.Text;
            z = txtDetalle.Text;
            f = cbEstado.Text;

            dtgReclamos[0, poc].Value = txtNumeroAB.Text;
            dtgReclamos[1, poc].Value = txtNombre.Text;
            dtgReclamos[2, poc].Value = txtDireccion.Text;
            dtgReclamos[3, poc].Value = txtTelefono.Text;
            dtgReclamos[5, poc].Value = txtDetalle.Text;
            dtgReclamos[6, poc].Value = cbEstado.Text;

            Limpiar();

        }

        private void dtgReclamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dtgReclamos.CurrentRow.Index;
            txtNumeroAB.Text = dtgReclamos[0, poc].Value.ToString();
            txtNombre.Text = dtgReclamos[1, poc].Value.ToString();
            txtDireccion.Text = dtgReclamos[2, poc].Value.ToString();
            txtTelefono.Text = dtgReclamos[3, poc].Value.ToString();
            txtDetalle.Text = dtgReclamos[5, poc].Value.ToString();
            cbEstado.Text = dtgReclamos[6, poc].Value.ToString();

            btnCambiar.Enabled = true;
        }

        //Metodos
        public void CrearTabla()
        {

            dtgReclamos.DataSource = ReclamoObj.TablaR;

         }

        public void Limpiar()
        {
            btnCambiar.Enabled = false;
            txtNumeroAB.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtDetalle.Text = "";
            cbEstado.Text = "";
        }

    }
}
 