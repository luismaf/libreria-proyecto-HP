namespace HP.Presentacion
{
    partial class frmBuscarInfoLibros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblColeccion = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblTituloLibro = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblEdadMinima = new System.Windows.Forms.Label();
            this.lblPrecioHasta = new System.Windows.Forms.Label();
            this.gbxDatosBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbxEdadMinima = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.tbxPrecioHasta = new System.Windows.Forms.TextBox();
            this.tbxPrecioDesde = new System.Windows.Forms.TextBox();
            this.tbxTituloLibro = new System.Windows.Forms.TextBox();
            this.tbxIsbn = new System.Windows.Forms.TextBox();
            this.tbxColeccion = new System.Windows.Forms.TextBox();
            this.dgvListadoLibros = new System.Windows.Forms.DataGridView();
            this.colIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColeccion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colTituloLibro = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdadMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbxDatosBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(6, 22);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(67, 13);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblColeccion
            // 
            this.lblColeccion.AutoSize = true;
            this.lblColeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColeccion.Location = new System.Drawing.Point(6, 62);
            this.lblColeccion.Name = "lblColeccion";
            this.lblColeccion.Size = new System.Drawing.Size(67, 13);
            this.lblColeccion.TabIndex = 1;
            this.lblColeccion.Text = "Colección:";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsbn.Location = new System.Drawing.Point(6, 101);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(40, 13);
            this.lblIsbn.TabIndex = 2;
            this.lblIsbn.Text = "ISBN:";
            // 
            // lblTituloLibro
            // 
            this.lblTituloLibro.AutoSize = true;
            this.lblTituloLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLibro.Location = new System.Drawing.Point(6, 140);
            this.lblTituloLibro.Name = "lblTituloLibro";
            this.lblTituloLibro.Size = new System.Drawing.Size(77, 13);
            this.lblTituloLibro.TabIndex = 3;
            this.lblTituloLibro.Text = "Título Libro:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(6, 179);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(47, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblEdadMinima
            // 
            this.lblEdadMinima.AutoSize = true;
            this.lblEdadMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadMinima.Location = new System.Drawing.Point(6, 218);
            this.lblEdadMinima.Name = "lblEdadMinima";
            this.lblEdadMinima.Size = new System.Drawing.Size(85, 13);
            this.lblEdadMinima.TabIndex = 5;
            this.lblEdadMinima.Text = "Edad Mínima:";
            // 
            // lblPrecioHasta
            // 
            this.lblPrecioHasta.AutoSize = true;
            this.lblPrecioHasta.Location = new System.Drawing.Point(52, 198);
            this.lblPrecioHasta.Name = "lblPrecioHasta";
            this.lblPrecioHasta.Size = new System.Drawing.Size(36, 13);
            this.lblPrecioHasta.TabIndex = 6;
            this.lblPrecioHasta.Text = "hasta:";
            // 
            // gbxDatosBusqueda
            // 
            this.gbxDatosBusqueda.Controls.Add(this.btnBuscar);
            this.gbxDatosBusqueda.Controls.Add(this.cbxEdadMinima);
            this.gbxDatosBusqueda.Controls.Add(this.cbxCategoria);
            this.gbxDatosBusqueda.Controls.Add(this.tbxPrecioHasta);
            this.gbxDatosBusqueda.Controls.Add(this.tbxPrecioDesde);
            this.gbxDatosBusqueda.Controls.Add(this.tbxTituloLibro);
            this.gbxDatosBusqueda.Controls.Add(this.lblPrecioHasta);
            this.gbxDatosBusqueda.Controls.Add(this.tbxIsbn);
            this.gbxDatosBusqueda.Controls.Add(this.lblEdadMinima);
            this.gbxDatosBusqueda.Controls.Add(this.tbxColeccion);
            this.gbxDatosBusqueda.Controls.Add(this.lblPrecio);
            this.gbxDatosBusqueda.Controls.Add(this.lblCategoria);
            this.gbxDatosBusqueda.Controls.Add(this.lblTituloLibro);
            this.gbxDatosBusqueda.Controls.Add(this.lblIsbn);
            this.gbxDatosBusqueda.Controls.Add(this.lblColeccion);
            this.gbxDatosBusqueda.Location = new System.Drawing.Point(12, 12);
            this.gbxDatosBusqueda.Name = "gbxDatosBusqueda";
            this.gbxDatosBusqueda.Size = new System.Drawing.Size(142, 290);
            this.gbxDatosBusqueda.TabIndex = 10;
            this.gbxDatosBusqueda.TabStop = false;
            this.gbxDatosBusqueda.Text = "Datos de la Búsqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(30, 261);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cbxEdadMinima
            // 
            this.cbxEdadMinima.FormattingEnabled = true;
            this.cbxEdadMinima.Location = new System.Drawing.Point(6, 234);
            this.cbxEdadMinima.Name = "cbxEdadMinima";
            this.cbxEdadMinima.Size = new System.Drawing.Size(130, 21);
            this.cbxEdadMinima.TabIndex = 6;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(6, 38);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(130, 21);
            this.cbxCategoria.TabIndex = 0;
            // 
            // tbxPrecioHasta
            // 
            this.tbxPrecioHasta.Location = new System.Drawing.Point(96, 195);
            this.tbxPrecioHasta.Name = "tbxPrecioHasta";
            this.tbxPrecioHasta.Size = new System.Drawing.Size(40, 20);
            this.tbxPrecioHasta.TabIndex = 5;
            // 
            // tbxPrecioDesde
            // 
            this.tbxPrecioDesde.Location = new System.Drawing.Point(6, 195);
            this.tbxPrecioDesde.Name = "tbxPrecioDesde";
            this.tbxPrecioDesde.Size = new System.Drawing.Size(40, 20);
            this.tbxPrecioDesde.TabIndex = 4;
            // 
            // tbxTituloLibro
            // 
            this.tbxTituloLibro.Location = new System.Drawing.Point(6, 156);
            this.tbxTituloLibro.Name = "tbxTituloLibro";
            this.tbxTituloLibro.Size = new System.Drawing.Size(130, 20);
            this.tbxTituloLibro.TabIndex = 3;
            // 
            // tbxIsbn
            // 
            this.tbxIsbn.Location = new System.Drawing.Point(6, 117);
            this.tbxIsbn.Name = "tbxIsbn";
            this.tbxIsbn.Size = new System.Drawing.Size(130, 20);
            this.tbxIsbn.TabIndex = 2;
            // 
            // tbxColeccion
            // 
            this.tbxColeccion.Location = new System.Drawing.Point(6, 78);
            this.tbxColeccion.Name = "tbxColeccion";
            this.tbxColeccion.Size = new System.Drawing.Size(130, 20);
            this.tbxColeccion.TabIndex = 1;
            // 
            // dgvListadoLibros
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvListadoLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListadoLibros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListadoLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIsbn,
            this.colCategoria,
            this.colColeccion,
            this.colTituloLibro,
            this.colPrecio,
            this.colEdadMinima,
            this.colStockActual});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoLibros.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListadoLibros.Location = new System.Drawing.Point(160, 17);
            this.dgvListadoLibros.Name = "dgvListadoLibros";
            this.dgvListadoLibros.Size = new System.Drawing.Size(727, 285);
            this.dgvListadoLibros.TabIndex = 8;
            this.dgvListadoLibros.TabStop = false;
            // 
            // colIsbn
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIsbn.DefaultCellStyle = dataGridViewCellStyle9;
            this.colIsbn.HeaderText = "ISBN";
            this.colIsbn.Name = "colIsbn";
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.Name = "colCategoria";
            // 
            // colColeccion
            // 
            this.colColeccion.ActiveLinkColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colColeccion.DefaultCellStyle = dataGridViewCellStyle10;
            this.colColeccion.HeaderText = "Colección";
            this.colColeccion.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colColeccion.LinkColor = System.Drawing.Color.Black;
            this.colColeccion.Name = "colColeccion";
            this.colColeccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colColeccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colColeccion.Text = "";
            this.colColeccion.TrackVisitedState = false;
            this.colColeccion.UseColumnTextForLinkValue = true;
            this.colColeccion.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // colTituloLibro
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colTituloLibro.DefaultCellStyle = dataGridViewCellStyle11;
            this.colTituloLibro.HeaderText = "Titulo Libro";
            this.colTituloLibro.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colTituloLibro.LinkColor = System.Drawing.Color.Black;
            this.colTituloLibro.Name = "colTituloLibro";
            this.colTituloLibro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTituloLibro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTituloLibro.TrackVisitedState = false;
            this.colTituloLibro.UseColumnTextForLinkValue = true;
            this.colTituloLibro.VisitedLinkColor = System.Drawing.Color.Black;
            this.colTituloLibro.Width = 150;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Width = 50;
            // 
            // colEdadMinima
            // 
            this.colEdadMinima.HeaderText = "Edad Mínima";
            this.colEdadMinima.Name = "colEdadMinima";
            this.colEdadMinima.Width = 108;
            // 
            // colStockActual
            // 
            this.colStockActual.HeaderText = "Stock";
            this.colStockActual.Name = "colStockActual";
            this.colStockActual.Width = 50;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(812, 308);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmBuscarInfoLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 337);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvListadoLibros);
            this.Controls.Add(this.gbxDatosBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBuscarInfoLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Información Sobre Libros, Colecciones o Categorías";
            this.gbxDatosBusqueda.ResumeLayout(false);
            this.gbxDatosBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblColeccion;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblTituloLibro;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblEdadMinima;
        private System.Windows.Forms.Label lblPrecioHasta;
        private System.Windows.Forms.GroupBox gbxDatosBusqueda;
        private System.Windows.Forms.TextBox tbxPrecioDesde;
        private System.Windows.Forms.TextBox tbxTituloLibro;
        private System.Windows.Forms.TextBox tbxIsbn;
        private System.Windows.Forms.TextBox tbxColeccion;
        private System.Windows.Forms.TextBox tbxPrecioHasta;
        private System.Windows.Forms.ComboBox cbxEdadMinima;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvListadoLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewLinkColumn colColeccion;
        private System.Windows.Forms.DataGridViewLinkColumn colTituloLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEdadMinima;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockActual;
        private System.Windows.Forms.Button btnVolver;
    }
}

