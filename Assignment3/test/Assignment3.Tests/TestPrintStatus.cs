using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace Assignment3.Tests
{
    [TestClass]
    public class TestPrintStatus
    {
        [TestMethod]
        public void PrintsExpectedOutputStartingLife()
        {
            var stringBuilder = new StringBuilder();
            var outputWriter = new StringWriter(stringBuilder);
            Console.SetOut(outputWriter);

            Assignment3.RoshamboMethods.PrintStatus(100, 100);

            string programOutput = stringBuilder.ToString();

            string expectedOutput = @"
Your Life total is: 100
Cpu's Life total is: 100
"; // this last line is here because program uses console.writeline instead of console.write


            Assert.AreEqual(expectedOutput, programOutput);
        }

        [TestMethod]
        public void Prints80Life60Life()
        {
            var stringBuilder = new StringBuilder();
            var outputWriter = new StringWriter(stringBuilder);
            Console.SetOut(outputWriter);

            int cpuLife = 80;
            int userLife = 60;

            Assignment3.RoshamboMethods.PrintStatus(cpuLife, userLife);

            string programOutput = stringBuilder.ToString();

            string expectedOutput = $@"
Your Life total is: {userLife}
Cpu's Life total is: {cpuLife}
"; 


            Assert.AreEqual(expectedOutput, programOutput);
        }
    }
}
