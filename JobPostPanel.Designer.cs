﻿namespace Job_Application_Manager
{
    partial class JobPostPanel
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
            jobTypeLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            companyNameLabel = new Label();
            jobLocationLabel = new Label();
            workModeLabel = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            closedPositionLabel = new TextBox();
            jobTitleBttn = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            saveJobBttn = new ReaLTaiizor.Controls.Button();
            vacancyLabel = new Label();
            initialSalaryLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)companyLogoPic).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // companyLogoPic
            // 
            companyLogoPic.BackColor = SystemColors.Control;
            companyLogoPic.Dock = DockStyle.Left;
            companyLogoPic.Location = new Point(0, 0);
            companyLogoPic.Name = "companyLogoPic";
            companyLogoPic.Size = new Size(113, 117);
            companyLogoPic.SizeMode = PictureBoxSizeMode.StretchImage;
            companyLogoPic.TabIndex = 0;
            companyLogoPic.TabStop = false;
            // 
            // jobTypeLabel
            // 
            jobTypeLabel.AutoSize = true;
            jobTypeLabel.Font = new Font("Bahnschrift Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jobTypeLabel.Location = new Point(109, 18);
            jobTypeLabel.Name = "jobTypeLabel";
            jobTypeLabel.Size = new Size(83, 18);
            jobTypeLabel.TabIndex = 9;
            jobTypeLabel.Text = "( Job Type )";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(companyNameLabel);
            flowLayoutPanel1.Controls.Add(jobLocationLabel);
            flowLayoutPanel1.Controls.Add(workModeLabel);
            flowLayoutPanel1.Controls.Add(jobTypeLabel);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 58);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(280, 59);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Font = new Font("Bahnschrift Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            companyNameLabel.Location = new Point(3, 0);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(113, 18);
            companyNameLabel.TabIndex = 8;
            companyNameLabel.Text = "Company Name";
            // 
            // jobLocationLabel
            // 
            jobLocationLabel.AutoSize = true;
            jobLocationLabel.Font = new Font("Bahnschrift Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jobLocationLabel.Location = new Point(122, 0);
            jobLocationLabel.Name = "jobLocationLabel";
            jobLocationLabel.Size = new Size(93, 18);
            jobLocationLabel.TabIndex = 9;
            jobLocationLabel.Text = "Job Location";
            // 
            // workModeLabel
            // 
            workModeLabel.AutoSize = true;
            workModeLabel.Font = new Font("Bahnschrift Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            workModeLabel.Location = new Point(3, 18);
            workModeLabel.Name = "workModeLabel";
            workModeLabel.Size = new Size(100, 18);
            workModeLabel.TabIndex = 11;
            workModeLabel.Text = "( Work Mode )";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(113, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 117);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(closedPositionLabel);
            panel2.Controls.Add(jobTitleBttn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 58);
            panel2.TabIndex = 12;
            // 
            // closedPositionLabel
            // 
            closedPositionLabel.BackColor = SystemColors.ButtonHighlight;
            closedPositionLabel.BorderStyle = BorderStyle.None;
            closedPositionLabel.Dock = DockStyle.Right;
            closedPositionLabel.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closedPositionLabel.ForeColor = SystemColors.GrayText;
            closedPositionLabel.Location = new Point(140, 0);
            closedPositionLabel.Multiline = true;
            closedPositionLabel.Name = "closedPositionLabel";
            closedPositionLabel.ReadOnly = true;
            closedPositionLabel.Size = new Size(140, 58);
            closedPositionLabel.TabIndex = 4;
            closedPositionLabel.Text = "\r\n[ Position Closed ]";
            closedPositionLabel.Visible = false;
            // 
            // jobTitleBttn
            // 
            jobTitleBttn.AutoSize = true;
            jobTitleBttn.BackColor = Color.Transparent;
            jobTitleBttn.FlatAppearance.BorderSize = 0;
            jobTitleBttn.FlatStyle = FlatStyle.Flat;
            jobTitleBttn.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jobTitleBttn.IconChar = FontAwesome.Sharp.IconChar.None;
            jobTitleBttn.IconColor = Color.Black;
            jobTitleBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            jobTitleBttn.Location = new Point(0, 0);
            jobTitleBttn.Name = "jobTitleBttn";
            jobTitleBttn.Size = new Size(105, 57);
            jobTitleBttn.TabIndex = 3;
            jobTitleBttn.Text = "Job Title";
            jobTitleBttn.UseVisualStyleBackColor = false;
            jobTitleBttn.Click += jobTitleBttn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(saveJobBttn);
            panel3.Controls.Add(vacancyLabel);
            panel3.Controls.Add(initialSalaryLabel);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(280, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(140, 117);
            panel3.TabIndex = 14;
            // 
            // saveJobBttn
            // 
            saveJobBttn.BackColor = Color.Transparent;
            saveJobBttn.BackgroundImageLayout = ImageLayout.None;
            saveJobBttn.BorderColor = Color.Transparent;
            saveJobBttn.EnteredBorderColor = Color.Transparent;
            saveJobBttn.EnteredColor = Color.FromArgb(13, 59, 141);
            saveJobBttn.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveJobBttn.Image = null;
            saveJobBttn.ImageAlign = ContentAlignment.MiddleLeft;
            saveJobBttn.InactiveColor = SystemColors.ControlDark;
            saveJobBttn.Location = new Point(36, 66);
            saveJobBttn.Name = "saveJobBttn";
            saveJobBttn.PressedBorderColor = Color.Transparent;
            saveJobBttn.PressedColor = SystemColors.ControlLight;
            saveJobBttn.Size = new Size(70, 34);
            saveJobBttn.TabIndex = 14;
            saveJobBttn.Text = "Save";
            saveJobBttn.TextAlignment = StringAlignment.Center;
            saveJobBttn.Click += saveJobBttn_Click;
            // 
            // vacancyLabel
            // 
            vacancyLabel.AutoSize = true;
            vacancyLabel.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vacancyLabel.ForeColor = SystemColors.ControlDarkDark;
            vacancyLabel.Location = new Point(8, 31);
            vacancyLabel.Name = "vacancyLabel";
            vacancyLabel.Size = new Size(124, 19);
            vacancyLabel.TabIndex = 13;
            vacancyLabel.Text = "0 Available Pos.";
            // 
            // initialSalaryLabel
            // 
            initialSalaryLabel.AutoSize = true;
            initialSalaryLabel.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            initialSalaryLabel.ForeColor = SystemColors.ControlDarkDark;
            initialSalaryLabel.Location = new Point(3, 9);
            initialSalaryLabel.Name = "initialSalaryLabel";
            initialSalaryLabel.Size = new Size(127, 19);
            initialSalaryLabel.TabIndex = 12;
            initialSalaryLabel.Text = "0000.00 / month";
            // 
            // JobPostPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panel1);
            Controls.Add(companyLogoPic);
            Name = "JobPostPanel";
            Size = new Size(533, 117);
            ((System.ComponentModel.ISupportInitialize)companyLogoPic).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox companyLogoPic;
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
        private FontAwesome.Sharp.IconButton jobTitleBttn;
        private ReaLTaiizor.Controls.Button saveJobBttn;
        private TextBox closedPositionLabel;
    }
}
