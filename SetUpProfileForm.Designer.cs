namespace Job_Application_Manager
{
    partial class SetUpProfileForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetUpProfileForm));
            pfpMenuOpt = new ContextMenuStrip(components);
            uploadLogoToolStripMenuItem = new ToolStripMenuItem();
            viewLogoToolStripMenuItem = new ToolStripMenuItem();
            deleteLogoToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            fullName = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            hunterEmail = new TextBox();
            textBox9 = new TextBox();
            hunterAddress = new TextBox();
            textBox11 = new TextBox();
            hunterNationality = new TextBox();
            textBox13 = new TextBox();
            contactNumber = new TextBox();
            textBox16 = new TextBox();
            clearInputsBttn = new FontAwesome.Sharp.IconButton();
            textBox20 = new TextBox();
            textBox17 = new TextBox();
            resumeDocx = new TextBox();
            label = new TextBox();
            coverLetter = new TextBox();
            textBox22 = new TextBox();
            portfolio = new TextBox();
            browseFileBttn1 = new FontAwesome.Sharp.IconButton();
            browseFileBttn2 = new FontAwesome.Sharp.IconButton();
            browseFileBttn3 = new FontAwesome.Sharp.IconButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            submitBttn = new FontAwesome.Sharp.IconButton();
            ProfilePicture = new PictureBox();
            textBox5 = new TextBox();
            maleBttn = new RadioButton();
            femaleBttn = new RadioButton();
            otherBttn = new RadioButton();
            dateOfBirth = new DateTimePicker();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            educAttainment = new ComboBox();
            degreeEarned = new TextBox();
            degreeLabel = new TextBox();
            hasWebsite = new RadioButton();
            genderBox = new GroupBox();
            portfolioWeb = new TextBox();
            university = new TextBox();
            univLabel = new TextBox();
            updateBttn = new FontAwesome.Sharp.IconButton();
            textBox7 = new TextBox();
            pfpMenuOpt.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            genderBox.SuspendLayout();
            SuspendLayout();
            // 
            // pfpMenuOpt
            // 
            pfpMenuOpt.BackColor = SystemColors.ButtonHighlight;
            pfpMenuOpt.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pfpMenuOpt.Items.AddRange(new ToolStripItem[] { uploadLogoToolStripMenuItem, viewLogoToolStripMenuItem, deleteLogoToolStripMenuItem });
            pfpMenuOpt.Name = "logoMenuOpt";
            pfpMenuOpt.Size = new Size(160, 70);
            // 
            // uploadLogoToolStripMenuItem
            // 
            uploadLogoToolStripMenuItem.Image = Properties.Resources.upload;
            uploadLogoToolStripMenuItem.Name = "uploadLogoToolStripMenuItem";
            uploadLogoToolStripMenuItem.Size = new Size(159, 22);
            uploadLogoToolStripMenuItem.Text = "Upload Picture";
            uploadLogoToolStripMenuItem.Click += uploadLogoToolStripMenuItem_Click;
            // 
            // viewLogoToolStripMenuItem
            // 
            viewLogoToolStripMenuItem.Image = Properties.Resources.image;
            viewLogoToolStripMenuItem.Name = "viewLogoToolStripMenuItem";
            viewLogoToolStripMenuItem.Size = new Size(159, 22);
            viewLogoToolStripMenuItem.Text = "View Picture";
            viewLogoToolStripMenuItem.Click += viewLogoToolStripMenuItem_Click;
            // 
            // deleteLogoToolStripMenuItem
            // 
            deleteLogoToolStripMenuItem.Image = Properties.Resources.deletePhoto;
            deleteLogoToolStripMenuItem.Name = "deleteLogoToolStripMenuItem";
            deleteLogoToolStripMenuItem.Size = new Size(159, 22);
            deleteLogoToolStripMenuItem.Text = "Delete Picture";
            deleteLogoToolStripMenuItem.Click += deleteLogoToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(859, 66);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(853, 60);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(128, 60);
            panel3.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Geoform", 9.749998F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(30, 22);
            label2.Name = "label2";
            label2.Size = new Size(89, 16);
            label2.TabIndex = 32;
            label2.Text = "JOB-HUNT";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Geoform", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(134, 19);
            label1.Name = "label1";
            label1.Size = new Size(447, 22);
            label1.TabIndex = 0;
            label1.Text = "SET UP YOUR PROFILE AS A JOB-HUNTER";
            // 
            // fullName
            // 
            fullName.Font = new Font("Bahnschrift", 11.25F);
            fullName.Location = new Point(165, 128);
            fullName.Multiline = true;
            fullName.Name = "fullName";
            fullName.Size = new Size(241, 26);
            fullName.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(74, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(262, 23);
            textBox2.TabIndex = 23;
            textBox2.Text = "Basic Job-Hunter Information:\r\n";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox3.Location = new Point(33, 133);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 20);
            textBox3.TabIndex = 24;
            textBox3.Text = "Full Name:";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox4.Location = new Point(33, 173);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(126, 20);
            textBox4.TabIndex = 25;
            textBox4.Text = "Date of Birth:";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox6.Location = new Point(33, 293);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(70, 20);
            textBox6.TabIndex = 27;
            textBox6.Text = "Email:";
            // 
            // hunterEmail
            // 
            hunterEmail.Font = new Font("Bahnschrift", 11.25F);
            hunterEmail.Location = new Point(165, 291);
            hunterEmail.Multiline = true;
            hunterEmail.Name = "hunterEmail";
            hunterEmail.Size = new Size(241, 26);
            hunterEmail.TabIndex = 28;
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox9.Location = new Point(33, 334);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(70, 20);
            textBox9.TabIndex = 30;
            textBox9.Text = "Address:";
            // 
            // hunterAddress
            // 
            hunterAddress.Font = new Font("Bahnschrift", 11.25F);
            hunterAddress.Location = new Point(165, 332);
            hunterAddress.Multiline = true;
            hunterAddress.Name = "hunterAddress";
            hunterAddress.Size = new Size(241, 26);
            hunterAddress.TabIndex = 31;
            // 
            // textBox11
            // 
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox11.Location = new Point(35, 376);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(84, 20);
            textBox11.TabIndex = 32;
            textBox11.Text = "Nationality:";
            // 
            // hunterNationality
            // 
            hunterNationality.Font = new Font("Bahnschrift", 11.25F);
            hunterNationality.Location = new Point(165, 373);
            hunterNationality.Multiline = true;
            hunterNationality.Name = "hunterNationality";
            hunterNationality.Size = new Size(241, 26);
            hunterNationality.TabIndex = 33;
            // 
            // textBox13
            // 
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox13.Location = new Point(33, 252);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(126, 20);
            textBox13.TabIndex = 34;
            textBox13.Text = "Contact Number:";
            // 
            // contactNumber
            // 
            contactNumber.Font = new Font("Bahnschrift", 11.25F);
            contactNumber.Location = new Point(165, 250);
            contactNumber.Multiline = true;
            contactNumber.Name = "contactNumber";
            contactNumber.Size = new Size(241, 26);
            contactNumber.TabIndex = 35;
            // 
            // textBox16
            // 
            textBox16.BorderStyle = BorderStyle.None;
            textBox16.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox16.Location = new Point(33, 465);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(214, 20);
            textBox16.TabIndex = 36;
            textBox16.Text = "Highest Educ. Attainment:";
            // 
            // clearInputsBttn
            // 
            clearInputsBttn.BackColor = Color.FromArgb(13, 59, 141);
            clearInputsBttn.FlatAppearance.BorderSize = 0;
            clearInputsBttn.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 229, 148);
            clearInputsBttn.FlatStyle = FlatStyle.Flat;
            clearInputsBttn.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            clearInputsBttn.ForeColor = SystemColors.ButtonHighlight;
            clearInputsBttn.IconChar = FontAwesome.Sharp.IconChar.None;
            clearInputsBttn.IconColor = Color.Black;
            clearInputsBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            clearInputsBttn.Location = new Point(168, 593);
            clearInputsBttn.Name = "clearInputsBttn";
            clearInputsBttn.Size = new Size(84, 42);
            clearInputsBttn.TabIndex = 59;
            clearInputsBttn.Text = "Clear";
            clearInputsBttn.UseVisualStyleBackColor = false;
            // 
            // textBox20
            // 
            textBox20.BorderStyle = BorderStyle.None;
            textBox20.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox20.Location = new Point(512, 271);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(213, 23);
            textBox20.TabIndex = 43;
            textBox20.Text = "Supporting Documents:";
            // 
            // textBox17
            // 
            textBox17.BorderStyle = BorderStyle.None;
            textBox17.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox17.Location = new Point(469, 317);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(115, 20);
            textBox17.TabIndex = 44;
            textBox17.Text = "Resume / CV:";
            // 
            // resumeDocx
            // 
            resumeDocx.Font = new Font("Bahnschrift", 11.25F);
            resumeDocx.Location = new Point(469, 345);
            resumeDocx.Multiline = true;
            resumeDocx.Name = "resumeDocx";
            resumeDocx.Size = new Size(268, 26);
            resumeDocx.TabIndex = 45;
            // 
            // label
            // 
            label.BorderStyle = BorderStyle.None;
            label.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            label.Location = new Point(469, 389);
            label.Name = "label";
            label.Size = new Size(181, 20);
            label.TabIndex = 46;
            label.Text = "Cover Letter (Optional):";
            // 
            // coverLetter
            // 
            coverLetter.Font = new Font("Bahnschrift", 11.25F);
            coverLetter.Location = new Point(469, 418);
            coverLetter.Multiline = true;
            coverLetter.Name = "coverLetter";
            coverLetter.Size = new Size(268, 26);
            coverLetter.TabIndex = 47;
            // 
            // textBox22
            // 
            textBox22.BorderStyle = BorderStyle.None;
            textBox22.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox22.Location = new Point(469, 463);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(241, 20);
            textBox22.TabIndex = 48;
            textBox22.Text = "Personal Portfolio (If available):";
            // 
            // portfolio
            // 
            portfolio.Font = new Font("Bahnschrift", 11.25F);
            portfolio.Location = new Point(469, 493);
            portfolio.Multiline = true;
            portfolio.Name = "portfolio";
            portfolio.Size = new Size(268, 26);
            portfolio.TabIndex = 49;
            // 
            // browseFileBttn1
            // 
            browseFileBttn1.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            browseFileBttn1.IconColor = Color.Black;
            browseFileBttn1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            browseFileBttn1.IconSize = 25;
            browseFileBttn1.Location = new Point(735, 344);
            browseFileBttn1.Name = "browseFileBttn1";
            browseFileBttn1.Size = new Size(31, 27);
            browseFileBttn1.TabIndex = 50;
            browseFileBttn1.UseVisualStyleBackColor = true;
            browseFileBttn1.Click += browseFileBttn1_Click;
            // 
            // browseFileBttn2
            // 
            browseFileBttn2.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            browseFileBttn2.IconColor = Color.Black;
            browseFileBttn2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            browseFileBttn2.IconSize = 25;
            browseFileBttn2.Location = new Point(735, 417);
            browseFileBttn2.Name = "browseFileBttn2";
            browseFileBttn2.Size = new Size(31, 27);
            browseFileBttn2.TabIndex = 51;
            browseFileBttn2.UseVisualStyleBackColor = true;
            browseFileBttn2.Click += browseFileBttn2_Click;
            // 
            // browseFileBttn3
            // 
            browseFileBttn3.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            browseFileBttn3.IconColor = Color.Black;
            browseFileBttn3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            browseFileBttn3.IconSize = 25;
            browseFileBttn3.Location = new Point(735, 492);
            browseFileBttn3.Name = "browseFileBttn3";
            browseFileBttn3.Size = new Size(31, 27);
            browseFileBttn3.TabIndex = 52;
            browseFileBttn3.UseVisualStyleBackColor = true;
            browseFileBttn3.Click += browseFileBttn3_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.ButtonHighlight;
            iconPictureBox1.BackgroundImage = Properties.Resources.info;
            iconPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(469, 266);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPictureBox1.TabIndex = 55;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = SystemColors.ButtonHighlight;
            iconPictureBox3.BackgroundImage = Properties.Resources.information;
            iconPictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.Location = new Point(33, 85);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(32, 32);
            iconPictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPictureBox3.TabIndex = 57;
            iconPictureBox3.TabStop = false;
            // 
            // submitBttn
            // 
            submitBttn.BackColor = Color.FromArgb(13, 59, 141);
            submitBttn.FlatAppearance.BorderSize = 0;
            submitBttn.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 229, 148);
            submitBttn.FlatStyle = FlatStyle.Flat;
            submitBttn.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            submitBttn.ForeColor = SystemColors.ButtonHighlight;
            submitBttn.IconChar = FontAwesome.Sharp.IconChar.None;
            submitBttn.IconColor = Color.Black;
            submitBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submitBttn.Location = new Point(38, 593);
            submitBttn.Name = "submitBttn";
            submitBttn.Size = new Size(84, 42);
            submitBttn.TabIndex = 58;
            submitBttn.Text = "Submit";
            submitBttn.UseVisualStyleBackColor = false;
            submitBttn.Click += submitBttn_Click;
            // 
            // ProfilePicture
            // 
            ProfilePicture.BackColor = SystemColors.ControlDark;
            ProfilePicture.ContextMenuStrip = pfpMenuOpt;
            ProfilePicture.InitialImage = Properties.Resources.research;
            ProfilePicture.Location = new Point(586, 90);
            ProfilePicture.Name = "ProfilePicture";
            ProfilePicture.Size = new Size(189, 152);
            ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ProfilePicture.TabIndex = 41;
            ProfilePicture.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox5.Location = new Point(33, 212);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(89, 20);
            textBox5.TabIndex = 60;
            textBox5.Text = "Gender:";
            // 
            // maleBttn
            // 
            maleBttn.AutoSize = true;
            maleBttn.Font = new Font("Bahnschrift SemiLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maleBttn.Location = new Point(3, 14);
            maleBttn.Name = "maleBttn";
            maleBttn.Size = new Size(66, 22);
            maleBttn.TabIndex = 61;
            maleBttn.TabStop = true;
            maleBttn.Text = "MALE";
            maleBttn.UseVisualStyleBackColor = true;
            // 
            // femaleBttn
            // 
            femaleBttn.AutoSize = true;
            femaleBttn.Font = new Font("Bahnschrift SemiLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            femaleBttn.Location = new Point(75, 14);
            femaleBttn.Name = "femaleBttn";
            femaleBttn.Size = new Size(83, 22);
            femaleBttn.TabIndex = 62;
            femaleBttn.TabStop = true;
            femaleBttn.Text = "FEMALE";
            femaleBttn.UseVisualStyleBackColor = true;
            // 
            // otherBttn
            // 
            otherBttn.AutoSize = true;
            otherBttn.Font = new Font("Bahnschrift SemiLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            otherBttn.Location = new Point(164, 14);
            otherBttn.Name = "otherBttn";
            otherBttn.Size = new Size(72, 22);
            otherBttn.TabIndex = 63;
            otherBttn.TabStop = true;
            otherBttn.Text = "OTHER";
            otherBttn.UseVisualStyleBackColor = true;
            // 
            // dateOfBirth
            // 
            dateOfBirth.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateOfBirth.Location = new Point(165, 169);
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.Size = new Size(241, 27);
            dateOfBirth.TabIndex = 64;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(74, 421);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 23);
            textBox1.TabIndex = 65;
            textBox1.Text = "Educational Attainment:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.graduation;
            pictureBox2.Location = new Point(33, 418);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 66;
            pictureBox2.TabStop = false;
            // 
            // educAttainment
            // 
            educAttainment.BackColor = SystemColors.ControlLightLight;
            educAttainment.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            educAttainment.FormattingEnabled = true;
            educAttainment.Items.AddRange(new object[] { "High School", "Senior High School", "College Degree", "Masteral Degree", "Doctorate Degree" });
            educAttainment.Location = new Point(228, 461);
            educAttainment.Name = "educAttainment";
            educAttainment.Size = new Size(181, 26);
            educAttainment.TabIndex = 67;
            educAttainment.TextChanged += educAttainment_TextChanged;
            // 
            // degreeEarned
            // 
            degreeEarned.Enabled = false;
            degreeEarned.Font = new Font("Bahnschrift", 11.25F);
            degreeEarned.Location = new Point(168, 504);
            degreeEarned.Multiline = true;
            degreeEarned.Name = "degreeEarned";
            degreeEarned.Size = new Size(241, 26);
            degreeEarned.TabIndex = 69;
            // 
            // degreeLabel
            // 
            degreeLabel.BorderStyle = BorderStyle.None;
            degreeLabel.Enabled = false;
            degreeLabel.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            degreeLabel.Location = new Point(33, 506);
            degreeLabel.Name = "degreeLabel";
            degreeLabel.Size = new Size(84, 20);
            degreeLabel.TabIndex = 68;
            degreeLabel.Text = "Degree:";
            // 
            // hasWebsite
            // 
            hasWebsite.AutoSize = true;
            hasWebsite.Font = new Font("Bahnschrift SemiLight SemiConde", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hasWebsite.Location = new Point(466, 525);
            hasWebsite.Name = "hasWebsite";
            hasWebsite.Size = new Size(309, 20);
            hasWebsite.TabIndex = 70;
            hasWebsite.TabStop = true;
            hasWebsite.Text = "Check if you have a website. (Please provide link above)";
            hasWebsite.UseVisualStyleBackColor = true;
            hasWebsite.CheckedChanged += hasWebsite_CheckedChanged;
            // 
            // genderBox
            // 
            genderBox.Controls.Add(otherBttn);
            genderBox.Controls.Add(maleBttn);
            genderBox.Controls.Add(femaleBttn);
            genderBox.FlatStyle = FlatStyle.Flat;
            genderBox.Location = new Point(165, 198);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(241, 42);
            genderBox.TabIndex = 71;
            genderBox.TabStop = false;
            // 
            // portfolioWeb
            // 
            portfolioWeb.Font = new Font("Bahnschrift", 11.25F);
            portfolioWeb.Location = new Point(469, 561);
            portfolioWeb.Multiline = true;
            portfolioWeb.Name = "portfolioWeb";
            portfolioWeb.Size = new Size(268, 26);
            portfolioWeb.TabIndex = 72;
            portfolioWeb.Visible = false;
            // 
            // university
            // 
            university.Enabled = false;
            university.Font = new Font("Bahnschrift", 11.25F);
            university.Location = new Point(168, 546);
            university.Multiline = true;
            university.Name = "university";
            university.Size = new Size(241, 26);
            university.TabIndex = 74;
            // 
            // univLabel
            // 
            univLabel.BorderStyle = BorderStyle.None;
            univLabel.Enabled = false;
            univLabel.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            univLabel.Location = new Point(33, 548);
            univLabel.Name = "univLabel";
            univLabel.Size = new Size(124, 20);
            univLabel.TabIndex = 73;
            univLabel.Text = "Institution/Univ.:";
            // 
            // updateBttn
            // 
            updateBttn.BackColor = Color.FromArgb(13, 59, 141);
            updateBttn.FlatAppearance.BorderSize = 0;
            updateBttn.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 229, 148);
            updateBttn.FlatStyle = FlatStyle.Flat;
            updateBttn.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            updateBttn.ForeColor = SystemColors.ButtonHighlight;
            updateBttn.IconChar = FontAwesome.Sharp.IconChar.None;
            updateBttn.IconColor = Color.Black;
            updateBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            updateBttn.Location = new Point(298, 593);
            updateBttn.Name = "updateBttn";
            updateBttn.Size = new Size(84, 42);
            updateBttn.TabIndex = 75;
            updateBttn.Text = "Update";
            updateBttn.UseVisualStyleBackColor = false;
            updateBttn.Visible = false;
            updateBttn.Click += updateBttn_Click;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox7.Location = new Point(466, 136);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(118, 104);
            textBox7.TabIndex = 76;
            textBox7.Text = "Profile Picture:\r\n(Right click\r\nfor options)";
            // 
            // SetUpProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(859, 659);
            Controls.Add(textBox7);
            Controls.Add(updateBttn);
            Controls.Add(university);
            Controls.Add(univLabel);
            Controls.Add(portfolioWeb);
            Controls.Add(genderBox);
            Controls.Add(hasWebsite);
            Controls.Add(degreeEarned);
            Controls.Add(degreeLabel);
            Controls.Add(educAttainment);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(dateOfBirth);
            Controls.Add(textBox5);
            Controls.Add(clearInputsBttn);
            Controls.Add(submitBttn);
            Controls.Add(iconPictureBox3);
            Controls.Add(iconPictureBox1);
            Controls.Add(browseFileBttn3);
            Controls.Add(browseFileBttn2);
            Controls.Add(browseFileBttn1);
            Controls.Add(portfolio);
            Controls.Add(textBox22);
            Controls.Add(coverLetter);
            Controls.Add(label);
            Controls.Add(resumeDocx);
            Controls.Add(textBox17);
            Controls.Add(textBox20);
            Controls.Add(ProfilePicture);
            Controls.Add(textBox16);
            Controls.Add(contactNumber);
            Controls.Add(textBox13);
            Controls.Add(hunterNationality);
            Controls.Add(textBox11);
            Controls.Add(hunterAddress);
            Controls.Add(textBox9);
            Controls.Add(hunterEmail);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(fullName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SetUpProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Set up Job-Hunter Profile";
            pfpMenuOpt.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            genderBox.ResumeLayout(false);
            genderBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip pfpMenuOpt;
        private ToolStripMenuItem uploadLogoToolStripMenuItem;
        private ToolStripMenuItem viewLogoToolStripMenuItem;
        private ToolStripMenuItem deleteLogoToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox fullName;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox hunterEmail;
        private TextBox textBox9;
        private TextBox hunterAddress;
        private TextBox textBox11;
        private TextBox hunterNationality;
        private TextBox textBox13;
        private TextBox contactNumber;
        private TextBox textBox16;
        private FontAwesome.Sharp.IconButton clearInputsBttn;
        private TextBox textBox20;
        private TextBox textBox17;
        private TextBox resumeDocx;
        private TextBox label;
        private TextBox coverLetter;
        private TextBox textBox22;
        private TextBox portfolio;
        private FontAwesome.Sharp.IconButton browseFileBttn1;
        private FontAwesome.Sharp.IconButton browseFileBttn2;
        private FontAwesome.Sharp.IconButton browseFileBttn3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconButton submitBttn;
        private PictureBox ProfilePicture;
        private TextBox textBox5;
        private RadioButton maleBttn;
        private RadioButton femaleBttn;
        private RadioButton otherBttn;
        private DateTimePicker dateOfBirth;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private ComboBox educAttainment;
        private TextBox degreeEarned;
        private TextBox degreeLabel;
        private RadioButton hasWebsite;
        private GroupBox genderBox;
        private TextBox portfolioWeb;
        private TextBox university;
        private TextBox univLabel;
        private FontAwesome.Sharp.IconButton updateBttn;
        private TextBox textBox7;
    }
}