using System;
using System.Collections.Generic;
using System.Text;

namespace HP.Negocio
{
    public class Lineas_Pedido
    {
        Datos.Linea_Pedido oLinea_pedido = new HP.Datos.Linea_Pedido();

        public void Agregar(Entidades.Linea_Pedido linea)
        { oLinea_pedido.Agregar(linea); }

        public Entidades.Lineas_Pedido ObtenerTodasNoEntregadas(int id_compra)
        { return oLinea_pedido.ObtenerTodasNoEntregadas(id_compra); }

        public Entidades.Lineas_Pedido ObtenerTodasEntregadas(int id_compra)
        { return oLinea_pedido.ObtenerTodasEntregadas(id_compra); }
    }
}
