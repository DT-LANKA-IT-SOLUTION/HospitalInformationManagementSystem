using HospitalInformationManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalInformationManagementSystem.InformationPL
{
    public partial class frmNotification : Form
    {
        public frmNotification()
        {
            InitializeComponent();
        }
        public enum enmAction
        {
            wait,
            start,
            close
        }
        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }
        private frmNotification.enmAction action;

        int x, y;

        private void btnClose_Click(object sender, EventArgs e)
        {
            tmrSuccess.Interval = 1;
            action = enmAction.close;
        }

        private void tmrSuccess_Tick(object sender, EventArgs e)
        {
            switch(this.action)
            {
                case enmAction.wait:
                    tmrSuccess.Interval = 5000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    tmrSuccess.Interval = 1;
                    this.Opacity += 0.1;
                    if(this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if(this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }    
                    }
                    break;
                case enmAction.close:
                    tmrSuccess.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if(base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 0; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                frmNotification frm = (frmNotification)Application.OpenForms[fname];

                if(frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch(type)
            {
                case enmType.Success:
                    this.pbNotification.Image = Resources.Success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    this.pbNotification.Image = Resources.Error;
                    this.BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    this.pbNotification.Image = Resources.Information;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case enmType.Warning:
                    this.pbNotification.Image = Resources.Warning;
                    this.BackColor = Color.DarkOrange;
                    break;
            }


            this.lblMessage.Text = msg;
            this.Show();
            this.action = enmAction.start;
            this.tmrSuccess.Interval = 1;
            tmrSuccess.Start();
        }
            
    }
}
