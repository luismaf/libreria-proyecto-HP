using System;
using System.Collections.Generic;
using System.Text;

namespace HP.Entidades
{
    public class Libro
    {
        #region Propiedades

        private int id_libro;
        private long isbn;
        private string titulo_libro;
        private int stock_minimo;
        private int stock_actual;
        private int stock_deseable;
        private string resena;
        private int cant_pedida;
        private bool habilitado_libro;
        private Entidades.Coleccion colec;

        public int Id_libro
        {
            get { return id_libro; }
            set { id_libro = value; }
        }

        public long Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Titulo_libro
        {
            get { return titulo_libro; }
            set { titulo_libro = value; }
        }

        public int Stock_minimo
        {
            get { return stock_minimo; }
            set { stock_minimo = value; }
        }

        public int Stock_deseable
        {
            get { return stock_deseable; }
            set { stock_deseable = value; }
        }

        public int Stock_actual
        {
            get { return stock_actual; }
            set { stock_actual = value; }
        }

        public string Resena
        {
            get { return resena; }
            set { resena = value; }
        }

        public int Cant_pedida
        {
            get { return cant_pedida; }
            set { cant_pedida = value; }
        }

        public bool Habilitado_Libro
        {
            get { return habilitado_libro; }
            set { habilitado_libro = value; }
        }

        public Entidades.Coleccion Colec
        {
            get { return colec; }
            set { colec = value; }
        }

        #endregion
    }
}
