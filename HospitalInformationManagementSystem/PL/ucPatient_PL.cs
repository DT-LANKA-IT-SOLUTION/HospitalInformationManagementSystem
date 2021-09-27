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
            _grantUserPermission.GrantButtonPermission("patient", btnAddPatient, btnEditPatient, btnDeletePatient);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    this.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int AddPatient()
        {
            try
            {
                if (IsValid("add"))
                {
                    patientModel.first_name = (string.IsNullOrEmpty(txtFirstName.Text)) ? "N/A" : txtFirstName.Text.Trim();
                    patientModel.last_name = (string.IsNullOrEmpty(txtLastName.Text)) ? "N/A" : txtLastName.Text.Trim();
                    patientModel.gender = (cmbGender.SelectedItem == null) ? "N/A" : cmbGender.SelectedItem.ToString();
                    patientModel.nic_no = (string.IsNullOrEmpty(txtNIC.Text)) ? "N/A" : txtNIC.Text.Trim();
                    patientModel.phone_no = (string.IsNullOrEmpty(txtPhone.Text)) ? 00000000 : Int32.Parse(txtPhone.Text.Trim());
                    patientModel.marital_status = (cmbMaritalStatus.SelectedItem == null) ? "N/A" : cmbMaritalStatus.SelectedItem.ToString();
                    patientModel.address = (string.IsNullOrEmpty(txtAddress.Text)) ? "N/A" : txtAddress.Text.Trim();
                    patientModel.dob = (string.IsNullOrEmpty(dtpBirthDay.Text)) ? DateTime.Now : Convert.ToDateTime(dtpBirthDay.Text.Trim());
                    patientModel.blood_group = (cmbBloadGroup.SelectedItem == null) ? "N/A" : cmbBloadGroup.SelectedItem.ToString();
                    patientModel.allergies = (string.IsNullOrEmpty(txtAllergies.Text)) ? "N/A" : txtAllergies.Text.Trim();

                    patientModel.user_name = (string.IsNullOrEmpty(txtUsername.Text)) ? txtFirstName.Text.Trim() + txtLastName.Text.Trim() : txtUsername.Text.Trim();
                    patientModel.password = EncryptionLab.EncryptText((string.IsNullOrEmpty(txtPassword.Text)) ? txtNIC.Text.Trim() : txtPassword.Text.Trim());
                    patientModel.user_type = "patient";
                    patientModel.IsActive = true;

                    return _patient_BLL.AddPatient(patientModel);
                }
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtNIC.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            dtpBirthDay.Text = "";
            txtAllergies.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbBloadGroup.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            cmbMaritalStatus.SelectedIndex = -1;
        }

        private bool IsValid(string type)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                epPatient.SetError(txtFirstName, "Please Fill First Name");
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                epPatient.SetError(txtLastName, "Please Fill Last Name");
                txtLastName.Focus();
                return false;
            }

            if (cmbGender.SelectedItem == null)
            {
                epPatient.SetError(cmbGender, "Please Fill Gender");
                cmbGender.Focus();
                return false;
            }

            if (cmbMaritalStatus.SelectedItem == null)
            {
                epPatient.SetError(cmbMaritalStatus, "Please Fill Marital Status");
                cmbMaritalStatus.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                epPatient.SetError(txtAddress, "Please Fill Address");
                txtAddress.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(dtpBirthDay.Text))
            {
                epPatient.SetError(dtpBirthDay, "Please Fill Birth Day");
                dtpBirthDay.Focus();
                return false;
            }

            if (cmbBloadGroup.SelectedItem == null)
            {
                epPatient.SetError(cmbBloadGroup, "Please Fill Bload Group");
                cmbBloadGroup.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtAllergies.Text))
            {
                epPatient.SetError(txtAllergies, "Please Fill Allergies");
                txtAllergies.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                epPatient.SetError(txtUsername, "Please Fill Username");
                txtUsername.Focus();
                return false;
            }
            else
            {
                if (type == "add")
                {
                    if (string.IsNullOrEmpty(_patient_BLL.CheckPatientByUsername(patientModel)))
                    {
                        epPatient.Clear();
                    }
                    else
                    {
                        epPatient.SetError(txtUsername, "This username is already use");
                        txtUsername.Focus();
                        return false;
                    }
                }
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                epPatient.SetError(txtPassword, "Please Fill Password");
                txtPassword.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNIC.Text))
            {
                epPatient.SetError(txtNIC, "Please Fill NIC");
                txtNIC.Focus();
                return false;
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
                    epPatient.SetError(txtNIC, "This NIC number is invalid...!");
                    txtNIC.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                epPatient.SetError(txtPhone, "Please Fill Phone");
                txtPhone.Focus();
                return false;
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
                    epPatient.SetError(txtPhone, "This Phone Number is invalid...!");
                    txtPhone.Focus();
                    return false;
                }
            }

            epPatient.Clear();
            return true;
        }

        private void DgvPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPatient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvPatient.CurrentRow.Selected = true;

                txtFirstName.Text = dgvPatient.Rows[e.RowIndex].Cells["f_name"].FormattedValue.ToString();
                txtLastName.Text = dgvPatient.Rows[e.RowIndex].Cells["l_name"].FormattedValue.ToString();
                txtNIC.Text = dgvPatient.Rows[e.RowIndex].Cells["nic_no"].FormattedValue.ToString();
                txtPhone.Text = dgvPatient.Rows[e.RowIndex].Cells["phone_no"].FormattedValue.ToString();
                txtAddress.Text = dgvPatient.Rows[e.RowIndex].Cells["address"].FormattedValue.ToString();
                dtpBirthDay.Text = dgvPatient.Rows[e.RowIndex].Cells["dob"].FormattedValue.ToString();
                txtAllergies.Text = dgvPatient.Rows[e.RowIndex].Cells["allergies"].FormattedValue.ToString();
                txtUsername.Text = dgvPatient.Rows[e.RowIndex].Cells["Username"].FormattedValue.ToString();
                txtPassword.Text = EncryptionLab.DecryptText(dgvPatient.Rows[e.RowIndex].Cells["password"].FormattedValue.ToString());

                cmbBloadGroup.Text = dgvPatient.Rows[e.RowIndex].Cells["blood_group"].FormattedValue.ToString();
                cmbMaritalStatus.Text = dgvPatient.Rows[e.RowIndex].Cells["marital_status"].FormattedValue.ToString();
                cmbGender.Text = dgvPatient.Rows[e.RowIndex].Cells["gender"].FormattedValue.ToString();

                txtUserID.Text = dgvPatient.Rows[e.RowIndex].Cells["user_id"].FormattedValue.ToString();

                //btnAddPatient.Enabled = false;
            }
        }

        private void BtnEditPatient_Click(object sender, EventArgs e)
        {
            try
            {
                if (UpdatePatient() > 0)
                {
                    MessageBox.Show("Patient update sucessfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.FilDGVPatient();
                    this.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int UpdatePatient()
        {
            try
            {
                if (IsValid("update"))
                {
                    patientModel.first_name = (string.IsNullOrEmpty(txtFirstName.Text)) ? "N/A" : txtFirstName.Text.Trim();
                    patientModel.last_name = (string.IsNullOrEmpty(txtLastName.Text)) ? "N/A" : txtLastName.Text.Trim();
                    patientModel.gender = (cmbGender.SelectedItem == null) ? "N/A" : cmbGender.SelectedItem.ToString();
                    patientModel.nic_no = (string.IsNullOrEmpty(txtNIC.Text)) ? "N/A" : txtNIC.Text.Trim();
                    patientModel.phone_no = (string.IsNullOrEmpty(txtPhone.Text)) ? 00000000 : Int32.Parse(txtPhone.Text.Trim());
                    patientModel.marital_status = (cmbMaritalStatus.SelectedItem == null) ? "N/A" : cmbMaritalStatus.SelectedItem.ToString();
                    patientModel.address = (string.IsNullOrEmpty(txtAddress.Text)) ? "N/A" : txtAddress.Text.Trim();
                    patientModel.dob = (string.IsNullOrEmpty(dtpBirthDay.Text)) ? DateTime.Now : Convert.ToDateTime(dtpBirthDay.Text.Trim());
                    patientModel.blood_group = (cmbBloadGroup.SelectedItem == null) ? "N/A" : cmbBloadGroup.SelectedItem.ToString();
                    patientModel.allergies = (string.IsNullOrEmpty(txtAllergies.Text)) ? "N/A" : txtAllergies.Text.Trim();

                    patientModel.user_name = (string.IsNullOrEmpty(txtUsername.Text)) ? txtFirstName.Text.Trim() + txtLastName.Text.Trim() : txtUsername.Text.Trim();
                    patientModel.password = EncryptionLab.EncryptText((string.IsNullOrEmpty(txtPassword.Text)) ? txtNIC.Text.Trim() : txtPassword.Text.Trim());
                    patientModel.user_type = "patient";
                    patientModel.IsActive = true;
                    patientModel.user_id = Int32.Parse(txtUserID.Text.Trim());

                    return _patient_BLL.UpdatePatient(patientModel);
                }
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_patient_BLL.CheckPatientByUsername(patientModel)))
                {
                    epPatient.Clear();
                }
                else
                {
                    epPatient.SetError(txtUsername, "This username is already use");
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                this.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void BtnDeletePatient_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeletePatient() > 0)
                {
                    MessageBox.Show("Patient delete sucessfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.FilDGVPatient();
                    this.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int DeletePatient()
        {
            try
            {
                return _patient_BLL.DeletePatient(false, Int32.Parse(txtUserID.Text.Trim()));
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchByNIC.Text))
            {
                epPatient.SetError(txtSearchByNIC, "Please Fill NIC");
                txtSearchByNIC.Focus();
            }
            else
            {
                epPatient.Clear();
                this.FilDGVSearchPatient(txtSearchByNIC.Text.Trim());
            }
        }

        private void FilDGVSearchPatient(string nic)
        {
            try
            {
                _patient_BLL.LoadPatientByNICGridView(dgvPatient,nic);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSearchByNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchByNIC.Text))
            {
                epPatient.SetError(txtSearchByNIC, "Please Fill NIC");
                txtSearchByNIC.Focus();
            }
            else
            {
                epPatient.Clear();
                this.FilDGVSearchPatient(txtSearchByNIC.Text.Trim());
            }
        }
    }
}
