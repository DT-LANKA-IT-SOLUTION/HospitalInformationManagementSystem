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
                return ODBC.GetData("SELECT * FROM Patients,Users WHERE Patients.user_id = Users.user_id");
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
                string sql = string.Format("INSERT INTO Patient(EmpName,EmpAddress,EmpQualification,EmpGender,EmpCountryId,Active,CreatedDate)" +
                "VALUES(@EmpName,@EmpAddress,@EmpQualification,@EmpGender,@EmpCountryId,@Active,@CreatedDate)");

                SqlParameter[] _sql = new SqlParameter[7];

                _sql[0] = SqlParameterFormat.Format("@EmpName", patientModel.EmpName);
                _sql[1] = SqlParameterFormat.Format("@EmpAddress", patientModel.EmpAddress);
                _sql[2] = SqlParameterFormat.Format("@EmpQualification", patientModel.EmpQualification);
                _sql[3] = SqlParameterFormat.Format("@EmpGender", patientModel.EmpGender);
                _sql[4] = SqlParameterFormat.Format("@EmpCountryId", patientModel.EmpCountryId);
                _sql[5] = SqlParameterFormat.Format("@Active", patientModel.Active);
                _sql[6] = SqlParameterFormat.Format("@CreatedDate", patientModel.CreatedDate);

                return ODBC.SetData(sql, _sql);
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
                string sql = string.Format("UPDATE TblPatient SET" +
                    "EmpName=@EmpName," +
                    "EmpAddress=@EmpAddress," +
                    "EmpQualification=@EmpQualification," +
                    "EmpGender=@EmpGender," +
                    "EmpCountryId=@EmpCountryId," +
                    "Active=@Active," +
                    "UpdatedDate=@UpdatedDate" +
                    "WHERE EmpId=@EmpId"
                    );

                SqlParameter[] _sql = new SqlParameter[8];

                _sql[0] = SqlParameterFormat.Format("@EmpName", tblPatient.EmpName);
                _sql[1] = SqlParameterFormat.Format("@EmpAddress", tblPatient.EmpAddress);
                _sql[2] = SqlParameterFormat.Format("@EmpQualification", tblPatient.EmpQualification);
                _sql[3] = SqlParameterFormat.Format("@EmpGender", tblPatient.EmpGender);
                _sql[4] = SqlParameterFormat.Format("@EmpCountryId", tblPatient.EmpCountryId);
                _sql[5] = SqlParameterFormat.Format("@Active", tblPatient.Active);
                _sql[6] = SqlParameterFormat.Format("@UpdatedDate", tblPatient.UpdatedDate);
                _sql[6] = SqlParameterFormat.Format("@EmpId", tblPatient.EmpID);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int DeletePatient(bool Active, int EmpID)
        {
            try
            {
                string sql = string.Format("UPDATE TblPatient SET" +
                    "Active=@Active," +
                    "WHERE EmpId=@EmpId"
                    );

                SqlParameter[] _sql = new SqlParameter[2];

                _sql[5] = SqlParameterFormat.Format("@Active", Active);
                _sql[6] = SqlParameterFormat.Format("@EmpId", EmpID);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
