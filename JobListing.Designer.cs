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
            panel5 = new Panel();
            panel6 = new Panel();
            ApplicationDetails = new RichTextBox();
            addJobBttn = new Button();
            label9 = new Label();
            clearInputsBttn = new Button();
            label8 = new Label();
            JobDescription = new RichTextBox();
            panel2 = new Panel();
            label11 = new Label();
            applicationDeadline = new DateTimePicker();
            WorkMode = new ComboBox();
            label6 = new Label();
            jobVacancy = new ComboBox();
            companyLogo = new PictureBox();
            label1 = new Label();
            vacancyLabel = new Label();
            JobTitle = new TextBox();
            CompanyName = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            checkedListBox1 = new CheckedListBox();
            JobType = new ComboBox();
            startingSalary = new TextBox();
            label3 = new Label();
            startingSalaryLabel = new Label();
            JobCategory = new ComboBox();
            label10 = new Label();
            label4 = new Label();
            Industry = new TextBox();
            label5 = new Label();
            workModeLabel = new Label();
            JobLocation = new TextBox();
            locationLabel = new Label();
            menuBarPanel2 = new Panel();
            menuBarPanel3 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label7 = new Label();
            logoMenuOpt.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)companyLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(1108, 680);
            panel1.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.AutoScroll = true;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(JobDescription);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 416);
            panel5.Name = "panel5";
            panel5.Size = new Size(1108, 264);
            panel5.TabIndex = 98;
            // 
            // panel6
            // 
            panel6.Controls.Add(ApplicationDetails);
            panel6.Controls.Add(addJobBttn);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(clearInputsBttn);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(508, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(600, 264);
            panel6.TabIndex = 95;
            // 
            // ApplicationDetails
            // 
            ApplicationDetails.BorderStyle = BorderStyle.None;
            ApplicationDetails.Font = new Font("Bahnschrift", 11.25F);
            ApplicationDetails.ForeColor = SystemColors.ControlDarkDark;
            ApplicationDetails.Location = new Point(3, 57);
            ApplicationDetails.Name = "ApplicationDetails";
            ApplicationDetails.Size = new Size(467, 176);
            ApplicationDetails.TabIndex = 54;
            ApplicationDetails.Text = "Enter application process details here...";
            ApplicationDetails.Enter += ApplicationDetails_Enter;
            ApplicationDetails.Leave += ApplicationDetails_Leave;
            // 
            // addJobBttn
            // 
            addJobBttn.BackColor = SystemColors.ButtonHighlight;
            addJobBttn.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 229, 148);
            addJobBttn.FlatStyle = FlatStyle.Flat;
            addJobBttn.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addJobBttn.Location = new Point(489, 57);
            addJobBttn.Name = "addJobBttn";
            addJobBttn.Size = new Size(83, 52);
            addJobBttn.TabIndex = 89;
            addJobBttn.Text = "Add";
            addJobBttn.UseVisualStyleBackColor = false;
            addJobBttn.Click += addJobBttn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 21);
            label9.Name = "label9";
            label9.Size = new Size(224, 18);
            label9.TabIndex = 53;
            label9.Text = "Application Process Information:";
            // 
            // clearInputsBttn
            // 
            clearInputsBttn.BackColor = SystemColors.ButtonHighlight;
            clearInputsBttn.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 229, 148);
            clearInputsBttn.FlatStyle = FlatStyle.Flat;
            clearInputsBttn.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearInputsBttn.Location = new Point(489, 126);
            clearInputsBttn.Name = "clearInputsBttn";
            clearInputsBttn.Size = new Size(83, 52);
            clearInputsBttn.TabIndex = 94;
            clearInputsBttn.Text = "Clear";
            clearInputsBttn.UseVisualStyleBackColor = false;
            clearInputsBttn.Click += clearInputsBttn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(35, 21);
            label8.Name = "label8";
            label8.Size = new Size(224, 18);
            label8.TabIndex = 52;
            label8.Text = "Job Description && Qualifications:";
            // 
            // JobDescription
            // 
            JobDescription.BorderStyle = BorderStyle.None;
            JobDescription.Font = new Font("Bahnschrift", 11.25F);
            JobDescription.ForeColor = SystemColors.ControlDarkDark;
            JobDescription.Location = new Point(35, 57);
            JobDescription.Name = "JobDescription";
            JobDescription.Size = new Size(467, 176);
            JobDescription.TabIndex = 51;
            JobDescription.Text = "Enter job description and qualifications here...";
            JobDescription.Enter += JobDescription_Enter;
            JobDescription.Leave += JobDescription_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(label11);
            panel2.Controls.Add(applicationDeadline);
            panel2.Controls.Add(WorkMode);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(jobVacancy);
            panel2.Controls.Add(companyLogo);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(vacancyLabel);
            panel2.Controls.Add(JobTitle);
            panel2.Controls.Add(CompanyName);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(checkedListBox1);
            panel2.Controls.Add(JobType);
            panel2.Controls.Add(startingSalary);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(startingSalaryLabel);
            panel2.Controls.Add(JobCategory);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(Industry);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(workModeLabel);
            panel2.Controls.Add(JobLocation);
            panel2.Controls.Add(locationLabel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1108, 416);
            panel2.TabIndex = 97;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(587, 57);
            label11.Name = "label11";
            label11.Size = new Size(206, 18);
            label11.TabIndex = 97;
            label11.Text = "Logo: (right click for options): ";
            // 
            // applicationDeadline
            // 
            applicationDeadline.CalendarTitleBackColor = SystemColors.ControlText;
            applicationDeadline.CalendarTitleForeColor = SystemColors.ActiveCaption;
            applicationDeadline.CustomFormat = "MM/dd/yyyy h:mm tt";
            applicationDeadline.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            applicationDeadline.Format = DateTimePickerFormat.Custom;
            applicationDeadline.Location = new Point(620, 362);
            applicationDeadline.Name = "applicationDeadline";
            applicationDeadline.Size = new Size(264, 26);
            applicationDeadline.TabIndex = 56;
            // 
            // WorkMode
            // 
            WorkMode.BackColor = SystemColors.InactiveCaption;
            WorkMode.FlatStyle = FlatStyle.Flat;
            WorkMode.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WorkMode.FormattingEnabled = true;
            WorkMode.Items.AddRange(new object[] { "On-site", "Remote", "Hybrid", "Flexible Work Arrangement" });
            WorkMode.Location = new Point(733, 184);
            WorkMode.Name = "WorkMode";
            WorkMode.Size = new Size(246, 26);
            WorkMode.TabIndex = 88;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(587, 336);
            label6.Name = "label6";
            label6.Size = new Size(147, 18);
            label6.TabIndex = 55;
            label6.Text = "Application Deadline:";
            // 
            // jobVacancy
            // 
            jobVacancy.BackColor = SystemColors.InactiveCaption;
            jobVacancy.FlatStyle = FlatStyle.Flat;
            jobVacancy.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jobVacancy.FormattingEnabled = true;
            jobVacancy.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            jobVacancy.Location = new Point(733, 285);
            jobVacancy.Name = "jobVacancy";
            jobVacancy.Size = new Size(246, 26);
            jobVacancy.TabIndex = 96;
            // 
            // companyLogo
            // 
            companyLogo.BackColor = SystemColors.ControlDark;
            companyLogo.BorderStyle = BorderStyle.FixedSingle;
            companyLogo.ContextMenuStrip = logoMenuOpt;
            companyLogo.InitialImage = Properties.Resources.research;
            companyLogo.Location = new Point(798, 15);
            companyLogo.Name = "companyLogo";
            companyLogo.Size = new Size(120, 105);
            companyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            companyLogo.TabIndex = 50;
            companyLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 142);
            label1.Name = "label1";
            label1.Size = new Size(67, 18);
            label1.TabIndex = 75;
            label1.Text = "Job Title:";
            // 
            // vacancyLabel
            // 
            vacancyLabel.AutoSize = true;
            vacancyLabel.BackColor = Color.Transparent;
            vacancyLabel.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vacancyLabel.Location = new Point(587, 288);
            vacancyLabel.Name = "vacancyLabel";
            vacancyLabel.Size = new Size(64, 18);
            vacancyLabel.TabIndex = 95;
            vacancyLabel.Text = "Vacancy:";
            // 
            // JobTitle
            // 
            JobTitle.BackColor = SystemColors.InactiveCaption;
            JobTitle.BorderStyle = BorderStyle.None;
            JobTitle.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JobTitle.Location = new Point(191, 139);
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
            CompanyName.Location = new Point(191, 92);
            CompanyName.Multiline = true;
            CompanyName.Name = "CompanyName";
            CompanyName.Size = new Size(247, 27);
            CompanyName.TabIndex = 74;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.suitcase;
            pictureBox1.Location = new Point(47, 23);
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
            label2.Location = new Point(44, 96);
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
            checkedListBox1.Location = new Point(192, 306);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(246, 109);
            checkedListBox1.TabIndex = 84;
            // 
            // JobType
            // 
            JobType.BackColor = SystemColors.InactiveCaption;
            JobType.FlatStyle = FlatStyle.Flat;
            JobType.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JobType.FormattingEnabled = true;
            JobType.Items.AddRange(new object[] { "Full-Time", "Part-Time", "Contract", "Apprenticeship", "Internship", "Seasonal" });
            JobType.Location = new Point(191, 187);
            JobType.Name = "JobType";
            JobType.Size = new Size(246, 26);
            JobType.TabIndex = 78;
            // 
            // startingSalary
            // 
            startingSalary.BackColor = SystemColors.InactiveCaption;
            startingSalary.BorderStyle = BorderStyle.None;
            startingSalary.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startingSalary.Location = new Point(733, 234);
            startingSalary.Multiline = true;
            startingSalary.Name = "startingSalary";
            startingSalary.Size = new Size(246, 27);
            startingSalary.TabIndex = 92;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 190);
            label3.Name = "label3";
            label3.Size = new Size(68, 18);
            label3.TabIndex = 79;
            label3.Text = "Job Type:";
            // 
            // startingSalaryLabel
            // 
            startingSalaryLabel.AutoSize = true;
            startingSalaryLabel.BackColor = Color.Transparent;
            startingSalaryLabel.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startingSalaryLabel.Location = new Point(584, 239);
            startingSalaryLabel.Name = "startingSalaryLabel";
            startingSalaryLabel.Size = new Size(109, 18);
            startingSalaryLabel.TabIndex = 91;
            startingSalaryLabel.Text = "Starting Salary:";
            // 
            // JobCategory
            // 
            JobCategory.BackColor = SystemColors.InactiveCaption;
            JobCategory.FlatStyle = FlatStyle.Flat;
            JobCategory.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JobCategory.FormattingEnabled = true;
            JobCategory.Items.AddRange(new object[] { "Accounting & Finance", "Administrative Support", "Architecture & Engineering", "Arts & Design", "Business Development", "Construction & Skilled Trades", "Consulting", "Customer Service", "Data Science & Analytics", "Education & Training", "Engineering", "Healthcare", "Hospitality & Travel", "Human Resources", "Information Technology (IT)", "Legal", "Logistics & Supply Chain", "Management", "Manufacturing & Production", "Marketing & Advertising", "Media & Communications", "Operations", "Project Management", "Public Relations (PR)", "Quality Assurance (QA)", "Real Estate", "Research & Development (R&D)", "Retail & Sales", "Science", "Security", "Social Services & Non-Profit", "Software Development", "Support Services", "Technical Support", "Telecommunications", "Training & Development", "Transportation & Logistics", "Writing & Editing" });
            JobCategory.Location = new Point(192, 234);
            JobCategory.Name = "JobCategory";
            JobCategory.Size = new Size(245, 26);
            JobCategory.TabIndex = 80;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(104, 28);
            label10.Name = "label10";
            label10.Size = new Size(201, 29);
            label10.TabIndex = 90;
            label10.Text = "Enter Job Details:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 288);
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
            Industry.Location = new Point(192, 281);
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
            label5.Location = new Point(43, 238);
            label5.Name = "label5";
            label5.Size = new Size(69, 18);
            label5.TabIndex = 84;
            label5.Text = "Category:";
            // 
            // workModeLabel
            // 
            workModeLabel.AutoSize = true;
            workModeLabel.BackColor = Color.Transparent;
            workModeLabel.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            workModeLabel.Location = new Point(584, 189);
            workModeLabel.Name = "workModeLabel";
            workModeLabel.Size = new Size(85, 18);
            workModeLabel.TabIndex = 87;
            workModeLabel.Text = "Work Mode:";
            // 
            // JobLocation
            // 
            JobLocation.BackColor = SystemColors.InactiveCaption;
            JobLocation.BorderStyle = BorderStyle.None;
            JobLocation.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JobLocation.ForeColor = SystemColors.ControlDarkDark;
            JobLocation.Location = new Point(733, 135);
            JobLocation.Multiline = true;
            JobLocation.Name = "JobLocation";
            JobLocation.Size = new Size(246, 27);
            JobLocation.TabIndex = 86;
            JobLocation.Text = "Country, City";
            JobLocation.Enter += JobLocation_Enter;
            JobLocation.Leave += JobLocation_Leave;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.BackColor = Color.Transparent;
            locationLabel.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            locationLabel.Location = new Point(587, 139);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(68, 18);
            locationLabel.TabIndex = 86;
            locationLabel.Text = "Location:";
            // 
            // menuBarPanel2
            // 
            menuBarPanel2.Controls.Add(menuBarPanel3);
            menuBarPanel2.Dock = DockStyle.Top;
            menuBarPanel2.Location = new Point(0, 0);
            menuBarPanel2.Name = "menuBarPanel2";
            menuBarPanel2.Padding = new Padding(0, 2, 0, 2);
            menuBarPanel2.Size = new Size(1108, 55);
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
            menuBarPanel3.Size = new Size(1108, 51);
            menuBarPanel3.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(942, 0);
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
            Size = new Size(1108, 735);
            logoMenuOpt.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)companyLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel2;
        private Panel panel5;
        private DateTimePicker applicationDeadline;
        private Label label6;
        private RichTextBox ApplicationDetails;
        private Label label9;
        private Label label8;
        private RichTextBox JobDescription;
        private PictureBox companyLogo;
        private Panel panel6;
        private Label label11;
    }
}
