using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HP.Datos
{
    public class Proveedor
    {
        #region Métodos

        public Entidades.Proveedores ObtenerHabilitados()
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
                    oCmd.CommandText = "ProveedorObtenerHabilitados";
                    Entidades.Proveedores oProveedores = new HP.Entidades.Proveedores();

                    SqlDataReader oReader = oCmd.ExecuteReader();
                    using (oReader)
                    {
                        while (oReader.Read())
                        {
                            Entidades.Proveedor oProveedor = new HP.Entidades.Proveedor();
                            oProveedor.Id_prov = Convert.ToInt32(oReader["id_prov"]);
                            oProveedor.Razon_social = Convert.ToString(oReader["razon_social"]);
                            oProveedores.Add(oProveedor);
                        }
                        oCnn.Close();
                        return oProveedores;
                    }
                }
            }
        }

        public Entidades.Proveedores ObtenerTodos()
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
                    oCmd.CommandText = "ProveedorObtenerTodos";
                    
                    Entidades.Proveedores oProveedores = new HP.Entidades.Proveedores();
                    SqlDataReader oReader = oCmd.ExecuteReader();
                    using (oReader)
                    {
                        while (oReader.Read())
                        {
                            Entidades.Proveedor oProveedor = new HP.Entidades.Proveedor();
                            oProveedor.Id_prov = Convert.ToInt32(oReader["id_prov"]);
                            oProveedor.Razon_social = Convert.ToString(oReader["razon_social"]);
                            oProveedor.Cuit_prov = Convert.ToInt64(oReader["cuit_prov"]);
                            oProveedor.Email_prov = Convert.ToString(oReader["email_prov"]);
                            oProveedor.Telefono = Convert.ToString(oReader["telefono_prov"]);
                            //oProveedor.Nro_cta_bca = Convert.ToInt64(oReader["nro_cta_bca"]);
                            oProveedor.Habilitado = Convert.ToBoolean(oReader["habilitado_prov"]);

                            oProveedores.Add(oProveedor);
                        }
                        oCnn.Close();
                        return oProveedores;
                    }
                }
            }
        }

        public int Agregar(Entidades.Proveedor proveedor)
        {
            SqlConnection oCnn = General.CreateConnection();
            using (oCnn)
            {
                oCnn.Open();
                SqlCommand oCmd = new SqlCommand();
                using (oCmd)
                {
                    try
                    {
                        oCmd.Connection = oCnn;
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oCmd.CommandText = "ProveedorAgregar";

                        oCmd.Parameters.AddWithValue("@cuit_prov", proveedor.Cuit_prov);
                        oCmd.Parameters.AddWithValue("@razon_social", proveedor.Razon_social);
                        oCmd.Parameters.AddWithValue("@telefono_prov", proveedor.Telefono);
                        oCmd.Parameters.AddWithValue("@email_prov", proveedor.Email_prov);
                        //oCmd.Parameters.AddWithValue("@nro_cta_bca", proveedor.Nro_cta_bca);

                        return Convert.ToInt32(oCmd.ExecuteScalar());
                    }
                    catch
                    {
                        return -1;
                    }
                    finally
                    {
                        oCnn.Close();
                    }
                }
            }
        }

        public int Editar(Entidades.Proveedor proveedor)
        {
            SqlConnection oCnn = General.CreateConnection();
            using (oCnn)
            {
                oCnn.Open();
                SqlCommand oCmd = new SqlCommand();
                using (oCmd)
                {
                    try
                    {
                        oCmd.Connection = oCnn;
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oCmd.CommandText = "ProveedorActualizar";

                        oCmd.Parameters.AddWithValue("@id_prov", proveedor.Id_prov);
                        oCmd.Parameters.AddWithValue("@cuit_prov", proveedor.Cuit_prov);
                        oCmd.Parameters.AddWithValue("@razon_social", proveedor.Razon_social);
                        oCmd.Parameters.AddWithValue("@telefono_prov", proveedor.Telefono);
                        oCmd.Parameters.AddWithValue("@email_prov", proveedor.Email_prov);
                        //oCmd.Parameters.AddWithValue("@nro_cta_bca", proveedor.Nro_cta_bca);

                        return oCmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        return -1;
                    }
                    finally
                    {
                        oCnn.Close();
                    }
                }
            }
        }

        public void EstablecerHabilitacion(int id_prov, int habilitado)
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
                    oCmd.CommandText = "ProveedorEstablecerHabilitacion";

                    oCmd.Parameters.AddWithValue("@id_prov", id_prov);
                    oCmd.Parameters.AddWithValue("@habilitado", habilitado);

                    oCmd.ExecuteNonQuery();
                }
                oCnn.Close();
            }
        }

        public Entidades.Compras ValidarPedidosPendientes(int id_prov)
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
                    oCmd.CommandText = "ProveedorValidarPedidosPendientes";

                    oCmd.Parameters.AddWithValue("id_prov", id_prov);
                    
                    SqlDataReader oReader = oCmd.ExecuteReader();
                    using (oReader)
                    {
                        Entidades.Compras compras = new HP.Entidades.Compras();
                        while (oReader.Read())
                        {
                            Entidades.Compra compra = new HP.Entidades.Compra();
                            compra.Id_Compra = Convert.ToInt32(oReader["id_compra"]);
                            compra.Fecha_Pedido = Convert.ToDateTime(oReader["fecha_pedido"]);

                            compras.Add(compra);
                        }
                        oCnn.Close();
                        return compras;
                    }
                }
            }
        }

        #endregion
    }
}
