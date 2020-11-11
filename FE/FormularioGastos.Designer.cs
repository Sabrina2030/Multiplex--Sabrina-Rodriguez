namespace FE
{
    partial class frmGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGastos));
            this.lblGastosTotales = new System.Windows.Forms.Label();
            this.lblruto = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.paGastosTotales = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLista = new System.Windows.Forms.Label();
            this.btnGastosTotales = new System.Windows.Forms.Button();
            this.btnNuevoProveedor = new System.Windows.Forms.Button();
            this.btnCofirmar = new System.Windows.Forms.Button();
            this.txtProveedores = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtTotalGastos = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.paIngresoBruto = new System.Windows.Forms.Panel();
            this.lblTotalCobranzas = new System.Windows.Forms.Label();
            this.txtCobranzas = new System.Windows.Forms.TextBox();
            this.lblCobranzas = new System.Windows.Forms.Label();
            this.paIngresoNeto = new System.Windows.Forms.Panel();
            this.btnIngresosNetos = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.dataGastos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.paGastosTotales.SuspendLayout();
            this.panel1.SuspendLayout();
            this.paIngresoBruto.SuspendLayout();
            this.paIngresoNeto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGastosTotales
            // 
            this.lblGastosTotales.AutoSize = true;
            this.lblGastosTotales.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosTotales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGastosTotales.Location = new System.Drawing.Point(99, 0);
            this.lblGastosTotales.Name = "lblGastosTotales";
            this.lblGastosTotales.Size = new System.Drawing.Size(124, 21);
            this.lblGastosTotales.TabIndex = 0;
            this.lblGastosTotales.Text = "Gastos Totales";
            this.lblGastosTotales.UseWaitCursor = true;
            // 
            // lblruto
            // 
            this.lblruto.AutoSize = true;
            this.lblruto.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblruto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblruto.Location = new System.Drawing.Point(95, 0);
            this.lblruto.Name = "lblruto";
            this.lblruto.Size = new System.Drawing.Size(133, 21);
            this.lblruto.TabIndex = 1;
            this.lblruto.Text = "Ingresos Brutos";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIngresos.Location = new System.Drawing.Point(100, 0);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(128, 21);
            this.lblIngresos.TabIndex = 2;
            this.lblIngresos.Text = "Ingresos Netos";
            // 
            // paGastosTotales
            // 
            this.paGastosTotales.AllowDrop = true;
            this.paGastosTotales.AutoSize = true;
            this.paGastosTotales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paGastosTotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paGastosTotales.Controls.Add(this.panel1);
            this.paGastosTotales.Controls.Add(this.btnGastosTotales);
            this.paGastosTotales.Controls.Add(this.btnNuevoProveedor);
            this.paGastosTotales.Controls.Add(this.btnCofirmar);
            this.paGastosTotales.Controls.Add(this.txtProveedores);
            this.paGastosTotales.Controls.Add(this.txtMonto);
            this.paGastosTotales.Controls.Add(this.txtTotalGastos);
            this.paGastosTotales.Controls.Add(this.lblMonto);
            this.paGastosTotales.Controls.Add(this.lblProveedores);
            this.paGastosTotales.Controls.Add(this.lblGastosTotales);
            this.paGastosTotales.Location = new System.Drawing.Point(47, 13);
            this.paGastosTotales.Name = "paGastosTotales";
            this.paGastosTotales.Size = new System.Drawing.Size(327, 319);
            this.paGastosTotales.TabIndex = 3;
            this.paGastosTotales.TabStop = true;
            this.paGastosTotales.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lblLista);
            this.panel1.Location = new System.Drawing.Point(25, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 148);
            this.panel1.TabIndex = 26;
            this.panel1.UseWaitCursor = true;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(10, 9);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(70, 13);
            this.lblLista.TabIndex = 25;
            this.lblLista.Text = "Proveedores:";
            this.lblLista.UseWaitCursor = true;
            // 
            // btnGastosTotales
            // 
            this.btnGastosTotales.Location = new System.Drawing.Point(119, 277);
            this.btnGastosTotales.Name = "btnGastosTotales";
            this.btnGastosTotales.Size = new System.Drawing.Size(75, 23);
            this.btnGastosTotales.TabIndex = 24;
            this.btnGastosTotales.Text = "Calcular";
            this.btnGastosTotales.UseVisualStyleBackColor = true;
            this.btnGastosTotales.UseWaitCursor = true;
            this.btnGastosTotales.Click += new System.EventHandler(this.btnGastosTotales_Click);
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.Location = new System.Drawing.Point(229, 62);
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.Size = new System.Drawing.Size(75, 19);
            this.btnNuevoProveedor.TabIndex = 23;
            this.btnNuevoProveedor.Text = "Nuevo";
            this.btnNuevoProveedor.UseVisualStyleBackColor = true;
            this.btnNuevoProveedor.UseWaitCursor = true;
            this.btnNuevoProveedor.Click += new System.EventHandler(this.btnNuevoProveedor_Click);
            // 
            // btnCofirmar
            // 
            this.btnCofirmar.Location = new System.Drawing.Point(229, 35);
            this.btnCofirmar.Name = "btnCofirmar";
            this.btnCofirmar.Size = new System.Drawing.Size(75, 20);
            this.btnCofirmar.TabIndex = 21;
            this.btnCofirmar.Text = "Confirmar";
            this.btnCofirmar.UseVisualStyleBackColor = true;
            this.btnCofirmar.UseWaitCursor = true;
            this.btnCofirmar.Click += new System.EventHandler(this.btnCofirmar_Click);
            // 
            // txtProveedores
            // 
            this.txtProveedores.Location = new System.Drawing.Point(123, 36);
            this.txtProveedores.Name = "txtProveedores";
            this.txtProveedores.Size = new System.Drawing.Size(100, 20);
            this.txtProveedores.TabIndex = 20;
            this.txtProveedores.UseWaitCursor = true;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(123, 61);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 19;
            this.txtMonto.UseWaitCursor = true;
            // 
            // txtTotalGastos
            // 
            this.txtTotalGastos.Location = new System.Drawing.Point(200, 280);
            this.txtTotalGastos.Name = "txtTotalGastos";
            this.txtTotalGastos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalGastos.TabIndex = 11;
            this.txtTotalGastos.UseWaitCursor = true;
            this.txtTotalGastos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTotalGastos_KeyUp);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMonto.Location = new System.Drawing.Point(18, 64);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 2;
            this.lblMonto.Text = "Monto:";
            this.lblMonto.UseWaitCursor = true;
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblProveedores.Location = new System.Drawing.Point(18, 39);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(102, 13);
            this.lblProveedores.TabIndex = 1;
            this.lblProveedores.Text = "Proveedores Varios:";
            this.lblProveedores.UseWaitCursor = true;
            // 
            // paIngresoBruto
            // 
            this.paIngresoBruto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paIngresoBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paIngresoBruto.Controls.Add(this.lblTotalCobranzas);
            this.paIngresoBruto.Controls.Add(this.txtCobranzas);
            this.paIngresoBruto.Controls.Add(this.lblCobranzas);
            this.paIngresoBruto.Controls.Add(this.lblruto);
            this.paIngresoBruto.Location = new System.Drawing.Point(413, 14);
            this.paIngresoBruto.Name = "paIngresoBruto";
            this.paIngresoBruto.Size = new System.Drawing.Size(317, 143);
            this.paIngresoBruto.TabIndex = 4;
            // 
            // lblTotalCobranzas
            // 
            this.lblTotalCobranzas.AutoSize = true;
            this.lblTotalCobranzas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalCobranzas.Location = new System.Drawing.Point(43, 67);
            this.lblTotalCobranzas.Name = "lblTotalCobranzas";
            this.lblTotalCobranzas.Size = new System.Drawing.Size(99, 13);
            this.lblTotalCobranzas.TabIndex = 4;
            this.lblTotalCobranzas.Text = "Total de Cobranzas";
            // 
            // txtCobranzas
            // 
            this.txtCobranzas.Location = new System.Drawing.Point(154, 63);
            this.txtCobranzas.Name = "txtCobranzas";
            this.txtCobranzas.Size = new System.Drawing.Size(100, 20);
            this.txtCobranzas.TabIndex = 3;
            // 
            // lblCobranzas
            // 
            this.lblCobranzas.AutoSize = true;
            this.lblCobranzas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCobranzas.Location = new System.Drawing.Point(64, 67);
            this.lblCobranzas.Name = "lblCobranzas";
            this.lblCobranzas.Size = new System.Drawing.Size(0, 13);
            this.lblCobranzas.TabIndex = 2;
            // 
            // paIngresoNeto
            // 
            this.paIngresoNeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paIngresoNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paIngresoNeto.Controls.Add(this.btnIngresosNetos);
            this.paIngresoNeto.Controls.Add(this.lblTotal);
            this.paIngresoNeto.Controls.Add(this.txtFecha);
            this.paIngresoNeto.Controls.Add(this.txtTotal);
            this.paIngresoNeto.Controls.Add(this.LblFecha);
            this.paIngresoNeto.Controls.Add(this.lblIngresos);
            this.paIngresoNeto.Location = new System.Drawing.Point(413, 177);
            this.paIngresoNeto.Name = "paIngresoNeto";
            this.paIngresoNeto.Size = new System.Drawing.Size(317, 155);
            this.paIngresoNeto.TabIndex = 5;
            // 
            // btnIngresosNetos
            // 
            this.btnIngresosNetos.Location = new System.Drawing.Point(67, 59);
            this.btnIngresosNetos.Name = "btnIngresosNetos";
            this.btnIngresosNetos.Size = new System.Drawing.Size(75, 34);
            this.btnIngresosNetos.TabIndex = 8;
            this.btnIngresosNetos.Text = "Calcular Ingresos Netos";
            this.btnIngresosNetos.UseVisualStyleBackColor = true;
            this.btnIngresosNetos.Click += new System.EventHandler(this.btnIngresosNetos_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotal.Location = new System.Drawing.Point(170, 70);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(173, 47);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(173, 86);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblFecha.Location = new System.Drawing.Point(170, 31);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(40, 13);
            this.LblFecha.TabIndex = 4;
            this.LblFecha.Text = "Fecha:";
            // 
            // dataGastos
            // 
            this.dataGastos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGastos.Location = new System.Drawing.Point(47, 374);
            this.dataGastos.Name = "dataGastos";
            this.dataGastos.Size = new System.Drawing.Size(445, 229);
            this.dataGastos.TabIndex = 6;
            this.dataGastos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGastos_CellClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(47, 345);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.UseWaitCursor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(128, 345);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.UseWaitCursor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Location = new System.Drawing.Point(209, 345);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(75, 23);
            this.btnVerTodo.TabIndex = 27;
            this.btnVerTodo.Text = "Ver Todo";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            this.btnVerTodo.UseWaitCursor = true;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(290, 345);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 28;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.UseWaitCursor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(766, 625);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnVerTodo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGastos);
            this.Controls.Add(this.paIngresoNeto);
            this.Controls.Add(this.paIngresoBruto);
            this.Controls.Add(this.paGastosTotales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGastos";
            this.Text = "Gastos y Ganancias";
            this.paGastosTotales.ResumeLayout(false);
            this.paGastosTotales.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.paIngresoBruto.ResumeLayout(false);
            this.paIngresoBruto.PerformLayout();
            this.paIngresoNeto.ResumeLayout(false);
            this.paIngresoNeto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGastosTotales;
        private System.Windows.Forms.Label lblruto;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Panel paGastosTotales;
        private System.Windows.Forms.Panel paIngresoBruto;
        private System.Windows.Forms.Panel paIngresoNeto;
        private System.Windows.Forms.Label lblCobranzas;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnCofirmar;
        private System.Windows.Forms.TextBox txtProveedores;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtTotalGastos;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Button btnNuevoProveedor;
        private System.Windows.Forms.Button btnGastosTotales;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIngresosNetos;
        public System.Windows.Forms.TextBox txtCobranzas;
        private System.Windows.Forms.Label lblTotalCobranzas;
        private System.Windows.Forms.DataGridView dataGastos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.Button btnBorrar;
    }
}