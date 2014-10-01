namespace HP.Presentacion
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lklOlvideContrasena = new System.Windows.Forms.LinkLabel();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.tbxContrasena = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            resources.ApplyResources(this.lblBienvenido, "lblBienvenido");
            this.lblBienvenido.Name = "lblBienvenido";
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.Name = "lblUsuario";
            // 
            // lblContrasena
            // 
            resources.ApplyResources(this.lblContrasena, "lblContrasena");
            this.lblContrasena.Name = "lblContrasena";
            // 
            // lklOlvideContrasena
            // 
            resources.ApplyResources(this.lklOlvideContrasena, "lklOlvideContrasena");
            this.lklOlvideContrasena.Name = "lklOlvideContrasena";
            this.lklOlvideContrasena.TabStop = true;
            // 
            // tbxUsuario
            // 
            resources.ApplyResources(this.tbxUsuario, "tbxUsuario");
            this.tbxUsuario.Name = "tbxUsuario";
            // 
            // tbxContrasena
            // 
            resources.ApplyResources(this.tbxContrasena, "tbxContrasena");
            this.tbxContrasena.Name = "tbxContrasena";
            // 
            // btnEntrar
            // 
            resources.ApplyResources(this.btnEntrar, "btnEntrar");
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // frmLogIn
            // 
            this.AcceptButton = this.btnEntrar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.tbxContrasena);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.lklOlvideContrasena);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblBienvenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.LinkLabel lklOlvideContrasena;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.TextBox tbxContrasena;
        private System.Windows.Forms.Button btnEntrar;
    }
}

