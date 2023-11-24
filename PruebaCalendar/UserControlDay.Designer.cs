namespace PruebaCalendar
{
    partial class UserControlDay
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
            this.lbdia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdia.ForeColor = System.Drawing.Color.Navy;
            this.lbdia.Location = new System.Drawing.Point(0, 0);
            this.lbdia.MaximumSize = new System.Drawing.Size(111, 50);
            this.lbdia.MinimumSize = new System.Drawing.Size(111, 50);
            this.lbdia.Name = "lbdia";
            this.lbdia.Size = new System.Drawing.Size(111, 50);
            this.lbdia.TabIndex = 1;
            this.lbdia.Text = "00";
            this.lbdia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbdia.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserControlDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbdia);
            this.Name = "UserControlDay";
            this.Size = new System.Drawing.Size(111, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbdia;
    }
}
