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

        public static int AddStaff(StaffModel staffModel)
        {
            try
            {
                string sql = string.Format("INSERT INTO Users(user_name,password,f_name,l_name,gender,phone_no,nic_no,dob,address,marital_status,user_type)" +
                    "VALUES(@user_name,@password,@f_name,@l_name,@gender,@phone_no,@nic_no,@dob,@address,@marital_status,@user_type)");

                SqlParameter[] _sql = new SqlParameter[11];

                _sql[0] = SqlParameterFormat.Format("@user_name", staffModel.user_name);
                _sql[1] = SqlParameterFormat.Format("@password", staffModel.password);
                _sql[2] = SqlParameterFormat.Format("@f_name", staffModel.first_name);
                _sql[3] = SqlParameterFormat.Format("@l_name", staffModel.last_name);
                _sql[4] = SqlParameterFormat.Format("@gender", staffModel.gender);
                _sql[5] = SqlParameterFormat.Format("@phone_no", staffModel.phone_no);
                _sql[6] = SqlParameterFormat.Format("@nic_no", staffModel.nic);
                _sql[7] = SqlParameterFormat.Format("@dob", staffModel.birth_date);
                _sql[8] = SqlParameterFormat.Format("@address", staffModel.address);
                _sql[9] = SqlParameterFormat.Format("@marital_status", staffModel.marital_status);
                _sql[10] = SqlParameterFormat.Format("@user_type", staffModel.user_type);

                if (ODBC.SetData(sql, _sql) > 0)
                {
                    sql = string.Format("SELECT IDENT_CURRENT('Users')");
                    int user_id = Int32.Parse(ODBC.ExecuteFunction(sql));
                    if (user_id > 0)
                    {
                        sql = string.Format("INSERT INTO Staff_Members(staff_id,user_id,staff_email,join_date)VALUES(@staff_id,@user_id,@staff_email,@joined_date)");
                        _sql = new SqlParameter[4];
                        _sql[0] = SqlParameterFormat.Format("@staff_id", staffModel.staff_id);
                        _sql[1] = SqlParameterFormat.Format("@user_id", user_id);
                        _sql[2] = SqlParameterFormat.Format("@staff_email", staffModel.staff_email);
                        _sql[3] = SqlParameterFormat.Format("@joined_date", staffModel.joined_date);

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

        public static int UpdateStaff(StaffModel staffModel)
        {
            try
            {
                string sql = string.Format("UPDATE Users SET f_name = @f_name,"
                    + "l_name = @l_name,"
                    + "gender = @gender,"
                    + "phone_no = @phone_no,"
                    + "nic_no = @nic_no,"
                    + "dob = @dob,"
                    + "address = @address,"
                    + "marital_status = @marital_status"
                    + " WHERE user_id = @user_id"
                    );

                SqlParameter[] _sql = new SqlParameter[9];

                _sql[0] = SqlParameterFormat.Format("@f_name", staffModel.first_name);
                _sql[1] = SqlParameterFormat.Format("@l_name", staffModel.last_name);
                _sql[2] = SqlParameterFormat.Format("@gender", staffModel.gender);
                _sql[3] = SqlParameterFormat.Format("@phone_no", staffModel.phone_no);
                _sql[4] = SqlParameterFormat.Format("@nic_no", staffModel.nic);
                _sql[5] = SqlParameterFormat.Format("@dob", staffModel.birth_date);
                _sql[6] = SqlParameterFormat.Format("@address", staffModel.address);
                _sql[7] = SqlParameterFormat.Format("@marital_status", staffModel.marital_status);
                _sql[8] = SqlParameterFormat.Format("@user_id", staffModel.user_id);

                if(ODBC.SetData(sql,_sql) > 0)
                {
                    sql = string.Format("UPDATE Staff_Members SET staff_id = @staff_id,"
                        + "staff_email = @staff_email,"
                        + "join_date = @join_date"
                        + " WHERE user_id = @user_id"
                        );
                    _sql = new SqlParameter[4];
                    _sql[0] = SqlParameterFormat.Format("staff_id", staffModel.staff_id);
                    _sql[1] = SqlParameterFormat.Format("user_id", staffModel.user_id);
                    _sql[2] = SqlParameterFormat.Format("staff_email", staffModel.staff_email);
                    _sql[3] = SqlParameterFormat.Format("join_date", staffModel.joined_date);

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
