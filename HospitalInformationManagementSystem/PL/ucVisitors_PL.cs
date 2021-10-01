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
    public partial class ucVisitors_PL : UserControl
    {
        
        GrantUserPermission _grantUserPermission = new GrantUserPermission();

        Visitor_BLL _visitor_BLL = new Visitor_BLL();

        VisitorModel visitorModel = new VisitorModel();

        public ucVisitors_PL()
        {
            InitializeComponent();
            _grantUserPermission.GrantButtonPermission("visitor", btnAdd, btnEdit, btnDelete);
        }

        private void UcVisitor_PL_Load(object sender, EventArgs e)
        {
            this.FillDGVVisitor();
            epVisitor.Clear();
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

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                epVisitor.SetError(txtNic, "Please Fill National Identity Card Number");
                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                epVisitor.SetError(txtPhone, "Please Fill Phone Number");
                txtLastName.Focus();
                return false;
            }

        //    if (string.IsNullOrEmpty(txtPassword.Text))
        //    {
        //        epPatient.SetError(txtPassword, "Please Fill Password");
        //        txtPassword.Focus();
        //        return false;
        //    }

        //    if (string.IsNullOrEmpty(txtNIC.Text))
        //    {
        //        epPatient.SetError(txtNIC, "Please Fill NIC");
        //        txtNIC.Focus();
        //        return false;
        //    }
        //    else
        //    {
        //        Regex reg = new Regex(@"^([0-9]{9}[x|X|v|V]|[0-9]{12})$");

        //        bool result = reg.IsMatch(txtNIC.Text.Trim());

        //        if (result)
        //        {
        //            epPatient.Clear();
        //        }
        //        else
        //        {
        //            epPatient.SetError(txtNIC, "This NIC number is invalid...!");
        //            txtNIC.Focus();
        //            return false;
        //        }
        //    }

        //    if (string.IsNullOrEmpty(txtPhone.Text))
        //    {
        //        epPatient.SetError(txtPhone, "Please Fill Phone");
        //        txtPhone.Focus();
        //        return false;
        //    }
        //    else
        //    {
        //        Regex reg = new Regex(@"^(?:7|0|(?:\+94))[0-9]{9,10}$");

        //        bool result = reg.IsMatch(txtPhone.Text.Trim());

        //        if (result)
        //        {
        //            epPatient.Clear();
        //        }
        //        else
        //        {
        //            epPatient.SetError(txtPhone, "This Phone Number is invalid...!");
        //            txtPhone.Focus();
        //            return false;
        //        }
        //    }

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
                visitorModel.fname = txtFirstName.Text.Trim();
                visitorModel.lname = txtLastName.Text.Trim();
                visitorModel.phone_no = txtPhone.Text.Trim();
                visitorModel.nic_no = txtNic.Text.Trim();
                visitorModel.date = Convert.ToDateTime(dtpDate.Text.Trim());

                string dtpInTime = DateTime.Now.ToString("h:mm:ss tt");
                visitorModel.in_time = Convert.ToDateTime(dtpInTime);
                visitorModel.out_time = Convert.ToDateTime(dtpOutTime.Text.Trim());
                visitorModel.note = txtNote.Text.Trim();
                visitorModel.purpose = txtPurpose.Text.Trim();
                visitorModel.attachment_type = txtAttachmentType.Text.Trim();
                
                visitorModel.IsActive = true;
                return _visitor_BLL.AddVisitor(visitorModel);
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
                    visitorModel.attachment_type = ofdVisitor.GetType().ToString();
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
                    visitorModel.date = Convert.ToDateTime(dtpDate.Text.Trim());
                    string dtpInTime = DateTime.Now.ToString("h:mm:ss tt");
                    visitorModel.in_time = Convert.ToDateTime(dtpInTime);
                    visitorModel.out_time = Convert.ToDateTime(dtpOutTime.Text.Trim());
                    visitorModel.note = txtNote.Text.Trim();
                    visitorModel.purpose = txtPurpose.Text.Trim();
                    visitorModel.attachment_type = txtAttachmentType.Text.Trim();

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
    }
}
