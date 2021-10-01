using HospitalInformationManagementSystem.BLL;
using HospitalInformationManagementSystem.Model;
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
    public partial class ucComplaint_PL : UserControl
    {
        Complaint_BLL _complaint_BLL = new Complaint_BLL();

        ComplaintModel complaintModel = new ComplaintModel();

        public ucComplaint_PL()
        {
            InitializeComponent();
        }

        private void ucComplaint_PL_Load(object sender, EventArgs e)
        {
            this.FilDGVComplaints();
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
                throw;
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

            if (cmbComplaintType.SelectedItem.Equals("Management"))
            {
                cmbComplaintCategory.Items.Clear();

                for(int i = 0; i < 5; i++)
                {
                    cmbComplaintCategory.Items.Add(comCategory[i]);
                }
                
            }
            else if (cmbComplaintType.SelectedItem.Equals("Clinical"))
            {
                cmbComplaintCategory.Items.Clear();

                for (int i = 5; i < 10; i++)
                {
                    cmbComplaintCategory.Items.Add(comCategory[i]);
                }
            }
            else if (cmbComplaintType.SelectedItem.Equals("Relationships & Behavior"))
            {
                cmbComplaintCategory.Items.Clear();

                for (int i = 10; i < comCategory.Length; i++)
                {
                    cmbComplaintCategory.Items.Add(comCategory[i]);
                }
            }
        }

        
    }
}
