namespace HP.Presentacion
{
    partial class frmListadoFaltantes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvListadoFaltantes = new System.Windows.Forms.DataGridView();
            this.colPedir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIdLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTituloLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockDeseable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadAPedir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantPedidaNoEntregada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnRealizarPedido = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblProveedor = new System.Windows.Forms.Label();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoFaltantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(174, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Listado de Faltantes";
            // 
            // dgvListadoFaltantes
            // 
            this.dgvListadoFaltantes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvListadoFaltantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoFaltantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoFaltantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoFaltantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoFaltantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPedir,
            this.colIdLibro,
            this.colISBN,
            this.colTituloLibro,
            this.colStockActual,
            this.colStockMinimo,
            this.colStockDeseable,
            this.colCantidadAPedir,
            this.colCantPedidaNoEntregada,
            this.colPrecioCompra,
            this.colSubtotal});
            this.dgvListadoFaltantes.Location = new System.Drawing.Point(12, 31);
            this.dgvListadoFaltantes.Name = "dgvListadoFaltantes";
            this.dgvListadoFaltantes.Size = new System.Drawing.Size(879, 320);
            this.dgvListadoFaltantes.TabIndex = 1;
            this.dgvListadoFaltantes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoFaltantes_CellEndEdit);
            this.dgvListadoFaltantes.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvListadoFaltantes_DataError);
            // 
            // colPedir
            // 
            this.colPedir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colPedir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colPedir.Frozen = true;
            this.colPedir.HeaderText = "Pedir";
            this.colPedir.Name = "colPedir";
            this.colPedir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPedir.ToolTipText = "Tildar si desea agregar al pedido";
            this.colPedir.Width = 42;
            // 
            // colIdLibro
            // 
            this.colIdLibro.Frozen = true;
            this.colIdLibro.HeaderText = "Id Libro";
            this.colIdLibro.Name = "colIdLibro";
            this.colIdLibro.ReadOnly = true;
            this.colIdLibro.Visible = false;
            // 
            // colISBN
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colISBN.DefaultCellStyle = dataGridViewCellStyle3;
            this.colISBN.Frozen = true;
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.ReadOnly = true;
            this.colISBN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colISBN.Width = 90;
            // 
            // colTituloLibro
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.colTituloLibro.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTituloLibro.Frozen = true;
            this.colTituloLibro.HeaderText = "Titulo del Libro";
            this.colTituloLibro.Name = "colTituloLibro";
            this.colTituloLibro.ReadOnly = true;
            this.colTituloLibro.Width = 200;
            // 
            // colStockActual
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colStockActual.DefaultCellStyle = dataGridViewCellStyle5;
            this.colStockActual.Frozen = true;
            this.colStockActual.HeaderText = "Stock Actual";
            this.colStockActual.MinimumWidth = 50;
            this.colStockActual.Name = "colStockActual";
            this.colStockActual.ReadOnly = true;
            this.colStockActual.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStockActual.Width = 60;
            // 
            // colStockMinimo
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colStockMinimo.DefaultCellStyle = dataGridViewCellStyle6;
            this.colStockMinimo.Frozen = true;
            this.colStockMinimo.HeaderText = "Stock Mínimo";
            this.colStockMinimo.MinimumWidth = 50;
            this.colStockMinimo.Name = "colStockMinimo";
            this.colStockMinimo.ReadOnly = true;
            this.colStockMinimo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStockMinimo.Width = 60;
            // 
            // colStockDeseable
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colStockDeseable.DefaultCellStyle = dataGridViewCellStyle7;
            this.colStockDeseable.Frozen = true;
            this.colStockDeseable.HeaderText = "Stock Deseable";
            this.colStockDeseable.MinimumWidth = 50;
            this.colStockDeseable.Name = "colStockDeseable";
            this.colStockDeseable.ReadOnly = true;
            this.colStockDeseable.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStockDeseable.Width = 60;
            // 
            // colCantidadAPedir
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colCantidadAPedir.DefaultCellStyle = dataGridViewCellStyle8;
            this.colCantidadAPedir.Frozen = true;
            this.colCantidadAPedir.HeaderText = "Cantidad a Pedir";
            this.colCantidadAPedir.MinimumWidth = 50;
            this.colCantidadAPedir.Name = "colCantidadAPedir";
            this.colCantidadAPedir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCantidadAPedir.ToolTipText = "Es el \"Stock Deseable\" menos el \"Stock Actual\"";
            this.colCantidadAPedir.Width = 60;
            // 
            // colCantPedidaNoEntregada
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colCantPedidaNoEntregada.DefaultCellStyle = dataGridViewCellStyle9;
            this.colCantPedidaNoEntregada.Frozen = true;
            this.colCantPedidaNoEntregada.HeaderText = "Cant. Pedida y No Entregada";
            this.colCantPedidaNoEntregada.Name = "colCantPedidaNoEntregada";
            this.colCantPedidaNoEntregada.ReadOnly = true;
            this.colCantPedidaNoEntregada.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colPrecioCompra
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colPrecioCompra.DefaultCellStyle = dataGridViewCellStyle10;
            this.colPrecioCompra.Frozen = true;
            this.colPrecioCompra.HeaderText = "Precio de Compra";
            this.colPrecioCompra.Name = "colPrecioCompra";
            this.colPrecioCompra.ReadOnly = true;
            this.colPrecioCompra.Width = 70;
            // 
            // colSubtotal
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colSubtotal.DefaultCellStyle = dataGridViewCellStyle11;
            this.colSubtotal.Frozen = true;
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            this.colSubtotal.Width = 70;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(792, 8);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(99, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "30/09/2009";
            // 
            // btnRealizarPedido
            // 
            this.btnRealizarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRealizarPedido.Location = new System.Drawing.Point(709, 402);
            this.btnRealizarPedido.Name = "btnRealizarPedido";
            this.btnRealizarPedido.Size = new System.Drawing.Size(101, 23);
            this.btnRealizarPedido.TabIndex = 3;
            this.btnRealizarPedido.Text = "Realizar Pedido";
            this.btnRealizarPedido.UseVisualStyleBackColor = true;
            this.btnRealizarPedido.Click += new System.EventHandler(this.btnRealizarPedido_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Location = new System.Drawing.Point(816, 402);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(12, 402);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Libro";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxProveedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.proveedoresBindingSource, "Id_prov", true));
            this.cbxProveedor.DataSource = this.proveedoresBindingSource;
            this.cbxProveedor.DisplayMember = "Razon_social";
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(375, 4);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(121, 21);
            this.cbxProveedor.TabIndex = 6;
            this.cbxProveedor.ValueMember = "Id_prov";
            this.cbxProveedor.SelectedIndexChanged += new System.EventHandler(this.cbxProveedor_SelectedIndexChanged);
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataSource = typeof(HP.Entidades.Proveedores);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(304, 8);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(65, 13);
            this.lblProveedor.TabIndex = 7;
            this.lblProveedor.Text = "Proveedor";
            // 
            // tbxTotal
            // 
            this.tbxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxTotal.Location = new System.Drawing.Point(796, 357);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.ReadOnly = true;
            this.tbxTotal.Size = new System.Drawing.Size(71, 20);
            this.tbxTotal.TabIndex = 8;
            this.tbxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(750, 360);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total:";
            // 
            // frmListadoFaltantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVolver;
            this.ClientSize = new System.Drawing.Size(903, 431);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.cbxProveedor);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRealizarPedido);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dgvListadoFaltantes);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmListadoFaltantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listado de Faltantes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoFaltantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvListadoFaltantes;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnRealizarPedido;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPedir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTituloLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockDeseable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadAPedir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantPedidaNoEntregada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
    }
}