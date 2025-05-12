using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.OleDb;
using System.Net.Mime;

namespace Job_Application_Manager
{
    public partial class codeVerifyHunter : Form
    {
        private DatabaseSupport dbSupport = new DatabaseSupport();

        private changePassHunter? changePasswordInstance;
        private string? randomCode;
        private bool codeSent;
        private Dictionary<string, object?>? AdminEmailData;

        public codeVerifyHunter()
        {
            InitializeComponent();
        }

        private void codeVerify_Load(object sender, EventArgs e)
        {
            sentCode.Enabled = false;
            verifyCode.Enabled = false;
            AdminEmailData = dbSupport.GetAdminEmailData(1);
        }

        private void sendVerifEmail_Click(object sender, EventArgs e)
        {
            string email = ToEmail.Text;


            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email address!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dbSupport.isValidHunterEmail(email) == false)
            {
                MessageBox.Show("Please enter a valid email address!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //this is to check if the email is in the database or not
            string? username = dbSupport.GetHunterNameByEmail(email);
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("No account found with this email!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //this is to check if the admin email is in the database or not
            string? senderEmail = AdminEmailData?["AdminEmail"]?.ToString();
            string? password = AdminEmailData?["GmailAppPassword"]?.ToString();
            if (string.IsNullOrEmpty(senderEmail) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("App Administrator not found!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            Random rand = new Random();
            randomCode = rand.Next(100000, 999999).ToString();
            DateTime expiryTime = DateTime.Now.AddMinutes(5);

            // Create a new MailMessage object
            using (MailMessage message = new MailMessage())
            {
                message.To.Add(email);
                message.From = new MailAddress(senderEmail); 
                message.Subject = "Password Reset Request";
                message.Subject = "🔐 Job-Hunt: Job Application Manager - Your Password Reset Code!";

                message.IsBodyHtml = true; // HTML content

                string htmlBody = $@"
                <html>
                    <body style='font-family: Arial, sans-serif; background-color: #f9f9f9; padding: 20px; color: #333;'>
                        <div style='max-width: 600px; margin: auto; background-color: #ffffff; padding: 20px; border-radius: 10px; box-shadow: 0 2px 5px rgba(0,0,0,0.1);'>
      
                        <h2 style='color: #0d3b8d; text-align: center;'>Password Reset Request</h2>

                        <p>Hello <strong>{username}</strong>,</p>
      
                        <p>We received a request to reset your password for your <strong>Job-Hunt App </strong> local account.</p>

                        <p style='margin: 20px 0;'>Please use the verification code below to reset your password:</p>

                        <div style='font-size: 28px; font-weight: bold; background-color: #f1f1f1; color: #333; padding: 15px 25px; border-radius: 8px; text-align: center; letter-spacing: 3px;'>
                        {randomCode}
                        </div>

                        <p style='margin-top: 20px;'>This code will expire after <strong>5 minutes</strong> at {expiryTime.ToString("hh:mm tt")}.</p>

                        <p>If you did not request a password reset, you can safely ignore this email.</p>

                        <hr style='margin: 30px 0; border: none; border-top: 1px solid #eee;'>

                        <p style='font-size: 12px; color: #888; text-align: center;'>
                            © {DateTime.Now.Year} Job-Hunt App. All rights reserved.<br>
                            Need help? Contact us at <a href='mailto:seanrichard.tadiamon@cit.edu'>seanrichard.tadiamon@cit.edu</a>
                        </p>
                        </div>
                    </body>
                </html>";

                //alternate view for HTML
                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(htmlBody, null, MediaTypeNames.Text.Html);

                message.Body = htmlBody;
                message.AlternateViews.Add(htmlView);

                // Configure SMTP client
                using (SmtpClient client = new SmtpClient("smtp.gmail.com"))
                {
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;

                    // Use App Password instead of real password
                    client.Credentials = new NetworkCredential(senderEmail, password);

                    try
                    {
                        client.Send(message);
                        MessageBox.Show("Verification code sent successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        codeSent = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error sending email: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        codeSent = false;
                    }
                    finally
                    {
                        if (codeSent)
                        {
                            sentCode.Enabled = true;
                            verifyCode.Enabled = true;
                        }
                    }
                }
            }
        }

        private void verifyCode_Click(object sender, EventArgs e)
        {
            if (sentCode.Text == randomCode)
            {
                if (changePasswordInstance == null || changePasswordInstance.IsDisposed)
                {
                    changePasswordInstance = new changePassHunter(ToEmail.Text);
                    changePasswordInstance.Show();
                    this.Hide();
                }
                else
                {
                    changePasswordInstance.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Error wrong code: " + "Your code did not match to the code we sent.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void siticoneCloseButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm loginForm = new LogInForm();
            loginForm.Show();
        }
    }
}
