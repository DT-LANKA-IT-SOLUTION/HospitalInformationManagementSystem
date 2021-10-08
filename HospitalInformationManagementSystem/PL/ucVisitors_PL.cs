using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalInformationManagementSystem.BLL;
using HospitalInformationManagementSystem.Model;
using HospitalInformationManagementSystem.Other;
using System.Globalization;

namespace HospitalInformationManagementSystem.PL
{
    public partial class ucVisitors_PL : MetroFramework.Controls.MetroUserControl
    {
        
        GrantUserPermission _grantUserPermission = new GrantUserPermission();

        Visitor_BLL _visitor_BLL = new Visitor_BLL();

        VisitorModel visitorModel = new VisitorModel();

        public ucVisitors_PL()
        {
            InitializeComponent();
            _grantUserPermission.GrantButtonPermission("visitor", btnAdd, btnEdit, btnDelete);
        }

       

        private void FillDGVVisitor()
        {
            try
            {
                _visitor_BLL.LoadAllVisitorGridView(dgvVisitor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValid(string type)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                epVisitor.SetError(txtFirstName, "Please Fill First Name");
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                epVisitor.SetError(txtLastName, "Please Fill Last Name");
                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNic.Text))
            {
                epVisitor.SetError(txtNic, "Please Fill National Identity Card Number");
                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                epVisitor.SetError(txtPhone, "Please Fill Phone Number");
                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtPurpose.Text))
            {
                epVisitor.SetError(txtPurpose, "Please Fill Purpose");
                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNote.Text))
            {
                epVisitor.SetError(txtNote, "Please Fill Note");
                txtLastName.Focus();
                return false;
            }

            epVisitor.Clear();
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddVisitor() > 0)
                {
                    MessageBox.Show("Visitor add sucessfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.FillDGVVisitor();
                    epVisitor.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private int AddVisitor()
        {
            try
            {
                if (IsValid("add"))
                {
                    visitorModel.fname = txtFirstName.Text.Trim();
                    visitorModel.lname = txtLastName.Text.Trim();
                    visitorModel.phone_no = txtPhone.Text.Trim();
                    visitorModel.nic_no = txtNic.Text.Trim();
                    visitorModel.date = Convert.ToDateTime(dtpDate.Text.Trim());
                    string date = DateTime.Now.ToString("M/d/yyyy");
                    visitorModel.date = Convert.ToDateTime(date);
                    string dtpInTime = DateTime.Now.ToString("h:mm:ss tt");
                    visitorModel.in_time = Convert.ToDateTime(dtpInTime);
                    visitorModel.out_time = Convert.ToDateTime(dtpOutTime.Text.Trim());
                    visitorModel.note = txtNote.Text.Trim();
                    visitorModel.purpose = txtPurpose.Text.Trim();
                    visitorModel.cmbAttachmentType = cmbAttachmentType.Text.Trim();
                    visitorModel.IsActive = true;
					
                    return _visitor_BLL.AddVisitor(visitorModel);
                }

                return 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                ofdVisitor.InitialDirectory = @"C:\";
                ofdVisitor.RestoreDirectory = true;
                ofdVisitor.Title = "Browse Text Files";
                if (ofdVisitor.ShowDialog() == DialogResult.OK)
                {
                    visitorModel.attachment_data = ofdVisitor.FileName;
                    visitorModel.cmbAttachmentType = ofdVisitor.GetType().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtNic.Text = "";
            dtpDate.Value = DateTime.Now;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (UpdateVisitor() > 0)
                {
                    MessageBox.Show("Patient update sucessfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.FillDGVVisitor();
                    this.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int UpdateVisitor()
        {
            try
            {
                if(IsValid("update"))
                {
                    visitorModel.fname = txtFirstName.Text.Trim();
                    visitorModel.lname = txtLastName.Text.Trim();
                    visitorModel.phone_no = txtPhone.Text.Trim();
                    visitorModel.nic_no = txtNic.Text.Trim();
                    //string date = DateTime.Now.ToString("M/d/yyyy");
                    //visitorModel.date = Convert.ToDateTime(date);
                    //string dtpInTime = DateTime.Now.ToString("h:mm:ss tt");
                    //visitorModel.in_time = Convert.ToDateTime(dtpInTime);
                    visitorModel.out_time = Convert.ToDateTime(dtpOutTime.Text.Trim());
                    visitorModel.note = txtNote.Text.Trim();
                    visitorModel.purpose = txtPurpose.Text.Trim();
                    visitorModel.cmbAttachmentType = cmbAttachmentType.Text.Trim();

                    visitorModel.IsActive = true;
                    return _visitor_BLL.AddVisitor(visitorModel);
                }
                return 0;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ucVisitors_PL_Load(object sender, EventArgs e)
        {
            this.FillDGVVisitor();
            epVisitor.Clear();
        }

        private void dgvVisitorsCellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvVisitor.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                btnDownload.Visible = true;
                dgvVisitor.CurrentRow.Selected = true;
                
                txtFirstName.Text = dgvVisitor.Rows[e.RowIndex].Cells["fname"].FormattedValue.ToString();
                txtLastName.Text = dgvVisitor.Rows[e.RowIndex].Cells["lname"].FormattedValue.ToString();
                txtNic.Text = dgvVisitor.Rows[e.RowIndex].Cells["nic_no"].FormattedValue.ToString();
                txtPhone.Text = dgvVisitor.Rows[e.RowIndex].Cells["phone_no"].FormattedValue.ToString();
                dtpOutTime.Text = dgvVisitor.Rows[e.RowIndex].Cells["out_time"].FormattedValue.ToString();
                txtPurpose.Text = dgvVisitor.Rows[e.RowIndex].Cells["purpose"].FormattedValue.ToString();
                dtpDate.Text = dgvVisitor.Rows[e.RowIndex].Cells["date"].FormattedValue.ToString();
                txtNote.Text = dgvVisitor.Rows[e.RowIndex].Cells["note"].FormattedValue.ToString();
                cmbAttachmentType.Text = dgvVisitor.Rows[e.RowIndex].Cells["attachment_type"].FormattedValue.ToString();
                cmbAttachmentType.Text = dgvVisitor.Rows[e.RowIndex].Cells["attachment_data"].FormattedValue.ToString();
                            

                //btnAddPatient.Enabled = false;
            }
        }
    }
}
