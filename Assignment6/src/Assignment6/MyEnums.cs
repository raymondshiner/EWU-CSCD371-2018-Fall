using System;

namespace Assignment6
{
    public class MyEnums
    {
        [Flags]
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public enum Seasons
        {
            Fall,
            Winter,
            Spring,
            Summer
        }

        struct Time
        {
            public (int hour, int minute, int second) TimeValue;
        }

        struct Schedule
        {
            public WeekDays DayOfWeek;
            public Seasons Quarter;
            public Time StartTime;
            public TimeSpan Duration;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
