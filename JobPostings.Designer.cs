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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobPostings));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            deletePostBttn = new FontAwesome.Sharp.IconButton();
            postJobBttn = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            menuBarPanel2 = new Panel();
            menuBarPanel3 = new Panel();
            panel4 = new Panel();
            searchBar = new ReaLTaiizor.Controls.DungeonTextBox();
            companyLogo2 = new SiticoneNetCoreUI.SiticonePictureBox();
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
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            menuBarPanel2.SuspendLayout();
            menuBarPanel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)jobEntriesTable).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Controls.Add(deletePostBttn);
            panel2.Controls.Add(postJobBttn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1164, 72);
            panel2.TabIndex = 0;
            // 
            // deletePostBttn
            // 
            deletePostBttn.BackColor = Color.LightSlateGray;
            deletePostBttn.FlatAppearance.BorderSize = 0;
            deletePostBttn.FlatStyle = FlatStyle.Flat;
            deletePostBttn.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deletePostBttn.ForeColor = SystemColors.ButtonHighlight;
            deletePostBttn.IconChar = FontAwesome.Sharp.IconChar.None;
            deletePostBttn.IconColor = Color.White;
            deletePostBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deletePostBttn.IconSize = 30;
            deletePostBttn.Location = new Point(162, 15);
            deletePostBttn.Name = "deletePostBttn";
            deletePostBttn.Size = new Size(113, 38);
            deletePostBttn.TabIndex = 1;
            deletePostBttn.Text = "Delete Post";
            deletePostBttn.UseVisualStyleBackColor = false;
            deletePostBttn.Click += deletePostBttn_Click;
            // 
            // postJobBttn
            // 
            postJobBttn.BackColor = Color.LightSlateGray;
            postJobBttn.FlatAppearance.BorderSize = 0;
            postJobBttn.FlatStyle = FlatStyle.Flat;
            postJobBttn.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            postJobBttn.ForeColor = SystemColors.ButtonHighlight;
            postJobBttn.IconChar = FontAwesome.Sharp.IconChar.None;
            postJobBttn.IconColor = Color.White;
            postJobBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            postJobBttn.IconSize = 30;
            postJobBttn.Location = new Point(39, 15);
            postJobBttn.Name = "postJobBttn";
            postJobBttn.Size = new Size(81, 38);
            postJobBttn.TabIndex = 0;
            postJobBttn.Text = "Post";
            postJobBttn.UseVisualStyleBackColor = false;
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
            panel4.Controls.Add(searchBar);
            panel4.Controls.Add(companyLogo2);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(854, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(315, 51);
            panel4.TabIndex = 1;
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
            // 
            // companyLogo2
            // 
            companyLogo2.BackColor = Color.Transparent;
            companyLogo2.BorderColor = Color.Black;
            companyLogo2.BorderWidth = 1;
            companyLogo2.Brightness = 1F;
            companyLogo2.Contrast = 1F;
            companyLogo2.CornerRadius = 15;
            companyLogo2.DraggingSpeed = 3.15F;
            companyLogo2.EnableAsyncLoading = false;
            companyLogo2.EnableCaching = false;
            companyLogo2.EnableDragDrop = false;
            companyLogo2.EnableExtendedImageSources = false;
            companyLogo2.EnableFilters = false;
            companyLogo2.EnableFlipping = false;
            companyLogo2.EnableGlow = false;
            companyLogo2.EnableHighDpiSupport = false;
            companyLogo2.EnableMouseInteraction = false;
            companyLogo2.EnablePlaceholder = false;
            companyLogo2.EnableRotation = false;
            companyLogo2.EnableShadow = false;
            companyLogo2.EnableSlideshow = false;
            companyLogo2.FlipHorizontal = false;
            companyLogo2.FlipVertical = false;
            companyLogo2.Grayscale = false;
            companyLogo2.Image = (Image)resources.GetObject("companyLogo2.Image");
            companyLogo2.ImageOpacity = 1F;
            companyLogo2.Images = (List<Image>)resources.GetObject("companyLogo2.Images");
            companyLogo2.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            companyLogo2.IsCircular = true;
            companyLogo2.Location = new Point(255, 6);
            companyLogo2.MaintainAspectRatio = true;
            companyLogo2.Name = "companyLogo2";
            companyLogo2.PlaceholderImage = null;
            companyLogo2.RotationAngle = 0F;
            companyLogo2.Saturation = 1F;
            companyLogo2.ShowBorder = true;
            companyLogo2.Size = new Size(40, 40);
            companyLogo2.SizeMode = SiticoneNetCoreUI.SiticonePictureBoxSizeMode.StretchImage;
            companyLogo2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(label7);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(555, 51);
            panel5.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Geoform", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(15, 14);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Desktop;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            jobEntriesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            jobEntriesTable.ColumnHeadersHeight = 35;
            jobEntriesTable.Columns.AddRange(new DataGridViewColumn[] { postID, companyName, jobTitle, jobType, jobLocation, workMode, startingSalary, vacantPositions, postStatus, applicationDeadline });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            jobEntriesTable.DefaultCellStyle = dataGridViewCellStyle2;
            jobEntriesTable.Dock = DockStyle.Fill;
            jobEntriesTable.EnableHeadersVisualStyles = false;
            jobEntriesTable.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            jobEntriesTable.GridColor = Color.FromArgb(255, 255, 255);
            jobEntriesTable.Location = new Point(0, 0);
            jobEntriesTable.Name = "jobEntriesTable";
            jobEntriesTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            jobEntriesTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            panel3.Padding = new Padding(0, 3, 3, 3);
            panel3.Size = new Size(1169, 306);
            panel3.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.LightSlateGray;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1164, 298);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
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
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private FontAwesome.Sharp.IconButton postJobBttn;
        private Panel panel1;
        private Panel menuBarPanel2;
        private Panel menuBarPanel3;
        private Panel panel4;
        private SiticoneNetCoreUI.SiticonePictureBox companyLogo2;
        private Panel panel5;
        private Label label7;
        private Panel panel6;
        private ReaLTaiizor.Controls.DungeonTextBox searchBar;
        private FontAwesome.Sharp.IconButton deletePostBttn;
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
    }
}
