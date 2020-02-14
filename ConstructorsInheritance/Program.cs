namespace ConstructorsInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("XYZ1234");
            var vehicle = new Vehicle("ABC1234");

            // Upcasting - converse to a base class. Implicit.
            Vehicle newVehicle = car;

            // Downcasting - converse to a derived class. Explicit.
            Car newCar = (Car)vehicle;
        }
    }
}
