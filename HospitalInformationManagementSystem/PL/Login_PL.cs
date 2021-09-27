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
    public partial class Login_PL : Form
    {
        public Login_PL()
        {
            InitializeComponent();
        }

        Auth_BLL auth = new Auth_BLL();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsFormValid())
                {
                    AuthModel _authModel = new AuthModel();
                    _authModel.Username = txtUsername.Text.Trim();
                    _authModel.Password = txtPassword.Text.Trim();
                    List<string> data = auth.GetUserAuthentication(_authModel);
                    if (data[1] == "true")
                    {
                        MessageBox.Show(data[0], "Message");
                        this.Hide();
                        Dashboard_PL dashboard = new Dashboard_PL();
                        dashboard.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private bool IsFormValid()
        {
            if (txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Username Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        private void BtnShutdown_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really need to shutdown", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
