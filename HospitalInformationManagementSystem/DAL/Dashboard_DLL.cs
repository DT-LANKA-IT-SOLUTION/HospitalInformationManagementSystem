using System;
using HospitalInformationManagementSystem.Model;
using HospitalInformationManagementSystem.Other;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HospitalInformationManagementSystem.DAL
{
    class Dashboard_DLL
    {
        public DataTable GetPatientCount()
        {
            try
            {
                string sql = string.Format("SELECT Count(Isnull(Patients.User_Id,0)) AS PCount FROM Patients,Users WHERE Patients.user_id = Users.user_id AND Users.IsActive=@IsActive");

                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = SqlParameterFormat.Format("@IsActive", true);

                return ODBC.GetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetAppointmentCount()
        {
            try
            {
                string sql = string.Format("SELECT Count(isnull(app_id,0)) AS ACount FROM Appointments WHERE status=@IsActive");

                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = SqlParameterFormat.Format("@IsActive", true);

                return ODBC.GetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }


        }


        public DataTable GetComplaintCount()
        {
            try
            {
                string sql = string.Format("SELECT Count(isnull(comp_id,0)) AS CCount FROM Complaints WHERE IsActive=@IsActive");

                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = SqlParameterFormat.Format("@IsActive", true);

                return ODBC.GetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }


        }

        public DataTable FillChart()
        {
            try
            {
                string sql = string.Format("  select app_date as AppDate,count(isnull(app_id,0)) as Appcount from Appointments WHERE status=@IsActive group by app_date ");

                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = SqlParameterFormat.Format("@IsActive", true);

                return ODBC.GetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}