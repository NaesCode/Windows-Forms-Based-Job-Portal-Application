namespace Job_Application_Manager
{
    partial class ChartView
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
            tab1 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            ApplicationsOverTimeChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            tab2 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            JobPostAnalyticsChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            JobListingTabs = new ReaLTaiizor.Controls.HopeTabPage();
            panel1 = new Panel();
            menuBarPanel3 = new Panel();
            panel3 = new Panel();
            companyLogo2 = new ReaLTaiizor.Controls.ParrotPictureBox();
            panel4 = new Panel();
            label7 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            tab1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tab2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            JobListingTabs.SuspendLayout();
            panel1.SuspendLayout();
            menuBarPanel3.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tab1
            // 
            tab1.BackColor = Color.LightSlateGray;
            tab1.Controls.Add(tableLayoutPanel2);
            tab1.Location = new Point(0, 40);
            tab1.Name = "tab1";
            tab1.Padding = new Padding(3);
            tab1.Size = new Size(890, 564);
            tab1.TabIndex = 1;
            tab1.Text = "Over Time";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(ApplicationsOverTimeChart, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(884, 558);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // ApplicationsOverTimeChart
            // 
            ApplicationsOverTimeChart.BackColor = SystemColors.GradientInactiveCaption;
            ApplicationsOverTimeChart.Dock = DockStyle.Fill;
            ApplicationsOverTimeChart.Location = new Point(3, 3);
            ApplicationsOverTimeChart.MatchAxesScreenDataRatio = false;
            ApplicationsOverTimeChart.Name = "ApplicationsOverTimeChart";
            ApplicationsOverTimeChart.Size = new Size(878, 552);
            ApplicationsOverTimeChart.TabIndex = 1;
            // 
            // tab2
            // 
            tab2.BackColor = Color.LightSlateGray;
            tab2.Controls.Add(tableLayoutPanel1);
            tab2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tab2.Location = new Point(0, 40);
            tab2.Name = "tab2";
            tab2.Padding = new Padding(3);
            tab2.Size = new Size(890, 564);
            tab2.TabIndex = 0;
            tab2.Text = "Per Job Posts";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.3231735F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.67683F));
            tableLayoutPanel1.Controls.Add(JobPostAnalyticsChart, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(884, 558);
            tableLayoutPanel1.TabIndex = 102;
            // 
            // JobPostAnalyticsChart
            // 
            JobPostAnalyticsChart.BackColor = SystemColors.GradientInactiveCaption;
            JobPostAnalyticsChart.Dock = DockStyle.Fill;
            JobPostAnalyticsChart.Location = new Point(3, 3);
            JobPostAnalyticsChart.MatchAxesScreenDataRatio = false;
            JobPostAnalyticsChart.Name = "JobPostAnalyticsChart";
            JobPostAnalyticsChart.Size = new Size(878, 552);
            JobPostAnalyticsChart.TabIndex = 0;
            // 
            // JobListingTabs
            // 
            JobListingTabs.BaseColor = Color.FromArgb(44, 55, 66);
            JobListingTabs.Controls.Add(tab1);
            JobListingTabs.Controls.Add(tab2);
            JobListingTabs.Dock = DockStyle.Fill;
            JobListingTabs.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JobListingTabs.ForeColorA = Color.Silver;
            JobListingTabs.ForeColorB = Color.Gray;
            JobListingTabs.ForeColorC = Color.FromArgb(150, 255, 255, 255);
            JobListingTabs.ItemSize = new Size(120, 40);
            JobListingTabs.Location = new Point(0, 55);
            JobListingTabs.Name = "JobListingTabs";
            JobListingTabs.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            JobListingTabs.SelectedIndex = 0;
            JobListingTabs.Size = new Size(890, 604);
            JobListingTabs.SizeMode = TabSizeMode.Fixed;
            JobListingTabs.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            JobListingTabs.TabIndex = 107;
            JobListingTabs.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            JobListingTabs.ThemeColorA = Color.FromArgb(64, 158, 255);
            JobListingTabs.ThemeColorB = Color.FromArgb(150, 64, 158, 255);
            JobListingTabs.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // panel1
            // 
            panel1.Controls.Add(menuBarPanel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 2, 0, 2);
            panel1.Size = new Size(890, 55);
            panel1.TabIndex = 108;
            // 
            // menuBarPanel3
            // 
            menuBarPanel3.BackColor = SystemColors.Desktop;
            menuBarPanel3.Controls.Add(panel3);
            menuBarPanel3.Controls.Add(panel4);
            menuBarPanel3.Dock = DockStyle.Fill;
            menuBarPanel3.Location = new Point(0, 2);
            menuBarPanel3.Name = "menuBarPanel3";
            menuBarPanel3.Size = new Size(890, 51);
            menuBarPanel3.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(companyLogo2);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(575, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(315, 51);
            panel3.TabIndex = 1;
            // 
            // companyLogo2
            // 
            companyLogo2.BackColor = Color.Transparent;
            companyLogo2.BackgroundImageLayout = ImageLayout.Zoom;
            companyLogo2.ColorLeft = Color.Transparent;
            companyLogo2.ColorRight = Color.Transparent;
            companyLogo2.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            companyLogo2.FilterAlpha = 0;
            companyLogo2.FilterEnabled = false;
            companyLogo2.Image = Properties.Resources._482748566_677122558084783_2784408297271869644_n;
            companyLogo2.ImeMode = ImeMode.NoControl;
            companyLogo2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            companyLogo2.IsElipse = true;
            companyLogo2.IsParallax = false;
            companyLogo2.Location = new Point(255, 6);
            companyLogo2.Name = "companyLogo2";
            companyLogo2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            companyLogo2.Size = new Size(40, 40);
            companyLogo2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            companyLogo2.TabIndex = 4;
            companyLogo2.Text = "parrotPictureBox1";
            companyLogo2.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(iconPictureBox1);
            panel4.Controls.Add(label7);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(471, 51);
            panel4.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Geoform", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(70, 14);
            label7.Name = "label7";
            label7.Size = new Size(142, 25);
            label7.TabIndex = 1;
            label7.Text = "ANALYTICS";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            iconPictureBox1.IconColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(19, 8);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // ChartView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(JobListingTabs);
            Controls.Add(panel1);
            Name = "ChartView";
            Size = new Size(890, 659);
            tab1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tab2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            JobListingTabs.ResumeLayout(false);
            panel1.ResumeLayout(false);
            menuBarPanel3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tab1;
        private TableLayoutPanel tableLayoutPanel2;
        private TabPage tab2;
        private TableLayoutPanel tableLayoutPanel1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart JobPostAnalyticsChart;
        private ReaLTaiizor.Controls.HopeTabPage JobListingTabs;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart ApplicationsOverTimeChart;
        private Panel panel1;
        private Panel menuBarPanel3;
        private Panel panel3;
        private Panel panel4;
        private Label label7;
        private ReaLTaiizor.Controls.ParrotPictureBox companyLogo2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
