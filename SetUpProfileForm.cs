using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Manager
{
    public partial class SetUpProfileForm : Form
    {
        private DatabaseSupport dbSupport = new DatabaseSupport();
        private int hunterID;
        private string? Degree = null;
        private string? University = null;
        private byte[]? imageData = null;

        public SetUpProfileForm(int ID)
        {
            InitializeComponent();
            educAttainment.TextChanged += educAttainment_TextChanged;
            hasWebsite.CheckedChanged += hasWebsite_CheckedChanged;
            this.hunterID = ID;
        }

        public SetUpProfileForm(Dictionary<string, object>? profileData, int ID)
        {
            InitializeComponent();
            updateBttn.Visible = true;
            submitBttn.Visible = false;
            updateBttn.Location = new Point(38, 593);
            this.hunterID = ID;

            imageData = dbSupport.DisplayProfilePicture(hunterID);
            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    ProfilePicture.Image = Image.FromStream(ms);
                }
            }

            if (profileData != null)
            {
                fullName.Text = profileData["Full Name"].ToString();
                dateOfBirth.Value = (DateTime)profileData["Date of Birth"];
                foreach (RadioButton control in genderBox.Controls)
                {
                    if (control.Text == profileData["Gender"].ToString())
                        control.Checked = true;
                }
                contactNumber.Text = profileData["Contact Number"].ToString();
                hunterEmail.Text = profileData["Email"].ToString();
                hunterAddress.Text = profileData["Address"].ToString();
                hunterNationality.Text = profileData["Nationality"].ToString();
                educAttainment.Text = profileData["Education"].ToString();
                degreeEarned.Text = profileData["Degree"].ToString();
                university.Text = profileData["University / Institution"].ToString();
            }
        }

        private void submitBttn_Click(object sender, EventArgs e)
        {
            string? gender = null;
            bool isSetUp = true;
            DateTime BirthDate = dateOfBirth.Value.Date;
            DateTime currentDate = DateTime.Now;

            foreach (RadioButton control in genderBox.Controls)
            {
                if (control.Checked == true)
                    gender = control.Text;
            }

            if (ProfilePicture.Tag == null || resumeDocx.Tag == null)
            {
                MessageBox.Show("Please upload both a profile picture and a resume.");
                return;
            }

            string? pfpTag = ProfilePicture.Tag.ToString();
            string? resumeTag = resumeDocx.Tag.ToString();
            string? coverLetterTag = coverLetter.Tag?.ToString() ?? null;
            string? portfolioTag = portfolio.Tag?.ToString() ?? null;

            byte[]? pfpBytes = File.ReadAllBytes(pfpTag);
            byte[]? resumeBytes = File.ReadAllBytes(resumeTag);
            byte[]? coverLetterBytes = coverLetterTag != null ? File.ReadAllBytes(coverLetterTag) : null;
            byte[]? portfolioBytes = portfolioTag != null ? File.ReadAllBytes(portfolioTag) : null;

            portfolioTag = hasWebsite.Checked ? null : portfolioTag;
            string? portfolioUrl = hasWebsite.Checked ? portfolioWeb.Text : null;

            try
            {
                dbSupport.InsertHunterProfileDetails(hunterID, fullName.Text, BirthDate, gender, contactNumber.Text, hunterEmail.Text, hunterAddress.Text, hunterNationality.Text, educAttainment.Text, Degree, University,
                                          pfpBytes, pfpTag, resumeBytes, resumeTag, coverLetterBytes, coverLetterTag, portfolioBytes, portfolioTag, portfolioUrl, currentDate, isSetUp);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Inserting data failed: {ex}");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
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
                    ProfilePicture.Image = Image.FromFile(openFileDialog.FileName);
                    ProfilePicture.Tag = openFileDialog.FileName; // Store the file path in the Tag for later use
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
                    resumeDocx.Text = openFileDialog.FileName;
                    resumeDocx.Tag = openFileDialog.FileName; // Store the file path in the textbox
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
                    coverLetter.Text = openFileDialog.FileName;
                    coverLetter.Tag = openFileDialog.FileName; // Store the file path in the textbox
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
                    portfolio.Text = openFileDialog.FileName;
                    portfolio.Tag = openFileDialog.FileName; // Store the file path in the textbox
                }
            }
        }

        private void educAttainment_TextChanged(object? sender, EventArgs e)
        {
            if (educAttainment.Text == "College Degree" || educAttainment.Text == "Masteral Degree" || educAttainment.Text == "Doctorate Degree")
            {
                degreeLabel.Enabled = true;
                degreeEarned.Enabled = true;
                degreeEarned.TextChanged += (s, e) => Degree = degreeEarned.Text;
                univLabel.Enabled = true;
                university.Enabled = true;
                university.TextChanged += (s, e) => University = university.Text;
            }
            else
            {
                degreeLabel.Enabled = false;
                degreeEarned.Enabled = false;
                univLabel.Enabled = false;
                university.Enabled = false;
            }
        }

        private bool IsValidUrl(string url) //checks if URL is valid
        {
            return Uri.TryCreate(url, UriKind.Absolute, out _);
        }

        private void hasWebsite_CheckedChanged(object? sender, EventArgs e)
        {
            string url = "";
            if (hasWebsite.Checked == true)
            {
                browseFileBttn3.Enabled = false;
                portfolio.Visible = false;
                portfolioWeb.Location = new Point(469, 493);
                portfolioWeb.Visible = true;
                portfolioWeb.TextChanged += (s, e) => url = portfolioWeb.Text;
                if (IsValidUrl(url))
                {
                    string displayText = "Click Here";
                    string companyWebsite = portfolioWeb.Text;
                    string optionalSubAddress = "";
                    string websiteLink = $"{displayText}#{companyWebsite}#{optionalSubAddress}";
                }
                else
                {
                    MessageBox.Show("Invalid URL. Please enter a valid URL.");
                    portfolioWeb.Clear();
                }
            }
            else
            {
                browseFileBttn3.Enabled = true;
                portfolioWeb.Clear();
                portfolio.Visible = true;
                portfolioWeb.Visible = false;
            }
        }

        private void updateBttn_Click(object sender, EventArgs e)
        {
            string? gender = null;
            DateTime BirthDate = dateOfBirth.Value.Date;
            DateTime currentDate = DateTime.Now;

            foreach (RadioButton control in genderBox.Controls)
            {
                if (control.Checked == true)
                    gender = control.Text;
            }

            if (ProfilePicture.Tag == null || resumeDocx.Tag == null)
            {
                MessageBox.Show("Please REUPLOAD both a profile picture and at least your resume.");
                return;
            }

            string? pfpTag = ProfilePicture.Tag.ToString();
            string? resumeTag = resumeDocx.Tag.ToString();
            string? coverLetterTag = coverLetter.Tag?.ToString() ?? null;
            string? portfolioTag = portfolio.Tag?.ToString() ?? null;

            byte[]? pfpBytes = File.ReadAllBytes(pfpTag);
            byte[]? resumeBytes = File.ReadAllBytes(resumeTag);
            byte[]? coverLetterBytes = coverLetterTag != null ? File.ReadAllBytes(coverLetterTag) : null;
            byte[]? portfolioBytes = portfolioTag != null ? File.ReadAllBytes(portfolioTag) : null;

            portfolioTag = hasWebsite.Checked ? null : portfolioTag;
            string? portfolioUrl = hasWebsite.Checked ? portfolioWeb.Text : null;

            try
            {
                dbSupport.UpdateHunterProfileDetails(hunterID, fullName.Text, BirthDate, gender, contactNumber.Text, hunterEmail.Text, hunterAddress.Text, hunterNationality.Text, educAttainment.Text, Degree, University,
                                          pfpBytes, pfpTag, resumeBytes, resumeTag, coverLetterBytes, coverLetterTag, portfolioBytes, portfolioTag, portfolioUrl, currentDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Inserting data failed: {ex}");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void deleteLogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfilePicture.Image.Dispose();
            ProfilePicture.Image = null;
        }

        private void viewLogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FullPictureView fullPictureForm = new FullPictureView(imageData);
            fullPictureForm.Show();
        }
    }
}
