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
    class Complaint_DLL
    {
        public static DataTable GetAllComplaints()
        {
            try
            {
                string sql = string.Format("SELECT * FROM Complaints");

                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = SqlParameterFormat.Format("@IsActive",true);

                return ODBC.GetData(sql, _sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
