using Microsoft.VisualBasic.ApplicationServices;
using ReaLTaiizor.Controls;
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
    public partial class ApplicantProfileView : Form
    {
        private DatabaseSupport dbSupport = new DatabaseSupport();
        public int HunterID { get; set; }
        public byte[]? imageData { get; set; }

        private Dictionary<string, object>? profileData;

        public ApplicantProfileView(int ID)
        {
            InitializeComponent();
            HunterID = ID;
        }

        private void JobHunterProfile_Load(object sender, EventArgs e)
        {
            // Fetch and display profile picture
            imageData = dbSupport.DisplayProfilePicture(HunterID);
            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    profilePic.Image = Image.FromStream(ms);
                }
            }

            // Fetch and display profile details
            profileData = dbSupport.GetProfileDetails(HunterID);
            if (profileData != null)
            {
                fullName.Text = profileData["Full Name"].ToString();
                gender.Text = profileData["Gender"].ToString();
                nationality.Text = profileData["Nationality"].ToString();
                degree.Text = profileData["Degree"].ToString();
                university.Text = profileData["University / Institution"].ToString();
                contactNumber.Text = profileData["Contact Number"].ToString();
                email.Text = profileData["Email"].ToString();
                birthdate.Text = profileData["Date of Birth"].ToString();
                address.Text = profileData["Address"].ToString();
                BioTextBox.Text = profileData["Bio"]?.ToString() ?? "Say more about yourself here...";
                BioTextBox.ForeColor = SystemColors.Desktop;
            }
        }
    }
}
