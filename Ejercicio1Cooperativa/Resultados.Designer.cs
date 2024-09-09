namespace Ejercicio1Cooperativa
{
    partial class Resultados
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lBResultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(220, 255);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lBResultados
            // 
            this.lBResultados.FormattingEnabled = true;
            this.lBResultados.Location = new System.Drawing.Point(27, 23);
            this.lBResultados.Name = "lBResultados";
            this.lBResultados.Size = new System.Drawing.Size(458, 225);
            this.lBResultados.TabIndex = 1;
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 290);
            this.Controls.Add(this.lBResultados);
            this.Controls.Add(this.btnCerrar);
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.ListBox lBResultados;
    }
}