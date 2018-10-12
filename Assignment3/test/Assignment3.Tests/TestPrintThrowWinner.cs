using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace Assignment3.Tests
{
    [TestClass]
    public class TestPrintThrowWinner
    {
        [TestMethod]
        public void PrintsExpectedOuput_UserRockCpuRock()
        {
            var stringBuilder = new StringBuilder();
            var outputWriter = new StringWriter(stringBuilder);
            Console.SetOut(outputWriter);

            int cpuLife = 100;
            int userLife = 100;
            (string cpuThrow, string userThrow) throws = ("rock", "rock");

            Assignment3.RoshamboMethods.PrintThrowWinner(ref cpuLife, ref userLife, throws);

            string programOutput = stringBuilder.ToString();

            string expectedOutput = $@"
You threw - rock
Cpu threw - rock
You Tied - No Change
";

            Assert.AreEqual(expectedOutput, programOutput);
        }

        [TestMethod]
        public void PrintsExpectedOuput_UserRockCpuPaper()
        {
            var stringBuilder = new StringBuilder();
            var outputWriter = new StringWriter(stringBuilder);
            Console.SetOut(outputWriter);

            int cpuLife = 100;
            int userLife = 100;
            (string cpuThrow, string userThrow) throws = ("paper", "rock");

            Assignment3.RoshamboMethods.PrintThrowWinner(ref cpuLife, ref userLife, throws);

            string programOutput = stringBuilder.ToString();

            string expectedOutput = $@"
You threw - rock
Cpu threw - paper
Paper beats Rock - You lose 15 life points
";

            Assert.AreEqual(expectedOutput, programOutput);
        }

        [TestMethod]
        public void PrintsExpectedOuput_UserRockCpuScissors()
        {
            var stringBuilder = new StringBuilder();
            var outputWriter = new StringWriter(stringBuilder);
            Console.SetOut(outputWriter);

            int cpuLife = 100;
            int userLife = 100;
            (string cpuThrow, string userThrow) throws = ("scissors", "rock");

            Assignment3.RoshamboMethods.PrintThrowWinner(ref cpuLife, ref userLife, throws);

            string programOutput = stringBuilder.ToString();

            string expectedOutput = $@"
You threw - rock
Cpu threw - scissors
Rock beats Scissors - Cpu loses 20 life points
";

            Assert.AreEqual(expectedOutput, programOutput);
        }

        [TestMethod]
        public void PrintsExpectedOuput_UserPaperCpuRock()
        {
            var stringBuilder = new StringBuilder();
            var outputWriter = new StringWriter(stringBuilder);
            Console.SetOut(outputWriter);

            int cpuLife = 100;
            int userLife = 100;
            (string cpuThrow, string userThrow) throws = ("rock", "paper");

            Assignment3.RoshamboMethods.PrintThrowWinner(ref cpuLife, ref userLife, throws);

            string programOutput = stringBuilder.ToString();

            string expectedOutput = $@"
You threw - paper
Cpu threw - rock
Paper beats Rock - Cpu loses 15 life points
";

            Assert.AreEqual(expectedOutput, programOutput);
        }

        [TestMethod]
        public void PrintsExpectedOuput_UserPaperCpuPaper()
        {
            var stringBuilder = new StringBuilder();
            var outputWriter = new StringWriter(stringBuilder);
            Console.SetOut(outputWriter);

            int cpuLife = 100;
            int userLife = 100;
            (string cpuThrow, string userThrow) throws = ("paper", "paper");

            Assignment3.RoshamboMethods.PrintThrowWinner(ref cpuLife, ref userLife, throws);

            string programOutput = stringBuilder.ToString();

            string expectedOutput = $@"
You threw - paper
Cpu threw - paper
You Tied - No Change
";

            Assert.AreEqual(expectedOutput, programOutput);
        }

        [TestMethod]
        public void PrintsExpectedOuput_UserPaperCpuScissors()
        {
            var stringBuilder = new StringBuilder();
            var outputWriter = new StringWriter(stringBuilder);
            Console.SetOut(outputWriter);

            int cpuLife = 100;
            int userLife = 100;
            (string cpuThrow, string userThrow) throws = ("scissors", "paper");

            Assignment3.RoshamboMethods.PrintThrowWinner(ref cpuLife, ref userLife, throws);

            string programOutput = stringBuilder.ToString();

            string expectedOutput = $@"
You threw - paper
Cpu threw - scissors
Scissors beats Paper - You lose 10 life points
";

            Assert.AreEqual(expectedOutput, programOutput);
        }

        [TestMethod]
        public void PrintsExpectedOuput_UserScissorsCpuRock()
        {
            var stringBuilder = new StringBuilder();
            var outputWriter = new StringWriter(stringBuilder);
            Console.SetOut(outputWriter);

            int cpuLife = 100;
            int userLife = 100;
            (string cpuThrow, string userThrow) throws = ("rock", "scissors");

            Assignment3.RoshamboMethods.PrintThrowWinner(ref cpuLife, ref userLife, throws);

            string programOutput = stringBuilder.ToString();

            string expectedOutput = $@"
You threw - scissors
Cpu threw - rock
Rock beats Scissors - You lose 20 life points
";

            Assert.AreEqual(expectedOutput, programOutput);
        }

        [TestMethod]
        public void PrintsExpectedOuput_UserScissorsCpuPaper()
        {
            var stringBuilder = new StringBuilder();
            var outputWriter = new StringWriter(stringBuilder);
            Console.SetOut(outputWriter);

            int cpuLife = 100;
            int userLife = 100;
            (string cpuThrow, string userThrow) throws = ("paper", "scissors");

            Assignment3.RoshamboMethods.PrintThrowWinner(ref cpuLife, ref userLife, throws);

            string programOutput = stringBuilder.ToString();

            string expectedOutput = $@"
You threw - scissors
Cpu threw - paper
Scissors beats Paper - Cpu loses 10 life points
";

            Assert.AreEqual(expectedOutput, programOutput);
        }

        [TestMethod]
        public void PrintsExpectedOuput_UserScissorsCpuScissors()
        {
            var stringBuilder = new StringBuilder();
            var outputWriter = new StringWriter(stringBuilder);
            Console.SetOut(outputWriter);

            int cpuLife = 100;
            int userLife = 100;
            (string cpuThrow, string userThrow) throws = ("scissors", "scissors");

            Assignment3.RoshamboMethods.PrintThrowWinner(ref cpuLife, ref userLife, throws);

            string programOutput = stringBuilder.ToString();

            string expectedOutput = $@"
You threw - scissors
Cpu threw - scissors
You Tied - No Change
";

            Assert.AreEqual(expectedOutput, programOutput);
        }

        //For Below Tests - 
        // Win with Rock - Opponent Loses 20 life points
        // Win with Paper - Opponent Loses 15 life points
        // Wind with Scissors - Opponent Loses 10 life points

        [TestMethod]
        public void LifeChanges_UserRockCpuRock()
        {
            int cpuLife = 100;
            int userLife = 100;
            (string cpuThrow, string userThrow) throws = ("rock", "rock");

            Assignment3.RoshamboMethods.PrintThrowWinner(ref cpuLife, ref userLife, throws);

            Assert.AreEqual(cpuLife, 100);
            Assert.AreEqual(userLife, 100);
        }

        [TestMethod]
        public void LifeChanges_UserRockCpuPaper()
        {
            int cpuLife = 100;
            int userLife = 100;
            (string cpuThrow, string userThrow) throws = ("paper", "rock");

            Assignment3.RoshamboMethods.PrintThrowWinner(ref cpuLife, ref userLife, throws);

            Assert.AreEqual(cpuLife, 100);
            Assert.AreEqual(userLife, 100-15);
        }

        [TestMethod]
        public void LifeChanges_UserRockCpuScissors()
        {
            int cpuLife = 100;
            int userLife = 100;
            (string cpuThrow, string userThrow) throws = ("scissors", "rock");

            Assignment3.RoshamboMethods.PrintThrowWinner(ref cpuLife, ref userLife, throws);

            Assert.AreEqual(cpuLife, 100-20);
            Assert.AreEqual(userLife, 100);
        }

        [TestMethod]
        public void LifeChanges_UserPaperCpuRock()
        {
            int cpuLife = 100;
            int userLife = 100;
            (string cpuThrow, string userThrow) throws = ("rock", "paper");

            Assignment3.RoshamboMethods.PrintThrowWinner(ref cpuLife, ref userLife, throws);
            
            Assert.AreEqual(cpuLife, 100-15);
            Assert.AreEqual(userLife, 100);
        }

        [TestMethod]
        public void LifeChanges_UserPaperCpuPaper()
        {
            int cpuLife = 100;
            int userLife = 100;
            (string cpuThrow, string userThrow) throws = ("paper", "paper");

            Assignment3.RoshamboMethods.PrintThrowWinner(ref cpuLife, ref userLife, throws);

            Assert.AreEqual(cpuLife, 100);
            Assert.AreEqual(userLife, 100);
        }

        [TestMethod]
        public void LifeChanges_UserPaperCpuScissors()
        {
            int cpuLife = 100;
            int userLife = 100;
            (string cpuThrow, string userThrow) throws = ("scissors", "paper");

            Assignment3.RoshamboMethods.PrintThrowWinner(ref cpuLife, ref userLife, throws);

            Assert.AreEqual(cpuLife, 100);
            Assert.AreEqual(userLife, 100-10);
        }

        [TestMethod]
        public void LifeChanges_UserScissorsCpuRock()
        {
            int cpuLife = 100;
            int userLife = 100;
            (string cpuThrow, string userThrow) throws = ("rock", "scissors");

            Assignment3.RoshamboMethods.PrintThrowWinner(ref cpuLife, ref userLife, throws);

            Assert.AreEqual(cpuLife, 100);
            Assert.AreEqual(userLife, 100-20);
        }

        [TestMethod]
        public void LifeChanges_UserScissorsCpuPaper()
        {
            int cpuLife = 100;
            int userLife = 100;
            (string cpuThrow, string userThrow) throws = ("paper", "scissors");

            Assignment3.RoshamboMethods.PrintThrowWinner(ref cpuLife, ref userLife, throws);

            Assert.AreEqual(cpuLife, 100-10);
            Assert.AreEqual(userLife, 100);
        }

        [TestMethod]
        public void LifeChanges_UserScissorsCpuScissors()
        {
            int cpuLife = 100;
            int userLife = 100;
            (string cpuThrow, string userThrow) throws = ("scissors", "scissors");

            Assignment3.RoshamboMethods.PrintThrowWinner(ref cpuLife, ref userLife, throws);

            Assert.AreEqual(cpuLife, 100);
            Assert.AreEqual(userLife, 100);
        }
    }

}
