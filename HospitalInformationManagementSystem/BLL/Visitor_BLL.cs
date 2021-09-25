using HospitalInformationManagementSystem.DAL;
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

        
    }
}
