using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using HospitalInformationManagementSystem.Other;
using System.Configuration;

namespace HospitalInformationManagementSystem.PL
{
    public partial class Loading : MetroFramework.Forms.MetroForm
    {
        DatabaseConnectionCheck dbconnection = new DatabaseConnectionCheck();
        public Loading()
        {
            InitializeComponent();
        }
        int counter = 0;
        //int len = 0;
        string txt;
        
        private void Loading_Load(object sender, EventArgs e)
        {
            txt = lblProgressInformation.Text;
            tmrLoading.Start();
            lblProgressInformation.Text = "";
        }
        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            try
            {
                counter++;
                if (counter > 25 && counter <= 150)
                {
                    lblProgressInformation.Text = "Gathering information";
                }
                
                else if (counter > 151 && counter <= 200)
                {
                    lblProgressInformation.Text = "Connecting to the database";
                }
                
                else if (counter > 200 && counter <= 325)
                {
                    
                   
                    if (dbconnection.CheckDbConnection(ConfigurationManager.ConnectionStrings["HIMS"].ConnectionString))
                    {
                        lblProgressInformation.Text = "Database Connected";
                    }
                    else
                    {
                        lblProgressInformation.Text = "Database Connection faild";

                    }

                }
                else if (counter > 326 && counter <= 400)
                {
                    lblProgressInformation.Text = "Welcome To the HIMS";

                }
                
                else if(counter > 401)
                {
                    Login_PL login = new Login_PL();
                    login.Show();
                    tmrLoading.Stop();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
