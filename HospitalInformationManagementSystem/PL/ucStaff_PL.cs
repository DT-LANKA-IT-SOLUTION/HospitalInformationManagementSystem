using HospitalInformationManagementSystem.BLL;
using HospitalInformationManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalInformationManagementSystem.PL
{
    public partial class ucStaff_PL : UserControl
    {
        Staff_BLL _staff_BLL = new Staff_BLL();

        StaffModel _staff_Model = new StaffModel();
        public ucStaff_PL()
        {
            InitializeComponent();
        }

        private void ucStaff_PL_Load(object sender, EventArgs e)
        {
            this.filDGVStaff();
        }

        private void filDGVStaff()
        {
            try
            {
                _staff_BLL.LoadAllStaffGridView(dgvStaff);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
