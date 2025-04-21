using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Manager
{
    public partial class JobPostPanel : BaseControl
    {
        private int JobPostID;
        private DateTime currentDate = DateTime.Now;

        public event Action<int, int, string>? SaveJobPostClicked;

        public JobPostPanel(int postID, string? closing, string? companyName, string? jobTitle, string? jobType, string? location, string? workMode, string? salary, int? vacancy, byte[]? companyLogo, int hunterID)
        {
            InitializeComponent();
            foreach (Label control in this.Controls.OfType<Label>())
            {
                control.Text = "";
            }

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

            string? format = "M/d/yyyy h:mm:ss tt";
            if (DateTime.TryParseExact(closing, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime closingDate))
            {
                if (currentDate >= closingDate || vacancy == 0) // application deadline is met or there are no more vacant positions.  
                {
                    closedPositionLabel.Visible = true;
                }
            }
        }

        private void jobTitleBttn_Click(object sender, EventArgs e)
        {
            JobFullDetails jobDetails = new JobFullDetails(JobPostID, HunterID);
            jobDetails.LoadJobDetails(imageData);
            jobDetails.ShowDialog();
        }

        private void saveJobBttn_Click(object sender, EventArgs e)
        {
            SaveJobPostClicked?.Invoke(JobPostID, HunterID, jobTitleBttn.Text);
        }
    }
}
