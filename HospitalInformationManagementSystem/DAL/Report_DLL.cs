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
    class Report_DLL
    {
        public DataSet GetAppointmentReport(ReportModel reportModel)
        {
            try
            {
                //string sql = string.Format("SELECT * FROM Appointments WHERE app_date BETWEEN @fromDate AND @toDate");
                string sql = string.Format("SELECT * FROM Appointments");

                //SqlParameter[] _sql = new SqlParameter[2];

                //_sql[0] = SqlParameterFormat.Format("@fromDate", reportModel.AppointmentFormDate);
                //_sql[1] = SqlParameterFormat.Format("@toDate", reportModel.AppointmentToDate);

                //return ODBC.ReportFunction(sql,_sql);
                return ODBC.ReportFunction(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet GetUserReport(ReportModel reportModel)
        {
            try
            {
                //string sql = string.Format("SELECT * FROM Users WHERE app_date BETWEEN @fromDate AND @toDate");
                string sql = string.Format("SELECT * FROM Users");

                //SqlParameter[] _sql = new SqlParameter[2];

                //_sql[0] = SqlParameterFormat.Format("@fromDate", reportModel.UserFormDate);
                //_sql[1] = SqlParameterFormat.Format("@toDate", reportModel.UserToDate);

                //return ODBC.ReportFunction(sql, _sql);
                return ODBC.ReportFunction(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet GetPatientReport(ReportModel reportModel)
        {
            try
            {
                string sql = string.Format("SELECT * FROM Appointments WHERE app_date BETWEEN @fromDate AND @toDate");

                SqlParameter[] _sql = new SqlParameter[2];

                _sql[0] = SqlParameterFormat.Format("@fromDate", reportModel.PatientFormDate);
                _sql[1] = SqlParameterFormat.Format("@toDate", reportModel.PatientToDate);

                return ODBC.ReportFunction(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
