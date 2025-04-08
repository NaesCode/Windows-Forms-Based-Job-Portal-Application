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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;
using System.Globalization;

namespace Job_Application_Manager
{
    public partial class JobFullDetails : Form
    {
        private int companyPostID;
        private int companyID;
        private int HunterID;
        private DatabaseSupport dbSupport = new DatabaseSupport();
        private DateTime currentDate = DateTime.Now; //Used to check for deadlines

        public JobFullDetails(int postID, int hunterID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            companyPostID = postID;
            HunterID = hunterID;
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

        private void JobFullDetails_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1095, 659); //or 700
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

        }

        private void exitButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maximButton1_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void minimButton1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Minimized;
            else if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
        }

        public void LoadJobDetails(byte[]? logo)
        {
            try
            {
                // load job details
                Dictionary<string, object?>? jobDetails = dbSupport.GetFullJobDetails(companyPostID);

                if (jobDetails != null)
                {
                    companyID = Convert.ToInt32(jobDetails["CompanyUserID"]); //will be used for company details
                    jobTitleLabel.Text = jobDetails["JobTitle"]?.ToString();
                    companyNameLabel.Text = jobDetails["CompanyName"]?.ToString();
                    jobLocationLabel.Text = jobDetails["Location"]?.ToString();
                    jobTypeLabel.Text = jobDetails["JobType"]?.ToString();
                    jobCategory.Text = jobDetails["Category"]?.ToString();
                    industryOverview.Text = jobDetails["Industry"]?.ToString();
                    workMode.Text = jobDetails["Work Mode"]?.ToString();
                    initialSalaryLabel.Text = jobDetails["StartingSalary"]?.ToString() + " / month";
                    vacancyLabel.Text = jobDetails["Vacancy"]?.ToString() + " Available Post.";
                    applDeadline.Text = jobDetails["Application Deadline"]?.ToString();
                    jobDescription.Text = jobDetails["Job Description"]?.ToString();
                    jobApplicationDetails.Text = jobDetails["ApplicationDetails"]?.ToString();
                    if (logo != null)
                    {
                        using (MemoryStream ms = new MemoryStream(logo))
                        {
                            companyLogo.Image = Image.FromStream(ms);
                        }
                    }
                    MessageBox.Show($"{applDeadline.Text} \n {currentDate}");
                }
                else
                {
                    throw new Exception("No job data found");
                }

                // load company details
                Dictionary<string, object?> companyDetails = dbSupport.GetGeneralCompanyDetails(companyID);

                if (companyDetails != null)
                {
                    companyName.Text = companyDetails["Company Name"]?.ToString();
                    companyAddress.Text = companyDetails["Company Address"]?.ToString();
                    string[]? linkParts = companyDetails["Company Website"]?.ToString()?.Split("#");
                    companyWeb.Text = (linkParts != null && linkParts.Length > 0) ? linkParts[1] : "";
                    companyEmail.Text = companyDetails["CompanyLog-In_Email"]?.ToString();
                }
                else
                {
                    throw new Exception("No company data found");
                }

                string? format = "M/d/yyyy h:mm:ss tt";
                if (DateTime.TryParseExact(applDeadline.Text, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime closing))
                {
                    if(currentDate >= closing) //application deadline is met.
                    {
                        ApplyNowBttn.Enabled = false;
                        ApplyNowBttn.Text = "Position Closed";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void ApplyNowBttn_Click(object sender, EventArgs e)
        {
            string applicationStatus = "FOR REVIEW";
            DateTime DateApplied = DateTime.Now.Date;
            dbSupport.ApplyForAJob(companyPostID, HunterID, DateApplied, applicationStatus);
            MessageBox.Show("Application sent successfully.");
            ApplyNowBttn.Text = "Applied";
            ApplyNowBttn.Enabled = false;
        }
    }
}
