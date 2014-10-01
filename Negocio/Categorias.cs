using System;
using System.Collections.Generic;
using System.Text;

namespace HP.Negocio
{
    public class Categorias
    {
        Datos.Categoria oDatos = new HP.Datos.Categoria();

        #region Metodos

        public Entidades.Categorias ObtenerTodas()
        { return oDatos.ObtenerTodas(); }

        public Entidades.Categorias ObtenerDeshabilitadas()
        { return oDatos.ObtenerDeshabilitadas(); }

        public int Agregar(Entidades.Categoria categoria)
        { return oDatos.Agregar(categoria); }

        public int Editar(Entidades.Categoria categoria)
        { return oDatos.Editar(categoria); }

        public void EstablecerHabilitacion(int id_categ, int habilitada)
        { oDatos.EstablecerHabilitacion(id_categ, habilitada); }

        public String ValidarStockCero(int id_categ)
        {
            Colecciones nColecciones = new Colecciones();
            Entidades.Colecciones colecciones = nColecciones.ObtenerTodas(id_categ);
            String strLibros = "";
            Entidades.Libros libros = new HP.Entidades.Libros();
            Datos.Libro oLibro = new HP.Datos.Libro();

            foreach (Entidades.Coleccion coleccion in colecciones)
            {
                foreach (Entidades.Libro libro in oLibro.ObtenerTodos(coleccion.Id_colec))
                {
                    if (libro.Stock_actual != 0)
                    {
                        strLibros += libro.Titulo_libro + "\n";
                    }
                }
            }
            return strLibros;
        }

        #endregion
    }
}
