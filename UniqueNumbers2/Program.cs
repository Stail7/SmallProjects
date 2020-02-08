using System;
using System.Collections.Generic;

namespace UniqueNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers (or type 'Quit' to exit): ");
            var list = new List<int>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;
                list.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach (var number in list)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            Console.WriteLine("Unique numbers: ");
            foreach (var number in uniques)
                Console.Write(number + " ");
        }
    }
}
