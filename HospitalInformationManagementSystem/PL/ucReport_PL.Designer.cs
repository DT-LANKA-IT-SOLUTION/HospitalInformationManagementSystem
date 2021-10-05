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
            this.btnAppointmentReport = new MetroFramework.Controls.MetroButton();
            this.dtpAppointmentTo = new MetroFramework.Controls.MetroDateTime();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpAppointmentFrom = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUserLogReport = new MetroFramework.Controls.MetroButton();
            this.dtpUserTo = new MetroFramework.Controls.MetroDateTime();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpUserFrom = new MetroFramework.Controls.MetroDateTime();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPatientLoginReport = new MetroFramework.Controls.MetroButton();
            this.dtpPatientTo = new MetroFramework.Controls.MetroDateTime();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpPatientFrom = new MetroFramework.Controls.MetroDateTime();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAppointmentReport);
            this.groupBox1.Controls.Add(this.dtpAppointmentTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpAppointmentFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Report";
            // 
            // btnAppointmentReport
            // 
            this.btnAppointmentReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAppointmentReport.ForeColor = System.Drawing.Color.Black;
            this.btnAppointmentReport.Location = new System.Drawing.Point(445, 44);
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
            this.dtpAppointmentTo.Location = new System.Drawing.Point(281, 44);
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
            this.label2.Location = new System.Drawing.Point(216, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // dtpAppointmentFrom
            // 
            this.dtpAppointmentFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppointmentFrom.Location = new System.Drawing.Point(71, 44);
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
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUserLogReport);
            this.groupBox2.Controls.Add(this.dtpUserTo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpUserFrom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(999, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Log";
            // 
            // btnUserLogReport
            // 
            this.btnUserLogReport.BackColor = System.Drawing.Color.YellowGreen;
            this.btnUserLogReport.ForeColor = System.Drawing.Color.Black;
            this.btnUserLogReport.Location = new System.Drawing.Point(445, 47);
            this.btnUserLogReport.Name = "btnUserLogReport";
            this.btnUserLogReport.Size = new System.Drawing.Size(153, 29);
            this.btnUserLogReport.TabIndex = 8;
            this.btnUserLogReport.Text = "Generate Reports";
            this.btnUserLogReport.UseSelectable = true;
            // 
            // dtpUserTo
            // 
            this.dtpUserTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUserTo.Location = new System.Drawing.Point(281, 47);
            this.dtpUserTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpUserTo.Name = "dtpUserTo";
            this.dtpUserTo.Size = new System.Drawing.Size(105, 29);
            this.dtpUserTo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(216, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "To";
            // 
            // dtpUserFrom
            // 
            this.dtpUserFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUserFrom.Location = new System.Drawing.Point(71, 47);
            this.dtpUserFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpUserFrom.Name = "dtpUserFrom";
            this.dtpUserFrom.Size = new System.Drawing.Size(105, 29);
            this.dtpUserFrom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "From";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPatientLoginReport);
            this.groupBox3.Controls.Add(this.dtpPatientTo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dtpPatientFrom);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(999, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Patient Login Credential";
            // 
            // btnPatientLoginReport
            // 
            this.btnPatientLoginReport.BackColor = System.Drawing.Color.YellowGreen;
            this.btnPatientLoginReport.ForeColor = System.Drawing.Color.Black;
            this.btnPatientLoginReport.Location = new System.Drawing.Point(445, 47);
            this.btnPatientLoginReport.Name = "btnPatientLoginReport";
            this.btnPatientLoginReport.Size = new System.Drawing.Size(153, 29);
            this.btnPatientLoginReport.TabIndex = 12;
            this.btnPatientLoginReport.Text = "Generate Reports";
            this.btnPatientLoginReport.UseSelectable = true;
            // 
            // dtpPatientTo
            // 
            this.dtpPatientTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPatientTo.Location = new System.Drawing.Point(281, 47);
            this.dtpPatientTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpPatientTo.Name = "dtpPatientTo";
            this.dtpPatientTo.Size = new System.Drawing.Size(105, 29);
            this.dtpPatientTo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(216, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "To";
            // 
            // dtpPatientFrom
            // 
            this.dtpPatientFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPatientFrom.Location = new System.Drawing.Point(71, 47);
            this.dtpPatientFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpPatientFrom.Name = "dtpPatientFrom";
            this.dtpPatientFrom.Size = new System.Drawing.Size(105, 29);
            this.dtpPatientFrom.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "From";
            // 
            // ucReport_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucReport_PL";
            this.Size = new System.Drawing.Size(1024, 691);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton btnAppointmentReport;
        private MetroFramework.Controls.MetroDateTime dtpAppointmentTo;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroDateTime dtpAppointmentFrom;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnUserLogReport;
        private MetroFramework.Controls.MetroDateTime dtpUserTo;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroDateTime dtpUserFrom;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton btnPatientLoginReport;
        private MetroFramework.Controls.MetroDateTime dtpPatientTo;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroDateTime dtpPatientFrom;
        private System.Windows.Forms.Label label5;
    }
}
