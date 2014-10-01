using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
    

namespace HP.Presentacion
{
    public partial class frmABMLibros : Form
    {
        Entidades.Categoria categoria;
        Entidades.Coleccion coleccion;
        Entidades.Libro libro;

        #region Enumeradores

        public enum tipoOperacion
        {
            SoloLectura = 0,
            Agregar = 1,
            EditarCategoria = 2,
            EditarColeccion = 3,
            EditarLibro = 4
//Se hace esta distinción en la edición ya que si edito una coleccion, por ejemplo, no quiero que al 
//cambiar la categoria de esta coleccion se llene el combobox coleccion con las pertenecientes a dicha
//categoria y por consiguiente me llene el formulario de la coleccion con los datos de la recien cambiada en
//el combobox. Sin embargo, si quiero que haga esto si estoy editando un libro o una categoria.
//El enumerador "SoloLectura" si bien no tiene utilidad alguna se deja para hacer hincapie en que no se
//encuentra en ningun otro modo.
        }

        #endregion

        #region Propiedades

        public tipoOperacion m_Operacion;
        public tipoOperacion Operacion
        {
            get { return m_Operacion; }
            set { m_Operacion = value; }
        }

        #endregion


        #region Constructor

        public frmABMLibros()
        {
            InitializeComponent();
            
            m_Operacion = tipoOperacion.SoloLectura;
            CategoriaRellenarCombobox();
        }

        #endregion


        #region Eventos

        //Controles: Comboboxes           Evento: SelectedIndexChanged
        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoriaSeleccionadaObtenerDatos();
            if (m_Operacion != tipoOperacion.EditarColeccion)
            {
                ColeccionRellenarCombobox(categoria.Id_categ);
            }
        }

