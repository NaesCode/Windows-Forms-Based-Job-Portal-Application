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
            foreach (Label control in this.Controls.OfType<Label>())
            {
                control.Text = "";
            }

            companyNameLabel.Text = companyName ?? "";
            jobTitleLabel.Text = (jobTitle?.Trim() ?? "");
            jobTypeLabel.Text = "( " + (jobType ?? "") + " )";
            jobLocationLabel.Text = location ?? "";
            workModeLabel.Text = "( " + (workMode ?? "") + " )";
            initialSalaryLabel.Text = (salary ?? "0") + ".00 / Month";
            vacancyLabel.Text = (vacancy?.ToString() ?? "0") + " Available Pos.";

            if (logo != null)
            {
                if (companyLogoPic.Image != null)
                {
                    companyLogoPic.Image.Dispose(); 
                }
                using (MemoryStream ms = new MemoryStream(logo))
                {
                    companyLogoPic.Image = Image.FromStream(ms);
                }
            }
        }
    }
}
