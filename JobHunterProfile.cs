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
    public partial class JobHunterProfile : HunterBaseControl
    {
        private DatabaseSupport db = new DatabaseSupport();
        private SetUpProfileForm? setUpProfileForm;
        private byte[]? imageData;

        public JobHunterProfile(int ID)
        {
            InitializeComponent();
            HunterID = ID;
        }

        public override void DisplayDetails()
        {
            // Fetch and display profile picture
            imageData = db.DisplayProfilePicture(HunterID);
            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    profilePic.Image = Image.FromStream(ms);
                }
            }

            // Fetch and display profile details
            var profileData = db.GetProfileDetails(HunterID);
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
            }
        }

        private void setUpBttn_Click(object sender, EventArgs e)
        {
            setUpProfileForm = new SetUpProfileForm(HunterID);
            setUpProfileForm.ShowDialog();
            DisplayDetails();
        }
    }
}
