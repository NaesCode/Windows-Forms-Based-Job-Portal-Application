namespace Job_Application_Manager
{
    partial class GenCompanyInfoTable
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
            panel1 = new Panel();
            disapproveBttn = new Button();
            approveBttn = new Button();
            companyInfoTable = new ReaLTaiizor.Controls.PoisonDataGridView();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)companyInfoTable).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(disapproveBttn);
            panel1.Controls.Add(approveBttn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 486);
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 118);
            panel1.TabIndex = 1;
            // 
            // disapproveBttn
            // 
            disapproveBttn.BackColor = SystemColors.ButtonHighlight;
            disapproveBttn.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 229, 148);
            disapproveBttn.FlatStyle = FlatStyle.Flat;
            disapproveBttn.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            disapproveBttn.Location = new Point(163, 37);
            disapproveBttn.Name = "disapproveBttn";
            disapproveBttn.Size = new Size(107, 52);
            disapproveBttn.TabIndex = 45;
            disapproveBttn.Text = "Reject";
            disapproveBttn.UseVisualStyleBackColor = false;
            disapproveBttn.Click += disapproveBttn_Click;
            // 
            // approveBttn
            // 
            approveBttn.BackColor = SystemColors.ButtonHighlight;
            approveBttn.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 229, 148);
            approveBttn.FlatStyle = FlatStyle.Flat;
            approveBttn.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            approveBttn.Location = new Point(49, 37);
            approveBttn.Name = "approveBttn";
            approveBttn.Size = new Size(83, 52);
            approveBttn.TabIndex = 44;
            approveBttn.Text = "Approve";
            approveBttn.UseVisualStyleBackColor = false;
            approveBttn.Click += approveBttn_Click;
            // 
            // companyInfoTable
            // 
            companyInfoTable.AllowUserToAddRows = false;
            companyInfoTable.AllowUserToResizeRows = false;
            companyInfoTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            companyInfoTable.BackgroundColor = Color.FromArgb(255, 255, 255);
            companyInfoTable.BorderStyle = BorderStyle.None;
            companyInfoTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            companyInfoTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.IndianRed;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            companyInfoTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            companyInfoTable.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            companyInfoTable.DefaultCellStyle = dataGridViewCellStyle2;
            companyInfoTable.Dock = DockStyle.Fill;
            companyInfoTable.EnableHeadersVisualStyles = false;
            companyInfoTable.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            companyInfoTable.GridColor = Color.FromArgb(255, 255, 255);
            companyInfoTable.Location = new Point(0, 0);
            companyInfoTable.Name = "companyInfoTable";
            companyInfoTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            companyInfoTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            companyInfoTable.RowHeadersVisible = false;
            companyInfoTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            companyInfoTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            companyInfoTable.Size = new Size(883, 486);
            companyInfoTable.TabIndex = 2;
            companyInfoTable.CellClick += companyInfoTable_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(companyInfoTable);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 10, 0);
            panel2.Size = new Size(893, 486);
            panel2.TabIndex = 3;
            // 
            // GenCompanyInfoTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "GenCompanyInfoTable";
            Size = new Size(893, 604);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)companyInfoTable).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button disapproveBttn;
        private Button approveBttn;
        private ReaLTaiizor.Controls.PoisonDataGridView companyInfoTable;
        private Panel panel2;
    }
}
