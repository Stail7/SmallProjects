using System;

namespace TimeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a time value in the 24-hour format (e.g. 19:00)");
            //var input = Console.ReadLine();
            var input = "19:00";
            Console.WriteLine(IsValidTime(input) ? "Valid Time" : "Invalid Time");
        }

        public static bool IsValidTime(string input)
        {
            DateTime time;
            return DateTime.TryParse(input, out time);
        }
    }
}
