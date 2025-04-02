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
    public partial class GenCompanyInfoTable : UserControl
    {
        DatabaseSupport dbSupport = new DatabaseSupport();
        private int companyUserID;
        public GenCompanyInfoTable()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            companyInfoTable.DataSource = dbSupport.GetCompanyData();
            string buttonColumnName = "Files";
            if (!companyInfoTable.Columns.Contains(buttonColumnName))
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = buttonColumnName;
                buttonColumn.HeaderText = "Files";
                buttonColumn.Text = "View Files";
                buttonColumn.UseColumnTextForButtonValue = true;
                companyInfoTable.Columns.Add(buttonColumn);
            }
        }

        private void approveBttn_Click(object sender, EventArgs e)
        {
            dbSupport.UpdateCompanyStatus(companyUserID, "APPROVED");
        }

        private void disapproveBttn_Click(object sender, EventArgs e)
        {
            dbSupport.UpdateCompanyStatus(companyUserID, "DISAPPROVED");
        }

        private void companyInfoTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if(indexRow > 0)
            {
                DataGridViewRow row = companyInfoTable.Rows[indexRow];
                companyUserID = Convert.ToInt32(row.Cells[0].Value);

                if (e.ColumnIndex == companyInfoTable.Columns["Files"].Index)
                {
                    dbSupport.RetrieveFiles(companyUserID);
                }
            }
        }
    }
}
