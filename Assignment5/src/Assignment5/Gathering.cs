namespace Assignment5
{
    public abstract class Gathering
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public static int InstantiationCount { get; set; }

        public Gathering()
        {
            Name = "Gathering";
            Location = "Seattle";
            InstantiationCount++;
        }

        public Gathering(string name, string location)
        {
            if (name == null || name.Equals(""))
                name = "Gathering";
            if (location == null || location.Equals(""))
                location = "Seattle";

            Name = name;
            Location = location;
        }

        public abstract void GetSummaryInformation();
    }
}
