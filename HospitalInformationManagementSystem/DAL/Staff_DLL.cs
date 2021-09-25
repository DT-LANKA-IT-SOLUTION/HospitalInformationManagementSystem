using HospitalInformationManagementSystem.Other;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformationManagementSystem.DAL
{
    class Staff_DLL
    {
        public static DataTable GetAllStaff()
        {
            try
            {
                return ODBC.GetData("SELECT * FROM Staff_Members,Users WHERE Staff_Members.user_id = Users.user_id");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
