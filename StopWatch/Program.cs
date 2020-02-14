using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            Thread.Sleep(2000);
            stopWatch.Stop();
            Console.WriteLine("Duration: " + stopWatch.Duration);

            stopWatch.Start();
            Thread.Sleep(3000);
            stopWatch.Stop();
            Console.WriteLine("Duration: " + stopWatch.Duration);
        }
    }
}
