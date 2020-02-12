using System;

namespace DemoClasses
{
    class Program
    {
        public class Person
        {
            public string Name;

            public void Introduce(string to)
            {
                Console.WriteLine("Hi {0}, I am {1}", to, Name);
            }

            public static Person Parse(string str)
            {
                var person = new Person();
                person.Name = str;
                return person;
            }
        }
        static void Main(string[] args)
        {
            var person = Person.Parse("Alex");
            person.Introduce("Luci");

            var customer = new Customer(1, "John");
            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id + " " + customer.Name);

        }
    }
}
