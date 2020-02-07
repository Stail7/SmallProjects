using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your name: ");
            var input = Console.ReadLine();
            var name = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                name[i] = input[input.Length - 1 - i];
            }

            //Array.Reverse(name);
            var reversed = new string(name);
            Console.WriteLine("Your name in reverse: " + reversed);
        }
    }
}
