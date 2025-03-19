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
    public partial class calendarDays : UserControl
    { 
        private int dayNumber;
        private DateTime date;
        public calendarDays(string day)
        {
            InitializeComponent();

            // Initialize day number
            if (int.TryParse(day, out dayNumber) && dayNumber > 0)
            {
                date = new DateTime(CalendarView._year, CalendarView._month, dayNumber);
                Day.Text = day;
            }
            else
            {
                Day.Text = "";
            }

            checkBox1.Hide();
            Sundays();

        }

        private void Sundays()
        {
            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                Day.ForeColor = Color.IndianRed;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = !checkBox1.Checked;
            this.BackColor = checkBox1.Checked ? Color.FromArgb(255, 255, 192) : Color.White;
        }
    }
}
