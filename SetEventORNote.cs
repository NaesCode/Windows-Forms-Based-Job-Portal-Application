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
    public partial class SetEventORNote : Form
    {
        private DatabaseSupport dbSupport = new DatabaseSupport();
        private DateTime dateSet;
        private int UserID;
        private static string? UserType;

        public SetEventORNote(int userId, DateTime date, string? userType)
        {
            InitializeComponent();
            dateSet = date;
            UserID = userId;
            UserType = userType;
        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetEvent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(EventOrNote.Text))
            {
                dbSupport.InsertEventOrNote(UserID, EventOrNote.Text, dateSet, UserType);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
