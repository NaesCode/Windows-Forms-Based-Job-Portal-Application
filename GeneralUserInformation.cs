using Microsoft.DotNet.DesignTools.Protocol.Endpoints;
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
    public partial class GeneralUserInformation : BaseControl
    {
        private DataTable? CompanyDetails;
        private DataTable? JobHunterDetails;

        public GeneralUserInformation()
        {
            InitializeComponent();
            Header.Text = "MANAGE COMPANIES";
            searchBar2.Visible = false;
            searchBar.TextChanged += searchBar_TextChanged;
        }

        public GeneralUserInformation(bool usage)
        {
            InitializeComponent();
            Header.Text = "ALL JOB HUNTERS";
            searchBar.Visible = false;
            searchBar2.TextChanged += searchBar2_TextChanged;
            searchBar2.Location = new Point(252, 11);
            panel1.Visible = false;
        }

        //The override method used to display Companies' Information
        public override async void LoadDataGrid()
        {
            InfoTable.DataSource = null;
            InfoTable.Columns.Clear();
            CompanyDetails = await Task.Run(() => dbSupport.GetAllCompanies());
            InfoTable.DataSource = CompanyDetails;
            string buttonColumnName = "Files";
            if (!InfoTable.Columns.Contains(buttonColumnName))
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = buttonColumnName;
                buttonColumn.HeaderText = "Files";
                buttonColumn.Text = "View Files";
                buttonColumn.UseColumnTextForButtonValue = true;
                InfoTable.Columns.Add(buttonColumn);
            }
        }

        //The override method used to display Job Hunters' Information
        public override async void DisplayDetails()
        {
            InfoTable.DataSource = null;
            InfoTable.Columns.Clear();
            JobHunterDetails = await Task.Run(() => dbSupport.GetAllJobHunters());
            InfoTable.DataSource = JobHunterDetails;
        }

        private void companyInfoTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow > 0)
            {
                DataGridViewRow row = InfoTable.Rows[indexRow];
                if (InfoTable.Columns["companyUserID"] != null)
                {
                    CompanyID = Convert.ToInt32(row.Cells["companyUserID"].Value);

                    if (InfoTable.Columns["Files"] != null)
                    {
                        if (e.ColumnIndex == InfoTable.Columns["Files"].Index)
                        {
                            dbSupport.RetrieveCompanyFiles(CompanyID);
                        }
                    }
                }
            }
        }

        private void ApproveBttn_Click(object sender, EventArgs e)
        {
            dbSupport.UpdateCompanyStatus(CompanyID, "APPROVED");
        }

        private void RejectBttn_Click(object sender, EventArgs e)
        {
            dbSupport.UpdateCompanyStatus(CompanyID, "DISAPPROVED");
        }

        private void searchBar_TextChanged(object? sender, EventArgs e)
        {
            string searchKey = searchBar.Text;
            if (string.IsNullOrEmpty(searchKey) || searchKey == "  Type here to search...")
            {
                if (CompanyDetails != null)
                {
                    CompanyDetails.DefaultView.RowFilter = "";
                }
            }
            else if (int.TryParse(searchKey, out int result))
            {
                FilterCompaniesByID(result);
            }
            else
            {
                FilterCompanies(searchKey);
            }
        }
        private void searchBar2_TextChanged(object? sender, EventArgs e)
        {
            string searchKey = searchBar2.Text;
            if (string.IsNullOrEmpty(searchKey) || searchKey == "  Type here to search...")
            {
                if (JobHunterDetails != null)
                {
                    JobHunterDetails.DefaultView.RowFilter = "";
                }
            }
            else if (int.TryParse(searchKey, out int result))
            {
                FilterHuntersByID(result);
            }
            else
            {
                FilterHunters(searchKey);
            }
        }

        private void FilterCompanies(string filter)
        {
            if (CompanyDetails != null)
            {
                string filterExpression = string.Format("[Company Name] LIKE '%{0}%' OR [CompanyLog-In_Email] LIKE '%{0}%' OR [Industry] LIKE '%{0}%' OR " +
                             "[Company Address] LIKE '%{0}%' OR [Contact Person Name] LIKE '%{0}%' OR [Contact Person Position] LIKE '%{0}%' OR " +
                             "[Contact Number] LIKE '%{0}%' OR [Contact Email] LIKE '%{0}%' OR [Status] LIKE '%{0}%'", filter.Replace("'", "''"));
                CompanyDetails.DefaultView.RowFilter = filterExpression;
            }
        }

        private void FilterCompaniesByID(int filter)
        {
            if (CompanyDetails != null)
            {
                string filterExpression = string.Format("[CompanyUserID] = {0} OR [FileID] = {0}", filter);
                CompanyDetails.DefaultView.RowFilter = filterExpression;
            }
        }

        private void FilterHunters(string filter)
        {
            if (JobHunterDetails != null)
            {
                string filterExpression = string.Format("[Full Name] LIKE '%{0}%' OR [Gender] LIKE '%{0}%' OR [Email] LIKE '%{0}%' OR " +
                             "[Nationality] LIKE '%{0}%' OR [Education] LIKE '%{0}%' OR [Degree] LIKE '%{0}%' OR [University / Institution] " +
                             "LIKE '%{0}%'", filter.Replace("'", "''"));
                JobHunterDetails.DefaultView.RowFilter = filterExpression;
            }
        }

        private void FilterHuntersByID(int filter)
        {
            if (JobHunterDetails != null)
            {
                string filterExpression = string.Format("[userID] = {0}", filter);
                JobHunterDetails.DefaultView.RowFilter = filterExpression;
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

        private void searchBar2_Enter(object sender, EventArgs e)
        {
            if (searchBar2.Text == "  Type here to search...")
            {
                searchBar2.Text = "";
            }
        }

        private void searchBar2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBar2.Text))
            {
                searchBar2.Text = "  Type here to search...";
            }
        }
    }
}
