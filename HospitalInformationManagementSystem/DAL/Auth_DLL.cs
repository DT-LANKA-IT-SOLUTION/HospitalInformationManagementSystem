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
        public static DataTable getUsername(AuthModel authModel)
        {
            try
            {
                string sql = string.Format("SELECT password FROM Users WHERE user_name = @username");

                SqlParameter[] _sql = new SqlParameter[1];

                _sql[0] = SqlParameterFormat.Format("@username", authModel.Username);

                return ODBC.GetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
