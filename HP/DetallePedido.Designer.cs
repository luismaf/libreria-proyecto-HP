namespace HP.Presentacion
{
    partial class frmDetallePedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTituloNroPedido = new System.Windows.Forms.Label();
            this.lblNroPedido = new System.Windows.Forms.Label();
            this.lblFechaPedido = new System.Windows.Forms.Label();
            this.lblTituloFechaPedido = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblTituloProveedor = new System.Windows.Forms.Label();
            this.dgvListadoLibros = new System.Windows.Forms.DataGridView();
            this.colIdLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTituloLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantPedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantAceptada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdColec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCod_Colec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo_Colec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdLineaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxDatosDelPago = new System.Windows.Forms.GroupBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.tbxBanco = new System.Windows.Forms.TextBox();
            this.gbxFechaPresentacionCheque = new System.Windows.Forms.GroupBox();
            this.rbt60Dias = new System.Windows.Forms.RadioButton();
            this.tbxFechaPresentacionCheque = new System.Windows.Forms.TextBox();
            this.lblFechaVencCheque = new System.Windows.Forms.Label();
            this.rbt30Dias = new System.Windows.Forms.RadioButton();
            this.btnEliminarNC = new System.Windows.Forms.Button();
            this.lblTotalNC = new System.Windows.Forms.Label();
            this.tbxTotalNC = new System.Windows.Forms.TextBox();
            this.dgvNotasCredito = new System.Windows.Forms.DataGridView();
            this.colIdNc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontoAUtilizar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarNC = new System.Windows.Forms.Button();
            this.lblMontoCompra = new System.Windows.Forms.Label();
            this.lblNroCheque = new System.Windows.Forms.Label();
            this.lblMontoCheque = new System.Windows.Forms.Label();
            this.tbxNroCheque = new System.Windows.Forms.TextBox();
            this.tbxMontoCheque = new System.Windows.Forms.TextBox();
            this.tbxMontoCompra = new System.Windows.Forms.TextBox();
            this.btnGuardarComoPedidoEntregado = new System.Windows.Forms.Button();
            this.lblTituloFechaEntregado = new System.Windows.Forms.Label();
            this.lblFechaEntregado = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblFechaCancelado = new System.Windows.Forms.Label();
            this.lblTituloFechaCancelado = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTituloEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLibros)).BeginInit();
            this.gbxDatosDelPago.SuspendLayout();
            this.gbxFechaPresentacionCheque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasCredito)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloNroPedido
            // 
            this.lblTituloNroPedido.AutoSize = true;
            this.lblTituloNroPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNroPedido.Location = new System.Drawing.Point(21, 15);
            this.lblTituloNroPedido.Name = "lblTituloNroPedido";
            this.lblTituloNroPedido.Size = new System.Drawing.Size(78, 13);
            this.lblTituloNroPedido.TabIndex = 0;
            this.lblTituloNroPedido.Text = "Nro. Pedido:";
            // 
            // lblNroPedido
            // 
            this.lblNroPedido.AutoSize = true;
            this.lblNroPedido.Location = new System.Drawing.Point(105, 15);
            this.lblNroPedido.Name = "lblNroPedido";
            this.lblNroPedido.Size = new System.Drawing.Size(31, 13);
            this.lblNroPedido.TabIndex = 1;
            this.lblNroPedido.Text = "1045";
            // 
            // lblFechaPedido
            // 
            this.lblFechaPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaPedido.AutoSize = true;
            this.lblFechaPedido.Location = new System.Drawing.Point(97, 38);
            this.lblFechaPedido.Name = "lblFechaPedido";
            this.lblFechaPedido.Size = new System.Drawing.Size(53, 13);
            this.lblFechaPedido.TabIndex = 3;
            this.lblFechaPedido.Text = "29/10/09";
            // 
            // lblTituloFechaPedido
            // 
            this.lblTituloFechaPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloFechaPedido.AutoSize = true;
            this.lblTituloFechaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFechaPedido.Location = new System.Drawing.Point(2, 38);
            this.lblTituloFechaPedido.Name = "lblTituloFechaPedido";
            this.lblTituloFechaPedido.Size = new System.Drawing.Size(89, 13);
            this.lblTituloFechaPedido.TabIndex = 2;
            this.lblTituloFechaPedido.Text = "Fecha Pedido:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(377, 15);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(65, 13);
            this.lblProveedor.TabIndex = 5;
            this.lblProveedor.Text = "Darken S.A.";
            // 
            // lblTituloProveedor
            // 
            this.lblTituloProveedor.AutoSize = true;
            this.lblTituloProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProveedor.Location = new System.Drawing.Point(302, 15);
            this.lblTituloProveedor.Name = "lblTituloProveedor";
            this.lblTituloProveedor.Size = new System.Drawing.Size(69, 13);
            this.lblTituloProveedor.TabIndex = 4;
            this.lblTituloProveedor.Text = "Proveedor:";
            // 
            // dgvListadoLibros
            // 
            this.dgvListadoLibros.AllowUserToAddRows = false;
            this.dgvListadoLibros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvListadoLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvListadoLibros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvListadoLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdLibro,
            this.colCodLibro,
            this.colTituloLibro,
            this.colCantPedida,
            this.colCantAceptada,
            this.colPrecioCompra,
            this.colSubtotal,
            this.colIdColec,
            this.colCod_Colec,
            this.colTitulo_Colec,
            this.colIdLineaPedido});
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoLibros.DefaultCellStyle = dataGridViewCellStyle25;
            this.dgvListadoLibros.Location = new System.Drawing.Point(13, 69);
            this.dgvListadoLibros.Name = "dgvListadoLibros";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoLibros.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvListadoLibros.Size = new System.Drawing.Size(685, 196);
            this.dgvListadoLibros.TabIndex = 0;
            this.dgvListadoLibros.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvListadoLibros_CellBeginEdit);
            this.dgvListadoLibros.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoLibros_CellEndEdit);
            this.dgvListadoLibros.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvListadoLibros_DataError);
            // 
            // colIdLibro
            // 
            this.colIdLibro.Frozen = true;
            this.colIdLibro.HeaderText = "Id Libro";
            this.colIdLibro.Name = "colIdLibro";
            this.colIdLibro.ReadOnly = true;
            this.colIdLibro.Visible = false;
            // 
            // colCodLibro
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colCodLibro.DefaultCellStyle = dataGridViewCellStyle19;
            this.colCodLibro.Frozen = true;
            this.colCodLibro.HeaderText = "ISBN";
            this.colCodLibro.Name = "colCodLibro";
            this.colCodLibro.ReadOnly = true;
            this.colCodLibro.Width = 95;
            // 
            // colTituloLibro
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colTituloLibro.DefaultCellStyle = dataGridViewCellStyle20;
            this.colTituloLibro.Frozen = true;
            this.colTituloLibro.HeaderText = "Título";
            this.colTituloLibro.Name = "colTituloLibro";
            this.colTituloLibro.ReadOnly = true;
            this.colTituloLibro.Width = 195;
            // 
            // colCantPedida
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colCantPedida.DefaultCellStyle = dataGridViewCellStyle21;
            this.colCantPedida.Frozen = true;
            this.colCantPedida.HeaderText = "Cant Pedida";
            this.colCantPedida.Name = "colCantPedida";
            this.colCantPedida.ReadOnly = true;
            this.colCantPedida.Width = 80;
            // 
            // colCantAceptada
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colCantAceptada.DefaultCellStyle = dataGridViewCellStyle22;
            this.colCantAceptada.Frozen = true;
            this.colCantAceptada.HeaderText = "Cant Aceptada";
            this.colCantAceptada.Name = "colCantAceptada";
            this.colCantAceptada.Width = 80;
            // 
            // colPrecioCompra
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colPrecioCompra.DefaultCellStyle = dataGridViewCellStyle23;
            this.colPrecioCompra.Frozen = true;
            this.colPrecioCompra.HeaderText = "Precio de Compra";
            this.colPrecioCompra.Name = "colPrecioCompra";
            this.colPrecioCompra.Width = 90;
            // 
            // colSubtotal
            // 
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colSubtotal.DefaultCellStyle = dataGridViewCellStyle24;
            this.colSubtotal.Frozen = true;
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            this.colSubtotal.Width = 80;
            // 
            // colIdColec
            // 
            this.colIdColec.Frozen = true;
            this.colIdColec.HeaderText = "Id Colec";
            this.colIdColec.Name = "colIdColec";
            this.colIdColec.ReadOnly = true;
            this.colIdColec.Visible = false;
            // 
            // colCod_Colec
            // 
            this.colCod_Colec.Frozen = true;
            this.colCod_Colec.HeaderText = "Codigo Coleccion";
            this.colCod_Colec.Name = "colCod_Colec";
            this.colCod_Colec.ReadOnly = true;
            this.colCod_Colec.Visible = false;
            // 
            // colTitulo_Colec
            // 
            this.colTitulo_Colec.Frozen = true;
            this.colTitulo_Colec.HeaderText = "Titulo Coleccion";
            this.colTitulo_Colec.Name = "colTitulo_Colec";
            this.colTitulo_Colec.ReadOnly = true;
            this.colTitulo_Colec.Visible = false;
            // 
            // colIdLineaPedido
            // 
            this.colIdLineaPedido.Frozen = true;
            this.colIdLineaPedido.HeaderText = "Id Linea Pedido";
            this.colIdLineaPedido.Name = "colIdLineaPedido";
            this.colIdLineaPedido.ReadOnly = true;
            this.colIdLineaPedido.Visible = false;
            // 
            // gbxDatosDelPago
            // 
            this.gbxDatosDelPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDatosDelPago.Controls.Add(this.lblBanco);
            this.gbxDatosDelPago.Controls.Add(this.tbxBanco);
            this.gbxDatosDelPago.Controls.Add(this.gbxFechaPresentacionCheque);
            this.gbxDatosDelPago.Controls.Add(this.btnEliminarNC);
            this.gbxDatosDelPago.Controls.Add(this.lblTotalNC);
            this.gbxDatosDelPago.Controls.Add(this.tbxTotalNC);
            this.gbxDatosDelPago.Controls.Add(this.dgvNotasCredito);
            this.gbxDatosDelPago.Controls.Add(this.btnAgregarNC);
            this.gbxDatosDelPago.Controls.Add(this.lblMontoCompra);
            this.gbxDatosDelPago.Controls.Add(this.lblNroCheque);
            this.gbxDatosDelPago.Controls.Add(this.lblMontoCheque);
            this.gbxDatosDelPago.Controls.Add(this.tbxNroCheque);
            this.gbxDatosDelPago.Controls.Add(this.tbxMontoCheque);
            this.gbxDatosDelPago.Controls.Add(this.tbxMontoCompra);
            this.gbxDatosDelPago.Location = new System.Drawing.Point(13, 271);
            this.gbxDatosDelPago.Name = "gbxDatosDelPago";
            this.gbxDatosDelPago.Size = new System.Drawing.Size(654, 254);
            this.gbxDatosDelPago.TabIndex = 1;
            this.gbxDatosDelPago.TabStop = false;
            this.gbxDatosDelPago.Text = "Datos del Pago";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(75, 136);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(41, 13);
            this.lblBanco.TabIndex = 14;
            this.lblBanco.Text = "Banco:";
            // 
            // tbxBanco
            // 
            this.tbxBanco.Location = new System.Drawing.Point(122, 133);
            this.tbxBanco.Name = "tbxBanco";
            this.tbxBanco.Size = new System.Drawing.Size(100, 20);
            this.tbxBanco.TabIndex = 5;
            // 
            // gbxFechaPresentacionCheque
            // 
            this.gbxFechaPresentacionCheque.Controls.Add(this.rbt60Dias);
            this.gbxFechaPresentacionCheque.Controls.Add(this.tbxFechaPresentacionCheque);
            this.gbxFechaPresentacionCheque.Controls.Add(this.lblFechaVencCheque);
            this.gbxFechaPresentacionCheque.Controls.Add(this.rbt30Dias);
            this.gbxFechaPresentacionCheque.Location = new System.Drawing.Point(27, 155);
            this.gbxFechaPresentacionCheque.Name = "gbxFechaPresentacionCheque";
            this.gbxFechaPresentacionCheque.Size = new System.Drawing.Size(195, 89);
            this.gbxFechaPresentacionCheque.TabIndex = 6;
            this.gbxFechaPresentacionCheque.TabStop = false;
            this.gbxFechaPresentacionCheque.Text = "Fecha de Presentación del Cheque";
            // 
            // rbt60Dias
            // 
            this.rbt60Dias.AutoSize = true;
            this.rbt60Dias.Location = new System.Drawing.Point(95, 28);
            this.rbt60Dias.Name = "rbt60Dias";
            this.rbt60Dias.Size = new System.Drawing.Size(63, 17);
            this.rbt60Dias.TabIndex = 8;
            this.rbt60Dias.Text = "60 Días";
            this.rbt60Dias.UseVisualStyleBackColor = true;
            this.rbt60Dias.CheckedChanged += new System.EventHandler(this.rbt30Dias_CheckedChanged);
            // 
            // tbxFechaPresentacionCheque
            // 
            this.tbxFechaPresentacionCheque.Location = new System.Drawing.Point(58, 51);
            this.tbxFechaPresentacionCheque.Name = "tbxFechaPresentacionCheque";
            this.tbxFechaPresentacionCheque.ReadOnly = true;
            this.tbxFechaPresentacionCheque.Size = new System.Drawing.Size(100, 20);
            this.tbxFechaPresentacionCheque.TabIndex = 9;
            this.tbxFechaPresentacionCheque.Text = "20/12/1986";
            this.tbxFechaPresentacionCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFechaVencCheque
            // 
            this.lblFechaVencCheque.AutoSize = true;
            this.lblFechaVencCheque.Location = new System.Drawing.Point(19, 54);
            this.lblFechaVencCheque.Name = "lblFechaVencCheque";
            this.lblFechaVencCheque.Size = new System.Drawing.Size(40, 13);
            this.lblFechaVencCheque.TabIndex = 4;
            this.lblFechaVencCheque.Text = "Fecha:";
            // 
            // rbt30Dias
            // 
            this.rbt30Dias.AutoSize = true;
            this.rbt30Dias.Checked = true;
            this.rbt30Dias.Location = new System.Drawing.Point(15, 28);
            this.rbt30Dias.Name = "rbt30Dias";
            this.rbt30Dias.Size = new System.Drawing.Size(63, 17);
            this.rbt30Dias.TabIndex = 7;
            this.rbt30Dias.TabStop = true;
            this.rbt30Dias.Text = "30 Días";
            this.rbt30Dias.UseVisualStyleBackColor = true;
            this.rbt30Dias.CheckedChanged += new System.EventHandler(this.rbt30Dias_CheckedChanged);
            // 
            // btnEliminarNC
            // 
            this.btnEliminarNC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarNC.Enabled = false;
            this.btnEliminarNC.Location = new System.Drawing.Point(501, 26);
            this.btnEliminarNC.Name = "btnEliminarNC";
            this.btnEliminarNC.Size = new System.Drawing.Size(135, 23);
            this.btnEliminarNC.TabIndex = 11;
            this.btnEliminarNC.Text = "Eliminar Nota de Crédito";
            this.btnEliminarNC.UseVisualStyleBackColor = true;
            this.btnEliminarNC.Click += new System.EventHandler(this.btnEliminarNC_Click);
            // 
            // lblTotalNC
            // 
            this.lblTotalNC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalNC.AutoSize = true;
            this.lblTotalNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNC.Location = new System.Drawing.Point(435, 231);
            this.lblTotalNC.Name = "lblTotalNC";
            this.lblTotalNC.Size = new System.Drawing.Size(139, 13);
            this.lblTotalNC.TabIndex = 11;
            this.lblTotalNC.Text = "Total Notas de Crédito:";
            // 
            // tbxTotalNC
            // 
            this.tbxTotalNC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxTotalNC.Location = new System.Drawing.Point(580, 228);
            this.tbxTotalNC.Name = "tbxTotalNC";
            this.tbxTotalNC.ReadOnly = true;
            this.tbxTotalNC.Size = new System.Drawing.Size(56, 20);
            this.tbxTotalNC.TabIndex = 13;
            this.tbxTotalNC.Text = "$0";
            this.tbxTotalNC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvNotasCredito
            // 
            this.dgvNotasCredito.AllowUserToAddRows = false;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvNotasCredito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvNotasCredito.Anchor = System.Windows.Forms.AnchorStyles.Right;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotasCredito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvNotasCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotasCredito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdNc,
            this.colCodNC,
            this.colMontoAUtilizar});
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotasCredito.DefaultCellStyle = dataGridViewCellStyle31;
            this.dgvNotasCredito.Location = new System.Drawing.Point(363, 55);
            this.dgvNotasCredito.Name = "dgvNotasCredito";
            this.dgvNotasCredito.ReadOnly = true;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotasCredito.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvNotasCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotasCredito.Size = new System.Drawing.Size(273, 167);
            this.dgvNotasCredito.TabIndex = 12;
            this.dgvNotasCredito.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvNotasCredito_RowsRemoved);
            // 
            // colIdNc
            // 
            this.colIdNc.Frozen = true;
            this.colIdNc.HeaderText = "ID NC";
            this.colIdNc.Name = "colIdNc";
            this.colIdNc.ReadOnly = true;
            this.colIdNc.Visible = false;
            // 
            // colCodNC
            // 
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colCodNC.DefaultCellStyle = dataGridViewCellStyle29;
            this.colCodNC.Frozen = true;
            this.colCodNC.HeaderText = "Código Nota Cred";
            this.colCodNC.Name = "colCodNC";
            this.colCodNC.ReadOnly = true;
            this.colCodNC.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCodNC.Width = 120;
            // 
            // colMontoAUtilizar
            // 
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colMontoAUtilizar.DefaultCellStyle = dataGridViewCellStyle30;
            this.colMontoAUtilizar.Frozen = true;
            this.colMontoAUtilizar.HeaderText = "Monto a Utilizar";
            this.colMontoAUtilizar.Name = "colMontoAUtilizar";
            this.colMontoAUtilizar.ReadOnly = true;
            this.colMontoAUtilizar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMontoAUtilizar.ToolTipText = "Monto a utilizar de la nota de crédito. No necesariamente es igual al monto total" +
                " de la nota, sino que puede ser menor";
            this.colMontoAUtilizar.Width = 110;
            // 
            // btnAgregarNC
            // 
            this.btnAgregarNC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregarNC.Location = new System.Drawing.Point(363, 26);
            this.btnAgregarNC.Name = "btnAgregarNC";
            this.btnAgregarNC.Size = new System.Drawing.Size(129, 23);
            this.btnAgregarNC.TabIndex = 10;
            this.btnAgregarNC.Text = "Agregar Nota de Crédito";
            this.btnAgregarNC.UseVisualStyleBackColor = true;
            this.btnAgregarNC.Click += new System.EventHandler(this.btnAgregarNC_Click);
            // 
            // lblMontoCompra
            // 
            this.lblMontoCompra.AutoSize = true;
            this.lblMontoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoCompra.Location = new System.Drawing.Point(24, 58);
            this.lblMontoCompra.Name = "lblMontoCompra";
            this.lblMontoCompra.Size = new System.Drawing.Size(92, 13);
            this.lblMontoCompra.TabIndex = 7;
            this.lblMontoCompra.Text = "Monto Compra:";
            // 
            // lblNroCheque
            // 
            this.lblNroCheque.AutoSize = true;
            this.lblNroCheque.Location = new System.Drawing.Point(46, 110);
            this.lblNroCheque.Name = "lblNroCheque";
            this.lblNroCheque.Size = new System.Drawing.Size(70, 13);
            this.lblNroCheque.TabIndex = 6;
            this.lblNroCheque.Text = "Nro. Cheque:";
            // 
            // lblMontoCheque
            // 
            this.lblMontoCheque.AutoSize = true;
            this.lblMontoCheque.Location = new System.Drawing.Point(36, 84);
            this.lblMontoCheque.Name = "lblMontoCheque";
            this.lblMontoCheque.Size = new System.Drawing.Size(80, 13);
            this.lblMontoCheque.TabIndex = 5;
            this.lblMontoCheque.Text = "Monto Cheque:";
            // 
            // tbxNroCheque
            // 
            this.tbxNroCheque.Location = new System.Drawing.Point(122, 107);
            this.tbxNroCheque.Name = "tbxNroCheque";
            this.tbxNroCheque.Size = new System.Drawing.Size(100, 20);
            this.tbxNroCheque.TabIndex = 4;
            // 
            // tbxMontoCheque
            // 
            this.tbxMontoCheque.Location = new System.Drawing.Point(122, 81);
            this.tbxMontoCheque.Name = "tbxMontoCheque";
            this.tbxMontoCheque.ReadOnly = true;
            this.tbxMontoCheque.Size = new System.Drawing.Size(100, 20);
            this.tbxMontoCheque.TabIndex = 3;
            // 
            // tbxMontoCompra
            // 
            this.tbxMontoCompra.Location = new System.Drawing.Point(122, 55);
            this.tbxMontoCompra.Name = "tbxMontoCompra";
            this.tbxMontoCompra.ReadOnly = true;
            this.tbxMontoCompra.Size = new System.Drawing.Size(100, 20);
            this.tbxMontoCompra.TabIndex = 2;
            // 
            // btnGuardarComoPedidoEntregado
            // 
            this.btnGuardarComoPedidoEntregado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarComoPedidoEntregado.Location = new System.Drawing.Point(392, 531);
            this.btnGuardarComoPedidoEntregado.Name = "btnGuardarComoPedidoEntregado";
            this.btnGuardarComoPedidoEntregado.Size = new System.Drawing.Size(172, 23);
            this.btnGuardarComoPedidoEntregado.TabIndex = 14;
            this.btnGuardarComoPedidoEntregado.Text = "Guardar Como Pedido Entregado";
            this.btnGuardarComoPedidoEntregado.UseVisualStyleBackColor = true;
            this.btnGuardarComoPedidoEntregado.Click += new System.EventHandler(this.btnGuardarComoPedidoEntregado_Click);
            // 
            // lblTituloFechaEntregado
            // 
            this.lblTituloFechaEntregado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloFechaEntregado.AutoSize = true;
            this.lblTituloFechaEntregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFechaEntregado.Location = new System.Drawing.Point(255, 38);
            this.lblTituloFechaEntregado.Name = "lblTituloFechaEntregado";
            this.lblTituloFechaEntregado.Size = new System.Drawing.Size(108, 13);
            this.lblTituloFechaEntregado.TabIndex = 9;
            this.lblTituloFechaEntregado.Text = "Fecha Entregado:";
            this.lblTituloFechaEntregado.Visible = false;
            // 
            // lblFechaEntregado
            // 
            this.lblFechaEntregado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaEntregado.AutoSize = true;
            this.lblFechaEntregado.Location = new System.Drawing.Point(369, 38);
            this.lblFechaEntregado.Name = "lblFechaEntregado";
            this.lblFechaEntregado.Size = new System.Drawing.Size(65, 13);
            this.lblFechaEntregado.TabIndex = 10;
            this.lblFechaEntregado.Text = "23/05/2010";
            this.lblFechaEntregado.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.Location = new System.Drawing.Point(631, 531);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(67, 23);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblFechaCancelado
            // 
            this.lblFechaCancelado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaCancelado.AutoSize = true;
            this.lblFechaCancelado.Location = new System.Drawing.Point(612, 38);
            this.lblFechaCancelado.Name = "lblFechaCancelado";
            this.lblFechaCancelado.Size = new System.Drawing.Size(65, 13);
            this.lblFechaCancelado.TabIndex = 13;
            this.lblFechaCancelado.Text = "23/06/2010";
            this.lblFechaCancelado.Visible = false;
            // 
            // lblTituloFechaCancelado
            // 
            this.lblTituloFechaCancelado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloFechaCancelado.AutoSize = true;
            this.lblTituloFechaCancelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFechaCancelado.Location = new System.Drawing.Point(498, 38);
            this.lblTituloFechaCancelado.Name = "lblTituloFechaCancelado";
            this.lblTituloFechaCancelado.Size = new System.Drawing.Size(110, 13);
            this.lblTituloFechaCancelado.TabIndex = 12;
            this.lblTituloFechaCancelado.Text = "Fecha Cancelado:";
            this.lblTituloFechaCancelado.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(612, 15);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 13);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.Text = "Pendiente";
            // 
            // lblTituloEstado
            // 
            this.lblTituloEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloEstado.AutoSize = true;
            this.lblTituloEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEstado.Location = new System.Drawing.Point(558, 15);
            this.lblTituloEstado.Name = "lblTituloEstado";
            this.lblTituloEstado.Size = new System.Drawing.Size(50, 13);
            this.lblTituloEstado.TabIndex = 14;
            this.lblTituloEstado.Text = "Estado:";
            // 
            // frmDetallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 566);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTituloEstado);
            this.Controls.Add(this.lblFechaCancelado);
            this.Controls.Add(this.lblTituloFechaCancelado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblFechaEntregado);
            this.Controls.Add(this.lblTituloFechaEntregado);
            this.Controls.Add(this.btnGuardarComoPedidoEntregado);
            this.Controls.Add(this.gbxDatosDelPago);
            this.Controls.Add(this.dgvListadoLibros);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblTituloProveedor);
            this.Controls.Add(this.lblFechaPedido);
            this.Controls.Add(this.lblTituloFechaPedido);
            this.Controls.Add(this.lblNroPedido);
            this.Controls.Add(this.lblTituloNroPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDetallePedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalles del Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLibros)).EndInit();
            this.gbxDatosDelPago.ResumeLayout(false);
            this.gbxDatosDelPago.PerformLayout();
            this.gbxFechaPresentacionCheque.ResumeLayout(false);
            this.gbxFechaPresentacionCheque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasCredito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloNroPedido;
        private System.Windows.Forms.Label lblNroPedido;
        private System.Windows.Forms.Label lblFechaPedido;
        private System.Windows.Forms.Label lblTituloFechaPedido;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblTituloProveedor;
        private System.Windows.Forms.DataGridView dgvListadoLibros;
        private System.Windows.Forms.GroupBox gbxDatosDelPago;
        private System.Windows.Forms.DataGridView dgvNotasCredito;
        private System.Windows.Forms.Button btnAgregarNC;
        private System.Windows.Forms.Label lblMontoCompra;
        private System.Windows.Forms.Label lblNroCheque;
        private System.Windows.Forms.Label lblMontoCheque;
        private System.Windows.Forms.Label lblFechaVencCheque;
        private System.Windows.Forms.TextBox tbxNroCheque;
        private System.Windows.Forms.TextBox tbxMontoCheque;
        private System.Windows.Forms.TextBox tbxMontoCompra;
        private System.Windows.Forms.Label lblTotalNC;
        private System.Windows.Forms.TextBox tbxTotalNC;
        private System.Windows.Forms.Button btnEliminarNC;
        private System.Windows.Forms.Button btnGuardarComoPedidoEntregado;
        private System.Windows.Forms.Label lblTituloFechaEntregado;
        private System.Windows.Forms.Label lblFechaEntregado;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblFechaCancelado;
        private System.Windows.Forms.Label lblTituloFechaCancelado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTituloEstado;
        private System.Windows.Forms.TextBox tbxFechaPresentacionCheque;
        private System.Windows.Forms.GroupBox gbxFechaPresentacionCheque;
        private System.Windows.Forms.RadioButton rbt60Dias;
        private System.Windows.Forms.RadioButton rbt30Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdNc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontoAUtilizar;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.TextBox tbxBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTituloLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantPedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantAceptada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdColec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod_Colec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo_Colec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdLineaPedido;
    }
}