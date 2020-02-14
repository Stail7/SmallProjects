using System;
using System.Net;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Copy();
            text.Duplicate();
            text.AddHyperLink("url.com");
            Console.WriteLine("Text height: {0}, width: {1}", text.Height = 10, text.Width = 3);
        }
    }
}
