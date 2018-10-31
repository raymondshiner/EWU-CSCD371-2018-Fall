using System.Reflection.Metadata.Ecma335;

namespace Assignment5
{
    public abstract class Gathering : IEvent
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public static int InstantiationCount { get; private set; }
        
        public static void ResetInstantiationCount()
        {
            InstantiationCount = 0;
        }

        public abstract string GetSummaryInformation();
    }
}
