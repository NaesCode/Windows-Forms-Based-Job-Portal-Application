using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        internal void checkConnection()
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

            string registerQuery = "INSERT INTO AccountReg_Details (Email, Username, [Password]) values (?, ?, ?)"; 
            cmd = new OleDbCommand(registerQuery, myConn);
            cmd.Parameters.AddWithValue("?", Email);
            cmd.Parameters.AddWithValue("?", Username);
            cmd.Parameters.AddWithValue("?", Password);
            cmd.ExecuteNonQuery();
            myConn.Close();

            //cmd = new OleDbCommand("SELECT MAX(ID) FROM AccountReg_Details", myConn); //Gets last inserted StudentID and uses it to the other tables
            //int userID = Convert.ToInt32(cmd.ExecuteScalar());
        }

        internal void registerCompanyData(string Email, string Username, string Password)
        {
            myConn = new OleDbConnection(connectionString);
            myConn.Open();

            string registerQuery = "INSERT INTO CompanyAccounts (CompanyEmail, CompanyName, [Password]) values (?, ?, ?)";
            cmd = new OleDbCommand(registerQuery, myConn);
            cmd.Parameters.AddWithValue("?", Email);
            cmd.Parameters.AddWithValue("?", Username);
            cmd.Parameters.AddWithValue("?", Password);
            cmd.ExecuteNonQuery();
            myConn.Close();

            //cmd = new OleDbCommand("SELECT MAX(ID) FROM AccountReg_Details", myConn); //Gets last inserted StudentID and uses it to the other tables
            //int userID = Convert.ToInt32(cmd.ExecuteScalar());
        }

        internal bool AuthenticateHunter(string username, string password)
        {
            string query = "SELECT * FROM [Log-In_Query] WHERE Username = ? AND [Password] = ?";

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
            string query = "SELECT * FROM [Log-InCompany_Query] WHERE CompanyEmail = ? AND [Password] = ?";

            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(query, myConn))
            {
                cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar)).Value = email;
                cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar)).Value = password;
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

        internal bool isValidEmail(string email)
        {
            string query = "SELECT * FROM [AccountReg_Details] WHERE Email = ?";

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

        internal string? GetUserNameByEmail(string email)
        {
            string query = "SELECT Username FROM [AccountReg_Details] WHERE Email = ?";

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

        internal void changePassword(string newPassword, string? UserEmail)
        {
            if (string.IsNullOrEmpty(UserEmail))
            {
                MessageBox.Show("Invalid email provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Query = "Update [AccountReg_Details] Set [Password] = ? Where Email = ?";
            using (myConn = new OleDbConnection(connectionString))
            using (cmd = new OleDbCommand(Query, myConn))
            {
                myConn.Open();
                cmd.Parameters.AddWithValue("?", newPassword);
                cmd.Parameters.AddWithValue("?", UserEmail);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
