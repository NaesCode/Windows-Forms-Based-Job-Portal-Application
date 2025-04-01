using System.Data.OleDb;
using System.Data;
using Microsoft.VisualBasic.Logging;

namespace Job_Application_Manager
{
    public partial class LogInForm : Form
    {
        DatabaseSupport dbSupport = new DatabaseSupport();

        private AccountTypeReg? accountTypeFormInstance;
        private JobHunterDashB? jobHunterDashBForm;
        private CompanyDashB? companyDashBForm;
        private AdminDashB adminDashBForm;
        private codeVerify? codeVerifyInstance;
        private bool valid;
        private int companyID;
        private int hunterID;
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            JobHunterCheckbox.CheckedChanged += Checkbox_CheckedChanged;
            CompanyCheckbox.CheckedChanged += Checkbox_CheckedChanged;
            AdminCheckBox.CheckedChanged += Checkbox_CheckedChanged;

            //Initial check
            Checkbox_CheckedChanged(sender, e);
        }

        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            bool anyChecked = CompanyCheckbox.Checked || JobHunterCheckbox.Checked || AdminCheckBox.Checked;
            UserName.Enabled = anyChecked;
            UserPassword.Enabled = anyChecked;
            forgotPassBttn.Enabled = anyChecked;
            LogInButton.Enabled = anyChecked;

            if(CompanyCheckbox.Checked == true)
            {
                textBox3.Text = "Company Email:";
                textBox3.Size = new Size(120, 20);
                UserName.Size = new Size(251, 23);
                UserName.Location = new Point(568, 244);
            }
            else
            {
                textBox3.Text = "Username:";
                UserName.Size = new Size(275, 23);
                UserName.Location = new Point(527, 244);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e) //can be removed
        {
            dbSupport.checkConnection();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (accountTypeFormInstance == null || accountTypeFormInstance.IsDisposed)
            {
                accountTypeFormInstance = new AccountTypeReg();
                accountTypeFormInstance.Show();
            }
            else
            {
                accountTypeFormInstance.BringToFront();
            }
        }

        private void LogInButton_Click_1(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = UserPassword.Text;
            string Cemail = UserName.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please input your username and password before logging in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (JobHunterCheckbox.Checked == true)
                {
                    valid = dbSupport.AuthenticateHunter(username, password);
                    hunterID = dbSupport.getHunterID(username);
                    if (valid)
                    {
                        if (jobHunterDashBForm == null || jobHunterDashBForm.IsDisposed)
                        {
                            jobHunterDashBForm = new JobHunterDashB(hunterID);
                            jobHunterDashBForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            jobHunterDashBForm.BringToFront();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Log -in Unsuccessful!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (CompanyCheckbox.Checked == true)
                {
                    valid = dbSupport.AuthenticateCompany(Cemail, password);
                    companyID = dbSupport.getCompanyID(Cemail);
                    if (valid)
                    {
                        //MessageBox.Show("You are logged in!", "Welcome to Job-Hunt!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (companyDashBForm == null || companyDashBForm.IsDisposed)
                        {
                            companyDashBForm = new CompanyDashB(companyID);
                            companyDashBForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            companyDashBForm.BringToFront();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Log-in Unsuccessful!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (AdminCheckBox.Checked == true)
                {
                    valid = dbSupport.AuthenticateAdmin(username, password);
                    //companyID = dbSupport.getCompanyID(Cemail);
                    if (valid)
                    {
                        //MessageBox.Show("You are logged in!", "Welcome to Job-Hunt!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (adminDashBForm == null || adminDashBForm.IsDisposed)
                        {
                            adminDashBForm = new AdminDashB();
                            adminDashBForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            adminDashBForm.BringToFront();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Log-in Unsuccessful!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void forgotPassBttn_Click(object sender, EventArgs e)
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
