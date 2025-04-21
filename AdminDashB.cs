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
using FontAwesome.Sharp;

namespace Job_Application_Manager
{
    public partial class AdminDashB : Form
    {
        private BaseControl? currentChildForm;
        private GeneralUserInformation? genCompanyInfoTable;

        private IconButton? currentBttn;
        private Dictionary<string, BaseControl> cachedChildForms = new();
        private DatabaseSupport dbSupport = new DatabaseSupport();

        public AdminDashB()
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

        private void adminDashB_Load(object sender, EventArgs e)
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
                    switch(menuButton.Name)
                    {
                        case "GeneralCompanyInfo":
                            menuButton.Text = menuButton.Tag?.ToString();
                            menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                            menuButton.TextAlign = ContentAlignment.MiddleCenter;
                            menuButton.Padding = new Padding(15, 0, 0, 0);
                            break;

                        case "UpdateCompanyRequests":
                            menuButton.Text = menuButton.Tag?.ToString();
                            menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                            menuButton.TextAlign = ContentAlignment.MiddleCenter;
                            menuButton.Padding = new Padding(15, 0, 0, 0);
                            break;

                        case "AllJobHuntersBttn":
                            menuButton.Text = menuButton.Tag?.ToString();
                            menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                            menuButton.TextAlign = ContentAlignment.MiddleCenter;
                            menuButton.Padding = new Padding(8, 0, 0, 0);
                            break;

                        case "AnalyticsBttn":
                            menuButton.Text = menuButton.Tag?.ToString();
                            menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                            menuButton.TextAlign = ContentAlignment.MiddleCenter;
                            menuButton.Padding = new Padding(1, 0, 0, 0);
                            break;

                        case "SignOutBttn":
                            menuButton.Text = menuButton.Tag?.ToString();
                            menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                            menuButton.TextAlign = ContentAlignment.MiddleCenter;
                            menuButton.Padding = new Padding(15, 0, 0, 5);
                            break;

                        default:
                            break;
                    }
                }
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

        private void minimButton1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Minimized;
            else if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
        }

        private void ActivateButton(object senderBttn)
        {
            if (currentBttn != senderBttn)
            {
                if (currentBttn != null)
                {
                    currentBttn.BackColor = SystemColors.Desktop;
                }
                currentBttn = (IconButton)senderBttn;
                currentBttn.BackColor = Color.IndianRed;
            }
        }

        private void GeneralCompanyInfo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            string key = "Manage Companies";

            if (currentChildForm != null)
            {
                desktopPanel.Controls.Remove(currentChildForm);
            }

            if (!cachedChildForms.ContainsKey(key))
            {
                currentChildForm = new GeneralUserInformation();
                currentChildForm.Dock = DockStyle.Fill;
                currentChildForm.LoadDataGrid();
                cachedChildForms[key] = currentChildForm;
            }

            currentChildForm = cachedChildForms[key];
            desktopPanel.Controls.Add(currentChildForm);
            desktopPanel.Tag = currentChildForm;
            desktopPanel.AutoScroll = true;
        }

        private void UpdateCompanyRequests_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            string key = "Update Requests";

            if (currentChildForm is UpdateRequests && currentChildForm == cachedChildForms[key])
                return;

            if (currentChildForm != null)
            {
                desktopPanel.Controls.Remove(currentChildForm);
            }

            if (!cachedChildForms.ContainsKey(key))
            {
                currentChildForm = new UpdateRequests();
                currentChildForm.Dock = DockStyle.Fill;
                currentChildForm.DisplayDetails();
                cachedChildForms[key] = currentChildForm;
            }

            currentChildForm = cachedChildForms[key];
            desktopPanel.Controls.Add(currentChildForm);
            currentChildForm.LoadDataGrid();
            desktopPanel.Tag = currentChildForm;
            desktopPanel.AutoScroll = true;
        }

        private void AllJobHuntersBttn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            string key = "All Job Hunters";
            bool isForJobHunters = true;

            if (currentChildForm != null)
            {
                desktopPanel.Controls.Remove(currentChildForm);
            }

            if (!cachedChildForms.ContainsKey(key))
            {
                currentChildForm = new GeneralUserInformation(isForJobHunters);
                currentChildForm.Dock = DockStyle.Fill;
                currentChildForm.DisplayDetails();
                cachedChildForms[key] = currentChildForm;
            }

            currentChildForm = cachedChildForms[key];
            desktopPanel.Controls.Add(currentChildForm);
            desktopPanel.Tag = currentChildForm;
            desktopPanel.AutoScroll = true;
        }

        private void AnalyticsBttn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            string key = "Analytics";

            if (currentChildForm is AdminAnalytics && currentChildForm == cachedChildForms[key])
                return;

            if (currentChildForm != null)
            {
                desktopPanel.Controls.Remove(currentChildForm);
            }

            if (!cachedChildForms.ContainsKey(key))
            {
                currentChildForm = new AdminAnalytics();
                currentChildForm.Dock = DockStyle.Fill;
                currentChildForm.DisplayDetails();
                cachedChildForms[key] = currentChildForm;
            }

            currentChildForm = cachedChildForms[key];
            desktopPanel.Controls.Add(currentChildForm);
            desktopPanel.Tag = currentChildForm;
            desktopPanel.AutoScroll = true;
        }

        private void SignOutBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm loginForm = new LogInForm();
            loginForm.Show();
        }

        
    }
}
