using System;
using System.Collections.Generic;

namespace Calendar.Classes
{
    public class DaySchedule
    {
        public IList<Activity> Activities { get; set; }

        public DateTime Date { get; set; }

        public string DayName { get; set; }

        private bool IsRestDay { get; set; }

        public DaySchedule(DateTime date)
        {
            Date = date;
            DayName = date.DayOfWeek.ToString();
        }
    }
}