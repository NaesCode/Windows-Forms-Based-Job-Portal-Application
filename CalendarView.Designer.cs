namespace Job_Application_Manager
{
    partial class CalendarView
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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label4 = new Label();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            nextMonth = new FontAwesome.Sharp.IconButton();
            prevMonth = new FontAwesome.Sharp.IconButton();
            MonthLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(nextMonth);
            panel1.Controls.Add(prevMonth);
            panel1.Controls.Add(MonthLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1169, 155);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(1169, 40);
            panel2.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(1072, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 0;
            label1.Text = "Sunday";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(403, 9);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 3;
            label4.Text = "Wednesday";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(586, 9);
            label7.Name = "label7";
            label7.Size = new Size(76, 19);
            label7.TabIndex = 9;
            label7.Text = "Thursday";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 9);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 1;
            label2.Text = "Monday";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(227, 9);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 2;
            label3.Text = "Tuesday";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(752, 9);
            label5.Name = "label5";
            label5.Size = new Size(55, 19);
            label5.TabIndex = 4;
            label5.Text = "Friday";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(908, 9);
            label6.Name = "label6";
            label6.Size = new Size(75, 19);
            label6.TabIndex = 5;
            label6.Text = "Saturday";
            // 
            // nextMonth
            // 
            nextMonth.BackColor = Color.Transparent;
            nextMonth.FlatAppearance.BorderSize = 0;
            nextMonth.FlatStyle = FlatStyle.Flat;
            nextMonth.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            nextMonth.IconChar = FontAwesome.Sharp.IconChar.LeftLong;
            nextMonth.IconColor = SystemColors.ActiveCaption;
            nextMonth.IconFont = FontAwesome.Sharp.IconFont.Auto;
            nextMonth.IconSize = 40;
            nextMonth.Location = new Point(358, 32);
            nextMonth.Name = "nextMonth";
            nextMonth.Size = new Size(58, 32);
            nextMonth.TabIndex = 8;
            nextMonth.UseVisualStyleBackColor = false;
            nextMonth.Click += nextMonth_Click;
            // 
            // prevMonth
            // 
            prevMonth.BackColor = Color.Transparent;
            prevMonth.FlatAppearance.BorderSize = 0;
            prevMonth.FlatStyle = FlatStyle.Flat;
            prevMonth.IconChar = FontAwesome.Sharp.IconChar.LeftLong;
            prevMonth.IconColor = SystemColors.ActiveCaption;
            prevMonth.IconFont = FontAwesome.Sharp.IconFont.Auto;
            prevMonth.IconSize = 40;
            prevMonth.Location = new Point(293, 32);
            prevMonth.Name = "prevMonth";
            prevMonth.Size = new Size(58, 32);
            prevMonth.TabIndex = 7;
            prevMonth.UseVisualStyleBackColor = false;
            prevMonth.Click += prevMonth_Click;
            // 
            // MonthLabel
            // 
            MonthLabel.AutoSize = true;
            MonthLabel.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MonthLabel.Location = new Point(35, 35);
            MonthLabel.Name = "MonthLabel";
            MonthLabel.Size = new Size(93, 29);
            MonthLabel.TabIndex = 6;
            MonthLabel.Text = "MONTH";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 155);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1169, 815);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // CalendarView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "CalendarView";
            Size = new Size(1169, 970);
            Load += CalendarView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton prevMonth;
        private Label MonthLabel;
        private FontAwesome.Sharp.IconButton nextMonth;
        private Label label7;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
