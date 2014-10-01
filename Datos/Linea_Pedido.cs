using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HP.Datos
{
    public class Linea_Pedido
    {
        #region Metodos

        public void Agregar(Entidades.Linea_Pedido linea)
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
                    oCmd.CommandText = "Linea_PedidoAgregar";

                    oCmd.Parameters.AddWithValue("@id_compra", linea.Id_compra);
                    oCmd.Parameters.AddWithValue("@id_libro", linea.Libro.Id_libro);
                    oCmd.Parameters.AddWithValue("@cant_pedida", linea.Cant_pedida);

                    oCmd.ExecuteNonQuery();
                }
            }
            oCnn.Close();
        }

        public Entidades.Lineas_Pedido ObtenerTodasNoEntregadas(int id_compra)
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
                    oCmd.CommandText = "Linea_PedidoObtenerTodasNoEntregadas";
                    oCmd.Parameters.AddWithValue("@id_compra", id_compra);

                    Entidades.Lineas_Pedido lineas = new HP.Entidades.Lineas_Pedido();

                    SqlDataReader oReader = oCmd.ExecuteReader();
                    using (oReader)
                    {
                        while (oReader.Read())
                        {
                            Entidades.Linea_Pedido linea = new HP.Entidades.Linea_Pedido();
                            Entidades.Libro libro = new HP.Entidades.Libro();
                            Entidades.Coleccion coleccion = new HP.Entidades.Coleccion();
                            
                            coleccion.Id_colec = Convert.ToInt32(oReader["id_colec"]);
                            coleccion.Cod_colec = Convert.ToString(oReader["cod_colec"]);
                            coleccion.Titulo_colec = Convert.ToString(oReader["titulo_colec"]);
                            coleccion.PrecioCompra = float.Parse(Convert.ToString(oReader["precioCompra"]));

                            libro.Id_libro = Convert.ToInt32(oReader["id_libro"]);
                            libro.Isbn = Convert.ToInt64(oReader["isbn"]);
                            libro.Titulo_libro = Convert.ToString(oReader["titulo_libro"]);
                            libro.Colec = coleccion;

                            linea.Id_Linea_Pedido = Convert.ToInt32(oReader["id_linea_pedido"]);
                            linea.Cant_pedida = Convert.ToInt32(oReader["cant_pedida"]);
                            linea.Libro = libro;

                            lineas.Add(linea);
                            linea = null;                            
                        }
                    }
                    oCnn.Close();
                    return lineas;
                }
            }
        }

        public Entidades.Lineas_Pedido ObtenerTodasEntregadas(int id_compra)
        {
            //Se diferencia este metodo del de ObtenerTodasNoEntregadas ya que en el recien mencionado
            //el precio de compra que se obtiene es el utlimo vigente, mientras que el precio de compra
            //del actual metodo es el ultimo vigente con fechaDesde menor o igual que la fecha de entregado.
            //No lo codifico porque no es necesario

            //La siguiente linea esta para que no tire error por no devolver nada...
            //Falta la codificacion pero no la hice porque no es requerida
            Entidades.Lineas_Pedido lin = new HP.Entidades.Lineas_Pedido();
            return lin;
        }

        public string ActualizarCantidadAceptada(Entidades.Lineas_Pedido lineas)
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
                    oCmd.CommandText = "Linea_PedidoActualizarCantidadAceptada";

                    foreach (Entidades.Linea_Pedido linea in lineas)
                    {
                        try
                        {
                            oCmd.Parameters.Clear();
                            oCmd.Parameters.AddWithValue("id_linea_pedido", linea.Id_Linea_Pedido);
                            oCmd.Parameters.AddWithValue("cant_aceptada", linea.Cant_aceptada);

                            oCmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            error = "Ha ocurrido un error al registrar en la base de datos la linea de pedido " +
                                    "correspondiente al libro \'" + linea.Libro.Titulo_libro + "\'";
                            break;
                        }
                    }
                }
                oCnn.Close();
            }
            return error;
        }

        #endregion
    }
}
