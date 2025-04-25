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
    public partial class JobApplicants : BaseControl
    {
        private DataTable? applicantsData;
        private ApplicantProfileView? applicantProfileView;
        private List<ViewApplicants>? jobPosts;
        private DateTime currentDate = DateTime.Now;

        private int PostID;
        private int ApplicationID;
        private int indexRow;

        public JobApplicants(int ID)
        {
            InitializeComponent();
            CompanyID = ID;

            searchBar.TextChanged += searchBar_TextChanged;
        }

        public override async void DisplayDetails()
        {
            jobPosts = await Task.Run(() => dbSupport.GetJobPostApplicants(CompanyID));

            flowPostsPanel.Controls.Clear();

            if (jobPosts.Count == 0)
            {
                MessageBox.Show("No data found.");
                return;
            }

            foreach (var jobPostPanel in jobPosts)
            {
                jobPostPanel.ViewApplicantsClicked += LoadApplicantsData;

                flowPostsPanel.Controls.Add(jobPostPanel);
            }
        }

        private async void LoadApplicantsData(int jobPostID)
        {
            applicantsData = await Task.Run(() => dbSupport.GetGeneralApplicantDetails(jobPostID));

            applicantsGridView.DataSource = null;
            applicantsGridView.Columns.Clear();

            applicantsGridView.DataSource = applicantsData;
            string buttonColumnName = "Files";
            if (!applicantsGridView.Columns.Contains(buttonColumnName))
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = buttonColumnName;
                buttonColumn.HeaderText = "Files";
                buttonColumn.Text = "View Files";
                buttonColumn.UseColumnTextForButtonValue = true;
                applicantsGridView.Columns.Add(buttonColumn);
            }
        }

        private async void applicantsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (indexRow >= 0)
            {
                DataGridViewRow row = applicantsGridView.Rows[indexRow];
                ApplicationID = Convert.ToInt32(row.Cells[0].Value);
                PostID = Convert.ToInt32(row.Cells[1].Value);
                HunterID = Convert.ToInt32(row.Cells[2].Value); //will be used for emailing and profile view

                if (e.ColumnIndex == applicantsGridView.Columns["Files"].Index)
                {
                    var retrievalStatus = await Task.Run(() => dbSupport.RetrieveApplicantFiles(HunterID));
                    if (retrievalStatus)
                    {
                        dbSupport.UpdateApplicationStatus(ApplicationID, "REVIEWED", currentDate);
                    }
                    LoadApplicantsData(PostID);
                }
            }
        }

        private void applicantsGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo hit = applicantsGridView.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    indexRow = hit.RowIndex;
                    DataGridViewRow row = applicantsGridView.Rows[indexRow];
                    HunterID = Convert.ToInt32(row.Cells[2].Value);
                    applicantsGridView.ClearSelection();
                    applicantsGridView.Rows[hit.RowIndex].Selected = true;
                }
            }
        }

        private void applicantsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            applicantProfileView = new ApplicantProfileView(HunterID);
            applicantProfileView.Show();
        }

        private void AcceptBttn_Click(object sender, EventArgs e)
        {
            if (applicantsGridView.Rows.Count > 0)
            {
                dbSupport.UpdateApplicationStatus(ApplicationID, "ACCEPTED", currentDate);
                LoadApplicantsData(PostID);
                dbSupport.DecrementJobVacancy(PostID);
                dbSupport.UpdateNumOfAcceptedApplicants(PostID);
            }
        }

        private void RejectBttn_Click(object sender, EventArgs e)
        {
            if (applicantsGridView.Rows.Count > 0)
            {
                dbSupport.UpdateApplicationStatus(ApplicationID, "REJECTED", currentDate);
                LoadApplicantsData(PostID);
                dbSupport.UpdateNumOfRejectedApplicants(PostID);
            }
        }

        private void ForInterviewBttn_Click(object sender, EventArgs e)
        {
            if (applicantsGridView.Rows.Count > 0)
            {
                dbSupport.UpdateApplicationStatus(ApplicationID, "FOR INTERVIEW", currentDate);
                LoadApplicantsData(PostID);
            }
        }

        private void ShortlistBttn_Click(object sender, EventArgs e)
        {
            if (applicantsGridView.Rows.Count > 0)
            {
                dbSupport.UpdateApplicationStatus(ApplicationID, "FOR CONSIDERATION", currentDate);
                LoadApplicantsData(PostID);
            }
        }

        private void searchBar_TextChanged(object? sender, EventArgs e)
        {
            string searchKey = searchBar.Text.Trim();
            if (searchKey == "  Filter/Search applicants...")
            {
                return;
            }
            else if (string.IsNullOrEmpty(searchKey))
            {
                if (applicantsData != null)
                {
                    applicantsData.DefaultView.RowFilter = "";
                }
            }
            else if (int.TryParse(searchKey, out int result)) //If the search key is an Application ID number or a User ID number
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
            if (applicantsData != null)
            {
                string filterExpression = string.Format("[Full Name] LIKE '%{0}%' OR [Status] LIKE '%{0}%'", filter.Replace("'", "''"));
                applicantsData.DefaultView.RowFilter = filterExpression;
            }
        }

        private void FilterApplicantsByID(int filter)
        {
            if (applicantsData != null)
            {
                string filterExpression = string.Format("[Application ID] = {0} OR [UserID] = {0}", filter);
                applicantsData.DefaultView.RowFilter = filterExpression;
            }
        }

        private void emailApplicantStripMenuItem_Click(object sender, EventArgs e)
        {
            if (indexRow >= 0 && applicantsGridView.Rows.Count > 0)
            {
                CompanyEmailingForm emailForm = new CompanyEmailingForm(CompanyID, HunterID);
                emailForm.Show();
            }
        }

        private void searchBar_Enter(object sender, EventArgs e)
        {
            if (searchBar.Text == "  Filter/Search applicants...")
            {
                searchBar.Text = "";
            }
        }

        private void searchBar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBar.Text))
            {
                searchBar.Text = "  Filter/Search applicants...";
            }
        }
    }
}
