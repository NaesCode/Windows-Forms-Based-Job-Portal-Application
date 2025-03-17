namespace Job_Application_Manager
{
    partial class ListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListView));
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "    COMPANY 1 NAME     " }, 0, SystemColors.Desktop, SystemColors.Control, new Font("Bahnschrift", 20.25F));
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "    COMPANY 2 NAME    " }, 0, SystemColors.Desktop, SystemColors.Control, new Font("Bahnschrift", 20.25F));
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "    COMPANY 3 NAME    " }, 0, SystemColors.Desktop, SystemColors.Control, new Font("Bahnschrift", 20.25F));
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "    COMPANY 4 NAME    " }, 0, SystemColors.Desktop, Color.Empty, new Font("Bahnschrift", 20.25F));
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "    COMPANY 5 NAME    " }, 0, SystemColors.Desktop, Color.Empty, new Font("Bahnschrift", 20.25F));
            imageList1 = new ImageList(components);
            listView1 = new System.Windows.Forms.ListView();
            columnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "research.png");
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.Control;
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView1.Dock = DockStyle.Fill;
            listView1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.HoverSelection = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem5.UseItemStyleForSubItems = false;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5 });
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(891, 521);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 0;
            listView1.TileSize = new Size(1, 1);
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "";
            columnHeader1.Width = 450;
            // 
            // ListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listView1);
            Name = "ListView";
            Size = new Size(891, 521);
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private ColumnHeader columnHeader1;
    }
}
