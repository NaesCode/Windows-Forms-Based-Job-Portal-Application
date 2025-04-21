namespace Job_Application_Manager
{
    partial class SetEventORNote
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetEventORNote));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            logoPanel = new Panel();
            Logo1 = new PictureBox();
            exitBttn = new FontAwesome.Sharp.IconButton();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            brandName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            EventOrNote = new ReaLTaiizor.Controls.MaterialRichTextBox();
            SetEvent = new FontAwesome.Sharp.IconButton();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo1).BeginInit();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // logoPanel
            // 
            logoPanel.BackColor = Color.Transparent;
            logoPanel.Controls.Add(brandName);
            logoPanel.Controls.Add(Logo1);
            logoPanel.Location = new Point(48, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(117, 82);
            logoPanel.TabIndex = 2;
            // 
            // Logo1
            // 
            Logo1.Image = (Image)resources.GetObject("Logo1.Image");
            Logo1.Location = new Point(22, 3);
            Logo1.Name = "Logo1";
            Logo1.Size = new Size(70, 86);
            Logo1.SizeMode = PictureBoxSizeMode.Zoom;
            Logo1.TabIndex = 11;
            Logo1.TabStop = false;
            // 
            // exitBttn
            // 
            exitBttn.BackColor = Color.Transparent;
            exitBttn.FlatAppearance.BorderSize = 0;
            exitBttn.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            exitBttn.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            exitBttn.FlatStyle = FlatStyle.Flat;
            exitBttn.ForeColor = SystemColors.ButtonHighlight;
            exitBttn.IconChar = FontAwesome.Sharp.IconChar.X;
            exitBttn.IconColor = SystemColors.ButtonHighlight;
            exitBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitBttn.IconSize = 25;
            exitBttn.Location = new Point(622, 0);
            exitBttn.Name = "exitBttn";
            exitBttn.Size = new Size(54, 34);
            exitBttn.TabIndex = 24;
            exitBttn.UseVisualStyleBackColor = false;
            exitBttn.Click += exitBttn_Click;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(SetEvent);
            guna2GradientPanel1.Controls.Add(EventOrNote);
            guna2GradientPanel1.Controls.Add(exitBttn);
            guna2GradientPanel1.Controls.Add(guna2HtmlLabel1);
            guna2GradientPanel1.Controls.Add(logoPanel);
            guna2GradientPanel1.CustomizableEdges = customizableEdges1;
            guna2GradientPanel1.FillColor = Color.Black;
            guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            guna2GradientPanel1.Location = new Point(-48, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientPanel1.Size = new Size(676, 627);
            guna2GradientPanel1.TabIndex = 0;
            // 
            // brandName
            // 
            brandName.AutoSize = false;
            brandName.BackColor = Color.Transparent;
            brandName.Font = new Font("Geoform", 11.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            brandName.ForeColor = SystemColors.HighlightText;
            brandName.Location = new Point(9, 37);
            brandName.Name = "brandName";
            brandName.Size = new Size(99, 17);
            brandName.TabIndex = 10;
            brandName.Text = "JOB-HUNT\r\n";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.AutoSize = false;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Geoform", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = SystemColors.HighlightText;
            guna2HtmlLabel1.Location = new Point(246, 37);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(250, 22);
            guna2HtmlLabel1.TabIndex = 11;
            guna2HtmlLabel1.Text = "SET EVENT OR NOTE:";
            // 
            // EventOrNote
            // 
            EventOrNote.BackColor = Color.FromArgb(255, 255, 255);
            EventOrNote.BorderStyle = BorderStyle.None;
            EventOrNote.Depth = 0;
            EventOrNote.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EventOrNote.ForeColor = Color.FromArgb(222, 0, 0, 0);
            EventOrNote.Hint = "";
            EventOrNote.Location = new Point(112, 88);
            EventOrNote.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            EventOrNote.Name = "EventOrNote";
            EventOrNote.Size = new Size(501, 95);
            EventOrNote.TabIndex = 25;
            EventOrNote.Text = "";
            // 
            // SetEvent
            // 
            SetEvent.BackColor = Color.Transparent;
            SetEvent.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            SetEvent.FlatStyle = FlatStyle.Flat;
            SetEvent.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SetEvent.ForeColor = SystemColors.ButtonHighlight;
            SetEvent.IconChar = FontAwesome.Sharp.IconChar.None;
            SetEvent.IconColor = Color.Black;
            SetEvent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SetEvent.Location = new Point(295, 206);
            SetEvent.Name = "SetEvent";
            SetEvent.Size = new Size(116, 45);
            SetEvent.TabIndex = 26;
            SetEvent.Text = "SET";
            SetEvent.UseVisualStyleBackColor = false;
            SetEvent.Click += SetEvent_Click;
            // 
            // SetEventORNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 277);
            Controls.Add(guna2GradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SetEventORNote";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "changePass";
            logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo1).EndInit();
            guna2GradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel logoPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel brandName;
        private PictureBox Logo1;
        private FontAwesome.Sharp.IconButton exitBttn;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private ReaLTaiizor.Controls.MaterialRichTextBox EventOrNote;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private FontAwesome.Sharp.IconButton SetEvent;
    }
}