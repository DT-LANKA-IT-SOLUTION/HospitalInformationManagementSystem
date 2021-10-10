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
                //bgWorkerReport.WorkerSupportsCancellation = true;

                //if (!bgWorkerReport.IsBusy)
                //    bgWorkerReport.RunWorkerAsync();
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

                if (cmbReportType.Text == "Appointment Report")
                {
                    report_BLL.GetAppointmentReport(reportModel, rptReportViewer);
                }
                else if (cmbReportType.Text == "User Log")
                {
                    report_BLL.GetUserReport(reportModel, rptReportViewer);
                }
                else
                {
                    report_BLL.GetPatientReport(reportModel, rptReportViewer);
                }
                
                

                
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void BgWorkerReport_DoWork(object sender, DoWorkEventArgs e)
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
    }
}
