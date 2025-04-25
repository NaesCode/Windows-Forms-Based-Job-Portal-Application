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
    public partial class JobHunterDashB : Form
    {
        private BaseControl? currentChildForm;
        private SetUpProfileForm? setUpProfileForm;

        private IconButton? currentBttn;
        private Dictionary<string, BaseControl> cachedChildForms = new ();
        private DatabaseSupport dbSupport = new DatabaseSupport();

        private int hunterID;

        public JobHunterDashB(int hunterID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.hunterID = hunterID;
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

        private async void JobHuntDashB_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1095, 659); //or 700
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

            bool? isSetUp = dbSupport.GetProfileSetUpStatus(hunterID);

            if(isSetUp == true)
            {
                ApplyJobBttn.Enabled = true;
            }
            else
            {
                setUpProfileForm = new SetUpProfileForm(hunterID);

                await Task.Delay(1000);

                setUpProfileForm.Opacity = 0;

                // Start the form and animate it
                setUpProfileForm.Show();

                System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();
                fadeTimer.Interval = 50; // Adjust for smoother animation
                fadeTimer.Tick += (s, ev) =>
                {
                    if (setUpProfileForm.Opacity < 1)
                    {
                        setUpProfileForm.Opacity += 0.05; // Smooth fade
                    }
                    else
                    {
                        fadeTimer.Stop();
                    }
                };
                fadeTimer.Start();

                // Wait for the form to close using FormClosed event
                setUpProfileForm.ProfileSetupCompleted += (s, ev) =>
                {
                    this.Enabled = true; // Re-enable main form
                    ApplyJobBttn.Enabled = true;
                };
            }

        }

        private void MenuBttn_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.menuBarPanel0.Width > 200)
            {
                if (this.WindowState == FormWindowState.Maximized)
                    adjustJobPostPanelSize(958, 117);
                else
                    adjustJobPostPanelSize(678, 117);
                if(currentChildForm is CalendarView)
                {
                    desktopPanel.BackgroundImage = null;
                    desktopPanel.BackColor = SystemColors.ButtonHighlight;
                }
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
                if (this.WindowState == FormWindowState.Maximized)
                    adjustJobPostPanelSize(858, 117);
                else
                    adjustJobPostPanelSize(578, 117);
                menuBarPanel0.Width = 202;
                Logo1.Visible = true;
                brandName.Visible = true;
                MenuBttn.Dock = DockStyle.None;
                MenuBttn.Location = new Point(135, 20);
                foreach (Button menuButton in menuBarPanel1.Controls.OfType<Button>())
                {
                    switch (menuButton.Name)
                    {
                        case "ProfileViewBttn":
                        case "ApplyJobBttn":
                        case "TableViewBttn":
                            menuButton.Padding = new Padding(15);
                            
                            break;

                        case "ChartViewBttn":
                        case "CalendarViewBttn":
                            menuButton.Padding = new Padding(22, 0, 0, 0);
                            break;

                        case "SignOutBttn":
                            menuButton.Padding = new Padding(15, 0, 0, 5);
                            break;

                        default:
                            break;
                    }
                    menuButton.Text = menuButton.Tag?.ToString();
                    menuButton.TextAlign = ContentAlignment.MiddleCenter;
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                }
            }
        }

        private void adjustJobPostPanelSize(int width, int height)
        {
            foreach (Control control in desktopPanel.Controls)
            {
                // Check if it's a Job_Hunt and contains a FlowLayoutPanel
                if (control is Job_Hunt jobHuntControl)
                {
                    foreach (Control innerControl in jobHuntControl.Controls)
                    {
                        if (innerControl is FlowLayoutPanel flowLayoutPanel)
                        {
                            // Iterate through JobPostPanel inside the FlowLayoutPanel
                            foreach (var panelControl in flowLayoutPanel.Controls)
                            {
                                if (panelControl is JobPostPanel jobPostPanel)
                                {
                                    jobPostPanel.Size = new Size(width, height);
                                }
                            }
                        }
                    }
                }
            }
        }
        private void exitButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximButton1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                if (this.menuBarPanel0.Width > 200)
                    adjustJobPostPanelSize(858, 117);
                else
                    adjustJobPostPanelSize(958, 117);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(1095, 659);
                if (this.menuBarPanel0.Width > 200)
                    adjustJobPostPanelSize(578, 117);
                else
                    adjustJobPostPanelSize(678, 117);
            }
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
                currentBttn.BackColor = Color.FromArgb(13, 59, 141);
            }
        }

        private void ProfileViewBttn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            string key = "JobHunterProfile";
            // If currentChildForm is already a JobHunterProfile and is added, do nothing
            if (currentChildForm is JobHunterProfile && currentChildForm == cachedChildForms[key])
                return;

            // Otherwise, create new profile form
            if (currentChildForm != null)
            {
                desktopPanel.Controls.Remove(currentChildForm);
            }

            if(!cachedChildForms.ContainsKey(key))
            {
                currentChildForm = new JobHunterProfile(hunterID);
                currentChildForm.Dock = DockStyle.Fill;
                currentChildForm.DisplayDetails();
                cachedChildForms[key] = currentChildForm;
            }

            currentChildForm = cachedChildForms[key];
            desktopPanel.Controls.Add(currentChildForm);
            desktopPanel.Tag = currentChildForm;
            desktopPanel.AutoScroll = true;
        }

        private void ApplyJobBttn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            string key = "ApplyJob";

            if (currentChildForm is Job_Hunt && currentChildForm == cachedChildForms[key])
                return;

            if (currentChildForm != null)
            {
                desktopPanel.Controls.Remove(currentChildForm);
            }

            if (!cachedChildForms.ContainsKey(key))
            {
                currentChildForm = new Job_Hunt(hunterID);
                currentChildForm.Dock = DockStyle.Fill;
                currentChildForm.DisplayDetails();
                cachedChildForms[key] = currentChildForm;
            }

            currentChildForm = cachedChildForms[key];
            desktopPanel.Controls.Add(currentChildForm);
            desktopPanel.Tag = currentChildForm;
            desktopPanel.AutoScroll = true;
        }

        private void TableViewBttn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            string key = "TrackApplications";

            if (currentChildForm is TrackApplications && currentChildForm == cachedChildForms[key])
                return;

            if (currentChildForm != null)
            {
                desktopPanel.Controls.Remove(currentChildForm);
            }

            if (!cachedChildForms.ContainsKey(key))
            {
                currentChildForm = new TrackApplications(hunterID);
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

        private void ChartViewBttn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            string key = "Analytics";

            if (currentChildForm is BoardView && currentChildForm == cachedChildForms[key])
                return;

            if (currentChildForm != null)
            {
                desktopPanel.Controls.Remove(currentChildForm);
            }

            if (!cachedChildForms.ContainsKey(key))
            {
                currentChildForm = new BoardView(hunterID);
                currentChildForm.Dock = DockStyle.Fill;
                currentChildForm.DisplayDetails();
                cachedChildForms[key] = currentChildForm;
            }

            currentChildForm = cachedChildForms[key];
            desktopPanel.Controls.Add(currentChildForm);
            currentChildForm.DisplayDetails();
            desktopPanel.Tag = currentChildForm;
            desktopPanel.AutoScroll = true;
        }

        private void CalendarViewBttn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            string key = "Personal Calendar";
            string userType = "Job Hunter";

            if (currentChildForm is CalendarView && currentChildForm == cachedChildForms[key])
                return;

            if (currentChildForm != null)
            {
                desktopPanel.Controls.Remove(currentChildForm);
            }

            if (!cachedChildForms.ContainsKey(key))
            {
                currentChildForm = new CalendarView(hunterID, userType);
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
