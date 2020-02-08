using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsecutiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a few numbers (eg 1-2-3-4): ");
            //var input = Console.ReadLine();
            var input = "10-9-8-7-7-5-4-3-2-1-0";
            var message = IsConsecutiveDigits(input) ? "Numbers are consecutive." : "Numbers are not consecutive.";
            Console.WriteLine(message);
        }

        public static bool IsConsecutiveDigits(string input)
        {
            var strArr = input.Split('-');
            
            var intArr = new int[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                intArr[i] = Convert.ToInt32(strArr[i]);
            }

            Array.Sort(intArr);

            for (int i = 0; i < intArr.Length - 1; i++)
            {
                if (intArr[i + 1] != intArr[i] + 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
