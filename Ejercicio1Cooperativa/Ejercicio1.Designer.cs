namespace Ejercicio1Cooperativa
{
    partial class Ejercicio1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCooperativa = new System.Windows.Forms.Label();
            this.tBCooperativa = new System.Windows.Forms.TextBox();
            this.btnIniciarCooperativa = new System.Windows.Forms.Button();
            this.gBAltaDeClientes = new System.Windows.Forms.GroupBox();
            this.btnCargaDeClientes = new System.Windows.Forms.Button();
            this.gBConsultasDeClientes = new System.Windows.Forms.GroupBox();
            this.lblNroDeServicio = new System.Windows.Forms.Label();
            this.tBNroDeServicio = new System.Windows.Forms.TextBox();
            this.btnSeleccionarNro = new System.Windows.Forms.Button();
            this.lblServicioSeleccionado = new System.Windows.Forms.Label();
            this.gBCargaDeConsumos = new System.Windows.Forms.GroupBox();
            this.tBCargaDeConsumos = new System.Windows.Forms.TextBox();
            this.btnCargarConsumo = new System.Windows.Forms.Button();
            this.gBConsumos = new System.Windows.Forms.GroupBox();
            this.btnVerConsumo = new System.Windows.Forms.Button();
            this.lblConsumos = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gBAltaDeClientes.SuspendLayout();
            this.gBConsultasDeClientes.SuspendLayout();
            this.gBCargaDeConsumos.SuspendLayout();
            this.gBConsumos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCooperativa
            // 
            this.lblCooperativa.AutoSize = true;
            this.lblCooperativa.Location = new System.Drawing.Point(56, 34);
            this.lblCooperativa.Name = "lblCooperativa";
            this.lblCooperativa.Size = new System.Drawing.Size(64, 13);
            this.lblCooperativa.TabIndex = 0;
            this.lblCooperativa.Text = "Cooperativa";
            // 
            // tBCooperativa
            // 
            this.tBCooperativa.Location = new System.Drawing.Point(137, 31);
            this.tBCooperativa.Multiline = true;
            this.tBCooperativa.Name = "tBCooperativa";
            this.tBCooperativa.Size = new System.Drawing.Size(185, 20);
            this.tBCooperativa.TabIndex = 1;
            // 
            // btnIniciarCooperativa
            // 
            this.btnIniciarCooperativa.Location = new System.Drawing.Point(344, 29);
            this.btnIniciarCooperativa.Name = "btnIniciarCooperativa";
            this.btnIniciarCooperativa.Size = new System.Drawing.Size(148, 23);
            this.btnIniciarCooperativa.TabIndex = 2;
            this.btnIniciarCooperativa.Text = "Iniciar Cooperativa";
            this.btnIniciarCooperativa.UseVisualStyleBackColor = true;
            this.btnIniciarCooperativa.Click += new System.EventHandler(this.btnIniciarCooperativa_Click);
            // 
            // gBAltaDeClientes
            // 
            this.gBAltaDeClientes.Controls.Add(this.btnCargaDeClientes);
            this.gBAltaDeClientes.Location = new System.Drawing.Point(38, 69);
            this.gBAltaDeClientes.Name = "gBAltaDeClientes";
            this.gBAltaDeClientes.Size = new System.Drawing.Size(474, 46);
            this.gBAltaDeClientes.TabIndex = 3;
            this.gBAltaDeClientes.TabStop = false;
            this.gBAltaDeClientes.Text = "Alta de Clientes";
            // 
            // btnCargaDeClientes
            // 
            this.btnCargaDeClientes.Location = new System.Drawing.Point(306, 14);
            this.btnCargaDeClientes.Name = "btnCargaDeClientes";
            this.btnCargaDeClientes.Size = new System.Drawing.Size(148, 23);
            this.btnCargaDeClientes.TabIndex = 0;
            this.btnCargaDeClientes.Text = "Carga de clientes";
            this.btnCargaDeClientes.UseVisualStyleBackColor = true;
            this.btnCargaDeClientes.Click += new System.EventHandler(this.btnCargaDeClientes_Click);
            // 
            // gBConsultasDeClientes
            // 
            this.gBConsultasDeClientes.Controls.Add(this.gBConsumos);
            this.gBConsultasDeClientes.Controls.Add(this.gBCargaDeConsumos);
            this.gBConsultasDeClientes.Controls.Add(this.lblServicioSeleccionado);
            this.gBConsultasDeClientes.Controls.Add(this.btnSeleccionarNro);
            this.gBConsultasDeClientes.Controls.Add(this.tBNroDeServicio);
            this.gBConsultasDeClientes.Controls.Add(this.lblNroDeServicio);
            this.gBConsultasDeClientes.Location = new System.Drawing.Point(38, 122);
            this.gBConsultasDeClientes.Name = "gBConsultasDeClientes";
            this.gBConsultasDeClientes.Size = new System.Drawing.Size(474, 243);
            this.gBConsultasDeClientes.TabIndex = 4;
            this.gBConsultasDeClientes.TabStop = false;
            this.gBConsultasDeClientes.Text = "Consultas de clientes";
            this.gBConsultasDeClientes.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblNroDeServicio
            // 
            this.lblNroDeServicio.AutoSize = true;
            this.lblNroDeServicio.Location = new System.Drawing.Point(18, 29);
            this.lblNroDeServicio.Name = "lblNroDeServicio";
            this.lblNroDeServicio.Size = new System.Drawing.Size(100, 13);
            this.lblNroDeServicio.TabIndex = 0;
            this.lblNroDeServicio.Text = "Número de Servicio";
            this.lblNroDeServicio.Click += new System.EventHandler(this.label1_Click);
            // 
            // tBNroDeServicio
            // 
            this.tBNroDeServicio.Location = new System.Drawing.Point(124, 26);
            this.tBNroDeServicio.Name = "tBNroDeServicio";
            this.tBNroDeServicio.Size = new System.Drawing.Size(143, 20);
            this.tBNroDeServicio.TabIndex = 1;
            // 
            // btnSeleccionarNro
            // 
            this.btnSeleccionarNro.Location = new System.Drawing.Point(306, 24);
            this.btnSeleccionarNro.Name = "btnSeleccionarNro";
            this.btnSeleccionarNro.Size = new System.Drawing.Size(148, 23);
            this.btnSeleccionarNro.TabIndex = 2;
            this.btnSeleccionarNro.Text = "Seleccionar";
            this.btnSeleccionarNro.UseVisualStyleBackColor = true;
            this.btnSeleccionarNro.Click += new System.EventHandler(this.btnSeleccionarNro_Click);
            // 
            // lblServicioSeleccionado
            // 
            this.lblServicioSeleccionado.AutoSize = true;
            this.lblServicioSeleccionado.Location = new System.Drawing.Point(142, 53);
            this.lblServicioSeleccionado.Name = "lblServicioSeleccionado";
            this.lblServicioSeleccionado.Size = new System.Drawing.Size(25, 13);
            this.lblServicioSeleccionado.TabIndex = 3;
            this.lblServicioSeleccionado.Text = "------";
            // 
            // gBCargaDeConsumos
            // 
            this.gBCargaDeConsumos.Controls.Add(this.lblConsumos);
            this.gBCargaDeConsumos.Controls.Add(this.btnCargarConsumo);
            this.gBCargaDeConsumos.Controls.Add(this.tBCargaDeConsumos);
            this.gBCargaDeConsumos.Location = new System.Drawing.Point(21, 74);
            this.gBCargaDeConsumos.Name = "gBCargaDeConsumos";
            this.gBCargaDeConsumos.Size = new System.Drawing.Size(447, 81);
            this.gBCargaDeConsumos.TabIndex = 4;
            this.gBCargaDeConsumos.TabStop = false;
            this.gBCargaDeConsumos.Text = "Carga de consumos";
            // 
            // tBCargaDeConsumos
            // 
            this.tBCargaDeConsumos.Location = new System.Drawing.Point(75, 29);
            this.tBCargaDeConsumos.Name = "tBCargaDeConsumos";
            this.tBCargaDeConsumos.Size = new System.Drawing.Size(170, 20);
            this.tBCargaDeConsumos.TabIndex = 0;
            // 
            // btnCargarConsumo
            // 
            this.btnCargarConsumo.Location = new System.Drawing.Point(285, 25);
            this.btnCargarConsumo.Name = "btnCargarConsumo";
            this.btnCargarConsumo.Size = new System.Drawing.Size(148, 23);
            this.btnCargarConsumo.TabIndex = 1;
            this.btnCargarConsumo.Text = "Cargar Consumo";
            this.btnCargarConsumo.UseVisualStyleBackColor = true;
            this.btnCargarConsumo.Click += new System.EventHandler(this.button1_Click);
            // 
            // gBConsumos
            // 
            this.gBConsumos.Controls.Add(this.btnVerConsumo);
            this.gBConsumos.Location = new System.Drawing.Point(21, 171);
            this.gBConsumos.Name = "gBConsumos";
            this.gBConsumos.Size = new System.Drawing.Size(447, 57);
            this.gBConsumos.TabIndex = 5;
            this.gBConsumos.TabStop = false;
            this.gBConsumos.Text = "Consumos";
            // 
            // btnVerConsumo
            // 
            this.btnVerConsumo.Location = new System.Drawing.Point(285, 19);
            this.btnVerConsumo.Name = "btnVerConsumo";
            this.btnVerConsumo.Size = new System.Drawing.Size(148, 23);
            this.btnVerConsumo.TabIndex = 0;
            this.btnVerConsumo.Text = "Ver Consumo";
            this.btnVerConsumo.UseVisualStyleBackColor = true;
            this.btnVerConsumo.Click += new System.EventHandler(this.btnVerConsumo_Click);
            // 
            // lblConsumos
            // 
            this.lblConsumos.AutoSize = true;
            this.lblConsumos.Location = new System.Drawing.Point(75, 56);
            this.lblConsumos.Name = "lblConsumos";
            this.lblConsumos.Size = new System.Drawing.Size(19, 13);
            this.lblConsumos.TabIndex = 2;
            this.lblConsumos.Text = "----";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(229, 382);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 417);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gBConsultasDeClientes);
            this.Controls.Add(this.gBAltaDeClientes);
            this.Controls.Add(this.btnIniciarCooperativa);
            this.Controls.Add(this.tBCooperativa);
            this.Controls.Add(this.lblCooperativa);
            this.Name = "Ejercicio1";
            this.Text = "Ejercicio 1";
            this.gBAltaDeClientes.ResumeLayout(false);
            this.gBConsultasDeClientes.ResumeLayout(false);
            this.gBConsultasDeClientes.PerformLayout();
            this.gBCargaDeConsumos.ResumeLayout(false);
            this.gBCargaDeConsumos.PerformLayout();
            this.gBConsumos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCooperativa;
        private System.Windows.Forms.TextBox tBCooperativa;
        private System.Windows.Forms.Button btnIniciarCooperativa;
        private System.Windows.Forms.GroupBox gBAltaDeClientes;
        private System.Windows.Forms.Button btnCargaDeClientes;
        private System.Windows.Forms.GroupBox gBConsultasDeClientes;
        private System.Windows.Forms.Button btnSeleccionarNro;
        private System.Windows.Forms.TextBox tBNroDeServicio;
        private System.Windows.Forms.Label lblNroDeServicio;
        private System.Windows.Forms.Label lblServicioSeleccionado;
        private System.Windows.Forms.GroupBox gBCargaDeConsumos;
        private System.Windows.Forms.Button btnCargarConsumo;
        private System.Windows.Forms.TextBox tBCargaDeConsumos;
        private System.Windows.Forms.GroupBox gBConsumos;
        private System.Windows.Forms.Button btnVerConsumo;
        private System.Windows.Forms.Label lblConsumos;
        private System.Windows.Forms.Button btnCerrar;
    }
}

