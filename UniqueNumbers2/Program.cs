using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
                if (input == "Quit" || input == "quit")
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
