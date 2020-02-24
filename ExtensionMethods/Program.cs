using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is a very long blog post blah blah blah...";
            var shortenedPost = post.Shorten(5);
            Console.WriteLine(shortenedPost);
        }
    }
}
