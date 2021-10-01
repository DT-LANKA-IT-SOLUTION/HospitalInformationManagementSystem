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

        public void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtNIC.Text = "";
            txtAddress.Text = "";
            txtStaffID.Text = "";
            txtStaffEmail.Text = "";

            dtpBirthDay.Text = "";
            dtpJoinedDate.Text = "";

            cmbGender.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
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

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStaff.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvStaff.CurrentRow.Selected = true;

                txtFirstName.Text = dgvStaff.Rows[e.RowIndex].Cells["f_name"].FormattedValue.ToString();
                txtLastName.Text = dgvStaff.Rows[e.RowIndex].Cells["l_name"].FormattedValue.ToString();
                txtNIC.Text = dgvStaff.Rows[e.RowIndex].Cells["nic_no"].FormattedValue.ToString();
                txtPhone.Text = dgvStaff.Rows[e.RowIndex].Cells["phone_no"].FormattedValue.ToString();
                txtAddress.Text = dgvStaff.Rows[e.RowIndex].Cells["address"].FormattedValue.ToString();
                dtpBirthDay.Text = dgvStaff.Rows[e.RowIndex].Cells["dob"].FormattedValue.ToString();
                txtStaffID.Text = dgvStaff.Rows[e.RowIndex].Cells["staff_id"].FormattedValue.ToString();
                txtStaffEmail.Text = dgvStaff.Rows[e.RowIndex].Cells["staff_email"].FormattedValue.ToString();
                dtpJoinedDate.Text = dgvStaff.Rows[e.RowIndex].Cells["join_date"].FormattedValue.ToString();

                cmbGender.Text = dgvStaff.Rows[e.RowIndex].Cells["gender"].FormattedValue.ToString();
                cmbStatus.Text = dgvStaff.Rows[e.RowIndex].Cells["marital_status"].FormattedValue.ToString();

                txtUserID.Text = dgvStaff.Rows[e.RowIndex].Cells["user_id"].FormattedValue.ToString();
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if(UpdateStaff() > 0)
                {
                    MessageBox.Show("Staff update sucessfull", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.filDGVStaff();
                    this.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int UpdateStaff()
        {
            try
            {
                staffModel.first_name = (string.IsNullOrEmpty(txtFirstName.Text)) ? "N/A" : txtFirstName.Text.Trim();
                staffModel.last_name = (string.IsNullOrEmpty(txtLastName.Text)) ? "N/A" : txtLastName.Text.Trim();
                staffModel.gender = (cmbGender.SelectedItem == null) ? "N/A" : cmbGender.SelectedItem.ToString();
                staffModel.phone_no = (string.IsNullOrEmpty(txtPhone.Text)) ? 00000000 : Int32.Parse(txtPhone.Text.Trim());
                staffModel.nic = (string.IsNullOrEmpty(txtNIC.Text)) ? "N/A" : txtNIC.Text.Trim();
                staffModel.birth_date = (string.IsNullOrEmpty(dtpBirthDay.Text)) ? DateTime.Now : Convert.ToDateTime(dtpBirthDay.Text.Trim());
                staffModel.address = (string.IsNullOrEmpty(txtAddress.Text)) ? "N/A" : txtAddress.Text.Trim();
                staffModel.marital_status = (cmbStatus.SelectedItem == null) ? "N/A" : cmbStatus.SelectedItem.ToString();
                staffModel.staff_id = (string.IsNullOrEmpty(txtStaffID.Text)) ? "N/A" : txtStaffID.Text.Trim();
                staffModel.staff_email = (string.IsNullOrEmpty(txtStaffEmail.Text)) ? "N/A" : txtStaffEmail.Text.Trim();
                staffModel.joined_date = (string.IsNullOrEmpty(dtpJoinedDate.Text)) ? DateTime.Now : Convert.ToDateTime(dtpJoinedDate.Text.Trim());

                staffModel.user_id = Int32.Parse(txtUserID.Text.Trim());

                return _staff_BLL.UpdateStaff(staffModel);             
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeleteStaff() > 0)
                {
                    MessageBox.Show("Staff delete sucessfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.filDGVStaff();
                    this.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        public int DeleteStaff()
        {
            try
            {
                return _staff_BLL.DeleteStaff(false, Int32.Parse(txtUserID.Text.Trim()));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
