using HospitalInformationManagementSystem.BLL;
using HospitalInformationManagementSystem.Model;
using HospitalInformationManagementSystem.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalInformationManagementSystem.PL
{
    public partial class ucStaff_PL : UserControl
    {
        GrantUserPermission _grantUserPermission = new GrantUserPermission();

        Staff_BLL _staff_BLL = new Staff_BLL();

        StaffModel staffModel = new StaffModel();

        public ucStaff_PL()
        {
            InitializeComponent();
        }

        private void ucStaff_PL_Load(object sender, EventArgs e)
        {
            this.filDGVStaff();
        }

        private void filDGVStaff()
        {
            try
            {
                _staff_BLL.LoadAllStaffGridView(dgvStaff);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if(AddStaff() > 0)
                {
                    MessageBox.Show("Staff add sucessfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.filDGVStaff();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
        public int AddStaff()
        {
            try
            {
                staffModel.first_name = txtFirstName.Text.Trim();
                staffModel.last_name = txtLastName.Text.Trim();
                staffModel.gender = cmbGender.SelectedItem.ToString();
                staffModel.phone_no = Int32.Parse(txtPhone.Text.Trim());
                staffModel.nic = txtNIC.Text.Trim();
                staffModel.marital_status = cmbStatus.SelectedItem.ToString();
                staffModel.birth_date = Convert.ToDateTime(dtpBirthDay.Text.Trim());
                staffModel.address = txtAddress.Text.Trim();
                staffModel.staff_id = txtStaffID.Text.Trim();
                staffModel.staff_email = txtStaffEmail.Text.Trim();
                staffModel.joined_date = Convert.ToDateTime(dtpJoinedDate.Text.Trim());

                staffModel.user_name = txtFirstName.Text.Trim() + txtLastName.Text.Trim();
                staffModel.password = EncryptionLab.EncryptText(txtNIC.Text.Trim());
                staffModel.user_type = "Staff";
                staffModel.IsActive = true;

                return _staff_BLL.AddStaff(staffModel);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
