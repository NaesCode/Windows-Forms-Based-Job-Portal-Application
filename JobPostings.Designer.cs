namespace Job_Application_Manager
{
    partial class JobPostings
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel2 = new Panel();
            updatePostBttn = new ReaLTaiizor.Controls.Button();
            deletePostBttn = new ReaLTaiizor.Controls.Button();
            postJobBttn = new ReaLTaiizor.Controls.Button();
            panel1 = new Panel();
            menuBarPanel2 = new Panel();
            menuBarPanel3 = new Panel();
            panel4 = new Panel();
            companyLogo2 = new ReaLTaiizor.Controls.ParrotPictureBox();
            searchBar = new ReaLTaiizor.Controls.DungeonTextBox();
            panel5 = new Panel();
            label7 = new Label();
            panel6 = new Panel();
            jobEntriesTable = new ReaLTaiizor.Controls.PoisonDataGridView();
            postID = new DataGridViewTextBoxColumn();
            companyName = new DataGridViewTextBoxColumn();
            jobTitle = new DataGridViewTextBoxColumn();
            jobType = new DataGridViewTextBoxColumn();
            jobLocation = new DataGridViewTextBoxColumn();
            workMode = new DataGridViewTextBoxColumn();
            startingSalary = new DataGridViewTextBoxColumn();
            vacantPositions = new DataGridViewTextBoxColumn();
            postStatus = new DataGridViewTextBoxColumn();
            applicationDeadline = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            menuBarPanel2.SuspendLayout();
            menuBarPanel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)jobEntriesTable).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Controls.Add(updatePostBttn);
            panel2.Controls.Add(deletePostBttn);
            panel2.Controls.Add(postJobBttn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1164, 72);
            panel2.TabIndex = 0;
            // 
            // updatePostBttn
            // 
            updatePostBttn.BackColor = Color.Transparent;
            updatePostBttn.BackgroundImageLayout = ImageLayout.None;
            updatePostBttn.BorderColor = Color.Transparent;
            updatePostBttn.EnteredBorderColor = Color.Black;
            updatePostBttn.EnteredColor = Color.FromArgb(13, 59, 141);
            updatePostBttn.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updatePostBttn.Image = null;
            updatePostBttn.ImageAlign = ContentAlignment.MiddleLeft;
            updatePostBttn.InactiveColor = Color.LightSlateGray;
            updatePostBttn.Location = new Point(314, 15);
            updatePostBttn.Name = "updatePostBttn";
            updatePostBttn.PressedBorderColor = Color.Transparent;
            updatePostBttn.PressedColor = Color.FromArgb(13, 59, 141);
            updatePostBttn.Size = new Size(199, 38);
            updatePostBttn.TabIndex = 7;
            updatePostBttn.Text = "Update Post Descriptions";
            updatePostBttn.TextAlignment = StringAlignment.Center;
            updatePostBttn.Click += updatePostBttn_Click;
            // 
            // deletePostBttn
            // 
            deletePostBttn.BackColor = Color.Transparent;
            deletePostBttn.BackgroundImageLayout = ImageLayout.None;
            deletePostBttn.BorderColor = Color.Transparent;
            deletePostBttn.EnteredBorderColor = Color.Black;
            deletePostBttn.EnteredColor = Color.Firebrick;
            deletePostBttn.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deletePostBttn.Image = null;
            deletePostBttn.ImageAlign = ContentAlignment.MiddleLeft;
            deletePostBttn.InactiveColor = Color.LightSlateGray;
            deletePostBttn.Location = new Point(162, 15);
            deletePostBttn.Name = "deletePostBttn";
            deletePostBttn.PressedBorderColor = Color.Transparent;
            deletePostBttn.PressedColor = Color.Firebrick;
            deletePostBttn.Size = new Size(113, 38);
            deletePostBttn.TabIndex = 6;
            deletePostBttn.Text = "Delete Post";
            deletePostBttn.TextAlignment = StringAlignment.Center;
            deletePostBttn.Click += deletePostBttn_Click;
            // 
            // postJobBttn
            // 
            postJobBttn.BackColor = Color.Transparent;
            postJobBttn.BackgroundImageLayout = ImageLayout.None;
            postJobBttn.BorderColor = Color.Transparent;
            postJobBttn.EnteredBorderColor = Color.Black;
            postJobBttn.EnteredColor = Color.FromArgb(35, 168, 109);
            postJobBttn.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            postJobBttn.Image = null;
            postJobBttn.ImageAlign = ContentAlignment.MiddleLeft;
            postJobBttn.InactiveColor = Color.LightSlateGray;
            postJobBttn.Location = new Point(33, 15);
            postJobBttn.Name = "postJobBttn";
            postJobBttn.PressedBorderColor = Color.Transparent;
            postJobBttn.PressedColor = Color.FromArgb(35, 168, 109);
            postJobBttn.Size = new Size(88, 38);
            postJobBttn.TabIndex = 5;
            postJobBttn.Text = "Post";
            postJobBttn.TextAlignment = StringAlignment.Center;
            postJobBttn.Click += postJobBttn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 630);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 3, 3);
            panel1.Size = new Size(1169, 77);
            panel1.TabIndex = 2;
            // 
            // menuBarPanel2
            // 
            menuBarPanel2.Controls.Add(menuBarPanel3);
            menuBarPanel2.Dock = DockStyle.Top;
            menuBarPanel2.Location = new Point(0, 0);
            menuBarPanel2.Name = "menuBarPanel2";
            menuBarPanel2.Padding = new Padding(0, 2, 0, 2);
            menuBarPanel2.Size = new Size(1169, 55);
            menuBarPanel2.TabIndex = 10;
            // 
            // menuBarPanel3
            // 
            menuBarPanel3.BackColor = SystemColors.Desktop;
            menuBarPanel3.Controls.Add(panel4);
            menuBarPanel3.Controls.Add(panel5);
            menuBarPanel3.Dock = DockStyle.Fill;
            menuBarPanel3.Location = new Point(0, 2);
            menuBarPanel3.Name = "menuBarPanel3";
            menuBarPanel3.Size = new Size(1169, 51);
            menuBarPanel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(companyLogo2);
            panel4.Controls.Add(searchBar);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(854, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(315, 51);
            panel4.TabIndex = 1;
            // 
            // companyLogo2
            // 
            companyLogo2.BackColor = Color.Transparent;
            companyLogo2.BackgroundImageLayout = ImageLayout.Zoom;
            companyLogo2.ColorLeft = Color.Transparent;
            companyLogo2.ColorRight = Color.Transparent;
            companyLogo2.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            companyLogo2.FilterAlpha = 0;
            companyLogo2.FilterEnabled = false;
            companyLogo2.Image = Properties.Resources._482748566_677122558084783_2784408297271869644_n;
            companyLogo2.ImeMode = ImeMode.NoControl;
            companyLogo2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            companyLogo2.IsElipse = true;
            companyLogo2.IsParallax = false;
            companyLogo2.Location = new Point(255, 6);
            companyLogo2.Name = "companyLogo2";
            companyLogo2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            companyLogo2.Size = new Size(40, 40);
            companyLogo2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            companyLogo2.TabIndex = 3;
            companyLogo2.Text = "parrotPictureBox1";
            companyLogo2.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // searchBar
            // 
            searchBar.BackColor = Color.Transparent;
            searchBar.BorderColor = Color.FromArgb(180, 180, 180);
            searchBar.EdgeColor = Color.White;
            searchBar.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBar.ForeColor = Color.DimGray;
            searchBar.Location = new Point(10, 11);
            searchBar.MaxLength = 32767;
            searchBar.Multiline = false;
            searchBar.Name = "searchBar";
            searchBar.ReadOnly = false;
            searchBar.Size = new Size(225, 29);
            searchBar.TabIndex = 4;
            searchBar.Text = "  Type here to search...";
            searchBar.TextAlignment = HorizontalAlignment.Left;
            searchBar.UseSystemPasswordChar = false;
            searchBar.TextChanged += searchBar_TextChanged;
            searchBar.Enter += searchBar_Enter;
            searchBar.Leave += searchBar_Leave;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(iconPictureBox1);
            panel5.Controls.Add(label7);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(408, 51);
            panel5.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Geoform", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(70, 14);
            label7.Name = "label7";
            label7.Size = new Size(248, 25);
            label7.TabIndex = 1;
            label7.Text = "JOB POST PREVIEW:";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonHighlight;
            panel6.Controls.Add(jobEntriesTable);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 361);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 0, 5, 0);
            panel6.Size = new Size(1169, 269);
            panel6.TabIndex = 11;
            // 
            // jobEntriesTable
            // 
            jobEntriesTable.AllowUserToAddRows = false;
            jobEntriesTable.AllowUserToResizeRows = false;
            jobEntriesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            jobEntriesTable.BackgroundColor = Color.FromArgb(255, 255, 255);
            jobEntriesTable.BorderStyle = BorderStyle.None;
            jobEntriesTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            jobEntriesTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Desktop;
            dataGridViewCellStyle4.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            jobEntriesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            jobEntriesTable.ColumnHeadersHeight = 35;
            jobEntriesTable.Columns.AddRange(new DataGridViewColumn[] { postID, companyName, jobTitle, jobType, jobLocation, workMode, startingSalary, vacantPositions, postStatus, applicationDeadline });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            jobEntriesTable.DefaultCellStyle = dataGridViewCellStyle5;
            jobEntriesTable.Dock = DockStyle.Fill;
            jobEntriesTable.EnableHeadersVisualStyles = false;
            jobEntriesTable.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            jobEntriesTable.GridColor = Color.FromArgb(255, 255, 255);
            jobEntriesTable.Location = new Point(0, 0);
            jobEntriesTable.Name = "jobEntriesTable";
            jobEntriesTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            jobEntriesTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            jobEntriesTable.RowHeadersVisible = false;
            jobEntriesTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            jobEntriesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            jobEntriesTable.Size = new Size(1164, 269);
            jobEntriesTable.TabIndex = 14;
            jobEntriesTable.CellClick += jobEntriesTable_CellClick;
            jobEntriesTable.CellEndEdit += jobEntriesTable_CellEndEdit;
            // 
            // postID
            // 
            postID.HeaderText = "PostID";
            postID.Name = "postID";
            // 
            // companyName
            // 
            companyName.HeaderText = "Company";
            companyName.Name = "companyName";
            // 
            // jobTitle
            // 
            jobTitle.HeaderText = "Job";
            jobTitle.Name = "jobTitle";
            // 
            // jobType
            // 
            jobType.HeaderText = "Type";
            jobType.Name = "jobType";
            // 
            // jobLocation
            // 
            jobLocation.HeaderText = "Location";
            jobLocation.Name = "jobLocation";
            // 
            // workMode
            // 
            workMode.HeaderText = "Mode";
            workMode.Name = "workMode";
            // 
            // startingSalary
            // 
            startingSalary.HeaderText = "Salary";
            startingSalary.Name = "startingSalary";
            // 
            // vacantPositions
            // 
            vacantPositions.HeaderText = "Vacancy";
            vacantPositions.Name = "vacantPositions";
            // 
            // postStatus
            // 
            postStatus.HeaderText = "IsPosted";
            postStatus.Name = "postStatus";
            // 
            // applicationDeadline
            // 
            applicationDeadline.HeaderText = "Closing";
            applicationDeadline.Name = "applicationDeadline";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 55);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 0, 3, 3);
            panel3.Size = new Size(1169, 306);
            panel3.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.LightSlateGray;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1164, 301);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Upload;
            iconPictureBox1.IconColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(21, 7);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 6;
            iconPictureBox1.TabStop = false;
            // 
            // JobPostings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(menuBarPanel2);
            Name = "JobPostings";
            Size = new Size(1169, 707);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            menuBarPanel2.ResumeLayout(false);
            menuBarPanel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)jobEntriesTable).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private Panel menuBarPanel2;
        private Panel menuBarPanel3;
        private Panel panel4;
        private Panel panel5;
        private Label label7;
        private Panel panel6;
        private ReaLTaiizor.Controls.DungeonTextBox searchBar;
        private ReaLTaiizor.Controls.PoisonDataGridView jobEntriesTable;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridViewTextBoxColumn postID;
        private DataGridViewTextBoxColumn companyName;
        private DataGridViewTextBoxColumn jobTitle;
        private DataGridViewTextBoxColumn jobType;
        private DataGridViewTextBoxColumn jobLocation;
        private DataGridViewTextBoxColumn workMode;
        private DataGridViewTextBoxColumn startingSalary;
        private DataGridViewTextBoxColumn vacantPositions;
        private DataGridViewTextBoxColumn postStatus;
        private DataGridViewTextBoxColumn applicationDeadline;
        private ReaLTaiizor.Controls.Button postJobBttn;
        private ReaLTaiizor.Controls.Button deletePostBttn;
        private ReaLTaiizor.Controls.Button updatePostBttn;
        private ReaLTaiizor.Controls.ParrotPictureBox companyLogo2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
