using System;
using System.Collections.Generic;
using System.Text;

namespace HP.Negocio
{
    public class Proveedores
    {
        Datos.Proveedor oDatos = new HP.Datos.Proveedor();

        #region Métodos

        public Entidades.Proveedores ObtenerHabilitados()
        { return oDatos.ObtenerHabilitados(); }

        public Entidades.Proveedores ObtenerTodos()
        { return oDatos.ObtenerTodos(); }

        public int Agregar(Entidades.Proveedor proveedor)
        { return oDatos.Agregar(proveedor); }

        public int Editar(Entidades.Proveedor proveedor)
        { return oDatos.Editar(proveedor); }

        public void EstablecerHabilitacion(int id_prov, int habilitado)
        { oDatos.EstablecerHabilitacion(id_prov, habilitado); }

        public Entidades.Compras ValidarPedidosPendientes(int id_prov)
        { return oDatos.ValidarPedidosPendientes(id_prov); }

        #endregion
    }
}
