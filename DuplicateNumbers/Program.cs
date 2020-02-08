using System;
using System.Collections.Generic;

namespace DuplicateNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a few numbers (eg 1-2-3-4): ");
            //var input = Console.ReadLine();
            var input = "9-8-7-9-5-4";

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            Console.WriteLine(HasDuplicates(numbers) ? "Duplicate" : "No duplicates");
        }

        public static bool HasDuplicates(List<int> numbers)
        {
            //for (int i = 0; i < numbers.Count - 1; i++)
            //{
            //    var temp = numbers[i];
            //    for (int j = i + 1; j < numbers.Count; j++)
            //    {
            //        if (temp == numbers[j])
            //        {
            //            return true;
            //        }
            //    }
            //}

            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
