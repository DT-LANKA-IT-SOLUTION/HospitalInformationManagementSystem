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
    class Postal_BLL
    {
        public void LoadAllPostalGridView(DataGridView dgvPostal)
        {
            try
            {
                dgvPostal.AutoGenerateColumns = false;
                dgvPostal.DataSource = Postal_DLL.GetAllPostal();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void LoadPostalByRefNoGridView(DataGridView dgvPostal, string refno)
        {
            try
            {
                dgvPostal.AutoGenerateColumns = false;
                dgvPostal.DataSource = Postal_DLL.GetPostalByRefNo(refno);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AddPostal(PostalModel postaltModel)
        {
            try
            {
                return Postal_DLL.AddPostal(postaltModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int UpdatePostal(PostalModel postalModel)
        {
            try
            {
                return Postal_DLL.UpdatePostal(postalModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int DeletePostal(int PostalID)
        {
            try
            {
                return Postal_DLL.DeletePostal(PostalID);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
