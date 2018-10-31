using System;

namespace Assignment5
{
    public interface IEvent
    {
        string Name { get; set; }
    }

    public static class IEventExtensions
    {
        public static string GetLengthOfName(this IEvent myEvent)
        {
            int num = myEvent.Name.Length;
            return $"Name is {num} Characters Long";
        }
    }
}
