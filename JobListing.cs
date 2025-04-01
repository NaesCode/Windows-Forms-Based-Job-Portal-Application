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

        public JobListing(int companyID)
        {
            InitializeComponent();
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            this.companyUserID = companyID;

            byte[]? imageData = dbSupport.DisplayCompanyLogo(companyUserID);
            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    companyLogo.Image = Image.FromStream(ms);
                }
            }
        }

        private void addJobBttn_Click(object sender, EventArgs e)
        {
            bool isPosted = false;
            int jobVacancy;
            jobVacancy = int.Parse(this.jobVacancy.Text);
            DateTime deadline = applicationDeadline.Value;

            try
            {
                dbSupport.insertJobPostData(companyUserID, CompanyName.Text, JobTitle.Text, JobType.Text, JobCategory.Text, Industry.Text,
                                        JobLocation.Text, WorkMode.Text, startingSalary.Text, JobDescription.Text, ApplicationDetails.Text, jobVacancy, deadline, isPosted);
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

            // Adjust for the current item being checked or unchecked
            if (e.NewValue == CheckState.Checked)
            {
                selectedIndustries.Add(checkedListBox1.Items[e.Index].ToString());
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                selectedIndustries.Remove(checkedListBox1.Items[e.Index].ToString());
            }

            Industry.Text = string.Join(", ", selectedIndustries);
        }
    }
}
