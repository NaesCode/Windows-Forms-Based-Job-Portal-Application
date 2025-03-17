using System.Data.OleDb;
using System.Data;

namespace Job_Application_Manager
{
    public partial class LogInForm : Form
    {
        DatabaseSupport dbSupport = new DatabaseSupport();

        private registerForm? registerFormInstance;
        private mainApp? mainAppFormInstance;
        private codeVerify? codeVerifyInstance;
        private bool valid;
        public LogInForm()
        {
            InitializeComponent();
        }
        private void guna2Button4_Click(object sender, EventArgs e) //can be removed
        {
            dbSupport.checkConnection();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (registerFormInstance == null || registerFormInstance.IsDisposed)
            {
                registerFormInstance = new registerForm();
                registerFormInstance.Show();
            }
            else
            {
                registerFormInstance.BringToFront();
            }
        }

        private void LogInButton_Click_1(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = UserPassword.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please input your username and password before logging in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                valid = dbSupport.AuthenticateUser(username, password);
                if (valid)
                {
                    //MessageBox.Show("You are logged in!", "Welcome to Job-Hunt!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (mainAppFormInstance == null || mainAppFormInstance.IsDisposed)
                    {
                        mainAppFormInstance = new mainApp();
                        mainAppFormInstance.Show();
                        this.Hide();
                    }
                    else
                    {
                        mainAppFormInstance.BringToFront();
                    }
                }
                else
                {
                    MessageBox.Show("Log-in Unsuccessful!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPassword_MouseUp(object sender, MouseEventArgs e)
        {
            UserPassword.UseSystemPasswordChar = true;
        }

        private void showPassword_MouseDown(object sender, MouseEventArgs e)
        {
            UserPassword.UseSystemPasswordChar = false;
        }

        private void forgotPassButton_Click(object sender, EventArgs e)
        {
            if (codeVerifyInstance == null || codeVerifyInstance.IsDisposed)
            {
                codeVerifyInstance = new codeVerify();
                codeVerifyInstance.Show();
                this.Hide();
            }
            else
            {
                codeVerifyInstance.BringToFront();
            }
        }
    }
}
