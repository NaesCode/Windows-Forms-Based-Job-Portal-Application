using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Manager
{
    public partial class ValidateCompanyForm : Form
    {
        DatabaseSupport db = new DatabaseSupport();
        private int companyUserID;
        public ValidateCompanyForm(int companyUserID)
        {
            InitializeComponent();
            this.companyUserID = companyUserID;
        }

        private void submitBttn_Click(object sender, EventArgs e)
        {
            string status = "NEW";
            string hyperlink = "";

            if (IsValidUrl(website.Text))
            {
                string displayText = "Click Here";
                string companyWebsite = website.Text;
                string optionalSubAddress = "";
                hyperlink = $"{displayText}#{companyWebsite}#{optionalSubAddress}";
            }
            else
            {
                MessageBox.Show("Invalid URL. Please enter a valid URL.");
                website.Clear();
                return;
            }

            DateTime currentDate = DateTime.Now;

            byte[]? logoBytes = File.ReadAllBytes(companyLogo.Tag.ToString());
            byte[]? corBytes = File.ReadAllBytes(COR.Tag.ToString());
            byte[]? birrBytes = File.ReadAllBytes(BIRR.Tag.ToString());
            byte[]? mpBytes = File.ReadAllBytes(MP.Tag.ToString());

            db.insertValidationData(companyUserID, companyName.Text, Industry.Text, companyAddress.Text, hyperlink, contactPerson.Text, contactPosition.Text, contactNumber.Text, contactEmail.Text,
                                    companyLogo.Tag.ToString(), logoBytes, COR.Tag.ToString(), corBytes, BIRR.Tag.ToString(), birrBytes, MP.Tag.ToString(), mpBytes, currentDate, status);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void uploadLogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    companyLogo.Image = Image.FromFile(openFileDialog.FileName);
                    companyLogo.Tag = openFileDialog.FileName; // Store the file path in the Tag for later use
                }
            }
        }

        private void browseFileBttn1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF Files|*.pdf";
                openFileDialog.Title = "Select a PDF File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    COR.Text = openFileDialog.FileName;
                    COR.Tag = openFileDialog.FileName; // Store the file path in the textbox
                }
            }
        }

        private void browseFileBttn2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF Files|*.pdf";
                openFileDialog.Title = "Select a PDF File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    BIRR.Text = openFileDialog.FileName;
                    BIRR.Tag = openFileDialog.FileName; // Store the file path in the textbox
                }
            }
        }

        private void browseFileBttn3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF Files|*.pdf";
                openFileDialog.Title = "Select a PDF File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MP.Text = openFileDialog.FileName;
                    MP.Tag = openFileDialog.FileName; // Store the file path in the textbox
                }
            }
        }

        private bool IsValidUrl(string url) //checks if URL is valid
        {
            return Uri.TryCreate(url, UriKind.Absolute, out _);
        }
    }
}
