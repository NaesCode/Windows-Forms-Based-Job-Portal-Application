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
        private DataTable? jobApplication;
        private int indexRow;

        public TrackApplications(int ID)
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
            jobApplication = dbSupport.GetJobApplications(HunterID);
            ApplicationsTable.DataSource = jobApplication;
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

        private void cancelAppStripMenuItem_Click(object sender, EventArgs e)
        {
            if (indexRow >= 0)
            {
                DataGridViewRow row = ApplicationsTable.Rows[indexRow];
                int applicationID = (int)row.Cells[1].Value;

                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete Application#: {applicationID}?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    dbSupport.DeleteJobApplication(applicationID);
                }
            }
            DisplayDetails();
        }
    }
}
