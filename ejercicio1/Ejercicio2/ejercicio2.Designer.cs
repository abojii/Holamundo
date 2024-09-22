namespace Ejercicio2
{
    partial class ejercicio2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRangoFin = new System.Windows.Forms.TextBox();
            this.txtRangoInicial = new System.Windows.Forms.TextBox();
            this.lblFinRango = new System.Windows.Forms.Label();
            this.lblInicioRango = new System.Windows.Forms.Label();
            this.btnRango = new System.Windows.Forms.Button();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtRangoFin);
            this.panel1.Controls.Add(this.txtRangoInicial);
            this.panel1.Controls.Add(this.lblFinRango);
            this.panel1.Controls.Add(this.lblInicioRango);
            this.panel1.Location = new System.Drawing.Point(50, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 197);
            this.panel1.TabIndex = 0;
            // 
            // txtRangoFin
            // 
            this.txtRangoFin.Location = new System.Drawing.Point(297, 103);
            this.txtRangoFin.Name = "txtRangoFin";
            this.txtRangoFin.Size = new System.Drawing.Size(65, 26);
            this.txtRangoFin.TabIndex = 3;
            // 
            // txtRangoInicial
            // 
            this.txtRangoInicial.Location = new System.Drawing.Point(297, 46);
            this.txtRangoInicial.Name = "txtRangoInicial";
            this.txtRangoInicial.Size = new System.Drawing.Size(65, 26);
            this.txtRangoInicial.TabIndex = 2;
            // 
            // lblFinRango
            // 
            this.lblFinRango.AutoSize = true;
            this.lblFinRango.Location = new System.Drawing.Point(35, 109);
            this.lblFinRango.Name = "lblFinRango";
            this.lblFinRango.Size = new System.Drawing.Size(214, 20);
            this.lblFinRango.TabIndex = 1;
            this.lblFinRango.Text = "Ingrese el valor final del rago:";
            // 
            // lblInicioRango
            // 
            this.lblInicioRango.AutoSize = true;
            this.lblInicioRango.Location = new System.Drawing.Point(35, 46);
            this.lblInicioRango.Name = "lblInicioRango";
            this.lblInicioRango.Size = new System.Drawing.Size(232, 20);
            this.lblInicioRango.TabIndex = 0;
            this.lblInicioRango.Text = "Ingrese el valor inicial del rango:";
            // 
            // btnRango
            // 
            this.btnRango.Location = new System.Drawing.Point(284, 272);
            this.btnRango.Name = "btnRango";
            this.btnRango.Size = new System.Drawing.Size(177, 49);
            this.btnRango.TabIndex = 4;
            this.btnRango.Text = "Imprimir Rango";
            this.btnRango.UseVisualStyleBackColor = true;
            this.btnRango.Click += new System.EventHandler(this.btnRango_Click);
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.ItemHeight = 20;
            this.lstNumeros.Location = new System.Drawing.Point(50, 272);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(203, 144);
            this.lstNumeros.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(284, 356);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(177, 49);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.btnRango);
            this.Controls.Add(this.panel1);
            this.Name = "ejercicio2";
            this.Text = "Ejercicio2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFinRango;
        private System.Windows.Forms.Label lblInicioRango;
        private System.Windows.Forms.TextBox txtRangoFin;
        private System.Windows.Forms.TextBox txtRangoInicial;
        private System.Windows.Forms.Button btnRango;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

