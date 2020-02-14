using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual void Draw()
        {

        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            // Any code specific to this class itself
            Console.WriteLine("Draw a circle.");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            // Any code specific to this class itself
            Console.WriteLine("Draw a rectangle.");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            // Any code specific to this class itself
            Console.WriteLine("Draw a Triangle.");
        }
    }

    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
