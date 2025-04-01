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
    public partial class JobPostings : UserControl
    {
        DatabaseSupport dbSupport = new DatabaseSupport();
        private int companyUserID;
        private int indexRow;
        private bool IsPosted = false;
        public JobPostings(int companyID)
        {
            InitializeComponent();
            companyUserID = companyID;
        }

        public void loadData()
        {
            DataTable? dt = dbSupport.getCompanyJobList(companyUserID);

            if (dt != null)
            {
                jobEntriesTable.Rows.Clear();
                foreach (DataRow row in dt.Rows)
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
            dbSupport.IsPostedStatus(companyUserID, IsPosted);
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
                byte[]? imageData = dbSupport.DisplayCompanyLogo(companyUserID);
                flowLayoutPanel1.Controls.Add(new JobPostPreviewPanel(companyName, jobTitle, jobType, location, workMode, salary, vacancy, imageData));
            }
            loadData();
        }
    }
}
