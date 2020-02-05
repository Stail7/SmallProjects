using System;

namespace DemoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] {3, 7, 9, 2, 14, 6};

            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf() - searches for index of an element (9 in example)
            Console.WriteLine("Index of 9: " + Array.IndexOf(numbers, 9));

            // Clear() - replaces a range of elements from starting index by default type values
            Array.Clear(numbers, 0, 3);

            Console.Write("Effect of Clear(): ");
            foreach (var i in numbers)
                Console.Write(i + " "); Console.WriteLine();

            // Copy
            var copyArr = new int[5];
            Array.Copy(numbers, copyArr, 5 );

            Console.Write("Effect of Copy(): ");
            foreach (var i in numbers)
                Console.Write(i + " "); Console.WriteLine();

            // Sort()
            Array.Sort(numbers);

            Console.Write("Effect of Sort(): ");
            foreach (var i in numbers)
                Console.Write(i + " "); Console.WriteLine();

            // Reverse()
            Array.Reverse(numbers);

            Console.Write("Effect of Reverse(): ");
            foreach (var i in numbers)
                Console.Write(i + " "); Console.WriteLine();
        }
    }
}
