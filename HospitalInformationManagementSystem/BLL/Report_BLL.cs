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
                

                ReportDocument Report = new ReportDocument();
                Report.Load(@"D:\uovt\C# 2\Project\HospitalInformationManagementSystem\PL\rptAppointment.rpt");
                //Report.SetDatabaseLogon("sa", "sa123", "Rakesh-PC", "RakeshData");
                Report.SetDataSource(report_DLL.GetAppointmentReport(reportModel));
                crystalReportViewer.ReportSource = Report;
                crystalReportViewer.Refresh();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void GetUserReport(ReportModel reportModel, CrystalReportViewer crystalReportViewer)
        {
            try
            {
                ReportDocument Report = new ReportDocument();
                Report.Load(@"PL\rptAppointment.rpt");
                //Report.SetDatabaseLogon("sa", "sa123", "Rakesh-PC", "RakeshData");
                Report.SetDataSource(report_DLL.GetUserReport(reportModel));
                crystalReportViewer.ReportSource = Report;
                crystalReportViewer.Refresh();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void GetPatientReport(ReportModel reportModel, CrystalReportViewer crystalReportViewer)
        {
            try
            {
                ReportDocument Report = new ReportDocument();
                Report.Load(@"D:\uovt\C# 2\Project\HospitalInformationManagementSystem\PL\rptPatient.rpt");
                //Report.SetDatabaseLogon("sa", "sa123", "Rakesh-PC", "RakeshData");
                Report.SetDataSource(report_DLL.GetPatientReport(reportModel));
                crystalReportViewer.ReportSource = Report;
                crystalReportViewer.Refresh();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
