using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformationManagementSystem.Other
{
    internal class ODBC
    {
        private static SqlConnection con;

        public static SqlConnection GetConnection()
        {
            if (con == null)
            {
                string connectionString = "Data Source = (local); Initial Catalog = schooldb; Integrated Security = true";

                con = new SqlConnection(connectionString);
            }
            return con;
        }

        private static void OpenConnection()
        {
            if (GetConnection().State == ConnectionState.Open)
            {
                GetConnection().Close();
            }
            GetConnection().Open();
        }

        public static DataTable GetData(string sql, SqlParameter[] mysqlParm = null)
        {
            OpenConnection();
            using (SqlCommand cmd = GetConnection().CreateCommand())
            {
                SqlDataAdapter adp = new SqlDataAdapter();
                DataSet ds = new DataSet();
                try
                {
                    cmd.CommandText = sql;
                    if (mysqlParm != null)
                        cmd.Parameters.AddRange(mysqlParm);

                    cmd.ExecuteNonQuery();
                    adp.SelectCommand = cmd;
                    adp.Fill(ds);
                    return ds.Tables[0];
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }


        public static string ExecuteFunction(string function, SqlParameter[] mysqlParameter = null)
        {
            OpenConnection();
            using (SqlCommand cmd = GetConnection().CreateCommand())
            {
                try
                {
                    cmd.CommandText = function;
                    if (mysqlParameter != null)
                        cmd.Parameters.AddRange(mysqlParameter);

                    if (cmd.ExecuteScalar() != DBNull.Value)
                        return Convert.ToString(cmd.ExecuteScalar());
                }
                catch (Exception)
                {
                    throw;
                }
                return null;
            }
        }
    }
}
