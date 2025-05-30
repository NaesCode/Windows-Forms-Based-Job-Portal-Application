namespace Job_Application_Manager
{
    partial class JobListing
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
            logoMenuOpt = new ContextMenuStrip(components);
            uploadLogoToolStripMenuItem = new ToolStripMenuItem();
            viewLogoToolStripMenuItem = new ToolStripMenuItem();
            deleteLogoToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            JobListingTabs = new ReaLTaiizor.Controls.HopeTabPage();
            tab0 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            label1 = new Label();
            JobTitle = new TextBox();
            CompanyName = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            checkedListBox1 = new CheckedListBox();
            JobType = new ComboBox();
            label3 = new Label();
            JobCategory = new ComboBox();
            label10 = new Label();
            label4 = new Label();
            Industry = new TextBox();
            label5 = new Label();
            panel6 = new Panel();
            label11 = new Label();
            nextTabBttn = new Button();
            companyLogo = new PictureBox();
            workModeLabel = new Label();
            startingSalary = new TextBox();
            startingSalaryLabel = new Label();
            label6 = new Label();
            applicationDeadline = new DateTimePicker();
            locationLabel = new Label();
            vacancyLabel = new Label();
            JobLocation = new TextBox();
            jobVacancy = new ComboBox();
            WorkMode = new ComboBox();
            tab1 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel5 = new Panel();
            JobDescription = new RichTextBox();
            label8 = new Label();
            panel7 = new Panel();
            label9 = new Label();
            ApplicationDetails = new RichTextBox();
            panel8 = new Panel();
            prevTabBttn = new Button();
            addJobBttn = new Button();
            clearInputsBttn = new Button();
            menuBarPanel2 = new Panel();
            menuBarPanel3 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label7 = new Label();
            logoMenuOpt.SuspendLayout();
            panel1.SuspendLayout();
            JobListingTabs.SuspendLayout();
            tab0.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)companyLogo).BeginInit();
            tab1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            menuBarPanel2.SuspendLayout();
            menuBarPanel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // logoMenuOpt
            // 
            logoMenuOpt.BackColor = SystemColors.ButtonHighlight;
            logoMenuOpt.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoMenuOpt.Items.AddRange(new ToolStripItem[] { uploadLogoToolStripMenuItem, viewLogoToolStripMenuItem, deleteLogoToolStripMenuItem });
            logoMenuOpt.Name = "logoMenuOpt";
            logoMenuOpt.Size = new Size(147, 70);
            // 
            // uploadLogoToolStripMenuItem
            // 
            uploadLogoToolStripMenuItem.Image = Properties.Resources.upload;
            uploadLogoToolStripMenuItem.Name = "uploadLogoToolStripMenuItem";
            uploadLogoToolStripMenuItem.Size = new Size(146, 22);
            uploadLogoToolStripMenuItem.Text = "Upload Logo";
            // 
            // viewLogoToolStripMenuItem
            // 
            viewLogoToolStripMenuItem.Image = Properties.Resources.image;
            viewLogoToolStripMenuItem.Name = "viewLogoToolStripMenuItem";
            viewLogoToolStripMenuItem.Size = new Size(146, 22);
            viewLogoToolStripMenuItem.Text = "View Logo";
            viewLogoToolStripMenuItem.Click += viewLogoToolStripMenuItem_Click;
            // 
            // deleteLogoToolStripMenuItem
            // 
            deleteLogoToolStripMenuItem.Image = Properties.Resources.deletePhoto;
            deleteLogoToolStripMenuItem.Name = "deleteLogoToolStripMenuItem";
            deleteLogoToolStripMenuItem.Size = new Size(146, 22);
            deleteLogoToolStripMenuItem.Text = "Delete Logo";
            deleteLogoToolStripMenuItem.Click += deleteLogoToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.Controls.Add(JobListingTabs);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 604);
            panel1.TabIndex = 10;
            // 
            // JobListingTabs
            // 
            JobListingTabs.BaseColor = Color.FromArgb(44, 55, 66);
            JobListingTabs.Controls.Add(tab0);
            JobListingTabs.Controls.Add(tab1);
            JobListingTabs.Dock = DockStyle.Fill;
            JobListingTabs.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JobListingTabs.ForeColorA = Color.Silver;
            JobListingTabs.ForeColorB = Color.Gray;
            JobListingTabs.ForeColorC = Color.FromArgb(150, 255, 255, 255);
            JobListingTabs.ItemSize = new Size(120, 40);
            JobListingTabs.Location = new Point(0, 0);
            JobListingTabs.Name = "JobListingTabs";
            JobListingTabs.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            JobListingTabs.SelectedIndex = 0;
            JobListingTabs.Size = new Size(922, 604);
            JobListingTabs.SizeMode = TabSizeMode.Fixed;
            JobListingTabs.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            JobListingTabs.TabIndex = 106;
            JobListingTabs.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            JobListingTabs.ThemeColorA = Color.FromArgb(5, 229, 148);
            JobListingTabs.ThemeColorB = Color.FromArgb(150, 64, 158, 255);
            JobListingTabs.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // tab0
            // 
            tab0.BackColor = Color.LightSlateGray;
            tab0.Controls.Add(tableLayoutPanel1);
            tab0.Location = new Point(0, 40);
            tab0.Name = "tab0";
            tab0.Padding = new Padding(3);
            tab0.Size = new Size(922, 564);
            tab0.TabIndex = 0;
            tab0.Text = "Primary";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.3231735F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.67683F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel6, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(916, 558);
            tableLayoutPanel1.TabIndex = 102;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(JobTitle);
            panel2.Controls.Add(CompanyName);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(checkedListBox1);
            panel2.Controls.Add(JobType);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(JobCategory);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(Industry);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(454, 552);
            panel2.TabIndex = 97;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 147);
            label1.Name = "label1";
            label1.Size = new Size(67, 18);
            label1.TabIndex = 75;
            label1.Text = "Job Title:";
            // 
            // JobTitle
            // 
            JobTitle.BackColor = SystemColors.InactiveCaption;
            JobTitle.BorderStyle = BorderStyle.None;
            JobTitle.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JobTitle.Location = new Point(189, 144);
            JobTitle.Multiline = true;
            JobTitle.Name = "JobTitle";
            JobTitle.Size = new Size(246, 27);
            JobTitle.TabIndex = 76;
            // 
            // CompanyName
            // 
            CompanyName.BackColor = SystemColors.InactiveCaption;
            CompanyName.BorderStyle = BorderStyle.None;
            CompanyName.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CompanyName.Location = new Point(189, 97);
            CompanyName.Multiline = true;
            CompanyName.Name = "CompanyName";
            CompanyName.Size = new Size(246, 27);
            CompanyName.TabIndex = 74;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.suitcase;
            pictureBox1.Location = new Point(45, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 93;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 101);
            label2.Name = "label2";
            label2.Size = new Size(116, 18);
            label2.TabIndex = 77;
            label2.Text = "Company Name:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = SystemColors.ButtonHighlight;
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Advertising and Marketing", "Agriculture", "Computer and Technology", "Construction", "Education", "Energy", "Entertainment", "Fashion", "Finance and Economics", "Food and Beverage", "Healthcare", "Hospitality", "Legal", "Manufacturing", "Media and News", "Mining", "Outsourcing", "Pharmaceuticals", "Telecommunications", "Transportaion" });
            checkedListBox1.Location = new Point(190, 311);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(245, 151);
            checkedListBox1.TabIndex = 84;
            // 
            // JobType
            // 
            JobType.BackColor = SystemColors.InactiveCaption;
            JobType.FlatStyle = FlatStyle.Flat;
            JobType.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JobType.FormattingEnabled = true;
            JobType.Items.AddRange(new object[] { "Full-Time", "Part-Time", "Contract", "Apprenticeship", "Internship", "Seasonal" });
            JobType.Location = new Point(189, 192);
            JobType.Name = "JobType";
            JobType.Size = new Size(246, 26);
            JobType.TabIndex = 78;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 195);
            label3.Name = "label3";
            label3.Size = new Size(68, 18);
            label3.TabIndex = 79;
            label3.Text = "Job Type:";
            // 
            // JobCategory
            // 
            JobCategory.BackColor = SystemColors.InactiveCaption;
            JobCategory.FlatStyle = FlatStyle.Flat;
            JobCategory.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JobCategory.FormattingEnabled = true;
            JobCategory.Items.AddRange(new object[] { "Accounting & Finance", "Administrative Support", "Architecture & Engineering", "Arts & Design", "Business Development", "Construction & Skilled Trades", "Consulting", "Customer Service", "Data Science & Analytics", "Education & Training", "Engineering", "Healthcare", "Hospitality & Travel", "Human Resources", "Information Technology (IT)", "Legal", "Logistics & Supply Chain", "Management", "Manufacturing & Production", "Marketing & Advertising", "Media & Communications", "Operations", "Project Management", "Public Relations (PR)", "Quality Assurance (QA)", "Real Estate", "Research & Development (R&D)", "Retail & Sales", "Science", "Security", "Social Services & Non-Profit", "Software Development", "Support Services", "Technical Support", "Telecommunications", "Training & Development", "Transportation & Logistics", "Writing & Editing" });
            JobCategory.Location = new Point(190, 239);
            JobCategory.Name = "JobCategory";
            JobCategory.Size = new Size(245, 26);
            JobCategory.TabIndex = 80;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(102, 33);
            label10.Name = "label10";
            label10.Size = new Size(229, 29);
            label10.TabIndex = 90;
            label10.Text = "Primary Job Details:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 293);
            label4.Name = "label4";
            label4.Size = new Size(64, 18);
            label4.TabIndex = 81;
            label4.Text = "Industry:";
            // 
            // Industry
            // 
            Industry.BackColor = SystemColors.InactiveCaption;
            Industry.BorderStyle = BorderStyle.None;
            Industry.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Industry.Location = new Point(190, 286);
            Industry.Multiline = true;
            Industry.Name = "Industry";
            Industry.Size = new Size(245, 27);
            Industry.TabIndex = 82;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 243);
            label5.Name = "label5";
            label5.Size = new Size(69, 18);
            label5.TabIndex = 84;
            label5.Text = "Category:";
            // 
            // panel6
            // 
            panel6.Controls.Add(label11);
            panel6.Controls.Add(nextTabBttn);
            panel6.Controls.Add(companyLogo);
            panel6.Controls.Add(workModeLabel);
            panel6.Controls.Add(startingSalary);
            panel6.Controls.Add(startingSalaryLabel);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(applicationDeadline);
            panel6.Controls.Add(locationLabel);
            panel6.Controls.Add(vacancyLabel);
            panel6.Controls.Add(JobLocation);
            panel6.Controls.Add(jobVacancy);
            panel6.Controls.Add(WorkMode);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(463, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(450, 552);
            panel6.TabIndex = 101;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(40, 87);
            label11.Name = "label11";
            label11.Size = new Size(206, 18);
            label11.TabIndex = 108;
            label11.Text = "Logo: (right click for options): ";
            // 
            // nextTabBttn
            // 
            nextTabBttn.BackColor = SystemColors.ButtonHighlight;
            nextTabBttn.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 229, 148);
            nextTabBttn.FlatStyle = FlatStyle.Flat;
            nextTabBttn.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextTabBttn.Location = new Point(331, 430);
            nextTabBttn.Name = "nextTabBttn";
            nextTabBttn.Size = new Size(101, 45);
            nextTabBttn.TabIndex = 109;
            nextTabBttn.Text = "Next";
            nextTabBttn.UseVisualStyleBackColor = false;
            nextTabBttn.Click += nextTabBttn_Click;
            // 
            // companyLogo
            // 
            companyLogo.BackColor = SystemColors.ControlDark;
            companyLogo.BorderStyle = BorderStyle.FixedSingle;
            companyLogo.ContextMenuStrip = logoMenuOpt;
            companyLogo.InitialImage = Properties.Resources.research;
            companyLogo.Location = new Point(269, 23);
            companyLogo.Name = "companyLogo";
            companyLogo.Size = new Size(163, 145);
            companyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            companyLogo.TabIndex = 50;
            companyLogo.TabStop = false;
            // 
            // workModeLabel
            // 
            workModeLabel.AutoSize = true;
            workModeLabel.BackColor = Color.Transparent;
            workModeLabel.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            workModeLabel.Location = new Point(40, 246);
            workModeLabel.Name = "workModeLabel";
            workModeLabel.Size = new Size(85, 18);
            workModeLabel.TabIndex = 102;
            workModeLabel.Text = "Work Mode:";
            // 
            // startingSalary
            // 
            startingSalary.BackColor = SystemColors.InactiveCaption;
            startingSalary.BorderStyle = BorderStyle.None;
            startingSalary.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startingSalary.Location = new Point(186, 285);
            startingSalary.Multiline = true;
            startingSalary.Name = "startingSalary";
            startingSalary.Size = new Size(246, 27);
            startingSalary.TabIndex = 105;
            // 
            // startingSalaryLabel
            // 
            startingSalaryLabel.AutoSize = true;
            startingSalaryLabel.BackColor = Color.Transparent;
            startingSalaryLabel.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startingSalaryLabel.Location = new Point(40, 294);
            startingSalaryLabel.Name = "startingSalaryLabel";
            startingSalaryLabel.Size = new Size(109, 18);
            startingSalaryLabel.TabIndex = 104;
            startingSalaryLabel.Text = "Starting Salary:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(40, 383);
            label6.Name = "label6";
            label6.Size = new Size(132, 18);
            label6.TabIndex = 98;
            label6.Text = "Closing (Deadline):\r\n";
            // 
            // applicationDeadline
            // 
            applicationDeadline.CalendarTitleBackColor = SystemColors.ControlText;
            applicationDeadline.CalendarTitleForeColor = SystemColors.ActiveCaption;
            applicationDeadline.CustomFormat = "MM/dd/yyyy h:mm tt";
            applicationDeadline.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            applicationDeadline.Format = DateTimePickerFormat.Custom;
            applicationDeadline.Location = new Point(186, 383);
            applicationDeadline.Name = "applicationDeadline";
            applicationDeadline.Size = new Size(246, 26);
            applicationDeadline.TabIndex = 99;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.BackColor = Color.Transparent;
            locationLabel.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            locationLabel.Location = new Point(40, 198);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(68, 18);
            locationLabel.TabIndex = 100;
            locationLabel.Text = "Location:";
            // 
            // vacancyLabel
            // 
            vacancyLabel.AutoSize = true;
            vacancyLabel.BackColor = Color.Transparent;
            vacancyLabel.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vacancyLabel.Location = new Point(40, 337);
            vacancyLabel.Name = "vacancyLabel";
            vacancyLabel.Size = new Size(64, 18);
            vacancyLabel.TabIndex = 106;
            vacancyLabel.Text = "Vacancy:";
            // 
            // JobLocation
            // 
            JobLocation.BackColor = SystemColors.InactiveCaption;
            JobLocation.BorderStyle = BorderStyle.None;
            JobLocation.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JobLocation.ForeColor = SystemColors.ControlDarkDark;
            JobLocation.Location = new Point(186, 190);
            JobLocation.Multiline = true;
            JobLocation.Name = "JobLocation";
            JobLocation.Size = new Size(246, 27);
            JobLocation.TabIndex = 101;
            JobLocation.Text = "Country, City";
            JobLocation.Enter += JobLocation_Enter;
            JobLocation.Leave += JobLocation_Leave;
            // 
            // jobVacancy
            // 
            jobVacancy.BackColor = SystemColors.InactiveCaption;
            jobVacancy.FlatStyle = FlatStyle.Flat;
            jobVacancy.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jobVacancy.FormattingEnabled = true;
            jobVacancy.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            jobVacancy.Location = new Point(186, 334);
            jobVacancy.Name = "jobVacancy";
            jobVacancy.Size = new Size(246, 26);
            jobVacancy.TabIndex = 107;
            // 
            // WorkMode
            // 
            WorkMode.BackColor = SystemColors.InactiveCaption;
            WorkMode.FlatStyle = FlatStyle.Flat;
            WorkMode.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WorkMode.FormattingEnabled = true;
            WorkMode.Items.AddRange(new object[] { "On-site", "Remote", "Hybrid", "Flexible Work Arrangement" });
            WorkMode.Location = new Point(186, 238);
            WorkMode.Name = "WorkMode";
            WorkMode.Size = new Size(246, 26);
            WorkMode.TabIndex = 103;
            // 
            // tab1
            // 
            tab1.BackColor = Color.LightSlateGray;
            tab1.Controls.Add(tableLayoutPanel2);
            tab1.Location = new Point(0, 40);
            tab1.Name = "tab1";
            tab1.Padding = new Padding(3);
            tab1.Size = new Size(922, 564);
            tab1.TabIndex = 1;
            tab1.Text = "Descriptions";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(916, 558);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(910, 552);
            flowLayoutPanel1.TabIndex = 97;
            // 
            // panel5
            // 
            panel5.AutoScroll = true;
            panel5.Controls.Add(JobDescription);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(601, 296);
            panel5.TabIndex = 101;
            // 
            // JobDescription
            // 
            JobDescription.BorderStyle = BorderStyle.None;
            JobDescription.Font = new Font("Bahnschrift", 11.25F);
            JobDescription.ForeColor = SystemColors.ControlDarkDark;
            JobDescription.Location = new Point(12, 54);
            JobDescription.Name = "JobDescription";
            JobDescription.Size = new Size(583, 239);
            JobDescription.TabIndex = 51;
            JobDescription.Text = "Enter job description and qualifications here...";
            JobDescription.Enter += JobDescription_Enter;
            JobDescription.Leave += JobDescription_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 18);
            label8.Name = "label8";
            label8.Size = new Size(224, 18);
            label8.TabIndex = 52;
            label8.Text = "Job Description && Qualifications:";
            // 
            // panel7
            // 
            panel7.Controls.Add(label9);
            panel7.Controls.Add(ApplicationDetails);
            panel7.Location = new Point(3, 305);
            panel7.Name = "panel7";
            panel7.Size = new Size(601, 296);
            panel7.TabIndex = 97;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 16);
            label9.Name = "label9";
            label9.Size = new Size(143, 18);
            label9.TabIndex = 54;
            label9.Text = "Application Process:";
            // 
            // ApplicationDetails
            // 
            ApplicationDetails.BorderStyle = BorderStyle.None;
            ApplicationDetails.Font = new Font("Bahnschrift", 11.25F);
            ApplicationDetails.ForeColor = SystemColors.ControlDarkDark;
            ApplicationDetails.Location = new Point(12, 52);
            ApplicationDetails.Name = "ApplicationDetails";
            ApplicationDetails.Size = new Size(583, 239);
            ApplicationDetails.TabIndex = 53;
            ApplicationDetails.Text = "Enter job application process details here...";
            ApplicationDetails.Enter += ApplicationDetails_Enter;
            ApplicationDetails.Leave += ApplicationDetails_Leave;
            // 
            // panel8
            // 
            panel8.Controls.Add(prevTabBttn);
            panel8.Controls.Add(addJobBttn);
            panel8.Controls.Add(clearInputsBttn);
            panel8.Location = new Point(3, 607);
            panel8.Name = "panel8";
            panel8.Size = new Size(535, 100);
            panel8.TabIndex = 97;
            // 
            // prevTabBttn
            // 
            prevTabBttn.BackColor = SystemColors.ButtonHighlight;
            prevTabBttn.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 229, 148);
            prevTabBttn.FlatStyle = FlatStyle.Flat;
            prevTabBttn.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prevTabBttn.Location = new Point(393, 10);
            prevTabBttn.Name = "prevTabBttn";
            prevTabBttn.Size = new Size(139, 52);
            prevTabBttn.TabIndex = 97;
            prevTabBttn.Text = "Back";
            prevTabBttn.UseVisualStyleBackColor = false;
            prevTabBttn.Click += prevTabBttn_Click;
            // 
            // addJobBttn
            // 
            addJobBttn.BackColor = SystemColors.ButtonHighlight;
            addJobBttn.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 229, 148);
            addJobBttn.FlatStyle = FlatStyle.Flat;
            addJobBttn.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addJobBttn.Location = new Point(12, 10);
            addJobBttn.Name = "addJobBttn";
            addJobBttn.Size = new Size(139, 52);
            addJobBttn.TabIndex = 95;
            addJobBttn.Text = "Add";
            addJobBttn.UseVisualStyleBackColor = false;
            addJobBttn.Click += addJobBttn_Click;
            // 
            // clearInputsBttn
            // 
            clearInputsBttn.BackColor = SystemColors.ButtonHighlight;
            clearInputsBttn.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 229, 148);
            clearInputsBttn.FlatStyle = FlatStyle.Flat;
            clearInputsBttn.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearInputsBttn.Location = new Point(203, 10);
            clearInputsBttn.Name = "clearInputsBttn";
            clearInputsBttn.Size = new Size(139, 52);
            clearInputsBttn.TabIndex = 96;
            clearInputsBttn.Text = "Clear All";
            clearInputsBttn.UseVisualStyleBackColor = false;
            clearInputsBttn.Click += clearInputsBttn_Click;
            // 
            // menuBarPanel2
            // 
            menuBarPanel2.Controls.Add(menuBarPanel3);
            menuBarPanel2.Dock = DockStyle.Top;
            menuBarPanel2.Location = new Point(0, 0);
            menuBarPanel2.Name = "menuBarPanel2";
            menuBarPanel2.Padding = new Padding(0, 2, 0, 2);
            menuBarPanel2.Size = new Size(922, 55);
            menuBarPanel2.TabIndex = 11;
            // 
            // menuBarPanel3
            // 
            menuBarPanel3.BackColor = SystemColors.Desktop;
            menuBarPanel3.Controls.Add(panel3);
            menuBarPanel3.Controls.Add(panel4);
            menuBarPanel3.Dock = DockStyle.Fill;
            menuBarPanel3.Location = new Point(0, 2);
            menuBarPanel3.Name = "menuBarPanel3";
            menuBarPanel3.Size = new Size(922, 51);
            menuBarPanel3.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Dock = DockStyle.Right;
            panel3.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.ForeColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(669, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(253, 51);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(iconPictureBox1);
            panel4.Controls.Add(label7);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(422, 51);
            panel4.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            iconPictureBox1.IconColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(19, 8);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 5;
            iconPictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Geoform", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(60, 13);
            label7.Name = "label7";
            label7.Size = new Size(287, 25);
            label7.TabIndex = 1;
            label7.Text = "COMPANY JOB LISTING:";
            // 
            // JobListing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightSlateGray;
            Controls.Add(panel1);
            Controls.Add(menuBarPanel2);
            Name = "JobListing";
            Size = new Size(922, 659);
            logoMenuOpt.ResumeLayout(false);
            panel1.ResumeLayout(false);
            JobListingTabs.ResumeLayout(false);
            tab0.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)companyLogo).EndInit();
            tab1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            menuBarPanel2.ResumeLayout(false);
            menuBarPanel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip logoMenuOpt;
        private ToolStripMenuItem uploadLogoToolStripMenuItem;
        private ToolStripMenuItem viewLogoToolStripMenuItem;
        private ToolStripMenuItem deleteLogoToolStripMenuItem;
        private Panel panel1;
        private Panel menuBarPanel2;
        private Panel menuBarPanel3;
        private Panel panel3;
        private Panel panel4;
        private Label label7;
        private PictureBox pictureBox1;
        private CheckedListBox checkedListBox1;
        private Label label10;
        private Label label5;
        private TextBox Industry;
        private Label label4;
        private ComboBox JobCategory;
        private Label label3;
        private ComboBox JobType;
        private Label label2;
        private TextBox CompanyName;
        private TextBox JobTitle;
        private Label label1;
        private Panel panel2;
        private PictureBox companyLogo;
        private Label label11;
        private DateTimePicker applicationDeadline;
        private ComboBox WorkMode;
        private Label label6;
        private Label locationLabel;
        private ComboBox jobVacancy;
        private TextBox JobLocation;
        private Label workModeLabel;
        private Label startingSalaryLabel;
        private Label vacancyLabel;
        private TextBox startingSalary;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel6;
        private ReaLTaiizor.Controls.HopeTabPage JobListingTabs;
        private TabPage tab0;
        private TabPage tab1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel5;
        private RichTextBox JobDescription;
        private RichTextBox ApplicationDetails;
        private Label label9;
        private Label label8;
        private Button clearInputsBttn;
        private Button addJobBttn;
        private Button nextTabBttn;
        private Panel panel7;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel8;
        private Button prevTabBttn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
