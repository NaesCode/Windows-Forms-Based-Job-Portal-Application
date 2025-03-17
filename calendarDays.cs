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
        string _day, date, weekday;
        public calendarDays(string day)
        {
            InitializeComponent();
            _day = day;
            Day.Text = _day;
            checkBox1.Hide();
            date =  CalendarView._month + "-" + _day + "-" + CalendarView._year;

        }

        private void Sundays()
        {
            try
            {
                DateTime day = DateTime.Parse(date);
                weekday = day.ToString("ddd");
                if (weekday == "Sunday")
                {
                    Day.ForeColor = Color.IndianRed;
                }
                else
                {
                    Day.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                this.BackColor = Color.FromArgb(255, 255, 192);
            }
            else
            {
                checkBox1.Checked = false;
                this.BackColor = Color.FromArgb(255, 255, 255);
            }
        }
    }
}
