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
    class Staff_BLL
    {
        public void LoadAllStaffGridView(DataGridView dgvStaff)
        {
            try
            {
                dgvStaff.AutoGenerateColumns = false;
                dgvStaff.DataSource = Staff_DLL.GetAllStaff();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int AddStaff(StaffModel staffModel)
        {

            try
            {
                return Staff_DLL.AddStaff(staffModel);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public int UpdateStaff(StaffModel staffModel)
        {
            try
            {
                return Staff_DLL.UpdateStaff(staffModel);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
