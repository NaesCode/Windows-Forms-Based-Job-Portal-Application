namespace Job_Application_Manager
{
    partial class TrackApplications
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            ApplicationsTable = new ReaLTaiizor.Controls.PoisonDataGridView();
            applicationOpt = new ContextMenuStrip(components);
            cancelApplicationToolStripMenuItem = new ToolStripMenuItem();
            deleteAppStripMenuItem = new ToolStripMenuItem();
            menuBarPanel2 = new Panel();
            menuBarPanel3 = new Panel();
            panel2 = new Panel();
            profilePicture = new ReaLTaiizor.Controls.ParrotPictureBox();
            searchBar = new ReaLTaiizor.Controls.DungeonTextBox();
            panel3 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ApplicationsTable).BeginInit();
            applicationOpt.SuspendLayout();
            menuBarPanel2.SuspendLayout();
            menuBarPanel3.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(ApplicationsTable);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 8, 0);
            panel1.Size = new Size(893, 549);
            panel1.TabIndex = 0;
            // 
            // ApplicationsTable
            // 
            ApplicationsTable.AllowUserToAddRows = false;
            ApplicationsTable.AllowUserToResizeRows = false;
            ApplicationsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ApplicationsTable.BackgroundColor = Color.FromArgb(255, 255, 255);
            ApplicationsTable.BorderStyle = BorderStyle.None;
            ApplicationsTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            ApplicationsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Desktop;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ApplicationsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ApplicationsTable.ColumnHeadersHeight = 35;
            ApplicationsTable.ContextMenuStrip = applicationOpt;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ApplicationsTable.DefaultCellStyle = dataGridViewCellStyle2;
            ApplicationsTable.Dock = DockStyle.Fill;
            ApplicationsTable.EnableHeadersVisualStyles = false;
            ApplicationsTable.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            ApplicationsTable.GridColor = Color.FromArgb(255, 255, 255);
            ApplicationsTable.Location = new Point(0, 0);
            ApplicationsTable.Name = "ApplicationsTable";
            ApplicationsTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ApplicationsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ApplicationsTable.RowHeadersVisible = false;
            ApplicationsTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            ApplicationsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ApplicationsTable.Size = new Size(885, 549);
            ApplicationsTable.TabIndex = 14;
            ApplicationsTable.CellClick += ApplicationsTable_CellClick;
            // 
            // applicationOpt
            // 
            applicationOpt.BackColor = SystemColors.ButtonHighlight;
            applicationOpt.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            applicationOpt.Items.AddRange(new ToolStripItem[] { cancelApplicationToolStripMenuItem, deleteAppStripMenuItem });
            applicationOpt.Name = "logoMenuOpt";
            applicationOpt.Size = new Size(180, 48);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            cancelApplicationToolStripMenuItem.Image = Properties.Resources.papercancel;
            cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            cancelApplicationToolStripMenuItem.Size = new Size(179, 22);
            cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            cancelApplicationToolStripMenuItem.Click += cancelApplicationToolStripMenuItem_Click;
            // 
            // deleteAppStripMenuItem
            // 
            deleteAppStripMenuItem.Image = Properties.Resources.delete;
            deleteAppStripMenuItem.Name = "deleteAppStripMenuItem";
            deleteAppStripMenuItem.Size = new Size(179, 22);
            deleteAppStripMenuItem.Text = "Delete Application";
            deleteAppStripMenuItem.Click += deleteAppStripMenuItem_Click;
            // 
            // menuBarPanel2
            // 
            menuBarPanel2.Controls.Add(menuBarPanel3);
            menuBarPanel2.Dock = DockStyle.Top;
            menuBarPanel2.Location = new Point(0, 0);
            menuBarPanel2.Name = "menuBarPanel2";
            menuBarPanel2.Padding = new Padding(0, 2, 0, 2);
            menuBarPanel2.Size = new Size(893, 55);
            menuBarPanel2.TabIndex = 10;
            // 
            // menuBarPanel3
            // 
            menuBarPanel3.BackColor = SystemColors.Desktop;
            menuBarPanel3.Controls.Add(panel2);
            menuBarPanel3.Controls.Add(panel3);
            menuBarPanel3.Dock = DockStyle.Fill;
            menuBarPanel3.Location = new Point(0, 2);
            menuBarPanel3.Name = "menuBarPanel3";
            menuBarPanel3.Size = new Size(893, 51);
            menuBarPanel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(profilePicture);
            panel2.Controls.Add(searchBar);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(588, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 51);
            panel2.TabIndex = 1;
            // 
            // profilePicture
            // 
            profilePicture.BackColor = Color.Transparent;
            profilePicture.BackgroundImageLayout = ImageLayout.Zoom;
            profilePicture.ColorLeft = Color.Transparent;
            profilePicture.ColorRight = Color.Transparent;
            profilePicture.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            profilePicture.FilterAlpha = 0;
            profilePicture.FilterEnabled = false;
            profilePicture.Image = Properties.Resources._482748566_677122558084783_2784408297271869644_n;
            profilePicture.ImeMode = ImeMode.NoControl;
            profilePicture.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            profilePicture.IsElipse = true;
            profilePicture.IsParallax = false;
            profilePicture.Location = new Point(250, 5);
            profilePicture.Name = "profilePicture";
            profilePicture.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            profilePicture.Size = new Size(40, 40);
            profilePicture.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            profilePicture.TabIndex = 5;
            profilePicture.Text = "parrotPictureBox1";
            profilePicture.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // searchBar
            // 
            searchBar.BackColor = Color.Transparent;
            searchBar.BorderColor = Color.FromArgb(180, 180, 180);
            searchBar.EdgeColor = Color.White;
            searchBar.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBar.ForeColor = Color.DimGray;
            searchBar.Location = new Point(25, 11);
            searchBar.MaxLength = 32767;
            searchBar.Multiline = false;
            searchBar.Name = "searchBar";
            searchBar.ReadOnly = false;
            searchBar.Size = new Size(208, 29);
            searchBar.TabIndex = 3;
            searchBar.Text = "  Type here to search...";
            searchBar.TextAlignment = HorizontalAlignment.Left;
            searchBar.UseSystemPasswordChar = false;
            searchBar.TextChanged += searchBar_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(iconPictureBox1);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(414, 51);
            panel3.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            iconPictureBox1.IconColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 39;
            iconPictureBox1.Location = new Point(15, 8);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(39, 42);
            iconPictureBox1.TabIndex = 4;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geoform", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(57, 13);
            label1.Name = "label1";
            label1.Size = new Size(291, 25);
            label1.TabIndex = 1;
            label1.Text = "MANAGE APPLICATIONS";
            // 
            // TrackApplications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(menuBarPanel2);
            Name = "TrackApplications";
            Size = new Size(893, 604);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ApplicationsTable).EndInit();
            applicationOpt.ResumeLayout(false);
            menuBarPanel2.ResumeLayout(false);
            menuBarPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.PoisonDataGridView ApplicationsTable;
        private Panel menuBarPanel2;
        private Panel menuBarPanel3;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private ReaLTaiizor.Controls.DungeonTextBox searchBar;
        private ContextMenuStrip applicationOpt;
        private ToolStripMenuItem deleteAppStripMenuItem;
        private ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private ReaLTaiizor.Controls.ParrotPictureBox profilePicture;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
