using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputToPascalCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few words separated by a space: ");
            //var input = Console.ReadLine();
            var input = "nUmBer oF stuDenTs";
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine("Variable name is: " + InPascalCase(input));
        }

        public static string InPascalCase(string input)
        {
            var inPascalCase = "";
            foreach (var word in input.ToLower().Split(' '))
            {
                inPascalCase += char.ToUpper(word[0]) + word.Substring(1);
            }
            return inPascalCase;

            //var inputToLowerSplit = input.ToLower().Split(' ');
            //var words = new List<StringBuilder>();
            //foreach (var word in inputToLowerSplit)
            //{
            //    words.Add(new StringBuilder(word));
            //}
            //foreach (var word in words)
            //{
            //    word[0] = char.ToUpper(word[0]);
            //}
            //var output = new StringBuilder();
            //foreach (var word in words)
            //{
            //    output.Append(word);
            //}
            //return output.ToString();
        }
    }
}
