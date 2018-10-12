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
        public void PrintFinalScores_CpuLoses0Life_PrintExpectedOutput()
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

        [TestMethod]
        public void PrintFinalScores_CpuLosesNegativeLife_PrintExpectedOutput()
        {
            var stringBuilder = new StringBuilder();
            var outputWriter = new StringWriter(stringBuilder);
            Console.SetOut(outputWriter);

            int cpuLife = -15;
            int userLife = 80;

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

        [TestMethod]
        public void PrintFinalScores_USerLoses0Life_PrintExpectedOutput()
        {
            var stringBuilder = new StringBuilder();
            var outputWriter = new StringWriter(stringBuilder);
            Console.SetOut(outputWriter);

            int cpuLife = 70;
            int userLife = 0;

            Assignment3.RoshamboMethods.PrintFinalScores(cpuLife, userLife);

            string programOutput = stringBuilder.ToString();

            string expectedOutput = $@"
GAME OVER - YOU LOSE
FINAL SCORES
You - 0
Cpu - {cpuLife}

";
            Assert.AreEqual(expectedOutput, programOutput);
        }

        [TestMethod]
        public void PrintFinalScores_USerLosesNegativeLife_PrintExpectedOutput()
        {
            var stringBuilder = new StringBuilder();
            var outputWriter = new StringWriter(stringBuilder);
            Console.SetOut(outputWriter);

            int cpuLife = 60;
            int userLife = -15;

            Assignment3.RoshamboMethods.PrintFinalScores(cpuLife, userLife);

            string programOutput = stringBuilder.ToString();

            string expectedOutput = $@"
GAME OVER - YOU LOSE
FINAL SCORES
You - 0
Cpu - {cpuLife}

";
            Assert.AreEqual(expectedOutput, programOutput);
        }
    }
    
}
