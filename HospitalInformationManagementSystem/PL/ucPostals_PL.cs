using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalInformationManagementSystem.Other;
using HospitalInformationManagementSystem.BLL;
using HospitalInformationManagementSystem.Model;
using System.IO;


namespace HospitalInformationManagementSystem.PL
{

    public partial class ucPostals_PL : UserControl
    {
        
        OpenFileDialog attachment;
        string FN = "";

        GrantUserPermission _grantUserPermission = new GrantUserPermission();

        Postal_BLL _postal_BLL = new Postal_BLL();

        PostalModel postalModel = new PostalModel();

        public ucPostals_PL()
        {
            InitializeComponent();
            //_grantUserPermission.GrantButtonPermission("receptionist", btn_postal_add, btn_postal_edit, btn_postal_delete);
        }

        private void UcPostal_PL_Load(object sender, EventArgs e)
        {
            this.FilDGVPostal();
            epPostal.Clear();
        }

        private void FilDGVPostal()
        {
            try
            {
                _postal_BLL.LoadAllPostalGridView(dgvPostal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_postal_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddPostal() > 0)
                {
                    MessageBox.Show("Postal add sucessfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.FilDGVPostal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int AddPostal()
        {
            try
            {   
                
                //get the file name, content type, and file data from the uploaded file

                /*
                FN = Path.GetFileName(fuimage.PostedFile.FileName);
                string contentType = fuimage.PostedFile.ContentType;
                Stream fs = attach.InputStream;
                BinaryReader br = new BinaryReader(fs);
                byte[] filebytes = br.ReadBytes((Int32)fs.Length);
                */

                //tried with some sample data. This part can be removed
                //FN = "img.jpg";
                //string contentType = ".jpg";
                //var data = "falcon\nhawk\nforest\ncloud\nsky";
                //byte[] filebytes = Encoding.UTF8.GetBytes(data);
                // end test data

                //asign values 
                postalModel.postal_type = comboBox_postal_type.SelectedItem.ToString();
                postalModel.ref_no = txt_refno.Text.Trim();
                postalModel.from_name = txt_from_to_name.Text.Trim();
                postalModel.address = txt_from_to_address.Text.Trim();
                postalModel.note = txt_note.Text.Trim();
                //this can be used to storo the upload file name. because we used from_name to store both from and to names.
                postalModel.to_name = FN;
                postalModel.date = Convert.ToDateTime(dateTimePicker1.Text.Trim());
                //postalModel.attachment_type = contentType; 
                //postalModel.attachment_data = Convert.ToBase64String(filebytes);
                postalModel.user_id = 1;

                

                return _postal_BLL.AddPostal(postalModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //upload the file
        private void btn_postal_attch_Click(object sender, EventArgs e)
        {
            try
            {
                ofdVisitor.InitialDirectory = @"C:\";
                ofdVisitor.RestoreDirectory = true;
                ofdVisitor.Title = "Browse Text Files";
                if (ofdVisitor.ShowDialog() == DialogResult.OK)
                {
                    postalModel.attachment_data = ofdVisitor.FileName;
                    postalModel.attachment_type = ofdVisitor.GetType().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPostal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
