using System;
using System.Threading;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var title = "Title";
            var description = "Description";

            var post = new Post(title, description);

            Console.WriteLine($"Post created at: {post.Created:F}" +
                              $"\nTitle: {post.Title}" +
                              $"\nDescription: {post.Description}");

            for (int i = 0; i < 3; i++)
            {
                post.UpVote();
            }
            Console.WriteLine("Votes: " + post.Votes);

            for (int i = 0; i < 2; i++)
            {
                post.DownVote();
            }
            Console.WriteLine("Votes: " + post.Votes);

            for (int i = 0; i < 3; i++)
            {
                post.UpVote();
            }
            Console.WriteLine("Votes: " + post.Votes);

            Thread.Sleep(2000);

            var title1 = "Title 1";
            var description1 = "Description 1";

            post.Modify(title1, description1);

            Console.WriteLine($"Post modified at: {post.Created:F}" +
                              $"\nTitle: {post.Title}" +
                              $"\nDescription: {post.Description}");
            Console.WriteLine("Votes: " + post.Votes);
        }
    }
}
