using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassLab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            while (c == 0)  
            {
                Console.WriteLine("Please enter a number 0-20:");
                int userInput = int.Parse(Console.ReadLine());
                Console.WriteLine(userInput + " factorial Recursion method is " + Recursion(userInput));
                Console.WriteLine(userInput + " factorial loop method is " + FactorialLoop(userInput));
                Console.WriteLine("Would you like to continue? Y/N");
                string choice = Console.ReadLine().ToLower();
                int x = 0;
                while (x == 0)
                {
                    if (choice == "n")
                    {
                        c++;
                        x++;

                    }
                    else if (choice == "y" || choice == "Y")
                    {
                        x++;

                    }
                    else if (choice != "y" && choice != "n")
                    {
                        Console.WriteLine("Please choose y or n");
                        choice = Console.ReadLine().ToLower();

                    }
                }
            }

        }
        public static long Recursion(long num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * Recursion(num - 1);
        }
        public static long FactorialLoop(long num)
        {
            if (num == 0)
            {
                return 1;
            }

            for (long i = num - 1; i > 0; i--)
            {
                num *= i;
            }

            return num;
        }

    }
}
