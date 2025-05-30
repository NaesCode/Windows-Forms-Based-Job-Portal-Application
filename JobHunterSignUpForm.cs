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

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string confPass = ConfirmPass.Text;
            try
            {
                if (confPass.Equals(UserPassword.Text))
                {
                    if (UserPassword.Text.Length < 8)
                        throw new Exception("Password must be atleast 8 characters.Try again");

                    if (GmailAppPass.Text.Length != 19) //includes whitespaces
                        throw new Exception("App password must be 16 characters. Try again");

                    dbSupport.registerJobHunterData(UserEmail.Text, UserName.Text, UserPassword.Text, GmailAppPass.Text);

                    MessageBox.Show("You are now registered!");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password didn't match. Try again.");
                    UserPassword.Clear();
                    ConfirmPass.Clear();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                GmailAppPass.Clear();
                return;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InstructionBttn_Click(object sender, EventArgs e)
        {
            HowToGetAppPass instructionForm = new HowToGetAppPass();
            instructionForm.ShowDialog();
        }
    }
}
