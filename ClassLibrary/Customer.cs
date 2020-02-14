using System;

namespace ClassLibrary {
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this); // new Customer()
            Console.WriteLine("Promote logic changed.");
        }
    }
}