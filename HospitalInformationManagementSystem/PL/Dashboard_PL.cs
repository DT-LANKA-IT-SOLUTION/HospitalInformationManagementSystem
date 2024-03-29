﻿using HospitalInformationManagementSystem.Model;
using HospitalInformationManagementSystem.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalInformationManagementSystem.PL
{
    public partial class Dashboard_PL : Form
    {
        GrantUserPermission _GrantUserPermission = new GrantUserPermission();
        //ucReport_PL ucReport_PL = new ucReport_PL();
        public Dashboard_PL()
        { 
            InitializeComponent();
            _GrantUserPermission.GrantMenuPermission(btnDashboard, btnPatient, btnVisitors, btnAppointment, btnPostal, btnComplaints, btnReports, btnStaff);

            timer1.Start();
            //this.ucReport_PL.ParentForm = this;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            ucDashboard_PL ucDashboard = new ucDashboard_PL();
            FormControl.showControls(ucDashboard, pnlContent);

        }

        private void BtnPatient_Click(object sender, EventArgs e)
        {
            ucPatient_PL ucPatient = new ucPatient_PL();
            FormControl.showControls(ucPatient,pnlContent);
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximizer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestore.Visible = true;
            btnMaximizer.Visible = false;
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

        private void BtnSlide_Click(object sender, EventArgs e)
        {
            if (pnlMenuVertical.Width == 260)
            {
                pnlMenuVertical.Width = 100;
            }
            else
                pnlMenuVertical.Width = 260;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {

        }

        private void PnlHeadder_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnVisitors_Click(object sender, EventArgs e)
        {
            ucVisitors_PL ucVisitor = new ucVisitors_PL();
            FormControl.showControls(ucVisitor,pnlContent);
        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            ucComplaint_PL ucComplaint = new ucComplaint_PL();
            FormControl.showControls(ucComplaint, pnlContent);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ucStaff_PL ucStaff = new ucStaff_PL();
            FormControl.showControls(ucStaff, pnlContent);
        }

        private void Dashboard_PL_Load(object sender, EventArgs e)
        {
            AuthModel authModel = new AuthModel();

            ucDashboard_PL ucDashboard = new ucDashboard_PL();
            FormControl.showControls(ucDashboard, pnlContent);

            
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            ucAppointment_PL ucAppointment = new ucAppointment_PL();
            FormControl.showControls(ucAppointment,pnlContent);
        }

        private void btnPostal_Click(object sender, EventArgs e)
        {
            ucPostals_PL ucPostals = new ucPostals_PL();
            FormControl.showControls(ucPostals, pnlContent);
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            ucReport_PL ucReport = new ucReport_PL();
            FormControl.showControls(ucReport, pnlContent);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            lbldate.Text = d.ToString();
        }
    }
}
