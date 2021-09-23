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
using System.Text.RegularExpressions;

namespace HospitalInformationManagementSystem.PL
{
    public partial class ucPatient_PL : UserControl
    {
        GrantUserPermission _grantUserPermission = new GrantUserPermission();

        Patient_BLL _patient_BLL = new Patient_BLL();

        PatientModel patientModel = new PatientModel();

        public ucPatient_PL()
        {
            InitializeComponent();
            _grantUserPermission.GrantButtonPermission("patient",btnAddPatient,btnEditPatient,btnDeletePatient);
        }

        private void UcPatient_PL_Load(object sender, EventArgs e)
        {
            this.FilDGVPatient();
            epPatient.Clear();
        }

        private void FilDGVPatient()
        {
            try
            {
                _patient_BLL.LoadAllPatientGridView(dgvPatient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void BtnAddPatient_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddPatient() > 0)
                {
                    MessageBox.Show("Patient add sucessfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.FilDGVPatient();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public int AddPatient()
        {
            try
            {
                patientModel.first_name = txtFirstName.Text.Trim();
                patientModel.last_name = txtLastName.Text.Trim();
                patientModel.gender = cmbGender.SelectedItem.ToString();
                patientModel.nic_no = txtNIC.Text.Trim();
                patientModel.phone_no = Int32.Parse(txtPhone.Text.Trim());
                patientModel.marital_status = cmbMaritalStatus.SelectedItem.ToString();
                patientModel.address = txtAddress.Text.Trim();
                patientModel.dob = Convert.ToDateTime(dtpBirthDay.Text.Trim());
                patientModel.blood_group = cmbBloadGroup.SelectedItem.ToString();
                patientModel.allergies = txtAllergies.Text.Trim();

                patientModel.user_name = txtFirstName.Text.Trim() + txtLastName.Text.Trim();
                patientModel.password = EncryptionLab.EncryptText(txtNIC.Text.Trim());
                patientModel.user_type = "Patient";
                patientModel.IsActive = true;

                return _patient_BLL.AddPatient(patientModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void TxtNIC_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNIC.Text))
            {
                epPatient.SetError(txtNIC, "Please Enter NIC...!");
                txtNIC.Focus();
            }
            else
            {
                Regex reg = new Regex(@"^([0-9]{9}[x|X|v|V]|[0-9]{12})$");

                bool result = reg.IsMatch(txtNIC.Text.Trim());

                if (result)
                {
                    epPatient.Clear();
                }
                else
                {
                    epPatient.SetError(txtNIC, "This NIC number is inalid...!");
                    txtNIC.Focus();
                }
            }
            
        }

        private void CmbGender_Validating(object sender, CancelEventArgs e)
        {
            if (cmbGender.SelectedItem == null)
            {
                epPatient.SetError(cmbGender, "Please Select Item ...!");
                cmbGender.Focus();
            }
            else
            {
                epPatient.Clear();
            }
        }

        private void TxtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                epPatient.SetError(txtPhone, "Please Endter NIC...!");
                txtPhone.Focus();
            }
            else
            {
                Regex reg = new Regex(@"^(?:7|0|(?:\+94))[0-9]{9,10}$");

                bool result = reg.IsMatch(txtPhone.Text.Trim());

                if (result)
                {
                    epPatient.Clear();
                }
                else
                {
                    epPatient.SetError(txtPhone, "This NIC number is inalid...!");
                    txtPhone.Focus();
                }
            }
        }

        private void CmbMaritalStatus_Validating(object sender, CancelEventArgs e)
        {
            if (cmbMaritalStatus.SelectedItem == null)
            {
                epPatient.SetError(cmbGender, "Please Select Item ...!");
                cmbMaritalStatus.Focus();
            }
            else
            {
                epPatient.Clear();
            }
        }

        private void CmbBloadGroup_Validating(object sender, CancelEventArgs e)
        {
            if (cmbBloadGroup.SelectedItem == null)
            {
                epPatient.SetError(cmbGender, "Please Select Item ...!");
                cmbBloadGroup.Focus();
            }
            else
            {
                epPatient.Clear();
            }
        }
    }
}
