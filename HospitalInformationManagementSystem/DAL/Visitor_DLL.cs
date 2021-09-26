﻿using HospitalInformationManagementSystem.Model;
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

                SqlParameter[] _sql = new SqlParameter[12];

                _sql[0] = SqlParameterFormat.Format("@purpose", visitorModel.purpose);
                _sql[1] = SqlParameterFormat.Format("@vis_fname", visitorModel.fname);
                _sql[2] = SqlParameterFormat.Format("@vis_lname", visitorModel.lname);
                _sql[3] = SqlParameterFormat.Format("@phone_no", visitorModel.phone_no);
                _sql[4] = SqlParameterFormat.Format("@nic_no", visitorModel.nic_no);
                _sql[5] = SqlParameterFormat.Format("@date", visitorModel.date);
                _sql[6] = SqlParameterFormat.Format("@in_time", visitorModel.in_time);
                _sql[7] = SqlParameterFormat.Format("@out_time", visitorModel.out_time);
                _sql[8] = SqlParameterFormat.Format("@note", visitorModel.note);
                _sql[9] = SqlParameterFormat.Format("@attachment_type", visitorModel.attachment_type);
                _sql[10] = SqlParameterFormat.Format("@attachment_data", visitorModel.attachment_data);
                _sql[11] = SqlParameterFormat.Format("@user_id", PermisionsModel.user_id);

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
                string sql = string.Format("UPDATE Visitors SET visitor_id= @visitor_id" +
                    "purpose = @purpose," +
                    "fname = @vis_fname," +
                    "lname = @vis_lname," +
                    "phone_no = @phone_no," +
                    "nic_no = @nic_no," +
                    "date = @date," +
                    "in_time = @in_time," +
                    "out_time = @out_time," +
                    "note = @note," +
                    "attachment_type = @attachment_type," +
                    "attachment_data = @attachement_date," +
                    "user_id = @user_id"
                    
                    );

                SqlParameter[] _sql = new SqlParameter[12];

                _sql[0] = SqlParameterFormat.Format("@purpose", visitorModel.purpose);
                _sql[1] = SqlParameterFormat.Format("@vis_fname", visitorModel.fname);
                _sql[2] = SqlParameterFormat.Format("@vis_lname", visitorModel.lname);
                _sql[3] = SqlParameterFormat.Format("@phone_no", visitorModel.phone_no);
                _sql[4] = SqlParameterFormat.Format("@nic_no", visitorModel.nic_no);
                _sql[5] = SqlParameterFormat.Format("@date", visitorModel.date);
                _sql[6] = SqlParameterFormat.Format("@in_time", visitorModel.in_time);
                _sql[7] = SqlParameterFormat.Format("@out_time", visitorModel.out_time);
                _sql[8] = SqlParameterFormat.Format("@note", visitorModel.note);
                _sql[9] = SqlParameterFormat.Format("@attachment_type", visitorModel.attachment_type);
                _sql[10] = SqlParameterFormat.Format("@attachment_data", visitorModel.attachment_data);
                _sql[11] = SqlParameterFormat.Format("@user_id", PermisionsModel.user_id);

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
                    "IsActive=@Active," +
                    "WHERE visitor_id=@visitor_id"
                    );

                SqlParameter[] _sql = new SqlParameter[2];

                _sql[5] = SqlParameterFormat.Format("@Active", Active);
                _sql[6] = SqlParameterFormat.Format("@visitor_id", visitor_id);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}