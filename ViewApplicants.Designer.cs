namespace Job_Application_Manager
{
    partial class ViewApplicants
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
            jobTitleBttn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)companyLogoPic).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
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
            // jobTypeLabel
            // 
            jobTypeLabel.AutoSize = true;
            jobTypeLabel.Font = new Font("Bahnschrift Light", 9.75F);
            jobTypeLabel.Location = new Point(3, 16);
            jobTypeLabel.Name = "jobTypeLabel";
            jobTypeLabel.Size = new Size(71, 16);
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
            flowLayoutPanel1.Location = new Point(0, 51);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(294, 59);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Font = new Font("Bahnschrift Light", 9.75F);
            companyNameLabel.Location = new Point(3, 0);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(97, 16);
            companyNameLabel.TabIndex = 8;
            companyNameLabel.Text = "Company Name";
            // 
            // jobLocationLabel
            // 
            jobLocationLabel.AutoSize = true;
            jobLocationLabel.Font = new Font("Bahnschrift Light", 9.75F);
            jobLocationLabel.Location = new Point(106, 0);
            jobLocationLabel.Name = "jobLocationLabel";
            jobLocationLabel.Size = new Size(79, 16);
            jobLocationLabel.TabIndex = 9;
            jobLocationLabel.Text = "Job Location";
            // 
            // workModeLabel
            // 
            workModeLabel.AutoSize = true;
            workModeLabel.Font = new Font("Bahnschrift Light", 9.75F);
            workModeLabel.Location = new Point(191, 0);
            workModeLabel.Name = "workModeLabel";
            workModeLabel.Size = new Size(85, 16);
            workModeLabel.TabIndex = 11;
            workModeLabel.Text = "( Work Mode )";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(113, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 110);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(jobTitleBttn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 51);
            panel2.TabIndex = 12;
            // 
            // jobTitleBttn
            // 
            jobTitleBttn.AutoSize = true;
            jobTitleBttn.BackColor = Color.Transparent;
            jobTitleBttn.FlatAppearance.BorderSize = 0;
            jobTitleBttn.FlatStyle = FlatStyle.Flat;
            jobTitleBttn.Font = new Font("Bahnschrift SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jobTitleBttn.IconChar = FontAwesome.Sharp.IconChar.None;
            jobTitleBttn.IconColor = Color.Black;
            jobTitleBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            jobTitleBttn.Location = new Point(0, 0);
            jobTitleBttn.Name = "jobTitleBttn";
            jobTitleBttn.Size = new Size(294, 54);
            jobTitleBttn.TabIndex = 3;
            jobTitleBttn.Text = "Job Title";
            jobTitleBttn.TextAlign = ContentAlignment.MiddleLeft;
            jobTitleBttn.UseVisualStyleBackColor = false;
            jobTitleBttn.Click += jobTitleBttn_Click;
            // 
            // ViewApplicants
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panel1);
            Controls.Add(companyLogoPic);
            Name = "ViewApplicants";
            Size = new Size(407, 110);
            ((System.ComponentModel.ISupportInitialize)companyLogoPic).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel2;
        private FontAwesome.Sharp.IconButton jobTitleBttn;
    }
}
