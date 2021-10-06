using HospitalInformationManagementSystem.BLL;
using HospitalInformationManagementSystem.Model;
using HospitalInformationManagementSystem.Other;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HospitalInformationManagementSystem.PL
{
    public partial class ucStaff_PL : UserControl
    {
        string fileName = "";

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
            txtUserID.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtNIC.Text = "";
            txtAddress.Text = "";
            txtStaffID.Text = "";
            txtStaffEmail.Text = "";
            
            dtpBirthDay.Text = "";
            dtpJoinedDate.Text = "";

            cmbSpeciality.SelectedIndex = -1;
            cmbSpeciality.Items.Clear();
            cmbSpeciality.Text = "";
            cmbSpeciality.Enabled = false;
            lblSpeciality.Enabled = false;

            cmbUserType.SelectedIndex = -1;           
            cmbGender.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;

            picBoxUserImage.Image = null;
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if(AddStaff() > 0)
                {

                    MessageBox.Show("Staff add sucessfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.filDGVStaff();
                    this.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public int AddStaff()
        {
            try
            {
                staffModel.user_name = string.IsNullOrEmpty(txtUserName.Text) ? txtFirstName.Text.Trim() + txtLastName.Text.Trim() : txtUserName.Text.Trim();
                staffModel.password = EncryptionLab.EncryptText(string.IsNullOrEmpty(txtPassword.Text) ? txtNIC.Text.Trim() : txtPassword.Text.Trim());                
                                
                staffModel.first_name = string.IsNullOrEmpty(txtFirstName.Text) ? "N/A" : txtFirstName.Text.Trim();
                staffModel.last_name = string.IsNullOrEmpty(txtLastName.Text) ? "N/A" : txtLastName.Text.Trim();
                staffModel.gender = string.IsNullOrEmpty(cmbGender.Text) ? "N/A" : cmbGender.SelectedItem.ToString();
                staffModel.phone_no = string.IsNullOrEmpty(txtPhone.Text) ? 00000000 : Int32.Parse(txtPhone.Text.Trim());
                staffModel.nic_no = string.IsNullOrEmpty(txtNIC.Text) ? "N/A" : txtNIC.Text.Trim();
                staffModel.birth_date = string.IsNullOrEmpty(dtpBirthDay.Text) ? DateTime.Now : Convert.ToDateTime(dtpBirthDay.Text.Trim());
                staffModel.address = string.IsNullOrEmpty(txtAddress.Text) ? "N/A" : txtAddress.Text.Trim();
                staffModel.marital_status = string.IsNullOrEmpty(cmbStatus.Text) ? "N/A" : cmbStatus.SelectedItem.ToString();
                staffModel.user_type = string.IsNullOrEmpty(cmbUserType.Text) ? "User" : cmbUserType.SelectedItem.ToString();

                staffModel.IsActive = true;

                staffModel.staff_id = string.IsNullOrEmpty(txtStaffID.Text) ? "N/A" : txtStaffID.Text.Trim();
                staffModel.staff_email = string.IsNullOrEmpty(txtStaffEmail.Text) ? "N/A" : txtStaffEmail.Text.Trim();
                staffModel.join_date = string.IsNullOrEmpty(dtpJoinedDate.Text) ? DateTime.Now : Convert.ToDateTime(dtpJoinedDate.Text.Trim());
                staffModel.speciality_area = string.IsNullOrEmpty(cmbSpeciality.Text) ? "N/A" : cmbSpeciality.SelectedItem.ToString();
                staffModel.photo_data = string.IsNullOrEmpty(ImageToBase64(picBoxUserImage.Image, System.Drawing.Imaging.ImageFormat.Png)) ? "N/A" : ImageToBase64(picBoxUserImage.Image, System.Drawing.Imaging.ImageFormat.Png);

                //Dashboard Permissions (1)

                string PermisionsValue = "";

                if (chkboxA1.Checked)
                {
                    PermisionsValue += "A";
                }

                if (chkboxC1.Checked)
                {
                    PermisionsValue += "C";
                }

                if (chkboxD1.Checked)
                {
                    PermisionsValue += "D";
                }

                if (chkboxM1.Checked)
                {
                    PermisionsValue += "M";
                }

                if (string.IsNullOrEmpty(PermisionsValue)) 
                {
                    PermisionsValue = "DENIED";
                }
                staffModel.DashboardValue = PermisionsValue;
                PermisionsValue = "";

                //Patient Permissions (2)

                PermisionsValue = "";

                if (chkboxA2.Checked)
                {
                    PermisionsValue += "A";
                }

                if (chkboxC1.Checked)
                {
                    PermisionsValue += "C";
                }

                if (chkboxD1.Checked)
                {
                    PermisionsValue += "D";
                }

                if (chkboxM1.Checked)
                {
                    PermisionsValue += "M";
                }

                if (string.IsNullOrEmpty(PermisionsValue))
                {
                    PermisionsValue = "DENIED";
                }

                staffModel.PatientValue = PermisionsValue;
                PermisionsValue = "";

                //Visitor Permissions (3)

                if (chkboxA2.Checked)
                {
                    PermisionsValue += "A";
                }

                if (chkboxC2.Checked)
                {
                    PermisionsValue += "C";
                }

                if (chkboxD2.Checked)
                {
                    PermisionsValue += "D";
                }

                if (chkboxM2.Checked)
                {
                    PermisionsValue += "M";
                }
                if (string.IsNullOrEmpty(PermisionsValue))
                {
                    PermisionsValue = "DENIED";
                }
                staffModel.VistorsValue = PermisionsValue;
                PermisionsValue = "";

                //Appointment Permissions (4)

                if (chkboxA1.Checked)
                {
                    PermisionsValue += "A";
                }

                if (chkboxC1.Checked)
                {
                    PermisionsValue += "C";
                }

                if (chkboxD1.Checked)
                {
                    PermisionsValue += "D";
                }

                if (chkboxM1.Checked)
                {
                    PermisionsValue += "M";
                }
                if (string.IsNullOrEmpty(PermisionsValue))
                {
                    PermisionsValue = "DENIED";
                }
                staffModel.AppoinmentValue = PermisionsValue;
                PermisionsValue = "";

                //Postal Permissions (5)

                if (chkboxA1.Checked)
                {
                    PermisionsValue += "A";
                }

                if (chkboxC1.Checked)
                {
                    PermisionsValue += "C";
                }

                if (chkboxD1.Checked)
                {
                    PermisionsValue += "D";
                }

                if (chkboxM1.Checked)
                {
                    PermisionsValue += "M";
                }
                if (string.IsNullOrEmpty(PermisionsValue))
                {
                    PermisionsValue = "DENIED";
                }
                staffModel.PostalValue = PermisionsValue;
                PermisionsValue = "";

                //Complaints Permissions (6)

                if (chkboxA1.Checked)
                {
                    PermisionsValue += "A";
                }

                if (chkboxC1.Checked)
                {
                    PermisionsValue += "C";
                }

                if (chkboxD1.Checked)
                {
                    PermisionsValue += "D";
                }

                if (chkboxM1.Checked)
                {
                    PermisionsValue += "M";
                }
                if (string.IsNullOrEmpty(PermisionsValue))
                {
                    PermisionsValue = "DENIED";
                }
                staffModel.ComplaintsValue = PermisionsValue;
                PermisionsValue = "";

                //Reports Permissions (7)

                if (chkboxA1.Checked)
                {
                    PermisionsValue += "A";
                }

                if (chkboxC1.Checked)
                {
                    PermisionsValue += "C";
                }

                if (chkboxD1.Checked)
                {
                    PermisionsValue += "D";
                }

                if (chkboxM1.Checked)
                {
                    PermisionsValue += "M";
                }
                if (string.IsNullOrEmpty(PermisionsValue))
                {
                    PermisionsValue = "DENIED";
                }
                staffModel.ReportsValue = PermisionsValue;
                PermisionsValue = "";

                //Staff Permissions (8)

                if (chkboxA1.Checked)
                {
                    PermisionsValue += "A";
                }

                if (chkboxC1.Checked)
                {
                    PermisionsValue += "C";
                }

                if (chkboxD1.Checked)
                {
                    PermisionsValue += "D";
                }

                if (chkboxM1.Checked)
                {
                    PermisionsValue += "M";
                }
                if (string.IsNullOrEmpty(PermisionsValue))
                {
                    PermisionsValue = "DENIED";
                }
                staffModel.StaffValue = PermisionsValue;
                PermisionsValue = "";

                return _staff_BLL.AddStaff(staffModel);              
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private Image Base64ToImage(string base64String)
        {
            if(string.IsNullOrEmpty(base64String))
            {
                return null;
            }
            else
            {
                try
                {
                    // Convert Base64 String to byte[]
                    byte[] imageBytes = Convert.FromBase64String(base64String);
                    MemoryStream ms = new MemoryStream(imageBytes, 0,
                      imageBytes.Length);

                    // Convert byte[] to Image
                    ms.Write(imageBytes, 0, imageBytes.Length);
                    Image image = Image.FromStream(ms, true);
                    return image;
                }
                catch (Exception)
                {

                    throw;
                }
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
                staffModel.user_name = (string.IsNullOrEmpty(txtUserName.Text)) ? txtFirstName.Text.Trim() + txtLastName.Text.Trim() : txtUserName.Text.Trim();
                staffModel.password = EncryptionLab.EncryptText(string.IsNullOrEmpty(txtPassword.Text) ? txtNIC.Text.Trim() : txtPassword.Text.Trim());
                staffModel.first_name = (string.IsNullOrEmpty(txtFirstName.Text)) ? "N/A" : txtFirstName.Text.Trim();
                staffModel.last_name = (string.IsNullOrEmpty(txtLastName.Text)) ? "N/A" : txtLastName.Text.Trim();
                staffModel.gender = (cmbGender.SelectedItem == null) ? "N/A" : cmbGender.SelectedItem.ToString();
                staffModel.phone_no = (string.IsNullOrEmpty(txtPhone.Text)) ? 00000000 : Int32.Parse(txtPhone.Text.Trim());
                staffModel.nic_no = (string.IsNullOrEmpty(txtNIC.Text)) ? "N/A" : txtNIC.Text.Trim();
                staffModel.birth_date = (string.IsNullOrEmpty(dtpBirthDay.Text)) ? DateTime.Now : Convert.ToDateTime(dtpBirthDay.Text.Trim());
                staffModel.address = (string.IsNullOrEmpty(txtAddress.Text)) ? "N/A" : txtAddress.Text.Trim();
                staffModel.marital_status = (string.IsNullOrEmpty(cmbStatus.Text)) ? "N/A" : cmbStatus.SelectedItem.ToString();
                staffModel.user_type = (string.IsNullOrEmpty(cmbUserType.Text)) ? "N/A" : cmbUserType.SelectedItem.ToString();

                staffModel.staff_id = (string.IsNullOrEmpty(txtStaffID.Text)) ? "N/A" : txtStaffID.Text.Trim();
                staffModel.staff_email = (string.IsNullOrEmpty(txtStaffEmail.Text)) ? "N/A" : txtStaffEmail.Text.Trim();
                staffModel.join_date = (string.IsNullOrEmpty(dtpJoinedDate.Text)) ? DateTime.Now : Convert.ToDateTime(dtpJoinedDate.Text.Trim());
                staffModel.speciality_area = (string.IsNullOrEmpty(cmbSpeciality.Text)) ? "" : cmbSpeciality.SelectedItem.ToString();
                staffModel.photo_data = string.IsNullOrEmpty(ImageToBase64(picBoxUserImage.Image, System.Drawing.Imaging.ImageFormat.Png)) ? "N/A" : ImageToBase64(picBoxUserImage.Image, System.Drawing.Imaging.ImageFormat.Png);
                
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

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvStaff.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvStaff.CurrentRow.Selected = true;

                txtUserID.Text = dgvStaff.Rows[e.RowIndex].Cells["user_id"].FormattedValue.ToString();
                txtUserName.Text = dgvStaff.Rows[e.RowIndex].Cells["user_name"].FormattedValue.ToString();
                txtPassword.Text = EncryptionLab.DecryptText(dgvStaff.Rows[e.RowIndex].Cells["password"].FormattedValue.ToString());
                txtFirstName.Text = dgvStaff.Rows[e.RowIndex].Cells["f_name"].FormattedValue.ToString();
                txtLastName.Text = dgvStaff.Rows[e.RowIndex].Cells["l_name"].FormattedValue.ToString();                
                txtPhone.Text = dgvStaff.Rows[e.RowIndex].Cells["phone_no"].FormattedValue.ToString();
                txtNIC.Text = dgvStaff.Rows[e.RowIndex].Cells["nic_no"].FormattedValue.ToString();
                txtAddress.Text = dgvStaff.Rows[e.RowIndex].Cells["address"].FormattedValue.ToString();
                txtStaffID.Text = dgvStaff.Rows[e.RowIndex].Cells["staff_id"].FormattedValue.ToString();
                txtStaffEmail.Text = dgvStaff.Rows[e.RowIndex].Cells["staff_email"].FormattedValue.ToString();

                cmbGender.Text = dgvStaff.Rows[e.RowIndex].Cells["gender"].FormattedValue.ToString();
                cmbStatus.Text = dgvStaff.Rows[e.RowIndex].Cells["marital_status"].FormattedValue.ToString();                
                cmbUserType.Text = dgvStaff.Rows[e.RowIndex].Cells["user_type"].FormattedValue.ToString();
                cmbSpeciality.Text = dgvStaff.Rows[e.RowIndex].Cells["speciality_area"].FormattedValue.ToString();

                dtpBirthDay.Text = dgvStaff.Rows[e.RowIndex].Cells["dob"].FormattedValue.ToString();
                dtpJoinedDate.Text = dgvStaff.Rows[e.RowIndex].Cells["join_date"].FormattedValue.ToString();
                
                picBoxUserImage.Image = Base64ToImage(dgvStaff.Rows[e.RowIndex].Cells["photo_data"].FormattedValue.ToString());
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            

        }

        private void cmbUserType_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                enableItem();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void enableItem()
        {
            string[] myArr = new string[25] { 
                "Allergists/Immunologists", 
                "Anesthesiologists", 
                "Cardiologists", 
                "Colon and Rectal Surgeons",
                "Critical Care Medicine Specialists",
                "Dermatologists",
                "Endocrinologists",
                "Emergency Medicine Specialists",
                "Pediatricians",
                "Gastroenterologists",
                "Geriatric Medicine Specialists",
                "Hematologists",
                "Infectious Disease Specialists",
                "Internists",
                "Medical Geneticists",
                "Nephrologists",
                "Neurologists",
                "Gynecologists",
                "Oncologists",
                "Ophthalmologists",
                "Pathologists",
                "Physiatrists",
                "Psychiatrists",
                "Radiologists",
                "Rheumatologists"
            };

            try
            {
                
                if (cmbUserType.SelectedIndex == 0 || cmbUserType.SelectedIndex == 1)
                {                                       
                    lblSpeciality.Enabled = false;
                    cmbSpeciality.Enabled = false;
                }
                else if(cmbUserType.SelectedIndex == 2)
                {
                    cmbSpeciality.Items.Clear();

                    for (int i = 0; i < myArr.Length; i++)
                    {
                    cmbSpeciality.Items.Add(myArr[i]);
                    }
            
                    lblSpeciality.Enabled = true;
                    cmbSpeciality.Enabled = true;
                }
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    epStaff.SetError(txtUserName, "This username is Empty");
                    txtUserName.Focus();
                }
                else
                {
                    staffModel.user_name = txtUserName.Text.Trim();
                    if (string.IsNullOrEmpty(_staff_BLL.CheckUserByUsername(staffModel)))
                    {
                        epStaff.Clear();
                    }
                    else
                    {
                        epStaff.SetError(txtUserName, "This username is already in use");
                        txtUserName.Focus();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {

                
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    //label1.Text = fileName;
                    picBoxUserImage.Image = Image.FromFile(fileName);
                    picBoxUserImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}
