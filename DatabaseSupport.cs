using System.Data;
using System.Data.OleDb;

namespace Job_Application_Manager
{
    internal class DatabaseSupport
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\\Users\\titan\\OneDrive\\Documents\\C andC# files\\C programming\\C# Programming\\OOP 2\\Database\\JobApplicationManager_Database.accdb";

        private OleDbConnection? myConn;
        private OleDbDataAdapter? da;
        private OleDbCommand? cmd;

        internal void registerJobHunterData(string Email, string Username, string Password, string GmailAppPass)
        {
            myConn = new OleDbConnection(connectionString);
            myConn.Open();

            string registerQuery = "INSERT INTO [JobHunter Accounts] ([Email], [Username], [Password], [Gmail App Password]) values (?, ?, ?, ?)";
            cmd = new OleDbCommand(registerQuery, myConn);
            cmd.Parameters.AddWithValue("?", Email);
            cmd.Parameters.AddWithValue("?", Username);
            cmd.Parameters.AddWithValue("?", Password);
            cmd.Parameters.AddWithValue("?", GmailAppPass);
            cmd.ExecuteNonQuery();
            myConn.Close();
        }

        internal void registerCompanyData(string Email, string Username, string Password, string GmailAppPass)
        {
            myConn = new OleDbConnection(connectionString);
            myConn.Open();

            string registerQuery = "INSERT INTO [CompanyAccounts] ([CompanyLog-In_Email], [CompanyName], [Password], [Gmail App Password]) values (?, ?, ?, ?)";
            cmd = new OleDbCommand(registerQuery, myConn);
            cmd.Parameters.AddWithValue("?", Email);
            cmd.Parameters.AddWithValue("?", Username);
            cmd.Parameters.AddWithValue("?", Password);
            cmd.Parameters.AddWithValue("?", GmailAppPass);
            cmd.ExecuteNonQuery();
            myConn.Close();
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

        internal string? GetHunterEmail(int hunterID)
        {
            using (myConn = new OleDbConnection(connectionString))
            {
                myConn.Open();
                string query = "SELECT [Email] FROM [JobHunter Accounts] WHERE [userID] = ?";
                using (cmd = new OleDbCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("?", hunterID);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["Email"].ToString();
                        }
                    }
                }
            }
            return null;
        }

        internal string? GetCompanyEmail(int companyID)
        {
            using (myConn = new OleDbConnection(connectionString))
            {
                myConn.Open();
                string query = "SELECT [CompanyLog-In_Email] FROM [CompanyAccounts] WHERE [companyUserID] = ?";
                using (cmd = new OleDbCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("?", companyID);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["CompanyLog-In_Email"].ToString();
                        }
                    }
                }
            }
            return null;
        }

        internal Dictionary<string, object?> GetCompanyEmailData(int companyID)
        {
            Dictionary<string, object?> companyEmailData = new Dictionary<string, object?>();

            string query = "SELECT [CompanyLog-In_Email], [Gmail App Password] FROM [CompanyAccounts] WHERE [companyUserID] = ?";
            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                cmd.Parameters.AddWithValue("?", companyID);
                try
                {
                    myConn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            companyEmailData["CompanyEmail"] = reader["CompanyLog-In_Email"].ToString();
                            companyEmailData["GmailAppPassword"] = reader["Gmail App Password"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return companyEmailData;
        }

        internal Dictionary<string, object?> GetHunterEmailData(int hunterID)
        {
            Dictionary<string, object?> hunterEmailData = new Dictionary<string, object?>();

            string query = "SELECT [Email], [Gmail App Password] FROM [JobHunter Accounts] WHERE [userID] = ?";
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
                            hunterEmailData["HunterEmail"] = reader["Email"].ToString();
                            hunterEmailData["GmailAppPassword"] = reader["Gmail App Password"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return hunterEmailData;
        }

        internal Dictionary<string, object?> GetAdminEmailData(int adminID)
        {
            Dictionary<string, object?> adminEmailData = new Dictionary<string, object?>();
            string query = "SELECT [Email], [Gmail App Password] FROM [Administrators] WHERE [adminID] = ?";
            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                cmd.Parameters.AddWithValue("?", adminID);
                try
                {
                    myConn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            adminEmailData["AdminEmail"] = reader["Email"].ToString();
                            adminEmailData["GmailAppPassword"] = reader["Gmail App Password"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return adminEmailData;
        }

        public byte[]? DisplayCompanyLogo(int companyId)
        {
            using (myConn = new OleDbConnection(connectionString))
            {
                myConn.Open();
                string logoQuery = "SELECT [Logo Data] FROM [Company Documents Binary Data] WHERE [companyUserID] = ? AND " +
                               "[Logo DataType] IN ('.jpg', '.jpeg', '.png', '.bmp', '.gif', '.webp')";

                using (cmd = new OleDbCommand(logoQuery, myConn))
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
            using (OleDbConnection myConn = new OleDbConnection(connectionString))
            {
                myConn.Open();
                string query = "SELECT [Pfp Data] FROM [JobHunter Documents Binary Data] WHERE [userID] = ? AND " +
                               "[Pfp FileType] IN ('.jpg', '.jpeg', '.png', '.bmp', '.gif', '.webp')";
                using (OleDbCommand cmd = new OleDbCommand(query, myConn))
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

        internal bool isValidHunterEmail(string email) //Used in code verification for changing passwords..Possible e change
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

        internal string? GetHunterNameByEmail(string email) //Used in code verification for changing passwords
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

        internal bool isValidCompanyEmail(string email) //Used in code verification for changing passwords..Possible e change
        {
            string query = "SELECT * FROM [CompanyAccounts] WHERE [CompanyLog-In_Email] = ?";

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

        internal string? GetCompanyNameByEmail(string email) //Used in code verification for changing passwords
        {
            string query = "SELECT [CompanyName] FROM [CompanyAccounts] WHERE [CompanyLog-In_Email] = ?";

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
                            return reader["CompanyName"].ToString();
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

        internal void ChangeHunterPassword(string newPassword, string? UserEmail)
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

        internal void ChangeCompanyPassword(string newPassword, string? UserEmail)
        {
            if (string.IsNullOrEmpty(UserEmail))
            {
                MessageBox.Show("Invalid email provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Query = "Update [CompanyAccounts] Set [Password] = ? Where [CompanyLog-In_Email] = ?";
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
            using (OleDbConnection myConn = new OleDbConnection(connectionString))
            {
                try
                {
                    myConn.Open();
                    string isPostedQuery = "UPDATE [Job Postings] SET [IsPosted] = ? WHERE [companyUserID] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(isPostedQuery, myConn))
                    {
                        cmd.Parameters.AddWithValue("?", status);
                        cmd.Parameters.AddWithValue("?", companyUserID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No rows updated. Check if companyUserID exists.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal void UpdateJobPost(int? postID, string? companyName, string? jobTitle, string? jobType, string? location, string? workMode, string? salary, int? vacancy, DateTime closing)
        {
            string isPostedQuery = "UPDATE [Job Postings] SET [CompanyName] = ?, [JobTitle] = ?, [JobType] = ?, [Location] = ?, [Work Mode] = ?, [StartingSalary] = ?, [Vacancy] = ?, [Application Deadline] = ? WHERE [PostID] = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(isPostedQuery, myConn))
            {
                cmd.Parameters.AddWithValue("?", companyName);
                cmd.Parameters.AddWithValue("?", jobTitle);
                cmd.Parameters.AddWithValue("?", jobType);
                cmd.Parameters.AddWithValue("?", location);
                cmd.Parameters.AddWithValue("?", workMode);
                cmd.Parameters.AddWithValue("?", salary);
                cmd.Parameters.AddWithValue("?", vacancy);
                cmd.Parameters.Add("?", OleDbType.Date).Value = closing;
                cmd.Parameters.AddWithValue("?", postID);
                try
                {
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Job post updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating job post: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal void UpdateJobDescription(int? postID, string? jobDescription)
        {
            string isPostedQuery = "UPDATE [Job Postings] SET [Job Description] = ? WHERE [PostID] = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(isPostedQuery, myConn))
            {
                cmd.Parameters.AddWithValue("?", jobDescription);
                cmd.Parameters.AddWithValue("?", postID);
                try
                {
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating job post: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal void UpdateJobApplicationDetails(int? postID, string? details)
        {
            string isPostedQuery = "UPDATE [Job Postings] SET [ApplicationDetails] = ? WHERE [PostID] = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(isPostedQuery, myConn))
            {
                cmd.Parameters.AddWithValue("?", details);
                cmd.Parameters.AddWithValue("?", postID);
                try
                {
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating job post: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal void DecrementJobVacancy(int postID)
        {
            string vacancyQuery = "UPDATE [Job Postings] SET [Vacancy] = Vacancy - 1 WHERE [PostID] = ?";
            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(vacancyQuery, myConn))
            {
                cmd.Parameters.AddWithValue("?", postID);
                try
                {
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating job post: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal void IncrementJobVacancy(int postID)
        {
            string vacancyQuery = "UPDATE [Job Postings] SET [Vacancy] = Vacancy + 1 WHERE [PostID] = ?";
            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(vacancyQuery, myConn))
            {
                cmd.Parameters.AddWithValue("?", postID);
                try
                {
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating job post: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal void RequestUpdateCompanyDetails(int companyUserId, string companyName, string industry, string Address, string website, string contactPerson, string contactPosition, string contactNumber, string contactEmail, string? logoFilePath, byte[] companyLogo)
        {
            string updateQuery = "INSERT INTO [Update Company Information Requests] ([companyUserID], [Company Name], [Industry], [Company Address], [Company Website], [Contact Person Name], [Contact Person Position], [Contact Number], [Contact Email], [Logo Path], [Logo Data]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(updateQuery, myConn))
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
                cmd.Parameters.AddWithValue("?", logoFilePath);
                cmd.Parameters.Add("?", OleDbType.VarBinary).Value = companyLogo;

                try
                {
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update request submitted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        internal void UpdateCompanyDetails(int companyUserId, string companyName, string industry, string Address, string website, string contactPerson, string contactPosition, string contactNumber, string contactEmail, string? logoFilePath, byte[] companyLogo)
        {
            string? logoFileName = Path.GetFileName(logoFilePath);
            string? logoFileType = Path.GetExtension(logoFilePath);

            string updateQuery = "UPDATE [Company Information Validation] SET [Company Name] = ?, [Industry] = ?, [Company Address] = ?, [Company Website] = ?, [Contact Person Name] = ?, [Contact Person Position] = ?, [Contact Number] = ?, [Contact Email] = ? WHERE [companyUserID] = ?";
            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(updateQuery, myConn))
            {
                cmd.Parameters.AddWithValue("?", companyName);
                cmd.Parameters.AddWithValue("?", industry);
                cmd.Parameters.AddWithValue("?", Address);
                cmd.Parameters.AddWithValue("?", website);
                cmd.Parameters.AddWithValue("?", contactPerson);
                cmd.Parameters.AddWithValue("?", contactPosition);
                cmd.Parameters.AddWithValue("?", contactNumber);
                cmd.Parameters.AddWithValue("?", contactEmail);
                cmd.Parameters.AddWithValue("?", companyUserId);
                try
                {
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            string filesQuery = "UPDATE [Company Supporting Documents] SET [Logo] = ? WHERE [companyUserID] = ?";
            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(filesQuery, myConn))
            {
                cmd.Parameters.AddWithValue("?", logoFileName);
                cmd.Parameters.AddWithValue("?", companyUserId);
                try
                {
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            string filesDataQuery = "UPDATE [Company Documents Binary Data] SET [Logo Data] = ?, [Logo DataType] = ? WHERE [companyUserID] = ?";
            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(filesDataQuery, myConn))
            {
                cmd.Parameters.Add("?", OleDbType.VarBinary).Value = companyLogo;
                cmd.Parameters.AddWithValue("?", logoFileType);
                cmd.Parameters.AddWithValue("?", companyUserId);
                try
                {
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            MessageBox.Show("Company details updated successfully!");
        }

        internal void DeleteUpdateRequest(int requestID)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string deleteRequestQuery = "DELETE FROM [Update Company Information Requests] WHERE [RequestID] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(deleteRequestQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", requestID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting request: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void DeleteJobPost(int postID)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string deletePostQuery = "DELETE FROM [Job Postings] WHERE [PostID] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(deletePostQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", postID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting post: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void UpdateApplicationStatusForDeleted(int postID, string status)
        {
            string query = "UPDATE [Job Applicants] SET [Status] = ? WHERE [JobPostID] = ?";
            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                cmd.Parameters.AddWithValue("?", status);
                cmd.Parameters.AddWithValue("?", postID);
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
            List<ViewApplicants> jobPostApplicants = new List<ViewApplicants>();
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
                            return jobPostApplicants; // Return empty if no data
                        }

                        while (reader.Read())
                        {
                            string companyName = reader.GetString(1);
                            string jobTitle = reader.GetString(2);
                            string jobType = reader.GetString(3);
                            string location = reader.GetString(5);
                            string workMode = reader.GetString(6);
                            int logoIndex = reader.GetOrdinal("Logo Data");
                            byte[]? logo = reader.IsDBNull(logoIndex) ? null : (byte[])reader[logoIndex];
                            int postID = reader.GetInt32(11);

                            var jobPostPanel = new ViewApplicants(postID, companyName, jobTitle, jobType, location, workMode, logo);
                            jobPostApplicants.Add(jobPostPanel);
                        }
                    }
                }
            }
            return jobPostApplicants;
        }

        internal DataTable? GetGeneralApplicantDetails(int postID)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM [General_Applicant_Information] WHERE [PostID] = ?", conn))
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

        internal void UpdateApplicationStatus(int applicationID, string status, DateTime dateUpdated)
        {
            string query = "UPDATE [Job Applicants] SET [Status] = ?, [Status Date Updated] = ? WHERE [Application ID] = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                cmd.Parameters.AddWithValue("?", status);
                cmd.Parameters.Add("?", OleDbType.Date).Value = dateUpdated;
                cmd.Parameters.AddWithValue("?", applicationID);
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

        internal bool RetrieveApplicantFiles(int hunterID)
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
                            string profilePic = reader["Profile Picture"].ToString() ?? DBNull.Value.ToString();
                            string resume = reader["Resume/CV"].ToString() ?? DBNull.Value.ToString();
                            string coverletter = reader["Cover Letter"].ToString() ?? DBNull.Value.ToString();
                            string portfolio = reader["Personal Portfolio"].ToString() ?? DBNull.Value.ToString();

                            if (coverletter != "N/A" || portfolio != "N/A")
                            {
                                byte[]? pfpData = (byte[])reader["Pfp Data"];
                                byte[]? resumeData = (byte[])reader["Resume Data"];
                                byte[]? letterData = (byte[])reader["CoverLetter Data"];
                                byte[]? portfolioData = (byte[])reader["Portfolio Data"];

                                string pfpPath = $"D:\\Users\\titan\\OneDrive\\Documents\\C andC# files\\C programming\\C# Programming\\OOP 2\\Database\\JobHunter Files\\{profilePic}";
                                string resumePath = $"D:\\Users\\titan\\OneDrive\\Documents\\C andC# files\\C programming\\C# Programming\\OOP 2\\Database\\JobHunter Files\\{resume}";
                                string letterPath = $"D:\\Users\\titan\\OneDrive\\Documents\\C andC# files\\C programming\\C# Programming\\OOP 2\\Database\\JobHunter Files\\{coverletter}";
                                string portfolioPath = $"D:\\Users\\titan\\OneDrive\\Documents\\C andC# files\\C programming\\C# Programming\\OOP 2\\Database\\JobHunter Files\\{portfolio}";

                                System.IO.File.WriteAllBytes(pfpPath, pfpData);
                                System.IO.File.WriteAllBytes(resumePath, resumeData);
                                System.IO.File.WriteAllBytes(letterPath, letterData);
                                System.IO.File.WriteAllBytes(portfolioPath, portfolioData);


                            }
                            else
                            {
                                if (profilePic != "" || resume != "")
                                {
                                    byte[]? pfpData = (byte[])reader["Pfp Data"];
                                    byte[]? resumeData = (byte[])reader["Resume Data"];
                                    string pfpPath = $"D:\\Users\\titan\\OneDrive\\Documents\\C andC# files\\C programming\\C# Programming\\OOP 2\\Database\\JobHunter Files\\{profilePic}";
                                    string resumePath = $"D:\\Users\\titan\\OneDrive\\Documents\\C andC# files\\C programming\\C# Programming\\OOP 2\\Database\\JobHunter Files\\{resume}";
                                    System.IO.File.WriteAllBytes(pfpPath, pfpData);
                                    System.IO.File.WriteAllBytes(resumePath, resumeData);
                                }
                                else
                                {
                                    MessageBox.Show("No files found for the selected applicant.");
                                    return false;
                                }
                            }
                        }
                    }
                    MessageBox.Show("Files retrieved successfully!");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving files: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        internal DataTable? GetAllCompanies() //For Admins
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

        internal void RetrieveCompanyFiles(int companyUserID) //For Admins
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
                            string? logoName = reader["Logo"].ToString();
                            string? corName = reader["CORSEC"].ToString();
                            string? birrName = reader["BIRR"].ToString();
                            string? mpName = reader["Mayor's Permit"].ToString();

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

        internal void UpdateCompanyStatus(int companyUserID, string status) //For Admins
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

        internal DataTable? GetUpdateRequests() //For Admins  
        {
            string requestQuery = "SELECT * FROM [Update Company Information Requests]";
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(requestQuery, conn))
                    {
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
                MessageBox.Show($"Error fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        internal DataTable? GetAllJobHunters() //For Admins
        {
            string requestQuery = "SELECT [userID], [Full Name], [Gender], [Email], [Nationality], [Education], [Degree], [University / Institution] FROM [JobHunter Profile Information]";
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(requestQuery, conn))
                    {
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
                MessageBox.Show($"Error fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        internal int GetTotalNumberOfCompanies() //For Admins
        {
            string query = "SELECT COUNT(*) FROM [Company Information Validation]";
            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                try
                {
                    myConn.Open();
                    object? result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving total number of companies: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
        }

        internal int GetTotalNumberOfJobHunters()
        {
            string query = "SELECT COUNT(*) FROM [JobHunter Profile Information]";
            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                try
                {
                    myConn.Open();
                    object? result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving total number of job hunters: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
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

        internal void InsertHunterProfileDetails(int hunterID, string name, DateTime bday, string? gender, string number, string email, string address, string nationality, string education, string? degree, string? univ,
                                                 byte[]? pfpData, string pfpFilePath, byte[]? resumeData, string resumeFilePath, byte[]? letterData, string? letterFilePath, byte[]? portfolioData,
                                                 string? portfolioFilePath, string? website, DateTime currentDate, bool status)
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

                    string profileQuery = "INSERT INTO [JobHunter Profile Information] ([userID], [Full Name], [Date of Birth], [Gender], [Contact Number], [Email], [Address], [Nationality], [Education], [Degree], [University / Institution]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

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
                        cmd.ExecuteNonQuery();
                    }

                    string isSetUpQuery = "UPDATE [JobHunter Accounts] SET [isSetUp] = ? WHERE [userID] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(isSetUpQuery, myConn))
                    {
                        cmd.Parameters.AddWithValue("?", status);
                        cmd.Parameters.AddWithValue("?", hunterID);
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
                        cmd.Parameters.Add("?", OleDbType.VarBinary).Value = letterData != null ? letterData : DBNull.Value;
                        cmd.Parameters.Add("?", OleDbType.VarBinary).Value = portfolioData != null ? portfolioData : DBNull.Value;
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
            string query = "SELECT [isSetUp] FROM [JobHunter Accounts] WHERE [userID] = ?";

            using (OleDbConnection myConn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, myConn))
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

        internal void UpdateHunterProfileDetails(int hunterID, string name, DateTime bday, string? gender, string number, string email, string address, string nationality, string education, string? degree, string? univ,
                                                 byte[]? pfpData, string pfpFilePath, byte[]? resumeData, string resumeFilePath, byte[]? letterData, string? letterFilePath, byte[]? portfolioData,
                                                 string? portfolioFilePath, string? website, DateTime currentDate)
        {
            int rowsAffected = 0;
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

                    string profileQuery = "UPDATE [JobHunter Profile Information] SET [Full Name] = ?, [Date of Birth] = ?, [Gender] = ?, [Contact Number] = ?, [Email] = ?, [Address] = ?, [Nationality] = ?, [Education] = ?, [Degree] = ?, [University / Institution] = ? WHERE [userID] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(profileQuery, myConn))
                    {
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
                        cmd.Parameters.AddWithValue("?", hunterID);

                        rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No rows updated. Check if HunterID exists.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    string filesQuery = "UPDATE [JobHunter Supporting Documents] SET [Profile Picture] = ?, [Resume/CV] = ?, [Cover Letter] = ?, [Personal Portfolio] = ?, [Website] = ? WHERE [userID] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(filesQuery, myConn))
                    {
                        cmd.Parameters.AddWithValue("?", pfpFileName);
                        cmd.Parameters.AddWithValue("?", resumeFileName);
                        cmd.Parameters.AddWithValue("?", letterFileName);
                        cmd.Parameters.AddWithValue("?", portfolioFileName);
                        cmd.Parameters.AddWithValue("?", websiteUrl);
                        cmd.Parameters.AddWithValue("?", hunterID);

                        rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No rows updated. Check if HunterID exists.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    string filesDataQuery = "UPDATE [JobHunter Documents Binary Data] SET [Pfp Data] = ?, [Resume Data] = ?, [CoverLetter Data] = ?, [Portfolio Data] = ?, [Pfp FileType] = ?, [Date Uploaded] = ? WHERE [userID] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(filesDataQuery, myConn))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarBinary).Value = pfpData;
                        cmd.Parameters.Add("?", OleDbType.VarBinary).Value = resumeData;
                        cmd.Parameters.Add("?", OleDbType.VarBinary).Value = letterData != null ? letterData : DBNull.Value;
                        cmd.Parameters.Add("?", OleDbType.VarBinary).Value = portfolioData != null ? portfolioData : DBNull.Value;
                        cmd.Parameters.AddWithValue("?", pfpFileType);
                        cmd.Parameters.Add("?", OleDbType.Date).Value = currentDate;
                        cmd.Parameters.AddWithValue("?", hunterID);

                        rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No rows updated. Check if HunterID exists.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    MessageBox.Show("Profile data updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        internal void UpdateProfileBio(int hunterID, string text)
        {
            try
            {
                using (OleDbConnection myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();

                    string profileQuery = "UPDATE [JobHunter Profile Information] SET [Bio] = ? WHERE [userID] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(profileQuery, myConn))
                    {
                        cmd.Parameters.AddWithValue("?", text);
                        cmd.Parameters.AddWithValue("?", hunterID);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Profile bio updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal List<JobPostData> GetJobPosts(int hunterID) //For JobHunters...fetches Job Posts data for Job Applications
        {
            List<JobPostData> jobPosts = new();
            bool isPosted = true;
            try
            {
                using (OleDbConnection conn = new(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM [Job_FrontEnd_Details] WHERE [IsPosted] = ?";

                    using (OleDbCommand cmd = new(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", isPosted);
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                jobPosts.Add(new JobPostData
                                {
                                    CompanyName = reader.GetString(1),
                                    JobTitle = reader.GetString(2),
                                    JobType = reader.GetString(3),
                                    Industry = reader.GetString(4),
                                    Location = reader.GetString(5),
                                    WorkMode = reader.GetString(6),
                                    StartingSalary = reader.GetString(7),
                                    Vacancy = reader.GetInt32(8),
                                    Logo = reader.IsDBNull(reader.GetOrdinal("Logo Data")) ? null : (byte[])reader["Logo Data"],
                                    PostID = reader.GetInt32(11),
                                    Closing = reader.GetDateTime(12).ToString()
                                });
                            }
                        }
                    }
                }
                return jobPosts;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return jobPosts;
            }
        }

        internal Dictionary<string, object?> GetCompanyDetails(int companyID)
        {
            Dictionary<string, object?> jobDetails = new Dictionary<string, object?>();
            string fullDetailsQuery = "SELECT * FROM [Company Information Validation] WHERE [companyUserID] = ?";
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

        internal bool AleadyAppliedChecker(int postID, int hunterID)
        {
            string query = "SELECT * FROM [Job Applicants] WHERE [JobPostID] = ? AND [UserID] = ?";
            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                cmd.Parameters.AddWithValue("?", postID);
                cmd.Parameters.AddWithValue("?", hunterID);
                try
                {
                    myConn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    return reader.HasRows;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        internal void ApplyForAJob(int postID, int companyID, int hunterID, DateTime dateApplied, string status)
        {
            try
            {
                myConn = new OleDbConnection(connectionString);
                myConn.Open();

                string applyQuery = "INSERT INTO [Job Applicants] ([JobPostID], [CompanyUserID], [UserID], [Application Date], [Status]) values (?, ?, ?, ?, ?)";
                cmd = new OleDbCommand(applyQuery, myConn);
                cmd.Parameters.AddWithValue("?", postID);
                cmd.Parameters.AddWithValue("?", companyID);
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

        internal void SaveJobPost(int postID, int hunterID, string jobTitle)
        {
            try
            {
                myConn = new OleDbConnection(connectionString);
                myConn.Open();
                string saveQuery = "INSERT INTO [Saved Job Posts] ([PostID], [UserID], [JobTitle]) values (?, ?, ?)";
                cmd = new OleDbCommand(saveQuery, myConn);
                cmd.Parameters.AddWithValue("?", postID);
                cmd.Parameters.AddWithValue("?", hunterID);
                cmd.Parameters.AddWithValue("?", jobTitle);
                cmd.ExecuteNonQuery();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        internal DataTable? GetSavedJobPosts(int hunterID)
        {
            try
            {
                using (OleDbConnection myConn = new OleDbConnection(connectionString))
                {
                    string query = "SELECT [PostID], [JobTitle] FROM [Saved Job Posts] WHERE [UserID] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
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

        internal void DeleteSavedJobPost(int postID, int hunterID)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string deletePostQuery = "DELETE FROM [Saved Job Posts] WHERE [PostID] = ? AND [UserID] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(deletePostQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", postID);
                        cmd.Parameters.AddWithValue("?", hunterID);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Job post deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting job post: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal DataTable? GetJobApplications(int hunterID)
        {
            try
            {
                using (OleDbConnection myConn = new OleDbConnection(connectionString))
                {
                    string query = "SELECT [Job Applicants].JobPostID, [Job Applicants].[Application ID], Job_FrontEnd_Details.CompanyName, Job_FrontEnd_Details.JobTitle, " +
                        "[Job Applicants].Status, Job_FrontEnd_Details.[Work Mode], [Job Applicants].[Application Date] FROM[Job Applicants] INNER JOIN Job_FrontEnd_Details " +
                        "ON[Job Applicants].JobPostID = Job_FrontEnd_Details.PostID WHERE [Job Applicants].UserID = ?";

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

        internal void DeleteJobApplication(int applicationID)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string deletePostQuery = "DELETE FROM [Job Applicants] WHERE [Application ID] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(deletePostQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", applicationID);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Application deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void InsertEventOrNote(int userID, string eventOrNote, DateTime date, string? userType)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO [Event Plans And Notes] ([UserType], [userID], [EventORNotes], [Date Set]) VALUES (?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", userType);
                        cmd.Parameters.AddWithValue("?", userID);
                        cmd.Parameters.AddWithValue("?", eventOrNote);
                        cmd.Parameters.Add("?", OleDbType.Date).Value = date;
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Event or note added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding event or note: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal string? GetEventOrNote(int userID, DateTime date, string? userType)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string selectQuery = "SELECT [EventORNotes] FROM [Event Plans And Notes] WHERE [userID] = ? AND [Date Set] = ? AND [UserType] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(selectQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", userID);
                        cmd.Parameters.Add("?", OleDbType.Date).Value = date;
                        cmd.Parameters.AddWithValue("?", userType);
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader["EventORNotes"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving events or notes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        internal bool HasNoted(int userID, DateTime date, string? userType)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string selectQuery = "SELECT COUNT(*) FROM [Event Plans And Notes] WHERE [userID] = ? AND [Date Set] = ? AND [UserType] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(selectQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", userID);
                        cmd.Parameters.Add("?", OleDbType.Date).Value = date;
                        cmd.Parameters.AddWithValue("?", userType);
                        object? count = cmd.ExecuteScalar();
                        return count != null && (int)count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking notes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        internal void DeleteEventOrNote(int hunterID, DateTime date, string? userType)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM [Event Plans And Notes] WHERE [userID] = ? AND [Date Set] = ? AND [UserType] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", hunterID);
                        cmd.Parameters.Add("?", OleDbType.Date).Value = date;
                        cmd.Parameters.AddWithValue("?", userType);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Event or note deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting event or note: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //FOR ANALYTICS
        internal void UpdateNumOfAcceptedApplicants(int postID)
        {
            string analyticsQuery = "UPDATE [Job Postings] SET [NumOfAccepted] = NumOfAccepted + 1 WHERE [PostID] = ?";
            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(analyticsQuery, myConn))
            {
                cmd.Parameters.Add("?", OleDbType.Integer).Value = postID;
                try
                {
                    myConn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("No records were updated. Post ID might be invalid.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal void UpdateNumOfRejectedApplicants(int postID)
        {
            string analyticsQuery = "UPDATE [Job Postings] SET [NumOfRejected] = NumOfRejected + 1 WHERE [PostID] = ?";
            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(analyticsQuery, myConn))
            {
                cmd.Parameters.AddWithValue("?", postID);
                try
                {
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal void UpdateNumOfCancelledApplications(int postID)
        {
            string analyticsQuery = "UPDATE [Job Postings] SET [NumOfCancelled] = NumOfCancelled + 1 WHERE [PostID] = ?";
            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(analyticsQuery, myConn))
            {
                cmd.Parameters.AddWithValue("?", postID);
                try
                {
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal void UpdateTotalNumOFApplicants(int postID)
        {
            string analyticsQuery = "UPDATE [Job Postings] SET [TotalApplicants] = TotalApplicants + 1 WHERE [PostID] = ?";
            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(analyticsQuery, myConn))
            {
                cmd.Parameters.AddWithValue("?", postID);
                try
                {
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal List<JobPostAnalytics> GetJobPostAnalytics(int companyID)
        {
            var analyticsList = new List<JobPostAnalytics>();

            string analyticsQuery = "SELECT [Job Postings].JobTitle, [Job Postings].TotalApplicants, [Job Postings].Vacancy, [Job Postings].NumOfAccepted, [Job Postings].NumOfRejected, [Job Postings].NumOfCancelled FROM [Job Postings] WHERE [CompanyUserID] = ?";

            using (var myConn = new OleDbConnection(connectionString))
            using (var cmd = new OleDbCommand(analyticsQuery, myConn))
            {
                cmd.Parameters.AddWithValue("?", companyID);
                myConn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        analyticsList.Add(new JobPostAnalytics
                        {
                            JobTitle = reader["JobTitle"].ToString(),
                            TotalApplicants = reader["TotalApplicants"] == DBNull.Value ? 0 : Convert.ToInt32(reader["TotalApplicants"]),
                            TargetHires = reader["Vacancy"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Vacancy"]),
                            NumOfAccepted = reader["NumOfAccepted"] == DBNull.Value ? 0 : Convert.ToInt32(reader["NumOfAccepted"]),
                            NumOfRejected = reader["NumOfRejected"] == DBNull.Value ? 0 : Convert.ToInt32(reader["NumOfRejected"]),
                            NumOfCancelled = reader["NumOfCancelled"] == DBNull.Value ? 0 : Convert.ToInt32(reader["NumOfCancelled"])
                        });
                    }
                }
            }
            return analyticsList;
        }

        internal List<TotalMonthlyApplicants> GetTotalMonthlyApplicants(int companyID)
        {
            var stats = new List<TotalMonthlyApplicants>();

            string analyticsQuery = @"SELECT Format([Application Date], 'mmm-yyyy') AS [Month], COUNT(*) AS [TotalApplicants] FROM [Job Applicants] WHERE CompanyUserID = ?
                            GROUP BY Format([Application Date], 'mmm-yyyy') ORDER BY Format([Application Date], 'mmm-yyyy')";

            using (var myConn = new OleDbConnection(connectionString))
            using (var cmd = new OleDbCommand(analyticsQuery, myConn))
            {
                cmd.Parameters.AddWithValue("?", companyID);
                myConn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        stats.Add(new TotalMonthlyApplicants
                        {
                            Month = reader["Month"].ToString(),
                            TotalApplicants = Convert.ToInt32(reader["TotalApplicants"])
                        });
                    }
                }
            }
            return stats;
        }

        internal DataTable? GetRejectedApplications(int hunterID)
        {
            try
            {
                using (OleDbConnection myConn = new OleDbConnection(connectionString))
                {
                    string query = "SELECT  Job_FrontEnd_Details.CompanyName, Job_FrontEnd_Details.JobTitle FROM[Job Applicants] " +
                        "INNER JOIN Job_FrontEnd_Details ON[Job Applicants].JobPostID = Job_FrontEnd_Details.PostID " +
                        "WHERE [Job Applicants].UserID = ? AND [Job Applicants].Status = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        // Add the hunterID parameter
                        cmd.Parameters.AddWithValue("?", hunterID);
                        cmd.Parameters.AddWithValue("?", "REJECTED");

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

        internal DataTable? GetAcceptedApplications(int hunterID)
        {
            try
            {
                using (OleDbConnection myConn = new OleDbConnection(connectionString))
                {
                    string query = "SELECT  Job_FrontEnd_Details.CompanyName, Job_FrontEnd_Details.JobTitle FROM [Job Applicants] " +
                        "INNER JOIN Job_FrontEnd_Details ON [Job Applicants].JobPostID = Job_FrontEnd_Details.PostID " +
                        "WHERE [Job Applicants].UserID = ? AND [Job Applicants].Status = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        // Add the hunterID parameter
                        cmd.Parameters.AddWithValue("?", hunterID);
                        cmd.Parameters.AddWithValue("?", "ACCEPTED");
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

        internal DataTable? GetPendingApplications(int hunterID)
        {
            try
            {
                using (OleDbConnection myConn = new OleDbConnection(connectionString))
                {
                    string query = "SELECT  Job_FrontEnd_Details.CompanyName, Job_FrontEnd_Details.JobTitle FROM [Job Applicants] " +
                        "INNER JOIN Job_FrontEnd_Details ON [Job Applicants].JobPostID = Job_FrontEnd_Details.PostID " +
                        "WHERE [Job Applicants].UserID = ? AND [Job Applicants].Status IN ('APPLIED', 'REVIEWED', 'FOR CONSIDERATION', 'FOR INTERVIEW')";
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

    //DATA TRANSFER OBJECT (DTO) CLASS
    internal class JobPostData
    {
        public int PostID { get; set; }
        public string? Closing { get; set; }
        public string? CompanyName { get; set; }
        public string? JobTitle { get; set; }
        public string? JobType { get; set; }
        public string? Industry { get; set; }
        public string? Location { get; set; }
        public string? WorkMode { get; set; }
        public string? StartingSalary { get; set; }
        public int Vacancy { get; set; }
        public byte[]? Logo { get; set; }
    }

    //DATA STRUCTURES FOR ANALYTICS
    internal class JobPostAnalytics
    {
        public string? JobTitle { get; set; }
        public int TotalApplicants { get; set; }
        public int TargetHires { get; set; }
        public int NumOfAccepted { get; set; }
        public int NumOfRejected { get; set; }
        public int NumOfCancelled { get; set; }
    }

    internal class TotalMonthlyApplicants
    {
        public int TotalApplicants { get; set; }
        public string? Month { get; set; }
    }
}
