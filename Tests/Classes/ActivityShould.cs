using System;
using System.Diagnostics;
using Calendar.Classes;
using Xunit;
using Activity = Calendar.Classes.Activity;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void HaveAllProperties()
        {
            var start = new DateTime(2020, 1, 1, 9, 0, 0);    // YYYY-MM-DD-HH-MM-SS
            var end = new DateTime(2020, 1, 1, 11, 0, 0);
            var name = "ActivityName";
            var desc = "ActivityDescription";
            var activityType = new ActivityType("Bla");
            
            var activity = new Activity(start, end, name, desc, activityType);

            Assert.Equal(activity.Start, start);
            Assert.Equal(activity.End, end);
            Assert.Equal(activity.Name, name);
            Assert.Equal(activity.Description, desc);
            Assert.Equal(activity.ActivityType, activityType);
        }
    }
}