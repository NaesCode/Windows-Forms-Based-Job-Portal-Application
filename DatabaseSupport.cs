using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.ComponentModel.Design;
using TheArtOfDevHtmlRenderer.Adapters;
using Microsoft.VisualBasic;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Collections;
using static SkiaSharp.HarfBuzz.SKShaper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Windows.Documents;
using System.Runtime.ConstrainedExecution;
using static QRCoder.PayloadGenerator;

namespace Job_Application_Manager
{
    internal class DatabaseSupport
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\\Users\\titan\\OneDrive\\Documents\\C andC# files\\C programming\\C# Programming\\OOP 2\\Database\\JobApplicationManager_Database.accdb";

        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        internal void checkConnection() //can be removed
        {
            myConn = new OleDbConnection(connectionString);
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            myConn.Close();
        }

        internal void registerJobHunterData(string Email, string Username, string Password)
        {
            myConn = new OleDbConnection(connectionString);
            myConn.Open();

            string registerQuery = "INSERT INTO [JobHunter Accounts] (Email, Username, [Password]) values (?, ?, ?)";
            cmd = new OleDbCommand(registerQuery, myConn);
            cmd.Parameters.AddWithValue("?", Email);
            cmd.Parameters.AddWithValue("?", Username);
            cmd.Parameters.AddWithValue("?", Password);
            cmd.ExecuteNonQuery();
            myConn.Close();

            //cmd = new OleDbCommand("SELECT MAX(ID) FROM [JobHunter Accounts]", myConn); //Gets last inserted StudentID and uses it to the other tables
            //int userID = Convert.ToInt32(cmd.ExecuteScalar());
        }

        internal void registerCompanyData(string Email, string Username, string Password)
        {
            myConn = new OleDbConnection(connectionString);
            myConn.Open();

            string registerQuery = "INSERT INTO [CompanyAccounts] ([CompanyLog-In_Email], [CompanyName], [Password]) values (?, ?, ?)";
            cmd = new OleDbCommand(registerQuery, myConn);
            cmd.Parameters.AddWithValue("?", Email);
            cmd.Parameters.AddWithValue("?", Username);
            cmd.Parameters.AddWithValue("?", Password);
            cmd.ExecuteNonQuery();
            myConn.Close();

            //cmd = new OleDbCommand("SELECT MAX(ID) FROM [JobHunter Accounts]", myConn); //Gets last inserted StudentID and uses it to the other tables
            //int userID = Convert.ToInt32(cmd.ExecuteScalar());
        }

