using System.ComponentModel.DataAnnotations;
using System.Linq;
using Calendar.Classes;

namespace Calendar.Validators
{
    public static class SetupScheduleValidator
    {
        public static void CheckNewActivityDoesNotConflict(DaySchedule schedule, Activity newActivity)
        {
            if (schedule.Activities.Any(activity => newActivity.Start >= activity.Start && newActivity.End <= activity.End))
            {
                throw new ValidationException("Activity conflict; there is already a activity scheduled at this time.");
            }
        }
    }
}