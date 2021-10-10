namespace HospitalInformationManagementSystem.InformationPL
{
    partial class frmNotification
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
            this.components = new System.ComponentModel.Container();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbNotification = new System.Windows.Forms.PictureBox();
            this.tmrSuccess = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbNotification)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(82, 35);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(132, 22);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message Text";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::HospitalInformationManagementSystem.Properties.Resources.Cancel_25px;
            this.btnClose.Location = new System.Drawing.Point(310, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 41);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbNotification
            // 
            this.pbNotification.Image = global::HospitalInformationManagementSystem.Properties.Resources.Success;
            this.pbNotification.Location = new System.Drawing.Point(12, 17);
            this.pbNotification.Name = "pbNotification";
            this.pbNotification.Size = new System.Drawing.Size(50, 50);
            this.pbNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNotification.TabIndex = 2;
            this.pbNotification.TabStop = false;
            // 
            // tmrSuccess
            // 
            this.tmrSuccess.Tick += new System.EventHandler(this.tmrSuccess_Tick);
            // 
            // frmSuccess
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(373, 84);
            this.Controls.Add(this.pbNotification);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSuccess";
            this.Text = "frmSuccess";
            ((System.ComponentModel.ISupportInitialize)(this.pbNotification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbNotification;
        private System.Windows.Forms.Timer tmrSuccess;
    }
}