namespace HP.Presentacion
{
    partial class frmMenuPrincipal
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
            this.btnABMLibros = new System.Windows.Forms.Button();
            this.btnListadoDeFaltantes = new System.Windows.Forms.Button();
            this.btnListadoDePedidosPendientes = new System.Windows.Forms.Button();
            this.btnConsultarLibros = new System.Windows.Forms.Button();
            this.btnVenderLibros = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.sfdBackUp = new System.Windows.Forms.SaveFileDialog();
            this.btnABMProveedor = new System.Windows.Forms.Button();
            this.ofdRestaurarBase = new System.Windows.Forms.OpenFileDialog();
            this.btnRestaurarBase = new System.Windows.Forms.Button();
            this.gbxClientes = new System.Windows.Forms.GroupBox();
            this.gbxProveedores = new System.Windows.Forms.GroupBox();
            this.gbxLibros = new System.Windows.Forms.GroupBox();
            this.gbxMantenimiento = new System.Windows.Forms.GroupBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.gbxClientes.SuspendLayout();
            this.gbxProveedores.SuspendLayout();
            this.gbxLibros.SuspendLayout();
            this.gbxMantenimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnABMLibros
            // 
            this.btnABMLibros.Location = new System.Drawing.Point(6, 19);
            this.btnABMLibros.Name = "btnABMLibros";
            this.btnABMLibros.Size = new System.Drawing.Size(161, 23);
            this.btnABMLibros.TabIndex = 0;
            this.btnABMLibros.Text = "ABM Libros";
            this.btnABMLibros.UseVisualStyleBackColor = true;
            this.btnABMLibros.Click += new System.EventHandler(this.btnABMLibros_Click);
            // 
            // btnListadoDeFaltantes
            // 
            this.btnListadoDeFaltantes.Location = new System.Drawing.Point(6, 48);
            this.btnListadoDeFaltantes.Name = "btnListadoDeFaltantes";
            this.btnListadoDeFaltantes.Size = new System.Drawing.Size(161, 23);
            this.btnListadoDeFaltantes.TabIndex = 2;
            this.btnListadoDeFaltantes.Text = "Listado de Faltantes";
            this.btnListadoDeFaltantes.UseVisualStyleBackColor = true;
            this.btnListadoDeFaltantes.Click += new System.EventHandler(this.btnListadoDeFaltantes_Click);
            // 
            // btnListadoDePedidosPendientes
            // 
            this.btnListadoDePedidosPendientes.Location = new System.Drawing.Point(6, 77);
            this.btnListadoDePedidosPendientes.Name = "btnListadoDePedidosPendientes";
            this.btnListadoDePedidosPendientes.Size = new System.Drawing.Size(161, 23);
            this.btnListadoDePedidosPendientes.TabIndex = 3;
            this.btnListadoDePedidosPendientes.Text = "Listado de Pedidos Pendientes";
            this.btnListadoDePedidosPendientes.UseVisualStyleBackColor = true;
            this.btnListadoDePedidosPendientes.Click += new System.EventHandler(this.btnListadoDePedidosPendientes_Click);
            // 
            // btnConsultarLibros
            // 
            this.btnConsultarLibros.Location = new System.Drawing.Point(6, 77);
            this.btnConsultarLibros.Name = "btnConsultarLibros";
            this.btnConsultarLibros.Size = new System.Drawing.Size(161, 23);
            this.btnConsultarLibros.TabIndex = 4;
            this.btnConsultarLibros.Text = "Consultar Libros";
            this.btnConsultarLibros.UseVisualStyleBackColor = true;
            this.btnConsultarLibros.Click += new System.EventHandler(this.btnConsultarLibros_Click);
            // 
            // btnVenderLibros
            // 
            this.btnVenderLibros.Location = new System.Drawing.Point(6, 19);
            this.btnVenderLibros.Name = "btnVenderLibros";
            this.btnVenderLibros.Size = new System.Drawing.Size(161, 23);
            this.btnVenderLibros.TabIndex = 5;
            this.btnVenderLibros.Text = "Vender Libros";
            this.btnVenderLibros.UseVisualStyleBackColor = true;
            this.btnVenderLibros.Click += new System.EventHandler(this.btnVenderLibros_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(6, 48);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(161, 23);
            this.btnAgregarCliente.TabIndex = 6;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnBackUp
            // 
            this.btnBackUp.Location = new System.Drawing.Point(6, 19);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(161, 23);
            this.btnBackUp.TabIndex = 7;
            this.btnBackUp.Text = "Realizar Back Up";
            this.btnBackUp.UseVisualStyleBackColor = true;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // sfdBackUp
            // 
            this.sfdBackUp.DefaultExt = "bak";
            this.sfdBackUp.FileName = "arlequin";
            this.sfdBackUp.Filter = "Archivos de Back Up (*.bak)|*.bak|Todos los archivos (*.*)|*.*";
            this.sfdBackUp.Title = "Guardar Back Up Como...";
            // 
            // btnABMProveedor
            // 
            this.btnABMProveedor.Location = new System.Drawing.Point(6, 19);
            this.btnABMProveedor.Name = "btnABMProveedor";
            this.btnABMProveedor.Size = new System.Drawing.Size(161, 23);
            this.btnABMProveedor.TabIndex = 1;
            this.btnABMProveedor.Text = "ABM Proveedores";
            this.btnABMProveedor.UseVisualStyleBackColor = true;
            this.btnABMProveedor.Click += new System.EventHandler(this.btnABMProveedor_Click);
            // 
            // ofdRestaurarBase
            // 
            this.ofdRestaurarBase.DefaultExt = "bak";
            this.ofdRestaurarBase.FileName = "arlequin";
            this.ofdRestaurarBase.Filter = "Archivos de Back Up (*.bak)|*.bak|Todos los archivos (*.*)|*.*";
            this.ofdRestaurarBase.Title = "Restaurar Base de Datos Desde...";
            // 
            // btnRestaurarBase
            // 
            this.btnRestaurarBase.Location = new System.Drawing.Point(6, 48);
            this.btnRestaurarBase.Name = "btnRestaurarBase";
            this.btnRestaurarBase.Size = new System.Drawing.Size(161, 23);
            this.btnRestaurarBase.TabIndex = 8;
            this.btnRestaurarBase.Text = "Restaurar Base de Datos";
            this.btnRestaurarBase.UseVisualStyleBackColor = true;
            this.btnRestaurarBase.Click += new System.EventHandler(this.btnRestaurarBase_Click);
            // 
            // gbxClientes
            // 
            this.gbxClientes.Controls.Add(this.btnVenderLibros);
            this.gbxClientes.Controls.Add(this.btnConsultarLibros);
            this.gbxClientes.Controls.Add(this.btnAgregarCliente);
            this.gbxClientes.Location = new System.Drawing.Point(12, 39);
            this.gbxClientes.Name = "gbxClientes";
            this.gbxClientes.Size = new System.Drawing.Size(178, 114);
            this.gbxClientes.TabIndex = 9;
            this.gbxClientes.TabStop = false;
            this.gbxClientes.Text = "Clientes";
            // 
            // gbxProveedores
            // 
            this.gbxProveedores.Controls.Add(this.btnABMProveedor);
            this.gbxProveedores.Controls.Add(this.btnListadoDeFaltantes);
            this.gbxProveedores.Controls.Add(this.btnListadoDePedidosPendientes);
            this.gbxProveedores.Location = new System.Drawing.Point(218, 39);
            this.gbxProveedores.Name = "gbxProveedores";
            this.gbxProveedores.Size = new System.Drawing.Size(178, 114);
            this.gbxProveedores.TabIndex = 10;
            this.gbxProveedores.TabStop = false;
            this.gbxProveedores.Text = "Proveedores";
            // 
            // gbxLibros
            // 
            this.gbxLibros.Controls.Add(this.btnABMLibros);
            this.gbxLibros.Location = new System.Drawing.Point(12, 176);
            this.gbxLibros.Name = "gbxLibros";
            this.gbxLibros.Size = new System.Drawing.Size(178, 85);
            this.gbxLibros.TabIndex = 11;
            this.gbxLibros.TabStop = false;
            this.gbxLibros.Text = "Libros";
            // 
            // gbxMantenimiento
            // 
            this.gbxMantenimiento.Controls.Add(this.btnBackUp);
            this.gbxMantenimiento.Controls.Add(this.btnRestaurarBase);
            this.gbxMantenimiento.Location = new System.Drawing.Point(218, 176);
            this.gbxMantenimiento.Name = "gbxMantenimiento";
            this.gbxMantenimiento.Size = new System.Drawing.Size(178, 85);
            this.gbxMantenimiento.TabIndex = 12;
            this.gbxMantenimiento.TabStop = false;
            this.gbxMantenimiento.Text = "Mantenimiento";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(305, 278);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(91, 23);
            this.btnCerrarSesion.TabIndex = 13;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.Location = new System.Drawing.Point(13, 13);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(144, 13);
            this.lblOpciones.TabIndex = 14;
            this.lblOpciones.Text = "Opciones de Operación:";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(411, 313);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.gbxMantenimiento);
            this.Controls.Add(this.gbxLibros);
            this.Controls.Add(this.gbxProveedores);
            this.Controls.Add(this.gbxClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmMenuPrincipal_HelpRequested);
            this.gbxClientes.ResumeLayout(false);
            this.gbxProveedores.ResumeLayout(false);
            this.gbxLibros.ResumeLayout(false);
            this.gbxMantenimiento.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnABMLibros;
        private System.Windows.Forms.Button btnListadoDeFaltantes;
        private System.Windows.Forms.Button btnListadoDePedidosPendientes;
        private System.Windows.Forms.Button btnConsultarLibros;
        private System.Windows.Forms.Button btnVenderLibros;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.SaveFileDialog sfdBackUp;
        private System.Windows.Forms.Button btnABMProveedor;
        private System.Windows.Forms.OpenFileDialog ofdRestaurarBase;
        private System.Windows.Forms.Button btnRestaurarBase;
        private System.Windows.Forms.GroupBox gbxClientes;
        private System.Windows.Forms.GroupBox gbxProveedores;
        private System.Windows.Forms.GroupBox gbxLibros;
        private System.Windows.Forms.GroupBox gbxMantenimiento;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblOpciones;



    }
}