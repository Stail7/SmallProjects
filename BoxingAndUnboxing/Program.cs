using System;
using System.Collections;
using System.Collections.Generic;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList(); // A list that accepts any OBJECTS
            list.Add(1); // That's why here Boxing happens
            list.Add("Alex"); // String is an object, Boxing not happening
            list.Add(DateTime.Today); // Boxing happens

            var number = (int)list[0]; // Unboxing happens
        }
    }
}
