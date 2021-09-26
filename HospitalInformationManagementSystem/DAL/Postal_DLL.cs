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
    class Postal_DLL
    {
        public static DataTable GetAllPostal()
        {
            try
            {
                return ODBC.GetData("SELECT * FROM Postals");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int AddPostal(PostalModel postalModel)
        {
            try
            {
                string sql = string.Format("INSERT INTO Postals(postal_type,ref_no,from_name,address,note,to_name,created_date,attachment_type,attachment_data,user_id)" +
                "VALUES(@postal_type,@ref_no,@from_name,@address,@note,@to_name,@date,@attachment_type,@attachment_data,@user_id)");

                byte[] file;
                using (var stream = new FileStream(postalModel.attachment_data, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        file = reader.ReadBytes((int)stream.Length);
                    }
                }

                SqlParameter[] _sql = new SqlParameter[10];

                _sql[0] = SqlParameterFormat.Format("@postal_type", postalModel.postal_type);
                _sql[1] = SqlParameterFormat.Format("@ref_no", postalModel.ref_no);
                _sql[2] = SqlParameterFormat.Format("@from_name", postalModel.from_name);
                _sql[3] = SqlParameterFormat.Format("@address", postalModel.address);
                _sql[4] = SqlParameterFormat.Format("@note", postalModel.note);
                _sql[5] = SqlParameterFormat.Format("@to_name", postalModel.to_name);
                _sql[6] = SqlParameterFormat.Format("@date", postalModel.date);
                //_sql[6] = SqlParameterFormat.Format("@date", postalModel.date);
                _sql[7] = SqlParameterFormat.Format("@attachment_type", postalModel.attachment_type);
                _sql[8] = SqlParameterFormat.Format("@attachment_data", file);
                _sql[9] = SqlParameterFormat.Format("@user_id", postalModel.user_id);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int UpdatePostal(PostalModel postalModel)
        {
            try
            {
                string sql = string.Format("UPDATE Users SET postal_type =@postal_type," +
                      "ref_no =@ref_no," +
                      "from_name = @from_name," +
                      "address = @address," +
                      "note = @note," +
                      "to_name = @to_name," +
                      "date = @date," +
                      "attachment_type = @attachment_type," +
                      "attachment_data = @attachment_data," +
                      "user_id = @user_id," +
                      "WHERE postal_id = @postal_id"
                 );

                SqlParameter[] _sql = new SqlParameter[10];

                _sql[0] = SqlParameterFormat.Format("@postal_type", postalModel.postal_type);
                _sql[1] = SqlParameterFormat.Format("@ref_no", postalModel.ref_no);
                _sql[2] = SqlParameterFormat.Format("@from_name", postalModel.from_name);
                _sql[3] = SqlParameterFormat.Format("@address", postalModel.address);
                _sql[4] = SqlParameterFormat.Format("@note", postalModel.note);
                _sql[5] = SqlParameterFormat.Format("@to_name", postalModel.to_name);
                _sql[6] = SqlParameterFormat.Format("@date", postalModel.date);
                _sql[7] = SqlParameterFormat.Format("@attachment_type", postalModel.attachment_type);
                _sql[8] = SqlParameterFormat.Format("@attachment_data", postalModel.attachment_data);
                _sql[9] = SqlParameterFormat.Format("@user_id", postalModel.user_id);

                return ODBC.SetData(sql, _sql);
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int DeletePostal(int postal_id)
        {
            try
            {
                string sql = string.Format("UPDATE Postals SET" +
                    "WHERE postal_id=@postal_id"
                    );

                SqlParameter[] _sql = new SqlParameter[1];

                _sql[0] = SqlParameterFormat.Format("@postal_id", postal_id);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
