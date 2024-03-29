﻿
namespace HospitalInformationManagementSystem.PL
{
    partial class ucAppointment_PL
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_medical_officer = new System.Windows.Forms.ComboBox();
            this.txt_app_id = new System.Windows.Forms.TextBox();
            this.txt_medical_officer = new System.Windows.Forms.TextBox();
            this.btn_reset_appointment = new System.Windows.Forms.Button();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.btn_add_appointment = new System.Windows.Forms.Button();
            this.btn_edit_appointment = new System.Windows.Forms.Button();
            this.btn_delete_appointment = new System.Windows.Forms.Button();
            this.dateTimePicker_time = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.txt_symptoms = new System.Windows.Forms.TextBox();
            this.txt_patient_name = new System.Windows.Forms.TextBox();
            this.txt_appointment_no = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvAppointment = new MetroFramework.Controls.MetroGrid();
            this.app_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointment_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptoms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medical_officer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.app_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.app_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSerarchStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchByAppNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.epAppointment = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cmb_medical_officer);
            this.groupBox1.Controls.Add(this.txt_app_id);
            this.groupBox1.Controls.Add(this.txt_medical_officer);
            this.groupBox1.Controls.Add(this.btn_reset_appointment);
            this.groupBox1.Controls.Add(this.comboBox_status);
            this.groupBox1.Controls.Add(this.btn_add_appointment);
            this.groupBox1.Controls.Add(this.btn_edit_appointment);
            this.groupBox1.Controls.Add(this.btn_delete_appointment);
            this.groupBox1.Controls.Add(this.dateTimePicker_time);
            this.groupBox1.Controls.Add(this.dateTimePicker_date);
            this.groupBox1.Controls.Add(this.txt_symptoms);
            this.groupBox1.Controls.Add(this.txt_patient_name);
            this.groupBox1.Controls.Add(this.txt_appointment_no);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 685);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Form";
            // 
            // cmb_medical_officer
            // 
            this.cmb_medical_officer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_medical_officer.FormattingEnabled = true;
            this.cmb_medical_officer.Location = new System.Drawing.Point(178, 248);
            this.cmb_medical_officer.Name = "cmb_medical_officer";
            this.cmb_medical_officer.Size = new System.Drawing.Size(336, 26);
            this.cmb_medical_officer.TabIndex = 15;
            this.cmb_medical_officer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_medical_officer_KeyPress);
            // 
            // txt_app_id
            // 
            this.txt_app_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_app_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_app_id.Location = new System.Drawing.Point(178, 22);
            this.txt_app_id.Name = "txt_app_id";
            this.txt_app_id.Size = new System.Drawing.Size(336, 24);
            this.txt_app_id.TabIndex = 14;
            this.txt_app_id.Visible = false;
            // 
            // txt_medical_officer
            // 
            this.txt_medical_officer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_medical_officer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medical_officer.Location = new System.Drawing.Point(177, 437);
            this.txt_medical_officer.Name = "txt_medical_officer";
            this.txt_medical_officer.Size = new System.Drawing.Size(337, 24);
            this.txt_medical_officer.TabIndex = 13;
            this.txt_medical_officer.Visible = false;
            // 
            // btn_reset_appointment
            // 
            this.btn_reset_appointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(201)))));
            this.btn_reset_appointment.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_reset_appointment.FlatAppearance.BorderSize = 0;
            this.btn_reset_appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset_appointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_reset_appointment.ForeColor = System.Drawing.Color.Black;
            this.btn_reset_appointment.Location = new System.Drawing.Point(183, 608);
            this.btn_reset_appointment.Name = "btn_reset_appointment";
            this.btn_reset_appointment.Size = new System.Drawing.Size(152, 55);
            this.btn_reset_appointment.TabIndex = 11;
            this.btn_reset_appointment.Text = "Reset";
            this.btn_reset_appointment.UseVisualStyleBackColor = false;
            this.btn_reset_appointment.Click += new System.EventHandler(this.btn_reset_appointment_Click);
            // 
            // comboBox_status
            // 
            this.comboBox_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] {
            "Available",
            "Pending",
            "Confirmed",
            "Rejected",
            "Completed"});
            this.comboBox_status.Location = new System.Drawing.Point(178, 386);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(182, 28);
            this.comboBox_status.TabIndex = 12;
            // 
            // btn_add_appointment
            // 
            this.btn_add_appointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(246)))));
            this.btn_add_appointment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_add_appointment.FlatAppearance.BorderSize = 0;
            this.btn_add_appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_appointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_appointment.ForeColor = System.Drawing.Color.Black;
            this.btn_add_appointment.Location = new System.Drawing.Point(14, 533);
            this.btn_add_appointment.Name = "btn_add_appointment";
            this.btn_add_appointment.Size = new System.Drawing.Size(152, 55);
            this.btn_add_appointment.TabIndex = 10;
            this.btn_add_appointment.Text = "Add Appointment";
            this.btn_add_appointment.UseVisualStyleBackColor = false;
            this.btn_add_appointment.Click += new System.EventHandler(this.btn_add_appointment_Click);
            // 
            // btn_edit_appointment
            // 
            this.btn_edit_appointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btn_edit_appointment.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_edit_appointment.FlatAppearance.BorderSize = 0;
            this.btn_edit_appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_appointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_edit_appointment.ForeColor = System.Drawing.Color.Black;
            this.btn_edit_appointment.Location = new System.Drawing.Point(183, 533);
            this.btn_edit_appointment.Name = "btn_edit_appointment";
            this.btn_edit_appointment.Size = new System.Drawing.Size(152, 55);
            this.btn_edit_appointment.TabIndex = 9;
            this.btn_edit_appointment.Text = "Edit Appointment";
            this.btn_edit_appointment.UseVisualStyleBackColor = false;
            this.btn_edit_appointment.Click += new System.EventHandler(this.btn_edit_appointment_Click);
            // 
            // btn_delete_appointment
            // 
            this.btn_delete_appointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(244)))), ((int)(((byte)(179)))));
            this.btn_delete_appointment.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_delete_appointment.FlatAppearance.BorderSize = 0;
            this.btn_delete_appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_appointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_delete_appointment.ForeColor = System.Drawing.Color.Black;
            this.btn_delete_appointment.Location = new System.Drawing.Point(362, 533);
            this.btn_delete_appointment.Name = "btn_delete_appointment";
            this.btn_delete_appointment.Size = new System.Drawing.Size(152, 55);
            this.btn_delete_appointment.TabIndex = 8;
            this.btn_delete_appointment.Text = "Delete Appointment";
            this.btn_delete_appointment.UseVisualStyleBackColor = false;
            this.btn_delete_appointment.Click += new System.EventHandler(this.btn_delete_appointment_Click);
            // 
            // dateTimePicker_time
            // 
            this.dateTimePicker_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_time.Location = new System.Drawing.Point(178, 341);
            this.dateTimePicker_time.Name = "dateTimePicker_time";
            this.dateTimePicker_time.Size = new System.Drawing.Size(182, 26);
            this.dateTimePicker_time.TabIndex = 5;
            this.dateTimePicker_time.Value = new System.DateTime(2021, 9, 19, 20, 3, 0, 0);
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_date.Location = new System.Drawing.Point(178, 295);
            this.dateTimePicker_date.MaxDate = new System.DateTime(2021, 9, 19, 0, 0, 0, 0);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(182, 26);
            this.dateTimePicker_date.TabIndex = 4;
            this.dateTimePicker_date.Value = new System.DateTime(2021, 9, 19, 0, 0, 0, 0);
            // 
            // txt_symptoms
            // 
            this.txt_symptoms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_symptoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_symptoms.Location = new System.Drawing.Point(178, 143);
            this.txt_symptoms.Multiline = true;
            this.txt_symptoms.Name = "txt_symptoms";
            this.txt_symptoms.Size = new System.Drawing.Size(336, 88);
            this.txt_symptoms.TabIndex = 2;
            // 
            // txt_patient_name
            // 
            this.txt_patient_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_patient_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_name.Location = new System.Drawing.Point(178, 101);
            this.txt_patient_name.Name = "txt_patient_name";
            this.txt_patient_name.Size = new System.Drawing.Size(336, 24);
            this.txt_patient_name.TabIndex = 1;
            // 
            // txt_appointment_no
            // 
            this.txt_appointment_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_appointment_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_appointment_no.Location = new System.Drawing.Point(179, 59);
            this.txt_appointment_no.Name = "txt_appointment_no";
            this.txt_appointment_no.Size = new System.Drawing.Size(335, 24);
            this.txt_appointment_no.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Medical Officer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Symptoms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Patient Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment No";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.dgvAppointment);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(539, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(483, 685);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment Schedule";
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.AllowUserToAddRows = false;
            this.dgvAppointment.AllowUserToDeleteRows = false;
            this.dgvAppointment.AllowUserToResizeRows = false;
            this.dgvAppointment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAppointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAppointment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.app_id,
            this.appointment_no,
            this.patient,
            this.symptoms,
            this.medical_officer,
            this.app_date,
            this.app_time,
            this.status});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointment.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAppointment.EnableHeadersVisualStyles = false;
            this.dgvAppointment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAppointment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAppointment.Location = new System.Drawing.Point(6, 185);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.ReadOnly = true;
            this.dgvAppointment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointment.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAppointment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointment.Size = new System.Drawing.Size(471, 494);
            this.dgvAppointment.TabIndex = 4;
            this.dgvAppointment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointment_CellClick);
            // 
            // app_id
            // 
            this.app_id.DataPropertyName = "app_id";
            this.app_id.HeaderText = "App ID";
            this.app_id.Name = "app_id";
            this.app_id.ReadOnly = true;
            this.app_id.Width = 85;
            // 
            // appointment_no
            // 
            this.appointment_no.DataPropertyName = "appointment_no";
            this.appointment_no.HeaderText = "Appointment No";
            this.appointment_no.Name = "appointment_no";
            this.appointment_no.ReadOnly = true;
            this.appointment_no.Width = 120;
            // 
            // patient
            // 
            this.patient.DataPropertyName = "patient";
            this.patient.HeaderText = "Patient";
            this.patient.Name = "patient";
            this.patient.ReadOnly = true;
            // 
            // symptoms
            // 
            this.symptoms.DataPropertyName = "symptoms";
            this.symptoms.HeaderText = "Symptoms";
            this.symptoms.Name = "symptoms";
            this.symptoms.ReadOnly = true;
            // 
            // medical_officer
            // 
            this.medical_officer.DataPropertyName = "medical_officer";
            this.medical_officer.HeaderText = "Medical Officer";
            this.medical_officer.Name = "medical_officer";
            this.medical_officer.ReadOnly = true;
            this.medical_officer.Width = 115;
            // 
            // app_date
            // 
            this.app_date.DataPropertyName = "app_date";
            this.app_date.HeaderText = "Date";
            this.app_date.Name = "app_date";
            this.app_date.ReadOnly = true;
            this.app_date.Width = 90;
            // 
            // app_time
            // 
            this.app_time.DataPropertyName = "app_time";
            this.app_time.HeaderText = "Time";
            this.app_time.Name = "app_time";
            this.app_time.ReadOnly = true;
            this.app_time.Width = 85;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbSerarchStatus);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearchByAppNo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(6, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 125);
            this.panel1.TabIndex = 3;
            // 
            // cmbSerarchStatus
            // 
            this.cmbSerarchStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSerarchStatus.FormattingEnabled = true;
            this.cmbSerarchStatus.Items.AddRange(new object[] {
            "Available",
            "Pending",
            "Confirmed",
            "Rejected",
            "Completed"});
            this.cmbSerarchStatus.Location = new System.Drawing.Point(173, 60);
            this.cmbSerarchStatus.Name = "cmbSerarchStatus";
            this.cmbSerarchStatus.Size = new System.Drawing.Size(178, 28);
            this.cmbSerarchStatus.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Status";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(367, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 33);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchByAppNo
            // 
            this.txtSearchByAppNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByAppNo.Location = new System.Drawing.Point(173, 19);
            this.txtSearchByAppNo.Name = "txtSearchByAppNo";
            this.txtSearchByAppNo.Size = new System.Drawing.Size(178, 24);
            this.txtSearchByAppNo.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(14, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Enter Appointment No";
            // 
            // epAppointment
            // 
            this.epAppointment.ContainerControl = this;
            // 
            // ucAppointment_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucAppointment_PL";
            this.Size = new System.Drawing.Size(1024, 691);
            this.Load += new System.EventHandler(this.ucAppointment_PL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epAppointment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_appointment_no;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_patient_name;
        private System.Windows.Forms.TextBox txt_symptoms;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Button btn_add_appointment;
        private System.Windows.Forms.Button btn_edit_appointment;
        private System.Windows.Forms.Button btn_delete_appointment;
        private System.Windows.Forms.DateTimePicker dateTimePicker_time;
        private System.Windows.Forms.TextBox txt_medical_officer;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_reset_appointment;
        private System.Windows.Forms.TextBox txt_app_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchByAppNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider epAppointment;
        private System.Windows.Forms.ComboBox cmb_medical_officer;
        private System.Windows.Forms.ComboBox cmbSerarchStatus;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroGrid dgvAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn app_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointment_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn symptoms;
        private System.Windows.Forms.DataGridViewTextBoxColumn medical_officer;
        private System.Windows.Forms.DataGridViewTextBoxColumn app_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn app_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}
