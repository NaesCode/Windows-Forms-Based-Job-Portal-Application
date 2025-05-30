namespace Job_Application_Manager
{
    partial class JobHunterEmailingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobHunterEmailingForm));
            menuBarPanel2 = new Panel();
            menuBarPanel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            browseFileBttn = new FontAwesome.Sharp.IconButton();
            AttachmentFiles = new ListBox();
            EmailSubject = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            CompanyEmail = new TextBox();
            panel1 = new Panel();
            clearInputsBttn = new FontAwesome.Sharp.IconButton();
            sendBttn = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            EmailBody = new RichTextBox();
            menuBarPanel2.SuspendLayout();
            menuBarPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuBarPanel2
            // 
            menuBarPanel2.Controls.Add(menuBarPanel3);
            menuBarPanel2.Dock = DockStyle.Top;
            menuBarPanel2.Location = new Point(0, 0);
            menuBarPanel2.Name = "menuBarPanel2";
            menuBarPanel2.Padding = new Padding(0, 2, 0, 2);
            menuBarPanel2.Size = new Size(874, 61);
            menuBarPanel2.TabIndex = 9;
            // 
            // menuBarPanel3
            // 
            menuBarPanel3.BackColor = SystemColors.Desktop;
            menuBarPanel3.Controls.Add(pictureBox2);
            menuBarPanel3.Controls.Add(panel3);
            menuBarPanel3.Dock = DockStyle.Fill;
            menuBarPanel3.Location = new Point(0, 2);
            menuBarPanel3.Name = "menuBarPanel3";
            menuBarPanel3.Size = new Size(874, 57);
            menuBarPanel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.gmail;
            pictureBox2.Location = new Point(806, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(315, 57);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Geoform", 9.749998F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(16, 20);
            label2.Name = "label2";
            label2.Size = new Size(89, 16);
            label2.TabIndex = 34;
            label2.Text = "JOB-HUNT";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geoform", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(130, 16);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 1;
            label1.Text = "SEND EMAIL";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(browseFileBttn);
            panel2.Controls.Add(AttachmentFiles);
            panel2.Controls.Add(EmailSubject);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(CompanyEmail);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(874, 172);
            panel2.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox2.Location = new Point(493, 19);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(136, 20);
            textBox2.TabIndex = 52;
            textBox2.Text = "Attach files here:";
            // 
            // browseFileBttn
            // 
            browseFileBttn.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            browseFileBttn.IconColor = Color.Black;
            browseFileBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            browseFileBttn.IconSize = 25;
            browseFileBttn.Location = new Point(799, 45);
            browseFileBttn.Name = "browseFileBttn";
            browseFileBttn.Size = new Size(44, 38);
            browseFileBttn.TabIndex = 51;
            browseFileBttn.UseVisualStyleBackColor = true;
            browseFileBttn.Click += browseFileBttn_Click;
            // 
            // AttachmentFiles
            // 
            AttachmentFiles.BackColor = SystemColors.ControlLight;
            AttachmentFiles.BorderStyle = BorderStyle.FixedSingle;
            AttachmentFiles.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AttachmentFiles.FormattingEnabled = true;
            AttachmentFiles.ItemHeight = 18;
            AttachmentFiles.Location = new Point(493, 45);
            AttachmentFiles.Name = "AttachmentFiles";
            AttachmentFiles.Size = new Size(309, 38);
            AttachmentFiles.TabIndex = 32;
            // 
            // EmailSubject
            // 
            EmailSubject.BackColor = SystemColors.ControlLight;
            EmailSubject.BorderStyle = BorderStyle.FixedSingle;
            EmailSubject.Font = new Font("Bahnschrift", 11.25F);
            EmailSubject.Location = new Point(124, 95);
            EmailSubject.Multiline = true;
            EmailSubject.Name = "EmailSubject";
            EmailSubject.Size = new Size(309, 26);
            EmailSubject.TabIndex = 30;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ButtonHighlight;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox4.Location = new Point(35, 98);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(83, 20);
            textBox4.TabIndex = 29;
            textBox4.Text = "Subject:";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonHighlight;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox3.Location = new Point(35, 47);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(83, 20);
            textBox3.TabIndex = 28;
            textBox3.Text = "To (Gmail): ";
            // 
            // CompanyEmail
            // 
            CompanyEmail.BackColor = SystemColors.ControlLight;
            CompanyEmail.BorderStyle = BorderStyle.FixedSingle;
            CompanyEmail.Font = new Font("Bahnschrift", 11.25F);
            CompanyEmail.Location = new Point(124, 45);
            CompanyEmail.Multiline = true;
            CompanyEmail.Name = "CompanyEmail";
            CompanyEmail.Size = new Size(309, 26);
            CompanyEmail.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(clearInputsBttn);
            panel1.Controls.Add(sendBttn);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(EmailBody);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 233);
            panel1.Name = "panel1";
            panel1.Size = new Size(874, 472);
            panel1.TabIndex = 19;
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
            clearInputsBttn.Location = new Point(165, 390);
            clearInputsBttn.Name = "clearInputsBttn";
            clearInputsBttn.Size = new Size(84, 42);
            clearInputsBttn.TabIndex = 61;
            clearInputsBttn.Text = "Clear";
            clearInputsBttn.UseVisualStyleBackColor = false;
            clearInputsBttn.Click += clearInputsBttn_Click;
            // 
            // sendBttn
            // 
            sendBttn.BackColor = Color.FromArgb(13, 59, 141);
            sendBttn.FlatAppearance.BorderSize = 0;
            sendBttn.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 229, 148);
            sendBttn.FlatStyle = FlatStyle.Flat;
            sendBttn.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            sendBttn.ForeColor = SystemColors.ButtonHighlight;
            sendBttn.IconChar = FontAwesome.Sharp.IconChar.None;
            sendBttn.IconColor = Color.Black;
            sendBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            sendBttn.Location = new Point(35, 390);
            sendBttn.Name = "sendBttn";
            sendBttn.Size = new Size(84, 42);
            sendBttn.TabIndex = 60;
            sendBttn.Text = "Send";
            sendBttn.UseVisualStyleBackColor = false;
            sendBttn.Click += sendBttn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            textBox1.Location = new Point(35, 19);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(116, 20);
            textBox1.TabIndex = 30;
            textBox1.Text = "Message Body:";
            // 
            // EmailBody
            // 
            EmailBody.BackColor = SystemColors.ControlLight;
            EmailBody.BorderStyle = BorderStyle.None;
            EmailBody.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailBody.ForeColor = SystemColors.ControlDarkDark;
            EmailBody.Location = new Point(35, 55);
            EmailBody.Name = "EmailBody";
            EmailBody.Size = new Size(803, 303);
            EmailBody.TabIndex = 20;
            EmailBody.Text = "Type your email message here...";
            // 
            // JobHunterEmailingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(874, 705);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(menuBarPanel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "JobHunterEmailingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += JobHunterProfile_Load;
            menuBarPanel2.ResumeLayout(false);
            menuBarPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel menuBarPanel2;
        private Panel menuBarPanel3;
        private Panel panel3;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private RichTextBox EmailBody;
        private TextBox EmailSubject;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox CompanyEmail;
        private TextBox textBox1;
        private ListBox AttachmentFiles;
        private FontAwesome.Sharp.IconButton browseFileBttn;
        private TextBox textBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton clearInputsBttn;
        private FontAwesome.Sharp.IconButton sendBttn;
        private PictureBox pictureBox2;
    }
}
