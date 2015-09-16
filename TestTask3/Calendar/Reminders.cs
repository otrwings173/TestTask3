using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public static class Reminders
    {
        private static Dictionary<string, TimeSpan> reminders = new Dictionary<string, TimeSpan>();

        static Reminders()
        {
            reminders.Add("15 minutes", new TimeSpan(0, 0, 15, 0));
            reminders.Add("30 minutes", new TimeSpan(0, 0, 30, 0));
            reminders.Add("45 minutes", new TimeSpan(0, 0, 45, 0));
            reminders.Add("1 hour", new TimeSpan(0, 1, 0, 0));
            reminders.Add("2 hours", new TimeSpan(0, 2, 0, 0));
            reminders.Add("3 hours", new TimeSpan(0, 3, 0, 0));
            reminders.Add("4 hours", new TimeSpan(0, 4, 0, 0));
            reminders.Add("5 hours", new TimeSpan(0, 5, 0, 0));
            reminders.Add("6 hours", new TimeSpan(0, 6, 0, 0));
            reminders.Add("7 hours", new TimeSpan(0, 7, 0, 0));
            reminders.Add("8 hours", new TimeSpan(0, 8, 0, 0));
            reminders.Add("9 hours", new TimeSpan(0, 9, 0, 0));
            reminders.Add("10 hours", new TimeSpan(0, 10, 0, 0));
            reminders.Add("15 hours", new TimeSpan(0, 15, 0, 0));
            reminders.Add("20 hours", new TimeSpan(0, 20, 0, 0));
            reminders.Add("1 day", new TimeSpan(1, 0, 0, 0));
            reminders.Add("2 days", new TimeSpan(2, 0, 0, 0));
            reminders.Add("3 days", new TimeSpan(3, 0, 0, 0));
            reminders.Add("4 days", new TimeSpan(4, 0, 0, 0));
            reminders.Add("5 days", new TimeSpan(5, 0, 0, 0));
            reminders.Add("6 days", new TimeSpan(6, 0, 0, 0));
            reminders.Add("1 week", new TimeSpan(7, 0, 0, 0));
        }

        public static List<string> GetTxtReminders()
        {
            return new List<string>(reminders.Keys);
        }

        public static string GetTxtReminder(TimeSpan reminder)
        {
            string reminderTxt = reminders.FirstOrDefault(x => x.Value == reminder).Key;
            return reminderTxt;
        }
       
        public static TimeSpan GetReminder(string reminderTxt)
        {
            TimeSpan reminder;
            reminders.TryGetValue(reminderTxt, out reminder);

            return reminder;
        }
    }
}
