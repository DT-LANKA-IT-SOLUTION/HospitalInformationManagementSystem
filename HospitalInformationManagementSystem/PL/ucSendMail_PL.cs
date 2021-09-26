using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace HospitalInformationManagementSystem.PL
{
    public partial class ucSendMail_PL : Form
    {
        OpenFileDialog attachment;
        string filename = "";

        public ucSendMail_PL()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient clientDetails = new SmtpClient();
                //clientDetails.Port = Convert.ToInt32(txt_server_port_number.Text.Trim());
                //clientDetails.Host = txt_smtp_server.Text.Trim();
                //clientDetails.EnableSsl = checkbox_ssl.Checked;
                clientDetails.Port = 587;
                clientDetails.Host = "smtp.gmail.com";
                clientDetails.EnableSsl = true;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.UseDefaultCredentials = false;
                clientDetails.Credentials = new NetworkCredential(txt_sender_email.Text.Trim(), txt_sender_password.Text.Trim());

                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress(txt_sender_email.Text.Trim());
                mailDetails.To.Add(txt_recipient_email.Text.Trim());
                mailDetails.Subject = txt_subject.Text.Trim();
                //mailDetails.IsBodyHtml = checkbox_ssl.Checked;
                mailDetails.IsBodyHtml = true;
                mailDetails.Body = txt_message.Text.Trim();

                if (filename.Length > 0)
                {
                    Attachment attch = new Attachment(filename);
                    mailDetails.Attachments.Add(attch);
                }

                clientDetails.Send(mailDetails);

                filename = "";

                ClearTextBoxes(this.Controls);

                MessageBox.Show("Your Email has been sent!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                attachment = new OpenFileDialog();
                attachment.Filter = "Images(.jpg, .png)|*.png;*.jpg;|Pdf File|* .pdf";
                if (attachment.ShowDialog() == DialogResult.OK)
                {
                    filename = attachment.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
