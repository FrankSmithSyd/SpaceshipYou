using System;
using System.Collections.Generic;

namespace Calendar.Classes
{
    public class DaySchedule
    {
        public IList<Activity> Activities { get; set; }

        public DateTime Date { get; set; }

        public string DayName { get; set; }

        public string Description { get; set; }

        public DaySchedule(DateTime date, string description)
        {
            Date = date;
            DayName = date.DayOfWeek.ToString();
            Activities = new List<Activity>();
        }
    }
}