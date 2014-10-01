using System;
using System.Collections.Generic;
using System.Text;

namespace HP.Entidades
{
    public class Categoria
    {
        #region Propiedades

        private int id_categ;
        private string nombre_categ;
        private bool habilitada_categ;

        public int Id_categ
        {
            get { return id_categ; }
            set { id_categ = value; }
        }

        public string Nombre_categ
        {
            get { return nombre_categ; }
            set { nombre_categ = value; }
        }

        public bool Habilitada_Categ
        {
            get { return habilitada_categ; }
            set { habilitada_categ = value; }
        }

        #endregion
    }
}
