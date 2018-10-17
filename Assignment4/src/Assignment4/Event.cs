using System;
using System.Security.Cryptography.X509Certificates;

namespace Assignment4
{
    public class Event
    {
        public string Name { get; set; } // auto property
   
        public string Location { get; } //read only
       
        public string StartTime { get; set; }

        public Event(string name, string startTime, string location)
        {
            if (name == null || startTime == null || location == null)
                throw new ArgumentNullException();

            if(name.Equals("") || startTime.Equals("") || location.Equals(""))
                throw new ArgumentOutOfRangeException();

            this.Name = name;
            this.StartTime = startTime;
            this.Location = location;
        }

    }
}