using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace Assignment3.Tests
{
    [TestClass]
    public class TestPrintFinalScores
    {
        [TestMethod]
        public void PrintFinalScores_CpuLoses0Life_ReturnExpectedOutput()
        {
            var stringBuilder = new StringBuilder();
            var outputWriter = new StringWriter(stringBuilder);
            Console.SetOut(outputWriter);

            int cpuLife = 0;
            int userLife = 60;

            Assignment3.RoshamboMethods.PrintFinalScores(cpuLife, userLife);

            string programOutput = stringBuilder.ToString();

            string expectedOutput = $@"
CONGRATULATIONS - YOU WIN
FINAL SCORES
You - {userLife}
Cpu - 0
";
            Assert.AreEqual(expectedOutput, programOutput);
        }
    }

    [TestClass]
    public class TestPrintFinalScores
    {
        [TestMethod]
        public void PrintFinalScores_CpuLoses0Life_ReturnExpectedOutput()
        {
            var stringBuilder = new StringBuilder();
            var outputWriter = new StringWriter(stringBuilder);
            Console.SetOut(outputWriter);

            int cpuLife = 0;
            int userLife = 60;

            Assignment3.RoshamboMethods.PrintFinalScores(cpuLife, userLife);

            string programOutput = stringBuilder.ToString();

            string expectedOutput = $@"
CONGRATULATIONS - YOU WIN
FINAL SCORES
You - {userLife}
Cpu - 0
";
            Assert.AreEqual(expectedOutput, programOutput);
        }
    }
}
