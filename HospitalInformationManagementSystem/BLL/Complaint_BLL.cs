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
    class Complaint_BLL
    {
        SqlDataReader dr;
        public void LoadAllComplaintsGridView(DataGridView dgvComplaints)
        {
            try
            {
                dgvComplaints.AutoGenerateColumns = false;
                dgvComplaints.DataSource = Complaint_DLL.GetAllComplaints();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int AddComplaints(ComplaintModel complaintModel)
        {
            try
            {
                return Complaint_DLL.AddComplaints(complaintModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int UpdateComplaints(ComplaintModel complaintModel)
        {
            try
            {
                return Complaint_DLL.UpdateComplaints(complaintModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int DeleteComplaints(bool Active, int comp_id)
        {
            try
            {
                return Complaint_DLL.DeleteComplaints(Active, comp_id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool GetAttachment(int comp_id,SaveFileDialog sfdComplaints)
        {
            byte[] fileUpload;

            dr = Complaint_DLL.GetAttachment(comp_id);

            if (dr.Read())
            {
                fileUpload = (byte[])dr.GetValue(0);

                if (sfdComplaints.ShowDialog() == DialogResult.OK)
                {
                    sfdComplaints.Title = "Save PDF Files";
                    // write bytes to disk as file
                    
                    ComplaintModel.viewFile = sfdComplaints.FileName;

                    using (FileStream fs = new FileStream(sfdComplaints.FileName, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite))
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
