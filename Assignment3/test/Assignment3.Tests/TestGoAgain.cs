using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace Assignment3.Tests
{
    [TestClass]
    public class TestGoAgain
    {
        [TestMethod]
        public void GoAgain_UserInputsY_ReturnTrue()
        {
            string input = "y" + Environment.NewLine;

            StringReader sr = new StringReader(input);
            Console.SetIn(sr);

            Assert.AreEqual(true, RoshamboMethods.GoAgain());
        }

        [TestMethod]
        public void GoAgain_UserInputsN_ReturnFalse()
        {
            string input = "n" + Environment.NewLine;

            StringReader sr = new StringReader(input);
            Console.SetIn(sr);

            Assert.AreEqual(false, RoshamboMethods.GoAgain());
        }

        [TestMethod]
        public void GoAgain_UserInputsY_PrintsExpectedOutput()
        {
            string input = "y" + Environment.NewLine;

            StringReader sr = new StringReader(input);
            Console.SetIn(sr);

            var stringBuilder = new StringBuilder();
            var outputWriter = new StringWriter(stringBuilder);
            Console.SetOut(outputWriter);

            RoshamboMethods.GoAgain();

            string realOutput = outputWriter.ToString();

            string expectedOutput = $@"Would you like to go again? (y/n): ";

            Assert.AreEqual(expectedOutput, realOutput);
        }

        [TestMethod]
        public void GoAgain_UserInputsN_PrintsExpectedOutput()
        {
            string input = "n" + Environment.NewLine;

            StringReader sr = new StringReader(input);
            Console.SetIn(sr);

            var stringBuilder = new StringBuilder();
            var outputWriter = new StringWriter(stringBuilder);
            Console.SetOut(outputWriter);

            RoshamboMethods.GoAgain();

            string realOutput = outputWriter.ToString();

            string expectedOutput = $@"Would you like to go again? (y/n): ";

            Assert.AreEqual(expectedOutput, realOutput);
        }
    }
}