        internal bool AuthenticateHunter(string username, string password)
        {
            string query = "SELECT * FROM [Log-InHunter_Query] WHERE Username = ? AND [Password] = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                cmd.Parameters.AddWithValue("?", username);
                cmd.Parameters.AddWithValue("?", password);
                try
                {
                    myConn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    return reader.HasRows;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        internal bool AuthenticateCompany(string email, string password)
        {
            string query = "SELECT * FROM [Log-InCompany_Query] WHERE [CompanyLog-In_Email] = ? AND [Password] = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = email;
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = password;
                try
                {
                    myConn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    return reader.HasRows;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        internal bool AuthenticateAdmin(string username, string password)
        {
            string query = "SELECT * FROM [Log-InAdmin_Query] WHERE Username = ? AND [Password] = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                cmd.Parameters.AddWithValue("?", username);
                cmd.Parameters.AddWithValue("?", password);
                try
                {
                    myConn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    return reader.HasRows;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        internal int getCompanyID(string email)
        {
            string query = "SELECT companyUserID FROM [CompanyAccounts] WHERE [CompanyLog-In_Email] = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                cmd.Parameters.AddWithValue("?", email);
                try
                {
                    myConn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return Convert.ToInt32(reader["companyUserID"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return 0;
        }

        internal int getHunterID(string userName)
        {
            string query = "SELECT userID FROM [JobHunter Accounts] WHERE [Username] = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                cmd.Parameters.AddWithValue("?", userName);
                try
                {
                    myConn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return Convert.ToInt32(reader["userID"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return 0;
        }

        public byte[]? DisplayCompanyLogo(int companyId)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string logoQuery = "SELECT [Logo Data] FROM [Company Documents Binary Data] WHERE [companyUserID] = ? AND " +
                               "[Logo DataType] IN ('.jpg', '.jpeg', '.png', '.bmp', '.gif', '.webp')";

                using (OleDbCommand cmd = new OleDbCommand(logoQuery, conn))
                {
                    cmd.Parameters.AddWithValue("?", companyId);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() && reader["Logo Data"] != DBNull.Value)
                        {
                            byte[] imageData = (byte[])reader["Logo Data"];
                            return imageData;
                        }
                        else
                        {
                            MessageBox.Show("No logo found for the selected company.");
                            return null;
                        }
                    }
                }
            }
        }

        public byte[]? DisplayProfilePicture(int hunterID)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT [Pfp Data] FROM [JobHunter Documents Binary Data] WHERE [userID] = ? AND " +
                               "[Pfp FileType] IN ('.jpg', '.jpeg', '.png', '.bmp', '.gif', '.webp')";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", hunterID);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() && reader["Pfp Data"] != DBNull.Value)
                        {
                            return (byte[])reader["Pfp Data"];
                        }
                    }
                }
            }
            return null;
        }

        internal bool isValidEmail(string email) //Used in code verification for changing passwords
        {
            string query = "SELECT * FROM [JobHunter Accounts] WHERE Email = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                cmd.Parameters.AddWithValue("?", email);
                try
                {
                    myConn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    return reader.HasRows;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        internal string? GetUserNameByEmail(string email) //Used in code verification for changing passwords
        {
            string query = "SELECT Username FROM [JobHunter Accounts] WHERE Email = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                cmd.Parameters.AddWithValue("?", email);
                try
                {
                    myConn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["Username"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return null;
        }

        internal void ChangePassword(string newPassword, string? UserEmail)
        {
            if (string.IsNullOrEmpty(UserEmail))
            {
                MessageBox.Show("Invalid email provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Query = "Update [JobHunter Accounts] Set [Password] = ? Where Email = ?";
            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(Query, myConn))
            {
                myConn.Open();
                cmd.Parameters.AddWithValue("?", newPassword);
                cmd.Parameters.AddWithValue("?", UserEmail);
                cmd.ExecuteNonQuery();
            }
        }

        internal void InsertValidationData(int companyUserId, string companyName, string industry, string Address, string website, string contactPerson, string contactPosition, string contactNumber, string contactEmail,
                                           string logoFilePath, byte[] companyLogo, string corFilePath, byte[] cor, string birrFilePath, byte[] birr, string mpFilePath, byte[] mp, DateTime currentDate, string status)
        {
            string logoFileName = Path.GetFileName(logoFilePath);
            string corFileName = Path.GetFileName(corFilePath);
            string birrFileName = Path.GetFileName(birrFilePath);
            string mpFileName = Path.GetFileName(mpFilePath);

            string logoFileType = Path.GetExtension(logoFilePath);

            try
            {
                using (OleDbConnection myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();

                    string validationQuery = "INSERT INTO [Company Information Validation] ([companyUserID], [Company Name], [Industry], [Company Address], [Company Website], [Contact Person Name], [Contact Person Position], [Contact Number], [Contact Email], [Status]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(validationQuery, myConn))
                    {
                        cmd.Parameters.AddWithValue("?", companyUserId);
                        cmd.Parameters.AddWithValue("?", companyName);
                        cmd.Parameters.AddWithValue("?", industry);
                        cmd.Parameters.AddWithValue("?", Address);
                        cmd.Parameters.AddWithValue("?", website);
                        cmd.Parameters.AddWithValue("?", contactPerson);
                        cmd.Parameters.AddWithValue("?", contactPosition);
                        cmd.Parameters.AddWithValue("?", contactNumber);
                        cmd.Parameters.AddWithValue("?", contactEmail);
                        cmd.Parameters.AddWithValue("?", status);
                        cmd.ExecuteNonQuery();
                    }

                    string filesQuery = "INSERT INTO [Company Supporting Documents] ([companyUserID], [Logo], [CORSEC], [BIRR], [Mayor's Permit]) VALUES (?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(filesQuery, myConn))
                    {
                        cmd.Parameters.AddWithValue("?", companyUserId);
                        cmd.Parameters.AddWithValue("?", logoFileName);
                        cmd.Parameters.AddWithValue("?", corFileName);
                        cmd.Parameters.AddWithValue("?", birrFileName);
                        cmd.Parameters.AddWithValue("?", mpFileName);
                        cmd.ExecuteNonQuery();
                    }

                    string filesDataQuery = "INSERT INTO [Company Documents Binary Data] ([companyUserID], [Logo Data], [COR Data], [BIRR Data], [MP Data], [Logo DataType], [Date Uploaded]) VALUES (?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(filesDataQuery, myConn))
                    {
                        cmd.Parameters.AddWithValue("?", companyUserId);
                        cmd.Parameters.Add("?", OleDbType.VarBinary).Value = companyLogo;
                        cmd.Parameters.Add("?", OleDbType.VarBinary).Value = cor;
                        cmd.Parameters.Add("?", OleDbType.VarBinary).Value = birr;
                        cmd.Parameters.Add("?", OleDbType.VarBinary).Value = mp;
                        cmd.Parameters.AddWithValue("?", logoFileType);
                        cmd.Parameters.Add("?", OleDbType.Date).Value = currentDate;
                        cmd.ExecuteNonQuery();
                    }


                    MessageBox.Show("Validation Data submitted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        internal void InsertJobPostData(int companyID, string companyName, string jobTitle, string jobType, string jobCategory, string jobIndustry, string jobLocation, string workMode, string salary, string jobDescription, string appDetails, int vacancy, DateTime appDeadline, bool IsPosted)
        {
            try
            {
                using (OleDbConnection myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();
                    string registerQuery = "INSERT INTO [Job Postings] ([CompanyUserID], [CompanyName], [JobTitle], [JobType], [Category], [Industry], [Location], [Work Mode], [StartingSalary], [Job Description], [ApplicationDetails], [Vacancy], [Application Deadline], [IsPosted]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(registerQuery, myConn))
                    {
                        cmd.Parameters.AddWithValue("?", companyID);
                        cmd.Parameters.AddWithValue("?", companyName);
                        cmd.Parameters.AddWithValue("?", jobTitle);
                        cmd.Parameters.AddWithValue("?", jobType);
                        cmd.Parameters.AddWithValue("?", jobCategory);
                        cmd.Parameters.AddWithValue("?", jobIndustry);
                        cmd.Parameters.AddWithValue("?", jobLocation);
                        cmd.Parameters.AddWithValue("?", workMode);
                        cmd.Parameters.AddWithValue("?", salary);
                        cmd.Parameters.AddWithValue("?", jobDescription);
                        cmd.Parameters.AddWithValue("?", appDetails);
                        cmd.Parameters.AddWithValue("?", vacancy);
                        cmd.Parameters.Add("?", OleDbType.Date).Value = appDeadline;
                        cmd.Parameters.AddWithValue("?", IsPosted);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Job post inserted successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //cmd = new OleDbCommand("SELECT MAX(ID) FROM [JobHunter Accounts]", myConn); //Gets last inserted StudentID and uses it to the other tables
            //int userID = Convert.ToInt32(cmd.ExecuteScalar());
        }

        internal DataTable? GetCompanyJobList(int companyUserID)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Job_FrontEnd_Details] WHERE [CompanyUserID] = ?", conn))
                {
                    cmd.Parameters.AddWithValue("?", companyUserID);
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        internal void UpdateIsPostedStatus(int companyUserID, bool status)
        {
            string isPostedQuery = "UPDATE [Job Postings] SET [IsPosted] = ? WHERE [companyUserID] = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(isPostedQuery, myConn))
            {
                cmd.Parameters.AddWithValue("?", status);
                cmd.Parameters.AddWithValue("?", companyUserID);
                try
                {
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal List<ViewApplicants> GetJobPostApplicants(int companyID) //For Companies...Fetches Job Posts data to display current company's own posts, only to get applicants
        {
            List<ViewApplicants> jobPostPanels = new List<ViewApplicants>();
            bool isPosted = true;

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM [Job_FrontEnd_Details] WHERE [CompanyUserID] = ? AND [isPosted] = ?";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", companyID);
                    cmd.Parameters.AddWithValue("?", isPosted);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            return jobPostPanels; // Return empty if no data
                        }

                        while (reader.Read())
                        {
                            string companyName = reader.GetString(1);
                            string jobTitle = reader.GetString(2);
                            string jobType = reader.GetString(3);
                            string location = reader.GetString(4);
                            string workMode = reader.GetString(5);
                            string startingSalary = reader.GetString(6);
                            int vacancy = reader.GetInt32(7);
                            int logoIndex = reader.GetOrdinal("Logo Data");
                            byte[]? logo = reader.IsDBNull(logoIndex) ? null : (byte[])reader[logoIndex];
                            int postID = reader.GetInt32(10);

                            var jobPostPanel = new ViewApplicants(postID, companyName, jobTitle, jobType, location, workMode, startingSalary, vacancy, logo)
                            {
                                Size = new Size(593, 117)
                            };
                            jobPostPanels.Add(jobPostPanel);
                        }
                    }
                }
            }
            return jobPostPanels;
        }

        internal DataTable? GetGeneralApplicantDetails(int postID)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM [General_Applicant_Information] WHERE [JobPostID] = ?", conn))
                {
                    cmd.Parameters.AddWithValue("?", postID);
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        internal void UpdateApplicationStatus(int hunterID, string status)
        {
            string query = "UPDATE [Job Applicants] SET [Status] = ? WHERE [UserID] = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                cmd.Parameters.AddWithValue("?", status);
                cmd.Parameters.AddWithValue("?", hunterID);
                try
                {
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Status updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal void RetrieveApplicantFiles(int hunterID)
        {
            string query = "SELECT [Profile Picture], [Resume/CV], [Cover Letter], [Personal Portfolio], [Pfp Data], [Resume Data], [CoverLetter Data], [Portfolio Data] FROM [JobHunter Files_Query] WHERE [userID] = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                cmd.Parameters.AddWithValue("?", hunterID);
                try
                {
                    myConn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string logoName = reader["Profile Picture"].ToString();
                            string corName = reader["Resume/CV"].ToString();
                            string birrName = reader["Cover Letter"].ToString();
                            string mpName = reader["Personal Portfolio"].ToString();

                            byte[] logoData = (byte[])reader["Pfp Data"];
                            byte[] corData = (byte[])reader["Resume Data"];
                            byte[] birrData = (byte[])reader["CoverLetter Data"];
                            byte[] mpData = (byte[])reader["Portfolio Data"];

                            string logoPath = $"D:\\Users\\titan\\OneDrive\\Documents\\C andC# files\\C programming\\C# Programming\\OOP 2\\Database\\JobHunter Files\\{logoName}";
                            string corPath = $"D:\\Users\\titan\\OneDrive\\Documents\\C andC# files\\C programming\\C# Programming\\OOP 2\\Database\\JobHunter Files\\{corName}";
                            string birrPath = $"D:\\Users\\titan\\OneDrive\\Documents\\C andC# files\\C programming\\C# Programming\\OOP 2\\Database\\JobHunter Files\\{birrName}";
                            string mpPath = $"D:\\Users\\titan\\OneDrive\\Documents\\C andC# files\\C programming\\C# Programming\\OOP 2\\Database\\JobHunter Files\\{mpName}";

                            System.IO.File.WriteAllBytes(logoPath, logoData);
                            System.IO.File.WriteAllBytes(corPath, corData);
                            System.IO.File.WriteAllBytes(birrPath, birrData);
                            System.IO.File.WriteAllBytes(mpPath, mpData);

                            MessageBox.Show("Files retrieved successfully!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving files: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal DataTable? GetCompanyData() //For admins
        {
            try
            {
                using (OleDbConnection myConn = new OleDbConnection(connectionString))
                {
                    da = new OleDbDataAdapter("SELECT [Company Information Validation].companyUserID, [Company Information Validation].[Company Name], CompanyAccounts.[CompanyLog-In_Email], " +
                        "[Company Information Validation].Industry, [Company Information Validation].[Company Address], [Company Information Validation].[Contact Person Name], " +
                        "[Company Information Validation].[Contact Person Position], [Company Information Validation].[Contact Number], [Company Information Validation].[Contact Email], " +
                        "[Company Information Validation].Status, [Company Files_Query].FileID FROM(CompanyAccounts INNER JOIN[Company Information Validation] ON " +
                        "CompanyAccounts.companyUserID = [Company Information Validation].companyUserID) INNER JOIN[Company Files_Query] ON CompanyAccounts.companyUserID = [Company Files_Query].companyUserID;", myConn);
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        internal void RetrieveFiles(int companyUserID) //For admins
        {
            string query = "SELECT [Logo], [CORSEC], [BIRR], [Mayor's Permit], [Logo Data], [COR Data], [BIRR Data], [MP Data] FROM [Company Files_Query] WHERE [companyUserID] = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                cmd.Parameters.AddWithValue("?", companyUserID);
                try
                {
                    myConn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string logoName = reader["Logo"].ToString();
                            string corName = reader["CORSEC"].ToString();
                            string birrName = reader["BIRR"].ToString();
                            string mpName = reader["Mayor's Permit"].ToString();

                            byte[] logoData = (byte[])reader["Logo Data"];
                            byte[] corData = (byte[])reader["COR Data"];
                            byte[] birrData = (byte[])reader["BIRR Data"];
                            byte[] mpData = (byte[])reader["MP Data"];

                            string logoPath = $"D:\\Users\\titan\\OneDrive\\Documents\\C andC# files\\C programming\\C# Programming\\OOP 2\\Database\\Company Files\\{logoName}";
                            string corPath = $"D:\\Users\\titan\\OneDrive\\Documents\\C andC# files\\C programming\\C# Programming\\OOP 2\\Database\\Company Files\\{corName}";
                            string birrPath = $"D:\\Users\\titan\\OneDrive\\Documents\\C andC# files\\C programming\\C# Programming\\OOP 2\\Database\\Company Files\\{birrName}";
                            string mpPath = $"D:\\Users\\titan\\OneDrive\\Documents\\C andC# files\\C programming\\C# Programming\\OOP 2\\Database\\Company Files\\{mpName}";

                            System.IO.File.WriteAllBytes(logoPath, logoData);
                            System.IO.File.WriteAllBytes(corPath, corData);
                            System.IO.File.WriteAllBytes(birrPath, birrData);
                            System.IO.File.WriteAllBytes(mpPath, mpData);

                            MessageBox.Show("Files retrieved successfully!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving files: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal void UpdateCompanyStatus(int companyUserID, string status) //For admins
        {
            string query = "UPDATE [Company Information Validation] SET [Status] = ? WHERE [companyUserID] = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                cmd.Parameters.AddWithValue("?", status);
                cmd.Parameters.AddWithValue("?", companyUserID);
                try
                {
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Status updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal string? GetApprovalStatus(int companyUserID)
        {
            string query = "SELECT [Status] FROM [Company Information Validation] WHERE [companyUserID] = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                cmd.Parameters.AddWithValue("?", companyUserID);
                try
                {
                    myConn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["Status"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return "";
        }

        internal void InsertHunterProfileDetails(int hunterID, string name, DateTime bday, string gender, string number, string email, string address, string nationality, string education, string? degree, string univ,
                                                 byte[]? pfpData, string pfpFilePath, byte[]? resumeData, string resumeFilePath, byte[]? letterData, string? letterFilePath, byte[]? portfolioData,
                                                 string? portfolioFilePath, string? website, DateTime currentDate, bool isSetUp)
        {
            string pfpFileName = Path.GetFileName(pfpFilePath);
            string resumeFileName = Path.GetFileName(resumeFilePath);
            string? letterFileName = letterFilePath != null ? Path.GetFileName(letterFilePath) : "N/A";
            string? portfolioFileName = portfolioFilePath != null ? Path.GetFileName(portfolioFilePath) : "N/A";

            string websiteUrl = website != null ? website : "N/A";

            string pfpFileType = Path.GetExtension(pfpFilePath);

            try
            {
                using (OleDbConnection myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();

                    string profileQuery = "INSERT INTO [JobHunter Profile Information] ([userID], [Full Name], [Date of Birth], [Gender], [Contact Number], [Email], [Address], [Nationality], [Education], [Degree], [University / Institution], [isSetUp]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(profileQuery, myConn))
                    {
                        cmd.Parameters.AddWithValue("?", hunterID);
                        cmd.Parameters.AddWithValue("?", name);
                        cmd.Parameters.Add("?", OleDbType.Date).Value = bday;
                        cmd.Parameters.AddWithValue("?", gender);
                        cmd.Parameters.AddWithValue("?", number);
                        cmd.Parameters.AddWithValue("?", email);
                        cmd.Parameters.AddWithValue("?", address);
                        cmd.Parameters.AddWithValue("?", nationality);
                        cmd.Parameters.AddWithValue("?", education);
                        cmd.Parameters.AddWithValue("?", degree);
                        cmd.Parameters.AddWithValue("?", univ);
                        cmd.Parameters.AddWithValue("?", isSetUp);
                        cmd.ExecuteNonQuery();
                    }

                    string filesQuery = "INSERT INTO [JobHunter Supporting Documents] ([userID], [Profile Picture], [Resume/CV], [Cover Letter], [Personal Portfolio], [Website]) VALUES (?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(filesQuery, myConn))
                    {
                        cmd.Parameters.AddWithValue("?", hunterID);
                        cmd.Parameters.AddWithValue("?", pfpFileName);
                        cmd.Parameters.AddWithValue("?", resumeFileName);
                        cmd.Parameters.AddWithValue("?", letterFileName);
                        cmd.Parameters.AddWithValue("?", portfolioFileName);
                        cmd.Parameters.AddWithValue("?", websiteUrl);
                        cmd.ExecuteNonQuery();
                    }

                    string filesDataQuery = "INSERT INTO [JobHunter Documents Binary Data] ([userID], [Pfp Data], [Resume Data], [CoverLetter Data], [Portfolio Data], [Pfp FileType], [Date Uploaded]) VALUES (?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(filesDataQuery, myConn))
                    {
                        cmd.Parameters.AddWithValue("?", hunterID);
                        cmd.Parameters.Add("?", OleDbType.VarBinary).Value = pfpData;
                        cmd.Parameters.Add("?", OleDbType.VarBinary).Value = resumeData;
                        cmd.Parameters.Add("?", OleDbType.VarBinary).Value = letterData;
                        cmd.Parameters.Add("?", OleDbType.VarBinary).Value = portfolioData;
                        cmd.Parameters.AddWithValue("?", pfpFileType);
                        cmd.Parameters.Add("?", OleDbType.Date).Value = currentDate;
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Validation Data submitted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public Dictionary<string, object>? GetProfileDetails(int hunterID)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM [JobHunter Profile Information] WHERE [userID] = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", hunterID);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var data = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                data[reader.GetName(i)] = reader.IsDBNull(i) ? "" : reader.GetValue(i);
                            }
                            return data;
                        }
                    }
                }
            }
            return null;
        }

        internal bool GetProfileSetUpStatus(int hunterID)
        {
            string query = "SELECT [isSetUp] FROM [JobHunter Profile Information] WHERE [userID] = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                cmd.Parameters.AddWithValue("?", hunterID);
                try
                {
                    myConn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (bool)reader["isSetUp"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        internal List<JobPostPanel> GetJobPosts(int hunterID) //For JobHunters...fetches Job Posts data for Job Applications
        {
            List<JobPostPanel> jobPostPanels = new List<JobPostPanel>();
            bool isPosted = true;

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM [Job_FrontEnd_Details] WHERE [IsPosted] = ?";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", isPosted);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            return jobPostPanels; // Return empty if no data
                        }

                        while (reader.Read())
                        {
                            string companyName = reader.GetString(1);
                            string jobTitle = reader.GetString(2);
                            string jobType = reader.GetString(3);
                            string location = reader.GetString(4);
                            string workMode = reader.GetString(5);
                            string startingSalary = reader.GetString(6);
                            int vacancy = reader.GetInt32(7);
                            int logoIndex = reader.GetOrdinal("Logo Data");
                            byte[]? logo = reader.IsDBNull(logoIndex) ? null : (byte[])reader[logoIndex];
                            int postID = reader.GetInt32(10);

                            string tag = companyName + "-" + jobTitle + "-" + jobType + "-" + location + "-" + workMode;

                            var jobPostPanelTemp = new JobPostPanel(postID, companyName, jobTitle, jobType, location, workMode, startingSalary, vacancy, logo, hunterID)
                            {
                                Size = new Size(593, 117)
                            };
                            jobPostPanelTemp.Tag = tag;
                            jobPostPanels.Add(jobPostPanelTemp);
                        }
                    }
                }
            }
            return jobPostPanels;
        }

        internal Dictionary<string, object?> GetFullJobDetails(int postID)
        {
            Dictionary<string, object?> jobDetails = new Dictionary<string, object?>();

            string fullDetailsQuery = "SELECT * FROM [Job Postings] WHERE [PostID] = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(fullDetailsQuery, myConn))
            {
                cmd.Parameters.AddWithValue("?", postID);
                try
                {
                    myConn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            for (int i = 1; i < reader.FieldCount - 1; i++)
                            {
                                string columnName = reader.GetName(i);
                                object? columnValue = reader.IsDBNull(i) ? null : reader.GetValue(i);
                                jobDetails[columnName] = columnValue;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving job details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return jobDetails;
        }

        internal Dictionary<string, object?> GetGeneralCompanyDetails(int companyID)
        {
            Dictionary<string, object?> jobDetails = new Dictionary<string, object?>();

            string fullDetailsQuery = "SELECT [Company Name], [CompanyLog-In_Email], [Company Address], [Company Website] FROM [General_Company_Information_Query] WHERE [companyUserID] = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(fullDetailsQuery, myConn))
            {
                cmd.Parameters.AddWithValue("?", companyID);
                try
                {
                    myConn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            jobDetails["Company Name"] = reader["Company Name"];
                            jobDetails["CompanyLog-In_Email"] = reader["CompanyLog-In_Email"];
                            jobDetails["Company Address"] = reader["Company Address"];
                            jobDetails["Company Website"] = reader["Company Website"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving job details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return jobDetails;
        }

        internal void ApplyForAJob(int postID, int hunterID, DateTime dateApplied, string status)
        {
            try
            {
                myConn = new OleDbConnection(connectionString);
                myConn.Open();

                string applyQuery = "INSERT INTO [Job Applicants] ([JobPostID], [UserID], [Application Date], [Status]) values (?, ?, ?, ?)";
                cmd = new OleDbCommand(applyQuery, myConn);
                cmd.Parameters.AddWithValue("?", postID);
                cmd.Parameters.AddWithValue("?", hunterID);
                cmd.Parameters.Add("?", OleDbType.Date).Value = dateApplied;
                cmd.Parameters.AddWithValue("?", status);
                cmd.ExecuteNonQuery();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        internal DataTable? GetJobApplications(int hunterID)
        {
            try
            {
                using (OleDbConnection myConn = new OleDbConnection(connectionString))
                {
                    string query = "SELECT [Job Applicants].UserID, [Job Applicants].[Application ID], Job_FrontEnd_Details.CompanyName, Job_FrontEnd_Details.JobTitle, " +
                        "[Job Applicants].Status, Job_FrontEnd_Details.[Work Mode], [Job Applicants].[Application Date] FROM [Job Applicants] INNER JOIN Job_FrontEnd_Details " +
                        "ON [Job Applicants].JobPostID = Job_FrontEnd_Details.PostID WHERE [Job Applicants].UserID = ?"; 

                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        // Add the hunterID parameter
                        cmd.Parameters.AddWithValue("?", hunterID);

                        using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            da.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
