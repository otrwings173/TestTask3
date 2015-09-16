using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calendar
{
    public partial class CalendarForm : Form
    {
        Calendar calendar;
        Timer timer = new Timer();

        public CalendarForm()
        {
            InitializeComponent();
            calendar = new Calendar();
            timer.Interval = 30000;
            timer.Tick += TimerElapsedHandler;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                calendar.SaveToFile();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TimerElapsedHandler(object sender, EventArgs e)
        {
            DoRemind();
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            try
            {
                calendar.LoadData();
                ShowValidEvents();
                SetReminders();
                timer.Enabled = true;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);

                var controls = this.Controls;
                foreach (Control control in controls)
                {
                    control.Enabled = false;
                }
            }
        }

        private void ShowValidEvents()
        {
            EventsForToday.Items.Clear();
            foreach (CalendarEntry item in calendar)
            {
                EventsForToday.Items.Add(item.ToString());
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int index = EventsForToday.SelectedIndex;
            calendar.DeleteRecordAt(index);
            ShowValidEvents();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            DateTime startDateTime = Calendar.GetSelectedDateTime(StartDate.Value, StartTime.Value);
            DateTime endDateTime = Calendar.GetSelectedDateTime(EndDate.Value, EndTime.Value);
            TimeSpan reminder = Reminders.GetReminder(RemindersBox.Text);

            if (Validate(-1, startDateTime, endDateTime))
            {
                calendar.CreateNewRecord(TitleBox.Text, startDateTime, endDateTime, reminder);
                ShowValidEvents();
            }
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            int index = EventsForToday.SelectedIndex;
            if (index < 0)
                return;

            DateTime startDateTime = Calendar.GetSelectedDateTime(StartDate.Value, StartTime.Value);
            DateTime endDateTime = Calendar.GetSelectedDateTime(EndDate.Value, EndTime.Value);
            TimeSpan reminder = Reminders.GetReminder(RemindersBox.Text);

            if (Validate(index, startDateTime, endDateTime))
            {
                calendar.ModifyRecordAt(index, TitleBox.Text, startDateTime, endDateTime, reminder);
                ShowValidEvents();
            }
        }

        private bool Validate(int index, DateTime startDateTime, DateTime endDateTime)
        {
            string errTxt = string.Empty;
            if ((errTxt = calendar.Validate(TitleBox.Text, startDateTime, endDateTime)) != string.Empty)
            {
                MessageBox.Show(errTxt, "Validation error");
                return false;
            }

            if ((errTxt = calendar.ValidateOverlappingDates(index, startDateTime, endDateTime)) != string.Empty)
            {
                if (MessageBox.Show(errTxt, "Validation error", MessageBoxButtons.YesNo) == DialogResult.No)
                    return false;
            }
            return true;
        }

        private void EventsForToday_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = EventsForToday.SelectedIndex;

            if (index < 0)
                return;

            CalendarEntry entry = calendar.GetDataAt(index);
            TitleBox.Text = entry.Title;
            StartDate.Value = entry.StartDate.Date;
            StartTime.Text = entry.StartDate.ToString("HH:mm");
            EndDate.Value = entry.EndDate.Date;
            EndTime.Text = entry.EndDate.ToString("HH:mm");
            RemindersBox.Text = Reminders.GetTxtReminder(entry.Reminder);
        }

        private void SetReminders()
        {
            List<string> reminders = Reminders.GetTxtReminders();
            foreach (string item in reminders)
            {
                RemindersBox.Items.Add(item);
            }
        }

        private void DoRemind()
        { 
            DateTime nowTmp = DateTime.Now;
            DateTime now = new DateTime(nowTmp.Year, nowTmp.Month, nowTmp.Day, nowTmp.Hour, nowTmp.Minute, 0);
            StringBuilder sb = new StringBuilder();

            foreach (CalendarEntry item in calendar)
            {
                bool isNotDefault = !(default(TimeSpan) == item.Reminder);
                if (isNotDefault && !item.Reminded && item.StartDate.Subtract(item.Reminder) == now)
                {
                    sb.AppendLine(string.Format("In {0} - {1}", Reminders.GetTxtReminder(item.Reminder), item.Title));
                    item.Reminded = true;
                }
            }
            if (sb.Length != 0)
                MessageBox.Show(sb.ToString(), "Reminder");
        }

        private void CalendarForm_Shown(object sender, EventArgs e)
        {
            DoRemind();
        }
    }
}
