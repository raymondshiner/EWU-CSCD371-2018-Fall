using System;

namespace Assignment2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a calculation to perform: ");

            var input = Console.ReadLine();

            string[] array;

            if (input.Contains('+'))
            {
                array = input.Split('+');

                int.TryParse(array[0], out int num1);
                int.TryParse(array[1], out int num2);

                int res = num1 + num2;

                Console.WriteLine("{0}+{1} = {2}", num1, num2, res);
            }

            else if (input.Contains('-'))
            {
                array = input.Split('-');

                int.TryParse(array[0], out int num1);
                int.TryParse(array[1], out int num2);

                int res = num1 - num2;

                Console.WriteLine("{0}-{1} = {2}", num1, num2, res);
            }

            else if (input.Contains('*'))
            {
                array = input.Split('*');

                int.TryParse(array[0], out int num1);
                int.TryParse(array[1], out int num2);

                int res = num1 * num2;

                Console.WriteLine("{0}*{1} = {2}", num1, num2, res);
            }

            else if (input.Contains('/'))
            {
                array = input.Split('/');

                int.TryParse(array[0], out int num1);
                int.TryParse(array[1], out int num2);

                if (num2 != 0)
                {
                    int res = num1 / num2;

                    Console.WriteLine("{0}/{1} = {2}", num1, num2, res);
                }

                else
                {
                    Console.WriteLine("Cannot Divide by Zero - Please Try Again");
                }
            }

            else
            {
                Console.WriteLine("ERROR - Please include an operator (+, -, *, /) in your input");
            }

            Console.Write("Press Enter to Exit Program . . .");

            Console.ReadLine();
        }
        
    }
}
