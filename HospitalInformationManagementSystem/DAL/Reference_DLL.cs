using HospitalInformationManagementSystem.Model;
using HospitalInformationManagementSystem.Other;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformationManagementSystem.DAL
{
    class Reference_DLL
    {
        public static DataTable GetComplaintTypes()
        {
            string sql = string.Format("SELECT * FROM HMS_References WHERE reference_type=@reference_type");
            SqlParameter[] _sql = new SqlParameter[1];
            _sql[0] = SqlParameterFormat.Format("@reference_type", "Complaint");

            return ODBC.GetData(sql, _sql);
        }
    }
}
