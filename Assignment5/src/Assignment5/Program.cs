using System;
using System.Collections.Generic;

namespace Assignment5
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyConsole console = new MyConsole();
            console.WriteLine("Welcome to the Program");
            int choice = 0;
            List<Gathering> myList = new List<Gathering>();

            do
            {
                choice = GetIntFromUser($@"
1) Create and Event
2) List Created Events
3) Quit
Choice: ", console);

                switch (choice)
                {
                    case 1:
                        Gathering myGathering = CreateGathering(console);
                        myList.Add(myGathering);
                        break;
                    case 2:
                        PrintList(myList, console);
                        break;
                    case 3:
                        break;
                    default:
                        console.WriteLine("ERROR - Please enter a valid number");
                        break;
                }
            } while (choice != 3);
        }

        public static void PrintList(List<Gathering> myList, MyConsole console)
        {
            foreach (var x in myList)
            {
                console.WriteLine("");
                console.WriteLine(x.GetSummaryInformation());
            }
        }


        public static Gathering CreateGathering(MyConsole console)
        {
            var choice = GetUserChoiceFromTwoChoices("Create a University Course", "Create a One-Time Event", console);
            var type = choice == 1 ? "University Course" : "Event";
            var name = GetStringFromUser($"Please enter a Name for your {type}: ", console);
            var location = GetStringFromUser($"Please enter a location for your {type}: ", console);
            Gathering myGathering;

            switch (choice)
            {
                case 1: // course
                    string schedule =
                        GetStringFromUser("Please enter the Schedule for your University Course: ",
                            console);
                    int credits =
                        GetIntFromUser(
                            "Please enter the number of Credits for your University Course (1-5 Credits only): ",
                            console);
                    myGathering = new UniversityCourse(name, location, schedule, credits);
                    break;
                default: //event
                    var time = GetStringFromUser("Please enter a Time for your Event", console);
                    myGathering = new Event(name, location, time);
                    break;
            }

            return myGathering;
        }



        public static string GetStringFromUser(string prompt, MyConsole console)
        {
            console.WriteLine(prompt);
            string str = console.ReadLine();
            console.WriteLine("");
            return str;
        }

        public static int GetIntFromUser(string prompt, MyConsole console)
        {
            console.Write(prompt);
            string str = console.ReadLine();
            int credits;
            Int32.TryParse(str, out credits);
            return credits;
        }

        public static int GetUserChoiceFromTwoChoices(string choice1, string choice2, MyConsole console)
        {
            int choice;

            do
            {
                console.WriteLine("Please Select a Choice: ");
                console.WriteLine($"1) {choice1}");
                console.WriteLine($"2) {choice2}");
                console.Write("Choice: ");

                string str = console.ReadLine();
                Int32.TryParse(str, out choice);

                if (choice != 1 && choice != 2)
                    console.WriteLine("ERROR - Please enter a valid choice");

            } while (choice != 1 && choice != 2);

            console.WriteLine("");
            return choice;
        }
    }
}
