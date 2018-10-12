using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace Assignment3.Tests
{
    [TestClass]
    public class TestGetThrows
    {
        [TestMethod]
        public void GetThrows_UserInputRock_ReturnOneOfExpectedTuples()
        {
            string input = @"rock" + Environment.NewLine;
            StringReader sr = new StringReader(input);

            Console.SetIn(sr);

            (string cpuThrow, string userThrow) methodOutput = RoshamboMethods.GetThrows();

            if (methodOutput.Equals(("rock", "rock")))
            {
                Assert.AreEqual(("rock", "rock"), methodOutput);
            }

            else if (methodOutput.Equals(("paper", "rock")))
            {
                Assert.AreEqual(("paper", "rock"), methodOutput);
            }

            else
            {
                Assert.AreEqual(("scissors", "rock"), methodOutput);
            }
                       
        }

        [TestMethod]
        public void GetThrows_UserInputPaper_ReturnOneOfExpectedTuples()
        {
            string input = "paper" + Environment.NewLine;
            StringReader sr = new StringReader(input);

            Console.SetIn(sr);

            (string cpuThrow, string userThrow) methodOutput = RoshamboMethods.GetThrows();

            if (methodOutput.Equals(("rock", "paper")))
            {
                Assert.AreEqual(("rock", "paper"), methodOutput);
            }

            else if (methodOutput.Equals(("paper", "paper")))
            {
                Assert.AreEqual(("paper", "paper"), methodOutput);
            }

            else
            {
                Assert.AreEqual(("scissors", "paper"), methodOutput);
            }

        }

        [TestMethod]
        public void GetThrows_UserInputScissors_ReturnOneOfExpectedTuples()
        {
            string input = "scissors" + Environment.NewLine;
            StringReader sr = new StringReader(input);

            Console.SetIn(sr);

            (string cpuThrow, string userThrow) methodOutput = RoshamboMethods.GetThrows();

            if (methodOutput.Equals(("rock", "scissors")))
            {
                Assert.AreEqual(("rock", "scissors"), methodOutput);
            }

            else if (methodOutput.Equals(("paper", "scissors")))
            {
                Assert.AreEqual(("paper", "scissors"), methodOutput);
            }

            else
            {
                Assert.AreEqual(("scissors", "scissors"), methodOutput);
            }

        }
    }
}
