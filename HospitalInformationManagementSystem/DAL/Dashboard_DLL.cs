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
        public static DataTable GetPatientCount()
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

        public static DataTable GetAppointmentCount()
        {
            try
            {
                string sql = string.Format("SELECT Count(isnull(app_id,0)) AS ACount FROM Appointments WHERE IsActive=@IsActive");

                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = SqlParameterFormat.Format("@IsActive", true);

                return ODBC.GetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }


        }


        public static DataTable GetComplaintCount()
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

        public static DataTable GetDoctorCount()
        {
            try
            {
                string sql = string.Format("SELECT Count(isnull(user_type,0)) AS DCount FROM Users WHERE IsActive=@IsActive AND user_type=@user_type");

                SqlParameter[] _sql = new SqlParameter[2];
                _sql[0] = SqlParameterFormat.Format("@IsActive", true);
                _sql[1] = SqlParameterFormat.Format("@user_type", "Medical Officer");

                return ODBC.GetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }


        }

        public static DataTable FillChart()
        {
            try
            {
                string sql = string.Format("SELECT app_date as AppDate,count(isnull(app_id,0)) as Appcount FROM Appointments WHERE IsActive=@IsActive group by app_date ");

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