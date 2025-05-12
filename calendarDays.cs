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
    public partial class calendarDays : BaseControl
    {
        private int dayNumber;
        private DateTime date;
        private bool isNoted;
        private static string? UserType;
        private int UserID;

        public calendarDays(int userId, string day, string? userType)
        {
            InitializeComponent();
            UserID = userId;
            UserType = userType;
            isNoted = false;
            checkBox1.Hide();
            deleteNote.Visible = false;

            if (int.TryParse(day, out dayNumber) && dayNumber > 0)
            {
                date = new DateTime(CalendarView._year, CalendarView._month, dayNumber);
                Day.Text = day;

                MarkToday();
                MarkSunday();
                CheckIfNoted();
            }
            else
            {
                Day.Text = "";
                this.Enabled = false; // disable interaction for blank days
            }
        }

        private void MarkToday()
        {
            if (date.Day == DateTime.Now.Day)
            {
                this.BackColor = Color.DarkGray;
            }
        }

        private void MarkSunday()
        {
            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                Day.ForeColor = Color.IndianRed;
            }
        }

        private void CheckIfNoted()
        {
            // Check if a note exists in DB
            isNoted = dbSupport.HasNoted(UserID, date, UserType); 
            if (isNoted)
            {
                if (UserType == "Job Hunter")
                {
                    this.BackColor = Color.IndianRed;
                }
                else
                {
                    this.BackColor = Color.FromArgb(13, 59, 141);
                }
                deleteNote.Visible = true;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (!isNoted)
            {
                if (UserType == "Job Hunter")
                {
                    checkBox1.Checked = !checkBox1.Checked;
                    this.BackColor = checkBox1.Checked ? Color.IndianRed : Color.White;
                }
                else
                {
                    checkBox1.Checked = !checkBox1.Checked;
                    this.BackColor = checkBox1.Checked ? Color.FromArgb(13, 59, 141) : Color.White;
                }
            }
            else
            {
                string? message = dbSupport.GetEventOrNote(UserID, date, UserType);
                if (!string.IsNullOrEmpty(message))
                {
                    MessageBox.Show(message, "Event or Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            var setEvent = new SetEventORNote(UserID, date, UserType);
            if (setEvent.ShowDialog() == DialogResult.OK)
            {
                isNoted = true;
                if (UserType == "Job Hunter")
                {
                    this.BackColor = Color.IndianRed;
                }
                else
                {
                    this.BackColor = Color.FromArgb(13, 59, 141);
                }
                deleteNote.Visible = true;
            }
        }

        private void deleteNote_Click(object sender, EventArgs e)
        {
            isNoted = false;
            this.BackColor = Color.White;
            deleteNote.Visible = false;
            dbSupport.DeleteEventOrNote(HunterID, date, UserType);
        }
    }
}
