using CrystalDecisions.CrystalReports.Engine;
using HospitalInformationManagementSystem.DAL;
using HospitalInformationManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.Windows.Forms;
using HospitalInformationManagementSystem.PL;

namespace HospitalInformationManagementSystem.BLL
{
    class Report_BLL
    {
        ReportDocument rd = new ReportDocument();
        Report_DLL report_DLL = new Report_DLL();

        public void GetAppointmentReport(ReportModel reportModel,CrystalReportViewer crystalReportViewer)
        {
            try
            {
                rptAppointment rptAppointment = new rptAppointment();
                rptAppointment.Load(@"D:\uovt\C# 2\Project\HospitalInformationManagementSystem\PL\rptAppointment.rpt");
                rptAppointment.SetDataSource(report_DLL.GetAppointmentReport(reportModel));

                crystalReportViewer.ReportSource = rptAppointment;
                crystalReportViewer.Refresh();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void GetUserReport(ReportModel reportModel)
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
        }
        public void GetPatientReport(ReportModel reportModel)
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
