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

        public JobApplicants(int ID)
        {
            InitializeComponent();
            CompanyID = ID;

            searchBar.TextChanged += searchBar_TextChanged;
        }

        public override void DisplayDetails()
        {
            imageData = dbSupport.DisplayCompanyLogo(CompanyID);
            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    companyLogo.Image = Image.FromStream(ms);
                    companyLogo.SizeMode = SiticoneNetCoreUI.SiticonePictureBoxSizeMode.StretchImage;
                }
            }

            flowPostsPanel.Controls.Clear();

            List<ViewApplicants> jobPosts = dbSupport.GetJobPostApplicants(CompanyID);

            if (jobPosts.Count == 0)
            {
                MessageBox.Show("No data found.");
                return;
            }

            foreach (var jobPostPanel in jobPosts)
            {
                jobPostPanel.Size = new Size(407, 110); // Adjust size if needed

                foreach (Panel panel in jobPostPanel.Controls.OfType<Panel>())
                {
                    foreach (Panel insidePanels in panel.Controls.OfType<Panel>())
                    {
                        if (insidePanels.Name == "panel3")
                            insidePanels.Visible = false;
                        // Iterate through Buttons inside the Panel and change font
                        foreach (Button controlBttn in insidePanels.Controls.OfType<Button>())
                        {
                            controlBttn.Font = new Font("Bahnschrift SemiBold", 11, FontStyle.Bold);
                        }
                    }
                    foreach (FlowLayoutPanel control in panel.Controls.OfType<FlowLayoutPanel>())
                    {
                        foreach (Label lblControl in control.Controls.OfType<Label>())
                        {
                            lblControl.Font = new Font("Bahnschrift Light", 10);
                        }
                    }
                }
                foreach (PictureBox control in jobPostPanel.Controls.OfType<PictureBox>())
                {
                    control.Size = new Size(113, 110);
                }

                jobPostPanel.ViewApplicantsClicked += LoadApplicantsData;

                flowPostsPanel.Controls.Add(jobPostPanel);
            }
        }

        private void LoadApplicantsData(int jobPostID)
        {
            applicantsGridView.DataSource = null;
            applicantsData = dbSupport.GetGeneralApplicantDetails(jobPostID);
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

        private void applicantsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow >= 0)
            {
                DataGridViewRow row = applicantsGridView.Rows[indexRow];
                HunterID = Convert.ToInt32(row.Cells[2].Value);

                if (e.ColumnIndex == applicantsGridView.Columns["Files"].Index)
                {
                    dbSupport.RetrieveApplicantFiles(HunterID);
                }
            }
        }
        private void applicantsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            applicantProfileView = new ApplicantProfileView(HunterID);
            applicantProfileView.Show();
        }

        private void acceptBttn_Click(object sender, EventArgs e)
        {
            dbSupport.UpdateApplicationStatus(HunterID, "ACCEPTED");
        }

        private void rejectBttn_Click(object sender, EventArgs e)
        {
            dbSupport.UpdateApplicationStatus(HunterID, "REJECTED");
        }

        private void forInterviewBttn_Click(object sender, EventArgs e)
        {
            dbSupport.UpdateApplicationStatus(HunterID, "FOR INTERVIEW");
        }

        private void shortlistBttn_Click(object sender, EventArgs e)
        {
            dbSupport.UpdateApplicationStatus(HunterID, "OFFER EXTENDED");
        }

        private void searchBar_TextChanged(object? sender, EventArgs e)
        {
            string searchKey = searchBar.Text.Trim();
            if (string.IsNullOrEmpty(searchKey))
            {
                if (applicantsData != null)
                {
                    applicantsData.DefaultView.RowFilter = "";
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
    }
}
