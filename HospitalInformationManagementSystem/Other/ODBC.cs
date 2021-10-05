using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace HospitalInformationManagementSystem.Other
{

    internal class ODBC
    {
        //Initialize SQL Server database connection
        private static SqlConnection con;

        public static SqlConnection GetConnection()
        {
            if (con == null)
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["HIMS"].ConnectionString;
                con = new SqlConnection(ConnectionString);
            }
            return con;
        }


        //Open SQL Server database connection open
        private static void OpenConnection()
        {
            if (GetConnection().State == ConnectionState.Open)
            {
                GetConnection().Close();
            }
            GetConnection().Open();
        }



        //select data as a table 
        public static DataTable GetData(string sql, SqlParameter[] sqlParm = null)
        {
            OpenConnection();
            using (SqlCommand cmd = GetConnection().CreateCommand())
            {
                SqlDataAdapter adp = new SqlDataAdapter();
                DataSet ds = new DataSet();
                try
                {
                    cmd.CommandText = sql;
                    if (sqlParm != null)
                        cmd.Parameters.AddRange(sqlParm);

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

        public static SqlDataReader GetData_reader(string sql, SqlParameter[] sqlParm = null)
        {
            OpenConnection();
            using (SqlCommand cmd = GetConnection().CreateCommand())
            {
                try
                {
                    cmd.CommandText = sql;
                    if (sqlParm != null)
                        cmd.Parameters.AddRange(sqlParm);
                    return cmd.ExecuteReader();
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }

        //function for execute SQL Server insert/update/delete query
        public static int SetData(String sql, SqlParameter[] SqlParameter = null)
        {
            OpenConnection();
            using (SqlCommand cmd = GetConnection().CreateCommand())
            {
                try
                {
                    cmd.CommandText = sql;
                    if (SqlParameter != null)
                        cmd.Parameters.AddRange(SqlParameter);

                    return cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }
        //this function for sql functions
        public static string ExecuteFunction(string function, SqlParameter[] SqlParameter = null)
        {
            OpenConnection();
            using (SqlCommand cmd = GetConnection().CreateCommand())
            {
                try
                {
                    cmd.CommandText = function;
                    if (SqlParameter != null)
                        cmd.Parameters.AddRange(SqlParameter);

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

        //public static DataSet ReportFunction(string sql, SqlParameter[] sqlParm = null)
        //{
        //    OpenConnection();
        //    using (SqlCommand cmd = GetConnection().CreateCommand())
        //    {
        //        SqlDataAdapter adp = new SqlDataAdapter();
        //        DataSet ds = new DataSet();
        //        try
        //        {
        //            cmd.CommandText = sql;
        //            if (sqlParm != null)
        //                cmd.Parameters.AddRange(sqlParm);

        //            cmd.ExecuteNonQuery();
        //            adp.SelectCommand = cmd;
        //            adp.Fill(ds);
        //            return ds;
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //    }
        //}
    }
}

