using System;
using System.Diagnostics;
using Xunit;
using Calendar;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void HaveAllProperties()
        {
            var start = new DateTime(2020, 1, 1, 9, 0, 0);    // YY-MM-DD-HH-MM-SS
            var end = new DateTime(2020, 1, 1, 11, 0, 0);    // YY-MM-DD-HH-MM-SS
            var name = "ActivityName";
            var desc = "ActivityDescription";
            var activity = new Calendar.Activity(start, end, name, desc);

            Assert.Equal(activity.Start, start);
            Assert.Equal(activity.End, end);
            Assert.Equal(activity.Name, name);
            Assert.Equal(activity.Description, desc);
        }
    }
}