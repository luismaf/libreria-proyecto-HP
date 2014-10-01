using System;
using System.Collections.Generic;
using System.Text;

namespace HP.Entidades
{
    public class Coleccion
    {
        #region Propiedades

        private int id_colec;
        private string cod_colec;
        private string titulo_colec;
        private string descripcion_colec;
        private string tamano;
        private int cant_pags;
        private string encuadernacion;
        private int edad_sugerida;
        private float precioCompra;
        private float precioVenta;
        private bool habilitada_colec;
        private Entidades.Categoria categ;
        private Entidades.Proveedor prov;

        public int Id_colec
        {
            get { return id_colec; }
            set { id_colec = value; }
        }
        
        public string Cod_colec
        {
            get { return cod_colec; }
            set { cod_colec = value; }
        }
                
        public string Titulo_colec
        {
            get { return titulo_colec; }
            set { titulo_colec = value; }
        }

        public string Descripcion_colec
        {
            get { return descripcion_colec; }
            set { descripcion_colec = value; }
        }

        public string Tamano
        {
            get { return tamano; }
            set { tamano = value; }
        }

        public int Cant_pags
        {
            get { return cant_pags; }
            set { cant_pags = value; }
        }

        public string Encuadernacion
        {
            get { return encuadernacion; }
            set { encuadernacion= value; }
        }

        public int Edad_sugerida
        {
            get { return edad_sugerida; }
            set { edad_sugerida = value; }
        }

        public float PrecioCompra
        {
            get { return precioCompra; }
            set { precioCompra = value; }
        }

        public float PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }

        public bool Habilitada_Colec
        {
            get { return habilitada_colec; }
            set { habilitada_colec = value; }
        }

        public Entidades.Categoria Categ
        {
            get { return categ; }
            set { categ = value; }
        }

        public Entidades.Proveedor Prov
        {
            get { return prov; }
            set { prov = value; }
        }

        #endregion
    }
}
