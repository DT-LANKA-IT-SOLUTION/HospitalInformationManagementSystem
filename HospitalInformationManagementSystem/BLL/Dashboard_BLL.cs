using HospitalInformationManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HospitalInformationManagementSystem.BLL
{
    class Dashboard_BLL
    {
        public void GetPatientCount(Label lable)
        {
            DataTable PTable = Dashboard_DLL.GetPatientCount();
            lable.Text = PTable.Rows[0]["PCount"].ToString();
        }

        public void GetAppointmentCount(Label lable)
        {
            DataTable ATable = Dashboard_DLL.GetAppointmentCount();
            lable.Text = ATable.Rows[0]["ACount"].ToString();
        }

        public void GetComplaintCount(Label lable)
        {
            DataTable CTable = Dashboard_DLL.GetComplaintCount();
            lable.Text = CTable.Rows[0]["CCount"].ToString();
        }

        public void GetDoctorCount(Label lable)
        {
            DataTable CTable = Dashboard_DLL.GetDoctorCount();
            lable.Text = CTable.Rows[0]["DCount"].ToString();
        }

        public void FillChart(Chart chart)
        {
            DataTable dTable = Dashboard_DLL.FillChart();
            chart.DataSource = dTable;
            chart.Series["Appointment"].XValueMember = "AppDate";
            chart.Series["Appointment"].YValueMembers = "  Appcount";
            chart.Titles.Add("Appointment Chart").ForeColor = Color.BlueViolet;
        }
    }
}
