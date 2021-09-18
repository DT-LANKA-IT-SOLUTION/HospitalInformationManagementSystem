using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalInformationManagementSystem.Other;

namespace HospitalInformationManagementSystem.PL
{
    public partial class ucPatient_PL : UserControl
    {
        GrantUserPermission _grantUserPermission = new GrantUserPermission();
        public ucPatient_PL()
        {
            InitializeComponent();
            _grantUserPermission.GrantButtonPermission("patient",btnAddPatient,btnEditPatient,btnDeletePatient);
        }
    }
}
