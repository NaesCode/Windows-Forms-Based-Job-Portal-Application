using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Manager
{
    public partial class JobPostPanel : BaseControl
    {
        private int JobPostID;
        public JobPostPanel(int postID, string? companyName, string? jobTitle, string? jobType, string? location, string? workMode, string? salary, int? vacancy, byte[]? companyLogo, int hunterID)
        {
            InitializeComponent();
            JobPostID = postID;
            HunterID = hunterID;
            companyNameLabel.Text = companyName;
            jobTitleBttn.Text = jobTitle;
            jobTypeLabel.Text = "( " + jobType + " )";
            jobLocationLabel.Text = location;
            workModeLabel.Text = "( " + workMode + " )";
            initialSalaryLabel.Text = salary + ".00 / Month";
            vacancyLabel.Text = vacancy.ToString() + " Available Pos.";
            imageData = companyLogo;
            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    companyLogoPic.Image = Image.FromStream(ms);
                }
            }
        }

        private void jobTitleBttn_Click(object sender, EventArgs e)
        {
            JobFullDetails jobDetails = new JobFullDetails(JobPostID, HunterID);
            jobDetails.LoadJobDetails(imageData);
            jobDetails.ShowDialog();
        }
    }
}
