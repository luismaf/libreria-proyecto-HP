using System;
using System.Collections.Generic;
using System.Text;

namespace HP.Negocio
{
    public class Libros
    {
        Datos.Libro oDatos = new HP.Datos.Libro();

        public Entidades.Libros ObtenerTodos(int id_colec)
        { return oDatos.ObtenerTodos(id_colec); }

        public Entidades.Libro ObtenerUno(int id_libro)
        { return oDatos.ObtenerUno(id_libro); }

        public Entidades.Libros ObtenerDeshabilitados()
        { return oDatos.ObtenerDeshabilitados(); }

        public int Agregar(Entidades.Libro libro)
        { return oDatos.Agregar(libro); }

        public int Editar(Entidades.Libro libro)
        { return oDatos.Editar(libro); }

        public void EstablecerHabilitacion(int id_libro, int habilitado)
        { oDatos.EstablecerHabilitacion(id_libro, habilitado); }

        public Entidades.Libros ObtenerListadoFaltantes(int id_prov)
        { return oDatos.ObtenerListadoFaltantes(id_prov); }

        public Entidades.Libros Buscar(string isbn, string titulo_libro, string titulo_colec)
        {
            //Remplaza los espacios blancos por el % y agrega un % al comienzo y otro al final del string
            string paramIsbn = "%" + isbn.Replace(' ', '%') + "%";
            string paramTitulo_libro = "%" + titulo_libro.Replace(' ', '%') + "%";
            string paramTitulo_colec = "%" + titulo_colec.Replace(' ', '%') + "%";    

            return oDatos.Buscar(paramIsbn, paramTitulo_libro, paramTitulo_colec);
        }
    }
}
