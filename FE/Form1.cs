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
    public partial class frmenu : Form
    {
        public frmenu()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\images.PNG");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void abonadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbonados Nuevo = new frmAbonados();
            Nuevo.MdiParent = this;
            Nuevo.Show();
        }

        private void gastosYCobranzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGastos Nuevo = new frmGastos();
            Nuevo.MdiParent = this;
            Nuevo.Show();
        }

        private void reclamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReclamos Nuevo = new frmReclamos();
            Nuevo.MdiParent = this;
            Nuevo.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por Sabrina Rodriguez/sabrinarodriguez.s@gmail.com");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
