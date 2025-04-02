namespace Job_Application_Manager
{
    partial class JobApplicants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobApplicants));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            menuBarPanel2 = new Panel();
            menuBarPanel3 = new Panel();
            panel2 = new Panel();
            searchBar = new ReaLTaiizor.Controls.DungeonTextBox();
            companyLogo = new SiticoneNetCoreUI.SiticonePictureBox();
            panel3 = new Panel();
            label1 = new Label();
            flowPostsPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            shortlistBttn = new FontAwesome.Sharp.IconButton();
            forInterviewBttn = new FontAwesome.Sharp.IconButton();
            rejectBttn = new FontAwesome.Sharp.IconButton();
            acceptBttn = new FontAwesome.Sharp.IconButton();
            applicantsGridView = new ReaLTaiizor.Controls.PoisonDataGridView();
            panel6 = new Panel();
            menuBarPanel2.SuspendLayout();
            menuBarPanel3.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)applicantsGridView).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // menuBarPanel2
            // 
            menuBarPanel2.Controls.Add(menuBarPanel3);
            menuBarPanel2.Dock = DockStyle.Top;
            menuBarPanel2.Location = new Point(0, 0);
            menuBarPanel2.Name = "menuBarPanel2";
            menuBarPanel2.Padding = new Padding(0, 2, 0, 2);
            menuBarPanel2.Size = new Size(1169, 55);
            menuBarPanel2.TabIndex = 9;
            // 
            // menuBarPanel3
            // 
            menuBarPanel3.BackColor = SystemColors.Desktop;
            menuBarPanel3.Controls.Add(panel2);
            menuBarPanel3.Controls.Add(panel3);
            menuBarPanel3.Dock = DockStyle.Fill;
            menuBarPanel3.Location = new Point(0, 2);
            menuBarPanel3.Name = "menuBarPanel3";
            menuBarPanel3.Size = new Size(1169, 51);
            menuBarPanel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(searchBar);
            panel2.Controls.Add(companyLogo);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(864, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 51);
            panel2.TabIndex = 1;
            // 
            // searchBar
            // 
            searchBar.BackColor = Color.Transparent;
            searchBar.BorderColor = Color.FromArgb(180, 180, 180);
            searchBar.EdgeColor = Color.White;
            searchBar.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBar.ForeColor = Color.DimGray;
            searchBar.Location = new Point(13, 11);
            searchBar.MaxLength = 32767;
            searchBar.Multiline = false;
            searchBar.Name = "searchBar";
            searchBar.ReadOnly = false;
            searchBar.Size = new Size(223, 29);
            searchBar.TabIndex = 4;
            searchBar.Text = "  Type here to search...";
            searchBar.TextAlignment = HorizontalAlignment.Left;
            searchBar.UseSystemPasswordChar = false;
            searchBar.TextChanged += searchBar_TextChanged;
            // 
            // companyLogo
            // 
            companyLogo.BackColor = Color.Transparent;
            companyLogo.BorderColor = Color.Black;
            companyLogo.BorderWidth = 0;
            companyLogo.Brightness = 1F;
            companyLogo.Contrast = 1F;
            companyLogo.CornerRadius = 15;
            companyLogo.DraggingSpeed = 3.15F;
            companyLogo.EnableAsyncLoading = false;
            companyLogo.EnableCaching = false;
            companyLogo.EnableDragDrop = false;
            companyLogo.EnableExtendedImageSources = false;
            companyLogo.EnableFilters = false;
            companyLogo.EnableFlipping = false;
            companyLogo.EnableGlow = false;
            companyLogo.EnableHighDpiSupport = false;
            companyLogo.EnableMouseInteraction = false;
            companyLogo.EnablePlaceholder = false;
            companyLogo.EnableRotation = false;
            companyLogo.EnableShadow = false;
            companyLogo.EnableSlideshow = false;
            companyLogo.FlipHorizontal = false;
            companyLogo.FlipVertical = false;
            companyLogo.Grayscale = false;
            companyLogo.Image = null;
            companyLogo.ImageOpacity = 1F;
            companyLogo.Images = (List<Image>)resources.GetObject("companyLogo.Images");
            companyLogo.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            companyLogo.IsCircular = true;
            companyLogo.Location = new Point(250, 5);
            companyLogo.MaintainAspectRatio = true;
            companyLogo.Name = "companyLogo";
            companyLogo.PlaceholderImage = null;
            companyLogo.RotationAngle = 0F;
            companyLogo.Saturation = 1F;
            companyLogo.ShowBorder = false;
            companyLogo.Size = new Size(40, 40);
            companyLogo.SizeMode = SiticoneNetCoreUI.SiticonePictureBoxSizeMode.StretchImage;
            companyLogo.TabIndex = 0;
            companyLogo.Text = "siticonePictureBox1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(555, 51);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geoform", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(479, 22);
            label1.TabIndex = 1;
            label1.Text = "VIEW JOB APPLICANTS FOR EACH JOB POST";
            // 
            // flowPostsPanel
            // 
            flowPostsPanel.AutoScroll = true;
            flowPostsPanel.BackColor = Color.LightSlateGray;
            flowPostsPanel.Dock = DockStyle.Fill;
            flowPostsPanel.FlowDirection = FlowDirection.TopDown;
            flowPostsPanel.Location = new Point(3, 3);
            flowPostsPanel.Name = "flowPostsPanel";
            flowPostsPanel.Size = new Size(413, 644);
            flowPostsPanel.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(flowPostsPanel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(421, 652);
            panel1.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(421, 630);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 3, 3, 3);
            panel4.Size = new Size(748, 77);
            panel4.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Desktop;
            panel5.Controls.Add(shortlistBttn);
            panel5.Controls.Add(forInterviewBttn);
            panel5.Controls.Add(rejectBttn);
            panel5.Controls.Add(acceptBttn);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(743, 69);
            panel5.TabIndex = 0;
            // 
            // shortlistBttn
            // 
            shortlistBttn.BackColor = Color.LightSlateGray;
            shortlistBttn.FlatAppearance.BorderSize = 0;
            shortlistBttn.FlatStyle = FlatStyle.Flat;
            shortlistBttn.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shortlistBttn.ForeColor = SystemColors.ButtonHighlight;
            shortlistBttn.IconChar = FontAwesome.Sharp.IconChar.None;
            shortlistBttn.IconColor = Color.White;
            shortlistBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            shortlistBttn.IconSize = 30;
            shortlistBttn.Location = new Point(494, 15);
            shortlistBttn.Name = "shortlistBttn";
            shortlistBttn.Size = new Size(122, 38);
            shortlistBttn.TabIndex = 3;
            shortlistBttn.Text = "Shortlist";
            shortlistBttn.UseVisualStyleBackColor = false;
            shortlistBttn.Click += shortlistBttn_Click;
            // 
            // forInterviewBttn
            // 
            forInterviewBttn.BackColor = Color.LightSlateGray;
            forInterviewBttn.FlatAppearance.BorderSize = 0;
            forInterviewBttn.FlatStyle = FlatStyle.Flat;
            forInterviewBttn.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forInterviewBttn.ForeColor = SystemColors.ButtonHighlight;
            forInterviewBttn.IconChar = FontAwesome.Sharp.IconChar.None;
            forInterviewBttn.IconColor = Color.White;
            forInterviewBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            forInterviewBttn.IconSize = 30;
            forInterviewBttn.Location = new Point(227, 15);
            forInterviewBttn.Name = "forInterviewBttn";
            forInterviewBttn.Size = new Size(122, 38);
            forInterviewBttn.TabIndex = 2;
            forInterviewBttn.Text = "For Interview";
            forInterviewBttn.UseVisualStyleBackColor = false;
            forInterviewBttn.Click += forInterviewBttn_Click;
            // 
            // rejectBttn
            // 
            rejectBttn.BackColor = Color.LightSlateGray;
            rejectBttn.FlatAppearance.BorderSize = 0;
            rejectBttn.FlatStyle = FlatStyle.Flat;
            rejectBttn.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rejectBttn.ForeColor = SystemColors.ButtonHighlight;
            rejectBttn.IconChar = FontAwesome.Sharp.IconChar.None;
            rejectBttn.IconColor = Color.White;
            rejectBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rejectBttn.IconSize = 30;
            rejectBttn.Location = new Point(128, 15);
            rejectBttn.Name = "rejectBttn";
            rejectBttn.Size = new Size(81, 38);
            rejectBttn.TabIndex = 1;
            rejectBttn.Text = "Reject";
            rejectBttn.UseVisualStyleBackColor = false;
            rejectBttn.Click += rejectBttn_Click;
            // 
            // acceptBttn
            // 
            acceptBttn.BackColor = Color.LightSlateGray;
            acceptBttn.FlatAppearance.BorderSize = 0;
            acceptBttn.FlatStyle = FlatStyle.Flat;
            acceptBttn.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acceptBttn.ForeColor = SystemColors.ButtonHighlight;
            acceptBttn.IconChar = FontAwesome.Sharp.IconChar.None;
            acceptBttn.IconColor = Color.White;
            acceptBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            acceptBttn.IconSize = 30;
            acceptBttn.Location = new Point(28, 15);
            acceptBttn.Name = "acceptBttn";
            acceptBttn.Size = new Size(81, 38);
            acceptBttn.TabIndex = 0;
            acceptBttn.Text = "Accept";
            acceptBttn.UseVisualStyleBackColor = false;
            acceptBttn.Click += acceptBttn_Click;
            // 
            // applicantsGridView
            // 
            applicantsGridView.AllowUserToAddRows = false;
            applicantsGridView.AllowUserToResizeRows = false;
            applicantsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            applicantsGridView.BackgroundColor = Color.FromArgb(255, 255, 255);
            applicantsGridView.BorderStyle = BorderStyle.None;
            applicantsGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            applicantsGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Desktop;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            applicantsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            applicantsGridView.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            applicantsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            applicantsGridView.Dock = DockStyle.Fill;
            applicantsGridView.EnableHeadersVisualStyles = false;
            applicantsGridView.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            applicantsGridView.GridColor = Color.FromArgb(255, 255, 255);
            applicantsGridView.Location = new Point(0, 0);
            applicantsGridView.Name = "applicantsGridView";
            applicantsGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            applicantsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            applicantsGridView.RowHeadersVisible = false;
            applicantsGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            applicantsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            applicantsGridView.Size = new Size(743, 575);
            applicantsGridView.TabIndex = 13;
            applicantsGridView.CellClick += applicantsGridView_CellClick;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonHighlight;
            panel6.Controls.Add(applicantsGridView);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(421, 55);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 0, 5, 0);
            panel6.Size = new Size(748, 575);
            panel6.TabIndex = 14;
            // 
            // JobApplicants
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(menuBarPanel2);
            Name = "JobApplicants";
            Size = new Size(1169, 707);
            menuBarPanel2.ResumeLayout(false);
            menuBarPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)applicantsGridView).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel menuBarPanel2;
        private Panel menuBarPanel3;
        private Panel panel2;
        private SiticoneNetCoreUI.SiticonePictureBox companyLogo;
        private Panel panel3;
        private Label label1;
        private FlowLayoutPanel flowPostsPanel;
        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton acceptBttn;
        private ReaLTaiizor.Controls.PoisonDataGridView applicantsGridView;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton rejectBttn;
        private FontAwesome.Sharp.IconButton forInterviewBttn;
        private FontAwesome.Sharp.IconButton shortlistBttn;
        private ReaLTaiizor.Controls.DungeonTextBox searchBar;
    }
}
