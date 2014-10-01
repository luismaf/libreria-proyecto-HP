using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HP.Negocio
{
    public class Validaciones
    {
        public bool CadenaVacia(string cadena)
        {
            return cadena == "" ? true : false;
        }

        public bool Nro1MenorQueNro2(float nro1, float nro2)
        {
            return nro1 < nro2 ? true : false;
        }

        public bool SoloXYDigitos(string cadena, int minimoXDigitos, int maximoYDigitos)
        {
            return Regex.IsMatch(cadena, @"^\d{" + minimoXDigitos + "," + maximoYDigitos + "}$");
        }
    }
}
