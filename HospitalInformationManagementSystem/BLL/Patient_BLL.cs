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

        public void LoadPatientByNICGridView(DataGridView dgvPatient,string nic)
        {
            try
            {
                dgvPatient.AutoGenerateColumns = false;
                dgvPatient.DataSource = Patient_DLL.GetPatientByNIC(nic);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string CheckPatientByUsername(PatientModel patientModel)
        {
            try
            {
               
                return Patient_DLL.GetPatientByUsername(patientModel);
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

        public int DeletePatient(bool Active, int user_id)
        {
            try
            {
                return Patient_DLL.DeletePatient(Active, user_id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
