using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HP.Datos
{
    public class Compra
    {
        public int Agregar(int id_prov)
        {
            int id_compra;
            SqlConnection oCnn = General.CreateConnection();
            using (oCnn)
            {
                oCnn.Open();
                SqlCommand oCmd = new SqlCommand();
                using (oCmd)
                {
                    oCmd.Connection = oCnn;
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.CommandText = "CompraAgregar";

                    oCmd.Parameters.AddWithValue("@id_prov", id_prov);
                    id_compra = Convert.ToInt32(oCmd.ExecuteScalar());
                }
            }
            oCnn.Close();
            return id_compra;
        }
      
        public Entidades.Compras ObtenerPendientesTodos()
        {
            SqlConnection oCnn = General.CreateConnection();
            using (oCnn)
            {
                oCnn.Open();
                SqlCommand oCmd = new SqlCommand();
                using (oCmd)
                {
                    oCmd.Connection = oCnn;
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.CommandText = "CompraObtenerPendientesTodos";

                    Entidades.Compras oCompras = new HP.Entidades.Compras();
                    SqlDataReader oReader = oCmd.ExecuteReader();

                    using (oReader)
                    {
                        while (oReader.Read())
                        {
                            Entidades.Compra oCompra = new HP.Entidades.Compra();
                            oCompra.Id_Compra = Convert.ToInt32(oReader["id_compra"]);
                            oCompra.Fecha_Pedido = Convert.ToDateTime(oReader["fecha_pedido"]);
                            Entidades.Proveedor oProveedor = new HP.Entidades.Proveedor();
                            oProveedor.Razon_social = Convert.ToString(oReader["razon_social"]);
                            oCompra.Prov = oProveedor;

                            oCompras.Add(oCompra);
                            oCompra = null;
                        }
                        oCnn.Close();
                        return oCompras;
                    }
                }
            }
        }

        public Entidades.Compras ObtenerPendientesUnProveedor(int id_prov)
        {
            SqlConnection oCnn = General.CreateConnection();
            using (oCnn)
            {
                oCnn.Open();
                SqlCommand oCmd = new SqlCommand();
                using (oCmd)
                {
                    oCmd.Connection = oCnn;
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.CommandText = "CompraObtenerPendientesUnProveedor";
                    oCmd.Parameters.AddWithValue("id_prov", id_prov);

                    Entidades.Compras oCompras = new HP.Entidades.Compras();
                    SqlDataReader oReader = oCmd.ExecuteReader();

                    using (oReader)
                    {
                        while (oReader.Read())
                        {
                            Entidades.Compra oCompra = new HP.Entidades.Compra();
                            oCompra.Id_Compra = Convert.ToInt32(oReader["id_compra"]);
                            oCompra.Fecha_Pedido = Convert.ToDateTime(oReader["fecha_pedido"]);

                            oCompras.Add(oCompra);
                            oCompra = null;
                        }
                        oCnn.Close();
                        return oCompras;
                    }
                }
            }
        }

        public int Cancelar(int id_compra)
        {
            SqlConnection oCnn = General.CreateConnection();
            using (oCnn)
            {
                oCnn.Open();
                SqlCommand oCmd = new SqlCommand();
                using (oCmd)
                {
                    oCmd.Connection = oCnn;
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.CommandText = "CompraCancelar";
                    oCmd.Parameters.AddWithValue("id_compra", id_compra);

                    return oCmd.ExecuteNonQuery();
                }
            }
        }

        public Entidades.Compra VerDetalles(int id_compra)
        {
            SqlConnection oCnn = General.CreateConnection();
            using (oCnn)
            {
                oCnn.Open();
                SqlCommand oCmd = new SqlCommand();
                using (oCmd)
                {
                    oCmd.Connection = oCnn;
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.CommandText = "CompraVerDetalles";
                    oCmd.Parameters.AddWithValue("id_compra", id_compra);

                    SqlDataReader oReader = oCmd.ExecuteReader();

                    Entidades.Compra oCompra = new HP.Entidades.Compra();
                    Entidades.Proveedor proveedor = new HP.Entidades.Proveedor();

                    using (oReader)
                    {
                        while (oReader.Read())
                        {
                            oCompra.Id_Compra = Convert.ToInt32(oReader["id_compra"]);
                            proveedor.Id_prov = Convert.ToInt32(oReader["id_prov"]);
                            proveedor.Razon_social = Convert.ToString(oReader["razon_social"]);
                            oCompra.Prov = proveedor;
                            oCompra.Id_Estado_Compra = Convert.ToInt32(oReader["id_estado_compra"]);
                            oCompra.Desc_Estado_Compra = Convert.ToString(oReader["desc_estado_compra"]);
                            oCompra.Fecha_Pedido = Convert.ToDateTime(oReader["fecha_pedido"]);
                            try
                            { oCompra.Fecha_Cancelado = Convert.ToDateTime(oReader["fecha_cancelado"]); }
                            catch
                            { }
                            try
                            {
                                oCompra.Fecha_Entregado = Convert.ToDateTime(oReader["fecha_entregado"]);
                                oCompra.Monto_Compra = float.Parse(Convert.ToString(oReader["monto_compra"]));
                            }
                            catch
                            { }
                            try
                            {
                                oCompra.Monto_Cheque = float.Parse(Convert.ToString(oReader["monto_cheque"]));
                                oCompra.Nro_Cheque = Convert.ToInt64(oReader["nro_cheque"]);
                                oCompra.Fecha_Venc_Cheque = Convert.ToDateTime(oReader["fec_venc_cheque"]);
                            }
                            catch
                            { }
                        }
                        oCnn.Close();
                        return oCompra;
                    }
                }
            }
        }

        public string GuardarComoEntregada(Entidades.Compra compra)
        {
            string error = "";

            SqlConnection oCnn = General.CreateConnection();
            using (oCnn)
            {
                oCnn.Open();
                SqlCommand oCmd = new SqlCommand();
                using (oCmd)
                {
                    oCmd.Connection = oCnn;
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.CommandText = "CompraGuardarComoEntregada";

                    oCmd.Parameters.AddWithValue("id_compra", compra.Id_Compra);
                    oCmd.Parameters.AddWithValue("monto_compra", compra.Monto_Compra);
                    oCmd.Parameters.AddWithValue("nro_cheque", compra.Nro_Cheque);
                    oCmd.Parameters.AddWithValue("fec_venc_cheque", compra.Fecha_Venc_Cheque);
                    oCmd.Parameters.AddWithValue("monto_cheque", compra.Monto_Cheque);

                    try
                    { oCmd.ExecuteNonQuery(); }
                    catch
                    { error = "Ha ocurrido un error al actualizar el pedido en la base de datos"; }
                }
                oCnn.Close();
            }
            return error;
        }


    }
}
