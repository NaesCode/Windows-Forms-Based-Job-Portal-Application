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

        private DateTime currentDate = DateTime.Now.Date; //Used to check for deadlines

        private int indexRow;
        private bool IsPosted = false;
        public JobPostings(int companyID)
        {
            InitializeComponent();
            CompanyID = companyID;

            searchBar.TextChanged += searchBar_TextChanged;
        }

        public override void DisplayDetails()
        {
            imageData = dbSupport.DisplayCompanyLogo(CompanyID);
            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    companyLogo2.Image = Image.FromStream(ms);
                    companyLogo2.SizeMode = SiticoneNetCoreUI.SiticonePictureBoxSizeMode.StretchImage;
                }
            }

            jobList = dbSupport.GetCompanyJobList(CompanyID);

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
                        row["Application Deadline"]
                    );
                }
            }
            jobEntriesTable.Columns["postID"].ReadOnly = true;
            jobEntriesTable.Columns["companyName"].ReadOnly = true;
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
            if (indexRow >= 0)
            {
                DataGridViewRow row = jobEntriesTable.Rows[indexRow];
                string? companyName = row.Cells[1].Value.ToString();
                string? jobTitle = row.Cells[2].Value.ToString();
                string? jobType = row.Cells[3].Value.ToString();
                string? location = row.Cells[4].Value.ToString();
                string? workMode = row.Cells[5].Value.ToString();
                string? salary = row.Cells[6].Value.ToString();
                int? vacancy = Convert.ToInt32(row.Cells[7].Value);
                byte[]? imageData = dbSupport.DisplayCompanyLogo(CompanyID);
                flowLayoutPanel1.Controls.Add(new JobPostPreviewPanel(companyName, jobTitle, jobType, location, workMode, salary, vacancy, imageData));
            }
            DisplayDetails();
        }

        private void searchBar_TextChanged(object? sender, EventArgs e)
        {
            string searchKey = searchBar.Text.Trim();
            if (string.IsNullOrEmpty(searchKey))
            {
                if (jobList != null)
                {
                    jobList.DefaultView.RowFilter = "";
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
                                                        "[Work Mode] LIKE '%{0}%' OR [StartingSalary] LIKE '%{0}%' OR [Application Deadline] LIKE '%{0}%'", filter.Replace("'", "''"));
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

        private void deletePostBttn_Click(object sender, EventArgs e)
        {
            if (indexRow >= 0)
            {
                DataGridViewRow row = jobEntriesTable.Rows[indexRow];
                int PostID = (int)row.Cells[0].Value;

                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete post#: {PostID}?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    dbSupport.DeleteJobPost(PostID);
                }
            }
            DisplayDetails();
        }

        private void jobEntriesTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(indexRow >= 0)
            {
                DataGridViewRow row = jobEntriesTable.Rows[indexRow];
                int PostID = (int)row.Cells[0].Value;
                string? jobTitle = row.Cells[2].Value.ToString()?.Trim() ?? "No Title";
                string? jobType = row.Cells[3].Value.ToString()?.Trim() ?? "Unknown";
                string? location = row.Cells[4].Value.ToString()?.Trim() ?? "Not Specified";
                string? workMode = row.Cells[5].Value.ToString()?.Trim() ?? "Not Specified";
                string? salary = row.Cells[6].Value.ToString()?.Trim() ?? "0";
                int? vacancy = row.Cells[7].Value != null ? Convert.ToInt32(row.Cells[7].Value) : 0;
                bool isPosted = false;
                string? date = row.Cells[8].Value.ToString()?.Trim() ?? null;
                string? format = "M/d/yyyy h:mm tt";
                if(!DateTime.TryParseExact(date, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime closing))
                {
                    MessageBox.Show("Please enter valid closing date.");
                    return;
                }
                if (jobTitle == null || jobType == null || location == null || workMode == null || salary == null || vacancy == null)
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
                else
                    dbSupport.UpdateJobPost(PostID, jobTitle, jobType, location, workMode, salary, vacancy, isPosted, closing);
            }
        }
    }
}
