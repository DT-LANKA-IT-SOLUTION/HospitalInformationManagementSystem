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
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void GetAppointment()
        {
            try
            {
                //reportModel.AppointmentFormDate = Convert.ToDateTime(dtpAppointmentFrom.Text.Trim());
                //reportModel.AppointmentToDate = Convert.ToDateTime(dtpAppointmentTo.Text.Trim());
                //Dashboard_PL dashboard_PL = new Dashboard_PL();
                //var myForm = dashboard_PL.pnlContent.FindForm();
                ucReportViwer_PL ucReportViwer_PL = new ucReportViwer_PL();
                //Dashboard_PL dashboard_PL = new Dashboard_PL();

                //report_BLL.GetAppointmentReport(reportModel, ucReportViwer_PL.rptReportView);

                if (ParentForm == null)
                    return;

                Panel pnlContent = (this.Parent as Dashboard_PL).Controls["pnlContent"] as Panel;

                FormControl.showControls(ucReportViwer_PL, pnlContent);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
