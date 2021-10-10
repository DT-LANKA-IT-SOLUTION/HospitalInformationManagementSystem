using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalInformationManagementSystem.DAL;
using HospitalInformationManagementSystem.BLL;

namespace HospitalInformationManagementSystem.PL
{
    public partial class ucDashboard_PL : UserControl
    {
        Dashboard_BLL _dashboard_BLL = new Dashboard_BLL();
        public ucDashboard_PL()
        {
            InitializeComponent();
        }

        private void ucDashboard_PL_Load(object sender, EventArgs e)
        {
            this.LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                _dashboard_BLL.GetPatientCount(lblPatientCount);
                _dashboard_BLL.GetAppointmentCount(lblAppointmentCount);
                _dashboard_BLL.GetComplaintCount(lblComplaintCount);
                _dashboard_BLL.GetDoctorCount(lblDoctorCount);
                _dashboard_BLL.FillChart(CT_Dashboard);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
