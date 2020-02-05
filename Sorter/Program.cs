using System;

namespace Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers split by a comma:");
            try
            {
                var input = Console.ReadLine();
                var split = input.Split(',');
                var length = split.Length;
                var inputInt = new int[length];
                for (int i = 0; i < length; i++)
                {
                    inputInt[i] = Convert.ToInt32(split[i]);
                }
                var count = 1;
                for (int i = 0; i < length; i++)
                {
                    for (int j = count; j < length; j++)
                    {
                        if (inputInt[i] < inputInt[j])
                        {
                            var x = inputInt[i];
                            inputInt[i] = inputInt[j];
                            inputInt[j] = x;
                        }
                    }
                    count++;
                }
                Console.Write("Sorted numbers: ");
                foreach (var item in inputInt)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
