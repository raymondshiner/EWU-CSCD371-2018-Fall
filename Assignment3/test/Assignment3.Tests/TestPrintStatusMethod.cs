using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment3.Tests
{
    [TestClass]
    public class TestPrintStatusMethod
    {
        [TestMethod]
        public void PrintsExpectedOutput()
        {
            IntelliTect.TestTools.Console.ConsoleAssert.Expect("", Assignment3.RoshamboMethods.PrintStatus(100, 100));
        }
    }
}
