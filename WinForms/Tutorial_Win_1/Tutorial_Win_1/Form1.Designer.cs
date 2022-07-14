namespace Tutorial_Win_1
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
            this.BtnSaludo = new System.Windows.Forms.Button();
            this.LabSaludo = new System.Windows.Forms.Label();
            this.BtnDespedida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSaludo
            // 
            this.BtnSaludo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSaludo.Location = new System.Drawing.Point(52, 51);
            this.BtnSaludo.Name = "BtnSaludo";
            this.BtnSaludo.Size = new System.Drawing.Size(227, 62);
            this.BtnSaludo.TabIndex = 0;
            this.BtnSaludo.Text = "Te quiero saludar";
            this.BtnSaludo.UseVisualStyleBackColor = false;
            this.BtnSaludo.Click += new System.EventHandler(this.BtnSaludo_Click);
            // 
            // LabSaludo
            // 
            this.LabSaludo.AutoSize = true;
            this.LabSaludo.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSaludo.Location = new System.Drawing.Point(561, 74);
            this.LabSaludo.Name = "LabSaludo";
            this.LabSaludo.Size = new System.Drawing.Size(136, 19);
            this.LabSaludo.TabIndex = 1;
            this.LabSaludo.Text = "Hola mucho gusto!";
            this.LabSaludo.Visible = false;
            // 
            // BtnDespedida
            // 
            this.BtnDespedida.Location = new System.Drawing.Point(52, 185);
            this.BtnDespedida.Name = "BtnDespedida";
            this.BtnDespedida.Size = new System.Drawing.Size(227, 56);
            this.BtnDespedida.TabIndex = 2;
            this.BtnDespedida.Text = "Despidete de mi";
            this.BtnDespedida.UseVisualStyleBackColor = true;
            this.BtnDespedida.Click += new System.EventHandler(this.BtnDespedida_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDespedida);
            this.Controls.Add(this.LabSaludo);
            this.Controls.Add(this.BtnSaludo);
            this.Name = "Form1";
            this.Text = "Programa 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSaludo;
        private System.Windows.Forms.Label LabSaludo;
        private System.Windows.Forms.Button BtnDespedida;
    }
}

