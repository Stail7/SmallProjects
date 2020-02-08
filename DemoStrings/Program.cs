using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Alex Par ";
            Console.WriteLine("Trim 'Alex Par ' to '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("Substrings: \nFirst Name: {0}\nLast Name: {1}", firstName, lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("Split: \nFirst Name: {0}\nLast Name: {1}", names[0], names[1]);

            var fName = fullName.Replace("Par", "Parshakov");
            Console.WriteLine("Replace: " + fName);
            var fName1 = fName.Replace('v', 'V');
            Console.WriteLine("Replace: " + fName1);

            // Check for null (empty) or whitespace
            if (String.IsNullOrWhiteSpace(null) || String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToInt32(str);
            Console.WriteLine("Age: " + age);

            var price = 29.95f;
            Console.WriteLine("Price: " + price.ToString("C0"));

            var number = 123;
            var inPercent = number.ToString("P");
            Console.WriteLine("123 in percent: " + inPercent);
        }
    }
}
