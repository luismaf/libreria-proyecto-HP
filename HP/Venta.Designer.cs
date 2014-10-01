namespace HP.Presentacion
{
    partial class frmVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTituloFecha = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dgvListadoLibros = new System.Windows.Forms.DataGridView();
            this.colQuitar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTituloLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxFormaDePago = new System.Windows.Forms.GroupBox();
            this.rdbTarjetaDebito = new System.Windows.Forms.RadioButton();
            this.rdbTarjetaCredito = new System.Windows.Forms.RadioButton();
            this.rdbEfectivo = new System.Windows.Forms.RadioButton();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.tbxTotalAPagar = new System.Windows.Forms.TextBox();
            this.tbxSubtotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.tbxDtoNC = new System.Windows.Forms.TextBox();
            this.lblDtoNC = new System.Windows.Forms.Label();
            this.tbxDtoPromocional = new System.Windows.Forms.TextBox();
            this.lblDtoPromocional = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.tbxIsbn = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.lklConsultarInformacionLibros = new System.Windows.Forms.LinkLabel();
            this.tbxCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLibros)).BeginInit();
            this.gbxFormaDePago.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloFecha
            // 
            this.lblTituloFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloFecha.AutoSize = true;
            this.lblTituloFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFecha.Location = new System.Drawing.Point(595, 9);
            this.lblTituloFecha.Name = "lblTituloFecha";
            this.lblTituloFecha.Size = new System.Drawing.Size(46, 13);
            this.lblTituloFecha.TabIndex = 2;
            this.lblTituloFecha.Text = "Fecha:";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(647, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "26/10/2009";
            // 
            // dgvListadoLibros
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvListadoLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListadoLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListadoLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQuitar,
            this.colIsbn,
            this.colTituloLibro,
            this.colCantidad,
            this.colPrecioUnitario,
            this.colSubtotal});
            this.dgvListadoLibros.Location = new System.Drawing.Point(12, 37);
            this.dgvListadoLibros.Name = "dgvListadoLibros";
            this.dgvListadoLibros.Size = new System.Drawing.Size(700, 131);
            this.dgvListadoLibros.TabIndex = 4;
            // 
            // colQuitar
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle11.NullValue = "X";
            this.colQuitar.DefaultCellStyle = dataGridViewCellStyle11;
            this.colQuitar.HeaderText = "Quitar";
            this.colQuitar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colQuitar.LinkColor = System.Drawing.Color.Red;
            this.colQuitar.Name = "colQuitar";
            this.colQuitar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colQuitar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colQuitar.TrackVisitedState = false;
            this.colQuitar.VisitedLinkColor = System.Drawing.Color.Blue;
            this.colQuitar.Width = 50;
            // 
            // colIsbn
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colIsbn.DefaultCellStyle = dataGridViewCellStyle12;
            this.colIsbn.HeaderText = "ISBN";
            this.colIsbn.Name = "colIsbn";
            // 
            // colTituloLibro
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colTituloLibro.DefaultCellStyle = dataGridViewCellStyle13;
            this.colTituloLibro.HeaderText = "Título Libro";
            this.colTituloLibro.Name = "colTituloLibro";
            this.colTituloLibro.Width = 200;
            // 
            // colCantidad
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colCantidad.DefaultCellStyle = dataGridViewCellStyle14;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Width = 70;
            // 
            // colPrecioUnitario
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colPrecioUnitario.DefaultCellStyle = dataGridViewCellStyle15;
            this.colPrecioUnitario.HeaderText = "Precio Unitario";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.Width = 116;
            // 
            // colSubtotal
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colSubtotal.DefaultCellStyle = dataGridViewCellStyle16;
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            // 
            // gbxFormaDePago
            // 
            this.gbxFormaDePago.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbxFormaDePago.Controls.Add(this.rdbTarjetaDebito);
            this.gbxFormaDePago.Controls.Add(this.rdbTarjetaCredito);
            this.gbxFormaDePago.Controls.Add(this.rdbEfectivo);
            this.gbxFormaDePago.Location = new System.Drawing.Point(12, 235);
            this.gbxFormaDePago.Name = "gbxFormaDePago";
            this.gbxFormaDePago.Size = new System.Drawing.Size(120, 90);
            this.gbxFormaDePago.TabIndex = 5;
            this.gbxFormaDePago.TabStop = false;
            this.gbxFormaDePago.Text = "Forma de Pago";
            // 
            // rdbTarjetaDebito
            // 
            this.rdbTarjetaDebito.AutoSize = true;
            this.rdbTarjetaDebito.Location = new System.Drawing.Point(6, 65);
            this.rdbTarjetaDebito.Name = "rdbTarjetaDebito";
            this.rdbTarjetaDebito.Size = new System.Drawing.Size(107, 17);
            this.rdbTarjetaDebito.TabIndex = 2;
            this.rdbTarjetaDebito.Text = "Tarjeta de Débito";
            this.rdbTarjetaDebito.UseVisualStyleBackColor = true;
            // 
            // rdbTarjetaCredito
            // 
            this.rdbTarjetaCredito.AutoSize = true;
            this.rdbTarjetaCredito.Location = new System.Drawing.Point(5, 42);
            this.rdbTarjetaCredito.Name = "rdbTarjetaCredito";
            this.rdbTarjetaCredito.Size = new System.Drawing.Size(109, 17);
            this.rdbTarjetaCredito.TabIndex = 1;
            this.rdbTarjetaCredito.Text = "Tarjeta de Crédito";
            this.rdbTarjetaCredito.UseVisualStyleBackColor = true;
            // 
            // rdbEfectivo
            // 
            this.rdbEfectivo.AutoSize = true;
            this.rdbEfectivo.Checked = true;
            this.rdbEfectivo.Location = new System.Drawing.Point(6, 19);
            this.rdbEfectivo.Name = "rdbEfectivo";
            this.rdbEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rdbEfectivo.TabIndex = 0;
            this.rdbEfectivo.TabStop = true;
            this.rdbEfectivo.Text = "Efectivo";
            this.rdbEfectivo.UseVisualStyleBackColor = true;
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAPagar.Location = new System.Drawing.Point(537, 258);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(88, 13);
            this.lblTotalAPagar.TabIndex = 7;
            this.lblTotalAPagar.Text = "Total a Pagar:";
            // 
            // tbxTotalAPagar
            // 
            this.tbxTotalAPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTotalAPagar.Location = new System.Drawing.Point(631, 255);
            this.tbxTotalAPagar.Name = "tbxTotalAPagar";
            this.tbxTotalAPagar.ReadOnly = true;
            this.tbxTotalAPagar.Size = new System.Drawing.Size(62, 20);
            this.tbxTotalAPagar.TabIndex = 8;
            this.tbxTotalAPagar.Text = "$ 122,93";
            this.tbxTotalAPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxSubtotal
            // 
            this.tbxSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSubtotal.Location = new System.Drawing.Point(631, 177);
            this.tbxSubtotal.Name = "tbxSubtotal";
            this.tbxSubtotal.ReadOnly = true;
            this.tbxSubtotal.Size = new System.Drawing.Size(62, 20);
            this.tbxSubtotal.TabIndex = 10;
            this.tbxSubtotal.Text = "$ 210,50";
            this.tbxSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(576, 180);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // tbxDtoNC
            // 
            this.tbxDtoNC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDtoNC.Location = new System.Drawing.Point(631, 229);
            this.tbxDtoNC.Name = "tbxDtoNC";
            this.tbxDtoNC.Size = new System.Drawing.Size(62, 20);
            this.tbxDtoNC.TabIndex = 12;
            this.tbxDtoNC.Text = "$ 50";
            this.tbxDtoNC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDtoNC
            // 
            this.lblDtoNC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDtoNC.AutoSize = true;
            this.lblDtoNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtoNC.Location = new System.Drawing.Point(528, 232);
            this.lblDtoNC.Name = "lblDtoNC";
            this.lblDtoNC.Size = new System.Drawing.Size(97, 13);
            this.lblDtoNC.TabIndex = 11;
            this.lblDtoNC.Text = "Dto. Notas Crédito:";
            // 
            // tbxDtoPromocional
            // 
            this.tbxDtoPromocional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDtoPromocional.Location = new System.Drawing.Point(631, 203);
            this.tbxDtoPromocional.Name = "tbxDtoPromocional";
            this.tbxDtoPromocional.ReadOnly = true;
            this.tbxDtoPromocional.Size = new System.Drawing.Size(62, 20);
            this.tbxDtoPromocional.TabIndex = 14;
            this.tbxDtoPromocional.Text = "$ 31,57";
            this.tbxDtoPromocional.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDtoPromocional
            // 
            this.lblDtoPromocional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDtoPromocional.AutoSize = true;
            this.lblDtoPromocional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtoPromocional.Location = new System.Drawing.Point(534, 206);
            this.lblDtoPromocional.Name = "lblDtoPromocional";
            this.lblDtoPromocional.Size = new System.Drawing.Size(91, 13);
            this.lblDtoPromocional.TabIndex = 13;
            this.lblDtoPromocional.Text = "Dto. Promocional:";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsbn.Location = new System.Drawing.Point(9, 177);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(40, 13);
            this.lblIsbn.TabIndex = 15;
            this.lblIsbn.Text = "ISBN:";
            // 
            // tbxIsbn
            // 
            this.tbxIsbn.Location = new System.Drawing.Point(55, 174);
            this.tbxIsbn.Name = "tbxIsbn";
            this.tbxIsbn.Size = new System.Drawing.Size(100, 20);
            this.tbxIsbn.TabIndex = 16;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(161, 171);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarVenta.Location = new System.Drawing.Point(531, 325);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(90, 23);
            this.btnRegistrarVenta.TabIndex = 19;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // lklConsultarInformacionLibros
            // 
            this.lklConsultarInformacionLibros.AutoSize = true;
            this.lklConsultarInformacionLibros.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lklConsultarInformacionLibros.Location = new System.Drawing.Point(12, 9);
            this.lklConsultarInformacionLibros.Name = "lklConsultarInformacionLibros";
            this.lklConsultarInformacionLibros.Size = new System.Drawing.Size(171, 13);
            this.lklConsultarInformacionLibros.TabIndex = 20;
            this.lklConsultarInformacionLibros.TabStop = true;
            this.lklConsultarInformacionLibros.Text = "Consultar Información Sobre Libros";
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.Location = new System.Drawing.Point(76, 200);
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.Size = new System.Drawing.Size(79, 20);
            this.tbxCantidad.TabIndex = 22;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(9, 203);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 13);
            this.lblCantidad.TabIndex = 21;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.Location = new System.Drawing.Point(650, 325);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(62, 23);
            this.btnVolver.TabIndex = 23;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 360);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tbxCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lklConsultarInformacionLibros);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbxIsbn);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.tbxDtoPromocional);
            this.Controls.Add(this.lblDtoPromocional);
            this.Controls.Add(this.tbxDtoNC);
            this.Controls.Add(this.lblDtoNC);
            this.Controls.Add(this.tbxSubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.tbxTotalAPagar);
            this.Controls.Add(this.lblTotalAPagar);
            this.Controls.Add(this.gbxFormaDePago);
            this.Controls.Add(this.dgvListadoLibros);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTituloFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLibros)).EndInit();
            this.gbxFormaDePago.ResumeLayout(false);
            this.gbxFormaDePago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dgvListadoLibros;
        private System.Windows.Forms.GroupBox gbxFormaDePago;
        private System.Windows.Forms.RadioButton rdbTarjetaDebito;
        private System.Windows.Forms.RadioButton rdbTarjetaCredito;
        private System.Windows.Forms.RadioButton rdbEfectivo;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.TextBox tbxTotalAPagar;
        private System.Windows.Forms.TextBox tbxSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox tbxDtoNC;
        private System.Windows.Forms.Label lblDtoNC;
        private System.Windows.Forms.TextBox tbxDtoPromocional;
        private System.Windows.Forms.Label lblDtoPromocional;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.TextBox tbxIsbn;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.DataGridViewLinkColumn colQuitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTituloLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.LinkLabel lklConsultarInformacionLibros;
        private System.Windows.Forms.TextBox tbxCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnVolver;
    }
}