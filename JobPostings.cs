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
                        row["CompanyName"],
                        row["JobTitle"],
                        row["JobType"],
                        row["Location"],
                        row["Work Mode"],
                        row["StartingSalary"],
                        row["Vacancy"],
                        row["IsPosted"]
                    );
                }
            }
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
                string? companyName = row.Cells[0].Value.ToString();
                string? jobTitle = row.Cells[1].Value.ToString();
                string? jobType = row.Cells[2].Value.ToString();
                string? location = row.Cells[3].Value.ToString();
                string? workMode = row.Cells[4].Value.ToString();
                string? salary = row.Cells[5].Value.ToString();
                int? vacancy = Convert.ToInt32(row.Cells[6].Value);
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
                                row["CompanyName"],
                                row["JobTitle"],
                                row["JobType"],
                                row["Location"],
                                row["Work Mode"],
                                row["StartingSalary"],
                                row["Vacancy"],
                                row["IsPosted"]
                            );
                        }
                    }
                }
            }
            else if (int.TryParse(searchKey, out int result)) //If the search key is an Application ID number or User ID number
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
                string filterExpression = string.Format("[CompanyName] LIKE '%{0}%' OR [JobTitle] LIKE '%{0}%' OR [JobType] LIKE '%{0}%' OR [Location] LIKE '%{0}%' OR " +
                                                        "[Work Mode] LIKE '%{0}%' OR [StartingSalary] LIKE '%{0}%'", filter.Replace("'", "''"));
                jobList.DefaultView.RowFilter = filterExpression;
                if (jobList != null)
                {
                    jobEntriesTable.Rows.Clear();
                    foreach (DataRow row in jobList.DefaultView.ToTable().Rows)
                    {
                        jobEntriesTable.Rows.Add(
                            row["CompanyName"],
                            row["JobTitle"],
                            row["JobType"],
                            row["Location"],
                            row["Work Mode"],
                            row["StartingSalary"],
                            row["Vacancy"],
                            row["IsPosted"]
                        );
                    }
                }
            }
        }

        private void FilterApplicantsByID(int filter)
        {
            if (jobList != null)
            {
                string filterExpression = string.Format("[Vacancy] = {0}", filter);
                jobList.DefaultView.RowFilter = filterExpression;
                if (jobList != null)
                {
                    jobEntriesTable.Rows.Clear();
                    foreach (DataRow row in jobList.DefaultView.ToTable().Rows)
                    {
                        jobEntriesTable.Rows.Add(
                            row["CompanyName"],
                            row["JobTitle"],
                            row["JobType"],
                            row["Location"],
                            row["Work Mode"],
                            row["StartingSalary"],
                            row["Vacancy"],
                            row["IsPosted"]
                        );
                    }
                }
            }
        }
    }
}
