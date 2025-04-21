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
            MonthLabel = new Label();
            prevMonth = new FontAwesome.Sharp.IconButton();
            nextMonth = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel3 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            label4 = new Label();
            panel7 = new Panel();
            label7 = new Label();
            panel8 = new Panel();
            label5 = new Label();
            panel9 = new Panel();
            label6 = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.Controls.Add(panel5);
            flowLayoutPanel2.Controls.Add(panel6);
            flowLayoutPanel2.Controls.Add(panel7);
            flowLayoutPanel2.Controls.Add(panel8);
            flowLayoutPanel2.Controls.Add(panel9);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.Location = new Point(0, 91);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1169, 58);
            flowLayoutPanel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(161, 30);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(76, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 0;
            label1.Text = "Sunday";
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Location = new Point(170, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(161, 30);
            panel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 9);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 1;
            label2.Text = "Monday";
            // 
            // panel5
            // 
            panel5.Controls.Add(label3);
            panel5.Location = new Point(337, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(161, 30);
            panel5.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 9);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 2;
            label3.Text = "Tuesday";
            // 
            // panel6
            // 
            panel6.Controls.Add(label4);
            panel6.Location = new Point(504, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(161, 30);
            panel6.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 9);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 3;
            label4.Text = "Wednesday";
            // 
            // panel7
            // 
            panel7.Controls.Add(label7);
            panel7.Location = new Point(671, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(161, 30);
            panel7.TabIndex = 4;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(46, 9);
            label7.Name = "label7";
            label7.Size = new Size(76, 19);
            label7.TabIndex = 9;
            label7.Text = "Thursday";
            // 
            // panel8
            // 
            panel8.Controls.Add(label5);
            panel8.Location = new Point(838, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(161, 30);
            panel8.TabIndex = 5;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(62, 9);
            label5.Name = "label5";
            label5.Size = new Size(55, 19);
            label5.TabIndex = 4;
            label5.Text = "Friday";
            // 
            // panel9
            // 
            panel9.Controls.Add(label6);
            panel9.Location = new Point(1005, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(161, 30);
            panel9.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(50, 9);
            label6.Name = "label6";
            label6.Size = new Size(75, 19);
            label6.TabIndex = 5;
            label6.Text = "Saturday";
            // 
            // panel1
            // 
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Controls.Add(nextMonth);
            panel1.Controls.Add(prevMonth);
            panel1.Controls.Add(MonthLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1169, 149);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 155F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1175, 970);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 158);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1169, 809);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // CalendarView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(tableLayoutPanel1);
            Name = "CalendarView";
            Size = new Size(1175, 970);
            Load += CalendarView_Load;
            flowLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label MonthLabel;
        private FontAwesome.Sharp.IconButton prevMonth;
        private FontAwesome.Sharp.IconButton nextMonth;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Label label2;
        private Panel panel5;
        private Label label3;
        private Panel panel6;
        private Label label4;
        private Panel panel7;
        private Label label7;
        private Panel panel8;
        private Label label5;
        private Panel panel9;
        private Label label6;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
