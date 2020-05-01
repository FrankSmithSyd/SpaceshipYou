using System.ComponentModel.DataAnnotations;
using Calendar.Classes;
using Calendar.Validators;
using Xunit;

namespace Tests.Validators
{
    public class CheckNewActivityDoesNotConflictShould : BaseSetupScheduleValidatorShould
    {
        [Fact]
        public void AllowNonConflictingActivity()
        {
            var schedule = Setup();
            var existingActivity = new Activity(
                    schedule.Date, 
                    schedule.Date.AddHours(1),
                    "dance",
                    "do the dance",
                ActivityType.Exercise);
            
            schedule.Activities.Add(existingActivity);
            
            
            var newActivity = new Activity(
                schedule.Date.AddHours(2), 
                schedule.Date.AddHours(3),
                "fly",
                "do the fly",
                ActivityType.Exercise);
            
            SetupScheduleValidator.CheckNewActivityDoesNotConflict(schedule, newActivity);
        }
        
        [Fact]
        public void ThrowException_WhenConflictingActivity()
        {
            var schedule = Setup();
            var existingActivity = new Activity(
                schedule.Date, 
                schedule.Date.AddHours(1),
                "dance",
                "do the dance",
                ActivityType.Exercise);
            
            schedule.Activities.Add(existingActivity);
            
            
            var newActivity = new Activity(
                schedule.Date, 
                schedule.Date.AddHours(1),
                "fly",
                "do the fly",
                ActivityType.Exercise);
            
            Assert.Throws<ValidationException>(() => SetupScheduleValidator.CheckNewActivityDoesNotConflict(schedule, newActivity));
        }
    }
}