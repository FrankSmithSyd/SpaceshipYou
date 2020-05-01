using System;

namespace Calendar.Classes
{
    public class Activity
    {
        public DateTime Start { get; }

        public DateTime End { get; }

        public string Name { get; }

        public string Description { get; }

        public ActivityType ActivityType { get; }

        public Activity(
            DateTime start,
            DateTime end,
            string name,
            string description,
            ActivityType activityType)
        {
            Start = start;
            End = end;
            Name = name;
            Description = description;
            ActivityType = activityType;
        }
    }
}