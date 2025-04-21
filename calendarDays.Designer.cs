namespace Job_Application_Manager
{
    partial class calendarDays
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
            deleteNote = new FontAwesome.Sharp.IconButton();
            checkBox1 = new CheckBox();
            Day = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(deleteNote);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(Day);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(145, 127);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            panel1.DoubleClick += panel1_DoubleClick;
            // 
            // deleteNote
            // 
            deleteNote.BackColor = SystemColors.ButtonHighlight;
            deleteNote.FlatAppearance.BorderSize = 0;
            deleteNote.FlatAppearance.MouseOverBackColor = SystemColors.WindowFrame;
            deleteNote.FlatStyle = FlatStyle.Flat;
            deleteNote.IconChar = FontAwesome.Sharp.IconChar.Trash;
            deleteNote.IconColor = Color.Black;
            deleteNote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteNote.IconSize = 20;
            deleteNote.Location = new Point(11, 90);
            deleteNote.Name = "deleteNote";
            deleteNote.Size = new Size(27, 23);
            deleteNote.TabIndex = 2;
            deleteNote.UseVisualStyleBackColor = false;
            deleteNote.Visible = false;
            deleteNote.Click += deleteNote_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(17, 19);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 1;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Day
            // 
            Day.AutoSize = true;
            Day.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Day.Location = new Point(97, 19);
            Day.Name = "Day";
            Day.Size = new Size(36, 25);
            Day.TabIndex = 0;
            Day.Text = "00";
            // 
            // calendarDays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "calendarDays";
            Padding = new Padding(5);
            Size = new Size(155, 137);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Day;
        private CheckBox checkBox1;
        private FontAwesome.Sharp.IconButton deleteNote;
    }
}
