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
    class Appointment_BLL
    {
        public void LoadAllAppointmentGridView(DataGridView dgvAppointment)
        {
            try
            {
                dgvAppointment.AutoGenerateColumns = false;
                dgvAppointment.DataSource = Appointment_DLL.GetAllAppointment();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void GetAppointmentByAppointmentNo(DataGridView dgvAppointment, string appno)
        {
            try
            {
                dgvAppointment.AutoGenerateColumns = false;
                dgvAppointment.DataSource = Appointment_DLL.GetAppointmentByAppointmentNo(appno);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AddAppointment(AppointmentModel appointmentModel)
        {
            try
            {
                return Appointment_DLL.AddAppointment(appointmentModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int UpdateAppointment(AppointmentModel appointmentModel)
        {
            try
            {
                return Appointment_DLL.UpdateAppointment(appointmentModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int DeleteAppointment(int AppointmentID)
        {
            try
            {
                return Appointment_DLL.DeleteAppointment(AppointmentID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void LoadAllDoctors(ComboBox comboBox)
        {
            try
            {
                comboBox.DataSource = Appointment_DLL.GetDoctors();
                comboBox.DisplayMember = "f_name";
                comboBox.ValueMember = "user_id";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
