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
    public partial class TrackApplications : BaseControl
    {
        private DateTime currentDate = DateTime.Now;
        private DataTable? jobApplication;
        private int indexRow;

        public TrackApplications(int ID)
        {
            InitializeComponent();
            HunterID = ID;

            searchBar.TextChanged += searchBar_TextChanged;
        }

        public override async void DisplayDetails()
        {
            LoadDataGrid();
            imageData = await Task.Run(() => dbSupport.DisplayProfilePicture(HunterID));

            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    profilePicture.Image = Image.FromStream(ms);
                }
            }
        }

        public override async void LoadDataGrid()
        {
            ApplicationsTable.DataSource = null;
            jobApplication = await Task.Run(() => dbSupport.GetJobApplications(HunterID));
            ApplicationsTable.DataSource = jobApplication;

            foreach (DataGridViewRow row in ApplicationsTable.Rows)
            {
                if (row.Cells["Status"].Value != null)
                {
                    string status = row.Cells["Status"].Value.ToString()?.ToLower() ?? "";

                    if (status == "accepted")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 255, 204);
                    }
                    else if (status == "rejected")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 204, 204);
                    }
                }
            }
        }

        private void searchBar_TextChanged(object? sender, EventArgs e)
        {
            string searchKey = searchBar.Text.Trim();
            if (string.IsNullOrEmpty(searchKey))
            {
                if (jobApplication != null)
                {
                    jobApplication.DefaultView.RowFilter = "";
                }
            }
            else if (int.TryParse(searchKey, out int result)) //If the search key is an Application ID number 
            {
                FilterApplicationsByID(result);
            }
            else
            {
                FilterApplications(searchKey);
            }
        }

        private void FilterApplications(string filter)
        {
            if (jobApplication != null)
            {
                string filterExpression = string.Format("[CompanyName] LIKE '%{0}%' OR [JobTitle] LIKE '%{0}%' OR " +
                             "[Status] LIKE '%{0}%' OR [Work Mode] LIKE '%{0}%'", filter.Replace("'", "''"));
                jobApplication.DefaultView.RowFilter = filterExpression;
            }
        }

        private void FilterApplicationsByID(int filter)
        {
            if (jobApplication != null)
            {
                string filterExpression = string.Format("[Application ID] = {0}", filter);
                jobApplication.DefaultView.RowFilter = filterExpression;
            }
        }

        private void ApplicationsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (indexRow >= 0 && ApplicationsTable.Rows.Count > 0)
            {
                DataGridViewRow row = ApplicationsTable.Rows[indexRow];
                int postID = (int)row.Cells[0].Value;
                int applicationID = (int)row.Cells[1].Value;

                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to cancel Application#: {applicationID}?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    dbSupport.UpdateApplicationStatus(applicationID, "CANCELLED", currentDate);
                    dbSupport.UpdateNumOfCancelledApplications(postID);
                    dbSupport.IncrementJobVacancy(postID);
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 204, 204);
                }
            }
            DisplayDetails();
        }

        private void deleteAppStripMenuItem_Click(object sender, EventArgs e)
        {
            if (indexRow >= 0 && ApplicationsTable.Rows.Count > 0)
            {
                DataGridViewRow row = ApplicationsTable.Rows[indexRow];
                int applicationID = (int)row.Cells[1].Value;
                if (row.Cells[4].Value.ToString() == "CANCELLED" || row.Cells[4].Value.ToString() == "REJECTED")
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete Application#: {applicationID}?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK)
                    {
                        dbSupport.DeleteJobApplication(applicationID);
                    }
                }
                else
                    MessageBox.Show("You cannot delete an application that is not cancelled or is not rejected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DisplayDetails();
        }
    }
}
