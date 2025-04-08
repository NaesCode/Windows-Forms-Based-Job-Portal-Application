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
    public partial class JobListing : UserControl
    {
        DatabaseSupport dbSupport = new DatabaseSupport();
        private int companyUserID;
        private byte[]? imageData;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (AreAllFieldsValid())
                {
                    addJobBttn_Click(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Please fill in all required fields correctly.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public JobListing(int companyID)
        {
            InitializeComponent();
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            this.companyUserID = companyID;

            imageData = dbSupport.DisplayCompanyLogo(companyUserID);
            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    companyLogo.Image = Image.FromStream(ms);
                }
            }
        }

        private bool AreAllFieldsValid()
        {
            if (string.IsNullOrWhiteSpace(CompanyName.Text) ||
                string.IsNullOrWhiteSpace(JobTitle.Text) ||
                string.IsNullOrWhiteSpace(JobType.Text) ||
                string.IsNullOrWhiteSpace(JobCategory.Text) ||
                string.IsNullOrWhiteSpace(Industry.Text) ||
                string.IsNullOrWhiteSpace(JobLocation.Text) ||
                string.IsNullOrWhiteSpace(WorkMode.Text) ||
                string.IsNullOrWhiteSpace(startingSalary.Text) ||
                string.IsNullOrWhiteSpace(jobVacancy.Text) ||
                string.IsNullOrWhiteSpace(JobDescription.Text) ||
                JobDescription.Text == "Enter job description and qualifications here..." ||
                string.IsNullOrWhiteSpace(ApplicationDetails.Text) ||
                ApplicationDetails.Text == "Enter application process details here...")
            {
                return false;
            }
            if (int.TryParse(jobVacancy.Text, out int vacancy) && vacancy <= 0)
            {
                MessageBox.Show("Job vacancy must be a positive number.");
                return false;
            }
            return true;
        }

        private void addJobBttn_Click(object sender, EventArgs e)
        {
            if (!AreAllFieldsValid())
            {
                MessageBox.Show("Please fill in all required fields correctly.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool isPosted = false;
            int jobVacancy;
            jobVacancy = int.Parse(this.jobVacancy.Text);
            DateTime deadline = applicationDeadline.Value;

            try
            {

                dbSupport.InsertJobPostData(companyUserID, CompanyName.Text, JobTitle.Text, JobType.Text, JobCategory.Text, Industry.Text,
                    JobLocation.Text, WorkMode.Text, startingSalary.Text, JobDescription.Text, ApplicationDetails.Text, jobVacancy, deadline, isPosted);
                MessageBox.Show("Job added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Inserting data failed: {ex}");
            }
        }

        private void checkedListBox1_ItemCheck(object? sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new Action(() => updateIndustryTextBox(e)));
        }

        private void updateIndustryTextBox(ItemCheckEventArgs e)
        {
            List<string?> selectedIndustries = new List<string?>();

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                // If this is the item being changed, check its *new* value
                if (i == e.Index)
                {
                    if (e.NewValue == CheckState.Checked)
                        selectedIndustries.Add(checkedListBox1.Items[i].ToString());
                    // Don't add it if it’s being unchecked
                }
                else
                {
                    // Keep items that are already checked
                    if (checkedListBox1.GetItemChecked(i))
                        selectedIndustries.Add(checkedListBox1.Items[i].ToString());
                }
            }

            Industry.Text = string.Join(", ", selectedIndustries);
        }

        private void JobDescription_Enter(object sender, EventArgs e)
        {
            if (JobDescription.Text == "Enter job description and qualifications here...")
            {
                JobDescription.Text = "";
                JobDescription.ForeColor = Color.Black;
            }
        }

        private void JobDescription_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(JobDescription.Text))
            {
                JobDescription.Text = "Enter job description and qualifications here...";
                JobDescription.ForeColor = SystemColors.ControlDarkDark;
            }
        }

        private void ApplicationDetails_Enter(object sender, EventArgs e)
        {
            if (ApplicationDetails.Text == "Enter application process details here...")
            {
                ApplicationDetails.Text = "";
                ApplicationDetails.ForeColor = SystemColors.Desktop;
            }
        }

        private void ApplicationDetails_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ApplicationDetails.Text))
            {
                ApplicationDetails.Text = "Enter application process details here...";
                ApplicationDetails.ForeColor = SystemColors.ControlDarkDark;
            }
        }

        private void JobLocation_Enter(object sender, EventArgs e)
        {
            if (JobLocation.Text == "Country, City")
            {
                JobLocation.Text = "";
                JobLocation.ForeColor = SystemColors.Desktop;
            }
        }

        private void JobLocation_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(JobLocation.Text))
            {
                JobLocation.Text = "Country, City";
                JobLocation.ForeColor = SystemColors.ControlDarkDark;
            }
        }

        private void clearInputsBttn_Click(object sender, EventArgs e)
        {
            CompanyName.Text = "";
            JobTitle.Text = "";
            JobType.Text = "";
            JobCategory.Text = "";
            Industry.Text = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            JobLocation.Text = "";
            WorkMode.Text = "";
            startingSalary.Text = "";
            jobVacancy.Text = "";
            JobDescription.Text = "Enter job description and qualifications here...";
            JobDescription.ForeColor = SystemColors.ControlDarkDark;
            ApplicationDetails.Text = "Enter application process details here...";
            ApplicationDetails.ForeColor = SystemColors.ControlDarkDark;
            applicationDeadline.Value = DateTime.Now;
        }

        private void deleteLogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            companyLogo.Image.Dispose();
            companyLogo.Image = null;
        }

        private void viewLogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FullPictureView fullPictureForm = new FullPictureView(imageData);
            fullPictureForm.Show();
        }
    }
}
