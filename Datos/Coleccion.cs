using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HP.Datos
{
	public class Coleccion
	{
        #region Metodos

        public Entidades.Colecciones ObtenerTodas(int id_categ)
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
                    oCmd.CommandText = "ColeccionObtenerTodas";
                    oCmd.Parameters.AddWithValue("@id_categ", id_categ);

                    Entidades.Colecciones oColecciones = new HP.Entidades.Colecciones();
                 
                    SqlDataReader oReader = oCmd.ExecuteReader();
                    using (oReader)
                    {
                        while (oReader.Read())
                        {
                            Entidades.Coleccion oColeccion = new HP.Entidades.Coleccion();
                            oColeccion.Id_colec = Convert.ToInt32(oReader["id_colec"]);
                            oColeccion.Titulo_colec = Convert.ToString(oReader["titulo_colec"]);

                            oColecciones.Add(oColeccion);
                            oColeccion = null;
                        }
                        oCnn.Close();
                        return oColecciones;
                    }
                }
            }
        }

        public Entidades.Colecciones ObtenerDeshabilitadas()
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
                    oCmd.CommandText = "ColeccionObtenerDeshabilitadas";

                    Entidades.Colecciones oColecciones = new HP.Entidades.Colecciones();

                    SqlDataReader oReader = oCmd.ExecuteReader();
                    using (oReader)
                    {
                        while (oReader.Read())
                        {
                            Entidades.Categoria oCategoria = new HP.Entidades.Categoria();
                            Entidades.Coleccion oColeccion = new HP.Entidades.Coleccion();

                            oCategoria.Id_categ = Convert.ToInt32(oReader["id_categ"]);
                            oCategoria.Nombre_categ = Convert.ToString(oReader["nombre_categ"]);
                            oCategoria.Habilitada_Categ = Convert.ToBoolean(oReader["habilitada_categ"]);
                            oColeccion.Id_colec = Convert.ToInt32(oReader["id_colec"]);
                            oColeccion.Titulo_colec = Convert.ToString(oReader["titulo_colec"]);
                            oColeccion.Habilitada_Colec = false;
                            oColeccion.Categ = oCategoria;

                            oColecciones.Add(oColeccion);
                            oColeccion = null;
                        }
                        oCnn.Close();
                        return oColecciones;
                    }
                }
            }
        }

        public Entidades.Coleccion ObtenerUna(int id_colec)
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
                    oCmd.CommandText = "ColeccionObtenerUna";
                    oCmd.Parameters.AddWithValue("@id_colec", id_colec);

                    Entidades.Categoria oCategoria = new HP.Entidades.Categoria();
                    Entidades.Proveedor oProveedor = new HP.Entidades.Proveedor();
                    Entidades.Coleccion oColeccion = new HP.Entidades.Coleccion();

                    SqlDataReader oReader = oCmd.ExecuteReader();
                    using (oReader)
                    {
                        while (oReader.Read())
                        {
                            oCategoria.Id_categ = Convert.ToInt32(oReader["id_categ"]);
                            oProveedor.Id_prov = Convert.ToInt32(oReader["id_prov"]);
                            oProveedor.Razon_social = Convert.ToString(oReader["razon_social"]);
                            oColeccion.Id_colec = Convert.ToInt32(oReader["id_colec"]);
                            oColeccion.Cod_colec = Convert.ToString(oReader["cod_colec"]);
                            oColeccion.Titulo_colec = Convert.ToString(oReader["titulo_colec"]);
                            oColeccion.Descripcion_colec = Convert.ToString(oReader["descripcion_colec"]);
                            oColeccion.Tamano = Convert.ToString(oReader["tamanio"]);
                            oColeccion.Cant_pags = Convert.ToInt32(oReader["cant_pags"]);
                            oColeccion.Encuadernacion = Convert.ToString(oReader["encuadernacion"]);
                            oColeccion.Edad_sugerida = Convert.ToInt32(oReader["edad_minima"]);
                            oColeccion.PrecioCompra = float.Parse(Convert.ToString(oReader["precioCompra"]));
                            oColeccion.PrecioVenta = float.Parse(Convert.ToString(oReader["precioVenta"]));
                            oColeccion.Habilitada_Colec = Convert.ToBoolean(oReader["habilitada_colec"]);

                            oColeccion.Categ = oCategoria;
                            oColeccion.Prov = oProveedor;
                        }
                        oCnn.Close();
                        return oColeccion;
                    }
                }
            }
        }

        public int Agregar(Entidades.Coleccion coleccion)
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
                        oCmd.CommandText = "ColeccionAgregar";

                        oCmd.Parameters.AddWithValue("@id_categ", coleccion.Categ.Id_categ);
                        oCmd.Parameters.AddWithValue("@id_prov", coleccion.Prov.Id_prov);
                        oCmd.Parameters.AddWithValue("@cod_colec", coleccion.Cod_colec);
                        oCmd.Parameters.AddWithValue("@titulo_colec", coleccion.Titulo_colec);
                        oCmd.Parameters.AddWithValue("@descripcion_colec", coleccion.Descripcion_colec);
                        oCmd.Parameters.AddWithValue("@tamanio", coleccion.Tamano);
                        oCmd.Parameters.AddWithValue("@cant_pags", coleccion.Cant_pags);
                        oCmd.Parameters.AddWithValue("@encuadernacion", coleccion.Encuadernacion);
                        oCmd.Parameters.AddWithValue("@edad_minima", coleccion.Edad_sugerida);
                        oCmd.Parameters.AddWithValue("@precioCompra", coleccion.PrecioCompra);
                        oCmd.Parameters.AddWithValue("@precioVenta", coleccion.PrecioVenta);

                        return Convert.ToInt32(oCmd.ExecuteScalar());
                    }
                    catch (SqlException e)
                    {
                        //devuelve un -1 si la colección esta habilitada y -2 si deshabilitada
                        return Convert.ToInt32(e.Errors[3].Message);
                    }
                    finally
                    {
                        oCnn.Close();
                    }
                }
            }
        }

        public int Editar(Entidades.Coleccion coleccion)
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
                        oCmd.CommandText = "ColeccionActualizar";

                        oCmd.Parameters.AddWithValue("@id_colec", coleccion.Id_colec);
                        oCmd.Parameters.AddWithValue("@id_categ", coleccion.Categ.Id_categ);
                        oCmd.Parameters.AddWithValue("@cod_colec", coleccion.Cod_colec);
                        oCmd.Parameters.AddWithValue("@descripcion_colec", coleccion.Descripcion_colec);
                        oCmd.Parameters.AddWithValue("@tamanio", coleccion.Tamano);
                        oCmd.Parameters.AddWithValue("@cant_pags", coleccion.Cant_pags);
                        oCmd.Parameters.AddWithValue("@encuadernacion", coleccion.Encuadernacion);
                        oCmd.Parameters.AddWithValue("@titulo_colec", coleccion.Titulo_colec);
                        oCmd.Parameters.AddWithValue("@edad_minima", coleccion.Edad_sugerida);
                        oCmd.Parameters.AddWithValue("@precioCompra", coleccion.PrecioCompra);
                        oCmd.Parameters.AddWithValue("@precioVenta", coleccion.PrecioVenta);
                        oCmd.Parameters.AddWithValue("@id_prov", coleccion.Prov.Id_prov);

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

        public void EstablecerHabilitacion(int id_colec, int habilitada)
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
                    oCmd.CommandText = "ColeccionEstablecerHabilitacion";
                    oCmd.Parameters.AddWithValue("@id_colec", id_colec);
                    oCmd.Parameters.AddWithValue("@habilitada", habilitada);
                    oCmd.ExecuteNonQuery();
                }
            }
            oCnn.Close();
        }

        public void ActualizarPrecioVenta(int id_colec, float precioVenta)
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
                    oCmd.CommandText = "Precio_VentaAgregar";

                    oCmd.Parameters.AddWithValue("id_colec", id_colec);
                    oCmd.Parameters.AddWithValue("precioVenta", precioVenta);

                    oCmd.ExecuteNonQuery();
                }
                oCnn.Close();
            }
        }

        public string ActualizarPrecioCompra(int id_colec, float precioCompra)
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
                    oCmd.CommandText = "Precio_CompraAgregar";

                    oCmd.Parameters.AddWithValue("id_colec", id_colec);
                    oCmd.Parameters.AddWithValue("precioCompra", precioCompra);

                    try
                    { oCmd.ExecuteNonQuery(); }
                    catch
                    {
                        error = "Ha ocurrido un error al registrar en la base de datos el " +
                                    "precio de compra de la colección";
                    }
                }
                oCnn.Close();
            }
            return error;
        }

        public float ObtenerPrecioVentaVigente(int id_colec)
        {
            float precioVentaVigente;

            SqlConnection oCnn = General.CreateConnection();
            using (oCnn)
            {
                oCnn.Open();
                SqlCommand oCmd = new SqlCommand();
                using (oCmd)
                {
                    oCmd.Connection = oCnn;
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.CommandText = "Precio_VentaObtenerVigente";

                    oCmd.Parameters.AddWithValue("id_colec", id_colec);

                    SqlDataReader oReader = oCmd.ExecuteReader();
                    using (oReader)
                    {
                        oReader.Read();
                        precioVentaVigente = float.Parse(oReader["precioVenta"].ToString());
                    }
                }
                oCnn.Close();
            }
            return precioVentaVigente;
        }

		#endregion
	
	}
}
