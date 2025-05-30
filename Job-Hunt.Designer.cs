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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            menuBarPanel2 = new Panel();
            menuBarPanel3 = new Panel();
            panel2 = new Panel();
            profilePicture = new ReaLTaiizor.Controls.ParrotPictureBox();
            searchBar = new ReaLTaiizor.Controls.DungeonTextBox();
            panel3 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            flowPostsPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            SavedJobPostGridView = new ReaLTaiizor.Controls.PoisonDataGridView();
            savingOpt = new ContextMenuStrip(components);
            deleteSavedPostStripMenuItem = new ToolStripMenuItem();
            panel7 = new Panel();
            label3 = new Label();
            panel8 = new Panel();
            filterIndustry = new ComboBox();
            label8 = new Label();
            filterSearch = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            filterLocation = new ComboBox();
            resetFilterSearch = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            filterWorkMode = new CheckedListBox();
            filterVacancy = new ComboBox();
            label4 = new Label();
            filterJobType = new CheckedListBox();
            label7 = new Label();
            panel5 = new Panel();
            label2 = new Label();
            FullTime = new ReaLTaiizor.Controls.MaterialCheckBox();
            PartTime = new ReaLTaiizor.Controls.MaterialCheckBox();
            menuBarPanel2.SuspendLayout();
            menuBarPanel3.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SavedJobPostGridView).BeginInit();
            savingOpt.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
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
            panel2.Controls.Add(profilePicture);
            panel2.Controls.Add(searchBar);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(558, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(332, 51);
            panel2.TabIndex = 1;
            // 
            // profilePicture
            // 
            profilePicture.BackColor = Color.Transparent;
            profilePicture.BackgroundImageLayout = ImageLayout.Zoom;
            profilePicture.ColorLeft = Color.Transparent;
            profilePicture.ColorRight = Color.Transparent;
            profilePicture.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            profilePicture.FilterAlpha = 0;
            profilePicture.FilterEnabled = false;
            profilePicture.Image = Properties.Resources._482748566_677122558084783_2784408297271869644_n;
            profilePicture.ImeMode = ImeMode.NoControl;
            profilePicture.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            profilePicture.IsElipse = true;
            profilePicture.IsParallax = false;
            profilePicture.Location = new Point(268, 5);
            profilePicture.Name = "profilePicture";
            profilePicture.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            profilePicture.Size = new Size(40, 40);
            profilePicture.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            profilePicture.TabIndex = 4;
            profilePicture.Text = "parrotPictureBox1";
            profilePicture.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
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
            searchBar.Enter += searchBar_Enter;
            searchBar.Leave += searchBar_Leave;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(iconPictureBox1);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(562, 51);
            panel3.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Suitcase;
            iconPictureBox1.IconColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(17, 8);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 4;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geoform", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(63, 13);
            label1.Name = "label1";
            label1.Size = new Size(471, 25);
            label1.TabIndex = 1;
            label1.Text = "HUNT AND APPLY TO YOUR DREAM JOB";
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
            // panel6
            // 
            panel6.Controls.Add(SavedJobPostGridView);
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 390);
            panel6.Name = "panel6";
            panel6.Size = new Size(284, 211);
            panel6.TabIndex = 2;
            // 
            // SavedJobPostGridView
            // 
            SavedJobPostGridView.AllowUserToAddRows = false;
            SavedJobPostGridView.AllowUserToResizeRows = false;
            SavedJobPostGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SavedJobPostGridView.BackgroundColor = SystemColors.Desktop;
            SavedJobPostGridView.BorderStyle = BorderStyle.None;
            SavedJobPostGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            SavedJobPostGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Desktop;
            dataGridViewCellStyle4.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            SavedJobPostGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            SavedJobPostGridView.ColumnHeadersHeight = 35;
            SavedJobPostGridView.ContextMenuStrip = savingOpt;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Desktop;
            dataGridViewCellStyle5.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            SavedJobPostGridView.DefaultCellStyle = dataGridViewCellStyle5;
            SavedJobPostGridView.Dock = DockStyle.Fill;
            SavedJobPostGridView.EnableHeadersVisualStyles = false;
            SavedJobPostGridView.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            SavedJobPostGridView.GridColor = Color.FromArgb(255, 255, 255);
            SavedJobPostGridView.Location = new Point(0, 34);
            SavedJobPostGridView.Name = "SavedJobPostGridView";
            SavedJobPostGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            SavedJobPostGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            SavedJobPostGridView.RowHeadersVisible = false;
            SavedJobPostGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            SavedJobPostGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SavedJobPostGridView.Size = new Size(284, 177);
            SavedJobPostGridView.TabIndex = 19;
            SavedJobPostGridView.CellClick += SavedJobPostGridView_CellClick;
            SavedJobPostGridView.CellDoubleClick += SavedJobPostGridView_CellDoubleClick;
            SavedJobPostGridView.MouseDown += SavedJobPostGridView_MouseDown;
            // 
            // savingOpt
            // 
            savingOpt.BackColor = SystemColors.ButtonHighlight;
            savingOpt.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            savingOpt.Items.AddRange(new ToolStripItem[] { deleteSavedPostStripMenuItem });
            savingOpt.Name = "logoMenuOpt";
            savingOpt.Size = new Size(180, 26);
            // 
            // deleteSavedPostStripMenuItem
            // 
            deleteSavedPostStripMenuItem.Image = Properties.Resources.delete;
            deleteSavedPostStripMenuItem.Name = "deleteSavedPostStripMenuItem";
            deleteSavedPostStripMenuItem.Size = new Size(179, 22);
            deleteSavedPostStripMenuItem.Text = "Delete Saved Post";
            deleteSavedPostStripMenuItem.Click += deleteSavedPostStripMenuItem_Click;
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
            // panel8
            // 
            panel8.Controls.Add(filterIndustry);
            panel8.Controls.Add(label8);
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
            panel8.Size = new Size(284, 356);
            panel8.TabIndex = 3;
            // 
            // filterIndustry
            // 
            filterIndustry.FlatStyle = FlatStyle.Flat;
            filterIndustry.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterIndustry.ForeColor = SystemColors.ControlDarkDark;
            filterIndustry.FormattingEnabled = true;
            filterIndustry.Items.AddRange(new object[] { "Advertising and Marketing", "Agriculture", "Computer and Technology", "Construction", "Education", "Energy", "Entertainment", "Fashion", "Finance and Economics", "Food and Beverage", "Healthcare", "Hospitality", "Legal", "Manufacturing", "Media and News", "Mining", "Outsourcing", "Pharmaceuticals", "Telecommunications", "Transportaion" });
            filterIndustry.Location = new Point(20, 321);
            filterIndustry.Name = "filterIndustry";
            filterIndustry.Size = new Size(136, 24);
            filterIndustry.TabIndex = 14;
            filterIndustry.Text = " Industry";
            filterIndustry.SelectedIndexChanged += filterIndustry_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(9, 293);
            label8.Name = "label8";
            label8.Size = new Size(81, 19);
            label8.TabIndex = 13;
            label8.Text = "INDUSTRY";
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
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SavedJobPostGridView).EndInit();
            savingOpt.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel menuBarPanel2;
        private Panel menuBarPanel3;
        private Panel panel2;
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
        private ReaLTaiizor.Controls.PoisonDataGridView SavedJobPostGridView;
        private ContextMenuStrip savingOpt;
        private ToolStripMenuItem deleteSavedPostStripMenuItem;
        private ReaLTaiizor.Controls.ParrotPictureBox profilePicture;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private ComboBox filterIndustry;
        private Label label8;
    }
}
