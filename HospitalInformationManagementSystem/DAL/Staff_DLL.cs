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
    class Staff_DLL
    {
        public static DataTable GetAllStaff()
        {
            try
            {
                string sql = string.Format("SELECT * FROM Staff_Members,Users WHERE Staff_Members.user_id = Users.user_id AND Users.IsActive = @IsActive");

                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = SqlParameterFormat.Format("@IsActive", true);

                return ODBC.GetData(sql, _sql);
                //return ODBC.GetData("SELECT * FROM Staff_Members,Users WHERE Staff_Members.user_id = Users.user_id AND Users.IsActive = @IsActive");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string GetUserByUsername(StaffModel staffModel)
        {
            try
            {
                string sql = string.Format("SELECT user_name FROM Users WHERE user_name = @username");

                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = SqlParameterFormat.Format("@username",staffModel.user_name);

                return ODBC.ExecuteFunction(sql, _sql);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static DataTable GetUserByNIC(string nic)
        {
            try
            {
                string sql = string.Format("SELECT * FROM Users,Staff_Members WHERE Users.user_id = Staff_Members.user_id AND Users.nic_no LIKE @nic");

                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = SqlParameterFormat.Format("@nic", "%"+nic+"%");

                return ODBC.GetData(sql,_sql);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int AddStaff(StaffModel staffModel)
        {
            try
            {
                string sql = string.Format("INSERT INTO Users(user_name,password,f_name,l_name,gender,phone_no,nic_no,dob,address,marital_status,user_type,IsActive)" +
                    "VALUES(@user_name,@password,@f_name,@l_name,@gender,@phone_no,@nic_no,@dob,@address,@marital_status,@user_type,@IsActive)");

                SqlParameter[] _sql = new SqlParameter[12];

                _sql[0] = SqlParameterFormat.Format("@user_name", staffModel.user_name);
                _sql[1] = SqlParameterFormat.Format("@password", staffModel.password);
                _sql[2] = SqlParameterFormat.Format("@f_name", staffModel.first_name);
                _sql[3] = SqlParameterFormat.Format("@l_name", staffModel.last_name);
                _sql[4] = SqlParameterFormat.Format("@gender", staffModel.gender);
                _sql[5] = SqlParameterFormat.Format("@phone_no", staffModel.phone_no);
                _sql[6] = SqlParameterFormat.Format("@nic_no", staffModel.nic_no);
                _sql[7] = SqlParameterFormat.Format("@dob", staffModel.birth_date);
                _sql[8] = SqlParameterFormat.Format("@address", staffModel.address);
                _sql[9] = SqlParameterFormat.Format("@marital_status", staffModel.marital_status);
                _sql[10] = SqlParameterFormat.Format("@user_type", staffModel.user_type);                
                _sql[11] = SqlParameterFormat.Format("@IsActive", staffModel.IsActive);
                

                if (ODBC.SetData(sql, _sql) > 0)
                {
                    sql = string.Format("SELECT IDENT_CURRENT('Users')");
                    int user_id = Int32.Parse(ODBC.ExecuteFunction(sql));
                    if (user_id > 0)
                    {
                        sql = string.Format("INSERT INTO User_Permisions(permision_id,user_id,status)VALUES(@permision_id,@user_id,@status)");
                        
                        for(int i = 1; i < 9; i++)
                        {
                            switch (i)
                            {
                                case 1:
                                    _sql = new SqlParameter[3];
                                    _sql[0] = SqlParameterFormat.Format("@permision_id",i);
                                    _sql[1] = SqlParameterFormat.Format("@user_id", user_id);
                                    _sql[2] = SqlParameterFormat.Format("@status", staffModel.DashboardValue);
                                    ODBC.SetData(sql, _sql);
                                    break;
                                case 2:
                                    _sql = new SqlParameter[3];
                                    _sql[0] = SqlParameterFormat.Format("@permision_id", i);
                                    _sql[1] = SqlParameterFormat.Format("@user_id", user_id);
                                    _sql[2] = SqlParameterFormat.Format("@status",staffModel.PatientValue);
                                    ODBC.SetData(sql, _sql);
                                    break;
                                case 3:
                                    _sql = new SqlParameter[3];
                                    _sql[0] = SqlParameterFormat.Format("@permision_id", i);
                                    _sql[1] = SqlParameterFormat.Format("@user_id", user_id);
                                    _sql[2] = SqlParameterFormat.Format("@status", staffModel.VistorsValue);
                                    ODBC.SetData(sql, _sql);
                                    break;
                                case 4:
                                    _sql = new SqlParameter[3];
                                    _sql[0] = SqlParameterFormat.Format("@permision_id", i);
                                    _sql[1] = SqlParameterFormat.Format("@user_id", user_id);
                                    _sql[2] = SqlParameterFormat.Format("@status", staffModel.AppointmentValue);
                                    ODBC.SetData(sql, _sql);
                                    break;
                                case 5:
                                    _sql = new SqlParameter[3];
                                    _sql[0] = SqlParameterFormat.Format("@permision_id", i);
                                    _sql[1] = SqlParameterFormat.Format("@user_id", user_id);
                                    _sql[2] = SqlParameterFormat.Format("@status", staffModel.PostalValue);
                                    ODBC.SetData(sql, _sql);
                                    break;
                                case 6:
                                    _sql = new SqlParameter[3];
                                    _sql[0] = SqlParameterFormat.Format("@permision_id", i);
                                    _sql[1] = SqlParameterFormat.Format("@user_id", user_id);
                                    _sql[2] = SqlParameterFormat.Format("@status", staffModel.ComplaintsValue);
                                    ODBC.SetData(sql, _sql);
                                    break;
                                case 7:
                                    _sql = new SqlParameter[3];
                                    _sql[0] = SqlParameterFormat.Format("@permision_id", i);
                                    _sql[1] = SqlParameterFormat.Format("@user_id", user_id);
                                    _sql[2] = SqlParameterFormat.Format("@status", staffModel.ReportsValue);
                                    ODBC.SetData(sql, _sql);
                                    break;
                                case 8:
                                    _sql = new SqlParameter[3];
                                    _sql[0] = SqlParameterFormat.Format("@permision_id", i);
                                    _sql[1] = SqlParameterFormat.Format("@user_id", user_id);
                                    _sql[2] = SqlParameterFormat.Format("@status", staffModel.StaffValue);
                                    ODBC.SetData(sql, _sql);
                                    break;
                            }
                        }

                        


                        sql = string.Format("INSERT INTO Staff_Members(staff_id,user_id,staff_email,join_date,speciality_area,photo_data)VALUES(@staff_id,@user_id,@staff_email,@joined_date,@speciality_area,@photo_data)");
                        _sql = new SqlParameter[6];
                        _sql[0] = SqlParameterFormat.Format("@staff_id", staffModel.staff_id);
                        _sql[1] = SqlParameterFormat.Format("@user_id", user_id);
                        _sql[2] = SqlParameterFormat.Format("@staff_email", staffModel.staff_email);
                        _sql[3] = SqlParameterFormat.Format("@joined_date", staffModel.join_date);
                        _sql[4] = SqlParameterFormat.Format("@speciality_area", staffModel.speciality_area);
                        _sql[5] = SqlParameterFormat.Format("@photo_data", staffModel.photo_data);

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

        public static SqlDataReader GetStaffPermissions(int user_id)
        {
            try
            {
                string sql = string.Format("SELECT permision_id, user_id, status FROM User_Permisions WHERE user_id = @user_id");

                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = SqlParameterFormat.Format("@user_id", user_id);

                return ODBC.GetData_reader(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int UpdateStaff(StaffModel staffModel)
        {
            try
            {
                string sql = string.Format("UPDATE Users SET user_name = @user_name,"
                    + "password = @password,"
                    + "f_name = @f_name,"
                    + "l_name = @l_name,"
                    + "gender = @gender,"
                    + "phone_no = @phone_no,"
                    + "nic_no = @nic_no," 
                    + "dob = @dob,"
                    + "address = @address,"
                    + "marital_status = @marital_status,"
                    + "user_type = @user_type"                  
                    + " WHERE user_id = @user_id"
                    );

                SqlParameter[] _sql = new SqlParameter[12];
                _sql[0] = SqlParameterFormat.Format("@user_name", staffModel.user_name);
                _sql[1] = SqlParameterFormat.Format("@password", staffModel.password);
                _sql[2] = SqlParameterFormat.Format("@f_name", staffModel.first_name);
                _sql[3] = SqlParameterFormat.Format("@l_name", staffModel.last_name);
                _sql[4] = SqlParameterFormat.Format("@gender", staffModel.gender);
                _sql[5] = SqlParameterFormat.Format("@phone_no", staffModel.phone_no);
                _sql[6] = SqlParameterFormat.Format("@nic_no", staffModel.nic_no);
                _sql[7] = SqlParameterFormat.Format("@dob", staffModel.birth_date);
                _sql[8] = SqlParameterFormat.Format("@address", staffModel.address);
                _sql[9] = SqlParameterFormat.Format("@marital_status", staffModel.marital_status);
                _sql[10] = SqlParameterFormat.Format("@user_type", staffModel.user_type);
                _sql[11] = SqlParameterFormat.Format("@user_id", staffModel.user_id);

                if (ODBC.SetData(sql,_sql) > 0)
                {
                    sql = string.Format("UPDATE Staff_Members SET staff_id = @staff_id,"
                        + "user_id = @user_id,"
                        + "staff_email = @staff_email,"
                        + "join_date = @join_date,"
                        + "speciality_area = @speciality_area,"
                        + "photo_data = @photo_data"
                        + " WHERE user_id = @user_id"
                        );
                    _sql = new SqlParameter[6];
                    _sql[0] = SqlParameterFormat.Format("@staff_id", staffModel.staff_id);
                    _sql[1] = SqlParameterFormat.Format("@user_id", staffModel.user_id);
                    _sql[2] = SqlParameterFormat.Format("@staff_email", staffModel.staff_email);
                    _sql[3] = SqlParameterFormat.Format("@join_date", staffModel.join_date);
                    _sql[4] = SqlParameterFormat.Format("@speciality_area", staffModel.speciality_area);
                    _sql[5] = SqlParameterFormat.Format("@photo_data", staffModel.photo_data);
                    return ODBC.SetData(sql,_sql);
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

        public static int DeleteStaff(bool Active, int user_id)
        {
            try
            {
                string sql = string.Format("UPDATE Users SET"
                    + " IsActive = @Active"
                    + " WHERE user_id = @user_id"
                    );

                SqlParameter[] _sql = new SqlParameter[2];

                _sql[0] = SqlParameterFormat.Format("@Active", Active);
                _sql[1] = SqlParameterFormat.Format("user_id",user_id);

                return ODBC.SetData(sql,_sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
