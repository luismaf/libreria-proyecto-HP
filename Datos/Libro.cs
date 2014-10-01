using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HP.Datos
{
	public class Libro
    {
        public Entidades.Libros ObtenerTodos(int id_colec)
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
                    oCmd.CommandText = "LibroObtenerTodos";
                    oCmd.Parameters.AddWithValue("@id_colec", id_colec);

                    Entidades.Libros oLibros = new HP.Entidades.Libros();

                    SqlDataReader oReader = oCmd.ExecuteReader();
                    using (oReader)
                    {
                        while (oReader.Read())
                        {
                            Entidades.Libro oLibro = new HP.Entidades.Libro();
                            oLibro.Id_libro = Convert.ToInt32(oReader["id_libro"]);
                            oLibro.Titulo_libro = Convert.ToString(oReader["titulo_libro"]);
                            oLibro.Stock_actual = Convert.ToInt32(oReader["stock_actual"]);

                            oLibros.Add(oLibro);
                            oLibro = null;
                        }
                        oCnn.Close();
                        return oLibros;
                    }
                }
            }
        }

        public Entidades.Libro ObtenerUno(int id_libro)
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
                    oCmd.CommandText = "LibroObtenerUno";
                    oCmd.Parameters.AddWithValue("@id_libro", id_libro);

                    Entidades.Coleccion oColeccion = new HP.Entidades.Coleccion();
                    Entidades.Libro oLibro = new HP.Entidades.Libro();

                    SqlDataReader oReader = oCmd.ExecuteReader();
                    using (oReader)
                    {
                        while (oReader.Read())
                        {
                            oColeccion.Id_colec = Convert.ToInt32(oReader["id_colec"]);
                            oLibro.Colec = oColeccion;
                            oLibro.Id_libro = Convert.ToInt32(oReader["id_libro"]);
                            oLibro.Isbn = Convert.ToInt64(oReader["isbn"]);
                            oLibro.Titulo_libro = Convert.ToString(oReader["titulo_libro"]);
                            oLibro.Stock_actual = Convert.ToInt32(oReader["stock_actual"]);
                            oLibro.Stock_deseable = Convert.ToInt32(oReader["stock_deseable"]);
                            oLibro.Stock_minimo = Convert.ToInt32(oReader["stock_minimo"]);
                            oLibro.Resena = Convert.ToString(oReader["resena"]);
                            oLibro.Habilitado_Libro = Convert.ToBoolean(oReader["habilitado_libro"]);
                        }
                        oCnn.Close();
                        return oLibro;
                    }
                }
            }
        }

        public Entidades.Libros ObtenerDeshabilitados()
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
                    oCmd.CommandText = "LibroObtenerDeshabilitados";

                    Entidades.Libros oLibros = new HP.Entidades.Libros();

                    SqlDataReader oReader = oCmd.ExecuteReader();
                    using (oReader)
                    {
                        while (oReader.Read())
                        {
                            Entidades.Categoria oCategoria = new HP.Entidades.Categoria();
                            Entidades.Coleccion oColeccion = new HP.Entidades.Coleccion();
                            Entidades.Libro oLibro = new HP.Entidades.Libro();

                            oCategoria.Id_categ = Convert.ToInt32(oReader["id_categ"]);
                            oCategoria.Nombre_categ = Convert.ToString(oReader["nombre_categ"]);
                            oCategoria.Habilitada_Categ = Convert.ToBoolean(oReader["habilitada_categ"]);
                            oColeccion.Id_colec = Convert.ToInt32(oReader["id_colec"]);
                            oColeccion.Titulo_colec = Convert.ToString(oReader["titulo_colec"]);
                            oColeccion.Habilitada_Colec = Convert.ToBoolean(oReader["habilitada_colec"]);
                            oColeccion.Categ = oCategoria;
                            oLibro.Id_libro = Convert.ToInt32(oReader["id_libro"]);
                            oLibro.Titulo_libro = Convert.ToString(oReader["titulo_libro"]);
                            oLibro.Colec = oColeccion;                            

                            oLibros.Add(oLibro);
                            oLibro = null;
                        }
                        oCnn.Close();
                        return oLibros;
                    }
                }
            }
        }

        public int Agregar(Entidades.Libro libro)
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
                        oCmd.CommandText = "LibroAgregar";

                        oCmd.Parameters.AddWithValue("@titulo_libro", libro.Titulo_libro);
                        oCmd.Parameters.AddWithValue("@isbn", libro.Isbn);
                        oCmd.Parameters.AddWithValue("@id_colec", libro.Colec.Id_colec);
                        oCmd.Parameters.AddWithValue("@stock_actual", libro.Stock_actual);
                        oCmd.Parameters.AddWithValue("@stock_deseable", libro.Stock_deseable);
                        oCmd.Parameters.AddWithValue("@stock_minimo", libro.Stock_minimo);
                        oCmd.Parameters.AddWithValue("@resena", libro.Resena);

                        return Convert.ToInt32(oCmd.ExecuteScalar());
                    }
                    catch (SqlException e)
                    {
                        //devuelve un -1 si el libro esta habilitado y -2 si deshabilitado
                        return Convert.ToInt32(e.Errors[3].Message);
                    }
                    finally
                    {
                        oCnn.Close();
                    }
                }
            }
        }

        public int Editar(Entidades.Libro libro)
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
                        oCmd.CommandText = "LibroActualizar";
                        
                        oCmd.Parameters.AddWithValue("@id_libro", libro.Id_libro);
                        oCmd.Parameters.AddWithValue("@titulo_libro", libro.Titulo_libro);
                        oCmd.Parameters.AddWithValue("@isbn", libro.Isbn);
                        oCmd.Parameters.AddWithValue("@id_colec", libro.Colec.Id_colec);
                        oCmd.Parameters.AddWithValue("@stock_actual", libro.Stock_actual);
                        oCmd.Parameters.AddWithValue("@stock_deseable", libro.Stock_deseable);
                        oCmd.Parameters.AddWithValue("@stock_minimo", libro.Stock_minimo);
                        oCmd.Parameters.AddWithValue("@resena", libro.Resena);

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

        public void EstablecerHabilitacion(int id_libro, int habilitado)
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
                    oCmd.CommandText = "LibroEstablecerHabilitacion";
                    oCmd.Parameters.AddWithValue("@id_libro", id_libro);
                    oCmd.Parameters.AddWithValue("@habilitado", habilitado);
                    oCmd.ExecuteNonQuery();
                }
            }
            oCnn.Close();
        }

        public Entidades.Libros ObtenerListadoFaltantes(int id_prov)
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
                    oCmd.CommandText = "LibroObtenerListadoFaltantes";
                    oCmd.Parameters.AddWithValue("@id_prov", id_prov);

                    Entidades.Libros oLibros = new HP.Entidades.Libros();
                    SqlDataReader oReader = oCmd.ExecuteReader();
                    using (oReader)
                    {
                        while (oReader.Read())
                        {
                            Entidades.Libro oLibro = new HP.Entidades.Libro();
                            Entidades.Coleccion oColeccion = new HP.Entidades.Coleccion();

                            oColeccion.PrecioCompra = float.Parse(Convert.ToString(oReader["precioCompra"]));
                            oLibro.Colec = oColeccion;
                            oLibro.Id_libro = Convert.ToInt32(oReader["id_libro"]);
                            oLibro.Isbn = Convert.ToInt64(oReader["isbn"]);
                            oLibro.Titulo_libro = Convert.ToString(oReader["titulo_libro"]);
                            oLibro.Stock_actual = Convert.ToInt32(oReader["stock_actual"]);
                            oLibro.Stock_minimo = Convert.ToInt32(oReader["stock_minimo"]);
                            oLibro.Stock_deseable = Convert.ToInt32(oReader["stock_deseable"]);
                            try
                            { oLibro.Cant_pedida = Convert.ToInt32(oReader["cant_pedida"]); }
                            catch
                            { oLibro.Cant_pedida = 0; }

                            oLibros.Add(oLibro);
                            oLibro = null;
                        }
                        oCnn.Close();
                        return oLibros;
                    }
                }
            }
        }
        
        public Entidades.Libros Buscar(string isbn, string titulo_libro, string titulo_colec)
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
                    oCmd.CommandText = "LibroBuscar";

                    oCmd.Parameters.AddWithValue("@isbn", isbn);
                    oCmd.Parameters.AddWithValue("@titulo_libro", titulo_libro);
                    oCmd.Parameters.AddWithValue("@titulo_colec", titulo_colec);

                    Entidades.Libros oLibros = new HP.Entidades.Libros();

                    SqlDataReader oReader = oCmd.ExecuteReader();
                    using (oReader)
                    {
                        while (oReader.Read())
                        {
                            Entidades.Libro oLibro = new HP.Entidades.Libro();
                            Entidades.Coleccion oColeccion = new HP.Entidades.Coleccion(); 
                            Entidades.Categoria oCategoria = new HP.Entidades.Categoria();
                            Entidades.Proveedor oProveedor = new HP.Entidades.Proveedor();

                            oCategoria.Nombre_categ = Convert.ToString(oReader["nombre_categ"]);
                            oProveedor.Id_prov = Convert.ToInt32(oReader["id_prov"]);
                            oProveedor.Razon_social = Convert.ToString(oReader["razon_social"]);
                            oColeccion.Titulo_colec = Convert.ToString(oReader["titulo_colec"]);
                            oColeccion.PrecioCompra = float.Parse(Convert.ToString(oReader["precioCompra"]));
                            oColeccion.Categ = oCategoria;
                            oColeccion.Prov = oProveedor;
                            oLibro.Id_libro = Convert.ToInt32(oReader["id_libro"]);
                            oLibro.Isbn = Convert.ToInt64(oReader["isbn"]);
                            oLibro.Titulo_libro = Convert.ToString(oReader["titulo_libro"]);
                            oLibro.Stock_minimo = Convert.ToInt32(oReader["stock_minimo"]);
                            oLibro.Stock_actual = Convert.ToInt32(oReader["stock_actual"]);
                            oLibro.Stock_deseable = Convert.ToInt32(oReader["stock_deseable"]);
                            oLibro.Colec = oColeccion;
                            try
                            { oLibro.Cant_pedida = Convert.ToInt32(oReader["cant_pedida"]); }
                            catch
                            { oLibro.Cant_pedida = 0; }

                            oLibros.Add(oLibro);
                            oLibro = null;
                        }
                        oCnn.Close();
                        return oLibros;
                    }
                }
            }
        }
    }
}

