
namespace HospitalInformationManagementSystem.PL
{
    partial class ucComplaint_PL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbComplaintForm = new System.Windows.Forms.GroupBox();
            this.btnComplaintViewFile = new MetroFramework.Controls.MetroButton();
            this.txtCompID = new System.Windows.Forms.TextBox();
            this.btnComplaintBrowse = new MetroFramework.Controls.MetroButton();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbComplaintCategory = new System.Windows.Forms.ComboBox();
            this.cmbComplaintType = new System.Windows.Forms.ComboBox();
            this.txtActionTaken = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComplaintBy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdComplaints = new System.Windows.Forms.OpenFileDialog();
            this.epComplaints = new System.Windows.Forms.ErrorProvider(this.components);
            this.sfdComplaints = new System.Windows.Forms.SaveFileDialog();
            this.grbComplaintData = new System.Windows.Forms.GroupBox();
            this.dgvComplaints = new MetroFramework.Controls.MetroGrid();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_taken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comp_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comp_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nic_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attachment_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attachment_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complaint_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddComplaint = new MetroFramework.Controls.MetroButton();
            this.btnEditComplaint = new MetroFramework.Controls.MetroButton();
            this.btnDeleteComplaint = new MetroFramework.Controls.MetroButton();
            this.grbComplaintForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epComplaints)).BeginInit();
            this.grbComplaintData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaints)).BeginInit();
            this.SuspendLayout();
            // 
            // grbComplaintForm
            // 
            this.grbComplaintForm.BackColor = System.Drawing.Color.White;
            this.grbComplaintForm.Controls.Add(this.btnDeleteComplaint);
            this.grbComplaintForm.Controls.Add(this.btnEditComplaint);
            this.grbComplaintForm.Controls.Add(this.btnAddComplaint);
            this.grbComplaintForm.Controls.Add(this.btnComplaintViewFile);
            this.grbComplaintForm.Controls.Add(this.txtCompID);
            this.grbComplaintForm.Controls.Add(this.btnComplaintBrowse);
            this.grbComplaintForm.Controls.Add(this.label10);
            this.grbComplaintForm.Controls.Add(this.dtpDate);
            this.grbComplaintForm.Controls.Add(this.txtNote);
            this.grbComplaintForm.Controls.Add(this.txtDescription);
            this.grbComplaintForm.Controls.Add(this.txtNIC);
            this.grbComplaintForm.Controls.Add(this.label7);
            this.grbComplaintForm.Controls.Add(this.label2);
            this.grbComplaintForm.Controls.Add(this.label6);
            this.grbComplaintForm.Controls.Add(this.label9);
            this.grbComplaintForm.Controls.Add(this.label5);
            this.grbComplaintForm.Controls.Add(this.label4);
            this.grbComplaintForm.Controls.Add(this.cmbComplaintCategory);
            this.grbComplaintForm.Controls.Add(this.cmbComplaintType);
            this.grbComplaintForm.Controls.Add(this.txtActionTaken);
            this.grbComplaintForm.Controls.Add(this.txtPhone);
            this.grbComplaintForm.Controls.Add(this.label8);
            this.grbComplaintForm.Controls.Add(this.txtComplaintBy);
            this.grbComplaintForm.Controls.Add(this.label3);
            this.grbComplaintForm.Controls.Add(this.label1);
            this.grbComplaintForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbComplaintForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbComplaintForm.ForeColor = System.Drawing.Color.Black;
            this.grbComplaintForm.Location = new System.Drawing.Point(0, 0);
            this.grbComplaintForm.Name = "grbComplaintForm";
            this.grbComplaintForm.Size = new System.Drawing.Size(510, 691);
            this.grbComplaintForm.TabIndex = 3;
            this.grbComplaintForm.TabStop = false;
            this.grbComplaintForm.Text = "Complaint Form";
            // 
            // btnComplaintViewFile
            // 
            this.btnComplaintViewFile.Location = new System.Drawing.Point(310, 573);
            this.btnComplaintViewFile.Name = "btnComplaintViewFile";
            this.btnComplaintViewFile.Size = new System.Drawing.Size(120, 32);
            this.btnComplaintViewFile.TabIndex = 17;
            this.btnComplaintViewFile.Text = "View File";
            this.btnComplaintViewFile.UseSelectable = true;
            this.btnComplaintViewFile.Visible = false;
            this.btnComplaintViewFile.Click += new System.EventHandler(this.BtnComplaintViewFile_Click);
            // 
            // txtCompID
            // 
            this.txtCompID.Location = new System.Drawing.Point(9, 527);
            this.txtCompID.Name = "txtCompID";
            this.txtCompID.Size = new System.Drawing.Size(100, 29);
            this.txtCompID.TabIndex = 16;
            this.txtCompID.Visible = false;
            // 
            // btnComplaintBrowse
            // 
            this.btnComplaintBrowse.Location = new System.Drawing.Point(151, 573);
            this.btnComplaintBrowse.Name = "btnComplaintBrowse";
            this.btnComplaintBrowse.Size = new System.Drawing.Size(120, 32);
            this.btnComplaintBrowse.TabIndex = 15;
            this.btnComplaintBrowse.Text = "Browse";
            this.btnComplaintBrowse.UseSelectable = true;
            this.btnComplaintBrowse.Click += new System.EventHandler(this.BtnComplaintBrowse_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 578);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Attachment";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(151, 274);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(111, 24);
            this.dtpDate.TabIndex = 11;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(151, 466);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(337, 90);
            this.txtNote.TabIndex = 10;
            this.txtNote.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(151, 165);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(337, 90);
            this.txtDescription.TabIndex = 10;
            // 
            // txtNIC
            // 
            this.txtNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIC.Location = new System.Drawing.Point(151, 317);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(337, 24);
            this.txtNIC.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Note";
            this.label2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Action Taken";
            this.label9.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "NIC";
            // 
            // cmbComplaintCategory
            // 
            this.cmbComplaintCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComplaintCategory.FormattingEnabled = true;
            this.cmbComplaintCategory.Location = new System.Drawing.Point(151, 120);
            this.cmbComplaintCategory.Name = "cmbComplaintCategory";
            this.cmbComplaintCategory.Size = new System.Drawing.Size(337, 26);
            this.cmbComplaintCategory.TabIndex = 4;
            // 
            // cmbComplaintType
            // 
            this.cmbComplaintType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComplaintType.FormattingEnabled = true;
            this.cmbComplaintType.Location = new System.Drawing.Point(151, 76);
            this.cmbComplaintType.Name = "cmbComplaintType";
            this.cmbComplaintType.Size = new System.Drawing.Size(337, 26);
            this.cmbComplaintType.TabIndex = 4;
            this.cmbComplaintType.SelectedValueChanged += new System.EventHandler(this.cmbComplaintType_SelectedValueChanged);
            // 
            // txtActionTaken
            // 
            this.txtActionTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActionTaken.Location = new System.Drawing.Point(151, 399);
            this.txtActionTaken.Multiline = true;
            this.txtActionTaken.Name = "txtActionTaken";
            this.txtActionTaken.Size = new System.Drawing.Size(337, 56);
            this.txtActionTaken.TabIndex = 1;
            this.txtActionTaken.Visible = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(151, 360);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(337, 24);
            this.txtPhone.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Complaint Category";
            // 
            // txtComplaintBy
            // 
            this.txtComplaintBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplaintBy.Location = new System.Drawing.Point(151, 35);
            this.txtComplaintBy.Name = "txtComplaintBy";
            this.txtComplaintBy.Size = new System.Drawing.Size(337, 24);
            this.txtComplaintBy.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Complaint Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complaint By";
            // 
            // ofdComplaints
            // 
            this.ofdComplaints.FileName = "ofdComplaints";
            this.ofdComplaints.Filter = "PDF document (*.pdf)|*.pdf";
            // 
            // epComplaints
            // 
            this.epComplaints.ContainerControl = this;
            // 
            // sfdComplaints
            // 
            this.sfdComplaints.Filter = "PDF document (*.pdf)|*.pdf";
            // 
            // grbComplaintData
            // 
            this.grbComplaintData.BackColor = System.Drawing.Color.White;
            this.grbComplaintData.Controls.Add(this.dgvComplaints);
            this.grbComplaintData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbComplaintData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.grbComplaintData.Location = new System.Drawing.Point(510, 0);
            this.grbComplaintData.Name = "grbComplaintData";
            this.grbComplaintData.Size = new System.Drawing.Size(514, 691);
            this.grbComplaintData.TabIndex = 0;
            this.grbComplaintData.TabStop = false;
            this.grbComplaintData.Text = "Complaint Data";
            // 
            // dgvComplaints
            // 
            this.dgvComplaints.AllowUserToResizeRows = false;
            this.dgvComplaints.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvComplaints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComplaints.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvComplaints.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComplaints.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComplaints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comp_id,
            this.complaint_category,
            this.attachment_type,
            this.attachment_data,
            this.nic_no,
            this.comp_by,
            this.comp_type,
            this.phone_no,
            this.date,
            this.description,
            this.action_taken,
            this.note,
            this.user_id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComplaints.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComplaints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComplaints.EnableHeadersVisualStyles = false;
            this.dgvComplaints.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvComplaints.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvComplaints.Location = new System.Drawing.Point(3, 25);
            this.dgvComplaints.Name = "dgvComplaints";
            this.dgvComplaints.ReadOnly = true;
            this.dgvComplaints.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComplaints.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvComplaints.RowHeadersWidth = 45;
            this.dgvComplaints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplaints.Size = new System.Drawing.Size(508, 663);
            this.dgvComplaints.TabIndex = 0;
            this.dgvComplaints.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvComplaints_CellClick);
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "User ID";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Visible = false;
            // 
            // note
            // 
            this.note.DataPropertyName = "note";
            this.note.HeaderText = "Note";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            this.note.Visible = false;
            // 
            // action_taken
            // 
            this.action_taken.DataPropertyName = "action_taken";
            this.action_taken.HeaderText = "Action Taken";
            this.action_taken.Name = "action_taken";
            this.action_taken.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // phone_no
            // 
            this.phone_no.DataPropertyName = "phone_no";
            this.phone_no.HeaderText = "Phone No";
            this.phone_no.Name = "phone_no";
            this.phone_no.ReadOnly = true;
            this.phone_no.Visible = false;
            // 
            // comp_type
            // 
            this.comp_type.DataPropertyName = "comp_type";
            this.comp_type.HeaderText = "Complaint Type";
            this.comp_type.Name = "comp_type";
            this.comp_type.ReadOnly = true;
            // 
            // comp_by
            // 
            this.comp_by.DataPropertyName = "comp_by";
            this.comp_by.HeaderText = "Complaint By";
            this.comp_by.Name = "comp_by";
            this.comp_by.ReadOnly = true;
            // 
            // nic_no
            // 
            this.nic_no.DataPropertyName = "nic_no";
            this.nic_no.HeaderText = "Nic";
            this.nic_no.Name = "nic_no";
            this.nic_no.ReadOnly = true;
            this.nic_no.Visible = false;
            // 
            // attachment_data
            // 
            this.attachment_data.DataPropertyName = "attachment_data";
            this.attachment_data.HeaderText = "Attachment Data";
            this.attachment_data.Name = "attachment_data";
            this.attachment_data.ReadOnly = true;
            this.attachment_data.Visible = false;
            // 
            // attachment_type
            // 
            this.attachment_type.DataPropertyName = "attachment_type";
            this.attachment_type.HeaderText = "Attachment Type";
            this.attachment_type.Name = "attachment_type";
            this.attachment_type.ReadOnly = true;
            this.attachment_type.Visible = false;
            // 
            // complaint_category
            // 
            this.complaint_category.DataPropertyName = "complaint_category";
            this.complaint_category.HeaderText = "Complaint Category";
            this.complaint_category.Name = "complaint_category";
            this.complaint_category.ReadOnly = true;
            this.complaint_category.Visible = false;
            // 
            // comp_id
            // 
            this.comp_id.DataPropertyName = "comp_id";
            this.comp_id.HeaderText = "Complaint ID";
            this.comp_id.Name = "comp_id";
            this.comp_id.ReadOnly = true;
            // 
            // btnAddComplaint
            // 
            this.btnAddComplaint.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAddComplaint.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAddComplaint.Location = new System.Drawing.Point(6, 625);
            this.btnAddComplaint.Name = "btnAddComplaint";
            this.btnAddComplaint.Size = new System.Drawing.Size(141, 47);
            this.btnAddComplaint.TabIndex = 18;
            this.btnAddComplaint.Text = "Add Complaint";
            this.btnAddComplaint.UseSelectable = true;
            this.btnAddComplaint.Click += new System.EventHandler(this.BtnAddComplaint_Click);
            // 
            // btnEditComplaint
            // 
            this.btnEditComplaint.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEditComplaint.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnEditComplaint.Location = new System.Drawing.Point(177, 625);
            this.btnEditComplaint.Name = "btnEditComplaint";
            this.btnEditComplaint.Size = new System.Drawing.Size(141, 47);
            this.btnEditComplaint.TabIndex = 19;
            this.btnEditComplaint.Text = "Edit Complaint";
            this.btnEditComplaint.UseSelectable = true;
            this.btnEditComplaint.Click += new System.EventHandler(this.BtnEditComplaint_Click);
            // 
            // btnDeleteComplaint
            // 
            this.btnDeleteComplaint.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDeleteComplaint.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDeleteComplaint.Location = new System.Drawing.Point(347, 625);
            this.btnDeleteComplaint.Name = "btnDeleteComplaint";
            this.btnDeleteComplaint.Size = new System.Drawing.Size(141, 47);
            this.btnDeleteComplaint.TabIndex = 20;
            this.btnDeleteComplaint.Text = "Delete Complaint";
            this.btnDeleteComplaint.UseSelectable = true;
            this.btnDeleteComplaint.Click += new System.EventHandler(this.BtnDeleteComplaint_Click);
            // 
            // ucComplaint_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbComplaintData);
            this.Controls.Add(this.grbComplaintForm);
            this.Name = "ucComplaint_PL";
            this.Size = new System.Drawing.Size(1024, 691);
            this.Load += new System.EventHandler(this.ucComplaint_PL_Load);
            this.grbComplaintForm.ResumeLayout(false);
            this.grbComplaintForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epComplaints)).EndInit();
            this.grbComplaintData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbComplaintForm;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbComplaintType;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtComplaintBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbComplaintCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtActionTaken;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroButton btnComplaintBrowse;
        private System.Windows.Forms.OpenFileDialog ofdComplaints;
        private System.Windows.Forms.ErrorProvider epComplaints;
        private System.Windows.Forms.TextBox txtCompID;
        private System.Windows.Forms.SaveFileDialog sfdComplaints;
        private MetroFramework.Controls.MetroButton btnComplaintViewFile;
        private System.Windows.Forms.GroupBox grbComplaintData;
        private MetroFramework.Controls.MetroGrid dgvComplaints;
        private System.Windows.Forms.DataGridViewTextBoxColumn comp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn complaint_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn attachment_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn attachment_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn nic_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn comp_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn comp_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_taken;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private MetroFramework.Controls.MetroButton btnAddComplaint;
        private MetroFramework.Controls.MetroButton btnDeleteComplaint;
        private MetroFramework.Controls.MetroButton btnEditComplaint;
    }
}
