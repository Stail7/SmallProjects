using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers split by a comma:");
            var input = Console.ReadLine();
            var array = input.Split(',');
            var number = 0;
            for (int i = 0; i < array.Length; i++)
            {
                var temp = Convert.ToInt32(array[i]);
                if (temp > number)
                {
                    number = temp;
                }
            }

            Console.WriteLine("Maximum numbers is " + number);
        }
    }
}
