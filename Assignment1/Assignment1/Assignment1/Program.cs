using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a String to be Repeated: ");

            string value = Console.ReadLine();

            Console.WriteLine("Your String is - " + value);
            Console.Write("Please press any key to exit . . .");

            Console.ReadLine();
        }
    }
}
