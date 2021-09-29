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
                //   visitorModel.in_time = Convert.ToDateTime(dtpInTime.Text.Trim());
                visitorModel.out_time = Convert.ToDateTime(dtpOutTime.Text.Trim());
                //visitorModel.out_time = DateTime.ParseExact(dtpOutTime.Text.Trim(), "HH:mm:ss", CultureInfo.InvariantCulture);
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
    }
}
