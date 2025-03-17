namespace Job_Application_Manager
{
    partial class TableView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            jobApplicationsTable = new Guna.UI2.WinForms.Guna2DataGridView();
            userID = new DataGridViewTextBoxColumn();
            ApplicationID = new DataGridViewTextBoxColumn();
            Company = new DataGridViewTextBoxColumn();
            JobTitle = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            WorkEnvi = new DataGridViewTextBoxColumn();
            DateApplied = new DataGridViewTextBoxColumn();
            ToDos = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)jobApplicationsTable).BeginInit();
            SuspendLayout();
            // 
            // jobApplicationsTable
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            jobApplicationsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            jobApplicationsTable.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            jobApplicationsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            jobApplicationsTable.ColumnHeadersHeight = 45;
            jobApplicationsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            jobApplicationsTable.Columns.AddRange(new DataGridViewColumn[] { userID, ApplicationID, Company, JobTitle, Status, WorkEnvi, DateApplied, ToDos });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            jobApplicationsTable.DefaultCellStyle = dataGridViewCellStyle3;
            jobApplicationsTable.Dock = DockStyle.Fill;
            jobApplicationsTable.GridColor = Color.FromArgb(231, 229, 255);
            jobApplicationsTable.Location = new Point(0, 0);
            jobApplicationsTable.Name = "jobApplicationsTable";
            jobApplicationsTable.RowHeadersVisible = false;
            jobApplicationsTable.Size = new Size(893, 604);
            jobApplicationsTable.TabIndex = 0;
            jobApplicationsTable.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            jobApplicationsTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            jobApplicationsTable.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            jobApplicationsTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            jobApplicationsTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            jobApplicationsTable.ThemeStyle.BackColor = SystemColors.ButtonHighlight;
            jobApplicationsTable.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            jobApplicationsTable.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            jobApplicationsTable.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            jobApplicationsTable.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            jobApplicationsTable.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            jobApplicationsTable.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            jobApplicationsTable.ThemeStyle.HeaderStyle.Height = 45;
            jobApplicationsTable.ThemeStyle.ReadOnly = false;
            jobApplicationsTable.ThemeStyle.RowsStyle.BackColor = Color.White;
            jobApplicationsTable.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            jobApplicationsTable.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            jobApplicationsTable.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            jobApplicationsTable.ThemeStyle.RowsStyle.Height = 25;
            jobApplicationsTable.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            jobApplicationsTable.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // userID
            // 
            userID.HeaderText = "UserID";
            userID.Name = "userID";
            // 
            // ApplicationID
            // 
            ApplicationID.HeaderText = "Application ID";
            ApplicationID.Name = "ApplicationID";
            // 
            // Company
            // 
            Company.HeaderText = "Company";
            Company.Name = "Company";
            // 
            // JobTitle
            // 
            JobTitle.HeaderText = "Job Title";
            JobTitle.Name = "JobTitle";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // WorkEnvi
            // 
            WorkEnvi.HeaderText = "Work Environment";
            WorkEnvi.Name = "WorkEnvi";
            // 
            // DateApplied
            // 
            DateApplied.HeaderText = "Date Applied";
            DateApplied.Name = "DateApplied";
            // 
            // ToDos
            // 
            ToDos.HeaderText = "Other Notes";
            ToDos.Name = "ToDos";
            // 
            // TableView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(jobApplicationsTable);
            Name = "TableView";
            Size = new Size(893, 604);
            ((System.ComponentModel.ISupportInitialize)jobApplicationsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView jobApplicationsTable;
        private DataGridViewTextBoxColumn userID;
        private DataGridViewTextBoxColumn ApplicationID;
        private DataGridViewTextBoxColumn Company;
        private DataGridViewTextBoxColumn JobTitle;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn WorkEnvi;
        private DataGridViewTextBoxColumn DateApplied;
        private DataGridViewTextBoxColumn ToDos;
    }
}
