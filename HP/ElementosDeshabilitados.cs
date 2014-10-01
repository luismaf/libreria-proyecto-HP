using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HP.Presentacion
{
    public partial class frmElementosDeshabilitados : Form
    {
        bool modificado = false;

        #region Constructor

        public frmElementosDeshabilitados()
        {
            InitializeComponent();
            CargarGrilla();
        }

        #endregion

        #region Eventos

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (dgvElementosDeshabilitados.Rows.Count != 0)
            { Habilitar(); }
        }

        private void frmElementosDeshabilitados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modificado == true)
            {
                DialogResult = DialogResult.Yes;
            }
        }

        #endregion

        #region Métodos

        public void CargarGrilla()
        {
            Negocio.Categorias nCategoria = new HP.Negocio.Categorias();
            Entidades.Categorias categorias = nCategoria.ObtenerDeshabilitadas();
            
            Negocio.Colecciones nColeccion = new HP.Negocio.Colecciones();
            Entidades.Colecciones colecciones = nColeccion.ObtenerDeshabilitadas();
            
            Negocio.Libros nLibro = new HP.Negocio.Libros();
            Entidades.Libros libros = nLibro.ObtenerDeshabilitados();

            bool categCargada;
            bool colecCargada;
            int indiceUltimaFila;

            #region Libros Deshabilitados
            
            #region Comentario importante
            /*
            El codigo correspondiente a esta seccion esta emparchado para funcionar bien.
            Deberia comparar la categoria y coleccion a la cual pertenece el libro con la categoria y/o coleccion
            que se encuentra presente en la row actual para verificar si la debe insertar antes, despues o
            no insertar en caso de que ya exista.
            Como esta aca, la BD devuelve primero novelas y despues diccionarios por ejemplo, entonces lo carga en
            ese orden y cuando el codigo llega a la region "Colecciones deshabilitadas", este esta escrito de manera
            que sí compare y al ver primero novelas va a insertar la coleccion diccionarios antes que esta y como ya
            se cargo anteriormente va a aparecer dos veces.
            Para emparcharlo se le puso un ORDER BY en el sotred procedure "LibrosDevolverDeshabilitados" para que
            devuelva diccionarios antes que novelas y de esta manera funciona bien, pero repito que para hacerlo como
            corresponde deberia modificar el codigo en la presente region (Libros Deshabilitados) para que compare
            como se hizo en las regiones "Colecciones deshabilitadas" y "Categorias Deshabilitadas"
            
            A su vez, se deberia reutilizar en este metodo CargarGrilla pero se lo repite para una lectura mas clara
            y comoda
            */
            #endregion

            foreach (Entidades.Libro libro in libros)
            {
                categCargada = false;
                colecCargada = false;

                //Si la categoria no se cargo anteriormente se carga
                foreach (DataGridViewRow row in dgvElementosDeshabilitados.Rows)
                {   
                    if (libro.Colec.Categ.Id_categ == Convert.ToInt32(row.Cells["colIdCateg"].Value))
                    {
                        categCargada = true;
                        break;
                    }
                }
                if (!categCargada)
                {
                    dgvElementosDeshabilitados.Rows.Add(libro.Colec.Categ.Id_categ,
                                                        libro.Colec.Categ.Habilitada_Categ,
                                                        libro.Colec.Categ.Nombre_categ,
                                                        null, null, null, null, null);
                    indiceUltimaFila = (dgvElementosDeshabilitados.Rows.Count - 1);
                    dgvElementosDeshabilitados.Rows[indiceUltimaFila].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                    
                    //Si esta deshabilitada la letra es de color rojo
                    if (!libro.Colec.Categ.Habilitada_Categ)
                    {
                        dgvElementosDeshabilitados.Rows[indiceUltimaFila].DefaultCellStyle.ForeColor = Color.Red;
                        dgvElementosDeshabilitados.Rows[indiceUltimaFila].DefaultCellStyle.SelectionForeColor = Color.Red;
                    }

                }

                //Si la coleccion no se cargo anteriormente se carga
                foreach (DataGridViewRow row2 in dgvElementosDeshabilitados.Rows)
                {
                    if (libro.Colec.Id_colec == Convert.ToInt32(row2.Cells["colIdColec"].Value))
                    {
                        colecCargada = true;
                        break;
                    }
                }
                if (!colecCargada)
                {
                    dgvElementosDeshabilitados.Rows.Add(libro.Colec.Categ.Id_categ,
                                                        null, null,
                                                        libro.Colec.Id_colec,
                                                        libro.Colec.Habilitada_Colec,
                                                        libro.Colec.Titulo_colec,
                                                        null, null);
                    indiceUltimaFila = (dgvElementosDeshabilitados.Rows.Count - 1);
                    dgvElementosDeshabilitados.Rows[indiceUltimaFila].Cells["colTituloColec"].Style.BackColor = Color.PaleGoldenrod;
                    dgvElementosDeshabilitados.Rows[indiceUltimaFila].Cells["colTitulolibro"].Style.BackColor = Color.PaleGoldenrod;
                    //Si esta deshabilitada la letra es de color rojo
                    if (!libro.Colec.Habilitada_Colec)
                    {
                        dgvElementosDeshabilitados.Rows[indiceUltimaFila].DefaultCellStyle.ForeColor = Color.Red;
                        dgvElementosDeshabilitados.Rows[indiceUltimaFila].DefaultCellStyle.SelectionForeColor = Color.Red;
                    }
                }

                //Se carga los libros, los cuales no pueden ser repetidos, por lo que no se valida
                dgvElementosDeshabilitados.Rows.Add(libro.Colec.Categ.Id_categ, null, null,
                                                    libro.Colec.Id_colec, null, null,
                                                    libro.Id_libro, libro.Titulo_libro);
                //Todos los libros que aparezcan estaran deshabilitados, por lo tanto su letra es roja
                indiceUltimaFila = (dgvElementosDeshabilitados.Rows.Count - 1);
                dgvElementosDeshabilitados.Rows[indiceUltimaFila].DefaultCellStyle.ForeColor = Color.Red;
                dgvElementosDeshabilitados.Rows[indiceUltimaFila].DefaultCellStyle.SelectionForeColor = Color.Red;
            }
            #endregion

            #region Colecciones Deshabilitadas
            foreach (Entidades.Coleccion coleccion in colecciones)
            {
                categCargada = false;
                colecCargada = false;
                int indiceActual = -1;

                //Si la categoria no se cargo anteriormente se carga
                foreach (DataGridViewRow row in dgvElementosDeshabilitados.Rows)
                {
                    if (row.Cells["colNombreCateg"].Value != null)
                    {
                        int comparaCateg = String.Compare(row.Cells["colNombreCateg"].Value.ToString(),
                                                        coleccion.Categ.Nombre_categ);

                        if (comparaCateg == 0)
                        {
                            categCargada = true;
                            indiceActual = (row.Index + 1);
                            
                            while (Convert.ToInt32(dgvElementosDeshabilitados.Rows[indiceActual].Cells["colIdCateg"].Value) ==
                            coleccion.Categ.Id_categ)
                            {
                                if (dgvElementosDeshabilitados.Rows[indiceActual].Cells["colTituloColec"].Value != null)
                                {
                                    //Devuelve 1 si es mayor, 0 si son iguales, -1 es menor
                                    int comparaColec = String.Compare(dgvElementosDeshabilitados.Rows[indiceActual].Cells["colTituloColec"].Value.ToString(),
                                                        coleccion.Titulo_colec);

                                    //Si es 0, la coleccion ya fue cargada
                                    if (comparaColec == 0)
                                    {
                                        colecCargada = true;
                                        break;
                                    }
                                    //si es 1, es menor a la coleccion en la fila actual, por lo que tengo
                                    //que insertarla en esa fila, desplazando una hacia adelante la actual
                                    else if (comparaColec == 1)
                                    {
                                        dgvElementosDeshabilitados.Rows.Insert(indiceActual,
                                                                                coleccion.Categ.Id_categ,
                                                                                null, null,
                                                                                coleccion.Id_colec,
                                                                                coleccion.Habilitada_Colec,
                                                                                coleccion.Titulo_colec,
                                                                                null, null, null);
                                        dgvElementosDeshabilitados.Rows[indiceActual].Cells["colTituloColec"].Style.BackColor = Color.PaleGoldenrod;
                                        dgvElementosDeshabilitados.Rows[indiceActual].Cells["colTitulolibro"].Style.BackColor = Color.PaleGoldenrod;
                                        dgvElementosDeshabilitados.Rows[indiceActual].DefaultCellStyle.ForeColor = Color.Red;
                                        dgvElementosDeshabilitados.Rows[indiceActual].DefaultCellStyle.SelectionForeColor = Color.Red;
                                        colecCargada = true;
                                        break;
                                    }
                                }

                                indiceActual++;
                                if (indiceActual == dgvElementosDeshabilitados.Rows.Count)
                                { break; }
                            }

                            //Si todavia no fue cargada va a lo ultimo del
                            //grupo correspondiente a su categoria
                            if (!colecCargada)
                            {
                                dgvElementosDeshabilitados.Rows.Insert(indiceActual,
                                                                coleccion.Categ.Id_categ,
                                                                null, null,
                                                                coleccion.Id_colec,
                                                                coleccion.Habilitada_Colec,
                                                                coleccion.Titulo_colec,
                                                                null, null, null);
                                dgvElementosDeshabilitados.Rows[indiceActual].Cells["colTituloColec"].Style.BackColor = Color.PaleGoldenrod;
                                dgvElementosDeshabilitados.Rows[indiceActual].Cells["colTitulolibro"].Style.BackColor = Color.PaleGoldenrod;
                                dgvElementosDeshabilitados.Rows[indiceActual].DefaultCellStyle.ForeColor = Color.Red;
                                dgvElementosDeshabilitados.Rows[indiceActual].DefaultCellStyle.SelectionForeColor = Color.Red;

                                colecCargada = true;
                            }
                            break;
                        }
                        else if (comparaCateg == 1)
                        {
                            dgvElementosDeshabilitados.Rows.Insert(row.Index,
                                                                    coleccion.Categ.Id_categ,
                                                                    coleccion.Categ.Habilitada_Categ,
                                                                    coleccion.Categ.Nombre_categ,
                                                                    null, null, null, null, null);
                            dgvElementosDeshabilitados.Rows[row.Index - 1].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                            //Si esta deshabilitada la letra es de color rojo
                            if (!coleccion.Categ.Habilitada_Categ)
                            {
                                dgvElementosDeshabilitados.Rows[row.Index - 1].DefaultCellStyle.ForeColor = Color.Red;
                                dgvElementosDeshabilitados.Rows[row.Index - 1].DefaultCellStyle.SelectionForeColor = Color.Red;
                            }

                            //Si la categoria no estaba cargada entonces la coleccion tampoco, por lo tanto no se valida.
                            dgvElementosDeshabilitados.Rows.Insert(row.Index,
                                                                coleccion.Categ.Id_categ,
                                                                null, null,
                                                                coleccion.Id_colec,
                                                                coleccion.Habilitada_Colec,
                                                                coleccion.Titulo_colec,
                                                                null, null);
                            dgvElementosDeshabilitados.Rows[row.Index - 1].Cells["colTituloColec"].Style.BackColor = Color.PaleGoldenrod;
                            dgvElementosDeshabilitados.Rows[row.Index - 1].Cells["colTitulolibro"].Style.BackColor = Color.PaleGoldenrod;

                            //En este punto todas las colecciones que se carguen estaran deshabilitdas
                            //por lo que no hace falta validar su habilitacion para ponerlas de rojo
                            dgvElementosDeshabilitados.Rows[row.Index - 1].DefaultCellStyle.ForeColor = Color.Red;
                            dgvElementosDeshabilitados.Rows[row.Index - 1].DefaultCellStyle.SelectionForeColor = Color.Red;

                            categCargada = true;
                            colecCargada = true;
                            break;
                        }
                    }
                }

                //Si todavia no se cargo la categoria, la cargo al final, como asi tambien la coleccion
                if (!categCargada)
                {
                    dgvElementosDeshabilitados.Rows.Add(coleccion.Categ.Id_categ,
                                                        coleccion.Categ.Habilitada_Categ,
                                                        coleccion.Categ.Nombre_categ,
                                                        null, null, null, null, null);
                    indiceUltimaFila = (dgvElementosDeshabilitados.Rows.Count - 1);
                    dgvElementosDeshabilitados.Rows[indiceUltimaFila].DefaultCellStyle.BackColor = Color.LightSteelBlue;

                    //Si esta deshabilitada la letra es de color rojo
                    if (!coleccion.Categ.Habilitada_Categ)
                    {
                        dgvElementosDeshabilitados.Rows[indiceUltimaFila].DefaultCellStyle.ForeColor = Color.Red;
                        dgvElementosDeshabilitados.Rows[indiceUltimaFila].DefaultCellStyle.SelectionForeColor = Color.Red;
                    }

                    //Si la categoria no estaba cargada entonces la coleccion tampoco, por lo tanto no se valida.
                    dgvElementosDeshabilitados.Rows.Add(coleccion.Categ.Id_categ, null, null,
                                                        coleccion.Id_colec,
                                                        coleccion.Habilitada_Colec,
                                                        coleccion.Titulo_colec,
                                                        null, null);
                    indiceUltimaFila = (dgvElementosDeshabilitados.Rows.Count - 1);
                    dgvElementosDeshabilitados.Rows[indiceUltimaFila].Cells["colTituloColec"].Style.BackColor = Color.PaleGoldenrod;
                    dgvElementosDeshabilitados.Rows[indiceUltimaFila].Cells["colTitulolibro"].Style.BackColor = Color.PaleGoldenrod;

                    //En este punto todas las colecciones que se carguen estaran deshabilitdas
                    //por lo que no hace falta validar su habilitacion para ponerlas de rojo
                    dgvElementosDeshabilitados.Rows[indiceUltimaFila].DefaultCellStyle.ForeColor = Color.Red;
                    dgvElementosDeshabilitados.Rows[indiceUltimaFila].DefaultCellStyle.SelectionForeColor = Color.Red;
                }
            }
            #endregion

            #region Categorias Deshabilitadas
            foreach (Entidades.Categoria categoria in categorias)
            {
                categCargada = false;

                //Si la categoria no se cargo anteriormente se carga
                foreach (DataGridViewRow row in dgvElementosDeshabilitados.Rows)
                {
                    //Comprueba que haya un valor en la columna "Coleccion". Por ej. en
                    //las filas correspondientes a libros no hay ninguna valor en las
                    //columnas "Categoria" y "Coleccion"
                    if (row.Cells["colNombreCateg"].Value != null)
                    {

                        //Devuelve 1 si es mayor, 0 si son iguales, -1 es menor
                        int comparacion = String.Compare(row.Cells["colNombreCateg"].Value.ToString(),
                                            categoria.Nombre_categ);

                        if (comparacion == 0)
                        {
                            categCargada = true;
                            break;
                        }
                        else if (comparacion == 1)
                        {
                            dgvElementosDeshabilitados.Rows.Insert(row.Index,
                                                            categoria.Id_categ,
                                                            categoria.Habilitada_Categ,
                                                            categoria.Nombre_categ,
                                                            null, null, null, null, null);
                            dgvElementosDeshabilitados.Rows[row.Index-1].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                            //Todas las categorias en esta cargadas en esta region estan deshabilitadas
                            dgvElementosDeshabilitados.Rows[row.Index-1].DefaultCellStyle.ForeColor = Color.Red;
                            dgvElementosDeshabilitados.Rows[row.Index-1].DefaultCellStyle.SelectionForeColor = Color.Red;

                            categCargada = true;
                            break;
                        }
                    }
                }
                //Si todavia no fue cargada es porque no estaba cargada y va a lo ultimo
                //alfabeticamente
                if (!categCargada)
                {
                    dgvElementosDeshabilitados.Rows.Add(categoria.Id_categ,
                                                        categoria.Habilitada_Categ,
                                                        categoria.Nombre_categ,
                                                        null, null, null, null, null);

                    indiceUltimaFila = (dgvElementosDeshabilitados.Rows.Count - 1);
                    dgvElementosDeshabilitados.Rows[indiceUltimaFila].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                    //Todas las categorias en esta cargadas en esta region estan deshabilitadas
                    dgvElementosDeshabilitados.Rows[indiceUltimaFila].DefaultCellStyle.ForeColor = Color.Red;
                    dgvElementosDeshabilitados.Rows[indiceUltimaFila].DefaultCellStyle.SelectionForeColor = Color.Red;
                }
            }
            #endregion

        }

        //Si se habilita algun elemento, se asigna true a la variable modificado
        public void Habilitar()
        {
            int id = -1;
            int indiceFila = dgvElementosDeshabilitados.SelectedCells[0].RowIndex;

            if (dgvElementosDeshabilitados.SelectedCells[0].Value != null)
            {
                int indiceColumna = dgvElementosDeshabilitados.SelectedCells[0].ColumnIndex;

                //Indices de columna: Categoria = 2, Coleccion = 5, Libro = 7
                switch (indiceColumna)
                {
                    case 7:
                        id = Convert.ToInt32(dgvElementosDeshabilitados.Rows[indiceFila].Cells["colIdLibro"].Value);

                        Negocio.Libros nLibro = new HP.Negocio.Libros();
                        nLibro.EstablecerHabilitacion(id, 1);

                        HabilitarColeccion(indiceFila);
                        HabilitarCategoria(indiceFila);

                        modificado = true;
                        break;
                    
                    case 5:
                        HabilitarColeccion(indiceFila);
                        HabilitarCategoria(indiceFila);
                        break;

                    case 2:
                        HabilitarCategoria(indiceFila);
                        break;
                }

                if (modificado)
                {
                    dgvElementosDeshabilitados.Rows.Clear();
                    CargarGrilla();
                }
            }
        }

        public void HabilitarColeccion(int indiceFila)
        {
            if (!Convert.ToBoolean(dgvElementosDeshabilitados.Rows[indiceFila].Cells["colHabilitadaColec"].Value))
            {
                int id = Convert.ToInt32(dgvElementosDeshabilitados.Rows[indiceFila].Cells["colIdColec"].Value);

                Negocio.Colecciones nColeccion = new HP.Negocio.Colecciones();
                nColeccion.EstablecerHabilitacion(id, 1);
                modificado = true;
            }
        }

        public void HabilitarCategoria(int indiceFila)
        {
            if (!Convert.ToBoolean(dgvElementosDeshabilitados.Rows[indiceFila].Cells["colHabilitadaCateg"].Value))
            {
                int id = Convert.ToInt32(dgvElementosDeshabilitados.Rows[indiceFila].Cells["colIdCateg"].Value);

                Negocio.Categorias nCategoria = new HP.Negocio.Categorias();
                nCategoria.EstablecerHabilitacion(id, 1);
                modificado = true;
            }
        }

        #endregion

    }
}