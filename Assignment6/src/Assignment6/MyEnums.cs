using System;

namespace Assignment6
{
    public class MyEnums
    {
        [Flags]
        public enum WeekDays : byte
        {
            Monday = 1 << 0,
            Tuesday = 1 << 1,
            Wednesday = 1 << 2,
            Thursday = 1 << 3,
            Friday = 1 << 4,
            Saturday = 1 << 5,
            Sunday = 1 << 6 
        }

        public enum Seasons : byte
        {
            Fall, 
            Winter,  
            Spring,  
            Summer  
        }

        public static void AddSeason(string str, ref Seasons season)
        {
            str = str.ToLower();
            switch (str)
            {
                case "fall":
                    season = Seasons.Fall;
                    break;
                case "winter":
                    season = Seasons.Winter;
                    break;
                case "spring":
                    season = Seasons.Spring;
                    break;
                case "summer":
                    season = Seasons.Summer;
                    break;
            }
        }
        public static void AddWeekDays(string str, ref WeekDays weekDays)
        {
            str = str.ToLower();

            var strings = str.Split(" ");

            foreach (var item in strings)
            {
                switch (item)
                {
                    case "monday":
                        weekDays |= WeekDays.Monday;
                        break;
                    case "tuesday":
                        weekDays |= WeekDays.Tuesday;
                        break;
                    case "wednesday":
                        weekDays |= WeekDays.Wednesday;
                        break;
                    case "thursday":
                        weekDays |= WeekDays.Thursday;
                        break;
                    case "friday":
                        weekDays |= WeekDays.Friday;
                        break;
                    case "saturday":
                        weekDays |= WeekDays.Saturday;
                        break;
                    case "sunday":
                        weekDays |= WeekDays.Sunday;
                        break;
                }
            }
        }

        public struct Time
        {
            public byte Hour { get; }
            public byte Minute { get; }
            public byte Second { get; }

            public Time(byte hour, byte minute, byte second)
            {
                Hour = hour;
                Minute = minute;
                Second = second;
            }
        }

        public struct Schedule
        {
            public WeekDays DaysOfWeek;
            public Seasons Quarter;
            public Time StartTime { get; }
            public TimeSpan Duration { get;}

            public Schedule(byte hours, byte min, byte sec)
            {
                DaysOfWeek = WeekDays.Monday | WeekDays.Tuesday | WeekDays.Wednesday | WeekDays.Thursday |
                             WeekDays.Friday;
                Quarter = Seasons.Fall;
                StartTime = new Time(hours, min, sec);
                Duration = new TimeSpan();
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
