using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HP.Datos
{
    public class Nota_Credito
    {
        public Entidades.Compra ObtenerNCUtilizadas(Entidades.Compra compra)
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
                    oCmd.CommandText = "NC_CompraObtenerUtilizadas";
                    oCmd.Parameters.AddWithValue("id_compra", compra.Id_Compra);

                    Entidades.Notas_Credito notas_credito = new HP.Entidades.Notas_Credito();
                    SqlDataReader oReader = oCmd.ExecuteReader();

                    using (oReader)
                    {
                        while (oReader.Read())
                        {
                            Entidades.Nota_Credito nota_credito = new HP.Entidades.Nota_Credito();

                            nota_credito.Id_Nota_Credito = Convert.ToInt32(oReader["id_nc"]);
                            nota_credito.Codigo_Nc = Convert.ToInt32(oReader["codigo_nc"]);
                            nota_credito.Monto_Aplicado = float.Parse(Convert.ToString(oReader["monto_aplicado_nc"]));

                            notas_credito.Add(nota_credito);
                        }
                        oCnn.Close();
                        compra.Notas_Credito = notas_credito;
                        return compra;
                    }
                }
            }
        }

        public Entidades.Notas_Credito ObtenerTodasConSaldoUnProveedor(int id_prov)
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
                    oCmd.CommandText = "Nota_Cred_ProveedoresObtenerTodasConSaldo";
                    oCmd.Parameters.AddWithValue("id_prov", id_prov);

                    Entidades.Notas_Credito notas_credito = new HP.Entidades.Notas_Credito();
                    SqlDataReader oReader = oCmd.ExecuteReader();

                    using (oReader)
                    {
                        while (oReader.Read())
                        {
                            Entidades.Nota_Credito nota_credito = new HP.Entidades.Nota_Credito();

                            nota_credito.Id_Nota_Credito = Convert.ToInt32(oReader["id_nc"]);
                            nota_credito.Codigo_Nc = Convert.ToInt32(oReader["codigo_nc"]);
                            nota_credito.Monto_Total_Nc = float.Parse(Convert.ToString(oReader["monto_total_nc"]));
                            nota_credito.Fecha_Emision = Convert.ToDateTime(oReader["fecha_emision_nc"]);
                            nota_credito.Saldo_Restante = float.Parse(Convert.ToString(oReader["saldo_restante_nc"]));

                            notas_credito.Add(nota_credito);
                        }
                        oCnn.Close();
                        return notas_credito;
                    }
                }
            }
        }

        public string AsignarACompra(int id_compra, Entidades.Notas_Credito notas)
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
                    oCmd.CommandText = "NCAsignarACompra";
                    
                    foreach (Entidades.Nota_Credito nc in notas)
                    {
                        try
                        {
                            oCmd.Parameters.Clear();
                            oCmd.Parameters.AddWithValue("id_compra", id_compra);
                            oCmd.Parameters.AddWithValue("id_nc", nc.Id_Nota_Credito);
                            oCmd.Parameters.AddWithValue("monto_aplicado_nc", nc.Monto_Aplicado);

                            oCmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            error = "Ha ocurrido un error al registrar en la base de datos la nota de crédito " +
                                    "cuyo código es \'" + nc.Codigo_Nc.ToString() + "\'";
                            break;
                        }
                    }
                }
                oCnn.Close();
            }
            return error;
        }
    }
}
