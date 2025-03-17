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
    public partial class changePass : Form
    {
        private LogInForm? logInFormInstance;
        string? UserEmail;
        DatabaseSupport dbSupport = new DatabaseSupport();
        public changePass()
        {
            InitializeComponent();
        }

        public changePass(string Email)
        {
            InitializeComponent();
            this.UserEmail = Email;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string confPass = ConfirmPass.Text;
            try
            {
                if (confPass.Equals(UserPassword.Text))
                {
                    if (UserPassword.Text.Length < 8)
                        throw new Exception("Password must be atleast 8 characters.Try again");

                    dbSupport.changePassword(UserPassword.Text, UserEmail);

                    MessageBox.Show("Password changed!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                    logInFormInstance = new LogInForm();
                    logInFormInstance.Show();
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
    }
}
