using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Manager
{
    public partial class Job_Hunt : BaseControl
    {
        private List<JobPostPanel> jobPosts = new List<JobPostPanel>();
        public Job_Hunt(int ID)
        {
            InitializeComponent();
            HunterID = ID;

            searchBar.TextChanged += searchBar_TextChanged;
        }

        public override void DisplayDetails()
        {
            imageData = dbSupport.DisplayProfilePicture(HunterID);
            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    profilePicture.Image = Image.FromStream(ms);
                    profilePicture.SizeMode = SiticoneNetCoreUI.SiticonePictureBoxSizeMode.StretchImage;
                }
            }

            flowPostsPanel.Controls.Clear();
            jobPosts = dbSupport.GetJobPosts(HunterID);

            if (jobPosts.Count == 0)
            {
                MessageBox.Show("No data found.");
                return;
            }

            foreach (var jobPostPanel in jobPosts)
            {
                flowPostsPanel.Controls.Add(jobPostPanel);
            }

            DisplayFilteredPosts("");

        }

        private void searchBar_TextChanged(object? sender, EventArgs e)
        {
            string searchText = searchBar.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                DisplayFilteredPosts("");
            }
            else
            {
                DisplayFilteredPosts(searchText);
            }
        }

        private void DisplayFilteredPosts(string filter)
        {
            flowPostsPanel.Controls.Clear();
            var filteredPosts = jobPosts.Where(post => post.Tag?.ToString()?.Contains(filter, StringComparison.OrdinalIgnoreCase) ?? false).ToList();

            foreach (var jobPostPanel in filteredPosts)
            {
                if (this.Parent is JobHunterDashB form) //checks if parent form is in maximized state or normal, and adjust the panels accordingly
                {
                    if(form.WindowState == FormWindowState.Maximized)
                        jobPostPanel.Size = new Size(878, 117);
                    else
                        jobPostPanel.Size = new Size(593, 117);
                }
                flowPostsPanel.Controls.Add(jobPostPanel);
            }
        }
    }
}
