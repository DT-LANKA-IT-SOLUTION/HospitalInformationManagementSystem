using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformationManagementSystem.Other
{
    class SqlParameterFormat
    {
        public static SqlParameter Format(string parameter, SqlDbType dtype, object value)
        {
            SqlParameter parm = new SqlParameter(parameter, dtype);
            parm.Value = value;
            return parm;
        }
        public static SqlParameter Format(string parameter, object value)
        {
            return new SqlParameter(parameter, value);
        }
    }
}
