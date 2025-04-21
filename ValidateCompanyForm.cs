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
        private DatabaseSupport dbSupport = new DatabaseSupport();
        private int companyUserID;
        private byte[]? imageData;

        /// Constructor for the form when used to register a new company
        public ValidateCompanyForm(int companyUserID)
        {
            InitializeComponent();
            this.companyUserID = companyUserID;
        }

        /// Constructor for the form when used to request an update
        public ValidateCompanyForm(Dictionary<string, object?> companyData, int companyID)
        {
            InitializeComponent();
            this.companyUserID = companyID;

            submitBttn.Visible = false;
            requestUpdateBttn.Visible = true;
            requestUpdateBttn.Location = new Point(33, 538);

            this.Text = "Request for Update";
            label1.Text = "UPDATE COMPANY DETAILS";
            browseFileBttn1.Enabled = false;
            browseFileBttn2.Enabled = false;
            browseFileBttn3.Enabled = false;
            COR.Text = "Update Restricted";
            BIRR.Text = "Update Restricted";
            MP.Text = "Update Restricted";
            COR.Enabled = false;
            BIRR.Enabled = false;
            MP.Enabled = false;

            imageData = dbSupport.DisplayCompanyLogo(companyUserID);

            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    companyLogo.Image = Image.FromStream(ms);
                }
            }

            contactNumber.Text = companyData?["Contact Number"]?.ToString();
            contactNumber.Text = companyData?["Contact Number"]?.ToString();
            contactNumber.Text = companyData?["Contact Number"]?.ToString();
            contactNumber.Text = companyData?["Contact Number"]?.ToString();
            contactNumber.Text = companyData?["Contact Number"]?.ToString();
            contactNumber.Text = companyData?["Contact Number"]?.ToString();
            contactNumber.Text = companyData?["Contact Number"]?.ToString();
            contactNumber.Text = companyData?["Contact Number"]?.ToString();

            companyName.Enter += Cell_Enter;
            Industry.Enter += Cell_Enter;
            companyAddress.Enter += Cell_Enter;
            website.Enter += Cell_Enter;
            contactPerson.Enter += Cell_Enter;
            contactPosition.Enter += Cell_Enter;
            contactNumber.Enter += Cell_Enter;
            contactEmail.Enter += Cell_Enter;
        }

        /// Constructor for the form when used to update company details which is done by the Admin
        public ValidateCompanyForm(Dictionary<string, object>? companyData, int companyID, string AdminUser)
        {
            InitializeComponent();
            this.companyUserID = companyID;

            submitBttn.Visible = false;
            UpdateBttn.Visible = true;
            UpdateBttn.Location = new Point(59, 538);

            this.Text = AdminUser + " Operation: " + "Update Company Details";
            label1.Text = "UPDATE COMPANY DETAILS";
            browseFileBttn1.Enabled = false;
            browseFileBttn2.Enabled = false;
            browseFileBttn3.Enabled = false;
            COR.Text = "Update Restricted";
            BIRR.Text = "Update Restricted";
            MP.Text = "Update Restricted";
            COR.Enabled = false;
            BIRR.Enabled = false;
            MP.Enabled = false;

            imageData = dbSupport.DisplayCompanyLogo(companyUserID);

            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    companyLogo.Image = Image.FromStream(ms);
                }
            }

            companyName.Text = companyData?["Company Name"].ToString();
            Industry.Text = companyData?["Industry"].ToString();
            companyAddress.Text = companyData?["Company Address"].ToString();
            website.Text = companyData?["Company Website"].ToString();
            contactPerson.Text = companyData?["Contact Person Name"].ToString();
            contactPosition.Text = companyData?["Contact Person Position"].ToString();
            contactNumber.Text = companyData?["Contact Number"].ToString();
            contactEmail.Text = companyData?["Contact Email"].ToString();

            companyName.Enter += Cell_Enter;
            Industry.Enter += Cell_Enter;
            companyAddress.Enter += Cell_Enter;
            website.Enter += Cell_Enter;
            contactPerson.Enter += Cell_Enter;
            contactPosition.Enter += Cell_Enter;
            contactNumber.Enter += Cell_Enter;
            contactEmail.Enter += Cell_Enter;
        }

        private void submitBttn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"By pressing OK, you made sure that the details you provied are accurate and correct. Press Cancel if not.", "Double Check Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.OK)
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

                if (companyLogo.Tag == null || COR.Tag == null || BIRR.Tag == null || MP.Tag == null)
                {
                    MessageBox.Show("Please upload company Logo and submit essential supporting documents for validation process.");
                    return;
                }

                DateTime currentDate = DateTime.Now;

                byte[]? logoBytes = File.ReadAllBytes(companyLogo.Tag.ToString());
                byte[]? corBytes = File.ReadAllBytes(COR.Tag.ToString());
                byte[]? birrBytes = File.ReadAllBytes(BIRR.Tag.ToString());
                byte[]? mpBytes = File.ReadAllBytes(MP.Tag.ToString());

                dbSupport.InsertValidationData(companyUserID, companyName.Text, Industry.Text, companyAddress.Text, hyperlink, contactPerson.Text, contactPosition.Text, contactNumber.Text, contactEmail.Text,
                                        companyLogo.Tag.ToString(), logoBytes, COR.Tag.ToString(), corBytes, BIRR.Tag.ToString(), birrBytes, MP.Tag.ToString(), mpBytes, currentDate, status);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                return;
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

        private void requestUpdateBttn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"By pressing OK, you made sure that the details you provied are accurate and correct. Press Cancel if not.", "Double Check Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.OK)
            {
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

                dbSupport.RequestUpdateCompanyDetails(companyUserID, companyName.Text, Industry.Text, companyAddress.Text, hyperlink, contactPerson.Text, contactPosition.Text, contactNumber.Text, contactEmail.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                return;
        }

        private void Cell_Enter(object? sender, EventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            if (textBox != null)
            {
                textBox.ForeColor = Color.Firebrick;
            }
        }

        private void UpdateBttn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"By pressing OK, you made sure that the details you provied are accurate and correct. Press Cancel if not.", "Double Check Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.OK)
            {
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

                dbSupport.UpdateCompanyDetails(companyUserID, companyName.Text, Industry.Text, companyAddress.Text, hyperlink, contactPerson.Text, contactPosition.Text, contactNumber.Text, contactEmail.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                return;
        }
    }
}
