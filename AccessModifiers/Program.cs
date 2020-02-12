using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1991, 05, 10));
            person.SetBirthdate(new DateTime(1991, 05, 10));
            Console.WriteLine(person.GetBirthdate().ToString("dd MMMM yyyy"));
            //// auto-properties
            Console.WriteLine(person.Age);
        }
    }
}
