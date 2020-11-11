namespace FE
{
    partial class frmAbonados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbonados));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.lblNumAb = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNumeroAb = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblSector = new System.Windows.Forms.Label();
            this.cbSector = new System.Windows.Forms.ComboBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.dataAbonados = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.lblTotalMes = new System.Windows.Forms.Label();
            this.texTotalMes = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataAbonados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Silver;
            this.btnGuardar.Location = new System.Drawing.Point(688, 44);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar Registro";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.Silver;
            this.btnVer.Location = new System.Drawing.Point(688, 77);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(100, 28);
            this.btnVer.TabIndex = 3;
            this.btnVer.Text = "Ver Abonados";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // lblNumAb
            // 
            this.lblNumAb.AutoSize = true;
            this.lblNumAb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNumAb.Location = new System.Drawing.Point(22, 22);
            this.lblNumAb.Name = "lblNumAb";
            this.lblNumAb.Size = new System.Drawing.Size(90, 13);
            this.lblNumAb.TabIndex = 5;
            this.lblNumAb.Text = "Numero Abonado";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNombre.Location = new System.Drawing.Point(21, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(91, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre y apellido";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDomicilio.Location = new System.Drawing.Point(21, 87);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 7;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTelefono.Location = new System.Drawing.Point(22, 118);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtNumeroAb
            // 
            this.txtNumeroAb.Location = new System.Drawing.Point(119, 19);
            this.txtNumeroAb.Name = "txtNumeroAb";
            this.txtNumeroAb.Size = new System.Drawing.Size(73, 20);
            this.txtNumeroAb.TabIndex = 9;
            this.txtNumeroAb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroAb_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(127, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(119, 87);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(127, 20);
            this.txtDomicilio.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(119, 118);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(127, 20);
            this.txtTelefono.TabIndex = 12;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSector.Location = new System.Drawing.Point(263, 90);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(38, 13);
            this.lblSector.TabIndex = 13;
            this.lblSector.Text = "Sector";
            // 
            // cbSector
            // 
            this.cbSector.FormattingEnabled = true;
            this.cbSector.Items.AddRange(new object[] {
            "Indivuduales",
            "Torres Marques",
            "Torres Alamos"});
            this.cbSector.Location = new System.Drawing.Point(307, 84);
            this.cbSector.Name = "cbSector";
            this.cbSector.Size = new System.Drawing.Size(90, 21);
            this.cbSector.TabIndex = 14;
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPlan.Location = new System.Drawing.Point(437, 17);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(28, 13);
            this.lblPlan.TabIndex = 15;
            this.lblPlan.Text = "Plan";
            // 
            // txtPlan
            // 
            this.txtPlan.Location = new System.Drawing.Point(550, 12);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(100, 20);
            this.txtPlan.TabIndex = 16;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMes.Location = new System.Drawing.Point(438, 52);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 13);
            this.lblMes.TabIndex = 17;
            this.lblMes.Text = "Mes";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPago.Location = new System.Drawing.Point(438, 87);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(82, 13);
            this.lblPago.TabIndex = 18;
            this.lblPago.Text = "Pago Realizado";
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Nobiembre",
            "Diciembre"});
            this.cbMes.Location = new System.Drawing.Point(550, 44);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(100, 21);
            this.cbMes.TabIndex = 21;
            // 
            // dataAbonados
            // 
            this.dataAbonados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataAbonados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAbonados.GridColor = System.Drawing.Color.Teal;
            this.dataAbonados.Location = new System.Drawing.Point(12, 191);
            this.dataAbonados.Name = "dataAbonados";
            this.dataAbonados.Size = new System.Drawing.Size(776, 232);
            this.dataAbonados.TabIndex = 4;
            this.dataAbonados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAbonados_CellClick);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Silver;
            this.btnBorrar.Location = new System.Drawing.Point(688, 111);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 27);
            this.btnBorrar.TabIndex = 22;
            this.btnBorrar.Text = "Borrar Registro";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.Silver;
            this.btnTotal.Location = new System.Drawing.Point(526, 432);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(136, 28);
            this.btnTotal.TabIndex = 24;
            this.btnTotal.Text = "Calcular Total del Mes";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Silver;
            this.btnConfirmar.Location = new System.Drawing.Point(688, 12);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 27);
            this.btnConfirmar.TabIndex = 25;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(550, 83);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(100, 20);
            this.txtPago.TabIndex = 26;
            // 
            // lblTotalMes
            // 
            this.lblTotalMes.AutoSize = true;
            this.lblTotalMes.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalMes.Location = new System.Drawing.Point(708, 444);
            this.lblTotalMes.Name = "lblTotalMes";
            this.lblTotalMes.Size = new System.Drawing.Size(0, 13);
            this.lblTotalMes.TabIndex = 27;
            // 
            // texTotalMes
            // 
            this.texTotalMes.Location = new System.Drawing.Point(672, 437);
            this.texTotalMes.Name = "texTotalMes";
            this.texTotalMes.Size = new System.Drawing.Size(100, 20);
            this.texTotalMes.TabIndex = 29;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Silver;
            this.btnMostrar.Location = new System.Drawing.Point(384, 432);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(136, 29);
            this.btnMostrar.TabIndex = 30;
            this.btnMostrar.Text = "Mostrar total en gastos";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(49, 165);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(100, 20);
            this.txtBuscador.TabIndex = 31;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FE.Properties.Resources.preview_search_find_locate_1551;
            this.pictureBox1.Location = new System.Drawing.Point(16, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // frmAbonados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(814, 468);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.texTotalMes);
            this.Controls.Add(this.lblTotalMes);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.txtPlan);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.cbSector);
            this.Controls.Add(this.lblSector);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNumeroAb);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNumAb);
            this.Controls.Add(this.dataAbonados);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnGuardar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAbonados";
            this.Text = "Abonados";
            ((System.ComponentModel.ISupportInitialize)(this.dataAbonados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label lblNumAb;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNumeroAb;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.ComboBox cbSector;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.TextBox txtPlan;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.DataGridView dataAbonados;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label lblTotalMes;
        private System.Windows.Forms.TextBox texTotalMes;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}