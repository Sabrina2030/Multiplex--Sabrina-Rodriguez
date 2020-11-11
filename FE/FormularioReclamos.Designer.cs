namespace FE
{
    partial class frmReclamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReclamos));
            this.lblNumero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbSolicitud = new System.Windows.Forms.RadioButton();
            this.rbReclamo = new System.Windows.Forms.RadioButton();
            this.rbConsulta = new System.Windows.Forms.RadioButton();
            this.txtNumeroAB = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.dtgReclamos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReclamo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btVerReclamos = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReclamos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumero.Location = new System.Drawing.Point(15, 27);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(105, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Numero de Abonado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(15, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Abonado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(15, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(15, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Detalle";
            // 
            // rbSolicitud
            // 
            this.rbSolicitud.AutoSize = true;
            this.rbSolicitud.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbSolicitud.Location = new System.Drawing.Point(25, 13);
            this.rbSolicitud.Name = "rbSolicitud";
            this.rbSolicitud.Size = new System.Drawing.Size(65, 17);
            this.rbSolicitud.TabIndex = 5;
            this.rbSolicitud.TabStop = true;
            this.rbSolicitud.Text = "Solicitud";
            this.rbSolicitud.UseVisualStyleBackColor = true;
            // 
            // rbReclamo
            // 
            this.rbReclamo.AutoSize = true;
            this.rbReclamo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbReclamo.Location = new System.Drawing.Point(196, 13);
            this.rbReclamo.Name = "rbReclamo";
            this.rbReclamo.Size = new System.Drawing.Size(67, 17);
            this.rbReclamo.TabIndex = 6;
            this.rbReclamo.TabStop = true;
            this.rbReclamo.Text = "Reclamo";
            this.rbReclamo.UseVisualStyleBackColor = true;
            // 
            // rbConsulta
            // 
            this.rbConsulta.AutoSize = true;
            this.rbConsulta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbConsulta.Location = new System.Drawing.Point(107, 13);
            this.rbConsulta.Name = "rbConsulta";
            this.rbConsulta.Size = new System.Drawing.Size(66, 17);
            this.rbConsulta.TabIndex = 7;
            this.rbConsulta.TabStop = true;
            this.rbConsulta.Text = "Consulta";
            this.rbConsulta.UseVisualStyleBackColor = true;
            // 
            // txtNumeroAB
            // 
            this.txtNumeroAB.Location = new System.Drawing.Point(145, 20);
            this.txtNumeroAB.Name = "txtNumeroAB";
            this.txtNumeroAB.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroAB.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(145, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(145, 89);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(205, 20);
            this.txtDireccion.TabIndex = 10;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(145, 129);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(383, 107);
            this.txtDetalle.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(461, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Telefono de Contacto";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(577, 89);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(210, 20);
            this.txtTelefono.TabIndex = 18;
            // 
            // dtgReclamos
            // 
            this.dtgReclamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReclamos.Location = new System.Drawing.Point(13, 285);
            this.dtgReclamos.Name = "dtgReclamos";
            this.dtgReclamos.Size = new System.Drawing.Size(877, 208);
            this.dtgReclamos.TabIndex = 19;
            this.dtgReclamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgReclamos_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbSolicitud);
            this.panel1.Controls.Add(this.rbConsulta);
            this.panel1.Controls.Add(this.rbReclamo);
            this.panel1.Location = new System.Drawing.Point(504, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 36);
            this.panel1.TabIndex = 20;
            // 
            // btnReclamo
            // 
            this.btnReclamo.Location = new System.Drawing.Point(677, 132);
            this.btnReclamo.Name = "btnReclamo";
            this.btnReclamo.Size = new System.Drawing.Size(110, 23);
            this.btnReclamo.TabIndex = 21;
            this.btnReclamo.Text = "Agregar ";
            this.btnReclamo.UseVisualStyleBackColor = true;
            this.btnReclamo.Click += new System.EventHandler(this.btnReclamo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(677, 162);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 23);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar ";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btVerReclamos
            // 
            this.btVerReclamos.Location = new System.Drawing.Point(677, 192);
            this.btVerReclamos.Name = "btVerReclamos";
            this.btVerReclamos.Size = new System.Drawing.Size(110, 23);
            this.btVerReclamos.TabIndex = 23;
            this.btVerReclamos.Text = "Ver ";
            this.btVerReclamos.UseVisualStyleBackColor = true;
            this.btVerReclamos.Click += new System.EventHandler(this.btVerReclamos_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "En proceso",
            "Solucionado",
            "Anulado"});
            this.cbEstado.Location = new System.Drawing.Point(577, 62);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 24;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEstado.Location = new System.Drawing.Point(461, 65);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 25;
            this.lblEstado.Text = "Estado";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(677, 221);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(110, 23);
            this.btnCambiar.TabIndex = 26;
            this.btnCambiar.Text = "Modificar Estado";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // frmReclamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(902, 521);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.btVerReclamos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnReclamo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgReclamos);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNumeroAB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReclamos";
            this.Text = "Reclamos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgReclamos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbSolicitud;
        private System.Windows.Forms.RadioButton rbReclamo;
        private System.Windows.Forms.RadioButton rbConsulta;
        private System.Windows.Forms.TextBox txtNumeroAB;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DataGridView dtgReclamos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReclamo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btVerReclamos;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnCambiar;
    }
}