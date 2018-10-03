using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment2.Tests
{
    [TestClass]
    public class TestAddition
    {
        [TestMethod]
        public void TestAdd8And2()
        {
            string expectedOuput = $@">>Please enter a calculation to perform: <<8+2
>>8+2 = 10
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestAdd6And90()
        {
            string expectedOuput = $@">>Please enter a calculation to perform: <<6+90
>>6+90 = 96
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestAddMinAnd5()
        {
            int minVal = int.MinValue;
            int five = 5;
            int res = minVal + five;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{minVal}+{five}
>>{minVal}+{five} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestAddMaxAndNeg7()
        {
            int maxVal = int.MaxValue;
            int negSeven = -7;
            int res = maxVal + negSeven;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{maxVal}+{negSeven}
>>{maxVal}+{negSeven} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestAdd0AndNeg7()
        {
            int zero = 0;
            int negSeven = -7;
            int res = zero + negSeven;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{zero}+{negSeven}
>>{zero}+{negSeven} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }
    }
    
    //END OF ADDITION TESTS
    






    //START OF SUBTRACTION TESTS

    [TestClass]
    public class TestSubtraction
    {
        [TestMethod]
        public void TestSub8And2HardCoded()
        {
            string expectedOuput = $@">>Please enter a calculation to perform: <<8-2
>>8-2 = 6
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestSub297And43()
        {
            int num1 = 297;
            int num2 = 43;
            int res = num1 - num2;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}-{num2}
>>{num1}-{num2} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestSubNeg4And16()
        {
            int num1 = -4;
            int num2 = 16;
            int res = num1 - num2;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}-{num2}
>>{num1}-{num2} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestSub5AndNeg12()
        {
            int num1 = 5;
            int num2 = -12;
            int res = num1 - num2;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}-{num2}
>>{num1}-{num2} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestSubNeg2AndNeg4()
        {
            int num1 = -2;
            int num2 = -4;
            int res = num1 - num2;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}-{num2}
>>{num1}-{num2} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }
        /*
        [TestMethod]
        public void TestSubNeg2AndMinVal()
        {
            int num1 = -2;
            int num2 = int.MinValue;
            int res = num1 - num2;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}-{num2}
>>{num1}-{num2} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }
        */

        [TestMethod]
        public void TestSubNeg2AndMaxVal()
        {
            int num1 = -2;
            int num2 = int.MaxValue;
            int res = num1 - num2;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}-{num2}
>>{num1}-{num2} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestSubMaxValAnd4()
        {
            int num1 = int.MaxValue;
            int num2 = 4;
            int res = num1 - num2;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}-{num2}
>>{num1}-{num2} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestSub0And4()
        {
            int num1 = 0;
            int num2 = 4;
            int res = num1 - num2;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}-{num2}
>>{num1}-{num2} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestSub0And7HardCoded()
        { 
            string expectedOuput = $@">>Please enter a calculation to perform: <<0-7
>>0-7 = -7
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }
    }

    //END OF SUBTRACTION TESTS








    //START OF MULTIPLICATION TESTS

    [TestClass]

    public class TestMultiplication
    {
        [TestMethod]
        public void TestMult4And7HardCoded()
        {
            string expectedOuput = $@">>Please enter a calculation to perform: <<4*7
>>4*7 = 28
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestMult0And15HardCoded()
        {
            int num1 = -2;
            int num2 = 40;
            int res = num1 * num2;

            string expectedOuput = $@">>Please enter a calculation to perform: <<0*15
>>0*15 = 0
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestMultNeg2And40()
        {
            int num1 = -2;
            int num2 = 40;
            int res = num1 * num2;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}*{num2}
>>{num1}*{num2} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestMult8AndNeg20()
        {
            int num1 = 8;
            int num2 = 20;
            int res = num1 * num2;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}*{num2}
>>{num1}*{num2} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestMultNeg13AndNeg4()
        {
            int num1 = -13;
            int num2 = -4;
            int res = num1 * num2;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}*{num2}
>>{num1}*{num2} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestMultMinValAnd5()
        {
            int num1 = int.MinValue;
            int num2 = 5;
            int res = num1 * num2;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}*{num2}
>>{num1}*{num2} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestMultMaxValAnd7()
        {
            int num1 = int.MaxValue;
            int num2 = 7;
            int res = num1 * num2;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}*{num2}
>>{num1}*{num2} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestMultMaxValAndZero()
        {
            int num1 = int.MaxValue;
            int num2 = 0;
            int res = num1 * num2;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}*{num2}
>>{num1}*{num2} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }
    }

    //END OF MULTIPLICATION TESTS









    //START OF DIVISION TESTS

    [TestClass]
    public class DivisionTests
    {
        [TestMethod]
        public void TestDiv12And3HardCoded()
        {
            string expectedOuput = $@">>Please enter a calculation to perform: <<12/3
>>12/3 = 4
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestDivNeg2And2()
        {
            int num1 = -2;
            int num2 = 2;
            int res = num1 / num2;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}/{num2}
>>{num1}/{num2} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestDiv15And4()
        {
            int num1 = 15;
            int num2 = 4;
            int res = num1 / num2;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}/{num2}
>>{num1}/{num2} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestDiv3And2()
        {
            int num1 = 3;
            int num2 = 2;
            int res = num1 / num2;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}/{num2}
>>{num1}/{num2} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestDiv3And0()
        {
            int num1 = 3;
            int num2 = 0;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}/{num2}
>>Cannot Divide by Zero - Please Try Again
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestDivNeg2And0()
        {
            int num1 = -2;
            int num2 = 0;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}/{num2}
>>Cannot Divide by Zero - Please Try Again
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestDivMinValAnd2()
        {
            int num1 = int.MinValue;
            int num2 = 2;
            int res = num1 / num2;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}/{num2}
>>{num1}/{num2} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }

        [TestMethod]
        public void TestDivMaxValAnd2()
        {
            int num1 = int.MaxValue;
            int num2 = 2;
            int res = num1 / num2;

            string expectedOuput = $@">>Please enter a calculation to perform: <<{num1}/{num2}
>>{num1}/{num2} = {res}
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }
    }

    //END OF DIVISION TESTS







    //START OF EDGECASE TESTS

    [TestClass]
    public class TestEdgeCases
    {
        [TestMethod]
        public void TestNoSymbolCase()
        {
            string expectedOuput = $@">>Please enter a calculation to perform: <<58493
>>ERROR - Please include an operator (+, -, *, /) in your input
>>Press Enter to Exit Program . . .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOuput, Assignment2.Program.Main);
        }
    }

    //END OF EDGECASE TESTS






    //START OF STRING TESTS

    [TestClass]
    public class StringTests
    {
        [TestMethod]
        public void TestStringEquals()
        {
            string str1 = "Raymond";
            string str2 = "Raymond";

            IntelliTect.TestTools.Console.ConsoleAssert.Equals(str1, str2);
        }
    }



}
