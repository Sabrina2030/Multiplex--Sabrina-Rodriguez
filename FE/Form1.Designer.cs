namespace FE
{
    partial class frmenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abonadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosYCobranzasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reclamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abonadosToolStripMenuItem,
            this.gastosYCobranzasToolStripMenuItem,
            this.reclamosToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abonadosToolStripMenuItem
            // 
            this.abonadosToolStripMenuItem.Name = "abonadosToolStripMenuItem";
            this.abonadosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.abonadosToolStripMenuItem.Text = "Abonados";
            this.abonadosToolStripMenuItem.Click += new System.EventHandler(this.abonadosToolStripMenuItem_Click);
            // 
            // gastosYCobranzasToolStripMenuItem
            // 
            this.gastosYCobranzasToolStripMenuItem.Name = "gastosYCobranzasToolStripMenuItem";
            this.gastosYCobranzasToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.gastosYCobranzasToolStripMenuItem.Text = "Gastos y Cobranzas ";
            this.gastosYCobranzasToolStripMenuItem.Click += new System.EventHandler(this.gastosYCobranzasToolStripMenuItem_Click);
            // 
            // reclamosToolStripMenuItem
            // 
            this.reclamosToolStripMenuItem.Name = "reclamosToolStripMenuItem";
            this.reclamosToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.reclamosToolStripMenuItem.Text = "Reclamos";
            this.reclamosToolStripMenuItem.Click += new System.EventHandler(this.reclamosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FE.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmenu";
            this.Text = "Multiplex- Menu principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abonadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosYCobranzasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reclamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}