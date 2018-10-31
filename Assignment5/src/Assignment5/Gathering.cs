using System.Reflection.Metadata.Ecma335;

namespace Assignment5
{
    public abstract class Gathering : IEvent
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int InstantiationCount { get; private set; }
        
        public static void ResetInstantiationCount()
        {
           
        }

        public abstract string GetSummaryInformation();
    }
}
