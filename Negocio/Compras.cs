using System;
using System.Collections.Generic;
using System.Text;

namespace HP.Negocio
{
    public class Compras
    {
        Datos.Compra oCompra = new HP.Datos.Compra();

        public int Agregar(int id_prov)
        { return oCompra.Agregar(id_prov); }

        public Entidades.Compras ObtenerPendientesTodos()
        { return oCompra.ObtenerPendientesTodos(); }

        public Entidades.Compras ObtenerPendientesUnProveedor(int id_prov)
        { return oCompra.ObtenerPendientesUnProveedor(id_prov); }

        public int Cancelar(int id_compra)
        { return oCompra.Cancelar(id_compra); }

        public Entidades.Compra VerDetalles(int id_compra)
        { return oCompra.VerDetalles(id_compra); }

        public string GuardarComoEntregada(Entidades.Compra compra)
        {
            string error = "";

            error = oCompra.GuardarComoEntregada(compra);

            if (error.Equals(""))
            {
                Datos.Linea_Pedido nLinea = new HP.Datos.Linea_Pedido();
                error = nLinea.ActualizarCantidadAceptada(compra.Lineas_pedido);

                if (error.Equals(""))
                {
                    Datos.Nota_Credito nNota_Credito = new HP.Datos.Nota_Credito();
                    error = nNota_Credito.AsignarACompra(compra.Id_Compra, compra.Notas_Credito);
                }
            }
            return error;
        }
    }
}
