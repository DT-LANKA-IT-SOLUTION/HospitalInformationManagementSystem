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
    public partial class Login_PL : Form
    {
        public Login_PL()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (this.isFormValid())
            {
                AuthModel _authModel = new AuthModel();
                _authModel.Username = txtUsername.Text.Trim();
                _authModel.Password = txtPassword.Text.Trim();
                //Auth_BLL.getUserAuthentication(_authModel);
            }
        }

        private bool isFormValid()
        {
            if (txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Username Required","Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
    }
}
