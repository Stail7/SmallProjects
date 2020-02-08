using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();

            builder.Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);

            var builder1 = builder;
            Console.WriteLine(builder1);

            builder.Replace("-", "+");
            var builder2 = builder;
            Console.WriteLine(builder2);

            builder.Remove(0, 10);
            var builder3 = builder;
            Console.WriteLine(builder3);

            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);
        }
    }
}
