using System;
using System.Collections.Generic;

namespace Exer3
{
    class Program
    {
        static void Main(string[] args)
        {
            //link:;
            //Console.WriteLine("Enter 5 unique numbers: ");

            //var numbers = new int[5];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Enter a number: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //var count = 1;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    var temp = numbers[i];
            //    for (int j = count; j < numbers.Length; j++)
            //    {
            //        if (temp == numbers[j])
            //        {
            //            Console.WriteLine("Numbers not unique, re-try\n");
            //            goto link;
            //        }
            //    }
            //    count++;
            //}

            //Array.Sort(numbers);
            //Console.Write("Sorted numbers: ");
            //foreach (var number in numbers)
            //{
            //    Console.Write(number + " ");
            //}

            //Console.WriteLine();

            Console.WriteLine("Enter 5 unique numbers: ");

            var list = new List<int>();

            while (list.Count < 5)
            {
                var input = Convert.ToInt32(Console.ReadLine());
                if (list.Contains(input))
                {
                    Console.WriteLine("Number already exist, try again");
                }
                else
                {
                    list.Add(input);
                }
            }
            list.Sort();
            Console.Write("Sorted numbers: ");
            foreach (var number in list)
            {
                Console.Write(number + " ");
            }
        }
    }
}
