using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Calendar
{
    public class CalendarEntry : IComparable<CalendarEntry>
    {
        const int titleLength = 50;

        public string Title
        { get; set; }

        public DateTime StartDate
        { get; set; }

        public DateTime EndDate
        { get; set; }

        public CalendarEntry(string title, DateTime StartDate, DateTime EndDate)
        {
            Title = title;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }

        static public string ValidateTitle(string title)
        {
            string errTxt = string.Empty;

            if (title == string.Empty)
                errTxt = string.Format("Title cannot be empty");

            if (title.Length > titleLength)
                errTxt = string.Format("Title cannot be longer than {0} symbols.", titleLength);
            return errTxt;
        }

        static public string ValidateStartDate(DateTime startDate)
        {
            string errTxt = string.Empty;
   
            if (startDate < DateTime.Today)
                errTxt = "Event cannot start earlier than today.";

            return errTxt;
        }

        static public string ValidateEndDateAgainstStartDate(DateTime startDate, DateTime endDate)
        {
            string errTxt = string.Empty;

            if (endDate < startDate)
                errTxt = @"""End Time"" cannot be earlier than ""Sart Time"".";

            return errTxt;
        }

        public string ValidateOverlappingDates(DateTime selectedStartDate, DateTime selectedEndDate)
        {
            string errTxt = string.Empty;

            if (((selectedStartDate >= StartDate) && (selectedStartDate <= EndDate))||((selectedEndDate >= StartDate) && (selectedEndDate <= EndDate)))
                errTxt = "Current event overlaps with another events in your calendar. Would you like to save it anyway?";

            return errTxt;
        }

        public override string ToString()
        {
            string startTime = StartDate.ToString("HH:mm");
            string startDate = StartDate.ToString("dd.MM");
            string endTime = EndDate.ToString("HH:mm");
            string endDate = EndDate.ToString("dd.MM");
            return string.Format("{0}/{1} till {2}/{3} - {4}", startTime, startDate, endTime, endDate, Title);
        }

        public override bool Equals(object obj)
        {
            CalendarEntry entry = obj as CalendarEntry;
            if (entry == null)
                return false;

            if ((Title == entry.Title) && (StartDate == entry.StartDate) && (EndDate == entry.EndDate))
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string CalendarEntryToFileLine()
        {
            string startDateTxt = StartDate.ToString("dd-MM-yyyy");
            string startTimeTxt = StartDate.ToString("HH:mm");
            string endDateTxt = EndDate.ToString("dd-MM-yyyy");
            string endTimeTxt = EndDate.ToString("HH:mm");
            string fileLine = Title + "%" + startDateTxt + " " + startTimeTxt + "%" + endDateTxt + " " + endTimeTxt;
            return fileLine;
        }

        public int CompareTo(CalendarEntry other)
        {
            if (StartDate > other.StartDate) 
                return 1;
            else if (StartDate < other.StartDate)
                return -1;
            else 
                return 0;
        }
    }
}
