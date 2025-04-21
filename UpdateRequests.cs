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
    public partial class UpdateRequests : BaseControl
    {
        private ValidateCompanyForm? validateCompanyForm;
        private DataTable? Requests;
        public UpdateRequests()
        {
            InitializeComponent();

            searchBar.TextChanged += searchBar_TextChanged;
        }

        public override async void LoadDataGrid()
        {
            requestsTable.DataSource = null;
            requestsTable.Columns.Clear();
            Requests = await Task.Run(() => dbSupport.GetUpdateRequests());
            requestsTable.DataSource = Requests;
        }

        private void requestsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string user = "Admin";
            if (e.RowIndex >= 0)
            {
                int requestID = Convert.ToInt32(requestsTable.Rows[e.RowIndex].Cells["RequestID"].Value);
                CompanyID = Convert.ToInt32(requestsTable.Rows[e.RowIndex].Cells["CompanyUserID"].Value);

                Dictionary<string, object> rowData = new Dictionary<string, object>();
                DataGridViewRow row = requestsTable.Rows[e.RowIndex];

                foreach (DataGridViewCell cell in row.Cells)
                {
                    string columnName = requestsTable.Columns[cell.ColumnIndex].Name;
                    object cellValue = cell.Value;
                    rowData[columnName] = cellValue;
                }

                validateCompanyForm = new ValidateCompanyForm(rowData, CompanyID, user);
                validateCompanyForm.ShowDialog();
                if (validateCompanyForm.DialogResult == DialogResult.OK)
                {
                    dbSupport.DeleteUpdateRequest(requestID);
                    LoadDataGrid();
                }
            }
        }

        private void searchBar_TextChanged(object? sender, EventArgs e)
        {
            string searchKey = searchBar.Text.Trim();
            if (string.IsNullOrEmpty(searchKey))
            {
                if (Requests != null)
                {
                    Requests.DefaultView.RowFilter = "";
                }
            }
            else if (int.TryParse(searchKey, out int result)) //If the search key is an Request ID number or Company ID
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
            if (Requests != null)
            {
                string filterExpression = string.Format("[Company Name] LIKE '%{0}%' OR [Industry] LIKE '%{0}%' OR " +
                             "[Company Address] LIKE '%{0}%' OR [Company Website] LIKE '%{0}%' OR [Contact Person Name] LIKE '%{0}%' OR " +
                             "[Contact Person Position] LIKE '%{0}%' OR [Contact Number] LIKE '%{0}%' OR [Contact Email] LIKE '%{0}%'", filter.Replace("'", "''"));
                Requests.DefaultView.RowFilter = filterExpression;
            }
        }

        private void FilterApplicationsByID(int filter)
        {
            if (Requests != null)
            {
                string filterExpression = string.Format("[RequestID] = {0} OR [CompanyUserID] = {0}", filter);
                Requests.DefaultView.RowFilter = filterExpression;
            }
        }
    }
}
