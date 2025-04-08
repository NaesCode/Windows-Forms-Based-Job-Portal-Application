namespace Job_Application_Manager
{
    partial class Job_Hunt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Job_Hunt));
            menuBarPanel2 = new Panel();
            menuBarPanel3 = new Panel();
            panel2 = new Panel();
            searchBar = new ReaLTaiizor.Controls.DungeonTextBox();
            profilePicture = new SiticoneNetCoreUI.SiticonePictureBox();
            panel3 = new Panel();
            label1 = new Label();
            flowPostsPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            panel4 = new Panel();
            filterSearch = new FontAwesome.Sharp.IconButton();
            resetFilterSearch = new FontAwesome.Sharp.IconButton();
            filterVacancy = new ComboBox();
            label7 = new Label();
            filterWorkMode = new CheckedListBox();
            label6 = new Label();
            filterLocation = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            filterJobType = new CheckedListBox();
            panel6 = new Panel();
            panel7 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            label2 = new Label();
            FullTime = new ReaLTaiizor.Controls.MaterialCheckBox();
            PartTime = new ReaLTaiizor.Controls.MaterialCheckBox();
            panel8 = new Panel();
            menuBarPanel2.SuspendLayout();
            menuBarPanel3.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // menuBarPanel2
            // 
            menuBarPanel2.Controls.Add(menuBarPanel3);
            menuBarPanel2.Dock = DockStyle.Top;
            menuBarPanel2.Location = new Point(0, 0);
            menuBarPanel2.Name = "menuBarPanel2";
            menuBarPanel2.Padding = new Padding(0, 2, 0, 2);
            menuBarPanel2.Size = new Size(890, 55);
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
            menuBarPanel3.Size = new Size(890, 51);
            menuBarPanel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(searchBar);
            panel2.Controls.Add(profilePicture);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(558, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(332, 51);
            panel2.TabIndex = 1;
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
            searchBar.Size = new Size(241, 29);
            searchBar.TabIndex = 4;
            searchBar.Text = "  Type here to search...";
            searchBar.TextAlignment = HorizontalAlignment.Left;
            searchBar.UseSystemPasswordChar = false;
            searchBar.TextChanged += searchBar_TextChanged;
            // 
            // profilePicture
            // 
            profilePicture.BackColor = Color.Transparent;
            profilePicture.BorderColor = Color.Black;
            profilePicture.BorderWidth = 1;
            profilePicture.Brightness = 1F;
            profilePicture.Contrast = 1F;
            profilePicture.CornerRadius = 15;
            profilePicture.DraggingSpeed = 3.15F;
            profilePicture.EnableAsyncLoading = false;
            profilePicture.EnableCaching = false;
            profilePicture.EnableDragDrop = false;
            profilePicture.EnableExtendedImageSources = false;
            profilePicture.EnableFilters = false;
            profilePicture.EnableFlipping = false;
            profilePicture.EnableGlow = false;
            profilePicture.EnableHighDpiSupport = false;
            profilePicture.EnableMouseInteraction = false;
            profilePicture.EnablePlaceholder = false;
            profilePicture.EnableRotation = false;
            profilePicture.EnableShadow = false;
            profilePicture.EnableSlideshow = false;
            profilePicture.FlipHorizontal = false;
            profilePicture.FlipVertical = false;
            profilePicture.Grayscale = false;
            profilePicture.Image = (Image)resources.GetObject("profilePicture.Image");
            profilePicture.ImageOpacity = 1F;
            profilePicture.Images = (List<Image>)resources.GetObject("profilePicture.Images");
            profilePicture.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            profilePicture.IsCircular = true;
            profilePicture.Location = new Point(268, 5);
            profilePicture.MaintainAspectRatio = true;
            profilePicture.Name = "profilePicture";
            profilePicture.PlaceholderImage = null;
            profilePicture.RotationAngle = 0F;
            profilePicture.Saturation = 1F;
            profilePicture.ShowBorder = true;
            profilePicture.Size = new Size(40, 40);
            profilePicture.SizeMode = SiticoneNetCoreUI.SiticonePictureBoxSizeMode.StretchImage;
            profilePicture.TabIndex = 0;
            profilePicture.Text = "siticonePictureBox1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(496, 51);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geoform", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 1;
            label1.Text = "DASHBOARD";
            // 
            // flowPostsPanel
            // 
            flowPostsPanel.AutoScroll = true;
            flowPostsPanel.BackColor = Color.LightSlateGray;
            flowPostsPanel.Dock = DockStyle.Fill;
            flowPostsPanel.FlowDirection = FlowDirection.TopDown;
            flowPostsPanel.Location = new Point(0, 55);
            flowPostsPanel.Name = "flowPostsPanel";
            flowPostsPanel.Size = new Size(600, 604);
            flowPostsPanel.TabIndex = 10;
            flowPostsPanel.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(600, 55);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3, 0, 3, 3);
            panel1.Size = new Size(290, 604);
            panel1.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.BackColor = SystemColors.Desktop;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.ForeColor = SystemColors.ButtonHighlight;
            panel4.Location = new Point(3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(284, 601);
            panel4.TabIndex = 0;
            // 
            // filterSearch
            // 
            filterSearch.FlatStyle = FlatStyle.Flat;
            filterSearch.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            filterSearch.IconColor = Color.Black;
            filterSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            filterSearch.Location = new Point(196, 151);
            filterSearch.Name = "filterSearch";
            filterSearch.Size = new Size(59, 31);
            filterSearch.TabIndex = 12;
            filterSearch.Text = "Filter";
            filterSearch.UseVisualStyleBackColor = true;
            filterSearch.Click += filterSearch_Click;
            // 
            // resetFilterSearch
            // 
            resetFilterSearch.FlatStyle = FlatStyle.Flat;
            resetFilterSearch.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetFilterSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            resetFilterSearch.IconColor = Color.Black;
            resetFilterSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            resetFilterSearch.Location = new Point(196, 192);
            resetFilterSearch.Name = "resetFilterSearch";
            resetFilterSearch.Size = new Size(59, 31);
            resetFilterSearch.TabIndex = 11;
            resetFilterSearch.Text = "Reset";
            resetFilterSearch.UseVisualStyleBackColor = true;
            resetFilterSearch.Click += resetFilterSearch_Click;
            // 
            // filterVacancy
            // 
            filterVacancy.FlatStyle = FlatStyle.Flat;
            filterVacancy.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterVacancy.ForeColor = SystemColors.ControlDarkDark;
            filterVacancy.FormattingEnabled = true;
            filterVacancy.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            filterVacancy.Location = new Point(20, 256);
            filterVacancy.Name = "filterVacancy";
            filterVacancy.Size = new Size(136, 24);
            filterVacancy.TabIndex = 10;
            filterVacancy.Text = "_ Available Post.";
            filterVacancy.SelectedIndexChanged += filterVacancy_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 228);
            label7.Name = "label7";
            label7.Size = new Size(78, 19);
            label7.TabIndex = 9;
            label7.Text = "VACANCY:";
            // 
            // filterWorkMode
            // 
            filterWorkMode.BackColor = SystemColors.Desktop;
            filterWorkMode.BorderStyle = BorderStyle.None;
            filterWorkMode.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterWorkMode.ForeColor = SystemColors.ButtonHighlight;
            filterWorkMode.FormattingEnabled = true;
            filterWorkMode.Items.AddRange(new object[] { "On-site", "Remote", "Hybrid", "Flexible" });
            filterWorkMode.Location = new Point(163, 43);
            filterWorkMode.Name = "filterWorkMode";
            filterWorkMode.Size = new Size(75, 72);
            filterWorkMode.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(151, 12);
            label6.Name = "label6";
            label6.Size = new Size(104, 19);
            label6.TabIndex = 7;
            label6.Text = "WORK MODE:";
            // 
            // filterLocation
            // 
            filterLocation.FlatStyle = FlatStyle.Flat;
            filterLocation.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterLocation.ForeColor = SystemColors.ControlDarkDark;
            filterLocation.FormattingEnabled = true;
            filterLocation.Items.AddRange(new object[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua&Deps", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "BosniaHerzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina", "Burundi", "Cambodia", "Cameroon", "Canada", "CapeVerde", "CentralAfricanRep", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Congo(DemocraticRep)", "CostaRica", "Croatia", "Cuba", "Cyprus", "CzechRepublic", "Denmark", "Djibouti", "Dominica", "DominicanRepublic", "EastTimor", "Ecuador", "Egypt", "ElSalvador", "EquatorialGuinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland(Republic)", "Israel", "Italy", "IvoryCoast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "KoreaNorth", "KoreaSouth", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "MarshallIslands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "NewZealand", "Nicaragua", "Niger", "Nigeria", "Norway", "Oman", "Pakistan", "Palau", "Palestine", "Panama", "PapuaNewGuinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "RussianFederation", "Rwanda", "StKitts&Nevis", "StLucia", "SaintVincent&theGrenadines", "Samoa", "SanMarino", "SaoTome&Principe", "SaudiArabia", "Senegal", "Serbia", "Seychelles", "SierraLeone", "Singapore", "Slovakia", "Slovenia", "SolomonIslands", "Somalia", "SouthAfrica", "SouthSudan", "Spain", "SriLanka", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad&Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "UnitedArabEmirates", "UnitedKingdom", "UnitedStates", "Uruguay", "Uzbekistan", "Vanuatu", "VaticanCity", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe" });
            filterLocation.Location = new Point(20, 192);
            filterLocation.Name = "filterLocation";
            filterLocation.Size = new Size(136, 24);
            filterLocation.TabIndex = 6;
            filterLocation.Text = "Country";
            filterLocation.SelectedIndexChanged += filterLocation_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 163);
            label5.Name = "label5";
            label5.Size = new Size(85, 19);
            label5.TabIndex = 5;
            label5.Text = "LOCATION:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 12);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 4;
            label4.Text = "JOB TYPE:";
            // 
            // filterJobType
            // 
            filterJobType.BackColor = SystemColors.Desktop;
            filterJobType.BorderStyle = BorderStyle.None;
            filterJobType.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterJobType.ForeColor = SystemColors.ButtonHighlight;
            filterJobType.FormattingEnabled = true;
            filterJobType.Items.AddRange(new object[] { "Full-Time", "Part-Time", "Contract", "Apprenticeship", "Internship", "Seasonal" });
            filterJobType.Location = new Point(20, 43);
            filterJobType.Name = "filterJobType";
            filterJobType.Size = new Size(113, 108);
            filterJobType.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 339);
            panel6.Name = "panel6";
            panel6.Size = new Size(284, 262);
            panel6.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(64, 64, 64);
            panel7.Controls.Add(label3);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(284, 34);
            panel7.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 7);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 0;
            label3.Text = "Saved";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(64, 64, 64);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(284, 34);
            panel5.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 7);
            label2.Name = "label2";
            label2.Size = new Size(106, 19);
            label2.TabIndex = 0;
            label2.Text = "Filter jobs by:";
            // 
            // FullTime
            // 
            FullTime.AutoSize = true;
            FullTime.Depth = 0;
            FullTime.Location = new Point(0, 0);
            FullTime.Margin = new Padding(0);
            FullTime.MouseLocation = new Point(-1, -1);
            FullTime.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            FullTime.Name = "FullTime";
            FullTime.ReadOnly = false;
            FullTime.Ripple = true;
            FullTime.Size = new Size(10, 10);
            FullTime.TabIndex = 0;
            FullTime.Text = "Full Time";
            FullTime.UseAccentColor = false;
            FullTime.UseVisualStyleBackColor = true;
            // 
            // PartTime
            // 
            PartTime.AutoSize = true;
            PartTime.Depth = 0;
            PartTime.Location = new Point(0, 0);
            PartTime.Margin = new Padding(0);
            PartTime.MouseLocation = new Point(-1, -1);
            PartTime.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            PartTime.Name = "PartTime";
            PartTime.ReadOnly = false;
            PartTime.Ripple = true;
            PartTime.Size = new Size(10, 10);
            PartTime.TabIndex = 0;
            PartTime.Text = "Part Time";
            PartTime.UseAccentColor = false;
            PartTime.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(filterSearch);
            panel8.Controls.Add(label6);
            panel8.Controls.Add(filterLocation);
            panel8.Controls.Add(resetFilterSearch);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(filterWorkMode);
            panel8.Controls.Add(filterVacancy);
            panel8.Controls.Add(label4);
            panel8.Controls.Add(filterJobType);
            panel8.Controls.Add(label7);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 34);
            panel8.Name = "panel8";
            panel8.Size = new Size(284, 305);
            panel8.TabIndex = 3;
            // 
            // Job_Hunt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowPostsPanel);
            Controls.Add(panel1);
            Controls.Add(menuBarPanel2);
            Name = "Job_Hunt";
            Size = new Size(890, 659);
            menuBarPanel2.ResumeLayout(false);
            menuBarPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel menuBarPanel2;
        private Panel menuBarPanel3;
        private Panel panel2;
        private SiticoneNetCoreUI.SiticonePictureBox profilePicture;
        private Panel panel3;
        private Label label1;
        private FlowLayoutPanel flowPostsPanel;
        private Panel panel1;
        private Panel panel4;
        private Panel panel6;
        private Panel panel7;
        private Label label3;
        private Panel panel5;
        private Label label2;
        private ReaLTaiizor.Controls.DungeonTextBox searchBar;
        private ReaLTaiizor.Controls.MaterialCheckBox FullTime;
        private ReaLTaiizor.Controls.MaterialCheckBox PartTime;
        private CheckedListBox filterJobType;
        private Label label4;
        private Label label5;
        private ComboBox filterLocation;
        private CheckedListBox filterWorkMode;
        private Label label6;
        private ComboBox filterVacancy;
        private Label label7;
        private FontAwesome.Sharp.IconButton resetFilterSearch;
        private FontAwesome.Sharp.IconButton filterSearch;
        private Panel panel8;
    }
}
