using System;
using System.Collections.Generic;
using System.Text;

namespace HP.Entidades
{
    public class Proveedor
    {
        #region Propiedades

        private int id_prov;
        private long cuit_prov;
        private string razon_social;
        private string telefono;
        private string email_prov;
     //   private long nro_cta_bca;
        private bool habilitado;

        public int Id_prov
        {
            get { return id_prov; }
            set { id_prov = value; }
        }

        public long Cuit_prov
        {
            get { return cuit_prov; }
            set { cuit_prov = value; }
        }

        public string Razon_social
        {
            get { return razon_social; }
            set { razon_social = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Email_prov
        {
            get { return email_prov; }
            set { email_prov = value; }
        }
/*
        public long Nro_cta_bca
        {
            get { return nro_cta_bca; }
            set { nro_cta_bca = value; }
        }
*/
        public bool Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }

        #endregion
    }
}
