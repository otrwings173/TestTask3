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
        public CalendarForm()
        {
            InitializeComponent();
            calendar = new Calendar();
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

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            try
            {
                calendar.LoadData();
                ShowValidEvents();
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

            if (Validate(-1, startDateTime, endDateTime))
            {
                calendar.CreateNewRecord(TitleBox.Text, startDateTime, endDateTime);
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

            if (Validate(index, startDateTime, endDateTime))
            {
                calendar.ModifyRecordAt(index, TitleBox.Text, startDateTime, endDateTime);
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
    }
}
