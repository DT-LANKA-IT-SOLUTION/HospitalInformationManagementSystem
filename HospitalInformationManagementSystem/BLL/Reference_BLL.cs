using HospitalInformationManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalInformationManagementSystem.BLL
{
    class Reference_BLL
    {
        public void GetComplaintTypes(ComboBox cmbComplaintTypes)
        {
            cmbComplaintTypes.DataSource = Reference_DLL.GetComplaintTypes();
            cmbComplaintTypes.DisplayMember = "text_value";
            cmbComplaintTypes.ValueMember = "text_value";
        }
    }
}
