using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goAgain;

            do
            {
                Console.WriteLine("Welcome to a game of Rock Paper Scissors");
                Console.WriteLine("Both Players start with 100 life, its you versus the Computer");
                Console.WriteLine("Good Luck - Have Fun");
                Console.WriteLine();

                int cpuLife = 100;
                int userLife = 100;

                while (true)
                {
                    if (cpuLife <= 0 || userLife <= 0)
                    {
                        break;
                    }

                    RoshamboMethods.PrintStatus(cpuLife, userLife);

                    (string cpuThrow, string userThrow) throws = RoshamboMethods.GetThrows();

                    RoshamboMethods.PrintThrowWinner(ref cpuLife, ref userLife, throws);
                }

                RoshamboMethods.PrintFinalScores(cpuLife, userLife);

                goAgain = RoshamboMethods.GoAgain();

            } while (goAgain);

            Console.WriteLine("Thanks for Playing - Have a nice day");
            Console.Write("Press any key to exit. . .");
            Console.ReadLine();
        }
    }
}
