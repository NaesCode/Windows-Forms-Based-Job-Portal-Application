namespace Job_Application_Manager
{
    partial class JobPostPreviewPanel
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
            companyLogoPic = new PictureBox();
            jobTitleLabel = new Label();
            jobTypeLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            companyNameLabel = new Label();
            panel6 = new Panel();
            jobLocationLabel = new Label();
            panel5 = new Panel();
            workModeLabel = new Label();
            panel4 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            vacancyLabel = new Label();
            initialSalaryLabel = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)companyLogoPic).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // companyLogoPic
            // 
            companyLogoPic.BackColor = SystemColors.Control;
            companyLogoPic.Dock = DockStyle.Left;
            companyLogoPic.Location = new Point(0, 0);
            companyLogoPic.Name = "companyLogoPic";
            companyLogoPic.Size = new Size(113, 110);
            companyLogoPic.SizeMode = PictureBoxSizeMode.StretchImage;
            companyLogoPic.TabIndex = 0;
            companyLogoPic.TabStop = false;
            // 
            // jobTitleLabel
            // 
            jobTitleLabel.Font = new Font("Bahnschrift SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jobTitleLabel.Location = new Point(0, 0);
            jobTitleLabel.Name = "jobTitleLabel";
            jobTitleLabel.Size = new Size(509, 57);
            jobTitleLabel.TabIndex = 2;
            jobTitleLabel.Text = "Job Title";
            jobTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // jobTypeLabel
            // 
            jobTypeLabel.AutoSize = true;
            jobTypeLabel.Font = new Font("Bahnschrift Light", 11.25F);
            jobTypeLabel.Location = new Point(441, 0);
            jobTypeLabel.Name = "jobTypeLabel";
            jobTypeLabel.Size = new Size(83, 18);
            jobTypeLabel.TabIndex = 9;
            jobTypeLabel.Text = "( Job Type )";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(companyNameLabel);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(jobLocationLabel);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(workModeLabel);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(jobTypeLabel);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 57);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1037, 53);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Font = new Font("Bahnschrift Light", 11.25F);
            companyNameLabel.Location = new Point(3, 0);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(113, 18);
            companyNameLabel.TabIndex = 8;
            companyNameLabel.Text = "Company Name";
            // 
            // panel6
            // 
            panel6.Location = new Point(122, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(32, 13);
            panel6.TabIndex = 14;
            // 
            // jobLocationLabel
            // 
            jobLocationLabel.AutoSize = true;
            jobLocationLabel.Font = new Font("Bahnschrift Light", 11.25F);
            jobLocationLabel.Location = new Point(160, 0);
            jobLocationLabel.Name = "jobLocationLabel";
            jobLocationLabel.Size = new Size(93, 18);
            jobLocationLabel.TabIndex = 9;
            jobLocationLabel.Text = "Job Location";
            // 
            // panel5
            // 
            panel5.Location = new Point(259, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(32, 13);
            panel5.TabIndex = 13;
            // 
            // workModeLabel
            // 
            workModeLabel.AutoSize = true;
            workModeLabel.Font = new Font("Bahnschrift Light", 11.25F);
            workModeLabel.Location = new Point(297, 0);
            workModeLabel.Name = "workModeLabel";
            workModeLabel.Size = new Size(100, 18);
            workModeLabel.TabIndex = 11;
            workModeLabel.Text = "( Work Mode )";
            // 
            // panel4
            // 
            panel4.Location = new Point(403, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(32, 13);
            panel4.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(113, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 110);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(vacancyLabel);
            panel3.Controls.Add(initialSalaryLabel);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(858, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(179, 57);
            panel3.TabIndex = 14;
            // 
            // vacancyLabel
            // 
            vacancyLabel.AutoSize = true;
            vacancyLabel.Font = new Font("Bahnschrift Light", 12F);
            vacancyLabel.ForeColor = SystemColors.ControlDarkDark;
            vacancyLabel.Location = new Point(13, 31);
            vacancyLabel.Name = "vacancyLabel";
            vacancyLabel.Size = new Size(124, 19);
            vacancyLabel.TabIndex = 13;
            vacancyLabel.Text = "0 Available Pos.";
            // 
            // initialSalaryLabel
            // 
            initialSalaryLabel.AutoSize = true;
            initialSalaryLabel.Font = new Font("Bahnschrift Light", 12F);
            initialSalaryLabel.ForeColor = SystemColors.ControlDarkDark;
            initialSalaryLabel.Location = new Point(8, 9);
            initialSalaryLabel.Name = "initialSalaryLabel";
            initialSalaryLabel.Size = new Size(127, 19);
            initialSalaryLabel.TabIndex = 12;
            initialSalaryLabel.Text = "0000.00 / month";
            // 
            // panel2
            // 
            panel2.Controls.Add(jobTitleLabel);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 57);
            panel2.TabIndex = 12;
            // 
            // JobPostPreviewPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panel1);
            Controls.Add(companyLogoPic);
            Name = "JobPostPreviewPanel";
            Size = new Size(1150, 110);
            ((System.ComponentModel.ISupportInitialize)companyLogoPic).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox companyLogoPic;
        private Label jobTitleLabel;
        private Label jobTypeLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label companyNameLabel;
        private Label jobLocationLabel;
        private Label workModeLabel;
        private Panel panel1;
        private Panel panel3;
        private Label initialSalaryLabel;
        private Panel panel2;
        private Label vacancyLabel;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
    }
}
