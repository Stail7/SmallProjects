using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // Searches collection for items with specific conditions
            var cheapBooks = books.Where(book => book.Price < 10);
            foreach (var book in cheapBooks)
                Console.WriteLine(book.Title + " " + book.Price);

            // Sorts items in collection
            var orderedBooks = books.OrderBy(b => b.Title);
            foreach (var book in orderedBooks)
                Console.WriteLine(book.Title + " " + book.Price);

            // Selects all items in collection and projects them by type fields
            var selectedBooks = books.Select(b => b.Title);
            foreach (var book in selectedBooks)
                Console.WriteLine(book);

            // C# common convention layout for multiple inline LINQ statements
            var booksLinq = books
                .Where(book => book.Price < 10) // Searches collection for items with specific conditions
                .OrderBy(b => b.Title) // Sorts items in collection
                .Select(b => b.Title); // Selects all items in collection and projects them by type fields

            // OR LINQ Query Operators
            var booksLinqQuery =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b.Title;

            // Another useful LINQ Extension Methods
            var singleBook = books.SingleOrDefault(b => b.Title == "ASP.NET MVC"); // returns single item or default value
            Console.WriteLine(singleBook != null ? singleBook.Title : "There is no such book in collection");

            var firstBook = books.FirstOrDefault(b => b.Title == "Entity Framework");
            Console.WriteLine(firstBook.Title + " " + firstBook.Price);

            var lastBook = books.LastOrDefault(b => b.Title == "Entity Framework");
            Console.WriteLine(lastBook.Title + " " + lastBook.Price);

            var skipBooks = books.Skip(2).Take(3);
            foreach (var skipBook in skipBooks)
                Console.WriteLine(skipBook.Title);

            Console.WriteLine("Books count: " + books.Count());
            Console.WriteLine("Books max price: " + books.Max(b => b.Price));
            Console.WriteLine("Books min price: " + books.Min(b => b.Price));
            Console.WriteLine("Sum of all books prices: " + books.Sum(b => b.Price));
            Console.WriteLine("Average of all books prices: " + books.Average(b => b.Price));
        }
    }
}
