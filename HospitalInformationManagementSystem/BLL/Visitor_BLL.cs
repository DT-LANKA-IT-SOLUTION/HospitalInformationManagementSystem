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
    class Visitor_BLL
    {
        public void LoadAllVisitorGridView(DataGridView dtgVisitor)
        {
            try
            {
                dtgVisitor.AutoGenerateColumns = false;
                dtgVisitor.DataSource = Visitor_DLL.GetAllVisitor();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AddVisitor(VisitorModel visitorModel)
        {
            try
            {
                return Visitor_DLL.AddVisitors(visitorModel);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int UpdateVisitor(VisitorModel visitorModel)
        {
            try
            {
                return Visitor_DLL.UpdateVisitors(visitorModel);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int DeleteVisitor(bool Active, int VisitorID)
        {
            try
            {
                return Visitor_DLL.DeleteVisitor(Active, VisitorID);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
