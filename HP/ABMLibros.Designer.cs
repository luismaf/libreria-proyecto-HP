namespace HP.Presentacion
{
    partial class frmABMLibros
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
            if (disposing && (components != null) && (cbxCategoria.Items.Count != 0))
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
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxColeccion = new System.Windows.Forms.ComboBox();
            this.coleccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxLibro = new System.Windows.Forms.ComboBox();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lklCategoriaAgregar = new System.Windows.Forms.LinkLabel();
            this.lklColeccionAgregar = new System.Windows.Forms.LinkLabel();
            this.lklLibroAgregar = new System.Windows.Forms.LinkLabel();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblColeccion = new System.Windows.Forms.Label();
            this.lblLibro = new System.Windows.Forms.Label();
            this.tbcABMLibros = new System.Windows.Forms.TabControl();
            this.tbpCategoria = new System.Windows.Forms.TabPage();
            this.btnCategoriaGuardar = new System.Windows.Forms.Button();
            this.btnCategoriaCancelar = new System.Windows.Forms.Button();
            this.lblCategoriaNombre = new System.Windows.Forms.Label();
            this.tbxCategoriaNombre = new System.Windows.Forms.TextBox();
            this.tbpColeccion = new System.Windows.Forms.TabPage();
            this.tbxColeccionPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblColeccionPrecioVenta = new System.Windows.Forms.Label();
            this.cbxColeccionProveedor = new System.Windows.Forms.ComboBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnColeccionGuardar = new System.Windows.Forms.Button();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.tbxColeccionProveedor = new System.Windows.Forms.TextBox();
            this.btnColeccionCancelar = new System.Windows.Forms.Button();
            this.tbxColeccionDescripcion = new System.Windows.Forms.TextBox();
            this.tbxColeccionCantPaginas = new System.Windows.Forms.TextBox();
            this.tbxColeccionEncuadernacion = new System.Windows.Forms.TextBox();
            this.tbxColeccionEdadSugerida = new System.Windows.Forms.TextBox();
            this.tbxColeccionPrecioCompra = new System.Windows.Forms.TextBox();
            this.tbxColeccionTamano = new System.Windows.Forms.TextBox();
            this.tbxColeccionTitulo = new System.Windows.Forms.TextBox();
            this.tbxColeccionCodigo = new System.Windows.Forms.TextBox();
            this.lblColeccionDescripcion = new System.Windows.Forms.Label();
            this.lblColeccionCantPaginas = new System.Windows.Forms.Label();
            this.lblColeccionEdadSugerida = new System.Windows.Forms.Label();
            this.lblColeccionPrecioCompra = new System.Windows.Forms.Label();
            this.lblColeccionEncuadernacion = new System.Windows.Forms.Label();
            this.lblColeccionTamano = new System.Windows.Forms.Label();
            this.lblColeccionTitulo = new System.Windows.Forms.Label();
            this.lblColeccionCodigo = new System.Windows.Forms.Label();
            this.tbpLibro = new System.Windows.Forms.TabPage();
            this.btnLibroGuardar = new System.Windows.Forms.Button();
            this.tbxLibroResena = new System.Windows.Forms.TextBox();
            this.lblLibroResena = new System.Windows.Forms.Label();
            this.tbxLibroIsbn = new System.Windows.Forms.TextBox();
            this.tbxLibroTitulo = new System.Windows.Forms.TextBox();
            this.btnLibroCancelar = new System.Windows.Forms.Button();
            this.tbxLibroStockActual = new System.Windows.Forms.TextBox();
            this.tbxLibroStockDeseable = new System.Windows.Forms.TextBox();
            this.lblLibroStockActual = new System.Windows.Forms.Label();
            this.lblLibroStockDeseable = new System.Windows.Forms.Label();
            this.lblLibroStockMinimo = new System.Windows.Forms.Label();
            this.lblLibroTitulo = new System.Windows.Forms.Label();
            this.lblLibroIsbn = new System.Windows.Forms.Label();
            this.tbxLibroStockMinimo = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lklCategoriaEditar = new System.Windows.Forms.LinkLabel();
            this.lklColeccionEditar = new System.Windows.Forms.LinkLabel();
            this.lklLibroEditar = new System.Windows.Forms.LinkLabel();
            this.lklCategoriaDeshabilitar = new System.Windows.Forms.LinkLabel();
            this.lklColeccionDeshabilitar = new System.Windows.Forms.LinkLabel();
            this.lklLibroDeshabilitar = new System.Windows.Forms.LinkLabel();
            this.lklVerElementosDeshabilitados = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coleccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            this.tbcABMLibros.SuspendLayout();
            this.tbpCategoria.SuspendLayout();
            this.tbpColeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            this.tbpLibro.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoriasBindingSource, "Id_categ", true));
            this.cbxCategoria.DataSource = this.categoriasBindingSource;
            this.cbxCategoria.DisplayMember = "Nombre_categ";
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(15, 32);
            this.cbxCategoria.MaxDropDownItems = 10;
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoria.TabIndex = 1;
            this.cbxCategoria.ValueMember = "Id_categ";
            this.cbxCategoria.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria_SelectedIndexChanged);
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataSource = typeof(HP.Entidades.Categorias);
            // 
            // cbxColeccion
            // 
            this.cbxColeccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxColeccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxColeccion.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.coleccionesBindingSource, "Id_colec", true));
            this.cbxColeccion.DataSource = this.coleccionesBindingSource;
            this.cbxColeccion.DisplayMember = "Titulo_colec";
            this.cbxColeccion.FormattingEnabled = true;
            this.cbxColeccion.Location = new System.Drawing.Point(186, 32);
            this.cbxColeccion.MaxDropDownItems = 10;
            this.cbxColeccion.Name = "cbxColeccion";
            this.cbxColeccion.Size = new System.Drawing.Size(121, 21);
            this.cbxColeccion.TabIndex = 2;
            this.cbxColeccion.ValueMember = "Id_colec";
            this.cbxColeccion.SelectedIndexChanged += new System.EventHandler(this.cbxColeccion_SelectedIndexChanged);
            // 
            // coleccionesBindingSource
            // 
            this.coleccionesBindingSource.DataSource = typeof(HP.Entidades.Colecciones);
            // 
            // cbxLibro
            // 
            this.cbxLibro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxLibro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxLibro.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.librosBindingSource, "Id_libro", true));
            this.cbxLibro.DataSource = this.librosBindingSource;
            this.cbxLibro.DisplayMember = "Titulo_libro";
            this.cbxLibro.FormattingEnabled = true;
            this.cbxLibro.Location = new System.Drawing.Point(354, 32);
            this.cbxLibro.MaxDropDownItems = 10;
            this.cbxLibro.Name = "cbxLibro";
            this.cbxLibro.Size = new System.Drawing.Size(121, 21);
            this.cbxLibro.TabIndex = 3;
            this.cbxLibro.ValueMember = "Id_libro";
            this.cbxLibro.SelectedIndexChanged += new System.EventHandler(this.cbxLibro_SelectedIndexChanged);
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataSource = typeof(HP.Entidades.Libros);
            // 
            // lklCategoriaAgregar
            // 
            this.lklCategoriaAgregar.AutoSize = true;
            this.lklCategoriaAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklCategoriaAgregar.Location = new System.Drawing.Point(12, 56);
            this.lklCategoriaAgregar.Name = "lklCategoriaAgregar";
            this.lklCategoriaAgregar.Size = new System.Drawing.Size(106, 13);
            this.lklCategoriaAgregar.TabIndex = 4;
            this.lklCategoriaAgregar.TabStop = true;
            this.lklCategoriaAgregar.Text = "<Agregar Categoría>";
            this.lklCategoriaAgregar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklCategoriaAgregar_LinkClicked);
            // 
            // lklColeccionAgregar
            // 
            this.lklColeccionAgregar.AutoSize = true;
            this.lklColeccionAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklColeccionAgregar.Location = new System.Drawing.Point(183, 56);
            this.lklColeccionAgregar.Name = "lklColeccionAgregar";
            this.lklColeccionAgregar.Size = new System.Drawing.Size(106, 13);
            this.lklColeccionAgregar.TabIndex = 7;
            this.lklColeccionAgregar.TabStop = true;
            this.lklColeccionAgregar.Text = "<Agregar Colección>";
            this.lklColeccionAgregar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklColeccionAgregar_LinkClicked);
            // 
            // lklLibroAgregar
            // 
            this.lklLibroAgregar.AutoSize = true;
            this.lklLibroAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklLibroAgregar.Location = new System.Drawing.Point(351, 56);
            this.lklLibroAgregar.Name = "lklLibroAgregar";
            this.lklLibroAgregar.Size = new System.Drawing.Size(82, 13);
            this.lklLibroAgregar.TabIndex = 10;
            this.lklLibroAgregar.TabStop = true;
            this.lklLibroAgregar.Text = "<Agregar Libro>";
            this.lklLibroAgregar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklLibroAgregar_LinkClicked);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(12, 16);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(67, 13);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblColeccion
            // 
            this.lblColeccion.AutoSize = true;
            this.lblColeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColeccion.Location = new System.Drawing.Point(183, 16);
            this.lblColeccion.Name = "lblColeccion";
            this.lblColeccion.Size = new System.Drawing.Size(67, 13);
            this.lblColeccion.TabIndex = 7;
            this.lblColeccion.Text = "Colección:";
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibro.Location = new System.Drawing.Point(351, 16);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(39, 13);
            this.lblLibro.TabIndex = 8;
            this.lblLibro.Text = "Libro:";
            // 
            // tbcABMLibros
            // 
            this.tbcABMLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcABMLibros.Controls.Add(this.tbpCategoria);
            this.tbcABMLibros.Controls.Add(this.tbpColeccion);
            this.tbcABMLibros.Controls.Add(this.tbpLibro);
            this.tbcABMLibros.HotTrack = true;
            this.tbcABMLibros.Location = new System.Drawing.Point(15, 128);
            this.tbcABMLibros.Name = "tbcABMLibros";
            this.tbcABMLibros.SelectedIndex = 0;
            this.tbcABMLibros.Size = new System.Drawing.Size(460, 285);
            this.tbcABMLibros.TabIndex = 13;
            // 
            // tbpCategoria
            // 
            this.tbpCategoria.Controls.Add(this.btnCategoriaGuardar);
            this.tbpCategoria.Controls.Add(this.btnCategoriaCancelar);
            this.tbpCategoria.Controls.Add(this.lblCategoriaNombre);
            this.tbpCategoria.Controls.Add(this.tbxCategoriaNombre);
            this.tbpCategoria.Location = new System.Drawing.Point(4, 22);
            this.tbpCategoria.Name = "tbpCategoria";
            this.tbpCategoria.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCategoria.Size = new System.Drawing.Size(452, 259);
            this.tbpCategoria.TabIndex = 0;
            this.tbpCategoria.Text = "Categoría";
            this.tbpCategoria.UseVisualStyleBackColor = true;
            // 
            // btnCategoriaGuardar
            // 
            this.btnCategoriaGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCategoriaGuardar.Enabled = false;
            this.btnCategoriaGuardar.Location = new System.Drawing.Point(267, 230);
            this.btnCategoriaGuardar.Name = "btnCategoriaGuardar";
            this.btnCategoriaGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnCategoriaGuardar.TabIndex = 2;
            this.btnCategoriaGuardar.Text = "Guardar";
            this.btnCategoriaGuardar.UseVisualStyleBackColor = true;
            this.btnCategoriaGuardar.Click += new System.EventHandler(this.btnCategoriaGuardar_Click);
            // 
            // btnCategoriaCancelar
            // 
            this.btnCategoriaCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCategoriaCancelar.Enabled = false;
            this.btnCategoriaCancelar.Location = new System.Drawing.Point(371, 230);
            this.btnCategoriaCancelar.Name = "btnCategoriaCancelar";
            this.btnCategoriaCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCategoriaCancelar.TabIndex = 3;
            this.btnCategoriaCancelar.Text = "Cancelar";
            this.btnCategoriaCancelar.UseVisualStyleBackColor = true;
            this.btnCategoriaCancelar.Click += new System.EventHandler(this.btnCategoriaCancelar_Click);
            // 
            // lblCategoriaNombre
            // 
            this.lblCategoriaNombre.AutoSize = true;
            this.lblCategoriaNombre.Location = new System.Drawing.Point(12, 22);
            this.lblCategoriaNombre.Name = "lblCategoriaNombre";
            this.lblCategoriaNombre.Size = new System.Drawing.Size(47, 13);
            this.lblCategoriaNombre.TabIndex = 3;
            this.lblCategoriaNombre.Text = "Nombre:";
            // 
            // tbxCategoriaNombre
            // 
            this.tbxCategoriaNombre.Location = new System.Drawing.Point(65, 19);
            this.tbxCategoriaNombre.Name = "tbxCategoriaNombre";
            this.tbxCategoriaNombre.ReadOnly = true;
            this.tbxCategoriaNombre.Size = new System.Drawing.Size(162, 20);
            this.tbxCategoriaNombre.TabIndex = 1;
            this.tbxCategoriaNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbpColeccion
            // 
            this.tbpColeccion.Controls.Add(this.tbxColeccionPrecioVenta);
            this.tbpColeccion.Controls.Add(this.lblColeccionPrecioVenta);
            this.tbpColeccion.Controls.Add(this.cbxColeccionProveedor);
            this.tbpColeccion.Controls.Add(this.btnColeccionGuardar);
            this.tbpColeccion.Controls.Add(this.lblProveedor);
            this.tbpColeccion.Controls.Add(this.tbxColeccionProveedor);
            this.tbpColeccion.Controls.Add(this.btnColeccionCancelar);
            this.tbpColeccion.Controls.Add(this.tbxColeccionDescripcion);
            this.tbpColeccion.Controls.Add(this.tbxColeccionCantPaginas);
            this.tbpColeccion.Controls.Add(this.tbxColeccionEncuadernacion);
            this.tbpColeccion.Controls.Add(this.tbxColeccionEdadSugerida);
            this.tbpColeccion.Controls.Add(this.tbxColeccionPrecioCompra);
            this.tbpColeccion.Controls.Add(this.tbxColeccionTamano);
            this.tbpColeccion.Controls.Add(this.tbxColeccionTitulo);
            this.tbpColeccion.Controls.Add(this.tbxColeccionCodigo);
            this.tbpColeccion.Controls.Add(this.lblColeccionDescripcion);
            this.tbpColeccion.Controls.Add(this.lblColeccionCantPaginas);
            this.tbpColeccion.Controls.Add(this.lblColeccionEdadSugerida);
            this.tbpColeccion.Controls.Add(this.lblColeccionPrecioCompra);
            this.tbpColeccion.Controls.Add(this.lblColeccionEncuadernacion);
            this.tbpColeccion.Controls.Add(this.lblColeccionTamano);
            this.tbpColeccion.Controls.Add(this.lblColeccionTitulo);
            this.tbpColeccion.Controls.Add(this.lblColeccionCodigo);
            this.tbpColeccion.Location = new System.Drawing.Point(4, 22);
            this.tbpColeccion.Name = "tbpColeccion";
            this.tbpColeccion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpColeccion.Size = new System.Drawing.Size(452, 259);
            this.tbpColeccion.TabIndex = 1;
            this.tbpColeccion.Text = "Colección";
            this.tbpColeccion.UseVisualStyleBackColor = true;
            // 
            // tbxColeccionPrecioVenta
            // 
            this.tbxColeccionPrecioVenta.Location = new System.Drawing.Point(100, 229);
            this.tbxColeccionPrecioVenta.Name = "tbxColeccionPrecioVenta";
            this.tbxColeccionPrecioVenta.ReadOnly = true;
            this.tbxColeccionPrecioVenta.Size = new System.Drawing.Size(120, 20);
            this.tbxColeccionPrecioVenta.TabIndex = 9;
            this.tbxColeccionPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblColeccionPrecioVenta
            // 
            this.lblColeccionPrecioVenta.AutoSize = true;
            this.lblColeccionPrecioVenta.Location = new System.Drawing.Point(8, 235);
            this.lblColeccionPrecioVenta.Name = "lblColeccionPrecioVenta";
            this.lblColeccionPrecioVenta.Size = new System.Drawing.Size(86, 13);
            this.lblColeccionPrecioVenta.TabIndex = 16;
            this.lblColeccionPrecioVenta.Text = "Precio de Venta:";
            // 
            // cbxColeccionProveedor
            // 
            this.cbxColeccionProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxColeccionProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxColeccionProveedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.proveedoresBindingSource, "Id_prov", true));
            this.cbxColeccionProveedor.DataSource = this.proveedoresBindingSource;
            this.cbxColeccionProveedor.DisplayMember = "Razon_social";
            this.cbxColeccionProveedor.FormattingEnabled = true;
            this.cbxColeccionProveedor.Location = new System.Drawing.Point(100, 70);
            this.cbxColeccionProveedor.MaxDropDownItems = 10;
            this.cbxColeccionProveedor.Name = "cbxColeccionProveedor";
            this.cbxColeccionProveedor.Size = new System.Drawing.Size(121, 21);
            this.cbxColeccionProveedor.TabIndex = 3;
            this.cbxColeccionProveedor.ValueMember = "Id_prov";
            this.cbxColeccionProveedor.Visible = false;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataSource = typeof(HP.Entidades.Proveedores);
            // 
            // btnColeccionGuardar
            // 
            this.btnColeccionGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColeccionGuardar.Enabled = false;
            this.btnColeccionGuardar.Location = new System.Drawing.Point(267, 230);
            this.btnColeccionGuardar.Name = "btnColeccionGuardar";
            this.btnColeccionGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnColeccionGuardar.TabIndex = 11;
            this.btnColeccionGuardar.Text = "Guardar";
            this.btnColeccionGuardar.UseVisualStyleBackColor = true;
            this.btnColeccionGuardar.Click += new System.EventHandler(this.btnColeccionGuardar_Click);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(30, 73);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(59, 13);
            this.lblProveedor.TabIndex = 15;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // tbxColeccionProveedor
            // 
            this.tbxColeccionProveedor.Location = new System.Drawing.Point(100, 70);
            this.tbxColeccionProveedor.Name = "tbxColeccionProveedor";
            this.tbxColeccionProveedor.ReadOnly = true;
            this.tbxColeccionProveedor.Size = new System.Drawing.Size(120, 20);
            this.tbxColeccionProveedor.TabIndex = 3;
            this.tbxColeccionProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnColeccionCancelar
            // 
            this.btnColeccionCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColeccionCancelar.Enabled = false;
            this.btnColeccionCancelar.Location = new System.Drawing.Point(371, 230);
            this.btnColeccionCancelar.Name = "btnColeccionCancelar";
            this.btnColeccionCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnColeccionCancelar.TabIndex = 12;
            this.btnColeccionCancelar.Text = "Cancelar";
            this.btnColeccionCancelar.UseVisualStyleBackColor = true;
            this.btnColeccionCancelar.Click += new System.EventHandler(this.btnColeccionCancelar_Click);
            // 
            // tbxColeccionDescripcion
            // 
            this.tbxColeccionDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxColeccionDescripcion.Location = new System.Drawing.Point(242, 34);
            this.tbxColeccionDescripcion.Multiline = true;
            this.tbxColeccionDescripcion.Name = "tbxColeccionDescripcion";
            this.tbxColeccionDescripcion.ReadOnly = true;
            this.tbxColeccionDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxColeccionDescripcion.Size = new System.Drawing.Size(204, 189);
            this.tbxColeccionDescripcion.TabIndex = 10;
            // 
            // tbxColeccionCantPaginas
            // 
            this.tbxColeccionCantPaginas.Location = new System.Drawing.Point(100, 177);
            this.tbxColeccionCantPaginas.Name = "tbxColeccionCantPaginas";
            this.tbxColeccionCantPaginas.ReadOnly = true;
            this.tbxColeccionCantPaginas.Size = new System.Drawing.Size(120, 20);
            this.tbxColeccionCantPaginas.TabIndex = 7;
            this.tbxColeccionCantPaginas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxColeccionEncuadernacion
            // 
            this.tbxColeccionEncuadernacion.Location = new System.Drawing.Point(100, 125);
            this.tbxColeccionEncuadernacion.Name = "tbxColeccionEncuadernacion";
            this.tbxColeccionEncuadernacion.ReadOnly = true;
            this.tbxColeccionEncuadernacion.Size = new System.Drawing.Size(120, 20);
            this.tbxColeccionEncuadernacion.TabIndex = 5;
            this.tbxColeccionEncuadernacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxColeccionEdadSugerida
            // 
            this.tbxColeccionEdadSugerida.Location = new System.Drawing.Point(100, 151);
            this.tbxColeccionEdadSugerida.Name = "tbxColeccionEdadSugerida";
            this.tbxColeccionEdadSugerida.ReadOnly = true;
            this.tbxColeccionEdadSugerida.Size = new System.Drawing.Size(120, 20);
            this.tbxColeccionEdadSugerida.TabIndex = 6;
            this.tbxColeccionEdadSugerida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxColeccionPrecioCompra
            // 
            this.tbxColeccionPrecioCompra.Location = new System.Drawing.Point(100, 203);
            this.tbxColeccionPrecioCompra.Name = "tbxColeccionPrecioCompra";
            this.tbxColeccionPrecioCompra.ReadOnly = true;
            this.tbxColeccionPrecioCompra.Size = new System.Drawing.Size(120, 20);
            this.tbxColeccionPrecioCompra.TabIndex = 8;
            this.tbxColeccionPrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxColeccionTamano
            // 
            this.tbxColeccionTamano.Location = new System.Drawing.Point(100, 96);
            this.tbxColeccionTamano.Name = "tbxColeccionTamano";
            this.tbxColeccionTamano.ReadOnly = true;
            this.tbxColeccionTamano.Size = new System.Drawing.Size(120, 20);
            this.tbxColeccionTamano.TabIndex = 4;
            this.tbxColeccionTamano.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxColeccionTitulo
            // 
            this.tbxColeccionTitulo.Location = new System.Drawing.Point(100, 44);
            this.tbxColeccionTitulo.Name = "tbxColeccionTitulo";
            this.tbxColeccionTitulo.ReadOnly = true;
            this.tbxColeccionTitulo.Size = new System.Drawing.Size(120, 20);
            this.tbxColeccionTitulo.TabIndex = 2;
            this.tbxColeccionTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxColeccionCodigo
            // 
            this.tbxColeccionCodigo.Location = new System.Drawing.Point(100, 18);
            this.tbxColeccionCodigo.Name = "tbxColeccionCodigo";
            this.tbxColeccionCodigo.ReadOnly = true;
            this.tbxColeccionCodigo.Size = new System.Drawing.Size(120, 20);
            this.tbxColeccionCodigo.TabIndex = 1;
            this.tbxColeccionCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblColeccionDescripcion
            // 
            this.lblColeccionDescripcion.AutoSize = true;
            this.lblColeccionDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColeccionDescripcion.Location = new System.Drawing.Point(239, 18);
            this.lblColeccionDescripcion.Name = "lblColeccionDescripcion";
            this.lblColeccionDescripcion.Size = new System.Drawing.Size(78, 13);
            this.lblColeccionDescripcion.TabIndex = 7;
            this.lblColeccionDescripcion.Text = "Descripción:";
            // 
            // lblColeccionCantPaginas
            // 
            this.lblColeccionCantPaginas.AutoSize = true;
            this.lblColeccionCantPaginas.Location = new System.Drawing.Point(18, 180);
            this.lblColeccionCantPaginas.Name = "lblColeccionCantPaginas";
            this.lblColeccionCantPaginas.Size = new System.Drawing.Size(76, 13);
            this.lblColeccionCantPaginas.TabIndex = 6;
            this.lblColeccionCantPaginas.Text = "Cant. Páginas:";
            // 
            // lblColeccionEdadSugerida
            // 
            this.lblColeccionEdadSugerida.AutoSize = true;
            this.lblColeccionEdadSugerida.Location = new System.Drawing.Point(21, 154);
            this.lblColeccionEdadSugerida.Name = "lblColeccionEdadSugerida";
            this.lblColeccionEdadSugerida.Size = new System.Drawing.Size(73, 13);
            this.lblColeccionEdadSugerida.TabIndex = 5;
            this.lblColeccionEdadSugerida.Text = "Edad Mínima:";
            // 
            // lblColeccionPrecioCompra
            // 
            this.lblColeccionPrecioCompra.AutoSize = true;
            this.lblColeccionPrecioCompra.Location = new System.Drawing.Point(0, 208);
            this.lblColeccionPrecioCompra.Name = "lblColeccionPrecioCompra";
            this.lblColeccionPrecioCompra.Size = new System.Drawing.Size(94, 13);
            this.lblColeccionPrecioCompra.TabIndex = 4;
            this.lblColeccionPrecioCompra.Text = "Precio de Compra:";
            // 
            // lblColeccionEncuadernacion
            // 
            this.lblColeccionEncuadernacion.AutoSize = true;
            this.lblColeccionEncuadernacion.Location = new System.Drawing.Point(6, 128);
            this.lblColeccionEncuadernacion.Name = "lblColeccionEncuadernacion";
            this.lblColeccionEncuadernacion.Size = new System.Drawing.Size(88, 13);
            this.lblColeccionEncuadernacion.TabIndex = 3;
            this.lblColeccionEncuadernacion.Text = "Encuadernación:";
            // 
            // lblColeccionTamano
            // 
            this.lblColeccionTamano.AutoSize = true;
            this.lblColeccionTamano.Location = new System.Drawing.Point(45, 99);
            this.lblColeccionTamano.Name = "lblColeccionTamano";
            this.lblColeccionTamano.Size = new System.Drawing.Size(49, 13);
            this.lblColeccionTamano.TabIndex = 2;
            this.lblColeccionTamano.Text = "Tamano:";
            // 
            // lblColeccionTitulo
            // 
            this.lblColeccionTitulo.AutoSize = true;
            this.lblColeccionTitulo.Location = new System.Drawing.Point(56, 47);
            this.lblColeccionTitulo.Name = "lblColeccionTitulo";
            this.lblColeccionTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblColeccionTitulo.TabIndex = 1;
            this.lblColeccionTitulo.Text = "Título:";
            // 
            // lblColeccionCodigo
            // 
            this.lblColeccionCodigo.AutoSize = true;
            this.lblColeccionCodigo.Location = new System.Drawing.Point(51, 21);
            this.lblColeccionCodigo.Name = "lblColeccionCodigo";
            this.lblColeccionCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblColeccionCodigo.TabIndex = 0;
            this.lblColeccionCodigo.Text = "Código:";
            // 
            // tbpLibro
            // 
            this.tbpLibro.Controls.Add(this.btnLibroGuardar);
            this.tbpLibro.Controls.Add(this.tbxLibroResena);
            this.tbpLibro.Controls.Add(this.lblLibroResena);
            this.tbpLibro.Controls.Add(this.tbxLibroIsbn);
            this.tbpLibro.Controls.Add(this.tbxLibroTitulo);
            this.tbpLibro.Controls.Add(this.btnLibroCancelar);
            this.tbpLibro.Controls.Add(this.tbxLibroStockActual);
            this.tbpLibro.Controls.Add(this.tbxLibroStockDeseable);
            this.tbpLibro.Controls.Add(this.lblLibroStockActual);
            this.tbpLibro.Controls.Add(this.lblLibroStockDeseable);
            this.tbpLibro.Controls.Add(this.lblLibroStockMinimo);
            this.tbpLibro.Controls.Add(this.lblLibroTitulo);
            this.tbpLibro.Controls.Add(this.lblLibroIsbn);
            this.tbpLibro.Controls.Add(this.tbxLibroStockMinimo);
            this.tbpLibro.Location = new System.Drawing.Point(4, 22);
            this.tbpLibro.Name = "tbpLibro";
            this.tbpLibro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLibro.Size = new System.Drawing.Size(452, 259);
            this.tbpLibro.TabIndex = 2;
            this.tbpLibro.Text = "Libro";
            this.tbpLibro.UseVisualStyleBackColor = true;
            // 
            // btnLibroGuardar
            // 
            this.btnLibroGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLibroGuardar.Enabled = false;
            this.btnLibroGuardar.Location = new System.Drawing.Point(267, 230);
            this.btnLibroGuardar.Name = "btnLibroGuardar";
            this.btnLibroGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnLibroGuardar.TabIndex = 7;
            this.btnLibroGuardar.Text = "Guardar";
            this.btnLibroGuardar.UseVisualStyleBackColor = true;
            this.btnLibroGuardar.Click += new System.EventHandler(this.btnLibroGuardar_Click);
            // 
            // tbxLibroResena
            // 
            this.tbxLibroResena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLibroResena.Location = new System.Drawing.Point(220, 38);
            this.tbxLibroResena.Multiline = true;
            this.tbxLibroResena.Name = "tbxLibroResena";
            this.tbxLibroResena.ReadOnly = true;
            this.tbxLibroResena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxLibroResena.Size = new System.Drawing.Size(226, 159);
            this.tbxLibroResena.TabIndex = 6;
            // 
            // lblLibroResena
            // 
            this.lblLibroResena.AutoSize = true;
            this.lblLibroResena.Location = new System.Drawing.Point(217, 21);
            this.lblLibroResena.Name = "lblLibroResena";
            this.lblLibroResena.Size = new System.Drawing.Size(47, 13);
            this.lblLibroResena.TabIndex = 10;
            this.lblLibroResena.Text = "Resena:";
            // 
            // tbxLibroIsbn
            // 
            this.tbxLibroIsbn.Location = new System.Drawing.Point(102, 39);
            this.tbxLibroIsbn.Name = "tbxLibroIsbn";
            this.tbxLibroIsbn.ReadOnly = true;
            this.tbxLibroIsbn.Size = new System.Drawing.Size(100, 20);
            this.tbxLibroIsbn.TabIndex = 1;
            this.tbxLibroIsbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxLibroTitulo
            // 
            this.tbxLibroTitulo.Location = new System.Drawing.Point(102, 65);
            this.tbxLibroTitulo.Multiline = true;
            this.tbxLibroTitulo.Name = "tbxLibroTitulo";
            this.tbxLibroTitulo.ReadOnly = true;
            this.tbxLibroTitulo.Size = new System.Drawing.Size(100, 54);
            this.tbxLibroTitulo.TabIndex = 2;
            this.tbxLibroTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLibroCancelar
            // 
            this.btnLibroCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLibroCancelar.Enabled = false;
            this.btnLibroCancelar.Location = new System.Drawing.Point(371, 230);
            this.btnLibroCancelar.Name = "btnLibroCancelar";
            this.btnLibroCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnLibroCancelar.TabIndex = 8;
            this.btnLibroCancelar.Text = "Cancelar";
            this.btnLibroCancelar.UseVisualStyleBackColor = true;
            this.btnLibroCancelar.Click += new System.EventHandler(this.btnLibroCancelar_Click);
            // 
            // tbxLibroStockActual
            // 
            this.tbxLibroStockActual.Location = new System.Drawing.Point(102, 177);
            this.tbxLibroStockActual.Name = "tbxLibroStockActual";
            this.tbxLibroStockActual.ReadOnly = true;
            this.tbxLibroStockActual.Size = new System.Drawing.Size(100, 20);
            this.tbxLibroStockActual.TabIndex = 5;
            this.tbxLibroStockActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxLibroStockDeseable
            // 
            this.tbxLibroStockDeseable.Location = new System.Drawing.Point(102, 151);
            this.tbxLibroStockDeseable.Name = "tbxLibroStockDeseable";
            this.tbxLibroStockDeseable.ReadOnly = true;
            this.tbxLibroStockDeseable.Size = new System.Drawing.Size(100, 20);
            this.tbxLibroStockDeseable.TabIndex = 4;
            this.tbxLibroStockDeseable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLibroStockActual
            // 
            this.lblLibroStockActual.AutoSize = true;
            this.lblLibroStockActual.Location = new System.Drawing.Point(25, 180);
            this.lblLibroStockActual.Name = "lblLibroStockActual";
            this.lblLibroStockActual.Size = new System.Drawing.Size(71, 13);
            this.lblLibroStockActual.TabIndex = 5;
            this.lblLibroStockActual.Text = "Stock Actual:";
            // 
            // lblLibroStockDeseable
            // 
            this.lblLibroStockDeseable.AutoSize = true;
            this.lblLibroStockDeseable.Location = new System.Drawing.Point(10, 154);
            this.lblLibroStockDeseable.Name = "lblLibroStockDeseable";
            this.lblLibroStockDeseable.Size = new System.Drawing.Size(86, 13);
            this.lblLibroStockDeseable.TabIndex = 4;
            this.lblLibroStockDeseable.Text = "Stock Deseable:";
            // 
            // lblLibroStockMinimo
            // 
            this.lblLibroStockMinimo.AutoSize = true;
            this.lblLibroStockMinimo.Location = new System.Drawing.Point(20, 128);
            this.lblLibroStockMinimo.Name = "lblLibroStockMinimo";
            this.lblLibroStockMinimo.Size = new System.Drawing.Size(76, 13);
            this.lblLibroStockMinimo.TabIndex = 3;
            this.lblLibroStockMinimo.Text = "Stock Mínimo:";
            // 
            // lblLibroTitulo
            // 
            this.lblLibroTitulo.AutoSize = true;
            this.lblLibroTitulo.Location = new System.Drawing.Point(58, 68);
            this.lblLibroTitulo.Name = "lblLibroTitulo";
            this.lblLibroTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblLibroTitulo.TabIndex = 2;
            this.lblLibroTitulo.Text = "Título:";
            // 
            // lblLibroIsbn
            // 
            this.lblLibroIsbn.AutoSize = true;
            this.lblLibroIsbn.Location = new System.Drawing.Point(61, 42);
            this.lblLibroIsbn.Name = "lblLibroIsbn";
            this.lblLibroIsbn.Size = new System.Drawing.Size(35, 13);
            this.lblLibroIsbn.TabIndex = 1;
            this.lblLibroIsbn.Text = "ISBN:";
            // 
            // tbxLibroStockMinimo
            // 
            this.tbxLibroStockMinimo.Location = new System.Drawing.Point(102, 125);
            this.tbxLibroStockMinimo.Name = "tbxLibroStockMinimo";
            this.tbxLibroStockMinimo.ReadOnly = true;
            this.tbxLibroStockMinimo.Size = new System.Drawing.Size(100, 20);
            this.tbxLibroStockMinimo.TabIndex = 3;
            this.tbxLibroStockMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.Location = new System.Drawing.Point(400, 419);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lklCategoriaEditar
            // 
            this.lklCategoriaEditar.AutoSize = true;
            this.lklCategoriaEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklCategoriaEditar.Location = new System.Drawing.Point(12, 76);
            this.lklCategoriaEditar.Name = "lklCategoriaEditar";
            this.lklCategoriaEditar.Size = new System.Drawing.Size(96, 13);
            this.lklCategoriaEditar.TabIndex = 5;
            this.lklCategoriaEditar.TabStop = true;
            this.lklCategoriaEditar.Text = "<Editar Categoría>";
            this.lklCategoriaEditar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklCategoriaEditar_LinkClicked);
            // 
            // lklColeccionEditar
            // 
            this.lklColeccionEditar.AutoSize = true;
            this.lklColeccionEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklColeccionEditar.Location = new System.Drawing.Point(183, 76);
            this.lklColeccionEditar.Name = "lklColeccionEditar";
            this.lklColeccionEditar.Size = new System.Drawing.Size(96, 13);
            this.lklColeccionEditar.TabIndex = 8;
            this.lklColeccionEditar.TabStop = true;
            this.lklColeccionEditar.Text = "<Editar Colección>";
            this.lklColeccionEditar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklColeccionEditar_LinkClicked);
            // 
            // lklLibroEditar
            // 
            this.lklLibroEditar.AutoSize = true;
            this.lklLibroEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklLibroEditar.Location = new System.Drawing.Point(351, 76);
            this.lklLibroEditar.Name = "lklLibroEditar";
            this.lklLibroEditar.Size = new System.Drawing.Size(72, 13);
            this.lklLibroEditar.TabIndex = 11;
            this.lklLibroEditar.TabStop = true;
            this.lklLibroEditar.Text = "<Editar Libro>";
            this.lklLibroEditar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklLibroEditar_LinkClicked);
            // 
            // lklCategoriaDeshabilitar
            // 
            this.lklCategoriaDeshabilitar.AutoSize = true;
            this.lklCategoriaDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklCategoriaDeshabilitar.Location = new System.Drawing.Point(12, 96);
            this.lklCategoriaDeshabilitar.Name = "lklCategoriaDeshabilitar";
            this.lklCategoriaDeshabilitar.Size = new System.Drawing.Size(124, 13);
            this.lklCategoriaDeshabilitar.TabIndex = 6;
            this.lklCategoriaDeshabilitar.TabStop = true;
            this.lklCategoriaDeshabilitar.Text = "<Deshabilitar Categoría>";
            this.lklCategoriaDeshabilitar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklCategoriaDeshabilitar_LinkClicked);
            // 
            // lklColeccionDeshabilitar
            // 
            this.lklColeccionDeshabilitar.AutoSize = true;
            this.lklColeccionDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklColeccionDeshabilitar.Location = new System.Drawing.Point(183, 96);
            this.lklColeccionDeshabilitar.Name = "lklColeccionDeshabilitar";
            this.lklColeccionDeshabilitar.Size = new System.Drawing.Size(124, 13);
            this.lklColeccionDeshabilitar.TabIndex = 9;
            this.lklColeccionDeshabilitar.TabStop = true;
            this.lklColeccionDeshabilitar.Text = "<Deshabilitar Colección>";
            this.lklColeccionDeshabilitar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklColeccionDeshabilitar_LinkClicked);
            // 
            // lklLibroDeshabilitar
            // 
            this.lklLibroDeshabilitar.AutoSize = true;
            this.lklLibroDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklLibroDeshabilitar.Location = new System.Drawing.Point(351, 96);
            this.lklLibroDeshabilitar.Name = "lklLibroDeshabilitar";
            this.lklLibroDeshabilitar.Size = new System.Drawing.Size(100, 13);
            this.lklLibroDeshabilitar.TabIndex = 12;
            this.lklLibroDeshabilitar.TabStop = true;
            this.lklLibroDeshabilitar.Text = "<Deshabilitar Libro>";
            this.lklLibroDeshabilitar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklLibroDeshabilitar_LinkClicked);
            // 
            // lklVerElementosDeshabilitados
            // 
            this.lklVerElementosDeshabilitados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lklVerElementosDeshabilitados.AutoSize = true;
            this.lklVerElementosDeshabilitados.Location = new System.Drawing.Point(12, 419);
            this.lklVerElementosDeshabilitados.Name = "lklVerElementosDeshabilitados";
            this.lklVerElementosDeshabilitados.Size = new System.Drawing.Size(159, 13);
            this.lklVerElementosDeshabilitados.TabIndex = 14;
            this.lklVerElementosDeshabilitados.TabStop = true;
            this.lklVerElementosDeshabilitados.Text = "<Ver Elementos Deshabilitados>";
            this.lklVerElementosDeshabilitados.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklVerElementosDeshabilitados_LinkClicked);
            // 
            // frmABMLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 454);
            this.Controls.Add(this.lklVerElementosDeshabilitados);
            this.Controls.Add(this.lklLibroDeshabilitar);
            this.Controls.Add(this.lklColeccionDeshabilitar);
            this.Controls.Add(this.lklCategoriaDeshabilitar);
            this.Controls.Add(this.lklLibroEditar);
            this.Controls.Add(this.lklColeccionEditar);
            this.Controls.Add(this.lklCategoriaEditar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tbcABMLibros);
            this.Controls.Add(this.lblLibro);
            this.Controls.Add(this.lblColeccion);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lklLibroAgregar);
            this.Controls.Add(this.lklColeccionAgregar);
            this.Controls.Add(this.lklCategoriaAgregar);
            this.Controls.Add(this.cbxLibro);
            this.Controls.Add(this.cbxColeccion);
            this.Controls.Add(this.cbxCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmABMLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM Libros";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmABMLibros_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coleccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            this.tbcABMLibros.ResumeLayout(false);
            this.tbpCategoria.ResumeLayout(false);
            this.tbpCategoria.PerformLayout();
            this.tbpColeccion.ResumeLayout(false);
            this.tbpColeccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            this.tbpLibro.ResumeLayout(false);
            this.tbpLibro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxColeccion;
        private System.Windows.Forms.ComboBox cbxLibro;
        private System.Windows.Forms.LinkLabel lklCategoriaAgregar;
        private System.Windows.Forms.LinkLabel lklColeccionAgregar;
        private System.Windows.Forms.LinkLabel lklLibroAgregar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblColeccion;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.TabControl tbcABMLibros;
        private System.Windows.Forms.TabPage tbpCategoria;
        private System.Windows.Forms.TabPage tbpColeccion;
        private System.Windows.Forms.TabPage tbpLibro;
        private System.Windows.Forms.Label lblCategoriaNombre;
        private System.Windows.Forms.TextBox tbxCategoriaNombre;
        private System.Windows.Forms.Label lblColeccionDescripcion;
        private System.Windows.Forms.Label lblColeccionCantPaginas;
        private System.Windows.Forms.Label lblColeccionEdadSugerida;
        private System.Windows.Forms.Label lblColeccionPrecioCompra;
        private System.Windows.Forms.Label lblColeccionEncuadernacion;
        private System.Windows.Forms.Label lblColeccionTamano;
        private System.Windows.Forms.Label lblColeccionTitulo;
        private System.Windows.Forms.Label lblColeccionCodigo;
        private System.Windows.Forms.TextBox tbxColeccionEncuadernacion;
        private System.Windows.Forms.TextBox tbxColeccionEdadSugerida;
        private System.Windows.Forms.TextBox tbxColeccionPrecioCompra;
        private System.Windows.Forms.TextBox tbxColeccionTamano;
        private System.Windows.Forms.TextBox tbxColeccionTitulo;
        private System.Windows.Forms.TextBox tbxColeccionCodigo;
        private System.Windows.Forms.TextBox tbxColeccionCantPaginas;
        private System.Windows.Forms.TextBox tbxColeccionDescripcion;
        private System.Windows.Forms.TextBox tbxLibroIsbn;
        private System.Windows.Forms.TextBox tbxLibroTitulo;
        private System.Windows.Forms.TextBox tbxLibroStockActual;
        private System.Windows.Forms.TextBox tbxLibroStockDeseable;
        private System.Windows.Forms.Label lblLibroStockActual;
        private System.Windows.Forms.Label lblLibroStockDeseable;
        private System.Windows.Forms.Label lblLibroStockMinimo;
        private System.Windows.Forms.Label lblLibroTitulo;
        private System.Windows.Forms.Label lblLibroIsbn;
        private System.Windows.Forms.TextBox tbxLibroStockMinimo;
        private System.Windows.Forms.TextBox tbxLibroResena;
        private System.Windows.Forms.Label lblLibroResena;
        private System.Windows.Forms.Button btnLibroCancelar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.LinkLabel lklCategoriaEditar;
        private System.Windows.Forms.LinkLabel lklColeccionEditar;
        private System.Windows.Forms.LinkLabel lklLibroEditar;
		private System.Windows.Forms.Button btnCategoriaCancelar;
		private System.Windows.Forms.Button btnColeccionCancelar;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox tbxColeccionProveedor;
        private System.Windows.Forms.BindingSource coleccionesBindingSource;
        private System.Windows.Forms.Button btnCategoriaGuardar;
        private System.Windows.Forms.Button btnColeccionGuardar;
        private System.Windows.Forms.Button btnLibroGuardar;
        private System.Windows.Forms.ComboBox cbxColeccionProveedor;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private System.Windows.Forms.LinkLabel lklCategoriaDeshabilitar;
        private System.Windows.Forms.LinkLabel lklColeccionDeshabilitar;
        private System.Windows.Forms.LinkLabel lklLibroDeshabilitar;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private System.Windows.Forms.LinkLabel lklVerElementosDeshabilitados;
        private System.Windows.Forms.TextBox tbxColeccionPrecioVenta;
        private System.Windows.Forms.Label lblColeccionPrecioVenta;
    }
}