namespace Assignment5
{
    public class UniversityCourse: Gathering
    {
        public string Schedule { get; set; }

        private int _Credits;
        public int Credits
        {
            get { return _Credits; }
            set
            {
                if (value < 1)
                    _Credits = 0;

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
    }
}