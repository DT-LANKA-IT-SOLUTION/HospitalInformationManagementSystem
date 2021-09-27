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
    class Patient_DLL
    {
        public static DataTable GetAllPatient()
        {
            try
            {
                string sql = string.Format("SELECT * FROM Patients,Users WHERE Patients.user_id = Users.user_id AND Users.IsActive=@IsActive");

                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = SqlParameterFormat.Format("@IsActive", true);

                return ODBC.GetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable GetPatientByNIC(string nic)
        {
            try
            {
                string sql = string.Format("SELECT * FROM Patients,Users WHERE Patients.user_id = Users.user_id AND Users.nic_no LIKE @nic");

                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = SqlParameterFormat.Format("@nic", "%"+nic+"%");

                return ODBC.GetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string GetPatientByUsername(PatientModel patientModel)
        {
            try
            {
                string sql = string.Format("SELECT user_name FROM Users WHERE user_name = @username");
                
                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = SqlParameterFormat.Format("@username", patientModel.user_name);

                return ODBC.ExecuteFunction(sql,_sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int AddPatient(PatientModel patientModel)
        {
            try
            {
                string sql = string.Format("INSERT INTO Users(user_name,password,f_name,l_name,gender,phone_no,nic_no,dob,address,marital_status,user_type)" +
                "VALUES(@user_name,@password,@f_name,@l_name,@gender,@phone_no,@nic_no,@dob,@address,@marital_status,@user_type)");

                SqlParameter[] _sql = new SqlParameter[11];

                _sql[0] = SqlParameterFormat.Format("@user_name", patientModel.user_name);
                _sql[1] = SqlParameterFormat.Format("@password", patientModel.password);
                _sql[2] = SqlParameterFormat.Format("@f_name", patientModel.first_name);
                _sql[3] = SqlParameterFormat.Format("@l_name", patientModel.last_name);
                _sql[4] = SqlParameterFormat.Format("@gender", patientModel.gender);
                _sql[5] = SqlParameterFormat.Format("@phone_no", patientModel.phone_no);
                _sql[6] = SqlParameterFormat.Format("@nic_no", patientModel.nic_no);
                _sql[7] = SqlParameterFormat.Format("@dob", patientModel.dob);
                _sql[8] = SqlParameterFormat.Format("@address", patientModel.address);
                _sql[9] = SqlParameterFormat.Format("@marital_status", patientModel.marital_status);
                _sql[10] = SqlParameterFormat.Format("@user_type", patientModel.user_type);

                if (ODBC.SetData(sql, _sql) > 0)
                {
                    sql = string.Format("SELECT IDENT_CURRENT('Users')");
                    int user_id = Int32.Parse(ODBC.ExecuteFunction(sql));
                    if (user_id > 0)
                    {
                        sql = string.Format("INSERT INTO Patients(user_id,blood_group,allergies)VALUES(@user_id,@blood_group,@allergies)");

                        _sql = new SqlParameter[3];
                        _sql[0] = SqlParameterFormat.Format("@user_id", user_id);
                        _sql[1] = SqlParameterFormat.Format("@blood_group", patientModel.blood_group);
                        _sql[2] = SqlParameterFormat.Format("@allergies", patientModel.allergies);

                        return ODBC.SetData(sql, _sql);
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int UpdatePatient(PatientModel patientModel)
        {
            try
            {
                string sql = string.Format("UPDATE Users SET user_name =@user_name," +
                      "password =@password," +
                      "f_name = @f_name," +
                      "l_name = @l_name," +
                      "gender = @gender," +
                      "phone_no = @phone_no," +
                      "nic_no = @nic_no," +
                      "dob = @dob," +
                      "address = @address," +
                      "marital_status = @marital_status," +
                      "user_type = @user_type" +
                      " WHERE user_id = @user_id"
                 );

                SqlParameter[] _sql = new SqlParameter[12];

                _sql[0] = SqlParameterFormat.Format("@user_name", patientModel.user_name);
                _sql[1] = SqlParameterFormat.Format("@password", patientModel.password);
                _sql[2] = SqlParameterFormat.Format("@f_name", patientModel.first_name);
                _sql[3] = SqlParameterFormat.Format("@l_name", patientModel.last_name);
                _sql[4] = SqlParameterFormat.Format("@gender", patientModel.gender);
                _sql[5] = SqlParameterFormat.Format("@phone_no", patientModel.phone_no);
                _sql[6] = SqlParameterFormat.Format("@nic_no", patientModel.nic_no);
                _sql[7] = SqlParameterFormat.Format("@dob", patientModel.dob);
                _sql[8] = SqlParameterFormat.Format("@address", patientModel.address);
                _sql[9] = SqlParameterFormat.Format("@marital_status", patientModel.marital_status);
                _sql[10] = SqlParameterFormat.Format("@user_type", patientModel.user_type);
                _sql[11] = SqlParameterFormat.Format("@user_id", patientModel.user_id);

                if (ODBC.SetData(sql, _sql) > 0)
                {
                    sql = string.Format("UPDATE Patients SET " +
                        "blood_group=@blood_group,allergies=@allergies" +
                        " WHERE user_id=@user_id"
                    );

                    _sql = new SqlParameter[3];
                    _sql[0] = SqlParameterFormat.Format("@user_id", patientModel.user_id);
                    _sql[1] = SqlParameterFormat.Format("@blood_group", patientModel.blood_group);
                    _sql[2] = SqlParameterFormat.Format("@allergies", patientModel.allergies);

                    return ODBC.SetData(sql, _sql);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int DeletePatient(bool Active, int user_id)
        {
            try
            {
                string sql = string.Format("UPDATE Users SET" +
                    " IsActive=@Active" +
                    " WHERE user_id=@user_id"
                    );

                SqlParameter[] _sql = new SqlParameter[2];

                _sql[0] = SqlParameterFormat.Format("@Active", Active);
                _sql[1] = SqlParameterFormat.Format("@user_id", user_id);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
