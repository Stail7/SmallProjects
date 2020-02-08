using System;
using System.Collections.Generic;

namespace SmallestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();
                var split = input.Split(',');
                if (split.Length >= 5)
                {
                    foreach (var t in split)
                    {
                        numbers.Add(Convert.ToInt32(t));
                    }

                    break;
                }
                Console.WriteLine("Invalid List, try again.");
            }
            numbers.Sort();
            Console.WriteLine("3 smallest numbers are: {0} {1} {2}", numbers[0], numbers[1], numbers[2]);
        }
    }
}
