namespace PruebaCalendar
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbdia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbdia
            // 
            this.lbdia.AutoSize = true;
            this.lbdia.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbdia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdia.ForeColor = System.Drawing.Color.White;
            this.lbdia.Location = new System.Drawing.Point(35, 15);
            this.lbdia.Name = "lbdia";
            this.lbdia.Size = new System.Drawing.Size(39, 20);
            this.lbdia.TabIndex = 0;
            this.lbdia.Text = "000";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.lbdia);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(111, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdia;
    }
}
