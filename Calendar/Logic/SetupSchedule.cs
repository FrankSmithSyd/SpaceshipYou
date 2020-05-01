using System;
using Calendar.Classes;
using Calendar.Validators;
using Activity = Calendar.Classes.Activity;

namespace Calendar.Logic
{
    public class SetupSchedule
    {
        public void SetupScheduleForDay(DateTime startDate, string description)
        {
            var dailySchedule = new DaySchedule(startDate, description);
        }

        public void AddActivityToDailySchedule(DaySchedule schedule, Activity activity)
        {
            SetupScheduleValidator.CheckNewActivityDoesNotConflict(schedule, activity);
            schedule.Activities.Add(activity);
        }
        
    }
}