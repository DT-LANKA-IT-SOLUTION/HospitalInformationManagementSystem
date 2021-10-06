using HospitalInformationManagementSystem.DAL;
using HospitalInformationManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalInformationManagementSystem.BLL
{
    class Complaint_BLL
    {
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
                return Complaint_DLL.DeleteComplaints(Active,comp_id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
