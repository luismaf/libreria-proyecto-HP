namespace HP.Presentacion
{
    partial class frmActualizarPreciosVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListadoColecciones = new System.Windows.Forms.DataGridView();
            this.colIdColec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodColec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTituloColec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioVentaVigente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioVentaNuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblColecciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoColecciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoColecciones
            // 
            this.dgvListadoColecciones.AllowUserToAddRows = false;
            this.dgvListadoColecciones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvListadoColecciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoColecciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoColecciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoColecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoColecciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdColec,
            this.colCodColec,
            this.colTituloColec,
            this.colPrecioCompra,
            this.colPrecioVentaVigente,
            this.colPrecioVentaNuevo});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoColecciones.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListadoColecciones.Location = new System.Drawing.Point(12, 25);
            this.dgvListadoColecciones.MultiSelect = false;
            this.dgvListadoColecciones.Name = "dgvListadoColecciones";
            this.dgvListadoColecciones.Size = new System.Drawing.Size(629, 199);
            this.dgvListadoColecciones.TabIndex = 0;
            this.dgvListadoColecciones.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoColecciones_CellEndEdit);
            this.dgvListadoColecciones.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvListadoColecciones_DataError);
            // 
            // colIdColec
            // 
            this.colIdColec.HeaderText = "Id Coleccion";
            this.colIdColec.Name = "colIdColec";
            this.colIdColec.ReadOnly = true;
            this.colIdColec.Visible = false;
            // 
            // colCodColec
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colCodColec.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCodColec.HeaderText = "Código";
            this.colCodColec.Name = "colCodColec";
            this.colCodColec.ReadOnly = true;
            this.colCodColec.Width = 50;
            // 
            // colTituloColec
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colTituloColec.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTituloColec.HeaderText = "Título";
            this.colTituloColec.Name = "colTituloColec";
            this.colTituloColec.ReadOnly = true;
            this.colTituloColec.Width = 150;
            // 
            // colPrecioCompra
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colPrecioCompra.DefaultCellStyle = dataGridViewCellStyle5;
            this.colPrecioCompra.HeaderText = "Precio de Compra";
            this.colPrecioCompra.Name = "colPrecioCompra";
            this.colPrecioCompra.ReadOnly = true;
            this.colPrecioCompra.Width = 120;
            // 
            // colPrecioVentaVigente
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colPrecioVentaVigente.DefaultCellStyle = dataGridViewCellStyle6;
            this.colPrecioVentaVigente.HeaderText = "Precio de Venta Vigente";
            this.colPrecioVentaVigente.Name = "colPrecioVentaVigente";
            this.colPrecioVentaVigente.ReadOnly = true;
            this.colPrecioVentaVigente.Width = 120;
            // 
            // colPrecioVentaNuevo
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colPrecioVentaNuevo.DefaultCellStyle = dataGridViewCellStyle7;
            this.colPrecioVentaNuevo.HeaderText = "Precio de Venta Nuevo";
            this.colPrecioVentaNuevo.Name = "colPrecioVentaNuevo";
            this.colPrecioVentaNuevo.Width = 120;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolver.Location = new System.Drawing.Point(566, 230);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.Location = new System.Drawing.Point(377, 230);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar Nuevos Precios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblColecciones
            // 
            this.lblColecciones.AutoSize = true;
            this.lblColecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColecciones.Location = new System.Drawing.Point(9, 9);
            this.lblColecciones.Name = "lblColecciones";
            this.lblColecciones.Size = new System.Drawing.Size(80, 13);
            this.lblColecciones.TabIndex = 3;
            this.lblColecciones.Text = "Colecciones:";
            // 
            // frmActualizarPreciosVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 262);
            this.Controls.Add(this.lblColecciones);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvListadoColecciones);
            this.Name = "frmActualizarPreciosVenta";
            this.Text = "Actualizar los Precios de Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoColecciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoColecciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdColec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodColec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTituloColec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioVentaVigente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioVentaNuevo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblColecciones;
    }
}