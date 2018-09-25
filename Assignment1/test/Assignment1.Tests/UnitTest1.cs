using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assignment1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInputOutput()
        {
            String name = "Raymond";
            String expectedOutput = $@">>Hello, what is your name?
<<{name}
>>Hello {name}!";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment1.Program.Main);
        }

    }
    /*
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestPressKeyContinue()
        {
            String expectedOutput = "Press any key to continue . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment1.Program.Main);
        }
    }
    */
}
