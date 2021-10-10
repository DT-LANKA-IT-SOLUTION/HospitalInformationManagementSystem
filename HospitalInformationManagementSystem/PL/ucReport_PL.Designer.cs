namespace HospitalInformationManagementSystem.PL
{
    partial class ucReport_PL
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAppointmentReport = new MetroFramework.Controls.MetroButton();
            this.dtpAppointmentTo = new MetroFramework.Controls.MetroDateTime();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpAppointmentFrom = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rptReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.bgWorkerReport = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbReportType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAppointmentReport);
            this.groupBox1.Controls.Add(this.dtpAppointmentTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpAppointmentFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report";
            // 
            // cmbReportType
            // 
            this.cmbReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "Appointment Report",
            "User Log",
            "Patient Login Credential"});
            this.cmbReportType.Location = new System.Drawing.Point(111, 36);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(185, 26);
            this.cmbReportType.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Report Type";
            // 
            // btnAppointmentReport
            // 
            this.btnAppointmentReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAppointmentReport.ForeColor = System.Drawing.Color.Black;
            this.btnAppointmentReport.Location = new System.Drawing.Point(780, 31);
            this.btnAppointmentReport.Name = "btnAppointmentReport";
            this.btnAppointmentReport.Size = new System.Drawing.Size(153, 29);
            this.btnAppointmentReport.TabIndex = 4;
            this.btnAppointmentReport.Text = "Generate Reports";
            this.btnAppointmentReport.UseSelectable = true;
            this.btnAppointmentReport.Click += new System.EventHandler(this.BtnAppointmentReport_Click);
            // 
            // dtpAppointmentTo
            // 
            this.dtpAppointmentTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppointmentTo.Location = new System.Drawing.Point(602, 31);
            this.dtpAppointmentTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpAppointmentTo.Name = "dtpAppointmentTo";
            this.dtpAppointmentTo.Size = new System.Drawing.Size(105, 29);
            this.dtpAppointmentTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(543, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // dtpAppointmentFrom
            // 
            this.dtpAppointmentFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppointmentFrom.Location = new System.Drawing.Point(395, 31);
            this.dtpAppointmentFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpAppointmentFrom.Name = "dtpAppointmentFrom";
            this.dtpAppointmentFrom.Size = new System.Drawing.Size(105, 29);
            this.dtpAppointmentFrom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(315, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rptReportViewer);
            this.panel1.Location = new System.Drawing.Point(13, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 569);
            this.panel1.TabIndex = 1;
            // 
            // rptReportViewer
            // 
            this.rptReportViewer.ActiveViewIndex = -1;
            this.rptReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptReportViewer.Location = new System.Drawing.Point(0, 0);
            this.rptReportViewer.Name = "rptReportViewer";
            this.rptReportViewer.Size = new System.Drawing.Size(999, 569);
            this.rptReportViewer.TabIndex = 0;
            // 
            // bgWorkerReport
            // 
            this.bgWorkerReport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWorkerReport_DoWork);
            // 
            // ucReport_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucReport_PL";
            this.Size = new System.Drawing.Size(1024, 691);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnAppointmentReport;
        private MetroFramework.Controls.MetroDateTime dtpAppointmentTo;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroDateTime dtpAppointmentFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptReportViewer;
        private System.ComponentModel.BackgroundWorker bgWorkerReport;
    }
}
