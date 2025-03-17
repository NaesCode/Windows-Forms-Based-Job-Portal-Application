using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Job_Application_Manager
{
    public partial class mainApp : Form
    {
        private UserControl? currentChildForm;
        public mainApp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;

        }

        // Windows API to enable snapping
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        // Windows API functions to allow dragging
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void controlBarPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void mainApp_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1095, 659); //or 700
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        }

        private void MenuBttn_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.menuBarPanel0.Width > 200)
            {
                menuBarPanel0.Width = 100;
                Logo1.Visible = false;
                brandName.Visible = false;
                MenuBttn.Location = new Point(27, 20);
                foreach (Button menuButton in menuBarPanel1.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                menuBarPanel0.Width = 202;
                Logo1.Visible = true;
                brandName.Visible = true;
                MenuBttn.Dock = DockStyle.None;
                MenuBttn.Location = new Point(135, 20);
                foreach (Button menuButton in menuBarPanel1.Controls.OfType<Button>())
                {
                    menuButton.Text = "     " + menuButton.Tag?.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.TextAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(15);
                }
                signOutBttn.Padding = new Padding(15, 0, 0, 5);
            }
        }

        private void exitButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximButton1_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void minimButton2_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Minimized;
            else if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
        }

        private void TableViewBttn_Click(object sender, EventArgs e)
        {
            desktopPanel.Controls.Clear();
            currentChildForm = new TableView();
            currentChildForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(currentChildForm);
            desktopPanel.Tag = currentChildForm;
            desktopPanel.AutoScroll = true;
        }

        private void BoardViewBttn_Click(object sender, EventArgs e)
        {
            desktopPanel.Controls.Clear();
            currentChildForm = new BoardView();
            currentChildForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(currentChildForm);
            desktopPanel.Tag = currentChildForm;
            desktopPanel.AutoScroll = true;
        }

        private void ChartViewBttn_Click(object sender, EventArgs e)
        {
            desktopPanel.Controls.Clear();
            currentChildForm = new ChartView();
            currentChildForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(currentChildForm);
            desktopPanel.Tag = currentChildForm;
            desktopPanel.AutoScroll = true;
        }

        private void ListViewBttn_Click(object sender, EventArgs e)
        {
            desktopPanel.Controls.Clear();
            currentChildForm = new ListView();
            currentChildForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(currentChildForm);
            desktopPanel.Tag = currentChildForm;
            desktopPanel.AutoScroll = true;
        }

        private void CalendarViewBttn_Click(object sender, EventArgs e)
        {
            desktopPanel.Controls.Clear();
            currentChildForm = new CalendarView();
            currentChildForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(currentChildForm);
            desktopPanel.Tag = currentChildForm;
            desktopPanel.AutoScroll = true;
        }

        private void signOutBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm loginForm = new LogInForm();
            loginForm.Show();
        }
    }
}
