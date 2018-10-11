using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class RoshamboMethods
    {
        public static void PrintStatus(int cpuLife, int userLife)
        {
            Console.WriteLine();
            Console.WriteLine($"Your Life total is: {userLife}");
            Console.WriteLine($"Cpu's Life total is: {cpuLife}");
        }

        public static (string, string) GetThrows()
        {
            Console.Write("What would you like to throw?: ");
            string theirThrow = Console.ReadLine();

            string cpuThrow;

            if (DateTime.Now.Millisecond % 3 == 0)
            {
                cpuThrow = "rock";
            }

            else if (DateTime.Now.Millisecond % 2 == 0)
            {
                cpuThrow = "paper";
            }

            else
            {
                cpuThrow = "scissors";
            }

            return (cpuThrow, theirThrow);
        }

        public static void PrintUpdatedScores(ref int cpuLife, ref int userLife, (string cpuThrow, string userThrow) throws)
        {
            Console.WriteLine();
            Console.WriteLine($"You threw - {throws.userThrow}");
            Console.WriteLine($"Cpu threw - {throws.cpuThrow}");
            

            if (throws.userThrow.Equals(throws.cpuThrow))
            {
                Console.WriteLine("You Tied - No Change");
            }

            else if (throws.userThrow.Equals("rock"))
            {
                if (throws.cpuThrow.Equals("paper"))
                {
                    Console.WriteLine("Paper beats Rock - You lose 15 life points");
                    userLife = userLife - 15;
                }

                else // scissors
                {
                    Console.WriteLine("Rock beats Scissors - Cpu Loses 20 life points");
                    cpuLife = cpuLife - 20;
                }
            }

            else if (throws.userThrow.Equals("paper"))
            {
                if (throws.cpuThrow.Equals("rock"))
                {
                    Console.WriteLine("Paper beats Rock - Cpu loses 15 life points");
                    cpuLife = cpuLife - 15;
                }

                else // scissors
                {
                    Console.WriteLine("Scissors beats Paper - You lose 10 life points");
                    userLife = userLife - 10;
                }
            }

            else // userThrow scissors
            {
                if (throws.cpuThrow.Equals("rock"))
                {
                    Console.WriteLine("Rock beats Scissors - You lose 20 life points");
                    userLife = userLife - 20;
                }

                else // paper
                {
                    Console.WriteLine("Scissors beats Paper - Cpu loses 10 life points");
                    cpuLife = cpuLife - 10;
                }
            }
        }// end printupdateScores

        public static void PrintFinalScores(int cpuLife, int userLife)
        {
            Console.WriteLine();

            if (cpuLife < userLife)
            {
                Console.WriteLine("CONGRATULATIONS - YOU WIN");
                Console.WriteLine("FINAL SCORES");
                Console.WriteLine("You - {0}", userLife);
                Console.WriteLine("Cpu - 0");
            }

            else
            {
                Console.WriteLine("GAME OVER - YOU LOSE");
                Console.WriteLine("FINAL SCORES");
                Console.WriteLine("You - 0");
                Console.WriteLine("Cpu - {0}", cpuLife);
            }

            Console.WriteLine();
        }//end printFinalresults

        public static bool GoAgain()
        {
            Console.Write("Would you like to go again? (y/n): ");
            string answer = Console.ReadLine();

            if (answer.Equals("y"))
                return true;

            return false;
        }
    }//end class
}//end namespace