namespace HP.Presentacion
{
    partial class frmAgregarAlListadoFaltantes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbxIsbn = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbxTitulo_Libro = new System.Windows.Forms.TextBox();
            this.lblColeccion = new System.Windows.Forms.Label();
            this.tbxTitulo_Colec = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvListadoLibros = new System.Windows.Forms.DataGridView();
            this.btnAgregarYSalir = new System.Windows.Forms.Button();
            this.btnAgregarYVolverABuscar = new System.Windows.Forms.Button();
            this.lblPertenecen = new System.Windows.Forms.Label();
            this.lblNoPertenecen = new System.Windows.Forms.Label();
            this.colId_Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId_Prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAgregar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxIsbn
            // 
            this.tbxIsbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxIsbn.Location = new System.Drawing.Point(122, 12);
            this.tbxIsbn.Name = "tbxIsbn";
            this.tbxIsbn.Size = new System.Drawing.Size(100, 20);
            this.tbxIsbn.TabIndex = 0;
            this.tbxIsbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIsbn
            // 
            this.lblIsbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsbn.Location = new System.Drawing.Point(76, 15);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(40, 13);
            this.lblIsbn.TabIndex = 1;
            this.lblIsbn.Text = "ISBN:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(302, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(45, 13);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Título:";
            // 
            // tbxTitulo_Libro
            // 
            this.tbxTitulo_Libro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTitulo_Libro.Location = new System.Drawing.Point(353, 10);
            this.tbxTitulo_Libro.Name = "tbxTitulo_Libro";
            this.tbxTitulo_Libro.Size = new System.Drawing.Size(100, 20);
            this.tbxTitulo_Libro.TabIndex = 2;
            this.tbxTitulo_Libro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblColeccion
            // 
            this.lblColeccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColeccion.AutoSize = true;
            this.lblColeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColeccion.Location = new System.Drawing.Point(533, 14);
            this.lblColeccion.Name = "lblColeccion";
            this.lblColeccion.Size = new System.Drawing.Size(67, 13);
            this.lblColeccion.TabIndex = 5;
            this.lblColeccion.Text = "Colección:";
            // 
            // tbxTitulo_Colec
            // 
            this.tbxTitulo_Colec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTitulo_Colec.Location = new System.Drawing.Point(606, 10);
            this.tbxTitulo_Colec.Name = "tbxTitulo_Colec";
            this.tbxTitulo_Colec.Size = new System.Drawing.Size(100, 20);
            this.tbxTitulo_Colec.TabIndex = 4;
            this.tbxTitulo_Colec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(792, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvListadoLibros
            // 
            this.dgvListadoLibros.AllowUserToAddRows = false;
            this.dgvListadoLibros.AllowUserToResizeColumns = false;
            this.dgvListadoLibros.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvListadoLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId_Libro,
            this.colId_Prov,
            this.colIsbn,
            this.colCategoria,
            this.colRazonSocial,
            this.colColeccion,
            this.colTitulo,
            this.colPrecioCompra,
            this.colAgregar});
            this.dgvListadoLibros.Location = new System.Drawing.Point(12, 41);
            this.dgvListadoLibros.Name = "dgvListadoLibros";
            this.dgvListadoLibros.Size = new System.Drawing.Size(854, 228);
            this.dgvListadoLibros.TabIndex = 7;
            // 
            // btnAgregarYSalir
            // 
            this.btnAgregarYSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarYSalir.Location = new System.Drawing.Point(536, 275);
            this.btnAgregarYSalir.Name = "btnAgregarYSalir";
            this.btnAgregarYSalir.Size = new System.Drawing.Size(88, 23);
            this.btnAgregarYSalir.TabIndex = 8;
            this.btnAgregarYSalir.Text = "Agregar y Salir";
            this.btnAgregarYSalir.UseVisualStyleBackColor = true;
            this.btnAgregarYSalir.Click += new System.EventHandler(this.btnAgregarYSalir_Click);
            // 
            // btnAgregarYVolverABuscar
            // 
            this.btnAgregarYVolverABuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarYVolverABuscar.Location = new System.Drawing.Point(729, 275);
            this.btnAgregarYVolverABuscar.Name = "btnAgregarYVolverABuscar";
            this.btnAgregarYVolverABuscar.Size = new System.Drawing.Size(138, 23);
            this.btnAgregarYVolverABuscar.TabIndex = 9;
            this.btnAgregarYVolverABuscar.Text = "Agregar y Volver a Buscar";
            this.btnAgregarYVolverABuscar.UseVisualStyleBackColor = true;
            this.btnAgregarYVolverABuscar.Click += new System.EventHandler(this.btnAgregarYVolverABuscar_Click);
            // 
            // lblPertenecen
            // 
            this.lblPertenecen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPertenecen.AutoSize = true;
            this.lblPertenecen.Location = new System.Drawing.Point(9, 280);
            this.lblPertenecen.Name = "lblPertenecen";
            this.lblPertenecen.Size = new System.Drawing.Size(206, 13);
            this.lblPertenecen.TabIndex = 10;
            this.lblPertenecen.Text = "Pertenecen al presente proveedor (Negro)";
            // 
            // lblNoPertenecen
            // 
            this.lblNoPertenecen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNoPertenecen.AutoSize = true;
            this.lblNoPertenecen.ForeColor = System.Drawing.Color.Red;
            this.lblNoPertenecen.Location = new System.Drawing.Point(9, 298);
            this.lblNoPertenecen.Name = "lblNoPertenecen";
            this.lblNoPertenecen.Size = new System.Drawing.Size(215, 13);
            this.lblNoPertenecen.TabIndex = 11;
            this.lblNoPertenecen.Text = "No pertenecen al presente proveedor (Rojo)";
            // 
            // colId_Libro
            // 
            this.colId_Libro.Frozen = true;
            this.colId_Libro.HeaderText = "Id Libro";
            this.colId_Libro.Name = "colId_Libro";
            this.colId_Libro.ReadOnly = true;
            this.colId_Libro.Visible = false;
            // 
            // colId_Prov
            // 
            this.colId_Prov.Frozen = true;
            this.colId_Prov.HeaderText = "Id Poveedor";
            this.colId_Prov.Name = "colId_Prov";
            this.colId_Prov.ReadOnly = true;
            this.colId_Prov.Visible = false;
            // 
            // colIsbn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colIsbn.DefaultCellStyle = dataGridViewCellStyle3;
            this.colIsbn.Frozen = true;
            this.colIsbn.HeaderText = "ISBN";
            this.colIsbn.Name = "colIsbn";
            this.colIsbn.ReadOnly = true;
            this.colIsbn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colCategoria
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colCategoria.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCategoria.Frozen = true;
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            this.colCategoria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCategoria.Width = 135;
            // 
            // colRazonSocial
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colRazonSocial.DefaultCellStyle = dataGridViewCellStyle5;
            this.colRazonSocial.Frozen = true;
            this.colRazonSocial.HeaderText = "Proveedor";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.ReadOnly = true;
            // 
            // colColeccion
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colColeccion.DefaultCellStyle = dataGridViewCellStyle6;
            this.colColeccion.Frozen = true;
            this.colColeccion.HeaderText = "Colección";
            this.colColeccion.Name = "colColeccion";
            this.colColeccion.ReadOnly = true;
            this.colColeccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colColeccion.Width = 135;
            // 
            // colTitulo
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colTitulo.DefaultCellStyle = dataGridViewCellStyle7;
            this.colTitulo.Frozen = true;
            this.colTitulo.HeaderText = "Título";
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.ReadOnly = true;
            this.colTitulo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTitulo.Width = 200;
            // 
            // colPrecioCompra
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colPrecioCompra.DefaultCellStyle = dataGridViewCellStyle8;
            this.colPrecioCompra.Frozen = true;
            this.colPrecioCompra.HeaderText = "Precio de Compra";
            this.colPrecioCompra.Name = "colPrecioCompra";
            this.colPrecioCompra.ReadOnly = true;
            this.colPrecioCompra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPrecioCompra.Width = 70;
            // 
            // colAgregar
            // 
            this.colAgregar.Frozen = true;
            this.colAgregar.HeaderText = "Agregar";
            this.colAgregar.Name = "colAgregar";
            this.colAgregar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAgregar.ThreeState = true;
            this.colAgregar.ToolTipText = "Seleccione la casilla de verificación si desea agregar este libro al listado de f" +
                "altantes.";
            this.colAgregar.Width = 55;
            // 
            // frmAgregarAlListadoFaltantes
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 320);
            this.Controls.Add(this.lblNoPertenecen);
            this.Controls.Add(this.lblPertenecen);
            this.Controls.Add(this.btnAgregarYVolverABuscar);
            this.Controls.Add(this.btnAgregarYSalir);
            this.Controls.Add(this.dgvListadoLibros);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblColeccion);
            this.Controls.Add(this.tbxTitulo_Colec);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tbxTitulo_Libro);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.tbxIsbn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAgregarAlListadoFaltantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Libros al Listado de Faltantes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxIsbn;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbxTitulo_Libro;
        private System.Windows.Forms.Label lblColeccion;
        private System.Windows.Forms.TextBox tbxTitulo_Colec;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvListadoLibros;
        private System.Windows.Forms.Button btnAgregarYSalir;
        private System.Windows.Forms.Button btnAgregarYVolverABuscar;
        private System.Windows.Forms.Label lblPertenecen;
        private System.Windows.Forms.Label lblNoPertenecen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId_Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId_Prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCompra;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAgregar;
    }
}