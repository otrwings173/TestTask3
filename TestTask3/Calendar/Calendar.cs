using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Calendar
{
    public class Calendar : IEnumerable<CalendarEntry>
    {
        const string fileName = "Calendar.txt";
        private List<CalendarEntry> entries = new List<CalendarEntry>();
        private List<CalendarEntry> validEntries = new List<CalendarEntry>();

        public void DeleteRecordAt(int index)
        {
            if (index >= 0)
                validEntries.RemoveAt(index);
        }

        public void ModifyRecordAt(int index, string title, DateTime startDateTime, DateTime endDateTime)
        {
            validEntries[index].Title = title;
            validEntries[index].StartDate = startDateTime;
            validEntries[index].EndDate = endDateTime;
            validEntries.Sort();
        }

        public CalendarEntry GetDataAt(int index)
        {
            return validEntries[index];
        }

        public void CreateNewRecord(string title, DateTime startDateTime, DateTime endDateTime)
        {
            CalendarEntry entry = new CalendarEntry(title, startDateTime, endDateTime);
            validEntries.Add(entry);
            validEntries.Sort();
        }

        public void LoadData()
        {
            LoadFileData();
            DetermineValidData();
        }

        private void LoadFileData()
        {
            using (FileStream fs = File.Open(fileName, FileMode.OpenOrCreate))
            {
                StreamReader sr = new StreamReader(fs);
                string txt = null;
                while (!sr.EndOfStream)
                {
                    txt = sr.ReadLine();
                    if (txt != string.Empty)
                    {
                        CalendarEntry entry = DecodeLine(txt);
                        entries.Add(entry);
                    }
                }
            }
        }

        private void DetermineValidData()
        {
            foreach (CalendarEntry item in entries)
            {
                if (item.EndDate.Date >= DateTime.Today)
                    validEntries.Add(item);
            }

            foreach (CalendarEntry item in validEntries)
            {
                entries.Remove(item);
            }

            validEntries.Sort();
        }

        private CalendarEntry DecodeLine(string txt)
        {
            CalendarEntry entry = null;
            string[] splitted = txt.Split('%');
            string pattern = "dd-MM-yyyy HH:mm";
            DateTime startDateTime;
            DateTime endDateTime;

            if ((DateTime.TryParseExact(splitted[1], pattern, null, DateTimeStyles.None, out startDateTime)) && (DateTime.TryParseExact(splitted[2], pattern, null, DateTimeStyles.None, out endDateTime)))
            {
                string title = splitted[0];
                entry = new CalendarEntry(title, startDateTime, endDateTime);
            }
            return entry;
        }

        public void SaveToFile()
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                List<CalendarEntry> tmp = new List<CalendarEntry>(entries);
                foreach (CalendarEntry entry in validEntries)
                {
                    tmp.Add(entry);
                }

                foreach (CalendarEntry entry in tmp)
                {
                    string fileLine = entry.CalendarEntryToFileLine();
                    sw.WriteLine(fileLine);
                }
            }
        }

        public string ValidateOverlappingDates(int index, DateTime selectedStartDate, DateTime selectedEndDate)
        {
            string errTxt = string.Empty;
            List<CalendarEntry> tmp = new List<CalendarEntry>(validEntries);
            if (index >= 0)
            {
                tmp.RemoveAt(index);
            }

            foreach (CalendarEntry entry in tmp)
            {
                if ((errTxt = entry.ValidateOverlappingDates(selectedStartDate, selectedEndDate)) != string.Empty)
                    break;
            }
            return errTxt;
        }

        public string Validate(string title, DateTime startDate, DateTime endDate)
        {
            string errTxt = string.Empty;
            if ((errTxt = CalendarEntry.ValidateTitle(title)) != string.Empty)
                return errTxt;
            if ((errTxt = CalendarEntry.ValidateStartDate(startDate)) != string.Empty)
                return errTxt;
            if ((errTxt = CalendarEntry.ValidateEndDateAgainstStartDate(startDate, endDate)) != string.Empty)
                return errTxt;

            return errTxt;
        }

        static public DateTime GetSelectedDateTime(DateTime selectedDate, DateTime selectedTime)
        {
            return new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, selectedTime.Hour, selectedTime.Minute, 0);
        }

        IEnumerator<CalendarEntry> IEnumerable<CalendarEntry>.GetEnumerator()
        {
            return validEntries.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return validEntries.GetEnumerator();
        }
    }
}
