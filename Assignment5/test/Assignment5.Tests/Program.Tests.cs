using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment5.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void PrintList_EmptyList_PrintsExpectedOutput()
        {
            MockConsole console = new MockConsole();
            Program.PrintList(new List<Gathering>(), console);
            string expectedOutput = "No Events or University Courses Created";
            Assert.AreEqual(console.LastWrittenLine, expectedOutput);
        }

        [TestMethod]
        public void PrintList_ListSize3_PrintsExpectedOutput()
        {
            MockConsole console = new MockConsole();
            List<Gathering> myList = new List<Gathering>();

            myList.Add(new Event("Event1", "Location1", "Time1"));
            myList.Add(new Event("Event2", "Location2", "Time2"));
            myList.Add(new Event("Event3", "Location3", "Time3"));

            Program.PrintList(myList, console);

            string out1 = @"Event -
Name: Event1
Location: Location1
Time: Time1
Title: Event1@Location1";

            string out2 = @"Event -
Name: Event2
Location: Location2
Time: Time2
Title: Event2@Location2";

            string out3 = @"Event -
Name: Event3
Location: Location3
Time: Time3
Title: Event3@Location3";

            Assert.AreEqual(console.Output[0], out1);
            Assert.AreEqual(console.Output[1], out2);
            Assert.AreEqual(console.Output[2], out3);
        }

        [TestMethod]
        public void CreateGathering_CreateUniveristyCourseAllValidChoices_ReturnsExpectedCourse()
        {
            MockConsole console = new MockConsole();
            console.Input.Add("1"); // chooses uni course
            console.Input.Add("MyCourse"); // name for course
            console.Input.Add("Location"); // location
            console.Input.Add("MWF 2-4"); // schedule
            console.Input.Add("5"); //number of credits

            Gathering myGathering = Program.CreateGathering(console);

            Assert.AreEqual(myGathering is UniversityCourse, true);

            UniversityCourse myCourse = (UniversityCourse)myGathering;

            Assert.AreEqual(myCourse.Name, "MyCourse");
            Assert.AreEqual(myCourse.Location, "Location");
            Assert.AreEqual(myCourse.Schedule, "MWF 2-4");
            Assert.AreEqual(myCourse.Credits, 5);
        }

        [TestMethod]
        public void CreateGathering_CreateEventAllValidChoices_ReturnsExpectedEvent()
        {
            MockConsole console = new MockConsole();
            console.Input.Add("2"); // chooses uni course
            console.Input.Add("MyEvent"); // name for course
            console.Input.Add("Location"); // location
            console.Input.Add("2-4"); // time

            Gathering myGathering = Program.CreateGathering(console);

            Assert.AreEqual(myGathering is Event, true);

            Event myEvent = (Event)myGathering;

            Assert.AreEqual(myEvent.Name, "MyEvent");
            Assert.AreEqual(myEvent.Location, "Location");
            Assert.AreEqual(myEvent.Time, "2-4");
            Assert.AreEqual(myEvent.Title, "MyEvent@Location");
        }

        [TestMethod]
        public void CreateGathering_CreateEventFirstChoiceInvalid_ReturnsExpectedEvent()
        {
            MockConsole console = new MockConsole();
            console.Input.Add("5"); // choice is invalid so it will prompt again
            console.Input.Add("2"); // chooses event
            console.Input.Add("MyEvent"); // name for course
            console.Input.Add("Location"); // location
            console.Input.Add("2-4"); // time

            Gathering myGathering = Program.CreateGathering(console);

            Assert.AreEqual(myGathering is Event, true);

            Event myEvent = (Event)myGathering;

            Assert.AreEqual(myEvent.Name, "MyEvent");
            Assert.AreEqual(myEvent.Location, "Location");
            Assert.AreEqual(myEvent.Time, "2-4");
            Assert.AreEqual(myEvent.Title, "MyEvent@Location");
        }

        [TestMethod]
        public void GetStringFromUser_ValidInput_ReturnsExpectedString()
        {
            MockConsole console = new MockConsole();
            console.Input.Add("This is a String");
            string str = Program.GetStringFromUser("Please enter String", console);

            Assert.AreEqual(console.LastWrittenLine, "Please enter String");
            Assert.AreEqual(str, "This is a String");
        }

        [TestMethod]
        public void GetIntFromUser_ValidInput_ReturnsExpectedInt()
        {
            MockConsole console = new MockConsole();
            console.Input.Add("4");
            var num = Program.GetIntFromUser("Please enter Int", console);

            Assert.AreEqual(console.LastWrittenLine, "Please enter Int");
            Assert.AreEqual(num, 4);
        }

        [TestMethod]
        public void GetIntFromUser_InvalidInput_Returns0()
        {
            MockConsole console = new MockConsole();
            console.Input.Add("Something"); //invalid input, will make it 0
            var num = Program.GetIntFromUser("Please enter Int", console);

            Assert.AreEqual("Please enter Int", console.LastWrittenLine);
            Assert.AreEqual(num, 0);
        }

        [TestMethod]
        public void GetUserChoiceFromTwoChoices_ValidInput_ReturnExpectedChoiceAndOutput()
        {
            MockConsole console = new MockConsole();
            console.Input.Add("1"); 
            var num = Program.GetUserChoiceFromTwoChoices("Choice1", "Choice2", console);

            Assert.AreEqual(console.Output[0], "Please Select a Choice: ");
            Assert.AreEqual(console.Output[1], "1) Choice1");
            Assert.AreEqual(console.Output[2], "2) Choice2");
            Assert.AreEqual(console.Output[3], "Choice: ");
            
            Assert.AreEqual(num, 1);
        }

        [TestMethod]
        public void GetUserChoiceFromTwoChoices_InvalidInput_RePromptsUserExpectedOutput()
        {
            MockConsole console = new MockConsole();
            console.Input.Add("Something"); // invalid input, will reprompt
            console.Input.Add("2"); 
            var num = Program.GetUserChoiceFromTwoChoices("Choice1", "Choice2", console);

            Assert.AreEqual(console.Output[0], "Please Select a Choice: ");
            Assert.AreEqual(console.Output[1], "1) Choice1");
            Assert.AreEqual(console.Output[2], "2) Choice2");
            Assert.AreEqual(console.Output[3], "Choice: ");
            Assert.AreEqual(console.Output[4], "ERROR - Please enter a valid choice");
            Assert.AreEqual(console.Output[5], "Please Select a Choice: ");
            Assert.AreEqual(console.Output[6], "1) Choice1");
            Assert.AreEqual(console.Output[7], "2) Choice2");
            Assert.AreEqual(console.Output[8], "Choice: ");

            Assert.AreEqual(num, 2);
        }

        [TestMethod]
        public void PrintNewLine_PrintsNewLIne()
        {
            MockConsole console = new MockConsole();
            Program.PrintNewLine(console);
            Assert.AreEqual(console.LastWrittenLine, "");
        }
    }
}
