using System;
using System.Collections.Generic;
using System.Linq;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("       1-Maximum");
            Console.WriteLine("       2-Minimum");
            Console.Write("     Chose a number from the menu above --> ");
            int userChoise = Convert.ToInt32(Console.ReadLine());
            switch (userChoise)
            {
                case 1:
                    Max();
                    break;
                case 2:
                    Min();
                    break;
                default:
                    Console.WriteLine("     Enter 1 or 2");
                    break;
            }

            static void Max()
            {
                Console.Write("     How many numbers do you have? ");
                int all = Convert.ToInt32(Console.ReadLine());
                var max = new List<int>();
                int counter = 1;
                for (int i = all; i != 0; i--)
                {
                    Console.Write($"     Number {counter} --> ");
                    var newNum = Convert.ToInt32(Console.ReadLine());
                    max.Add(newNum);
                    counter++;
                }
                int maxNum = max.Max();
                Console.WriteLine();
                Console.WriteLine($"     Maximum number is {maxNum}");
            }

            static void Min()
            {
                Console.Write("     How many numbers do you have? ");
                int all = Convert.ToInt32(Console.ReadLine());
                var min = new List<int>();
                int counter = 1;
                for (int i = all; i != 0; i--)
                {
                    Console.Write($"     Number {counter} --> ");
                    var newNum = Convert.ToInt32(Console.ReadLine());
                    min.Add(newNum);
                    counter++;
                }
                int minNum = min.Min();
                Console.WriteLine();
                Console.WriteLine($"     Minimum number is {minNum}");
            }
        }
    }
}