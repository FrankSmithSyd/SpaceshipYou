using System;
using System.Diagnostics;
using Xunit;
using DaySchedule = Calendar.Classes.DaySchedule;

namespace Tests
{
    public class DayScheduleShould
    {
        [Fact]
        public void HaveProperties()
        {
            var date = new DateTime(2020, 1, 1);
            var daySchedule = new DaySchedule(date);
            
            Assert.Equal(date, daySchedule.Date);
        }
        
        [Fact]
        public void SetDayName_DuringConstruction()
        {
            var date = new DateTime(2020, 1, 1);
            var daySchedule = new DaySchedule(date);
            
            Assert.Equal("Wednesday", daySchedule.DayName);
        }
    }
}