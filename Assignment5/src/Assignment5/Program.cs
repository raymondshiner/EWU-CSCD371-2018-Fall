using System;
using System.Collections.Generic;
using System.Data;
using Assignment5;

namespace Assignment5
{ 
    class Program
    {
        static void Main(string[] args)
        {
            MyConsole console = new MyConsole();
            console.WriteLine("Welcome to the Program");
            int choice = 0;
            List<Gathering> myList = new List<Gathering>();

            do
            {
                console.WriteLine("");
                console.WriteLine("1) Create and Event");
                console.WriteLine("2) List Created Events");
                console.WriteLine("3) Quit");
                console.Write("Choice: ");

                string str = Console.ReadLine();
                Int32.TryParse(str, out choice);

                switch (choice)
                {
                    case 1:
                        CreateEvent(ref myList, console);
                        break;
                    case 2:
                        PrintList(ref myList, console);
                        break;
                    case 3:
                        break;
                    default:
                        console.WriteLine("ERROR - Please enter a valid number");
                        break;
                }

            } while (choice != 3);
        }

        private static void PrintList(ref List<Gathering> myList, MyConsole console)
        {
            foreach (var x in myList)
            {
                console.WriteLine(x.ToString());
            }

            console.WriteLine(myList.ToString());
        }

        private static void CreateEvent(ref List<Gathering> myList, MyConsole console)
        {
            int choice;

            do
            {
                console.WriteLine("Please Select a Choice: ");
                console.WriteLine("1) Create a University Course");
                console.WriteLine("2) Create a One-Time Event");
                console.Write("Choice: ");

                string str = Console.ReadLine();
                Int32.TryParse(str, out choice);

                if (choice != 1 && choice != 2)
                    console.WriteLine("ERROR - Please enter a valid choice");

            } while (choice != 1 && choice != 2);

            string type;

            if (choice == 1)
                type = "University Course";
            else
                type = "Event";

            console.Write($"Please enter a Name for your {type}: ");
            string name = Console.ReadLine();
            console.WriteLine("");

            console.Write($"Please enter a location for your {type}: ");
            string location = Console.ReadLine();
            console.WriteLine("");

            if (choice == 1) //univeristy course
            {
                console.Write("Please enter the Schedule for your University Course");
                string schedule = Console.ReadLine();
                console.WriteLine("");

                int credits;
                do
                {
                    console.Write("Please enter the number of Credits for your University Course (1-5 Credits only): ");
                    string str = Console.ReadLine();
                    Int32.TryParse(str, out credits);
                    console.WriteLine("");
                    
                } while (credits > 5 || credits < 1);

                UniversityCourse newCourse = new UniversityCourse(name, location, schedule, credits);
                myList.Add(newCourse);
            }

            else // choice == 2
            {
                console.Write("Please enter the time for your Event");
                string time = Console.ReadLine();
                console.WriteLine("");

                Event newEvent = new Event(name, location, time);
                myList.Add(newEvent);
            }
        }//end create Event
    }
}
