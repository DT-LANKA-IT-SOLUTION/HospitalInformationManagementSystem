using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using HospitalInformationManagementSystem.Other;
using HospitalInformationManagementSystem.Model;

namespace HospitalInformationManagementSystem.DAL
{
    class Auth_DLL
    {
        public static string GetUserPassword(AuthModel authModel)
        {
            try
            {
                string sql = string.Format("SELECT password FROM Users WHERE user_name = @username");

                SqlParameter[] _sql = new SqlParameter[1];

                _sql[0] = SqlParameterFormat.Format("@username", authModel.Username);

                return ODBC.ExecuteFunction(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static SqlDataReader GetUserData(AuthModel authModel)
        {
            try
            {
                string sql = string.Format("SELECT * FROM Users WHERE user_name = @username");

                SqlParameter[] _sql = new SqlParameter[1];

                _sql[0] = SqlParameterFormat.Format("@username", authModel.Username);

                return ODBC.GetData_reader(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static SqlDataReader GetUserPermisions(int user_id)
        {
            try
            {
                string sql = string.Format("SELECT Permisions.permision_id,User_Permisions.user_id,Permisions.functions,User_Permisions.status FROM User_Permisions INNER JOIN Permisions ON Permisions.permision_id = User_Permisions.permision_id WHERE User_Permisions.user_id = @user_id");

                SqlParameter[] _sql = new SqlParameter[1];

                _sql[0] = SqlParameterFormat.Format("@user_id", user_id);

                return ODBC.GetData_reader(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string UserAuthentication(AuthModel authModel)
        {
            try
            {
                string sql = string.Format("SELECT user_id FROM Users WHERE user_name = @username");

                SqlParameter[] _sql = new SqlParameter[1];

                _sql[0] = SqlParameterFormat.Format("@username", authModel.Username);

                return ODBC.ExecuteFunction(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
