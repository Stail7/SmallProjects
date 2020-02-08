using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsInEnglishWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word in English: ");
            //var input = Console.ReadLine();
            var input = "InadEquate";

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine("'{0}' word has {1} vowels", input, VowelsCount(input));
        }

        public static int VowelsCount(string input)
        {
            //var vowels = new char[] {'a', 'e', 'o', 'u', 'i' };
            //var vowelsCount = 0;
            //foreach (var vowel in vowels)
            //{
            //    for (int i = 0; i < input.Length; i++)
            //    {
            //        if (vowel == input.ToLower()[i])
            //            vowelsCount++;
            //    }
            //}

            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;
            foreach (var character in input.ToLower())
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            return vowelsCount;
        }
    }
}
