using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Manager
{
    public partial class JobPostings : BaseControl
    {
        private DataTable? jobList;

        private int indexRow;
        private bool IsPosted = false;

        public JobPostings(int companyID)
        {
            InitializeComponent();
            CompanyID = companyID;

            searchBar.TextChanged += searchBar_TextChanged;
        }

        public override async void DisplayDetails()
        {
            LoadDataGrid();

            imageData = await Task.Run(() => dbSupport.DisplayCompanyLogo(CompanyID));

            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    companyLogo2.Image = Image.FromStream(ms);
                }
            }
        }

        public override async void LoadDataGrid()
        {
            jobEntriesTable.Rows.Clear();
            jobList = await Task.Run(() => dbSupport.GetCompanyJobList(CompanyID));
            if (jobList != null)
            {
                jobEntriesTable.Rows.Clear();
                foreach (DataRow row in jobList.Rows)
                {
                    jobEntriesTable.Rows.Add(
                        row["PostID"],
                        row["CompanyName"],
                        row["JobTitle"],
                        row["JobType"],
                        row["Location"],
                        row["Work Mode"],
                        row["StartingSalary"],
                        row["Vacancy"],
                        row["IsPosted"],
                        Convert.ToDateTime(row["Application Deadline"]).ToString("MM/dd/yyyy h:mm tt")
                    );
                }
            }
            jobEntriesTable.Columns["postID"].ReadOnly = true;
            jobEntriesTable.Columns["postStatus"].ReadOnly = true;
        }

        private void jobEntriesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
        }

        private void postJobBttn_Click(object sender, EventArgs e)
        {
            IsPosted = true;
            dbSupport.UpdateIsPostedStatus(CompanyID, IsPosted);
            if (indexRow >= 0 && jobEntriesTable.Rows.Count > 0)
            {
                DataGridViewRow row = jobEntriesTable.Rows[indexRow];
                string? companyName = row.Cells[1].Value.ToString();
                string? jobTitle = row.Cells[2].Value.ToString();
                string? jobType = row.Cells[3].Value.ToString();
                string? location = row.Cells[4].Value.ToString();
                string? workMode = row.Cells[5].Value.ToString();
                string? salary = row.Cells[6].Value.ToString();
                int? vacancy = Convert.ToInt32(row.Cells[7].Value);
                imageData = dbSupport.DisplayCompanyLogo(CompanyID);
                flowLayoutPanel1.Controls.Add(new JobPostPreviewPanel(companyName, jobTitle, jobType, location, workMode, salary, vacancy, imageData));
            }
            DisplayDetails();
        }

        private void deletePostBttn_Click(object sender, EventArgs e)
        {
            if (indexRow >= 0 && jobEntriesTable.Rows.Count > 0)
            {
                DataGridViewRow row = jobEntriesTable.Rows[indexRow];
                int PostID = (int)row.Cells[0].Value;
                string? jobTitle = row.Cells[2].Value.ToString();

                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete Post#: {PostID} with Job Title: {jobTitle}?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    dbSupport.DeleteJobPost(PostID);
                    dbSupport.UpdateApplicationStatusForDeleted(PostID, "JOB POST DELETED");
                }

                for (int i = flowLayoutPanel1.Controls.Count - 1; i >= 0; i--)
                {
                    if (flowLayoutPanel1.Controls[i] is JobPostPreviewPanel jobPostPreviewPanel)
                    {
                        foreach (Control innerControl in jobPostPreviewPanel.Controls)
                        {
                            if (innerControl is Label label && label.Name == "jobTitleLabel" && label.Text == jobTitle)
                            {
                                flowLayoutPanel1.Controls.RemoveAt(i);
                                break;
                            }
                        }
                    }
                }

            }
            else
                return;
            DisplayDetails();
        }

        private void updatePostBttn_Click(object sender, EventArgs e)
        {
            if (indexRow >= 0 && jobEntriesTable.Rows.Count > 0)
            {
                DataGridViewRow row = jobEntriesTable.Rows[indexRow];
                int PostID = (int)row.Cells[0].Value;
                JobFullDetails jobfullDetails = new JobFullDetails(PostID);
                jobfullDetails.LoadJobDetails(imageData);
                jobfullDetails.Show();
            }
        }

        private void jobEntriesTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (indexRow >= 0)
            {
                DataGridViewRow row = jobEntriesTable.Rows[indexRow];
                int PostID = (int)row.Cells[0].Value;
                string? companyName = row.Cells[1].Value.ToString()?.Trim();
                string? jobTitle = row.Cells[2].Value.ToString()?.Trim();
                string? jobType = row.Cells[3].Value.ToString()?.Trim();
                string? location = row.Cells[4].Value.ToString()?.Trim();
                string? workMode = row.Cells[5].Value.ToString()?.Trim();
                string? salary = row.Cells[6].Value.ToString()?.Trim();
                int? vacancy = row.Cells[7].Value != null ? Convert.ToInt32(row.Cells[7].Value) : 0;
                string? date = row.Cells[9].Value.ToString()?.Trim() ?? null;
                string[] formats = { "M/d/yyyy h:mm tt", "M/d/yyyy hh:mm tt", "MM/dd/yyyy h:mm tt", "MM/d/yyyy h:mm tt" };
                if (!DateTime.TryParseExact(date?.Trim(), formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime closing))
                {
                    MessageBox.Show("Please enter valid closing date.");
                    return;
                }
                if (companyName == null || jobTitle == null || jobType == null || location == null || workMode == null || salary == null || vacancy == null)
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
                else
                    dbSupport.UpdateJobPost(PostID, companyName, jobTitle, jobType, location, workMode, salary, vacancy, closing);
            }
        }

        private void searchBar_TextChanged(object? sender, EventArgs e)
        {
            string searchKey = searchBar.Text;
            if (searchKey == "  Type here to search...")
            {
                return;
            }
            else if (string.IsNullOrEmpty(searchKey))
            {
                if (jobList != null)
                {
                    jobList.DefaultView.RowFilter = "";
                    jobEntriesTable.Rows.Clear();
                    foreach (DataRow row in jobList.DefaultView.ToTable().Rows)
                    {
                        jobEntriesTable.Rows.Add(
                            row["PostID"],
                            row["CompanyName"],
                            row["JobTitle"],
                            row["JobType"],
                            row["Location"],
                            row["Work Mode"],
                            row["StartingSalary"],
                            row["Vacancy"],
                            row["IsPosted"],
                            row["Application Deadline"]
                        );
                    }
                }
            }
            else if (int.TryParse(searchKey, out int result)) //If the search key is a Post ID
            {
                FilterApplicantsByID(result);
            }
            else
            {
                FilterApplicants(searchKey);
            }
        }

        private void FilterApplicants(string filter)
        {
            if (jobList != null)
            {
                string filterExpression = string.Format("[JobTitle] LIKE '%{0}%' OR [JobType] LIKE '%{0}%' OR [Location] LIKE '%{0}%' OR " +
                                                        "[Work Mode] LIKE '%{0}%' OR [StartingSalary] LIKE '%{0}%' OR CONVERT([Application Deadline], " +
                                                        "'System.String') LIKE '%{0}%'", filter.Replace("'", "''"));
                jobList.DefaultView.RowFilter = filterExpression;
                if (jobList != null)
                {
                    jobEntriesTable.Rows.Clear();
                    foreach (DataRow row in jobList.DefaultView.ToTable().Rows)
                    {
                        jobEntriesTable.Rows.Add(
                            row["PostID"],
                            row["CompanyName"],
                            row["JobTitle"],
                            row["JobType"],
                            row["Location"],
                            row["Work Mode"],
                            row["StartingSalary"],
                            row["Vacancy"],
                            row["IsPosted"],
                            row["Application Deadline"]
                        );
                    }
                }
            }
        }

        private void FilterApplicantsByID(int filter)
        {
            if (jobList != null)
            {
                string filterExpression = string.Format("[PostID] = {0} OR [Vacancy] = {0}", filter);
                jobList.DefaultView.RowFilter = filterExpression;
                if (jobList != null)
                {
                    jobEntriesTable.Rows.Clear();
                    foreach (DataRow row in jobList.DefaultView.ToTable().Rows)
                    {
                        jobEntriesTable.Rows.Add(
                            row["PostID"],
                            row["CompanyName"],
                            row["JobTitle"],
                            row["JobType"],
                            row["Location"],
                            row["Work Mode"],
                            row["StartingSalary"],
                            row["Vacancy"],
                            row["IsPosted"],
                            row["Application Deadline"]
                        );
                    }
                }
            }
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
    }
}
