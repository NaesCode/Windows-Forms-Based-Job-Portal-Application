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
        private List<string?> selectedFilters = new List<string?>();

        public Job_Hunt(int ID)
        {
            InitializeComponent();
            HunterID = ID;

            searchBar.TextChanged += searchBar_TextChanged;
            filterJobType.ItemCheck += filterJobType_ItemCheck;
            filterWorkMode.ItemCheck += filterWorkMode_ItemCheck;
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

            var keywords = filter.Split('-')
                         .Select(k => k.Trim())
                         .Where(k => !string.IsNullOrEmpty(k))
                         .ToList();

            var filteredPosts = jobPosts
                .Where(post =>
                {
                    var tagList = post.Tag as List<string>;
                    if (tagList == null) return false;

                    // Check if all keywords are found in any tag item
                    return keywords.All(keyword =>
                        tagList.Any(tagItem =>
                            tagItem.Contains(keyword, StringComparison.OrdinalIgnoreCase)));
                }).ToList();

            foreach (var jobPostPanel in filteredPosts)
            {
                if (this.Parent is JobHunterDashB form) //checks if parent form is in maximized state or normal, and adjust the panels accordingly
                {
                    foreach(Panel controlPanel in form.Controls)
                    {
                        if(controlPanel.Name == "menuBarPanel0")
                        {
                            if (form.WindowState == FormWindowState.Maximized && controlPanel.Width > 200)
                                jobPostPanel.Size = new Size(858, 117);
                            else if (form.WindowState == FormWindowState.Maximized && controlPanel.Width < 200)
                                jobPostPanel.Size = new Size(958, 117);
                            else if (form.WindowState == FormWindowState.Normal && controlPanel.Width > 200)
                                jobPostPanel.Size = new Size(578, 117);
                            else if (form.WindowState == FormWindowState.Normal && controlPanel.Width < 200)
                                jobPostPanel.Size = new Size(678, 117);
                        }
                    }

                }
                flowPostsPanel.Controls.Add(jobPostPanel);
            }
        }

        private void filterJobType_ItemCheck(object? sender, ItemCheckEventArgs e)
        {
            string? itemText = filterJobType.Items[e.Index].ToString();

            // If the new value is Checked, uncheck all others
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < filterJobType.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        filterJobType.SetItemChecked(i, false);
                    }
                }

                // Add the newly checked item to the list
                if (!selectedFilters.Contains(itemText))
                    selectedFilters.Add(itemText);
            }
            else
            {
                // If the item is being unchecked, remove it from the list
                if (selectedFilters.Contains(itemText))
                    selectedFilters.Remove(itemText);
            }
        }

        private void filterWorkMode_ItemCheck(object? sender, ItemCheckEventArgs e)
        {
            string? itemText = filterWorkMode.Items[e.Index].ToString();

            // If the new value is Checked, uncheck all others
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < filterWorkMode.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        filterWorkMode.SetItemChecked(i, false);
                    }
                }

                // Add the newly checked item to the list
                if (!selectedFilters.Contains(itemText))
                    selectedFilters.Add(itemText);
            }
            else
            {
                // If the item is being unchecked, remove it from the list
                if (selectedFilters.Contains(itemText))
                    selectedFilters.Remove(itemText);
            }
        }

        private void filterLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFilters.Add(filterLocation.SelectedItem?.ToString());
        }

        private void filterVacancy_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFilters.Add(filterVacancy.SelectedItem?.ToString());
        }

        private void resetFilterSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < filterJobType.Items.Count; i++)
            {
                filterJobType.SetItemChecked(i, false);
            }
            for (int i = 0; i < filterWorkMode.Items.Count; i++)
            {
                filterWorkMode.SetItemChecked(i, false);
            }
            filterLocation.SelectedIndex = -1;
            filterLocation.Text = "Country";
            filterVacancy.SelectedIndex = -1;
            filterVacancy.Text = "_ Available Post";
            searchBar.Text = "";
            selectedFilters.Clear();
        }

        private void filterSearch_Click(object sender, EventArgs e)
        {
            searchBar.Text = string.Join(" - ", selectedFilters);
        }
    }
}
