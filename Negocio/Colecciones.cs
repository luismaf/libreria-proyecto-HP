using System;
using System.Collections.Generic;
using System.Text;

namespace HP.Negocio
{
    public class Colecciones
    {
        Datos.Coleccion oDatos = new HP.Datos.Coleccion();

        #region Metodos

        public Entidades.Colecciones ObtenerTodas(int id_categ)
        { return oDatos.ObtenerTodas(id_categ); }

        public Entidades.Coleccion ObtenerUna(int id_colec)
        { return oDatos.ObtenerUna(id_colec); }

        public Entidades.Colecciones ObtenerDeshabilitadas()
        { return oDatos.ObtenerDeshabilitadas(); }

        public int Agregar(Entidades.Coleccion coleccion)
        { return oDatos.Agregar(coleccion); }

        public int Editar(Entidades.Coleccion coleccion)
        { return oDatos.Editar(coleccion); }

        public void EstablecerHabilitacion(int id_colec, int habilitada)
        { oDatos.EstablecerHabilitacion(id_colec, habilitada); }

        public String ValidarStockCero(int id_colec)
        {
            Entidades.Libros libros = new HP.Entidades.Libros();
            Datos.Libro oLibro = new HP.Datos.Libro();

            String strLibros = "";
            foreach (Entidades.Libro libro in oLibro.ObtenerTodos(id_colec))
            {
                if (libro.Stock_actual != 0)
                {
                    strLibros += libro.Titulo_libro + "\n";
                }
            }
            return strLibros;
        }

        public void ActualizarPrecioVenta(int id_colec, float precioVenta)
        { oDatos.ActualizarPrecioVenta(id_colec, precioVenta); }

        public string ActualizarPrecioCompra(int id_colec, float precioCompra)
        { return oDatos.ActualizarPrecioCompra(id_colec, precioCompra); }

        public float ObtenerPrecioVentaVigente(int id_colec)
        { return oDatos.ObtenerPrecioVentaVigente(id_colec); }

        #endregion
    }
}
