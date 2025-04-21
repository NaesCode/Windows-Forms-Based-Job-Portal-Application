using Microsoft.VisualBasic.ApplicationServices;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Job_Application_Manager
{
    public partial class JobHunterEmailingForm : Form
    {
        private DatabaseSupport dbSupport = new DatabaseSupport();

        private readonly int HunterID;
        private readonly int CompanyID;

        private Dictionary<string, object?>? HunterEmailData;

        private string? recipientEmail;

        private List<string> attachmentPaths = new List<string>();

        public JobHunterEmailingForm(int companyID, int hunterID)
        {
            InitializeComponent();
            this.HunterID = hunterID;
            this.CompanyID = companyID;
        }

        private void JobHunterProfile_Load(object sender, EventArgs e)
        {
            HunterEmailData = dbSupport.GetHunterEmailData(HunterID);
            recipientEmail = dbSupport.GetCompanyEmail(CompanyID);
            CompanyEmail.Text = recipientEmail;
        }

        private void browseFileBttn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Title = "Select attachment(s)";
                openFileDialog.Filter = "All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in openFileDialog.FileNames)
                    {
                        attachmentPaths.Add(file);
                        AttachmentFiles.Items.Add(Path.GetFileName(file));
                    }
                }
            }
        }

        private void sendBttn_Click(object sender, EventArgs e)
        {
            string? SenderEmail = HunterEmailData?["HunterEmail"]?.ToString();
            string? AppPassword = HunterEmailData?["GmailAppPassword"]?.ToString();
            string? Subject = EmailSubject.Text;
            string? Body = EmailBody.Text;

            if (string.IsNullOrEmpty(SenderEmail) || string.IsNullOrEmpty(AppPassword))
            {
                MessageBox.Show("Please check your email settings.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(CompanyEmail.Text) || string.IsNullOrEmpty(EmailSubject.Text) || EmailBody.Text == "Type your email message here...")
            {
                MessageBox.Show("Please fill up all necessary information before sending email.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new MailMessage object
            using (MailMessage message = new MailMessage())
            {
                message.To.Add(CompanyEmail.Text);
                message.From = new MailAddress(SenderEmail); // Your Gmail address
                message.Subject = Subject;
                foreach (string filePath in attachmentPaths)
                {
                    if (File.Exists(filePath))
                    {
                        message.Attachments.Add(new Attachment(filePath));
                    }
                }

                message.IsBodyHtml = true; // HTML content

                string htmlBody = $@"
                <html>
                  <body style='font-family: Bahnschrift, sans-serif; font-size: 18px; color: #2e2e2e;'>
                    <div style='border: 1px solid #ccc; padding: 20px; border-radius: 10px; max-width: 1000px; margin: auto; background-color: #f9f9f9;'>
      
                      <p>{Body.Replace("\n", "<br/>")}</p>

                      <hr style='border: none; height: 1px; background-color: #ddd; margin: 20px 0;' />

                      <p style='text-align: center;'>
                        <a href='mailto:{SenderEmail}' style='
                          display: inline-block;
                          padding: 10px 20px;
                          background-color: #0066cc;
                          color: white;
                          text-decoration: none;
                          border-radius: 5px;
                          font-weight: bold;
                        '>Reply Now</a>
                      </p>

                      <p style='font-size: 10px; color: #888; text-align: center; margin-top: 40px;'>
                        You are receiving this email because you are a registered user of <strong>Job-Hunter Job Portal Application</strong>.
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
                    client.Credentials = new NetworkCredential(SenderEmail, AppPassword);

                    try
                    {
                        client.Send(message);
                        MessageBox.Show("Email sent successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error sending email: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void clearInputsBttn_Click(object sender, EventArgs e)
        {
            CompanyEmail.Text = "";
            EmailSubject.Text = "";
            EmailBody.Text = "Type your email message here...";
            attachmentPaths.Clear();
            AttachmentFiles.Items.Clear();
        }
    }
}
