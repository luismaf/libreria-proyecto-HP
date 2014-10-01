using System;
using System.Collections.Generic;
using System.Text;

namespace HP.Entidades
{
    public class Linea_Pedido
    {
        #region Propiedades

        private int id_linea_pedido;
        private int id_compra;
        private Entidades.Libro libro;
        private int cant_pedida;
        //private Nullable<int> cant_entregada;
        private Nullable<int> cant_aceptada;

        public int Id_Linea_Pedido
        {
            get { return id_linea_pedido; }
            set { id_linea_pedido = value; }
        }

        public int Id_compra
        {
            get { return id_compra; }
            set { id_compra = value; }
        }
        
        public Entidades.Libro Libro
        {
            get { return libro; }
            set { libro = value; }
        }

        public int Cant_pedida
        {
            get { return cant_pedida; }
            set { cant_pedida = value; }
        }

/*      public Nullable<int> Cant_entregada
        {
            get { return cant_entregada; }
            set { cant_entregada = value; }
        }
*/

        public Nullable<int> Cant_aceptada
        {
            get { return cant_aceptada; }
            set { cant_aceptada = value; }
        }


        #endregion

    }
}
