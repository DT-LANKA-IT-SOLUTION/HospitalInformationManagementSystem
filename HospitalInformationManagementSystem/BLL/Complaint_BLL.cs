using HospitalInformationManagementSystem.DAL;
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
    }
}
