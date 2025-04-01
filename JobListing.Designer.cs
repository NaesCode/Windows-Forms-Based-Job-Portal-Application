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
            jobVacancy = new ComboBox();
            vacancyLabel = new Label();
            clearInputsBttn = new Button();
            pictureBox1 = new PictureBox();
            checkedListBox1 = new CheckedListBox();
            startingSalary = new TextBox();
            startingSalaryLabel = new Label();
            label10 = new Label();
            addJobBttn = new Button();
            WorkMode = new ComboBox();
            workModeLabel = new Label();
            locationLabel = new Label();
            JobLocation = new TextBox();
            label5 = new Label();
            Industry = new TextBox();
            label4 = new Label();
            JobCategory = new ComboBox();
            label3 = new Label();
            JobType = new ComboBox();
            label2 = new Label();
            CompanyName = new TextBox();
            JobTitle = new TextBox();
            label1 = new Label();
            panel5 = new Panel();
            applicationDeadline = new DateTimePicker();
            label6 = new Label();
            ApplicationDetails = new RichTextBox();
            label9 = new Label();
            label8 = new Label();
            JobDescription = new RichTextBox();
            companyLogo = new PictureBox();
            menuBarPanel2 = new Panel();
            menuBarPanel3 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label7 = new Label();
            logoMenuOpt.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)companyLogo).BeginInit();
            menuBarPanel2.SuspendLayout();
            menuBarPanel3.SuspendLayout();
            panel4.SuspendLayout();
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
            // 
            // deleteLogoToolStripMenuItem
            // 
            deleteLogoToolStripMenuItem.Image = Properties.Resources.deletePhoto;
            deleteLogoToolStripMenuItem.Name = "deleteLogoToolStripMenuItem";
            deleteLogoToolStripMenuItem.Size = new Size(146, 22);
            deleteLogoToolStripMenuItem.Text = "Delete Logo";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(jobVacancy);
            panel1.Controls.Add(vacancyLabel);
            panel1.Controls.Add(clearInputsBttn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(checkedListBox1);
            panel1.Controls.Add(startingSalary);
            panel1.Controls.Add(startingSalaryLabel);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(addJobBttn);
            panel1.Controls.Add(WorkMode);
            panel1.Controls.Add(workModeLabel);
            panel1.Controls.Add(locationLabel);
            panel1.Controls.Add(JobLocation);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Industry);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(JobCategory);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(JobType);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CompanyName);
            panel1.Controls.Add(JobTitle);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(1013, 760);
            panel1.TabIndex = 10;
            // 
            // jobVacancy
            // 
            jobVacancy.BackColor = SystemColors.InactiveCaption;
            jobVacancy.FlatStyle = FlatStyle.Flat;
            jobVacancy.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jobVacancy.FormattingEnabled = true;
            jobVacancy.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            jobVacancy.Location = new Point(216, 578);
            jobVacancy.Name = "jobVacancy";
            jobVacancy.Size = new Size(246, 26);
            jobVacancy.TabIndex = 96;
            // 
            // vacancyLabel
            // 
            vacancyLabel.AutoSize = true;
            vacancyLabel.BackColor = Color.Transparent;
            vacancyLabel.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vacancyLabel.Location = new Point(70, 581);
            vacancyLabel.Name = "vacancyLabel";
            vacancyLabel.Size = new Size(64, 18);
            vacancyLabel.TabIndex = 95;
            vacancyLabel.Text = "Vacancy:";
            // 
            // clearInputsBttn
            // 
            clearInputsBttn.BackColor = SystemColors.ButtonHighlight;
            clearInputsBttn.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 229, 148);
            clearInputsBttn.FlatStyle = FlatStyle.Flat;
            clearInputsBttn.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearInputsBttn.Location = new Point(280, 623);
            clearInputsBttn.Name = "clearInputsBttn";
            clearInputsBttn.Size = new Size(83, 52);
            clearInputsBttn.TabIndex = 94;
            clearInputsBttn.Text = "Clear";
            clearInputsBttn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.suitcase;
            pictureBox1.Location = new Point(69, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 93;
            pictureBox1.TabStop = false;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = SystemColors.ButtonHighlight;
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Advertising and Marketing", "Agriculture", "Computer and Technology", "Construction", "Education", "Energy", "Entertainment", "Fashion", "Finance and Economics", "Food and Beverage", "Healthcare", "Hospitality", "Legal", "Manufacturing", "Media and News", "Mining", "Outsourcing", "Pharmaceuticals", "Telecommunications", "Transportaion" });
            checkedListBox1.Location = new Point(217, 300);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(246, 109);
            checkedListBox1.TabIndex = 83;
            // 
            // startingSalary
            // 
            startingSalary.BackColor = SystemColors.InactiveCaption;
            startingSalary.BorderStyle = BorderStyle.None;
            startingSalary.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startingSalary.Location = new Point(216, 527);
            startingSalary.Multiline = true;
            startingSalary.Name = "startingSalary";
            startingSalary.Size = new Size(246, 27);
            startingSalary.TabIndex = 92;
            // 
            // startingSalaryLabel
            // 
            startingSalaryLabel.AutoSize = true;
            startingSalaryLabel.BackColor = Color.Transparent;
            startingSalaryLabel.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startingSalaryLabel.Location = new Point(67, 532);
            startingSalaryLabel.Name = "startingSalaryLabel";
            startingSalaryLabel.Size = new Size(109, 18);
            startingSalaryLabel.TabIndex = 91;
            startingSalaryLabel.Text = "Starting Salary:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(129, 15);
            label10.Name = "label10";
            label10.Size = new Size(244, 40);
            label10.TabIndex = 90;
            label10.Text = "Enter Job Details:";
            // 
            // addJobBttn
            // 
            addJobBttn.BackColor = SystemColors.ButtonHighlight;
            addJobBttn.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 229, 148);
            addJobBttn.FlatStyle = FlatStyle.Flat;
            addJobBttn.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addJobBttn.Location = new Point(119, 623);
            addJobBttn.Name = "addJobBttn";
            addJobBttn.Size = new Size(83, 52);
            addJobBttn.TabIndex = 89;
            addJobBttn.Text = "Add";
            addJobBttn.UseVisualStyleBackColor = false;
            // 
            // WorkMode
            // 
            WorkMode.BackColor = SystemColors.InactiveCaption;
            WorkMode.FlatStyle = FlatStyle.Flat;
            WorkMode.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WorkMode.FormattingEnabled = true;
            WorkMode.Items.AddRange(new object[] { "On-site", "Remote", "Hybrid", "Flexible Work Arrangement" });
            WorkMode.Location = new Point(216, 477);
            WorkMode.Name = "WorkMode";
            WorkMode.Size = new Size(246, 26);
            WorkMode.TabIndex = 88;
            // 
            // workModeLabel
            // 
            workModeLabel.AutoSize = true;
            workModeLabel.BackColor = Color.Transparent;
            workModeLabel.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            workModeLabel.Location = new Point(67, 482);
            workModeLabel.Name = "workModeLabel";
            workModeLabel.Size = new Size(85, 18);
            workModeLabel.TabIndex = 87;
            workModeLabel.Text = "Work Mode:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.BackColor = Color.Transparent;
            locationLabel.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            locationLabel.Location = new Point(70, 432);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(68, 18);
            locationLabel.TabIndex = 86;
            locationLabel.Text = "Location:";
            // 
            // JobLocation
            // 
            JobLocation.BackColor = SystemColors.InactiveCaption;
            JobLocation.BorderStyle = BorderStyle.None;
            JobLocation.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JobLocation.Location = new Point(216, 428);
            JobLocation.Multiline = true;
            JobLocation.Name = "JobLocation";
            JobLocation.Size = new Size(246, 27);
            JobLocation.TabIndex = 85;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(68, 232);
            label5.Name = "label5";
            label5.Size = new Size(69, 18);
            label5.TabIndex = 84;
            label5.Text = "Category:";
            // 
            // Industry
            // 
            Industry.BackColor = SystemColors.InactiveCaption;
            Industry.BorderStyle = BorderStyle.None;
            Industry.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Industry.Location = new Point(217, 275);
            Industry.Multiline = true;
            Industry.Name = "Industry";
            Industry.Size = new Size(245, 27);
            Industry.TabIndex = 82;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(68, 282);
            label4.Name = "label4";
            label4.Size = new Size(64, 18);
            label4.TabIndex = 81;
            label4.Text = "Industry:";
            // 
            // JobCategory
            // 
            JobCategory.BackColor = SystemColors.InactiveCaption;
            JobCategory.FlatStyle = FlatStyle.Flat;
            JobCategory.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JobCategory.FormattingEnabled = true;
            JobCategory.Items.AddRange(new object[] { "Accounting & Finance", "Administrative Support", "Architecture & Engineering", "Arts & Design", "Business Development", "Construction & Skilled Trades", "Consulting", "Customer Service", "Data Science & Analytics", "Education & Training", "Engineering", "Healthcare", "Hospitality & Travel", "Human Resources", "Information Technology (IT)", "Legal", "Logistics & Supply Chain", "Management", "Manufacturing & Production", "Marketing & Advertising", "Media & Communications", "Operations", "Project Management", "Public Relations (PR)", "Quality Assurance (QA)", "Real Estate", "Research & Development (R&D)", "Retail & Sales", "Science", "Security", "Social Services & Non-Profit", "Software Development", "Support Services", "Technical Support", "Telecommunications", "Training & Development", "Transportation & Logistics", "Writing & Editing" });
            JobCategory.Location = new Point(217, 228);
            JobCategory.Name = "JobCategory";
            JobCategory.Size = new Size(245, 26);
            JobCategory.TabIndex = 80;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 184);
            label3.Name = "label3";
            label3.Size = new Size(68, 18);
            label3.TabIndex = 79;
            label3.Text = "Job Type:";
            // 
            // JobType
            // 
            JobType.BackColor = SystemColors.InactiveCaption;
            JobType.FlatStyle = FlatStyle.Flat;
            JobType.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JobType.FormattingEnabled = true;
            JobType.Items.AddRange(new object[] { "Full-Time", "Part-Time", "Contract", "Apprenticeship", "Internship", "Seasonal" });
            JobType.Location = new Point(216, 181);
            JobType.Name = "JobType";
            JobType.Size = new Size(246, 26);
            JobType.TabIndex = 78;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 90);
            label2.Name = "label2";
            label2.Size = new Size(116, 18);
            label2.TabIndex = 77;
            label2.Text = "Company Name:";
            // 
            // CompanyName
            // 
            CompanyName.BackColor = SystemColors.InactiveCaption;
            CompanyName.BorderStyle = BorderStyle.None;
            CompanyName.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CompanyName.Location = new Point(216, 86);
            CompanyName.Multiline = true;
            CompanyName.Name = "CompanyName";
            CompanyName.Size = new Size(247, 27);
            CompanyName.TabIndex = 76;
            // 
            // JobTitle
            // 
            JobTitle.BackColor = SystemColors.InactiveCaption;
            JobTitle.BorderStyle = BorderStyle.None;
            JobTitle.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JobTitle.Location = new Point(216, 133);
            JobTitle.Multiline = true;
            JobTitle.Name = "JobTitle";
            JobTitle.Size = new Size(246, 27);
            JobTitle.TabIndex = 74;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 136);
            label1.Name = "label1";
            label1.Size = new Size(67, 18);
            label1.TabIndex = 75;
            label1.Text = "Job Title:";
            // 
            // panel5
            // 
            panel5.AutoScroll = true;
            panel5.Controls.Add(applicationDeadline);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(ApplicationDetails);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(JobDescription);
            panel5.Controls.Add(companyLogo);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(475, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(538, 760);
            panel5.TabIndex = 48;
            // 
            // applicationDeadline
            // 
            applicationDeadline.CalendarTitleBackColor = SystemColors.ControlText;
            applicationDeadline.CalendarTitleForeColor = SystemColors.ActiveCaption;
            applicationDeadline.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            applicationDeadline.Location = new Point(52, 643);
            applicationDeadline.Name = "applicationDeadline";
            applicationDeadline.Size = new Size(264, 26);
            applicationDeadline.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 617);
            label6.Name = "label6";
            label6.Size = new Size(147, 18);
            label6.TabIndex = 55;
            label6.Text = "Application Deadline:";
            // 
            // ApplicationDetails
            // 
            ApplicationDetails.BorderStyle = BorderStyle.None;
            ApplicationDetails.Font = new Font("Bahnschrift", 11.25F);
            ApplicationDetails.Location = new Point(52, 428);
            ApplicationDetails.Name = "ApplicationDetails";
            ApplicationDetails.Size = new Size(467, 167);
            ApplicationDetails.TabIndex = 54;
            ApplicationDetails.Text = "Hello";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 392);
            label9.Name = "label9";
            label9.Size = new Size(136, 18);
            label9.TabIndex = 53;
            label9.Text = "Application Details:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 172);
            label8.Name = "label8";
            label8.Size = new Size(221, 18);
            label8.TabIndex = 52;
            label8.Text = "Job Description && Qualifications";
            // 
            // JobDescription
            // 
            JobDescription.BorderStyle = BorderStyle.None;
            JobDescription.Font = new Font("Bahnschrift", 11.25F);
            JobDescription.Location = new Point(52, 205);
            JobDescription.Name = "JobDescription";
            JobDescription.Size = new Size(467, 169);
            JobDescription.TabIndex = 51;
            JobDescription.Text = "Hello";
            // 
            // companyLogo
            // 
            companyLogo.BackColor = SystemColors.ControlDark;
            companyLogo.BorderStyle = BorderStyle.FixedSingle;
            companyLogo.ContextMenuStrip = logoMenuOpt;
            companyLogo.InitialImage = Properties.Resources.research;
            companyLogo.Location = new Point(216, 18);
            companyLogo.Name = "companyLogo";
            companyLogo.Size = new Size(166, 140);
            companyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            companyLogo.TabIndex = 50;
            companyLogo.TabStop = false;
            // 
            // menuBarPanel2
            // 
            menuBarPanel2.Controls.Add(menuBarPanel3);
            menuBarPanel2.Dock = DockStyle.Top;
            menuBarPanel2.Location = new Point(0, 0);
            menuBarPanel2.Name = "menuBarPanel2";
            menuBarPanel2.Padding = new Padding(0, 2, 0, 2);
            menuBarPanel2.Size = new Size(1013, 55);
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
            menuBarPanel3.Size = new Size(1013, 51);
            menuBarPanel3.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(847, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(166, 51);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(label7);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(555, 51);
            panel4.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Geoform", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(15, 15);
            label7.Name = "label7";
            label7.Size = new Size(290, 25);
            label7.TabIndex = 1;
            label7.Text = "COMPANY DASHBOARD";
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
            Size = new Size(1013, 815);
            logoMenuOpt.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)companyLogo).EndInit();
            menuBarPanel2.ResumeLayout(false);
            menuBarPanel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel5;
        private DateTimePicker applicationDeadline;
        private Label label6;
        private RichTextBox ApplicationDetails;
        private Label label9;
        private Label label8;
        private RichTextBox JobDescription;
        private PictureBox companyLogo;
        private ComboBox jobVacancy;
        private Label vacancyLabel;
        private Button clearInputsBttn;
        private PictureBox pictureBox1;
        private CheckedListBox checkedListBox1;
        private TextBox startingSalary;
        private Label startingSalaryLabel;
        private Label label10;
        private Button addJobBttn;
        private ComboBox WorkMode;
        private Label workModeLabel;
        private Label locationLabel;
        private TextBox JobLocation;
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
    }
}
