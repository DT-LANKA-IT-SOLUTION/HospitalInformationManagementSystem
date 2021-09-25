using HospitalInformationManagementSystem.Model;
using HospitalInformationManagementSystem.Other;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                return ODBC.GetData("SELECT * FROM Visitors");
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
                string sql = string.Format("INSERT INTO Visitors(purpose,name,phone_no,nic_no,date,in_time,out_time,note,attachment_type,attachment_data,user_id)" +
                    "VALUES(@purpose,@vis_name,@phone_no,@nic_no,@date,@in_time,@out_time,@note,@attachment_type,@attachment_data,@user_id)");

                SqlParameter[] _sql = new SqlParameter[11];

                _sql[0] = SqlParameterFormat.Format("@purpose", visitorModel.purpose);
                _sql[1] = SqlParameterFormat.Format("@vis_name", visitorModel.name);
                _sql[2] = SqlParameterFormat.Format("@phone_no", visitorModel.phone_no);
                _sql[3] = SqlParameterFormat.Format("@nic_no", visitorModel.nic_no);
                _sql[4] = SqlParameterFormat.Format("@date", visitorModel.date);
                _sql[5] = SqlParameterFormat.Format("@in_time", visitorModel.in_time);
                _sql[6] = SqlParameterFormat.Format("@out_time", visitorModel.out_time);
                _sql[7] = SqlParameterFormat.Format("@note", visitorModel.note);
                _sql[8] = SqlParameterFormat.Format("@attachment_type", visitorModel.attachment_type);
                _sql[9] = SqlParameterFormat.Format("@attachment_data", visitorModel.attachment_data);
                _sql[10] = SqlParameterFormat.Format("@user_id", PermisionsModel.user_id);

                return ODBC.SetData(sql,_sql);
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
                string sql = string.Format("UPDATE Visitors S");

                SqlParameter[] _sql = new SqlParameter[11];

                _sql[0] = SqlParameterFormat.Format("@purpose", visitorModel.purpose);
                _sql[1] = SqlParameterFormat.Format("@vis_name", visitorModel.name);
                _sql[2] = SqlParameterFormat.Format("@phone_no", visitorModel.phone_no);
                _sql[3] = SqlParameterFormat.Format("@nic_no", visitorModel.nic_no);
                _sql[4] = SqlParameterFormat.Format("@date", visitorModel.date);
                _sql[5] = SqlParameterFormat.Format("@in_time", visitorModel.in_time);
                _sql[6] = SqlParameterFormat.Format("@out_time", visitorModel.out_time);
                _sql[7] = SqlParameterFormat.Format("@note", visitorModel.note);
                _sql[8] = SqlParameterFormat.Format("@attachment_type", visitorModel.attachment_type);
                _sql[9] = SqlParameterFormat.Format("@attachment_data", visitorModel.attachment_data);
                _sql[10] = SqlParameterFormat.Format("@user_id", PermisionsModel.user_id);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
