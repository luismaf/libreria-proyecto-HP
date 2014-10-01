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
    public partial class frmAgregarAlListadoFaltantes : Form
    {
        int id_prov;
        Entidades.Libros libros;

        #region Propiedades

        private Entidades.Libros librosAAgregar;

        public Entidades.Libros LibrosAAgregar
        {
            get { return librosAAgregar; }
            set { librosAAgregar = value; }
        }

        #endregion

        #region Constructor

        public frmAgregarAlListadoFaltantes(int id_proveedor)
        {
            InitializeComponent();
            id_prov = id_proveedor;
        }

        #endregion

        #region Eventos

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VaciarGrilla();
            BuscarLibros();
        }

        private void btnAgregarYSalir_Click(object sender, EventArgs e)
        {
            ObtenerLibrosAAgregar();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAgregarYVolverABuscar_Click(object sender, EventArgs e)
        {
            ObtenerLibrosAAgregar();
            DialogResult = DialogResult.Retry;
            VaciarGrilla();
            VaciarTextBoxes();
            tbxIsbn.Focus();
            this.Close();
        }

        #endregion

        #region Métodos

        public void BuscarLibros()
        {
            string isbn = tbxIsbn.Text.Trim();
            string titulo_libro = tbxTitulo_Libro.Text.Trim();
            string titulo_colec = tbxTitulo_Colec.Text.Trim();

            if (ValidarIngresos(isbn, titulo_libro, titulo_colec))
            {
                Negocio.Libros nLibros = new HP.Negocio.Libros();
                libros = nLibros.Buscar(isbn, titulo_libro, titulo_colec);

                if (libros.Count == 0)
                {
                    MessageBox.Show("La búsqueda no obtuvo ningun resultado", "Búsqueda",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
                bool agregar = false;

                foreach (Entidades.Libro libro in libros)
                {
                    this.dgvListadoLibros.Rows.Add(libro.Id_libro, libro.Colec.Prov.Id_prov, libro.Isbn,
                        libro.Colec.Categ.Nombre_categ, libro.Colec.Prov.Razon_social, libro.Colec.Titulo_colec,
                        libro.Titulo_libro, libro.Colec.PrecioCompra, agregar);
                    
                    if (id_prov != libro.Colec.Prov.Id_prov) 
                    {
                        int indiceUltimaFila = (this.dgvListadoLibros.Rows.Count) - 1;
                        this.dgvListadoLibros.Rows[indiceUltimaFila].DefaultCellStyle.ForeColor = Color.Red;
                        this.dgvListadoLibros.Rows[indiceUltimaFila].Cells["colAgregar"].ReadOnly = true;
                        this.dgvListadoLibros.Rows[indiceUltimaFila].Cells["colAgregar"].ToolTipText =
                                "Este libro no puede ser agregado ya que pertenece a un PROVEEDOR diferente " +
                                "al correspondiente al listado de faltantes en construccion";

                    }
                }
            }
        }

        public void VaciarGrilla()
        {
            this.dgvListadoLibros.Rows.Clear();
        }

        public bool ValidarIngresos(string isbn, string titulo_libro, string titulo_colec)
        {
            string mensaje = "";

            if (isbn == "" && titulo_libro == "" && titulo_colec == "")
                mensaje += "Debe ingresar algún atributo de búsqueda en por lo menos uno de los campos.\n";


            if (isbn != "" && !Regex.IsMatch(isbn, @"^\d+$"))
                mensaje += "En el campo \"ISBN\" solo se pueden ingresar números enteros";

            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Ingreso Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxIsbn.Focus();
                tbxIsbn.SelectAll();
                return false;
            }

            return true;

        }

        public void ObtenerLibrosAAgregar()
        {
            librosAAgregar = new HP.Entidades.Libros();

            foreach (DataGridViewRow row in dgvListadoLibros.Rows)
            {
                if (Convert.ToBoolean(row.Cells["colAgregar"].Value))
                {
                    int id_libro = Convert.ToInt32(row.Cells["colId_libro"].Value);

                    foreach (Entidades.Libro libro in libros)
                    {
                        if (id_libro == libro.Id_libro)
                        {
                            librosAAgregar.Add(libro);
                            break;
                        }
                    }
                }
            }
        }

        public void VaciarTextBoxes()
        {
            tbxIsbn.Text = "";
            tbxTitulo_Colec.Text = "";
            tbxTitulo_Libro.Text = "";
        }

        #endregion
                        
    }
}