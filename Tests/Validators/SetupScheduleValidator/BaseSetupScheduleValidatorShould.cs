using System;
using Calendar.Classes;

namespace Tests.Validators
{
    public class BaseSetupScheduleValidatorShould
    {
        public DaySchedule Setup()
        {
            var scheduleStart = new DateTime(2020, 1, 1);
            var desc = "Schedule Desc";
            var daySchedule = new DaySchedule(scheduleStart, desc);
            

            return daySchedule;
        }

        public ActivityType SetupActivityType()
        {
            return new ActivityType("Activity Type Name");
        }
    }
}