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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Job_Application_Manager
{
    public partial class JobHunterSignUpForm : Form
    {
        DatabaseSupport dbSupport = new DatabaseSupport();
        public JobHunterSignUpForm()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            dbSupport.checkConnection();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string confPass = ConfirmPass.Text;
            try
            {
                if (confPass.Equals(UserPassword.Text))
                {
                    if (UserPassword.Text.Length < 8)
                        throw new Exception("Password must be atleast 8 characters.Try again");

                    dbSupport.registerJobHunterData(UserEmail.Text, UserName.Text, UserPassword.Text);

                    MessageBox.Show("You are now registered!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password didn't match. Try again.");
                    UserPassword.Clear();
                    ConfirmPass.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                UserPassword.Clear();
                ConfirmPass.Clear();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
