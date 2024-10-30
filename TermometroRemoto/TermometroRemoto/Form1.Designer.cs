namespace TermometroRemoto
{
    partial class Form1
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
            this.labelTemperatura = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.buttonDesconectar = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelTemperatura
            // 
            this.labelTemperatura.AutoSize = true;
            this.labelTemperatura.Location = new System.Drawing.Point(21, 18);
            this.labelTemperatura.Name = "labelTemperatura";
            this.labelTemperatura.Size = new System.Drawing.Size(73, 13);
            this.labelTemperatura.TabIndex = 0;
            this.labelTemperatura.Text = "Temperatura: ";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(21, 42);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(30, 13);
            this.labelEstado.TabIndex = 1;
            this.labelEstado.Text = "--  °C";
            // 
            // buttonConectar
            // 
            this.buttonConectar.Location = new System.Drawing.Point(154, 59);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(85, 23);
            this.buttonConectar.TabIndex = 2;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // buttonDesconectar
            // 
            this.buttonDesconectar.Location = new System.Drawing.Point(154, 109);
            this.buttonDesconectar.Name = "buttonDesconectar";
            this.buttonDesconectar.Size = new System.Drawing.Size(85, 23);
            this.buttonDesconectar.TabIndex = 3;
            this.buttonDesconectar.Text = "Desconectar";
            this.buttonDesconectar.UseVisualStyleBackColor = true;
            this.buttonDesconectar.Click += new System.EventHandler(this.buttonDesconectar_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(134, 18);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPorts.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 191);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.buttonDesconectar);
            this.Controls.Add(this.buttonConectar);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelTemperatura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTemperatura;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Button buttonDesconectar;
        private System.Windows.Forms.ComboBox comboBoxPorts;
    }
}

