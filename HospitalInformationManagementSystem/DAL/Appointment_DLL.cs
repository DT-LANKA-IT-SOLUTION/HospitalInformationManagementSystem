using HospitalInformationManagementSystem.Model;
using HospitalInformationManagementSystem.Other;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformationManagementSystem.DAL
{
    class Appointment_DLL
    {
        public static DataTable GetAllAppointment()
        {
            try
            {
                string sql = "";

                if (PermisionsModel.user_type == "patient")
                {
                    sql = string.Format("SELECT * FROM Appointments");
                }
                else if (PermisionsModel.user_type == "Medical Officer")
                {
                    sql = string.Format("SELECT * FROM Appointments");
                }
                else
                {
                    sql = string.Format("SELECT * FROM Appointments");
                }

                return ODBC.GetData(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable GetAppointmentByAppointmentNo(string appno)
        {
            int appointmentno = Convert.ToInt32(appno);
            try
            {
                string sql = string.Format("SELECT * FROM Appointments WHERE Appointments.appointment_no LIKE @appno");

                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = SqlParameterFormat.Format("@appno", "%" + appointmentno + "%");

                return ODBC.GetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int AddAppointment(AppointmentModel appointmentModel)
        {
            try
            {
                string sql = string.Format("INSERT INTO Appointments(appointment_no,app_date,app_time,patient,symptoms,medical_officer,status,user_id)" +
                "VALUES(@appointment_no,@app_date,@app_time,@patient,@symptoms,@medical_officer,@status,@user_id)");

                SqlParameter[] _sql = new SqlParameter[8];

                _sql[0] = SqlParameterFormat.Format("@appointment_no", appointmentModel.appointment_no);
                _sql[1] = SqlParameterFormat.Format("@app_date", appointmentModel.app_date);
                _sql[2] = SqlParameterFormat.Format("@app_time", appointmentModel.app_time);
                _sql[3] = SqlParameterFormat.Format("@patient", appointmentModel.patient);
                _sql[4] = SqlParameterFormat.Format("@symptoms", appointmentModel.symptoms);
                _sql[5] = SqlParameterFormat.Format("@medical_officer", appointmentModel.medical_officer);
                _sql[6] = SqlParameterFormat.Format("@status", appointmentModel.status);
                _sql[7] = SqlParameterFormat.Format("@user_id", appointmentModel.user_id);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int UpdateAppointment(AppointmentModel appointmentModel)
        {
            try
            {
                string sql = string.Format("UPDATE Appointments SET appointment_no = @appointment_no, patient = @patient, symptoms = @symptoms, medical_officer = @medical_officer, app_date = @app_date, app_time = @app_time, status = @status, user_id = @user_id Where app_id = @app_id");

                SqlParameter[] _sql = new SqlParameter[9];

                _sql[0] = SqlParameterFormat.Format("@appointment_no", appointmentModel.appointment_no);
                _sql[1] = SqlParameterFormat.Format("@patient", appointmentModel.patient);
                _sql[2] = SqlParameterFormat.Format("@symptoms", appointmentModel.symptoms);
                _sql[3] = SqlParameterFormat.Format("@medical_officer", appointmentModel.medical_officer);
                _sql[4] = SqlParameterFormat.Format("@app_date", appointmentModel.app_date);
                _sql[5] = SqlParameterFormat.Format("@app_time", appointmentModel.app_time);
                _sql[6] = SqlParameterFormat.Format("@status", appointmentModel.status);
                _sql[7] = SqlParameterFormat.Format("@user_id", appointmentModel.user_id);
                _sql[8] = SqlParameterFormat.Format("@app_id", appointmentModel.app_id);

                return ODBC.SetData(sql, _sql);

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int DeleteAppointment(int app_id)
        {
            try
            {
                string sql = string.Format("DELETE FROM Appointments WHERE app_id = @app_id");

                SqlParameter[] _sql = new SqlParameter[1];

                _sql[0] = SqlParameterFormat.Format("@app_id", app_id);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable GetDoctors()
        {
            try
            {
                string sql = string.Format("SELECT * FROM Users WHERE user_type=@user_type AND IsActive=@IsActive");

                SqlParameter[] _sql = new SqlParameter[2];
                _sql[0] = SqlParameterFormat.Format("@user_type", "Medical Officer");
                _sql[1] = SqlParameterFormat.Format("@IsActive", true);

                return ODBC.GetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
