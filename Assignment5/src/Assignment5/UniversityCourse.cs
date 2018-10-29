namespace Assignment5
{
    public class UniversityCourse: Gathering
    {
        public string Schedule { get; set; }

        private int _Credits;
        public int Credits
        {
            get => _Credits;
            set
            {
                if (value < 1)
                    _Credits = 1;

                else if (value > 5)
                    _Credits = 5;

                else
                    _Credits = value;
            }
        }

        public UniversityCourse()
           : base("Elective Course", "Eastern Washington University")
        {
            Credits = 5;
            Schedule = "TBD";
        }

        public UniversityCourse(string name, string location, string schedule, int credits)
        {
            if (name == null || name.Equals(""))
                name = "Elective Course";
            if (location == null || location.Equals(""))
                location = "Eastern Washington University";
            if (schedule == null || schedule.Equals(""))
                schedule = "TBD";

            Name = name;
            Location = location;
            Schedule = schedule;
            Credits = credits;
        }

        public string GetSummaryInformation()
        {
            
        }
    }
}