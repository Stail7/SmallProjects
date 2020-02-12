using System;

namespace DemoIndexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie[1] = "Alex";
            Console.WriteLine(cookie[1]);
        }
    }
}
