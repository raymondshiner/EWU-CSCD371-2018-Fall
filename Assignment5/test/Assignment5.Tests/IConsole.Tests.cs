using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment5.Tests
{
    [TestClass]
    public class IConsoleTests
    {
        [TestMethod]
        public void IConsole_ConsoleWriteLine_WritesOutput()
        {
            MyConsole console = new MyConsole();
            console.WriteLine("This is a String");

            Assert.AreEqual(console.LastWrittenLine, "This is a String");
        }

        [TestMethod]
        public void IConsole_ConsoleWrite_WritesOutput()
        {
            MyConsole console = new MyConsole();
            console.WriteLine("This is a String2");

            Assert.AreEqual(console.LastWrittenLine, "This is a String2");
        }

        [TestMethod]
        public void IEvent_EventIsIEvent_ReturnTrue()
        {
            Assert.IsTrue(new Event() is IEvent);
        }

        [TestMethod]
        public void IEvent_UniversityCourseIsIEvent_ReturnTrue()
        {
            Assert.IsTrue(new UniversityCourse() is IEvent);
        }
    }
}