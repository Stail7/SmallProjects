using System;

namespace TimeSpanExemp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating TimeSpan objects
            var timeSpan = new TimeSpan(1,2,3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);
            Console.WriteLine();

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            // Add
            Console.WriteLine("Add Example " + timeSpan.Add(TimeSpan.FromMinutes(10)));
            Console.WriteLine("Subtract Example " + timeSpan.Subtract(TimeSpan.FromMinutes(10)));

            // Conversion To and From strings
            Console.WriteLine("ToString: " + timeSpan.ToString());
            var fromString = TimeSpan.Parse("01:02:03");
            Console.WriteLine("Parse from string: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
