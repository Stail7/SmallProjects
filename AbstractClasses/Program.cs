using System;
using AbstractClasses;

namespace AbstractClasses
{
    public abstract class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Shape copied into clipboard.");
        }

        public void Select()
        {
            Console.WriteLine("Shape selected.");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle.");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //you cannot instantiate a Shape class,
            //as it abstract and only provides common behavior.

            //var shape = new Shape();
            
            var circle = new Circle();
            circle.Draw();
            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
