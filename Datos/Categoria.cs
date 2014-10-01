using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HP.Datos
{
	public class Categoria
	{
		#region Metodos

        public Entidades.Categorias ObtenerTodas()
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
                    oCmd.CommandText = "CategoriaObtenerTodas";
                    Entidades.Categorias oCategorias = new HP.Entidades.Categorias();

                    SqlDataReader oReader = oCmd.ExecuteReader();
                    using (oReader)
                    {
                        while (oReader.Read())
                        {
                            Entidades.Categoria oCategoria = new HP.Entidades.Categoria();
                            oCategoria.Id_categ = Convert.ToInt32(oReader["id_categ"]);
                            oCategoria.Nombre_categ = Convert.ToString(oReader["nombre_categ"]);
                            oCategorias.Add(oCategoria);
                        }
                        oCnn.Close();
                        return oCategorias;
                    }
                }
            }
        }

        public Entidades.Categorias ObtenerDeshabilitadas()
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
                    oCmd.CommandText = "CategoriaObtenerDeshabilitadas";
                    Entidades.Categorias oCategorias = new HP.Entidades.Categorias();

                    SqlDataReader oReader = oCmd.ExecuteReader();
                    using (oReader)
                    {
                        while (oReader.Read())
                        {
                            Entidades.Categoria oCategoria = new HP.Entidades.Categoria();
                            oCategoria.Id_categ = Convert.ToInt32(oReader["id_categ"]);
                            oCategoria.Nombre_categ = Convert.ToString(oReader["nombre_categ"]);
                            oCategoria.Habilitada_Categ = false;
                            oCategorias.Add(oCategoria);
                        }
                        oCnn.Close();
                        return oCategorias;
                    }
                }
            }
        }

        public int Agregar(Entidades.Categoria categoria)
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
                        oCmd.CommandText = "CategoriaAgregar";
                        oCmd.Parameters.AddWithValue("@nombre_categ", categoria.Nombre_categ);
                        return Convert.ToInt32(oCmd.ExecuteScalar());
                    }
                    catch (SqlException e)
                    {
                        //devuelve un -1 si la categoria esta habilitada y -2 si deshabilitada
                        return Convert.ToInt32(e.Errors[3].Message);
                    }
                    finally
                    {
                        oCnn.Close();
                    }
                }
            }
        }

        public int Editar(Entidades.Categoria categoria)
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
                        oCmd.CommandText = "CategoriaActualizar";
                        oCmd.Parameters.AddWithValue("@id_categ", categoria.Id_categ);
                        oCmd.Parameters.AddWithValue("@nombre_categ", categoria.Nombre_categ);
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

        public void EstablecerHabilitacion(int id_categ, int habilitada)
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
                    oCmd.CommandText = "CategoriaEstablecerHabilitacion";
                    oCmd.Parameters.AddWithValue("@id_categ", id_categ);
                    oCmd.Parameters.AddWithValue("@habilitada", habilitada);
                    oCmd.ExecuteNonQuery();
                }
            }
            oCnn.Close();
        }

		#endregion
	}
}
