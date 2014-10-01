namespace HP.Presentacion
{
    partial class frmDatosLibro
    {
        /// <summary>
        /// Variable del disenador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Disenador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Disenador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIsbn = new System.Windows.Forms.Label();
            this.tbxIsbn = new System.Windows.Forms.TextBox();
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbxResena = new System.Windows.Forms.TextBox();
            this.lblResena = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(24, 15);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(35, 13);
            this.lblIsbn.TabIndex = 0;
            this.lblIsbn.Text = "ISBN:";
            // 
            // tbxIsbn
            // 
            this.tbxIsbn.Location = new System.Drawing.Point(65, 12);
            this.tbxIsbn.Name = "tbxIsbn";
            this.tbxIsbn.Size = new System.Drawing.Size(249, 20);
            this.tbxIsbn.TabIndex = 1;
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Location = new System.Drawing.Point(65, 38);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(249, 20);
            this.tbxTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(21, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Título:";
            // 
            // tbxResena
            // 
            this.tbxResena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxResena.Location = new System.Drawing.Point(65, 64);
            this.tbxResena.Multiline = true;
            this.tbxResena.Name = "tbxResena";
            this.tbxResena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxResena.Size = new System.Drawing.Size(249, 214);
            this.tbxResena.TabIndex = 4;
            // 
            // lblResena
            // 
            this.lblResena.AutoSize = true;
            this.lblResena.Location = new System.Drawing.Point(12, 67);
            this.lblResena.Name = "lblResena";
            this.lblResena.Size = new System.Drawing.Size(47, 13);
            this.lblResena.TabIndex = 7;
            this.lblResena.Text = "Resena:";
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.Location = new System.Drawing.Point(239, 284);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // frmDatosLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 319);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblResena);
            this.Controls.Add(this.tbxResena);
            this.Controls.Add(this.tbxTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tbxIsbn);
            this.Controls.Add(this.lblIsbn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(500, 450);
            this.Name = "frmDatosLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos del Libro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.TextBox tbxIsbn;
        private System.Windows.Forms.TextBox tbxTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbxResena;
        private System.Windows.Forms.Label lblResena;
        private System.Windows.Forms.Button btnVolver;
    }
}