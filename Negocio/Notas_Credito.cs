using System;
using System.Collections.Generic;
using System.Text;

namespace HP.Negocio
{
    public class Notas_Credito
    {
        Datos.Nota_Credito oNota_Credito = new HP.Datos.Nota_Credito();

        public Entidades.Compra ObtenerNCUtilizadas(Entidades.Compra compra)
        { return oNota_Credito.ObtenerNCUtilizadas(compra); }

        public Entidades.Notas_Credito ObtenerTodasConSaldoUnProveedor(int id_prov)
        { return oNota_Credito.ObtenerTodasConSaldoUnProveedor(id_prov); }
    }
}
