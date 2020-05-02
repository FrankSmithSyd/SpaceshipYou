using System;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Calendar.Classes;



namespace Database
{
    public class CalendarContext : DbContext
    {
        public CalendarContext(DbContextOptions<CalendarContext> options) : base(options)
        {
            
        }

        public DbSet<Activity> Activities { get; set; }
        
        public DbSet<ActivityType> ActivityTypes { get; set; }
        
        public DbSet<DaySchedule> DaySchedules { get; set; }
    }
}