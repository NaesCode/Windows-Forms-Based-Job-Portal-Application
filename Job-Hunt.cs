using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Manager
{
    public partial class Job_Hunt : HunterBaseControl
    {   
        private DatabaseSupport dbSupport = new DatabaseSupport();

        public Job_Hunt(int ID)
        {
            InitializeComponent();
            HunterID = ID;
        }

        public override void DisplayDetails()
        {
            flowPostsPanel.Controls.Clear();
            List<JobPostPanel> jobPosts = dbSupport.GetJobPosts(HunterID);

            if (jobPosts.Count == 0)
            {
                MessageBox.Show("No data found.");
                return;
            }

            foreach (var jobPostPanel in jobPosts)
            {
                flowPostsPanel.Controls.Add(jobPostPanel);
            }
        }
    }
}
