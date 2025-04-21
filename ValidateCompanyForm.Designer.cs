namespace Job_Application_Manager
{
    partial class ValidateCompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidateCompanyForm));
            logoMenuOpt = new ContextMenuStrip(components);
            uploadLogoToolStripMenuItem = new ToolStripMenuItem();
            viewLogoToolStripMenuItem = new ToolStripMenuItem();
            deleteLogoToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            companyName = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            Industry = new TextBox();
            textBox6 = new TextBox();
            companyAddress = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            contactPerson = new TextBox();
            textBox11 = new TextBox();
            contactPosition = new TextBox();
            textBox13 = new TextBox();
            contactNumber = new TextBox();
            textBox16 = new TextBox();
            contactEmail = new TextBox();
            clearInputsBttn = new FontAwesome.Sharp.IconButton();
            textBox20 = new TextBox();
            textBox17 = new TextBox();
            COR = new TextBox();
            textBox19 = new TextBox();
            BIRR = new TextBox();
            textBox22 = new TextBox();
            MP = new TextBox();
            browseFileBttn1 = new FontAwesome.Sharp.IconButton();
            browseFileBttn2 = new FontAwesome.Sharp.IconButton();
            browseFileBttn3 = new FontAwesome.Sharp.IconButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            submitBttn = new FontAwesome.Sharp.IconButton();
            companyLogo = new PictureBox();
            website = new TextBox();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            requestUpdateBttn = new FontAwesome.Sharp.IconButton();
            UpdateBttn = new FontAwesome.Sharp.IconButton();
            logoMenuOpt.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)companyLogo).BeginInit();
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
            uploadLogoToolStripMenuItem.Click += uploadLogoToolStripMenuItem_Click;
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
            label1.Size = new Size(591, 22);
            label1.TabIndex = 0;
            label1.Text = "COMPANY INFORMATION AND LEGITIMACY VALIDATION";
            // 
            // companyName
            // 
            companyName.Font = new Font("Bahnschrift", 11.25F);
            companyName.Location = new Point(179, 132);
            companyName.Multiline = true;
            companyName.Name = "companyName";
            companyName.Size = new Size(227, 26);
            companyName.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(74, 90);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(245, 23);
            textBox2.TabIndex = 23;
            textBox2.Text = "Basic Company Information:\r\n";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonHighlight;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox3.Location = new Point(33, 133);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(126, 20);
            textBox3.TabIndex = 24;
            textBox3.Text = "Company Name:";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ButtonHighlight;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox4.Location = new Point(33, 173);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(126, 20);
            textBox4.TabIndex = 25;
            textBox4.Text = "Industry:";
            // 
            // Industry
            // 
            Industry.Font = new Font("Bahnschrift", 11.25F);
            Industry.Location = new Point(179, 171);
            Industry.Multiline = true;
            Industry.Name = "Industry";
            Industry.Size = new Size(227, 26);
            Industry.TabIndex = 26;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ButtonHighlight;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox6.Location = new Point(33, 211);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(140, 20);
            textBox6.TabIndex = 27;
            textBox6.Text = "Company Address:";
            // 
            // companyAddress
            // 
            companyAddress.Font = new Font("Bahnschrift", 11.25F);
            companyAddress.Location = new Point(179, 211);
            companyAddress.Multiline = true;
            companyAddress.Name = "companyAddress";
            companyAddress.Size = new Size(227, 26);
            companyAddress.TabIndex = 28;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.ButtonHighlight;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(74, 305);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(213, 23);
            textBox8.TabIndex = 29;
            textBox8.Text = "Contact Person Details:";
            // 
            // textBox9
            // 
            textBox9.BackColor = SystemColors.ButtonHighlight;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox9.Location = new Point(33, 351);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(58, 20);
            textBox9.TabIndex = 30;
            textBox9.Text = "Name: ";
            // 
            // contactPerson
            // 
            contactPerson.Font = new Font("Bahnschrift", 11.25F);
            contactPerson.Location = new Point(163, 351);
            contactPerson.Multiline = true;
            contactPerson.Name = "contactPerson";
            contactPerson.Size = new Size(243, 26);
            contactPerson.TabIndex = 31;
            // 
            // textBox11
            // 
            textBox11.BackColor = SystemColors.ButtonHighlight;
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox11.Location = new Point(33, 391);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(70, 20);
            textBox11.TabIndex = 32;
            textBox11.Text = "Position:";
            // 
            // contactPosition
            // 
            contactPosition.Font = new Font("Bahnschrift", 11.25F);
            contactPosition.Location = new Point(163, 391);
            contactPosition.Multiline = true;
            contactPosition.Name = "contactPosition";
            contactPosition.Size = new Size(243, 26);
            contactPosition.TabIndex = 33;
            // 
            // textBox13
            // 
            textBox13.BackColor = SystemColors.ButtonHighlight;
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox13.Location = new Point(33, 433);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(126, 20);
            textBox13.TabIndex = 34;
            textBox13.Text = "Contact Number:";
            // 
            // contactNumber
            // 
            contactNumber.Font = new Font("Bahnschrift", 11.25F);
            contactNumber.Location = new Point(164, 432);
            contactNumber.Multiline = true;
            contactNumber.Name = "contactNumber";
            contactNumber.Size = new Size(243, 26);
            contactNumber.TabIndex = 35;
            // 
            // textBox16
            // 
            textBox16.BackColor = SystemColors.ButtonHighlight;
            textBox16.BorderStyle = BorderStyle.None;
            textBox16.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox16.Location = new Point(33, 474);
            textBox16.Name = "textBox16";
            textBox16.ReadOnly = true;
            textBox16.Size = new Size(126, 20);
            textBox16.TabIndex = 36;
            textBox16.Text = "Email:\r\n";
            // 
            // contactEmail
            // 
            contactEmail.Font = new Font("Bahnschrift", 11.25F);
            contactEmail.Location = new Point(164, 473);
            contactEmail.Multiline = true;
            contactEmail.Name = "contactEmail";
            contactEmail.Size = new Size(243, 26);
            contactEmail.TabIndex = 37;
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
            clearInputsBttn.Location = new Point(203, 538);
            clearInputsBttn.Name = "clearInputsBttn";
            clearInputsBttn.Size = new Size(84, 42);
            clearInputsBttn.TabIndex = 59;
            clearInputsBttn.Text = "Clear";
            clearInputsBttn.UseVisualStyleBackColor = false;
            // 
            // textBox20
            // 
            textBox20.BackColor = SystemColors.ButtonHighlight;
            textBox20.BorderStyle = BorderStyle.None;
            textBox20.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox20.Location = new Point(512, 271);
            textBox20.Name = "textBox20";
            textBox20.ReadOnly = true;
            textBox20.Size = new Size(285, 23);
            textBox20.TabIndex = 43;
            textBox20.Text = "Supporting Documents (in PDFs):";
            // 
            // textBox17
            // 
            textBox17.BackColor = SystemColors.ButtonHighlight;
            textBox17.BorderStyle = BorderStyle.None;
            textBox17.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox17.Location = new Point(469, 317);
            textBox17.Name = "textBox17";
            textBox17.ReadOnly = true;
            textBox17.Size = new Size(243, 20);
            textBox17.TabIndex = 44;
            textBox17.Text = "Certificate of Registration (SEC):";
            // 
            // COR
            // 
            COR.Font = new Font("Bahnschrift", 11.25F);
            COR.Location = new Point(469, 345);
            COR.Multiline = true;
            COR.Name = "COR";
            COR.Size = new Size(243, 26);
            COR.TabIndex = 45;
            // 
            // textBox19
            // 
            textBox19.BackColor = SystemColors.ButtonHighlight;
            textBox19.BorderStyle = BorderStyle.None;
            textBox19.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox19.Location = new Point(469, 389);
            textBox19.Name = "textBox19";
            textBox19.ReadOnly = true;
            textBox19.Size = new Size(128, 20);
            textBox19.TabIndex = 46;
            textBox19.Text = "BIR Registration:";
            // 
            // BIRR
            // 
            BIRR.Font = new Font("Bahnschrift", 11.25F);
            BIRR.Location = new Point(469, 418);
            BIRR.Multiline = true;
            BIRR.Name = "BIRR";
            BIRR.Size = new Size(243, 26);
            BIRR.TabIndex = 47;
            // 
            // textBox22
            // 
            textBox22.BackColor = SystemColors.ButtonHighlight;
            textBox22.BorderStyle = BorderStyle.None;
            textBox22.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox22.Location = new Point(469, 463);
            textBox22.Name = "textBox22";
            textBox22.ReadOnly = true;
            textBox22.Size = new Size(128, 20);
            textBox22.TabIndex = 48;
            textBox22.Text = "Mayor's Permit:";
            // 
            // MP
            // 
            MP.Font = new Font("Bahnschrift", 11.25F);
            MP.Location = new Point(469, 493);
            MP.Multiline = true;
            MP.Name = "MP";
            MP.Size = new Size(243, 26);
            MP.TabIndex = 49;
            // 
            // browseFileBttn1
            // 
            browseFileBttn1.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            browseFileBttn1.IconColor = Color.Black;
            browseFileBttn1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            browseFileBttn1.IconSize = 25;
            browseFileBttn1.Location = new Point(710, 344);
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
            browseFileBttn2.Location = new Point(710, 417);
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
            browseFileBttn3.Location = new Point(710, 492);
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
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = SystemColors.ButtonHighlight;
            iconPictureBox2.BackgroundImage = Properties.Resources.contactPerson;
            iconPictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.Location = new Point(33, 300);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(32, 32);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPictureBox2.TabIndex = 56;
            iconPictureBox2.TabStop = false;
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
            submitBttn.Location = new Point(59, 538);
            submitBttn.Name = "submitBttn";
            submitBttn.Size = new Size(84, 42);
            submitBttn.TabIndex = 58;
            submitBttn.Text = "Submit";
            submitBttn.UseVisualStyleBackColor = false;
            submitBttn.Click += submitBttn_Click;
            // 
            // companyLogo
            // 
            companyLogo.BackColor = SystemColors.ControlDark;
            companyLogo.ContextMenuStrip = logoMenuOpt;
            companyLogo.InitialImage = Properties.Resources.research;
            companyLogo.Location = new Point(608, 90);
            companyLogo.Name = "companyLogo";
            companyLogo.Size = new Size(189, 152);
            companyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            companyLogo.TabIndex = 41;
            companyLogo.TabStop = false;
            // 
            // website
            // 
            website.Font = new Font("Bahnschrift", 11.25F);
            website.Location = new Point(180, 251);
            website.Multiline = true;
            website.Name = "website";
            website.Size = new Size(227, 26);
            website.TabIndex = 61;
            website.Text = "https://";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ButtonHighlight;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox5.Location = new Point(33, 252);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(157, 20);
            textBox5.TabIndex = 60;
            textBox5.Text = "Website:";
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.ButtonHighlight;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox7.Location = new Point(469, 134);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(95, 63);
            textBox7.TabIndex = 77;
            textBox7.Text = "Logo:\r\n(Right click\r\nfor options)";
            // 
            // requestUpdateBttn
            // 
            requestUpdateBttn.BackColor = Color.FromArgb(13, 59, 141);
            requestUpdateBttn.FlatAppearance.BorderSize = 0;
            requestUpdateBttn.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 229, 148);
            requestUpdateBttn.FlatStyle = FlatStyle.Flat;
            requestUpdateBttn.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            requestUpdateBttn.ForeColor = SystemColors.ButtonHighlight;
            requestUpdateBttn.IconChar = FontAwesome.Sharp.IconChar.None;
            requestUpdateBttn.IconColor = Color.Black;
            requestUpdateBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            requestUpdateBttn.Location = new Point(345, 538);
            requestUpdateBttn.Name = "requestUpdateBttn";
            requestUpdateBttn.Size = new Size(132, 42);
            requestUpdateBttn.TabIndex = 78;
            requestUpdateBttn.Text = "Request Update";
            requestUpdateBttn.UseVisualStyleBackColor = false;
            requestUpdateBttn.Visible = false;
            requestUpdateBttn.Click += requestUpdateBttn_Click;
            // 
            // UpdateBttn
            // 
            UpdateBttn.BackColor = Color.FromArgb(13, 59, 141);
            UpdateBttn.FlatAppearance.BorderSize = 0;
            UpdateBttn.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 229, 148);
            UpdateBttn.FlatStyle = FlatStyle.Flat;
            UpdateBttn.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            UpdateBttn.ForeColor = SystemColors.ButtonHighlight;
            UpdateBttn.IconChar = FontAwesome.Sharp.IconChar.None;
            UpdateBttn.IconColor = Color.Black;
            UpdateBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            UpdateBttn.Location = new Point(525, 538);
            UpdateBttn.Name = "UpdateBttn";
            UpdateBttn.Size = new Size(84, 42);
            UpdateBttn.TabIndex = 79;
            UpdateBttn.Text = "Update";
            UpdateBttn.UseVisualStyleBackColor = false;
            UpdateBttn.Visible = false;
            UpdateBttn.Click += UpdateBttn_Click;
            // 
            // ValidateCompanyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(859, 629);
            Controls.Add(UpdateBttn);
            Controls.Add(requestUpdateBttn);
            Controls.Add(textBox7);
            Controls.Add(website);
            Controls.Add(textBox5);
            Controls.Add(clearInputsBttn);
            Controls.Add(submitBttn);
            Controls.Add(iconPictureBox3);
            Controls.Add(iconPictureBox2);
            Controls.Add(iconPictureBox1);
            Controls.Add(browseFileBttn3);
            Controls.Add(browseFileBttn2);
            Controls.Add(browseFileBttn1);
            Controls.Add(MP);
            Controls.Add(textBox22);
            Controls.Add(BIRR);
            Controls.Add(textBox19);
            Controls.Add(COR);
            Controls.Add(textBox17);
            Controls.Add(textBox20);
            Controls.Add(companyLogo);
            Controls.Add(contactEmail);
            Controls.Add(textBox16);
            Controls.Add(contactNumber);
            Controls.Add(textBox13);
            Controls.Add(contactPosition);
            Controls.Add(textBox11);
            Controls.Add(contactPerson);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(companyAddress);
            Controls.Add(textBox6);
            Controls.Add(Industry);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(companyName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ValidateCompanyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company Information and Legitamacy Validation";
            logoMenuOpt.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)companyLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip logoMenuOpt;
        private ToolStripMenuItem uploadLogoToolStripMenuItem;
        private ToolStripMenuItem viewLogoToolStripMenuItem;
        private ToolStripMenuItem deleteLogoToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox companyName;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox Industry;
        private TextBox textBox6;
        private TextBox companyAddress;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox contactPerson;
        private TextBox textBox11;
        private TextBox contactPosition;
        private TextBox textBox13;
        private TextBox contactNumber;
        private TextBox textBox16;
        private TextBox contactEmail;
        private FontAwesome.Sharp.IconButton clearInputsBttn;
        private TextBox textBox20;
        private TextBox textBox17;
        private TextBox COR;
        private TextBox textBox19;
        private TextBox BIRR;
        private TextBox textBox22;
        private TextBox MP;
        private FontAwesome.Sharp.IconButton browseFileBttn1;
        private FontAwesome.Sharp.IconButton browseFileBttn2;
        private FontAwesome.Sharp.IconButton browseFileBttn3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconButton submitBttn;
        private PictureBox companyLogo;
        private TextBox website;
        private TextBox textBox5;
        private TextBox textBox7;
        private FontAwesome.Sharp.IconButton requestUpdateBttn;
        private FontAwesome.Sharp.IconButton UpdateBttn;
    }
}