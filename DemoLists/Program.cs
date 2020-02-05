using System;
using System.Collections.Generic;
using System.Globalization;

namespace DemoLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {1, 2, 3, 4};

            numbers.Add(1);

            numbers.AddRange(new int[]{ 5, 6, 7 });
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            // IndexOf 1
            Console.WriteLine("\nIndexOf 1: " + numbers.IndexOf(1));
            Console.WriteLine("LastIndexOf 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);

            // Remove 1
            Console.Write("Remove 1: ");
            numbers.Remove(1);
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            } Console.WriteLine();

            // Remove all instances of 1
            Console.Write("Remove all instances of 1: ");
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            // Clear
            numbers.Clear();
            Console.WriteLine("\nCount after Clear(): " + numbers.Count);
        }
    }
}
