using System.Data.OleDb;
using System.Data;
using Microsoft.VisualBasic.Logging;

namespace Job_Application_Manager
{
    public partial class LogInForm : Form
    {
        private DatabaseSupport dbSupport = new DatabaseSupport();

        private AccountTypeReg? accountTypeFormInstance;
        private JobHunterDashB? jobHunterDashBForm;
        private CompanyDashB? companyDashBForm;
        private AdminDashB? adminDashBForm;
        private codeVerify? codeVerifyInstance;
        private codeVerifyCompany? codeVerifyCompanyInstance;

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

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LogInButton_Click(sender, e);
            }
        }

        private void Checkbox_CheckedChanged(object? sender, EventArgs e)
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

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = UserPassword.Text;
            string companyEmail = UserName.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all required fields correctly.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            this.Hide();
                            jobHunterDashBForm = new JobHunterDashB(hunterID);
                            jobHunterDashBForm.Show();
                            jobHunterDashBForm.BringToFront();
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
                    valid = dbSupport.AuthenticateCompany(companyEmail, password);
                    companyID = dbSupport.getCompanyID(companyEmail);
                    if (valid)
                    { 
                        if (companyDashBForm == null || companyDashBForm.IsDisposed)
                        {
                            this.Hide();
                            companyDashBForm = new CompanyDashB(companyID);
                            companyDashBForm.Show();
                            companyDashBForm.BringToFront();
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
                    if (valid)
                    {
                        if (adminDashBForm == null || adminDashBForm.IsDisposed)
                        {
                            this.Hide();
                            adminDashBForm = new AdminDashB();
                            adminDashBForm.Show();
                            adminDashBForm.WindowState = FormWindowState.Normal; //new
                            adminDashBForm.Activate(); //new
                            adminDashBForm.BringToFront();
                            adminDashBForm.Focus(); //new
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
            if (JobHunterCheckbox.Checked == true)
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
            else if (CompanyCheckbox.Checked == true)
            {
                if (codeVerifyCompanyInstance == null || codeVerifyCompanyInstance.IsDisposed)
                {
                    codeVerifyCompanyInstance = new codeVerifyCompany();
                    codeVerifyCompanyInstance.Show();
                    this.Hide();
                }
                else
                {
                    codeVerifyCompanyInstance.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Please specify first what type of user are you.");
                return;
            }
        }
    }
}
