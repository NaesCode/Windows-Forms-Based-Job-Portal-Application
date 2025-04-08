using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Manager
{
    public partial class CalendarView : BaseControl //dli pani sure nga inheritance
    {
        public static int _year, _month;
        public CalendarView()
        {
            InitializeComponent();
        }

        private void CalendarView_Load(object sender, EventArgs e)
        {
            ShowDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void ShowDays(int month, int year)
        {
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.Controls.Clear();

            _year = year;
            _month = month;

            // Display month and year
            MonthLabel.Text = $"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month).ToUpper()} {year}";

            // Calculate starting day and total days in the month
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int totalDaysInMonth = DateTime.DaysInMonth(year, month);
            int startDayOfWeek = (int)startOfTheMonth.DayOfWeek;

            // Add empty placeholders for previous month days
            for (int i = 0; i < startDayOfWeek; i++)
            {
                flowLayoutPanel1.Controls.Add(new calendarDays(string.Empty));
            }

            // Add actual day controls
            for (int i = 1; i <= totalDaysInMonth; i++)
            {
                flowLayoutPanel1.Controls.Add(new calendarDays(i.ToString()));
            }

            flowLayoutPanel1.ResumeLayout();
        }

        private void nextMonth_Click(object sender, EventArgs e)
        {
            if (++_month > 12)
            {
                _month = 1;
                _year++;
            }
            ShowDays(_month, _year);
        }

        private void prevMonth_Click(object sender, EventArgs e)
        {
            if (--_month < 1)
            {
                _month = 12;
                _year--;
            }
            ShowDays(_month, _year);
        }
    }
}
