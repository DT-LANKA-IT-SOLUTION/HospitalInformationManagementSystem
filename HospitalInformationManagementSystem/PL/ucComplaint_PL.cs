using HospitalInformationManagementSystem.BLL;
using HospitalInformationManagementSystem.Model;
using HospitalInformationManagementSystem.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalInformationManagementSystem.PL
{
    public partial class ucComplaint_PL : UserControl
    {
        Complaint_BLL _complaint_BLL = new Complaint_BLL();

        Reference_BLL _reference_BLL = new Reference_BLL();

        ComplaintModel complaintModel = new ComplaintModel();

        public ucComplaint_PL()
        {
            InitializeComponent();
        }

        private void ucComplaint_PL_Load(object sender, EventArgs e)
        {
            this.FilDGVComplaints();
            this.LoadComboBoxComplaintType();
            cmbComplaintType.SelectedIndex = -1;
        }

        private void LoadComboBoxComplaintType()
        {
            try
            {
                _reference_BLL.GetComplaintTypes(cmbComplaintType);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilDGVComplaints()
        {
            try
            {
                _complaint_BLL.LoadAllComplaintsGridView(dgvComplaints);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmbComplaintType_SelectedValueChanged(object sender, EventArgs e)
        {
            string[] comCategory = new string[15] {
                "Environment",
                "Finances & Billing",
                "Service Issues",
                "Access & Admissions",
                "Delays",
                "Treatment",
                "Quality of Care",
                "Errors in Diagnosis",
                "Medication Errors",
                "Safety Incidence",
                "Communication Breakdown",
                "Incorrect Information",
                "Respect, Dignity & care",
                "Violation of Rights",
                "Confidentiality"
            };

            if (cmbComplaintType.SelectedValue == null)
            {
                cmbComplaintCategory.Items.Clear();
            }
            else if (cmbComplaintType.SelectedValue.ToString().Equals("Management"))
            {
                cmbComplaintCategory.Items.Clear();

                for (int i = 0; i < 5; i++)
                {
                    cmbComplaintCategory.Items.Add(comCategory[i]);
                }

            }
            else if (cmbComplaintType.SelectedValue.ToString().Equals("Clinical"))
            {
                cmbComplaintCategory.Items.Clear();

                for (int i = 5; i < 10; i++)
                {
                    cmbComplaintCategory.Items.Add(comCategory[i]);
                }
            }
            else if (cmbComplaintType.SelectedValue.ToString().Equals("Relationships & Behavior"))
            {
                cmbComplaintCategory.Items.Clear();

                for (int i = 10; i < comCategory.Length; i++)
                {
                    cmbComplaintCategory.Items.Add(comCategory[i]);
                }
            }
            
        }

        private void BtnComplaintBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                ofdComplaints.Title = "Browse Files";
                if (ofdComplaints.ShowDialog() == DialogResult.OK)
                {
                    complaintModel.attachment_data = ofdComplaints.FileName;
                    complaintModel.attachment_type = Path.GetExtension(ofdComplaints.FileName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddComplaint_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddComplaint() > 0)
                {
                    MessageBox.Show("Complaint Add Sucessfull");
                    this.FilDGVComplaints();
                    this.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int AddComplaint()
        {
            try
            {
                if (IsValide("add"))
                {
                    complaintModel.complaint_by = txtComplaintBy.Text.Trim();
                    complaintModel.complaint_type = cmbComplaintType.Text.Trim();
                    complaintModel.complaintCategory = cmbComplaintCategory.Text.Trim();
                    complaintModel.description = txtDescription.Text.Trim();
                    complaintModel.date = Convert.ToDateTime(dtpDate.Text.Trim());
                    complaintModel.nic_no = txtNIC.Text.Trim();
                    complaintModel.phone_no = Int32.Parse(txtPhone.Text.Trim());
                    //complaintModel.action_taken = txtActionTaken.Text.Trim();
                    //complaintModel.note = txtNote.Text.Trim();
                    complaintModel.IsActive = true;

                    return _complaint_BLL.AddComplaints(complaintModel);
                }
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool IsValide(string action)
        {
            try
            {
                if (ValidationLab.ComboBoxValidation(cmbComplaintType, epComplaints) == false)
                {
                    return false;
                }

                if (ValidationLab.ComboBoxValidation(cmbComplaintCategory, epComplaints) == false)
                {
                    return false;
                }

                if (ValidationLab.TextBoxValidation(txtDescription, epComplaints) == false)
                {
                    return false;
                }
                if (action == "update")
                {
                    if (ValidationLab.TextBoxValidation(txtActionTaken, epComplaints) == false)
                    {
                        return false;
                    }

                    if (ValidationLab.TextBoxValidation(txtNote, epComplaints) == false)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DgvComplaints_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvComplaints.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvComplaints.CurrentRow.Selected = true;

                txtCompID.Text = dgvComplaints.Rows[e.RowIndex].Cells["comp_id"].FormattedValue.ToString();
                txtComplaintBy.Text = dgvComplaints.Rows[e.RowIndex].Cells["comp_by"].FormattedValue.ToString();
                cmbComplaintType.Text = dgvComplaints.Rows[e.RowIndex].Cells["comp_type"].FormattedValue.ToString();
                cmbComplaintCategory.Text = dgvComplaints.Rows[e.RowIndex].Cells["complaint_category"].FormattedValue.ToString();
                txtDescription.Text = dgvComplaints.Rows[e.RowIndex].Cells["description"].FormattedValue.ToString();
                dtpDate.Text = dgvComplaints.Rows[e.RowIndex].Cells["date"].FormattedValue.ToString();
                txtNIC.Text = dgvComplaints.Rows[e.RowIndex].Cells["nic_no"].FormattedValue.ToString();
                txtPhone.Text = dgvComplaints.Rows[e.RowIndex].Cells["phone_no"].FormattedValue.ToString();
                txtActionTaken.Text = dgvComplaints.Rows[e.RowIndex].Cells["action_taken"].FormattedValue.ToString();
                txtNote.Text = dgvComplaints.Rows[e.RowIndex].Cells["note"].FormattedValue.ToString();

                btnComplaintViewFile.Visible = true;
                btnAddComplaint.Enabled = false;
                label9.Visible = true;
                label2.Visible = true;
                txtActionTaken.Visible = true;
                txtNote.Visible = true;
            }
        }

        private bool CreateFile()
        {
            try
            {
                if (_complaint_BLL.GetAttachment(Int32.Parse(txtCompID.Text.Trim()),sfdComplaints))
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Clear()
        {
            txtComplaintBy.Text = "";
            cmbComplaintType.Text = "";
            cmbComplaintCategory.Text = "";
            txtDescription.Text = "";
            dtpDate.Text = "";
            txtNIC.Text = "";
            txtPhone.Text = "";
            txtActionTaken.Text = "";
            txtNote.Text = "";
        }

        private void BtnComplaintViewFile_Click(object sender, EventArgs e)
        {
            if (CreateFile())
            {
                wfViewFiles_PL wfViewFiles_PL = new wfViewFiles_PL(ComplaintModel.viewFile);
                wfViewFiles_PL.Show();
            }
        }

        private void BtnEditComplaint_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.UpdateComplaint() > 0)
                {
                    MessageBox.Show("Complaint Update Sucessfull");
                    this.FilDGVComplaints();
                    this.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int UpdateComplaint()
        {
            try
            {
                if(IsValide("update"))
                {
                    complaintModel.complaint_by = txtComplaintBy.Text.Trim();
                    complaintModel.complaint_type = cmbComplaintType.Text.Trim();
                    complaintModel.complaintCategory = cmbComplaintCategory.Text.Trim();
                    complaintModel.description = txtDescription.Text.Trim();
                    complaintModel.date = Convert.ToDateTime(dtpDate.Text.Trim());
                    complaintModel.nic_no = txtNIC.Text.Trim();
                    complaintModel.phone_no = Int32.Parse(txtPhone.Text.Trim());
                    complaintModel.action_taken = txtActionTaken.Text.Trim();
                    complaintModel.note = txtNote.Text.Trim();
                    complaintModel.IsActive = true;
                    complaintModel.complaint_id = Int32.Parse(txtCompID.Text.Trim());

                    return _complaint_BLL.UpdateComplaints(complaintModel);
                }
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnDeleteComplaint_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.DeleteComplaint() > 0)
                {
                    MessageBox.Show("Complaint Delete Sucessfull");
                    this.FilDGVComplaints();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            
        }

        private int DeleteComplaint()
        {
            try
            {
                return _complaint_BLL.DeleteComplaints(false,Int32.Parse(txtCompID.Text.Trim()));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
