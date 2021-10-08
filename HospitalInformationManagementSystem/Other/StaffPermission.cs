using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalInformationManagementSystem.Other
{
    class StaffPermission
    {
        public void SetChechBoxData(string status, CheckBox cbAccess, CheckBox cbCreate, CheckBox cbDlelete, CheckBox cbModify)
        {
            if (status == "DENIED")
            {
                cbAccess.Checked = false;
                cbCreate.Checked = false;
                cbDlelete.Checked = false;
                cbModify.Checked = false;
            }
            else
            {
                Regex regex = new Regex(status);

                Match match = regex.Match(status);

                if (match.Success)
                {
                    foreach (char ch in match.Value)
                    {
                        if (ch == 'A')
                        {
                            cbAccess.Checked = true;
                        }
                        else if (ch == 'C')
                        {
                            cbCreate.Checked = true;
                        }
                        else if (ch == 'D')
                        {
                            cbDlelete.Checked = true;
                        }
                        else if (ch == 'M')
                        {
                            cbModify.Checked = true;
                        }
                    }
                }
            }
        }
    }
}
