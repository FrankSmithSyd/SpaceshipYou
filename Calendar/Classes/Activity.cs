using System;

namespace Calendar.Classes
{
    public class Activity
    {
        public DateTime Start { get; }

        public DateTime End { get; }

        public string Name { get; }

        public string Description { get; }


        public Activity(
            DateTime start,
            DateTime end,
            string name,
            string description)
        {
            Start = start;
            End = end;
            Name = name;
            Description = description;
        }
    }
}