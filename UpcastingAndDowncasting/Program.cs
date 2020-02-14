using System;

namespace UpcastingAndDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            Shape shape = text;

            text.Wigth = 200;
            shape.Wigth = 100;

            Console.WriteLine(text.Wigth);

            Shape shape1 = new Text();
            Text text1 = (Text) shape1;
        }
    }
}