        private void cbxColeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxColeccion.DataSource != null && cbxColeccion.SelectedIndex != -1)
            {
                ColeccionSeleccionadaObtenerDatos(((Entidades.Coleccion)cbxColeccion.SelectedItem).Id_colec);
                if (m_Operacion != tipoOperacion.EditarLibro)
                {
                    LibroRellenarCombobox(coleccion.Id_colec);
                }
            }
        }

        private void cbxLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLibro.DataSource != null && cbxLibro.SelectedIndex != -1)
            {
                LibroSeleccionadoObtenerDatos(((Entidades.Libro)cbxLibro.SelectedItem).Id_libro);
            }
        }


        //Controles: LinkLabels "Agregar"           Evento: LinkClicked
        private void lklCategoriaAgregar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_Operacion = tipoOperacion.Agregar;
            CategoriaVaciarFormulario();
            CategoriaPrepararFormulario();
        }

        private void lklColeccionAgregar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cbxCategoria.DataSource != null && cbxCategoria.SelectedIndex != -1)
            {
                m_Operacion = tipoOperacion.Agregar;
                ColeccionVaciarFormulario();
                ColeccionPrepararFormulario();                
            }
            else
            {
                MessageBox.Show("Para poder agregar una nueva colección, primero debe seleccionar la categoría a " +
                    "la cual pertenece.", "Seleccione una categoría", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lklLibroAgregar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cbxColeccion.DataSource != null && cbxColeccion.SelectedIndex != -1)
            {
                m_Operacion = tipoOperacion.Agregar;
                LibroHabilitarDeshabilitarFormulario(false);
                HabilitarDeshabilitarComboboxesYLinklabels(false);
                LibroVaciarFormulario();
                tbxLibroStockActual.Text = "0";
                tbcABMLibros.SelectTab(tbpLibro);
                tbxLibroIsbn.Focus();
            }
            else
            {
                MessageBox.Show("Para poder agregar un nuevo libro, primero debe seleccionar la colección a " +
                    "la cual pertenece.", "Seleccione una colección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Controles: LklLabels "Editar"          Evento: LinkClicked
        private void lklCategoriaEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cbxCategoria.DataSource != null && cbxCategoria.SelectedIndex != -1)
            {
                m_Operacion = tipoOperacion.EditarCategoria;
                CategoriaPrepararFormulario();
            }
            else
            {
                MessageBox.Show("Para poder editar una categoría, primero debe seleccionarla", 
                        "Seleccione una categoría", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lklColeccionEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cbxColeccion.DataSource != null && cbxColeccion.SelectedIndex != -1)
            {
                m_Operacion = tipoOperacion.EditarColeccion;
                ColeccionPrepararFormulario();
                cbxCategoria.Enabled = true;
                cbxColeccionProveedor.SelectedValue = coleccion.Prov.Id_prov;
                char[] MyChar = { '$', ' ' };
                tbxColeccionPrecioCompra.Text = tbxColeccionPrecioCompra.Text.TrimStart(MyChar);
                tbxColeccionPrecioVenta.Text = tbxColeccionPrecioVenta.Text.TrimStart(MyChar);
            }
            else
            {
                MessageBox.Show("Para poder editar una colección, primero debe seleccionarla",
                "Seleccione una colección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lklLibroEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cbxLibro.DataSource != null && cbxLibro.SelectedIndex != -1)
            {
                m_Operacion = tipoOperacion.EditarLibro;
                LibroPrepararFormulario();
                cbxCategoria.Enabled = true;
                cbxColeccion.Enabled = true;
            }
            else
            {
                MessageBox.Show("Para poder editar un libro, primero debe seleccionarlo",
                "Seleccione un libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Controles: LklLabels "Deshabilitar"          Evento: LinkClicked
        private void lklCategoriaDeshabilitar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            if (cbxCategoria.DataSource != null && cbxCategoria.SelectedIndex != -1)
            {
                if (DialogResult.Yes == MessageBox.Show("Esta seguro de querer deshabilitar la presente Categoría?",
                "Confirmar Deshabilitación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                { CategoriaDeshabilitar(); }
            }
            else
            {
                MessageBox.Show("Para poder deshabilitar una categoría, primero debe seleccionarla",
                        "Seleccione una categoría", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lklColeccionDeshabilitar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cbxColeccion.DataSource != null && cbxColeccion.SelectedIndex != -1)
            {
                if (DialogResult.Yes == MessageBox.Show("Esta seguro de querer deshabilitar la presente Colección?",
                "Confirmar Deshabilitación", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                { ColeccionDeshabilitar(); }
            }
            else
            {
                MessageBox.Show("Para poder deshabilitar una colección, primero debe seleccionarla",
                "Seleccione una colección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lklLibroDeshabilitar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cbxLibro.DataSource != null && cbxLibro.SelectedIndex != -1)
            {
                if (DialogResult.Yes == MessageBox.Show("Esta seguro de querer deshabilitar el presente Libro?",
                "Confirmar Deshabilitación", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                { LibroDeshabilitar(); }
            }
            else
            {
                MessageBox.Show("Para poder deshabilitar un libro, primero debe seleccionarlo",
                "Seleccione un libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Controles: LkLabels "Ver Elementos Deshabilitados"    Evento: LinkClicked
        private void lklVerElementosDeshabilitados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VerElementosDeshabilitados();
        }


        //Controles: Buttons "Guardar"          Evento: Click
        private void btnCategoriaGuardar_Click(object sender, EventArgs e)
        {
            if (CategoriaValidarCampos())
            {
                int id_categAux = -1;

                if (m_Operacion == tipoOperacion.Agregar)
                {
                    id_categAux = CategoriaGuardar();
                }
                else if (m_Operacion == tipoOperacion.EditarCategoria)
                {
                    id_categAux = CategoriaEditar();
                }

                if (id_categAux != -1)
                {
                    cbxCategoria.SelectedValue = id_categAux;
                    CategoriaHabilitarDeshabilitarFormulario(true);
                    HabilitarDeshabilitarComboboxesYLinklabels(true);
                    m_Operacion = tipoOperacion.SoloLectura;
                }
            }
        }

        private void btnColeccionGuardar_Click(object sender, EventArgs e)
        {
            if (ColeccionValidarCampos())
            {
                int id_colecAux = -1;
                
                if (m_Operacion == tipoOperacion.Agregar)
                {
                    id_colecAux = ColeccionGuardar();
                }
                else if (m_Operacion == tipoOperacion.EditarColeccion)
                     {
                         id_colecAux = ColeccionEditar();
                     }

                if (id_colecAux != -1)
                {
                    cbxColeccion.SelectedValue = id_colecAux;
                    ColeccionHabilitarDeshabilitarFormulario(true);
                    HabilitarDeshabilitarComboboxesYLinklabels(true);
                    m_Operacion = tipoOperacion.SoloLectura;
                    cbxColeccionProveedor.Visible = false;
                    tbxColeccionProveedor.Visible = true;
                }
            }
        }

        private void btnLibroGuardar_Click(object sender, EventArgs e)
        {
            if (LibroValidarCampos())
            {
                int id_libroAux = -1;

                if (m_Operacion == tipoOperacion.Agregar)
                {
                    id_libroAux = LibroGuardar();
                }
                else if (m_Operacion == tipoOperacion.EditarLibro)
                {
                    id_libroAux = LibroEditar();
                }

                if (id_libroAux != -1)
                {
                    cbxLibro.SelectedValue = id_libroAux;
                    LibroHabilitarDeshabilitarFormulario(true);
                    HabilitarDeshabilitarComboboxesYLinklabels(true);
                    m_Operacion = tipoOperacion.SoloLectura;
                }
            }
        }


        //Controles: Buttons "Cancelar"         Evento: Click
        private void btnCategoriaCancelar_Click(object sender, EventArgs e)
        {
            CategoriaCancelar();
        }

        private void btnColeccionCancelar_Click(object sender, EventArgs e)
        {
            ColeccionCancelar();
        }

        private void btnLibroCancelar_Click(object sender, EventArgs e)
        {
            LibroCancelar();
        }


        //Control: Button "Volver"          Evento: Click
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //AYUDA
        private void frmABMLibros_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MostrarAyuda();
        }

        #endregion
        
//////////////////////////////////////////////////////////////////////////////////////////////

        #region Métodos

        //Rellenar comboboxes
        private void CategoriaRellenarCombobox()
        {
            Negocio.Categorias nCategorias = new HP.Negocio.Categorias();
            cbxCategoria.DataSource = nCategorias.ObtenerTodas();
        }
        
        private void ColeccionRellenarCombobox(int id_categ)
        {
            Negocio.Colecciones nColecciones = new HP.Negocio.Colecciones();
            cbxColeccion.DataSource = nColecciones.ObtenerTodas(id_categ);
            if (cbxColeccion.Items.Count == 0)
            {
                cbxColeccion.Text = "";
                ColeccionVaciarFormulario();
                cbxLibro.DataSource = new Entidades.Libros();
                cbxLibro.Text = "";
                LibroVaciarFormulario();
            }
        }

        private void ColeccionProveedorRellenarCombobox()
        {
            Negocio.Proveedores nProvedores = new HP.Negocio.Proveedores();
            cbxColeccionProveedor.DataSource = nProvedores.ObtenerHabilitados();
        }

        private void LibroRellenarCombobox(int id_colec)
        {
            Negocio.Libros nLibros = new HP.Negocio.Libros();
            cbxLibro.DataSource = nLibros.ObtenerTodos(id_colec);
            if (cbxLibro.Items.Count == 0)
            {
                cbxLibro.Text = "";
                LibroVaciarFormulario();
            }
        }


        //Obtencion de datos del item seleccionado
        private void CategoriaSeleccionadaObtenerDatos()
        {
            categoria = (Entidades.Categoria)cbxCategoria.SelectedItem;
            tbxCategoriaNombre.Text = categoria.Nombre_categ;
        }

        private void ColeccionSeleccionadaObtenerDatos(int id_colec)
        {
            Negocio.Colecciones nColeccion = new HP.Negocio.Colecciones();
            coleccion = nColeccion.ObtenerUna(id_colec);
            ColeccionRellenarFormulario(coleccion);
        }

        private void LibroSeleccionadoObtenerDatos(int id_libro)
        {
            Negocio.Libros nLibro = new HP.Negocio.Libros();
            libro = nLibro.ObtenerUno(id_libro);
            
            Entidades.Categoria categoriaAux = new HP.Entidades.Categoria();
            Entidades.Coleccion coleccionAux = new HP.Entidades.Coleccion();
            categoriaAux.Id_categ = ((Entidades.Categoria)cbxCategoria.SelectedItem).Id_categ;
            coleccionAux.Categ = categoriaAux;
            coleccionAux.Id_colec = ((Entidades.Coleccion)cbxColeccion.SelectedItem).Id_colec;
            coleccionAux.Categ = categoriaAux;
            libro.Colec = coleccionAux;
                        
            LibroRellenarFormulario(libro);
        }


        //Rellenar de formularios
        private void ColeccionRellenarFormulario(Entidades.Coleccion pColeccion)
        {
            tbxColeccionCodigo.Text = pColeccion.Cod_colec;
            tbxColeccionTitulo.Text = pColeccion.Titulo_colec;
            tbxColeccionTamano.Text = pColeccion.Tamano;
            tbxColeccionEncuadernacion.Text = pColeccion.Encuadernacion;
            tbxColeccionEdadSugerida.Text = pColeccion.Edad_sugerida.ToString();
            tbxColeccionCantPaginas.Text = pColeccion.Cant_pags.ToString();
            tbxColeccionPrecioCompra.Text = "$ " + pColeccion.PrecioCompra.ToString();
            tbxColeccionPrecioVenta.Text = "$ " + pColeccion.PrecioVenta.ToString();
            tbxColeccionDescripcion.Text = pColeccion.Descripcion_colec;
            tbxColeccionProveedor.Text = pColeccion.Prov.Razon_social;
        }

        private void LibroRellenarFormulario(Entidades.Libro plibro)
        {
            tbxLibroIsbn.Text = plibro.Isbn.ToString();
            tbxLibroResena.Text = plibro.Resena;
            tbxLibroStockActual.Text = plibro.Stock_actual.ToString();
            tbxLibroStockDeseable.Text = plibro.Stock_deseable.ToString();
            tbxLibroStockMinimo.Text = plibro.Stock_minimo.ToString(); ;
            tbxLibroTitulo.Text = plibro.Titulo_libro;
        }


        //Vaciar formularios
        private void CategoriaVaciarFormulario()
        {
            tbxCategoriaNombre.Text = "";
        }

        private void ColeccionVaciarFormulario()
        {
            tbxColeccionCodigo.Text = "";
            tbxColeccionTitulo.Text = "";
            tbxColeccionTamano.Text = "";
            tbxColeccionEncuadernacion.Text = "";
            tbxColeccionEdadSugerida.Text = "";
            tbxColeccionCantPaginas.Text = "";
            tbxColeccionPrecioCompra.Text = "";
            tbxColeccionPrecioVenta.Text = "";
            tbxColeccionDescripcion.Text = "";
            tbxColeccionProveedor.Text = "";
        }

        private void LibroVaciarFormulario()
        {
            tbxLibroIsbn.Text = "";
            tbxLibroTitulo.Text = "";
            tbxLibroStockMinimo.Text = "";
            tbxLibroStockDeseable.Text = "";
            tbxLibroStockActual.Text = "";
            tbxLibroResena.Text = "";
        }


        //Habilitar/Deshabilitar Formularios
        private void CategoriaHabilitarDeshabilitarFormulario(bool soloLectura)
        {
            tbxCategoriaNombre.ReadOnly = soloLectura;
            btnCategoriaGuardar.Enabled = !soloLectura;
            btnCategoriaCancelar.Enabled = !soloLectura;
        }

        private void ColeccionHabilitarDeshabilitarFormulario(bool soloLectura)
        {
            tbxColeccionCodigo.ReadOnly = soloLectura;
            tbxColeccionTitulo.ReadOnly = soloLectura;
            tbxColeccionEncuadernacion.ReadOnly = soloLectura;
            tbxColeccionProveedor.ReadOnly = soloLectura;
            tbxColeccionTamano.ReadOnly = soloLectura;
            tbxColeccionEncuadernacion.ReadOnly = soloLectura;
            tbxColeccionEdadSugerida.ReadOnly = soloLectura;
            tbxColeccionCantPaginas.ReadOnly = soloLectura;
            tbxColeccionPrecioCompra.ReadOnly = soloLectura;
            tbxColeccionPrecioVenta.ReadOnly = soloLectura;
            tbxColeccionDescripcion.ReadOnly = soloLectura;
            btnColeccionGuardar.Enabled = !soloLectura;
            btnColeccionCancelar.Enabled = !soloLectura;
        }

        private void LibroHabilitarDeshabilitarFormulario(bool soloLectura)
        {
            tbxLibroIsbn.ReadOnly = soloLectura;
            tbxLibroTitulo.ReadOnly = soloLectura;
            tbxLibroStockMinimo.ReadOnly = soloLectura;
            tbxLibroStockDeseable.ReadOnly = soloLectura;
            tbxLibroStockActual.ReadOnly = soloLectura;
            tbxLibroResena.ReadOnly = soloLectura;
            btnLibroGuardar.Enabled = !soloLectura;
            btnLibroCancelar.Enabled = !soloLectura;
        }


        //Habilitar/Deshabilitar Comboboxes y LinkLabels
        private void HabilitarDeshabilitarComboboxesYLinklabels(bool habilitado)
        {
            lklCategoriaAgregar.Enabled = habilitado;
            lklCategoriaEditar.Enabled = habilitado;
            lklCategoriaDeshabilitar.Enabled = habilitado;
            lklColeccionAgregar.Enabled = habilitado;
            lklColeccionEditar.Enabled = habilitado;
            lklColeccionDeshabilitar.Enabled = habilitado;
            lklLibroAgregar.Enabled = habilitado;
            lklLibroEditar.Enabled = habilitado;
            lklLibroDeshabilitar.Enabled = habilitado;

            lklVerElementosDeshabilitados.Enabled = habilitado;

            cbxCategoria.Enabled = habilitado;
            cbxColeccion.Enabled = habilitado;
            cbxLibro.Enabled = habilitado;
        }


        //Guardar datos
        private int CategoriaGuardar()
        {
            Entidades.Categoria categoriaAuxiliar = CategoriaObtenerDatosDelFormulario();
            Negocio.Categorias nCategoria = new HP.Negocio.Categorias();
            categoriaAuxiliar.Id_categ = nCategoria.Agregar(categoriaAuxiliar);

            if (categoriaAuxiliar.Id_categ > 0)
            {
                CategoriaRellenarCombobox();
                categoria = categoriaAuxiliar;
                return categoria.Id_categ;
            }
            else if (categoriaAuxiliar.Id_categ == -1)
            {
                MessageBox.Show("El título ingresado pertenece a una categoría ya existente, " +
                    "pero que se encuentra deshabilitada.\nPara volver a habilitarla " +
                    "consulte el listado de elementos deshabilitados", "Categoría Existente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (categoriaAuxiliar.Id_categ == -2)
            {
                MessageBox.Show("El título ingresado pertenece a una categoría ya existente",
                    "Categoría Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error. La categoría no ha sido guardada",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbxCategoriaNombre.Focus();
            tbxCategoriaNombre.SelectAll();
            //CategoriaCancelar();
            return -1;
        }

        private int ColeccionGuardar()
        {
            Entidades.Coleccion coleccionAuxiliar = ColeccionObtenerDatosDelFormulario();
            Negocio.Colecciones nColeccion = new HP.Negocio.Colecciones();
            coleccionAuxiliar.Id_colec = nColeccion.Agregar(coleccionAuxiliar);

            if (coleccionAuxiliar.Id_colec > 0)
            {
                ColeccionRellenarCombobox(coleccionAuxiliar.Categ.Id_categ);
                coleccion = coleccionAuxiliar;
                return coleccion.Id_colec;
            }
            else if (coleccionAuxiliar.Id_colec == -1)
            {
                MessageBox.Show("El código ingresado pertenece a una colección ya existente, " +
                    "pero que se encuentra deshabilitada.\nPara volver a habilitarla " +
                    "consulte el listado de elementos deshabilitados",
                    "Colección Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (coleccionAuxiliar.Id_colec == -2)
            {
                MessageBox.Show("El código ingresado pertenece a una colección ya existente.\n" +
                    "Si bien esta colección se encuentra habilitada, la categoría que la " +
                    "contiene esta deshabilitada.\nPara volver a habilitarla " +
                    "consulte el listado de elementos deshabilitados",
                    "Colección Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (coleccionAuxiliar.Id_colec == -3)
            {
                MessageBox.Show("El código ingresado pertenece a una colección ya existente",
                    "Colección Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error. Los datos de la colección no han sido guardados",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbxColeccionCodigo.Focus();
            tbxColeccionCodigo.SelectAll();
            return -1;
        }

        private int LibroGuardar()
        {
            Entidades.Libro libroAuxiliar = LibroObtenerDatosDelFormulario();
            Negocio.Libros nLibro = new HP.Negocio.Libros();
            libroAuxiliar.Id_libro = nLibro.Agregar(libroAuxiliar);

            if (libroAuxiliar.Id_libro > 0)
            {
                LibroRellenarCombobox(libroAuxiliar.Colec.Id_colec);
                libro = libroAuxiliar;
                return libro.Id_libro;
            }
            else if (libroAuxiliar.Id_libro == -1)
            {
                MessageBox.Show("El ISBN ingresado pertenece a un libro ya existente, " +
                    "pero que se encuentra deshabilitado.\nPara volver a habilitarlo " +
                    "consulte el listado de elementos deshabilitados", "Libro Existente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (libroAuxiliar.Id_libro == -2)
            {
                MessageBox.Show("El ISBN ingresado pertenece a un libro ya existente.\n" +
                    "Si bien este libro se encuentra habilitado, la colección que lo " +
                    "contiene esta deshabilitada.\nPara volver a habilitarla " +
                    "consulte el listado de elementos deshabilitados", "Libro Existente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (libroAuxiliar.Id_libro == -3)
            {
                MessageBox.Show("El ISBN ingresado pertenece a un libro ya existente.\n" +
                    "Si bien tanto este libro, como la colección que lo contiene, se " +
                    "encuentran habilitados, la categoría a la que pertenecen esta " +
                    "deshabilitada.\nPara volver a habilitarla consulte el listado " +
                    "de elementos deshabilitados", "Libro Existente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (libroAuxiliar.Id_libro == -4)
            {
                MessageBox.Show("El ISBN ingresado pertenece a un libro ya existente",
                    "Libro Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error. Los datos del libro no han sido guardados",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbxLibroIsbn.Focus();
            tbxLibroIsbn.SelectAll();
            return -1;
        }


        //Editar datos
        private int CategoriaEditar()
        {
            Entidades.Categoria categoriaAuxiliar = CategoriaObtenerDatosDelFormulario();
            categoriaAuxiliar.Id_categ = ((Entidades.Categoria)cbxCategoria.SelectedItem).Id_categ;
            Negocio.Categorias nCategoria = new HP.Negocio.Categorias();

            if (nCategoria.Editar(categoriaAuxiliar) != -1)
            {
                CategoriaRellenarCombobox();
                categoria = categoriaAuxiliar;
                return categoria.Id_categ;
            }
            else
            {
                MessageBox.Show("El nombre ingresado corresponde a una categoría existente", 
                            "Categoría Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCategoriaNombre.Focus();
                tbxCategoriaNombre.SelectAll();
                return -1;
            }
        }

        private int ColeccionEditar()
        {
            Entidades.Coleccion coleccionAuxiliar = ColeccionObtenerDatosDelFormulario();
            coleccionAuxiliar.Id_colec = ((Entidades.Coleccion)cbxColeccion.SelectedItem).Id_colec;
            Negocio.Colecciones nColeccion = new HP.Negocio.Colecciones();

            if (nColeccion.Editar(coleccionAuxiliar) != -1)
            {
                ColeccionRellenarCombobox(coleccionAuxiliar.Categ.Id_categ);
                coleccion = coleccionAuxiliar;
                return coleccion.Id_colec;
            }
            else
            {
                MessageBox.Show("El código de colección ingresado pertenece a otra colección ya registrada", 
                        "Colección Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxColeccionCodigo.Focus();
                tbxColeccionCodigo.SelectAll();
                return -1;
            }
        }

        private int LibroEditar()
        {
            Entidades.Libro libroAuxiliar = LibroObtenerDatosDelFormulario();
            libroAuxiliar.Id_libro = ((Entidades.Libro)cbxLibro.SelectedItem).Id_libro;
            Negocio.Libros nLibro = new HP.Negocio.Libros();

            if (nLibro.Editar(libroAuxiliar) != -1)
            {
                LibroRellenarCombobox(libroAuxiliar.Colec.Id_colec);
                libro = libroAuxiliar;
                return libro.Id_libro;
            }
            else
            {
                MessageBox.Show("El ISBN ingresado pertenece a otro libro ya registrado", "Libro Existente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxLibroIsbn.Focus();
                tbxLibroIsbn.SelectAll();
                return -1;
            }
        }


        //Deshabilitar Categorias, Colecciones, Libros
        private void CategoriaDeshabilitar()
        {
            int id_categ = ((Entidades.Categoria) cbxCategoria.SelectedItem).Id_categ;
            Negocio.Categorias nCategoria = new HP.Negocio.Categorias();
            String librosConStock = nCategoria.ValidarStockCero(id_categ);

            if (librosConStock == "")
            {
                nCategoria.EstablecerHabilitacion(id_categ, 0);
                CategoriaRellenarCombobox();
            }
            else
            {
                MessageBox.Show("No se puede deshabilitar la categoria \"" +
                               ((Entidades.Categoria)cbxCategoria.SelectedItem).Nombre_categ +
                               "\" ya que los siguientes libros todavía tienen stock disponible:\n\n" +
                               librosConStock,
                               "Existen libros en stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ColeccionDeshabilitar()
        {
            int id_colec = ((Entidades.Coleccion)cbxColeccion.SelectedItem).Id_colec;
            Negocio.Colecciones nColeccion = new HP.Negocio.Colecciones();
            String librosConStock = nColeccion.ValidarStockCero(id_colec);

            if (librosConStock == "")
            {
                nColeccion.EstablecerHabilitacion(id_colec, 0);
                ColeccionRellenarCombobox(((Entidades.Categoria)cbxCategoria.SelectedItem).Id_categ);
            }
            else
            {
                MessageBox.Show("No se puede deshabilitar la colección \"" +
                               ((Entidades.Coleccion)cbxColeccion.SelectedItem).Titulo_colec +
                               "\" ya que los siguientes libros todavía tienen stock disponible:\n\n" + 
                               librosConStock,
                               "Existen libros en stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LibroDeshabilitar()
        {
            int id_libro = ((Entidades.Libro)cbxLibro.SelectedItem).Id_libro;

            Negocio.Libros nLibro = new HP.Negocio.Libros();
            Entidades.Libro libro = nLibro.ObtenerUno(id_libro);

            if (libro.Stock_actual == 0)
            {
                nLibro.EstablecerHabilitacion(id_libro, 0);
                LibroRellenarCombobox(((Entidades.Coleccion)cbxColeccion.SelectedItem).Id_colec);
            }
            else
            {
                MessageBox.Show("No se puede deshabilitar el libro \"" + libro.Titulo_libro +
                                "\" ya que todavía existen ejemplares en stock.\n", "Existen libros en stock",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Acciones de los botones cancelar
        private void CategoriaCancelar()
        {
            if (cbxCategoria.Items.Count != 0)
            {
                tbxCategoriaNombre.Text = categoria.Nombre_categ;
            }
            else
            {
                CategoriaVaciarFormulario();
            }
            CategoriaHabilitarDeshabilitarFormulario(true);
            HabilitarDeshabilitarComboboxesYLinklabels(true);
            m_Operacion = tipoOperacion.SoloLectura;
        }

        private void ColeccionCancelar()
        {
            if (cbxColeccion.Items.Count != 0)
            {
                cbxCategoria.SelectedValue = coleccion.Categ.Id_categ;
                ColeccionRellenarFormulario(coleccion);
            }
            else
            {
                ColeccionVaciarFormulario();
            }
            ColeccionHabilitarDeshabilitarFormulario(true);
            HabilitarDeshabilitarComboboxesYLinklabels(true);

            cbxColeccionProveedor.Visible = false;
            tbxColeccionProveedor.Visible = true;
            m_Operacion = tipoOperacion.SoloLectura;
        }

        private void LibroCancelar()
        {
            if (cbxLibro.Items.Count != 0)
            {
                cbxCategoria.SelectedValue = libro.Colec.Categ.Id_categ;
                cbxColeccion.SelectedValue = libro.Colec.Id_colec;
                LibroRellenarFormulario(libro);
            }
            else
            {
                LibroVaciarFormulario();
            }
            LibroHabilitarDeshabilitarFormulario(true);
            HabilitarDeshabilitarComboboxesYLinklabels(true);
            m_Operacion = tipoOperacion.SoloLectura;
        }

        //Guarda todos los datos del formulario en el objeto correspondiente y devuelve este objeto
        private Entidades.Categoria CategoriaObtenerDatosDelFormulario()
        {
            Entidades.Categoria categoriaAux = new HP.Entidades.Categoria();
            categoriaAux.Nombre_categ = tbxCategoriaNombre.Text.Trim();
            return categoriaAux;
        }

        private Entidades.Coleccion ColeccionObtenerDatosDelFormulario()
        {
            Entidades.Categoria categoriaAux = new HP.Entidades.Categoria();
            Entidades.Proveedor proveedorAux = new HP.Entidades.Proveedor();
            Entidades.Coleccion coleccionAux = new HP.Entidades.Coleccion();

            categoriaAux.Id_categ = ((Entidades.Categoria)cbxCategoria.SelectedItem).Id_categ;
            coleccionAux.Cod_colec = tbxColeccionCodigo.Text.Trim();
            coleccionAux.Titulo_colec = tbxColeccionTitulo.Text.Trim();
            proveedorAux.Id_prov = ((Entidades.Proveedor)cbxColeccionProveedor.SelectedItem).Id_prov;
            coleccionAux.Tamano = tbxColeccionTamano.Text.Trim();
            coleccionAux.Encuadernacion = tbxColeccionEncuadernacion.Text.Trim();
            coleccionAux.PrecioCompra = float.Parse(tbxColeccionPrecioCompra.Text.Trim());
            coleccionAux.PrecioVenta = float.Parse(tbxColeccionPrecioVenta.Text.Trim());
            coleccionAux.Descripcion_colec = tbxColeccionDescripcion.Text.Trim();

            if (tbxColeccionCantPaginas.Text.Trim() != "")
                coleccionAux.Cant_pags = Convert.ToInt32(tbxColeccionCantPaginas.Text.Trim());
            if (tbxColeccionEdadSugerida.Text.Trim() != "")
                coleccionAux.Edad_sugerida = Convert.ToInt32(tbxColeccionEdadSugerida.Text.Trim());

            coleccionAux.Categ = categoriaAux;
            coleccionAux.Prov = proveedorAux;

            return coleccionAux;
        }

        private Entidades.Libro LibroObtenerDatosDelFormulario()
        {
            Entidades.Categoria categoriaAux = new HP.Entidades.Categoria();
            Entidades.Coleccion coleccionAux = new HP.Entidades.Coleccion();
            Entidades.Libro libroAux = new HP.Entidades.Libro();

            categoriaAux.Id_categ = ((Entidades.Categoria)cbxCategoria.SelectedItem).Id_categ;
            coleccionAux.Categ = categoriaAux;
            coleccionAux.Id_colec = ((Entidades.Coleccion)cbxColeccion.SelectedItem).Id_colec;

            libroAux.Colec = coleccionAux;
            libroAux.Isbn = Convert.ToInt64(tbxLibroIsbn.Text.Trim());
            libroAux.Titulo_libro = tbxLibroTitulo.Text.Trim();
            libroAux.Stock_minimo = Convert.ToInt32(tbxLibroStockMinimo.Text.Trim());
            libroAux.Stock_deseable = Convert.ToInt32(tbxLibroStockDeseable.Text.Trim());
            libroAux.Stock_actual = Convert.ToInt32(tbxLibroStockActual.Text.Trim());

            if (tbxLibroResena.Text.Trim() == "")
                libroAux.Resena = "";
            else
                libroAux.Resena = tbxLibroResena.Text.Trim();
           
            return libroAux;
        }


        //Prepara los formularios para agregar o editar elementos
        private void CategoriaPrepararFormulario()
        {
            CategoriaHabilitarDeshabilitarFormulario(false);
            HabilitarDeshabilitarComboboxesYLinklabels(false);
            tbcABMLibros.SelectTab(tbpCategoria);
            tbxCategoriaNombre.Focus();
            tbxCategoriaNombre.SelectAll();
        }

        private void ColeccionPrepararFormulario()
        {
            ColeccionHabilitarDeshabilitarFormulario(false);
            HabilitarDeshabilitarComboboxesYLinklabels(false);
            tbcABMLibros.SelectTab(tbpColeccion);
            tbxColeccionCodigo.Focus();
            tbxColeccionCodigo.SelectAll();
            tbxColeccionProveedor.Visible = false;
            cbxColeccionProveedor.Visible = true;
            ColeccionProveedorRellenarCombobox();
        }

        private void LibroPrepararFormulario()
        {
            LibroHabilitarDeshabilitarFormulario(false);
            HabilitarDeshabilitarComboboxesYLinklabels(false);
            tbcABMLibros.SelectTab(tbpLibro);
            tbxLibroIsbn.Focus();
            tbxLibroIsbn.SelectAll();
        }


        //Validaciones de los campos del formulario
        private bool CategoriaValidarCampos()
        {
            Negocio.Validaciones nValidar = new HP.Negocio.Validaciones();
            string mensaje = "";

            if (nValidar.CadenaVacia(tbxCategoriaNombre.Text.Trim()))
            {
                mensaje += "El NOMBRE de la categoría no puede estar en blanco";
            }

            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCategoriaNombre.Focus();
                tbxCategoriaNombre.SelectAll();
                return false;
            }
            return true;
        }

        private bool ColeccionValidarCampos()
        {
            Negocio.Validaciones nValidar = new HP.Negocio.Validaciones();
            String mensaje = "";
            
            if (nValidar.CadenaVacia(tbxColeccionCodigo.Text.Trim()))
                mensaje += "El CÓDIGO de la colección no puede estar en blanco.\n";
            else if (!Regex.IsMatch(tbxColeccionCodigo.Text.Trim(), @"^(\d{1,3})(\s)([A-Z]{2})$"))
                mensaje += "El formato del CÓDIGO es incorrecto. Se debe ingresar de 1 a 3 " +
                            "dígitos, seguido de un espacio en blanco y luego 2 letras " + 
                            "mayúsuclas. Ejemplo: 456 AB.\n";

            if (nValidar.CadenaVacia(tbxColeccionTitulo.Text.Trim()))
                mensaje += "El TÍTULO no puede estar en blanco.\n";

            if (nValidar.CadenaVacia(tbxColeccionTamano.Text.Trim()))
                mensaje += "El TAMAÑO no puede estar en blanco.\n";
            else if (!Regex.IsMatch(tbxColeccionTamano.Text.Trim(),
                        @"^(\d{1,3})((,|.)\d)?(\s[xX]\s)(\d{1,3})((,|.)\d)?(\s)(cm)$"))
                mensaje += "El formato del TAMAÑO es incorrecto. Recuerde incluir la unidad " +
                            "de medida. Ejemplos : \"22 x 25 cm\" o \"20,5 X 30,4 cm\".\n";

            if (!nValidar.CadenaVacia(tbxColeccionEdadSugerida.Text.Trim()) &&
                !nValidar.SoloXYDigitos(tbxColeccionEdadSugerida.Text.Trim(), 1, 2))
                        mensaje += "El formato de la EDAD MÍNIMA es incorrecto. " +
                                    "Debe ingresar un Nº entero de 1 o 2 cifras.\n";

            if (!nValidar.CadenaVacia(tbxColeccionCantPaginas.Text.Trim()) &&
                !nValidar.SoloXYDigitos(tbxColeccionCantPaginas.Text.Trim(), 1, 4))
                    mensaje += "El formato de la CANTIDAD DE PÁGINAS es incorrecto. Debe ingresar" +
                                " un número entero menor a 10000.\n";

            if (nValidar.CadenaVacia(tbxColeccionPrecioCompra.Text.Trim()))
                mensaje += "El PRECIO DE COMPRA no puede estar en blanco.\n";
            else if (!Regex.IsMatch(tbxColeccionPrecioCompra.Text.Trim(), @"^(\d{1,3})(,\d{1,2})?$"))
                mensaje += "El formato del PRECIO DE COMPRA es incorrecto. Debe ser un numero menor a " +
                            "999 y puede contener hasta 2 decimales. Ejemplos: \"153\" o \"54,25\".\n";

            if (nValidar.CadenaVacia(tbxColeccionPrecioVenta.Text.Trim()))
                mensaje += "El PRECIO DE VENTA no puede estar en blanco.\n";
            else if (!Regex.IsMatch(tbxColeccionPrecioVenta.Text.Trim(), @"^(\d{1,3})(,\d{1,2})?$"))
                mensaje += "El formato del PRECIO DE VENTA es incorrecto. Debe ser un numero menor a " +
                            "999 y puede contener hasta 2 decimales. Ejemplos: \"153\" o \"54,25\".\n";

            if (nValidar.Nro1MenorQueNro2(float.Parse(tbxColeccionPrecioVenta.Text.Trim()),
                                       float.Parse(tbxColeccionPrecioCompra.Text.Trim())))
            {
                mensaje += "El PRECIO DE VENTA no puede ser menor al PRECIO DE COMPRA";
            }

            if (nValidar.CadenaVacia(tbxColeccionDescripcion.Text.Trim()))
                mensaje += "La DESCRIPCIÓN no puede estar en blanco.\n";

            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxColeccionCodigo.Focus();
                tbxColeccionCodigo.SelectAll();
                return false;
            }
            return true;
        }

        private bool LibroValidarCampos()
        {
            Negocio.Validaciones nValidar = new HP.Negocio.Validaciones();
            String mensaje = "";

            if (nValidar.CadenaVacia(tbxLibroIsbn.Text.Trim()))
                mensaje += "El ISBN no puede estar en blanco.\n";
            else if (!Regex.IsMatch(tbxLibroIsbn.Text.Trim(), @"^\d{9,13}$"))
                mensaje += "El ISBN tiene un formato incorrecto. Debe ser un número de 9 a 13 dígitos.\n";

            if (nValidar.CadenaVacia(tbxLibroTitulo.Text.Trim()))
                mensaje += "El TITULO no puede estar en blanco.\n";

            if (nValidar.CadenaVacia(tbxLibroStockMinimo.Text.Trim()))
                mensaje += "El STOCK MINIMO no puede estar en blanco.\n";
            else if (!nValidar.SoloXYDigitos(tbxLibroStockMinimo.Text.Trim(), 1, 2))
                mensaje += "El STOCK MINIMO tiene un formato incorrecto. Debe ser un número entre 0 y 99.\n";
            //Lo siguiente continua con el "else if" para poder comparar stock minimo y deseable,
            //para que no tire error si no se ingreso texto en alguno de ellos.
            else if (nValidar.CadenaVacia(tbxLibroStockDeseable.Text.Trim()))
                mensaje += "El STOCK DESEABLE no puede estar en blanco.\n";
            else if (!nValidar.SoloXYDigitos(tbxLibroStockDeseable.Text.Trim(), 1, 2))
                mensaje += "El STOCK DESEABLE tiene un formato incorrecto. Debe ser un número entre 0 y 99.\n";
            else if (Convert.ToInt32(tbxLibroStockMinimo.Text.Trim()) > Convert.ToInt32(tbxLibroStockDeseable.Text.Trim()))
                mensaje += "El STOCK DESEABLE no puedo ser inferior al STOCK MINIMO";

            if (nValidar.CadenaVacia(tbxLibroStockActual.Text.Trim()))
                mensaje += "El STOCK ACTUAL no puede estar en blanco.\n";
            else if (!Regex.IsMatch(tbxLibroStockActual.Text.Trim(), @"^\d{1,2}$"))
                mensaje += "El STOCK ACTUAL tiene un formato incorrecto. Debe ser un número entre 0 y 99.\n";

            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxLibroIsbn.Focus();
                tbxLibroIsbn.SelectAll();
                return false;
            }
            return true;
        }

        //Ver elementos deshabilitados
        private void VerElementosDeshabilitados()
        {
            //El formulario frmElementosDeshabilitados devuelve Yes si se modifico algo,
            //es decir, si se presiono el boton "Habilitar" alguna vez. Por lo tanto, recarga
            //los Comboboxes
            if (new frmElementosDeshabilitados().ShowDialog() == DialogResult.Yes)
            {
                CategoriaRellenarCombobox();
            }
        }

        private void MostrarAyuda()
        {
            Negocio.Ayuda nAyuda = new HP.Negocio.Ayuda();
            Help.ShowHelp(this, nAyuda.URLAyuda(), HelpNavigator.KeywordIndex, this.Text);
        }

        #endregion

    }
}