namespace Job_Application_Manager
{
    partial class GeneralUserInformation
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralUserInformation));
            panel1 = new Panel();
            RejectBttn = new Button();
            ApproveBttn = new Button();
            InfoTable = new ReaLTaiizor.Controls.PoisonDataGridView();
            panel2 = new Panel();
            menuBarPanel2 = new Panel();
            menuBarPanel3 = new Panel();
            panel3 = new Panel();
            searchBar2 = new ReaLTaiizor.Controls.DungeonTextBox();
            searchBar = new ReaLTaiizor.Controls.DungeonTextBox();
            siticonePictureBox1 = new SiticoneNetCoreUI.SiticonePictureBox();
            panel4 = new Panel();
            Header = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InfoTable).BeginInit();
            panel2.SuspendLayout();
            menuBarPanel2.SuspendLayout();
            menuBarPanel3.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(RejectBttn);
            panel1.Controls.Add(ApproveBttn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 486);
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 118);
            panel1.TabIndex = 1;
            // 
            // RejectBttn
            // 
            RejectBttn.BackColor = SystemColors.ButtonHighlight;
            RejectBttn.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 229, 148);
            RejectBttn.FlatStyle = FlatStyle.Flat;
            RejectBttn.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RejectBttn.Location = new Point(163, 37);
            RejectBttn.Name = "RejectBttn";
            RejectBttn.Size = new Size(107, 52);
            RejectBttn.TabIndex = 45;
            RejectBttn.Text = "Reject";
            RejectBttn.UseVisualStyleBackColor = false;
            RejectBttn.Click += RejectBttn_Click;
            // 
            // ApproveBttn
            // 
            ApproveBttn.BackColor = SystemColors.ButtonHighlight;
            ApproveBttn.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 229, 148);
            ApproveBttn.FlatStyle = FlatStyle.Flat;
            ApproveBttn.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApproveBttn.Location = new Point(49, 37);
            ApproveBttn.Name = "ApproveBttn";
            ApproveBttn.Size = new Size(83, 52);
            ApproveBttn.TabIndex = 44;
            ApproveBttn.Text = "Approve";
            ApproveBttn.UseVisualStyleBackColor = false;
            ApproveBttn.Click += ApproveBttn_Click;
            // 
            // InfoTable
            // 
            InfoTable.AllowUserToAddRows = false;
            InfoTable.AllowUserToResizeRows = false;
            InfoTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InfoTable.BackgroundColor = Color.FromArgb(255, 255, 255);
            InfoTable.BorderStyle = BorderStyle.None;
            InfoTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            InfoTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.IndianRed;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            InfoTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            InfoTable.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            InfoTable.DefaultCellStyle = dataGridViewCellStyle2;
            InfoTable.Dock = DockStyle.Fill;
            InfoTable.EnableHeadersVisualStyles = false;
            InfoTable.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            InfoTable.GridColor = Color.FromArgb(255, 255, 255);
            InfoTable.Location = new Point(0, 0);
            InfoTable.Name = "InfoTable";
            InfoTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            InfoTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            InfoTable.RowHeadersVisible = false;
            InfoTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            InfoTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            InfoTable.Size = new Size(883, 431);
            InfoTable.TabIndex = 2;
            InfoTable.CellClick += companyInfoTable_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(InfoTable);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 10, 0);
            panel2.Size = new Size(893, 431);
            panel2.TabIndex = 3;
            // 
            // menuBarPanel2
            // 
            menuBarPanel2.Controls.Add(menuBarPanel3);
            menuBarPanel2.Dock = DockStyle.Top;
            menuBarPanel2.Location = new Point(0, 0);
            menuBarPanel2.Name = "menuBarPanel2";
            menuBarPanel2.Padding = new Padding(0, 2, 0, 2);
            menuBarPanel2.Size = new Size(893, 55);
            menuBarPanel2.TabIndex = 11;
            // 
            // menuBarPanel3
            // 
            menuBarPanel3.BackColor = Color.IndianRed;
            menuBarPanel3.Controls.Add(panel3);
            menuBarPanel3.Controls.Add(panel4);
            menuBarPanel3.Dock = DockStyle.Fill;
            menuBarPanel3.Location = new Point(0, 2);
            menuBarPanel3.Name = "menuBarPanel3";
            menuBarPanel3.Size = new Size(893, 51);
            menuBarPanel3.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(searchBar2);
            panel3.Controls.Add(searchBar);
            panel3.Controls.Add(siticonePictureBox1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(357, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(536, 51);
            panel3.TabIndex = 1;
            // 
            // searchBar2
            // 
            searchBar2.BackColor = Color.Transparent;
            searchBar2.BorderColor = Color.FromArgb(180, 180, 180);
            searchBar2.EdgeColor = Color.White;
            searchBar2.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBar2.ForeColor = Color.DimGray;
            searchBar2.Location = new Point(23, 11);
            searchBar2.MaxLength = 32767;
            searchBar2.Multiline = false;
            searchBar2.Name = "searchBar2";
            searchBar2.ReadOnly = false;
            searchBar2.Size = new Size(208, 29);
            searchBar2.TabIndex = 6;
            searchBar2.Text = "  Type here to search...";
            searchBar2.TextAlignment = HorizontalAlignment.Left;
            searchBar2.UseSystemPasswordChar = false;
            searchBar2.Enter += searchBar2_Enter;
            searchBar2.Leave += searchBar2_Leave;
            // 
            // searchBar
            // 
            searchBar.BackColor = Color.Transparent;
            searchBar.BorderColor = Color.FromArgb(180, 180, 180);
            searchBar.EdgeColor = Color.White;
            searchBar.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBar.ForeColor = Color.DimGray;
            searchBar.Location = new Point(252, 11);
            searchBar.MaxLength = 32767;
            searchBar.Multiline = false;
            searchBar.Name = "searchBar";
            searchBar.ReadOnly = false;
            searchBar.Size = new Size(208, 29);
            searchBar.TabIndex = 5;
            searchBar.Text = "  Type here to search...";
            searchBar.TextAlignment = HorizontalAlignment.Left;
            searchBar.UseSystemPasswordChar = false;
            searchBar.TextChanged += searchBar_TextChanged;
            searchBar.Enter += searchBar_Enter;
            searchBar.Leave += searchBar_Leave;
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
            siticonePictureBox1.Location = new Point(478, 5);
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
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(Header);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(363, 51);
            panel4.TabIndex = 2;
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Geoform", 15.75F, FontStyle.Bold | FontStyle.Italic);
            Header.ForeColor = SystemColors.ButtonHighlight;
            Header.Location = new Point(15, 15);
            Header.Name = "Header";
            Header.Size = new Size(259, 25);
            Header.TabIndex = 1;
            Header.Text = "MANAGE COMPANIES";
            // 
            // GeneralUserInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panel2);
            Controls.Add(menuBarPanel2);
            Controls.Add(panel1);
            Name = "GeneralUserInformation";
            Size = new Size(893, 604);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InfoTable).EndInit();
            panel2.ResumeLayout(false);
            menuBarPanel2.ResumeLayout(false);
            menuBarPanel3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button RejectBttn;
        private Button ApproveBttn;
        private ReaLTaiizor.Controls.PoisonDataGridView InfoTable;
        private Panel panel2;
        private Panel menuBarPanel2;
        private Panel menuBarPanel3;
        private Panel panel3;
        private SiticoneNetCoreUI.SiticonePictureBox siticonePictureBox1;
        private Panel panel4;
        private Label Header;
        private ReaLTaiizor.Controls.DungeonTextBox searchBar;
        private ReaLTaiizor.Controls.DungeonTextBox searchBar2;
    }
}
