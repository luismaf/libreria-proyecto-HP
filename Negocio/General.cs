using System;
using System.Collections.Generic;
using System.Text;

namespace HP.Negocio
{
    public class General
    {
        #region Metodos

        public int RealizarBackUpCompleto(string ruta)
        {
            Datos.General oDatos = new HP.Datos.General();
            return oDatos.RealizarBackUpCompleto(ruta);
        }

        public int RestaurarBase(string ruta)
        {
            Datos.General oDatos = new HP.Datos.General();
            return oDatos.RestaurarBase(ruta);
        }

        #endregion
    }
}
