namespace HospitalInformationManagementSystem.PL
{
    partial class Dashboard_PL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlHeadder = new System.Windows.Forms.Panel();
            this.btnMaximizer = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnRestore = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.PictureBox();
            this.btnShutdown = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.pnlMenuVertical = new System.Windows.Forms.Panel();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnComplaints = new System.Windows.Forms.Button();
            this.btnPostal = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnVisitors = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHeadder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShutdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.pnlMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pnlContent.Location = new System.Drawing.Point(260, 50);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1024, 691);
            this.pnlContent.TabIndex = 5;
            // 
            // pnlHeadder
            // 
            this.pnlHeadder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHeadder.Controls.Add(this.btnMaximizer);
            this.pnlHeadder.Controls.Add(this.btnMin);
            this.pnlHeadder.Controls.Add(this.btnRestore);
            this.pnlHeadder.Controls.Add(this.btnSettings);
            this.pnlHeadder.Controls.Add(this.btnShutdown);
            this.pnlHeadder.Controls.Add(this.btnSlide);
            this.pnlHeadder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadder.Location = new System.Drawing.Point(260, 0);
            this.pnlHeadder.Name = "pnlHeadder";
            this.pnlHeadder.Size = new System.Drawing.Size(1024, 50);
            this.pnlHeadder.TabIndex = 4;
            this.pnlHeadder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHeadder_MouseDown);
            // 
            // btnMaximizer
            // 
            this.btnMaximizer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizer.Image = global::HospitalInformationManagementSystem.Properties.Resources.Maxim;
            this.btnMaximizer.Location = new System.Drawing.Point(924, 7);
            this.btnMaximizer.Name = "btnMaximizer";
            this.btnMaximizer.Size = new System.Drawing.Size(35, 35);
            this.btnMaximizer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizer.TabIndex = 5;
            this.btnMaximizer.TabStop = false;
            this.btnMaximizer.Click += new System.EventHandler(this.BtnMaximizer_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = global::HospitalInformationManagementSystem.Properties.Resources.minimize;
            this.btnMin.Location = new System.Drawing.Point(872, 7);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(35, 35);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 4;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.Image = global::HospitalInformationManagementSystem.Properties.Resources.restore1;
            this.btnRestore.Location = new System.Drawing.Point(924, 7);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(35, 35);
            this.btnRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestore.TabIndex = 3;
            this.btnRestore.TabStop = false;
            this.btnRestore.Visible = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Image = global::HospitalInformationManagementSystem.Properties.Resources.SettingsBlue;
            this.btnSettings.Location = new System.Drawing.Point(790, 7);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(35, 35);
            this.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSettings.TabIndex = 2;
            this.btnSettings.TabStop = false;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShutdown.Image = global::HospitalInformationManagementSystem.Properties.Resources.PowerBlue;
            this.btnShutdown.Location = new System.Drawing.Point(977, 7);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(35, 35);
            this.btnShutdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShutdown.TabIndex = 1;
            this.btnShutdown.TabStop = false;
            this.btnShutdown.Click += new System.EventHandler(this.BtnShutdown_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = global::HospitalInformationManagementSystem.Properties.Resources.Menublue3030;
            this.btnSlide.Location = new System.Drawing.Point(9, 7);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.BtnSlide_Click);
            // 
            // pnlMenuVertical
            // 
            this.pnlMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(29)))), ((int)(((byte)(71)))));
            this.pnlMenuVertical.Controls.Add(this.btnStaff);
            this.pnlMenuVertical.Controls.Add(this.btnReports);
            this.pnlMenuVertical.Controls.Add(this.btnComplaints);
            this.pnlMenuVertical.Controls.Add(this.btnPostal);
            this.pnlMenuVertical.Controls.Add(this.btnAppointment);
            this.pnlMenuVertical.Controls.Add(this.btnVisitors);
            this.pnlMenuVertical.Controls.Add(this.btnPatient);
            this.pnlMenuVertical.Controls.Add(this.btnDashboard);
            this.pnlMenuVertical.Controls.Add(this.pictureBox1);
            this.pnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuVertical.Name = "pnlMenuVertical";
            this.pnlMenuVertical.Size = new System.Drawing.Size(260, 741);
            this.pnlMenuVertical.TabIndex = 3;
            // 
            // btnStaff
            // 
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnStaff.Image = global::HospitalInformationManagementSystem.Properties.Resources.Staff;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(1, 582);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(15, 0, 96, 0);
            this.btnStaff.Size = new System.Drawing.Size(258, 45);
            this.btnStaff.TabIndex = 8;
            this.btnStaff.Text = "Staff";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnReports.Image = global::HospitalInformationManagementSystem.Properties.Resources.Reports;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(1, 522);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(15, 0, 63, 0);
            this.btnReports.Size = new System.Drawing.Size(258, 45);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnComplaints
            // 
            this.btnComplaints.FlatAppearance.BorderSize = 0;
            this.btnComplaints.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.btnComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplaints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnComplaints.Image = global::HospitalInformationManagementSystem.Properties.Resources.Complaints;
            this.btnComplaints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComplaints.Location = new System.Drawing.Point(1, 462);
            this.btnComplaints.Name = "btnComplaints";
            this.btnComplaints.Padding = new System.Windows.Forms.Padding(15, 0, 33, 0);
            this.btnComplaints.Size = new System.Drawing.Size(258, 45);
            this.btnComplaints.TabIndex = 6;
            this.btnComplaints.Text = "Complaints";
            this.btnComplaints.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComplaints.UseVisualStyleBackColor = true;
            this.btnComplaints.Click += new System.EventHandler(this.btnComplaints_Click);
            // 
            // btnPostal
            // 
            this.btnPostal.FlatAppearance.BorderSize = 0;
            this.btnPostal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.btnPostal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnPostal.Image = global::HospitalInformationManagementSystem.Properties.Resources.Postal;
            this.btnPostal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPostal.Location = new System.Drawing.Point(1, 402);
            this.btnPostal.Name = "btnPostal";
            this.btnPostal.Padding = new System.Windows.Forms.Padding(15, 0, 79, 0);
            this.btnPostal.Size = new System.Drawing.Size(258, 45);
            this.btnPostal.TabIndex = 5;
            this.btnPostal.Text = "Postal";
            this.btnPostal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPostal.UseVisualStyleBackColor = true;
            // 
            // btnAppointment
            // 
            this.btnAppointment.FlatAppearance.BorderSize = 0;
            this.btnAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnAppointment.Image = global::HospitalInformationManagementSystem.Properties.Resources.Appoinment;
            this.btnAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointment.Location = new System.Drawing.Point(1, 342);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Padding = new System.Windows.Forms.Padding(15, 0, 16, 0);
            this.btnAppointment.Size = new System.Drawing.Size(258, 45);
            this.btnAppointment.TabIndex = 4;
            this.btnAppointment.Text = "Appointment";
            this.btnAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAppointment.UseVisualStyleBackColor = true;
            // 
            // btnVisitors
            // 
            this.btnVisitors.FlatAppearance.BorderSize = 0;
            this.btnVisitors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.btnVisitors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnVisitors.Image = global::HospitalInformationManagementSystem.Properties.Resources.Visitor;
            this.btnVisitors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitors.Location = new System.Drawing.Point(1, 282);
            this.btnVisitors.Name = "btnVisitors";
            this.btnVisitors.Padding = new System.Windows.Forms.Padding(15, 0, 65, 0);
            this.btnVisitors.Size = new System.Drawing.Size(258, 45);
            this.btnVisitors.TabIndex = 3;
            this.btnVisitors.Text = "Visitors";
            this.btnVisitors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisitors.UseVisualStyleBackColor = true;
            this.btnVisitors.Click += new System.EventHandler(this.BtnVisitors_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.FlatAppearance.BorderSize = 0;
            this.btnPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnPatient.Image = global::HospitalInformationManagementSystem.Properties.Resources.Patient;
            this.btnPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatient.Location = new System.Drawing.Point(1, 222);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Padding = new System.Windows.Forms.Padding(15, 0, 70, 0);
            this.btnPatient.Size = new System.Drawing.Size(258, 45);
            this.btnPatient.TabIndex = 2;
            this.btnPatient.Text = "Patient";
            this.btnPatient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.BtnPatient_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDashboard.Image = global::HospitalInformationManagementSystem.Properties.Resources.Dashboard;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(1, 162);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(15, 0, 35, 0);
            this.btnDashboard.Size = new System.Drawing.Size(258, 45);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalInformationManagementSystem.Properties.Resources.IconInterface3;
            this.pictureBox1.Location = new System.Drawing.Point(2, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 741);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeadder);
            this.Controls.Add(this.pnlMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard_PL";
            this.Load += new System.EventHandler(this.Dashboard_PL_Load);
            this.pnlHeadder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShutdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.pnlMenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnComplaints;
        private System.Windows.Forms.Button btnPostal;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnVisitors;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnRestore;
        private System.Windows.Forms.PictureBox btnSettings;
        private System.Windows.Forms.PictureBox btnShutdown;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlHeadder;
        private System.Windows.Forms.PictureBox btnMaximizer;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.Panel pnlMenuVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}