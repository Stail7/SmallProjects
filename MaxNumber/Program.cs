using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers split by a comma:");
            var input = Console.ReadLine();
            var split = input.Split(',');
            var number = 0;
            for (int i = 0; i < split.Length; i++)
            {
                var temp = Convert.ToInt32(split[i]);
                if (temp > number)
                {
                    number = temp;
                }
            }

            Console.WriteLine("Maximum number is " + number);
        }
    }
}
