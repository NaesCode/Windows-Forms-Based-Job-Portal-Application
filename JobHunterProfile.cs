using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class JobHunterProfile : BaseControl
    {
        private SetUpProfileForm? setUpProfileForm;

        private Dictionary<string, object>? profileData;

        public JobHunterProfile(int ID)
        {
            InitializeComponent();
            HunterID = ID;
        }

        private async void JobHunterProfile_Load(object sender, EventArgs e)
        {
            bool isSetUp = await Task.Run(() => dbSupport.GetProfileSetUpStatus(HunterID));

            if (isSetUp == true)
                setUpBttn.Enabled = false;
            else
            {
                editBttn.Enabled = false;
                setUpBttn.Enabled = true;
            }
        }

        public override async void DisplayDetails()
        {
            (imageData, profileData) = await Task.Run(() =>
            {
                var pfp = dbSupport.DisplayProfilePicture(HunterID);
                var data = dbSupport.GetProfileDetails(HunterID);
                return(pfp, data);
            });

            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    profilePic.Image = Image.FromStream(ms);
                }
            }

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
            }
        }

        private void setUpBttn_Click(object sender, EventArgs e)
        {
            setUpProfileForm = new SetUpProfileForm(HunterID);
            setUpProfileForm.ShowDialog();
            DisplayDetails();
        }

        private void editBttn_Click(object sender, EventArgs e)
        {
            setUpProfileForm = new SetUpProfileForm(profileData, HunterID);
            setUpProfileForm.ShowDialog();
            DisplayDetails();
        }

        private void BioTextBox_Enter(object sender, EventArgs e)
        {
            if (BioTextBox.Text == "Say more about yourself here...")
            {
                BioTextBox.Text = "";
                BioTextBox.ForeColor = SystemColors.Desktop;
            }
        }

        private void BioTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BioTextBox.Text))
            {
                BioTextBox.Text = "Say more about yourself here...";
                BioTextBox.ForeColor = SystemColors.ControlDarkDark;
            }
        }

        private void BioTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (BioTextBox.Text == "Say more about yourself here...")
            {
                BioTextBox.Text = string.Empty;
            }

            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                e.SuppressKeyPress = true;
                string? profileBio = BioTextBox.Text.Trim();
                dbSupport.UpdateProfileBio(HunterID, profileBio);
            }
        }
    }
}
