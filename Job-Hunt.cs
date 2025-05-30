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
        private DataTable? SavedJobPosts;
        private int indexRow;

        public Job_Hunt(int ID)
        {
            InitializeComponent();
            HunterID = ID;

            searchBar.TextChanged += searchBar_TextChanged;
            filterJobType.ItemCheck += filterJobType_ItemCheck;
            filterWorkMode.ItemCheck += filterWorkMode_ItemCheck;
        }

        public override async void DisplayDetails()
        {
            (imageData, var jobPostDataList) = await Task.Run(() =>
            {
                var imageData = dbSupport.DisplayProfilePicture(HunterID);
                var jobPosts = dbSupport.GetJobPosts(HunterID);
                return (imageData, jobPosts);
            });

            if (jobPostDataList.Count == 0)
            {
                MessageBox.Show("No job posts found.");
                return;
            }

            Form? parentForm = this.FindForm();
            if (parentForm is JobHunterDashB form)
            {
                Panel? menuBar = form.Controls.Find("menuBarPanel0", true).FirstOrDefault() as Panel;
                if (menuBar == null) return;

                jobPosts.Clear();

                foreach (var data in jobPostDataList)
                {
                    var jobPostPanel = new JobPostPanel(
                        data.PostID, data.Closing, data.CompanyName, data.JobTitle, data.JobType,
                        data.Location, data.WorkMode, data.StartingSalary, data.Vacancy, data.Logo, HunterID
                    );

                    if (form.WindowState == FormWindowState.Maximized && menuBar.Width > 200)
                        jobPostPanel.Size = new Size(858, 117);
                    else if (form.WindowState == FormWindowState.Maximized)
                        jobPostPanel.Size = new Size(958, 117);
                    else if (menuBar.Width > 200)
                        jobPostPanel.Size = new Size(578, 117);
                    else
                        jobPostPanel.Size = new Size(678, 117);

                    jobPostPanel.SaveJobPostClicked += SaveJobPost;

                    jobPostPanel.Tag = new List<string>
                    {
                        data.CompanyName ?? "",
                        data.JobTitle ?? "",
                        data.JobType ?? "",
                        data.Industry ?? "",
                        data.Location ?? "",
                        data.WorkMode ?? "",
                        data.Vacancy.ToString()
                    };

                    jobPosts.Add(jobPostPanel);
                }
            }

            await LoadJobPostPanelsInChunks();

            if (imageData != null)
            {
                using MemoryStream ms = new(imageData);
                profilePicture.Image = Image.FromStream(ms);
            }

            LoadDataGrid();
        }

        private async Task LoadJobPostPanelsInChunks(int chunkSize = 10, int delayMs = 50) //One of the challenges in my Project (Optimizing performance)
        {
            flowPostsPanel.Controls.Clear();
            for (int i = 0; i < jobPosts.Count; i += chunkSize)
            {
                var chunk = jobPosts.Skip(i).Take(chunkSize).ToList();
                foreach (var panel in chunk)
                {
                    flowPostsPanel.Controls.Add(panel);
                }
                await Task.Delay(delayMs); //Letting the UI breathe
            }
        }

        private void SaveJobPost(int jobPostID, int hunterID, string jobTitle)
        {
            dbSupport.SaveJobPost(jobPostID, hunterID, jobTitle);
            LoadDataGrid();
        }

        public override async void LoadDataGrid()
        {
            SavedJobPostGridView.DataSource = null;
            SavedJobPosts = await Task.Run(() => dbSupport.GetSavedJobPosts(HunterID));
            SavedJobPostGridView.DataSource = SavedJobPosts;
        }

        private void searchBar_TextChanged(object? sender, EventArgs e)
        {
            string searchText = searchBar.Text.Trim();
            if (string.IsNullOrEmpty(searchText) || searchText == "Type here to search...")
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

        private void filterIndustry_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFilters.Add(filterIndustry.SelectedItem?.ToString());
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
            filterLocation.Text = " Country";
            filterVacancy.SelectedIndex = -1;
            filterVacancy.Text = "_ Available Post";
            filterIndustry.SelectedIndex = -1;
            filterIndustry.Text = " Industry";
            searchBar.Text = "  Type here to search...";
            selectedFilters.Clear();
        }

        private void searchBar_Enter(object sender, EventArgs e)
        {
            if (searchBar.Text == "  Type here to search...")
            {
                searchBar.Text = "";
            }
        }

        private void searchBar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBar.Text))
            {
                searchBar.Text = "  Type here to search...";
            }
        }

        private void filterSearch_Click(object sender, EventArgs e)
        {
            searchBar.Text = string.Join(" - ", selectedFilters);
        }

        private void SavedJobPostGridView_CellClick(object sender, DataGridViewCellEventArgs e) //Gets index when clicked
        {
            indexRow = e.RowIndex;
        }

        private void SavedJobPostGridView_MouseDown(object sender, MouseEventArgs e) //Gets index when right-clicked
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo hit = SavedJobPostGridView.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    indexRow = hit.RowIndex;
                    SavedJobPostGridView.ClearSelection();
                    SavedJobPostGridView.Rows[hit.RowIndex].Selected = true;
                }
            }
        }

        private void SavedJobPostGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (indexRow >= 0)
            {
                DataGridViewRow row = SavedJobPostGridView.Rows[indexRow];
                string? jobTitle = row.Cells[1].Value.ToString();
                searchBar.Text = jobTitle;
            }
        }

        private void deleteSavedPostStripMenuItem_Click(object sender, EventArgs e)
        {
            if (indexRow >= 0)
            {
                indexRow = SavedJobPostGridView.RowCount == 1 ? 0 : indexRow;
                DataGridViewRow row = SavedJobPostGridView.Rows[indexRow];
                int jobPostID = Convert.ToInt32(row.Cells[0].Value);
                dbSupport.DeleteSavedJobPost(jobPostID, HunterID);
            }
            LoadDataGrid();
        }
    }
}
