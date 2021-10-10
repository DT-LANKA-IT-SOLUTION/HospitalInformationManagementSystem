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
using HospitalInformationManagementSystem.BLL;
using HospitalInformationManagementSystem.Model;
using System.IO;

namespace HospitalInformationManagementSystem.PL
{
    public partial class ucAppointment_PL : UserControl
    {
        GrantUserPermission _grantUserPermission = new GrantUserPermission();

        Appointment_BLL _appointment_BLL = new Appointment_BLL();

        AppointmentModel appointmentModel = new AppointmentModel();

        public ucAppointment_PL()
        {
            InitializeComponent();
        }

        private void UcAppointent_PL_Load(object sender, EventArgs e)
        {
            this.FilDGVAppointment();
            //epAppointment.Clear();
        }

        private void FilDGVAppointment()
        {
            try
            {
                _appointment_BLL.LoadAllAppointmentGridView(dgvAppointment);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      

        private void btn_add_appointment_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddAppointment() > 0)
                {
                    MessageBox.Show("Appointment add sucessfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.FilDGVAppointment();
                    this.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int AddAppointment()
        {
            try
            {

                //asign values 
                appointmentModel.appointment_no = Convert.ToInt32(txt_appointment_no.Text.Trim());
                appointmentModel.app_date = Convert.ToDateTime(dateTimePicker_date.Text.Trim());
                appointmentModel.app_time = Convert.ToDateTime(dateTimePicker_time.Text.Trim());
                //appointmentModel.app_time = Convert.ToDateTime(dateTimePicker_date.Text.Trim());
                appointmentModel.patient = txt_patient_name.Text.Trim();
                appointmentModel.symptoms = txt_symptoms.Text.Trim();
                appointmentModel.medical_officer = Int32.Parse(cmb_medical_officer.SelectedValue.ToString());
                appointmentModel.status = comboBox_status.Text.Trim();
                appointmentModel.user_id = 1;

                return _appointment_BLL.AddAppointment(appointmentModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //clear form
        public void Clear()
        {
            txt_appointment_no.Text = "";
            dateTimePicker_date.Text = "";
            dateTimePicker_time.Text = "";
            txt_patient_name.Text = "";
            txt_symptoms.Text = "";
            txt_medical_officer.Text = "";
            comboBox_status.SelectedIndex = -1;
      
            
        }

        private void btn_edit_appointment_Click(object sender, EventArgs e)
        {
            try
            {
                if (UpdateAppointment() > 0)
                {
                    MessageBox.Show("Postal update sucessfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.FilDGVAppointment();
                    this.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int UpdateAppointment()
        {
            try
            {
                appointmentModel.app_id = Int32.Parse(txt_app_id.Text.Trim());
                //appointmentModel.app_id = 1009;
                appointmentModel.appointment_no = Convert.ToInt32(txt_appointment_no.Text.Trim());
                appointmentModel.patient = (string.IsNullOrEmpty(txt_patient_name.Text)) ? "N/A" : txt_patient_name.Text.Trim();
                appointmentModel.symptoms = (string.IsNullOrEmpty(txt_symptoms.Text)) ? "N/A" : txt_symptoms.Text.Trim();
                appointmentModel.medical_officer = (string.IsNullOrEmpty(cmb_medical_officer.Text)) ? 00000 : Int32.Parse(cmb_medical_officer.SelectedValue.ToString());
                appointmentModel.app_date = (string.IsNullOrEmpty(dateTimePicker_date.Text)) ? DateTime.Now : Convert.ToDateTime(dateTimePicker_date.Text.Trim());
                appointmentModel.app_time = (string.IsNullOrEmpty(dateTimePicker_time.Text)) ? DateTime.Now : Convert.ToDateTime(dateTimePicker_time.Text.Trim());
                appointmentModel.status = (comboBox_status.SelectedItem == null) ? "N/A" : comboBox_status.SelectedItem.ToString();
                
                appointmentModel.user_id = 1;

                return _appointment_BLL.UpdateAppointment(appointmentModel);

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_delete_appointment_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeleteAppointment() > 0)
                {
                    MessageBox.Show("Appointment delete sucessfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.FilDGVAppointment();
                    this.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int DeleteAppointment()
        {
            try
            {
                //int appno = 1009;
                int appno = Int32.Parse(txt_app_id.Text.Trim());
                return _appointment_BLL.DeleteAppointment(appno);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchByAppNo.Text))
            {
                epAppointment.SetError(txtSearchByAppNo, "Please enter Ref No");
                txtSearchByAppNo.Focus();
            }
            else
            {
                epAppointment.Clear();
                this.FilDGVSearchAppointments(txtSearchByAppNo.Text.Trim());
            }
        }

        private void FilDGVSearchAppointments(string appno)
        {
            try
            {
                _appointment_BLL.GetAppointmentByAppointmentNo(dgvAppointment, appno);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucAppointment_PL_Load(object sender, EventArgs e)
        {
            FilDGVAppointment();
            LoadComboboxDoctor();
        }

        private void LoadComboboxDoctor()
        {
            try
            {
                _appointment_BLL.LoadAllDoctors(cmb_medical_officer);
                cmb_medical_officer.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvAppointment.CurrentRow.Selected = true;

                txt_app_id.Text = dgvAppointment.Rows[e.RowIndex].Cells["app_id"].FormattedValue.ToString();
                txt_appointment_no.Text = dgvAppointment.Rows[e.RowIndex].Cells["appointment_no"].FormattedValue.ToString();
                dateTimePicker_date.Text = dgvAppointment.Rows[e.RowIndex].Cells["app_date"].FormattedValue.ToString();
                dateTimePicker_time.Text = dgvAppointment.Rows[e.RowIndex].Cells["app_time"].FormattedValue.ToString();
                txt_patient_name.Text = dgvAppointment.Rows[e.RowIndex].Cells["patient"].FormattedValue.ToString();
                txt_symptoms.Text = dgvAppointment.Rows[e.RowIndex].Cells["symptoms"].FormattedValue.ToString();
                cmb_medical_officer.SelectedValue = Int32.Parse(dgvAppointment.Rows[e.RowIndex].Cells["medical_officer"].FormattedValue.ToString());
                comboBox_status.Text = dgvAppointment.Rows[e.RowIndex].Cells["status"].FormattedValue.ToString();

                //txtPassword.Text = EncryptionLab.DecryptText(dgvPatient.Rows[e.RowIndex].Cells["password"].FormattedValue.ToString());
                //btn_add_appointment.Enabled = false;
            }
        }

        private void Cmb_medical_officer_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                cmb_medical_officer.DroppedDown = true;
                if (char.IsControl(e.KeyChar))
                {
                    return;
                }
                string str = cmb_medical_officer.Text.Substring(0, cmb_medical_officer.SelectionStart) + e.KeyChar;
                Int32 index = cmb_medical_officer.FindStringExact(str);
                if (index == -1)
                {
                    index = cmb_medical_officer.FindString(str);
                }
                this.cmb_medical_officer.SelectedIndex = index;
                this.cmb_medical_officer.SelectionStart = str.Length;
                this.cmb_medical_officer.SelectionLength = this.cmb_medical_officer.Text.Length - this.cmb_medical_officer.SelectionStart;
                e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
