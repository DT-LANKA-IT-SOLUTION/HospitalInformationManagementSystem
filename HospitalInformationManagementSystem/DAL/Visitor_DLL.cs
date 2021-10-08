using HospitalInformationManagementSystem.Model;
using HospitalInformationManagementSystem.Other;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformationManagementSystem.DAL
{
    class Visitor_DLL
    {
        public static DataTable GetAllVisitor()
        {
            try
            {
                string sql = string.Format("SELECT * FROM Visitors WHERE Visitors.IsActive = @IsActive"); 
                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = SqlParameterFormat.Format("@IsActive", true);

                return ODBC.GetData(sql, _sql);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int AddVisitors(VisitorModel visitorModel)
        {
            try
            {
                string sql = string.Format("INSERT INTO Visitors(purpose,fname,lname,phone_no,nic_no,date,out_time,note,attachment_type,attachment_data,user_id)" +
                    "VALUES(@purpose,@fname,@lname,@phone_no,@nic_no,@date,@out_time,@note,@attachment_type,@attachment_data,@user_id)");

                byte[] file;
                using (var stream = new FileStream(visitorModel.attachment_data, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        file = reader.ReadBytes((int)stream.Length);
                    }
                }

                SqlParameter[] _sql = new SqlParameter[11];

                _sql[0] = SqlParameterFormat.Format("@purpose", visitorModel.purpose);
                _sql[1] = SqlParameterFormat.Format("@fname", visitorModel.fname);
                _sql[2] = SqlParameterFormat.Format("@lname", visitorModel.lname);
                _sql[3] = SqlParameterFormat.Format("@phone_no", visitorModel.phone_no);
                _sql[4] = SqlParameterFormat.Format("@nic_no", visitorModel.nic_no);
                _sql[5] = SqlParameterFormat.Format("@date", visitorModel.date);
               // _sql[6] = SqlParameterFormat.Format("@in_time", visitorModel.in_time);
                _sql[6] = SqlParameterFormat.Format("@out_time", visitorModel.out_time);
                _sql[7] = SqlParameterFormat.Format("@note", visitorModel.note);
                _sql[8] = SqlParameterFormat.Format("@attachment_type", visitorModel.cmbAttachmentType);
                _sql[9] = SqlParameterFormat.Format("@attachment_data", file);
                _sql[10] = SqlParameterFormat.Format("@user_id", PermisionsModel.user_id);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static int UpdateVisitors(VisitorModel visitorModel)
        {
            try
            {
                string sql = string.Format("UPDATE Visitors SET +" +
                    "purpose = @purpose," +
                    "fname = @vis_fname," +
                    "lname = @vis_lname," +
                    "phone_no = @phone_no," +
                    "nic_no = @nic_no," +
                    "date = @date," +
                  //  "in_time = @in_time," +
                    "out_time = @out_time," +
                    "note = @note," +
                    "attachment_type = @attachment_type," +
                    "attachment_data = @attachement_date," +
                    "user_id = @user_id" +
                    "WHERE visitor_id = @visitor_id"

                    );

                SqlParameter[] _sql = new SqlParameter[12];

                _sql[0] = SqlParameterFormat.Format("@purpose", visitorModel.purpose);
                _sql[1] = SqlParameterFormat.Format("@fname", visitorModel.fname);
                _sql[2] = SqlParameterFormat.Format("@lname", visitorModel.lname);
                _sql[3] = SqlParameterFormat.Format("@phone_no", visitorModel.phone_no);
                _sql[4] = SqlParameterFormat.Format("@nic_no", visitorModel.nic_no);
                _sql[5] = SqlParameterFormat.Format("@date", visitorModel.date);
        //        _sql[6] = SqlParameterFormat.Format("@in_time", visitorModel.in_time);
                _sql[6] = SqlParameterFormat.Format("@out_time", visitorModel.out_time);
                _sql[7] = SqlParameterFormat.Format("@note", visitorModel.note);
                _sql[8] = SqlParameterFormat.Format("@attachment_type", visitorModel.cmbAttachmentType);
                _sql[9] = SqlParameterFormat.Format("@attachment_data", visitorModel.attachment_data);
                _sql[10] = SqlParameterFormat.Format("@visitor_id", PermisionsModel.user_id);
                _sql[11] = SqlParameterFormat.Format("@visitor_id", visitorModel.visitor_id);

                return ODBC.SetData(sql, _sql);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int DeleteVisitor(bool Active, int visitor_id)
        {
            try
            {
                string sql = string.Format("UPDATE Visitors SET" +
                    " IsActive=@Active" +
                    " WHERE visitor_id=@visitor_id"
                    );

                SqlParameter[] _sql = new SqlParameter[2];

                _sql[0] = SqlParameterFormat.Format("@Active", Active);
                _sql[1] = SqlParameterFormat.Format("@visitor_id", visitor_id);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
