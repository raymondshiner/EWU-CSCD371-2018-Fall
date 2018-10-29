using System;

namespace Assignment5
{
    public static class MyDisplay
    {
        public static void Display(Object o)
        {
            MyConsole console = new MyConsole();
            string check = "";
            string str;
            switch (@o)
            {
                case Event myEvent:
                    check = myEvent?.GetSummaryInformation();
                    str = check.Equals("") ? myEvent.ToString() : myEvent.GetSummaryInformation();
                    console.WriteLine(str);
                    break;
                case UniversityCourse myUniversityCourse:
                    check = myUniversityCourse?.GetSummaryInformation();
                    str = check.Equals("") ? myUniversityCourse.ToString() : myUniversityCourse.GetSummaryInformation();
                    console.WriteLine(str);
                    break;
                default:
                    console.WriteLine(o.ToString());
                    break;
            }
        }
    }
}