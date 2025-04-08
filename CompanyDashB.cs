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
    public partial class CompanyDashB : Form
    {
        private Control? currentDisplayedForm = null;

        private BaseControl? currentChildForm;
        private int companyUserID;

        ValidateCompanyForm? validateCompanyForm;
        JobListing? jobListingForm;
        ChartView? chartViewForm;


        private DatabaseSupport dbSupport = new DatabaseSupport();

        public CompanyDashB(int companyID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            companyUserID = companyID;
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

        private async void CompanyDashB_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1095, 659); //or 700
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

            string? approvalStatus = dbSupport.GetApprovalStatus(companyUserID);

            if(approvalStatus == "APPROVED")
            {
                AddJobBttn.Enabled = true;
            }
            else
            {
                validateCompanyForm = new ValidateCompanyForm(companyUserID);

                await Task.Delay(1000);

                validateCompanyForm.Opacity = 0;
                // Disable the main form to simulate modal behavior
                this.Enabled = false;

                // Start the form and animate it
                validateCompanyForm.Show();

                System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();
                fadeTimer.Interval = 50; // Adjust for smoother animation
                fadeTimer.Tick += (s, ev) =>
                {
                    if (validateCompanyForm.Opacity < 1)
                    {
                        validateCompanyForm.Opacity += 0.05; // Smooth fade
                    }
                    else
                    {
                        fadeTimer.Stop();
                    }
                };
                fadeTimer.Start();

                // Wait for the form to close using FormClosed event
                validateCompanyForm.FormClosed += (s, ev) =>
                {
                    this.Enabled = true; // Re-enable main form
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

        private void AdjustJobApplicantsViewPanel_Size(int width, int height)
        {
            foreach (Control control in desktopPanel.Controls)
            {
                // Check if it's a Job_Hunt and contains a FlowLayoutPanel
                if (control is JobApplicants jobApplicantControl)
                {
                    foreach (Control innerControl in jobApplicantControl.Controls)
                    {
                        if (innerControl is FlowLayoutPanel flowLayoutPanel)
                        {
                            // Iterate through JobPostPanel inside the FlowLayoutPanel
                            foreach (Control panelControl in flowLayoutPanel.Controls)
                            {
                                if (panelControl is ViewApplicants jobApplicants)
                                {
                                    jobApplicants.Size = new Size(width, height);
                                }
                            }
                        }
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
            {
                AdjustJobApplicantsViewPanel_Size(1157, 120);
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                AdjustJobApplicantsViewPanel_Size(884, 120);
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(1095, 659);
            }
        }

        private void minimButton1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Minimized;
            else if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
        }

        private void AddJobBttn_Click(object sender, EventArgs e)
        {
            if (jobListingForm == null || jobListingForm.IsDisposed)
                jobListingForm = new JobListing(companyUserID);

            if (currentDisplayedForm == jobListingForm)
                return;

            desktopPanel.Controls.Clear();

            jobListingForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(jobListingForm);
            currentDisplayedForm = jobListingForm;
            desktopPanel.AutoScroll = true;
        }

        private void jobPostingsBttn_Click(object sender, EventArgs e)
        {
            if (currentDisplayedForm is JobPostings)
                return;

            desktopPanel.Controls.Clear();

            currentChildForm = new JobPostings(companyUserID);
            currentChildForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(currentChildForm);
            currentChildForm.DisplayDetails();

            currentDisplayedForm = currentChildForm;
            desktopPanel.AutoScroll = true;
        }

        private void ChartViewBttn_Click(object sender, EventArgs e)
        {
            if (currentDisplayedForm == chartViewForm)
                return;

            desktopPanel.Controls.Clear();

            if (chartViewForm == null || chartViewForm.IsDisposed)
                chartViewForm = new ChartView();

            chartViewForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(chartViewForm);
            currentDisplayedForm = currentChildForm;
            desktopPanel.AutoScroll = true;
        }

        private void JobApplicantsBttn_Click(object sender, EventArgs e)
        {
            if (currentDisplayedForm is JobApplicants)
                return;

            desktopPanel.Controls.Clear();

            currentChildForm = new JobApplicants(companyUserID);
            currentChildForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(currentChildForm);
            currentChildForm.DisplayDetails();
            if (this.WindowState == FormWindowState.Maximized)
                AdjustJobApplicantsViewPanel_Size(1157, 120);
            currentDisplayedForm = currentChildForm;
            desktopPanel.AutoScroll = true;
        }

        private void CalendarViewBttn_Click(object sender, EventArgs e)
        {
            if (currentDisplayedForm is CalendarView)
                return;

            desktopPanel.Controls.Clear();

            currentChildForm = new CalendarView();
            currentChildForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(currentChildForm);
            currentDisplayedForm = currentChildForm;
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
