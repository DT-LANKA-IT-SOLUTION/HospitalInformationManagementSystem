using HospitalInformationManagementSystem.DAL;
using HospitalInformationManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalInformationManagementSystem.BLL
{
    class Visitor_BLL
    {
        SqlDataReader dr;
        public void LoadAllVisitorGridView(DataGridView dtgVisitor)
        {
            try
            {
                dtgVisitor.AutoGenerateColumns = false;
                dtgVisitor.DataSource = Visitor_DLL.GetAllVisitor();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AddVisitor(VisitorModel visitorModel)
        {
            try
            {
                return Visitor_DLL.AddVisitors(visitorModel);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int UpdateVisitor(VisitorModel visitorModel)
        {
            try
            {
                return Visitor_DLL.UpdateVisitors(visitorModel);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int DeleteVisitor(bool Active, int VisitorID)
        {
            try
            {
                return Visitor_DLL.DeleteVisitor(Active, VisitorID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool GetAttachment(int visitor_id, SaveFileDialog sfdVisitor)
        {
            byte[] fileUpload;

            dr = Visitor_DLL.GetAttachment(visitor_id);

            if (dr.Read())
            {
                fileUpload = (byte[])dr.GetValue(0);

                if (sfdVisitor.ShowDialog() == DialogResult.OK)
                {
                    sfdVisitor.Title = "Save PDF Files";
                    sfdVisitor.Filter = "PDF document (*.pdf)|*.pdf";
                    // write bytes to disk as file

                    VisitorModel.viewFile = sfdVisitor.FileName;

                    using (FileStream fs = new FileStream(sfdVisitor.FileName, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite))
                    {
                        // use a binary writer to write the bytes to disk
                        using (BinaryWriter bw = new BinaryWriter(fs))
                        {
                            bw.Write(fileUpload);
                            bw.Close();
                            return true;
                        }
                    }

                }
            }
            return false;
        }

    }
}
