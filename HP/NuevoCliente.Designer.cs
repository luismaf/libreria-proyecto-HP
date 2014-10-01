namespace HP.Presentacion
{
    partial class frmNuevoCliente
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
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.tbxNroDoc = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.tbxTelefono = new System.Windows.Forms.TextBox();
            this.tbxNacimientoDia = new System.Windows.Forms.TextBox();
            this.tbxNacimientoMes = new System.Windows.Forms.TextBox();
            this.tbxNacimientoAno = new System.Windows.Forms.TextBox();
            this.cbxTipoDoc = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblDdMmAa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(12, 15);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(54, 13);
            this.lblTipoDoc.TabIndex = 1;
            this.lblTipoDoc.Text = "Tipo Doc:";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(16, 41);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(50, 13);
            this.lblNroDoc.TabIndex = 3;
            this.lblNroDoc.Text = "Nro Doc:";
            // 
            // tbxNroDoc
            // 
            this.tbxNroDoc.Location = new System.Drawing.Point(72, 38);
            this.tbxNroDoc.Name = "tbxNroDoc";
            this.tbxNroDoc.Size = new System.Drawing.Size(135, 20);
            this.tbxNroDoc.TabIndex = 1;
            this.tbxNroDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(72, 64);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(135, 20);
            this.tbxNombre.TabIndex = 2;
            this.tbxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(19, 93);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido:";
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(72, 90);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(135, 20);
            this.tbxApellido.TabIndex = 3;
            this.tbxApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(213, 15);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(96, 13);
            this.lblFechaNacimiento.TabIndex = 11;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(221, 67);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(218, 93);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(27, 119);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-Mail:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(72, 116);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(135, 20);
            this.tbxEmail.TabIndex = 4;
            this.tbxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDireccion.Location = new System.Drawing.Point(279, 90);
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(135, 20);
            this.tbxDireccion.TabIndex = 9;
            this.tbxDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTelefono.Location = new System.Drawing.Point(279, 64);
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(135, 20);
            this.tbxTelefono.TabIndex = 8;
            this.tbxTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxNacimientoDia
            // 
            this.tbxNacimientoDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNacimientoDia.Location = new System.Drawing.Point(315, 12);
            this.tbxNacimientoDia.Name = "tbxNacimientoDia";
            this.tbxNacimientoDia.Size = new System.Drawing.Size(25, 20);
            this.tbxNacimientoDia.TabIndex = 5;
            this.tbxNacimientoDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNacimientoMes
            // 
            this.tbxNacimientoMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNacimientoMes.Location = new System.Drawing.Point(346, 12);
            this.tbxNacimientoMes.Name = "tbxNacimientoMes";
            this.tbxNacimientoMes.Size = new System.Drawing.Size(25, 20);
            this.tbxNacimientoMes.TabIndex = 6;
            this.tbxNacimientoMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNacimientoAno
            // 
            this.tbxNacimientoAno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNacimientoAno.Location = new System.Drawing.Point(377, 12);
            this.tbxNacimientoAno.Name = "tbxNacimientoAno";
            this.tbxNacimientoAno.Size = new System.Drawing.Size(38, 20);
            this.tbxNacimientoAno.TabIndex = 7;
            this.tbxNacimientoAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxTipoDoc
            // 
            this.cbxTipoDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTipoDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTipoDoc.FormattingEnabled = true;
            this.cbxTipoDoc.Items.AddRange(new object[] {
            "DNI",
            "Libreta Cívica",
            "Libreta de Enrolamiento"});
            this.cbxTipoDoc.Location = new System.Drawing.Point(72, 11);
            this.cbxTipoDoc.Name = "cbxTipoDoc";
            this.cbxTipoDoc.Size = new System.Drawing.Size(135, 21);
            this.cbxTipoDoc.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(259, 144);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Location = new System.Drawing.Point(340, 144);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // lblDdMmAa
            // 
            this.lblDdMmAa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDdMmAa.AutoSize = true;
            this.lblDdMmAa.Location = new System.Drawing.Point(315, 35);
            this.lblDdMmAa.Name = "lblDdMmAa";
            this.lblDdMmAa.Size = new System.Drawing.Size(99, 13);
            this.lblDdMmAa.TabIndex = 21;
            this.lblDdMmAa.Text = "(dd  /  mm  /  aaaa)";
            // 
            // frmNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 179);
            this.Controls.Add(this.lblDdMmAa);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbxTipoDoc);
            this.Controls.Add(this.tbxNacimientoAno);
            this.Controls.Add(this.tbxNacimientoMes);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxDireccion);
            this.Controls.Add(this.tbxTelefono);
            this.Controls.Add(this.tbxNacimientoDia);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.tbxApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblNroDoc);
            this.Controls.Add(this.tbxNroDoc);
            this.Controls.Add(this.lblTipoDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.frmNuevoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.TextBox tbxNroDoc;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxDireccion;
        private System.Windows.Forms.TextBox tbxTelefono;
        private System.Windows.Forms.TextBox tbxNacimientoDia;
        private System.Windows.Forms.TextBox tbxNacimientoMes;
        private System.Windows.Forms.TextBox tbxNacimientoAno;
        private System.Windows.Forms.ComboBox cbxTipoDoc;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblDdMmAa;
    }
}