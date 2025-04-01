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
    public partial class JobPostPreviewPanel : UserControl
    {
        public JobPostPreviewPanel(string? companyName, string? jobTitle, string? jobType, string? location, string? workMode, string? salary, int? vacancy, byte[]? logo)
        {
            InitializeComponent();

            companyNameLabel.Text = companyName;
            jobTitleLabel.Text = jobTitle;
            jobTypeLabel.Text = "( " + jobType + " )";
            jobLocationLabel.Text = location;
            workModeLabel.Text = "( " + workMode + " )";
            initialSalaryLabel.Text = salary + ".00 / Month";
            vacancyLabel.Text = vacancy.ToString() + " Available Pos.";
            if (logo != null)
            {
                using (MemoryStream ms = new MemoryStream(logo))
                {
                    companyLogoPic.Image = Image.FromStream(ms);
                }
            }
        }

        private void JobPostPreviewPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
