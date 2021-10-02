
namespace HospitalInformationManagementSystem.PL
{
    partial class ucPostals_PL
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_postal_id = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_postal_delete = new System.Windows.Forms.Button();
            this.btn_postal_edit = new System.Windows.Forms.Button();
            this.btn_postal_add = new System.Windows.Forms.Button();
            this.btnPostalAttch = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.txt_from_to_address = new System.Windows.Forms.TextBox();
            this.txt_from_to_name = new System.Windows.Forms.TextBox();
            this.txt_refno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_postal_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchByRefNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvPostal = new System.Windows.Forms.DataGridView();
            this.postal_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postal_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ref_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attachment_data = new System.Windows.Forms.DataGridViewImageColumn();
            this.epPostal = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofdVisitor = new System.Windows.Forms.OpenFileDialog();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPostal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.txt_postal_id);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btn_postal_delete);
            this.groupBox1.Controls.Add(this.btn_postal_edit);
            this.groupBox1.Controls.Add(this.btn_postal_add);
            this.groupBox1.Controls.Add(this.btnPostalAttch);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txt_note);
            this.groupBox1.Controls.Add(this.txt_from_to_address);
            this.groupBox1.Controls.Add(this.txt_from_to_name);
            this.groupBox1.Controls.Add(this.txt_refno);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_postal_type);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 685);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Postals Form";
            // 
            // txt_postal_id
            // 
            this.txt_postal_id.Location = new System.Drawing.Point(185, 16);
            this.txt_postal_id.Name = "txt_postal_id";
            this.txt_postal_id.Size = new System.Drawing.Size(306, 36);
            this.txt_postal_id.TabIndex = 16;
            this.txt_postal_id.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 529);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 36);
            this.textBox1.TabIndex = 15;
            // 
            // btn_postal_delete
            // 
            this.btn_postal_delete.BackColor = System.Drawing.Color.Red;
            this.btn_postal_delete.Location = new System.Drawing.Point(385, 577);
            this.btn_postal_delete.Name = "btn_postal_delete";
            this.btn_postal_delete.Size = new System.Drawing.Size(112, 47);
            this.btn_postal_delete.TabIndex = 14;
            this.btn_postal_delete.Text = "Delete";
            this.btn_postal_delete.UseVisualStyleBackColor = false;
            this.btn_postal_delete.Click += new System.EventHandler(this.btn_postal_delete_Click);
            // 
            // btn_postal_edit
            // 
            this.btn_postal_edit.BackColor = System.Drawing.Color.Yellow;
            this.btn_postal_edit.Location = new System.Drawing.Point(151, 577);
            this.btn_postal_edit.Name = "btn_postal_edit";
            this.btn_postal_edit.Size = new System.Drawing.Size(112, 47);
            this.btn_postal_edit.TabIndex = 14;
            this.btn_postal_edit.Text = "Edit";
            this.btn_postal_edit.UseVisualStyleBackColor = false;
            this.btn_postal_edit.Click += new System.EventHandler(this.btn_postal_edit_Click);
            // 
            // btn_postal_add
            // 
            this.btn_postal_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_postal_add.Location = new System.Drawing.Point(33, 577);
            this.btn_postal_add.Name = "btn_postal_add";
            this.btn_postal_add.Size = new System.Drawing.Size(112, 47);
            this.btn_postal_add.TabIndex = 13;
            this.btn_postal_add.Text = "Add";
            this.btn_postal_add.UseVisualStyleBackColor = false;
            this.btn_postal_add.Click += new System.EventHandler(this.btn_postal_add_Click);
            // 
            // btnPostalAttch
            // 
            this.btnPostalAttch.BackColor = System.Drawing.Color.Blue;
            this.btnPostalAttch.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostalAttch.ForeColor = System.Drawing.Color.White;
            this.btnPostalAttch.Location = new System.Drawing.Point(183, 458);
            this.btnPostalAttch.Name = "btnPostalAttch";
            this.btnPostalAttch.Size = new System.Drawing.Size(112, 47);
            this.btnPostalAttch.TabIndex = 12;
            this.btnPostalAttch.Text = "Attach";
            this.btnPostalAttch.UseVisualStyleBackColor = false;
            this.btnPostalAttch.Click += new System.EventHandler(this.btn_postal_attch_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 417);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(306, 30);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(185, 229);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(306, 175);
            this.txt_note.TabIndex = 7;
            // 
            // txt_from_to_address
            // 
            this.txt_from_to_address.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_from_to_address.Location = new System.Drawing.Point(185, 186);
            this.txt_from_to_address.Name = "txt_from_to_address";
            this.txt_from_to_address.Size = new System.Drawing.Size(306, 30);
            this.txt_from_to_address.TabIndex = 6;
            // 
            // txt_from_to_name
            // 
            this.txt_from_to_name.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_from_to_name.Location = new System.Drawing.Point(185, 144);
            this.txt_from_to_name.Name = "txt_from_to_name";
            this.txt_from_to_name.Size = new System.Drawing.Size(306, 30);
            this.txt_from_to_name.TabIndex = 6;
            // 
            // txt_refno
            // 
            this.txt_refno.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_refno.Location = new System.Drawing.Point(185, 102);
            this.txt_refno.Name = "txt_refno";
            this.txt_refno.Size = new System.Drawing.Size(306, 30);
            this.txt_refno.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "Attachment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Note";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "From/ To Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "From/ To Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ref No";
            // 
            // comboBox_postal_type
            // 
            this.comboBox_postal_type.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_postal_type.FormattingEnabled = true;
            this.comboBox_postal_type.Items.AddRange(new object[] {
            "Postal Recieved",
            "Postal Dispatch"});
            this.comboBox_postal_type.Location = new System.Drawing.Point(185, 58);
            this.comboBox_postal_type.Name = "comboBox_postal_type";
            this.comboBox_postal_type.Size = new System.Drawing.Size(306, 34);
            this.comboBox_postal_type.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Postal Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.dgvPostal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(517, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 685);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Postal View";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearchByRefNo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(6, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 43);
            this.panel1.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Silver;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(357, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 33);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchByRefNo
            // 
            this.txtSearchByRefNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByRefNo.Location = new System.Drawing.Point(114, 7);
            this.txtSearchByRefNo.Name = "txtSearchByRefNo";
            this.txtSearchByRefNo.Size = new System.Drawing.Size(237, 24);
            this.txtSearchByRefNo.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(14, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Enter Ref No";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dgvPostal
            // 
            this.dgvPostal.AllowUserToAddRows = false;
            this.dgvPostal.AllowUserToDeleteRows = false;
            this.dgvPostal.AllowUserToOrderColumns = true;
            this.dgvPostal.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPostal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.postal_id,
            this.Postal_type,
            this.ref_no,
            this.from_name,
            this.address,
            this.note,
            this.date,
            this.attachment_data});
            this.dgvPostal.Location = new System.Drawing.Point(5, 82);
            this.dgvPostal.Name = "dgvPostal";
            this.dgvPostal.ReadOnly = true;
            this.dgvPostal.Size = new System.Drawing.Size(493, 602);
            this.dgvPostal.TabIndex = 1;
            this.dgvPostal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPostal_CellContentClick);
            // 
            // postal_id
            // 
            this.postal_id.DataPropertyName = "postal_id";
            this.postal_id.HeaderText = "ID";
            this.postal_id.Name = "postal_id";
            this.postal_id.ReadOnly = true;
            // 
            // Postal_type
            // 
            this.Postal_type.DataPropertyName = "postal_type";
            this.Postal_type.HeaderText = "Postal Type";
            this.Postal_type.Name = "Postal_type";
            this.Postal_type.ReadOnly = true;
            // 
            // ref_no
            // 
            this.ref_no.DataPropertyName = "ref_no";
            this.ref_no.HeaderText = "Ref No";
            this.ref_no.Name = "ref_no";
            this.ref_no.ReadOnly = true;
            // 
            // from_name
            // 
            this.from_name.DataPropertyName = "from_name";
            this.from_name.HeaderText = "From/ To Name";
            this.from_name.Name = "from_name";
            this.from_name.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // note
            // 
            this.note.DataPropertyName = "note";
            this.note.HeaderText = "Note";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // attachment_data
            // 
            this.attachment_data.DataPropertyName = "attachment_data";
            this.attachment_data.HeaderText = "Attachment";
            this.attachment_data.Name = "attachment_data";
            this.attachment_data.ReadOnly = true;
            this.attachment_data.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.attachment_data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // epPostal
            // 
            this.epPostal.ContainerControl = this;
            // 
            // ofdVisitor
            // 
            this.ofdVisitor.FileName = "ofdVisitor";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Silver;
            this.btn_clear.Location = new System.Drawing.Point(267, 577);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(112, 47);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // ucPostals_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucPostals_PL";
            this.Size = new System.Drawing.Size(1024, 691);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPostal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_postal_type;
        private System.Windows.Forms.TextBox txt_refno;
        private System.Windows.Forms.Button btnPostalAttch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.TextBox txt_from_to_address;
        private System.Windows.Forms.TextBox txt_from_to_name;
        private System.Windows.Forms.Button btn_postal_edit;
        private System.Windows.Forms.Button btn_postal_add;
        private System.Windows.Forms.Button btn_postal_delete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPostal;
        private System.Windows.Forms.ErrorProvider epPostal;
        private System.Windows.Forms.OpenFileDialog ofdVisitor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchByRefNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_postal_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn postal_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postal_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ref_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn from_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewImageColumn attachment_data;
        private System.Windows.Forms.Button btn_clear;
    }
}
