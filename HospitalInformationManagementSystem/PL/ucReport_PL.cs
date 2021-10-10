using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalInformationManagementSystem.BLL;
using HospitalInformationManagementSystem.Model;
using CrystalDecisions.Windows.Forms;
using HospitalInformationManagementSystem.Other;

namespace HospitalInformationManagementSystem.PL
{
    public partial class ucReport_PL : UserControl
    {
        Report_BLL report_BLL = new Report_BLL();
        ReportModel reportModel = new ReportModel();

        public Dashboard_PL dashboard_PL { get; set; }

        public ucReport_PL()
        {
            InitializeComponent();
        }

        private void BtnAppointmentReport_Click(object sender, EventArgs e)
        {
            try
            {
                GetAppointment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetAppointment()
        {
            try
            {
                reportModel.AppointmentFormDate = Convert.ToDateTime(dtpAppointmentFrom.Text.Trim());
                reportModel.AppointmentToDate = Convert.ToDateTime(dtpAppointmentTo.Text.Trim());
                
                report_BLL.GetAppointmentReport(reportModel, rptReportViewer);

                
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
