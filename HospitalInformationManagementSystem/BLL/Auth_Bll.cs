using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalInformationManagementSystem.DAL;
using HospitalInformationManagementSystem.Model;

namespace HospitalInformationManagementSystem.BLL
{
    class Auth_BLL
    {
        public void getUserAuthentication(AuthModel authModel)
        {
            try
            {
                Auth_DLL.getUsername(authModel);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
