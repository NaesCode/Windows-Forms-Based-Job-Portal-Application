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
    public partial class ViewApplicants : BaseControl //d pani sure nga inheritance
    {
        public int JobPostID { get; private set; }
        private byte[]? companyLogo;

        public event Action<int>? ViewApplicantsClicked; //Defined an event that triggers when the job title button is clicked

        public ViewApplicants(int postID, string? companyName, string? jobTitle, string? jobType, string? location, string? workMode, string? salary, int? vacancy, byte[]? logo)
        {
            InitializeComponent();
            JobPostID = postID;
            companyNameLabel.Text = companyName;
            jobTitleBttn.Text = jobTitle;
            jobTypeLabel.Text = "( " + jobType + " )";
            jobLocationLabel.Text = location;
            workModeLabel.Text = "( " + workMode + " )";
            initialSalaryLabel.Text = salary + ".00 / Month";
            vacancyLabel.Text = vacancy.ToString() + " Available Pos.";
            companyLogo = logo;
            if (companyLogo != null)
            {
                using (MemoryStream ms = new MemoryStream(companyLogo))
                {
                    companyLogoPic.Image = Image.FromStream(ms);
                }
            }
        }

        private void jobTitleBttn_Click(object sender, EventArgs e)
        {
            ViewApplicantsClicked?.Invoke(JobPostID);
        }
    }
}
