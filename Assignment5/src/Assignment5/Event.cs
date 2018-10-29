
namespace Assignment5
{
    public class Event : Gathering
    {
        public string Title => $"{Name}@{Location}";

        public string Time { get; set; } 

        public Event()
            : base("Event", "Seattle")
        {
            Time = "12:00pm - 1:00pm";
        }

        public Event(string name, string location, string time)
        {
            if (name == null || name.Equals(""))
                name = "Event";
            if (location == null || location.Equals(""))
                location = "Seattle";
            if (time == null || time.Equals(""))
                time = "12:00pm - 1:00pm";

            this.Name = name;
            this.Location = location;
            Time = time;
        }

        public void GetSummaryInformation()
        {
            
        }
    }


}
