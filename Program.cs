using System;

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
                int[] max = new int[all];
                int counter = 1;
                int maxNum = max[0];
                for (int i = all; i != 0; i--)
                {
                    Console.Write($"     Number {counter} --> ");
                    max = new int[] { Convert.ToInt32(Console.ReadLine()) };
                    foreach (int num in max)
                    {
                        if (maxNum < num)
                        {
                            maxNum = num;
                        }
                    }
                    counter++;
                }
                Console.WriteLine();
                Console.WriteLine($"     Maximum number is {maxNum}");


            }
            static void Min()
            {
                Console.Write("     How many numbers do you have? ");
                int all = Convert.ToInt32(Console.ReadLine());
                int[] min = new int[all];
                int counter = 1;
                int minNum = min[0];
                for (int i = all; i != 0; i--)
                {
                    Console.Write($"     Number {counter} --> ");
                    min = new int[] { Convert.ToInt32(Console.ReadLine()) };
                    foreach (int num in min)
                    {
                        if (minNum > num)
                        {
                            minNum = num;
                        }
                    }
                    counter++;
                }
                Console.WriteLine();
                Console.WriteLine($"     Minimum number is {minNum}");
            }
        }
    }
}