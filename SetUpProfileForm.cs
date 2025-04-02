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
    public partial class SetUpProfileForm : Form
    {
        DatabaseSupport dbSupport = new DatabaseSupport();
        private int hunterID;
        private string? Degree = null;
        private string? University = null;
        private string? websiteLink = null;
        public SetUpProfileForm(int ID)
        {
            InitializeComponent();
            educAttainment.TextChanged += educAttainment_TextChanged;
            hasWebsite.CheckedChanged += hasWebsite_CheckedChanged;
            this.hunterID = ID;
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

            byte[]? pfpBytes = File.ReadAllBytes(ProfilePicture.Tag.ToString());
            byte[]? resumeBytes = File.ReadAllBytes(resumeDocx.Tag.ToString());
            byte[]? coverLetterBytes = coverLetter.Tag != null ? File.ReadAllBytes(coverLetter.Tag.ToString()) : null;
            byte[]? portfolioBytes = portfolio.Tag != null ? File.ReadAllBytes(portfolio.Tag.ToString()) : null;

            string? portfolioPath = hasWebsite.Checked ? null : portfolio.Text;
            string? portfolioUrl = hasWebsite.Checked ? portfolioWeb.Text : null;

            try
            {
                dbSupport.InsertHunterProfileDetails(hunterID, fullName.Text, BirthDate, gender, contactNumber.Text, hunterEmail.Text, hunterAddress.Text, hunterNationality.Text, educAttainment.Text, Degree, University,
                                          pfpBytes, ProfilePicture.Tag.ToString(), resumeBytes, resumeDocx.Tag.ToString(), coverLetterBytes, coverLetter.Tag.ToString(), portfolioBytes, portfolioPath, portfolioUrl, currentDate, isSetUp);
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
                portfolioWeb.TextChanged += (s,e) => url = portfolioWeb.Text;
                if (IsValidUrl(url))
                {
                    string displayText = "Click Here";
                    string companyWebsite = portfolioWeb.Text;
                    string optionalSubAddress = "";
                    websiteLink = $"{displayText}#{companyWebsite}#{optionalSubAddress}";
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
    }
}
