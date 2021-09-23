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
    class Patient_BLL
    {

        public void LoadAllPatientGridView(DataGridView dgvPatient)
        {
            try
            {
                dgvPatient.AutoGenerateColumns = false;
                dgvPatient.DataSource = Patient_DLL.GetAllPatient();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AddPatient(PatientModel patientModel)
        {
            try
            {
                return Patient_DLL.AddPatient(patientModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int UpdatePatient(PatientModel patientModel)
        {
            try
            {
                return Patient_DLL.UpdatePatient(patientModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int DeletePatient(bool Active, int EmpID)
        {
            try
            {
                return Patient_DLL.DeletePatient(Active, EmpID);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
