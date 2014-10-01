using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HP.Datos
{
	public class General
	{
		#region Metodos

		public static SqlConnection CreateConnection()
        {
            SqlConnection oCnn;

            try
            {
                oCnn = new SqlConnection();
                oCnn.ConnectionString = "Server="+Environment.UserDomainName+"\\SQLEXPRESS; Database=arlequin; Integrated Security=true;";
                                        //"Server=MELINA-PC; Database=arlequin; Integrated Security=true;";
                return oCnn;
            }
            finally
            {
                oCnn = null;
            }
		}

        public int RealizarBackUpCompleto(string ruta)
        {
            SqlConnection oCnn = CreateConnection();
            using (oCnn)
            {
                try
                {
                    oCnn.Open();
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        oCmd.Connection = oCnn;
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oCmd.CommandText = "GeneralBackUpCompleto";
                        oCmd.Parameters.AddWithValue("@ruta", ruta);

                        return Convert.ToInt32(oCmd.ExecuteScalar());
                    }
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

        //Hablar con Ezequiel para chequear la conveniencia del siguiente metodo
        public int RestaurarBase(string ruta)
        {
            SqlConnection oCnn = new SqlConnection("Server="+Environment.UserDomainName+"\\SQLEXPRESS; Database=master; Integrated Security=true;");
                                                   //"Server=localhost; Database=master; Integrated Security= false; User=net; Password=net;");
            using (oCnn)
            {
                try
                {
                    oCnn.Open();
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        oCmd.Connection = oCnn;
                        oCmd.CommandType = CommandType.Text;
                        oCmd.CommandText = "RESTORE DATABASE [arlequin] FROM  DISK = '" + ruta +
                                           "' WITH  FILE = 1,  NOUNLOAD, REPLACE,  STATS = 10";

                        return Convert.ToInt32(oCmd.ExecuteScalar());
                    }
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

		#endregion
	}
}
