using System;
using System.Collections.Generic;
using System.Text;

namespace HP.Negocio
{
    public class Ayuda
    {
        public string URLAyuda()
        {
            string path = Environment.CurrentDirectory.Replace("HP\\bin\\Debug",
                               "Datos\\Manual de Usuario\\manual de usuario.chm");

            return path;
        }
    }
}
