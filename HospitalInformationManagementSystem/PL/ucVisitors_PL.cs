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

namespace HospitalInformationManagementSystem.PL
{
    public partial class ucVisitors_PL : UserControl
    {
        //GrantUserPermission _grantUserPermission = new GrantUserPermission();

        Visitor_BLL _visitor_BLL = new Visitor_BLL();

        VisitorModel visitorModel = new VisitorModel();

        public ucVisitors_PL()
        {
            InitializeComponent();
        }

        private void UcVisitor_PL_Load(object sender, EventArgs e)
        {
            this.FillDGVVisitor();

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
                visitorModel.phone_no = Int32.Parse(txtPhone.Text.Trim());
                visitorModel.nic_no = txtNic.Text.Trim();
                visitorModel.date = dtpDate.Value;
                visitorModel.in_time = dtpInTime.Value;
                visitorModel.out_time = dtpOutTime.Value;
                visitorModel.note = txtNote.Text.Trim();
                //visitorModel.attachment_type = 


                visitorModel.IsActive = true;
                return _visitor_BLL.AddVisitor(visitorModel);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
