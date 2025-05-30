namespace Job_Application_Manager
{
    partial class AdminAnalytics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAnalytics));
            imageList1 = new ImageList(components);
            menuBarPanel2 = new Panel();
            menuBarPanel3 = new Panel();
            panel2 = new Panel();
            siticonePictureBox1 = new SiticoneNetCoreUI.SiticonePictureBox();
            panel3 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            CompaniesOverHunters = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            panel1 = new Panel();
            NumOfUsersChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            menuBarPanel2.SuspendLayout();
            menuBarPanel3.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "research.png");
            // 
            // menuBarPanel2
            // 
            menuBarPanel2.Controls.Add(menuBarPanel3);
            menuBarPanel2.Dock = DockStyle.Top;
            menuBarPanel2.Location = new Point(0, 0);
            menuBarPanel2.Name = "menuBarPanel2";
            menuBarPanel2.Padding = new Padding(0, 2, 0, 2);
            menuBarPanel2.Size = new Size(891, 55);
            menuBarPanel2.TabIndex = 9;
            // 
            // menuBarPanel3
            // 
            menuBarPanel3.BackColor = Color.IndianRed;
            menuBarPanel3.Controls.Add(panel2);
            menuBarPanel3.Controls.Add(panel3);
            menuBarPanel3.Dock = DockStyle.Fill;
            menuBarPanel3.Location = new Point(0, 2);
            menuBarPanel3.Name = "menuBarPanel3";
            menuBarPanel3.Size = new Size(891, 51);
            menuBarPanel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(siticonePictureBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(586, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 51);
            panel2.TabIndex = 1;
            // 
            // siticonePictureBox1
            // 
            siticonePictureBox1.BackColor = Color.Transparent;
            siticonePictureBox1.BorderColor = Color.Black;
            siticonePictureBox1.BorderWidth = 1;
            siticonePictureBox1.Brightness = 1F;
            siticonePictureBox1.Contrast = 1F;
            siticonePictureBox1.CornerRadius = 15;
            siticonePictureBox1.DraggingSpeed = 3.15F;
            siticonePictureBox1.EnableAsyncLoading = false;
            siticonePictureBox1.EnableCaching = false;
            siticonePictureBox1.EnableDragDrop = false;
            siticonePictureBox1.EnableExtendedImageSources = false;
            siticonePictureBox1.EnableFilters = false;
            siticonePictureBox1.EnableFlipping = false;
            siticonePictureBox1.EnableGlow = false;
            siticonePictureBox1.EnableHighDpiSupport = false;
            siticonePictureBox1.EnableMouseInteraction = false;
            siticonePictureBox1.EnablePlaceholder = false;
            siticonePictureBox1.EnableRotation = false;
            siticonePictureBox1.EnableShadow = false;
            siticonePictureBox1.EnableSlideshow = false;
            siticonePictureBox1.FlipHorizontal = false;
            siticonePictureBox1.FlipVertical = false;
            siticonePictureBox1.Grayscale = false;
            siticonePictureBox1.Image = (Image)resources.GetObject("siticonePictureBox1.Image");
            siticonePictureBox1.ImageOpacity = 1F;
            siticonePictureBox1.Images = (List<Image>)resources.GetObject("siticonePictureBox1.Images");
            siticonePictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            siticonePictureBox1.IsCircular = true;
            siticonePictureBox1.Location = new Point(250, 5);
            siticonePictureBox1.MaintainAspectRatio = true;
            siticonePictureBox1.Name = "siticonePictureBox1";
            siticonePictureBox1.PlaceholderImage = null;
            siticonePictureBox1.RotationAngle = 0F;
            siticonePictureBox1.Saturation = 1F;
            siticonePictureBox1.ShowBorder = true;
            siticonePictureBox1.Size = new Size(40, 40);
            siticonePictureBox1.SizeMode = SiticoneNetCoreUI.SiticonePictureBoxSizeMode.StretchImage;
            siticonePictureBox1.TabIndex = 0;
            siticonePictureBox1.Text = "siticonePictureBox1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(555, 51);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geoform", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 1;
            label1.Text = "ANALYTICS";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(891, 466);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientInactiveCaption;
            panel4.Controls.Add(CompaniesOverHunters);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(448, 3);
            panel4.Name = "panel4";
            tableLayoutPanel1.SetRowSpan(panel4, 2);
            panel4.Size = new Size(440, 460);
            panel4.TabIndex = 1;
            // 
            // CompaniesOverHunters
            // 
            CompaniesOverHunters.Dock = DockStyle.Fill;
            CompaniesOverHunters.InitialRotation = 0D;
            CompaniesOverHunters.IsClockwise = true;
            CompaniesOverHunters.Location = new Point(0, 0);
            CompaniesOverHunters.MaxAngle = 360D;
            CompaniesOverHunters.MaxValue = double.NaN;
            CompaniesOverHunters.MinValue = 0D;
            CompaniesOverHunters.Name = "CompaniesOverHunters";
            CompaniesOverHunters.Size = new Size(440, 460);
            CompaniesOverHunters.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(NumOfUsersChart);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            tableLayoutPanel1.SetRowSpan(panel1, 2);
            panel1.Size = new Size(439, 460);
            panel1.TabIndex = 0;
            // 
            // NumOfUsersChart
            // 
            NumOfUsersChart.Dock = DockStyle.Fill;
            NumOfUsersChart.Location = new Point(0, 0);
            NumOfUsersChart.MatchAxesScreenDataRatio = false;
            NumOfUsersChart.Name = "NumOfUsersChart";
            NumOfUsersChart.Size = new Size(439, 460);
            NumOfUsersChart.TabIndex = 0;
            // 
            // AdminAnalytics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuBarPanel2);
            Name = "AdminAnalytics";
            Size = new Size(891, 521);
            menuBarPanel2.ResumeLayout(false);
            menuBarPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private Panel menuBarPanel2;
        private Panel menuBarPanel3;
        private Panel panel2;
        private SiticoneNetCoreUI.SiticonePictureBox siticonePictureBox1;
        private Panel panel3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart CompaniesOverHunters;
        private Panel panel4;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart NumOfUsersChart;
    }
}
