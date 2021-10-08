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
    class Complaint_DLL
    {
        public static DataTable GetAllComplaints()
        {
            try
            {
                string sql = string.Format("SELECT * FROM Complaints WHERE IsActive=@IsActive");

                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = SqlParameterFormat.Format("@IsActive",true);

                return ODBC.GetData(sql, _sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static int AddComplaints(ComplaintModel ComplaintModel)
        {
            try
            {
                string sql = string.Format("INSERT INTO Complaints(comp_type,comp_by,phone_no,date,description,attachment_type,attachment_data,user_id,IsActive,nic_no,complaint_category)"
                + "VALUES(@comp_type,@comp_by,@phone_no,@date,@description,@attachment_type,@attachment_data,@user_id,@IsActive,@nic_no,@complaint_category)");

                SqlParameter[] _sql = new SqlParameter[11];

                byte[] file;
                using (var stream = new FileStream(ComplaintModel.attachment_data, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        file = reader.ReadBytes((int)stream.Length);
                    }
                }

                _sql[0] = SqlParameterFormat.Format("@comp_type", ComplaintModel.complaint_type);
                _sql[1] = SqlParameterFormat.Format("@comp_by", ComplaintModel.complaint_by);
                _sql[2] = SqlParameterFormat.Format("@phone_no", ComplaintModel.phone_no);
                _sql[3] = SqlParameterFormat.Format("@date", ComplaintModel.date);
                _sql[4] = SqlParameterFormat.Format("@description", ComplaintModel.description);
                //_sql[5] = SqlParameterFormat.Format("@action_taken", ComplaintModel.action_taken);
                //_sql[6] = SqlParameterFormat.Format("@note", ComplaintModel.note);
                _sql[5] = SqlParameterFormat.Format("@attachment_type", ComplaintModel.attachment_type);
                _sql[6] = SqlParameterFormat.Format("@attachment_data", file);
                _sql[7] = SqlParameterFormat.Format("@user_id", PermisionsModel.user_id);
                _sql[8] = SqlParameterFormat.Format("@IsActive", ComplaintModel.IsActive);
                _sql[9] = SqlParameterFormat.Format("@nic_no", ComplaintModel.nic_no);
                _sql[10] = SqlParameterFormat.Format("@complaint_category", ComplaintModel.complaintCategory);


                return ODBC.SetData(sql, _sql);
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int UpdateComplaints(ComplaintModel ComplaintModel)
        {
            try
            {
                string sql = "";

                SqlParameter[] _sql;

                byte[] file;

                if (ComplaintModel.attachment_data != null)
                {
                    using (var stream = new FileStream(ComplaintModel.attachment_data, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = new BinaryReader(stream))
                        {
                            file = reader.ReadBytes((int)stream.Length);
                        }
                    }

                    sql = string.Format("UPDATE Complaints"
                     + " SET comp_type = @comp_type"
                     + " , comp_by = @comp_by"
                     + " , phone_no = @phone_no"
                     + " , date = @date"
                     + " , description = @description"
                     + " , action_taken = @action_taken"
                     + " , note = @note"
                     + " , attachment_type = @attachment_type"
                     + " , attachment_data = @attachment_data"
                     + " , user_id = @user_id"
                     + " , IsActive = @IsActive"
                     + " , complaint_category = @complaint_category"
                     + " WHERE comp_id = @comp_id");

                    _sql = new SqlParameter[14];

                    _sql[12] = SqlParameterFormat.Format("@attachment_data", file);
                    _sql[13] = SqlParameterFormat.Format("@attachment_type", ComplaintModel.attachment_type);
                }
                else
                {
                    sql = string.Format("UPDATE Complaints"
                    + " SET comp_type = @comp_type"
                    + " , comp_by = @comp_by"
                    + " , phone_no = @phone_no"
                    + " , date = @date"
                    + " , description = @description"
                    + " , action_taken = @action_taken"
                    + " , note = @note"
                    + " , user_id = @user_id"
                    + " , IsActive = @IsActive"
                    + " , complaint_category = @complaint_category"
                    + " WHERE comp_id = @comp_id");

                    _sql = new SqlParameter[12];
                }
               

                _sql[0] = SqlParameterFormat.Format("@comp_type", ComplaintModel.complaint_type);
                _sql[1] = SqlParameterFormat.Format("@comp_by", ComplaintModel.complaint_by);
                _sql[2] = SqlParameterFormat.Format("@phone_no", ComplaintModel.phone_no);
                _sql[3] = SqlParameterFormat.Format("@date", ComplaintModel.date);
                _sql[4] = SqlParameterFormat.Format("@description", ComplaintModel.description);
                _sql[5] = SqlParameterFormat.Format("@action_taken", ComplaintModel.action_taken);
                _sql[6] = SqlParameterFormat.Format("@note", ComplaintModel.note);
                _sql[7] = SqlParameterFormat.Format("@user_id", PermisionsModel.user_id);
                _sql[8] = SqlParameterFormat.Format("@IsActive", ComplaintModel.IsActive);
                _sql[9] = SqlParameterFormat.Format("@nic_no", ComplaintModel.nic_no);
                _sql[10] = SqlParameterFormat.Format("@comp_id", ComplaintModel.complaint_id);
                _sql[11] = SqlParameterFormat.Format("@complaint_category", ComplaintModel.complaintCategory);
               

                return ODBC.SetData(sql, _sql);                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int DeleteComplaints(bool Active, int comp_id)
        {
            try
            {
                string sql = string.Format("UPDATE Complaints SET" +
                    " IsActive=@Active" +
                    " WHERE comp_id=@comp_id"
                    );

                SqlParameter[] _sql = new SqlParameter[2];

                _sql[0] = SqlParameterFormat.Format("@Active", Active);
                _sql[1] = SqlParameterFormat.Format("@comp_id", comp_id);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public static SqlDataReader GetAttachment(int comp_id)
        {
            string sql = string.Format("SELECT attachment_data FROM Complaints WHERE IsActive=IsActive AND comp_id = @comp_id");

            SqlParameter[] _sql = new SqlParameter[2];
            _sql[0] = SqlParameterFormat.Format("@IsActive", true);
            _sql[1] = SqlParameterFormat.Format("@comp_id", comp_id);

            return ODBC.GetData_reader(sql, _sql);
        }
    }
}
