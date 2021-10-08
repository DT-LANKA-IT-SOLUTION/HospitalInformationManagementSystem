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

namespace HospitalInformationManagementSystem.PL
{
    public partial class ucDashboard_PL : UserControl
    {
        public ucDashboard_PL()
        {
            InitializeComponent();
        }

        private void ucDashboard_PL_Load(object sender, EventArgs e)
        {
            Dashboard_DLL dashboard = new Dashboard_DLL();
            DataTable PTable = dashboard.GetPatientCount();
            lblPatientCount.Text = PTable.Rows[0]["PCount"].ToString();

            DataTable ATable = dashboard.GetAppointmentCount();
            lblAppointmentCount.Text = ATable.Rows[0]["ACount"].ToString();

            DataTable CTable = dashboard.GetComplaintCount();
            lblComplaintCount.Text = CTable.Rows[0]["CCount"].ToString();



            DataTable dTable = dashboard.FillChart();
            CT_Dashboard.DataSource = dTable;
            CT_Dashboard.Series["Appointment"].XValueMember = "AppDate";
            CT_Dashboard.Series["Appointment"].YValueMembers = "  Appcount";
            CT_Dashboard.Titles.Add("Appointment Chart").ForeColor = Color.BlueViolet;
        }
    }
}
