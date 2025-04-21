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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            menuBarPanel2 = new Panel();
            menuBarPanel3 = new Panel();
            panel2 = new Panel();
            searchBar = new ReaLTaiizor.Controls.DungeonTextBox();
            panel3 = new Panel();
            label1 = new Label();
            flowPostsPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            ShortlistBttn = new ReaLTaiizor.Controls.Button();
            ForInterviewBttn = new ReaLTaiizor.Controls.Button();
            RejectBttn = new ReaLTaiizor.Controls.Button();
            AcceptBttn = new ReaLTaiizor.Controls.Button();
            applicantsGridView = new ReaLTaiizor.Controls.PoisonDataGridView();
            applicantOpt = new ContextMenuStrip(components);
            emailApplicantStripMenuItem = new ToolStripMenuItem();
            panel6 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            menuBarPanel2.SuspendLayout();
            menuBarPanel3.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)applicantsGridView).BeginInit();
            applicantOpt.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
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
            searchBar.Size = new Size(277, 29);
            searchBar.TabIndex = 4;
            searchBar.Text = "  Filter/Search applicants...";
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
            panel3.Size = new Size(601, 51);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geoform", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(70, 15);
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
            panel5.Controls.Add(ShortlistBttn);
            panel5.Controls.Add(ForInterviewBttn);
            panel5.Controls.Add(RejectBttn);
            panel5.Controls.Add(AcceptBttn);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(743, 69);
            panel5.TabIndex = 0;
            // 
            // ShortlistBttn
            // 
            ShortlistBttn.BackColor = Color.Transparent;
            ShortlistBttn.BackgroundImageLayout = ImageLayout.None;
            ShortlistBttn.BorderColor = Color.Transparent;
            ShortlistBttn.EnteredBorderColor = Color.Black;
            ShortlistBttn.EnteredColor = Color.FromArgb(13, 59, 141);
            ShortlistBttn.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShortlistBttn.Image = null;
            ShortlistBttn.ImageAlign = ContentAlignment.MiddleLeft;
            ShortlistBttn.InactiveColor = Color.LightSlateGray;
            ShortlistBttn.Location = new Point(123, 15);
            ShortlistBttn.Name = "ShortlistBttn";
            ShortlistBttn.PressedBorderColor = Color.Transparent;
            ShortlistBttn.PressedColor = Color.FromArgb(13, 59, 141);
            ShortlistBttn.Size = new Size(106, 38);
            ShortlistBttn.TabIndex = 7;
            ShortlistBttn.Text = "Shortlist";
            ShortlistBttn.TextAlignment = StringAlignment.Center;
            ShortlistBttn.Click += ShortlistBttn_Click;
            // 
            // ForInterviewBttn
            // 
            ForInterviewBttn.BackColor = Color.Transparent;
            ForInterviewBttn.BackgroundImageLayout = ImageLayout.None;
            ForInterviewBttn.BorderColor = Color.Transparent;
            ForInterviewBttn.EnteredBorderColor = Color.Black;
            ForInterviewBttn.EnteredColor = Color.FromArgb(13, 59, 141);
            ForInterviewBttn.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForInterviewBttn.Image = null;
            ForInterviewBttn.ImageAlign = ContentAlignment.MiddleLeft;
            ForInterviewBttn.InactiveColor = Color.LightSlateGray;
            ForInterviewBttn.Location = new Point(247, 15);
            ForInterviewBttn.Name = "ForInterviewBttn";
            ForInterviewBttn.PressedBorderColor = Color.Transparent;
            ForInterviewBttn.PressedColor = Color.FromArgb(13, 59, 141);
            ForInterviewBttn.Size = new Size(124, 38);
            ForInterviewBttn.TabIndex = 6;
            ForInterviewBttn.Text = "For Interview";
            ForInterviewBttn.TextAlignment = StringAlignment.Center;
            ForInterviewBttn.Click += ForInterviewBttn_Click;
            // 
            // RejectBttn
            // 
            RejectBttn.BackColor = Color.Transparent;
            RejectBttn.BackgroundImageLayout = ImageLayout.None;
            RejectBttn.BorderColor = Color.Transparent;
            RejectBttn.EnteredBorderColor = Color.Black;
            RejectBttn.EnteredColor = Color.Firebrick;
            RejectBttn.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RejectBttn.Image = null;
            RejectBttn.ImageAlign = ContentAlignment.MiddleLeft;
            RejectBttn.InactiveColor = Color.LightSlateGray;
            RejectBttn.Location = new Point(18, 15);
            RejectBttn.Name = "RejectBttn";
            RejectBttn.PressedBorderColor = Color.Transparent;
            RejectBttn.PressedColor = Color.Firebrick;
            RejectBttn.Size = new Size(88, 38);
            RejectBttn.TabIndex = 5;
            RejectBttn.Text = "Reject";
            RejectBttn.TextAlignment = StringAlignment.Center;
            RejectBttn.Click += RejectBttn_Click;
            // 
            // AcceptBttn
            // 
            AcceptBttn.BackColor = Color.Transparent;
            AcceptBttn.BackgroundImageLayout = ImageLayout.None;
            AcceptBttn.BorderColor = Color.Transparent;
            AcceptBttn.EnteredBorderColor = Color.Black;
            AcceptBttn.EnteredColor = Color.FromArgb(35, 168, 109);
            AcceptBttn.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AcceptBttn.Image = null;
            AcceptBttn.ImageAlign = ContentAlignment.MiddleLeft;
            AcceptBttn.InactiveColor = Color.LightSlateGray;
            AcceptBttn.Location = new Point(388, 15);
            AcceptBttn.Name = "AcceptBttn";
            AcceptBttn.PressedBorderColor = Color.Transparent;
            AcceptBttn.PressedColor = Color.FromArgb(35, 168, 109);
            AcceptBttn.Size = new Size(88, 38);
            AcceptBttn.TabIndex = 4;
            AcceptBttn.Text = "Accept";
            AcceptBttn.TextAlignment = StringAlignment.Center;
            AcceptBttn.Click += AcceptBttn_Click;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Desktop;
            dataGridViewCellStyle4.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            applicantsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            applicantsGridView.ColumnHeadersHeight = 35;
            applicantsGridView.ContextMenuStrip = applicantOpt;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            applicantsGridView.DefaultCellStyle = dataGridViewCellStyle5;
            applicantsGridView.Dock = DockStyle.Fill;
            applicantsGridView.EnableHeadersVisualStyles = false;
            applicantsGridView.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            applicantsGridView.GridColor = Color.FromArgb(255, 255, 255);
            applicantsGridView.Location = new Point(0, 0);
            applicantsGridView.Name = "applicantsGridView";
            applicantsGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            applicantsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            applicantsGridView.RowHeadersVisible = false;
            applicantsGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            applicantsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            applicantsGridView.Size = new Size(743, 575);
            applicantsGridView.TabIndex = 13;
            applicantsGridView.CellClick += applicantsGridView_CellClick;
            applicantsGridView.CellDoubleClick += applicantsGridView_CellDoubleClick;
            applicantsGridView.MouseDown += applicantsGridView_MouseDown;
            // 
            // applicantOpt
            // 
            applicantOpt.BackColor = SystemColors.ButtonHighlight;
            applicantOpt.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            applicantOpt.Items.AddRange(new ToolStripItem[] { emailApplicantStripMenuItem });
            applicantOpt.Name = "logoMenuOpt";
            applicantOpt.Size = new Size(164, 26);
            // 
            // emailApplicantStripMenuItem
            // 
            emailApplicantStripMenuItem.Image = Properties.Resources.email;
            emailApplicantStripMenuItem.Name = "emailApplicantStripMenuItem";
            emailApplicantStripMenuItem.Size = new Size(163, 22);
            emailApplicantStripMenuItem.Text = "Email Applicant";
            emailApplicantStripMenuItem.Click += emailApplicantStripMenuItem_Click;
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
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconPictureBox1.IconColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(21, 7);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 7;
            iconPictureBox1.TabStop = false;
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
            applicantOpt.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
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
        private Panel panel5;
        private ReaLTaiizor.Controls.PoisonDataGridView applicantsGridView;
        private Panel panel6;
        private ReaLTaiizor.Controls.DungeonTextBox searchBar;
        private ReaLTaiizor.Controls.Button AcceptBttn;
        private ReaLTaiizor.Controls.Button RejectBttn;
        private ReaLTaiizor.Controls.Button ForInterviewBttn;
        private ReaLTaiizor.Controls.Button ShortlistBttn;
        private ContextMenuStrip applicantOpt;
        private ToolStripMenuItem emailApplicantStripMenuItem;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
