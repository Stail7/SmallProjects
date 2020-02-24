using System;
using System.Collections.Generic;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Square(5));

            // arguments =>(goes to) expression

            // () => ...
            // x => ...
            // (x, y, z) => ...

            // return from delegate
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));

            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;
            Console.WriteLine(multiplier(10));

            // return from local function
            int Square(int number) => number * number;
            Console.WriteLine(Square(5));

            int Add(int a, int b) => a + b;
            Console.WriteLine(Add(5, 5));

            // BookRepository class example. Find books cheaper then 10
            // 1
            var books = new BookRepository().GetBooks();
            var cheapBooks1 = new List<Book>();
            foreach (var book in books)
            {
                if (book.Price > 10)
                    continue;
                cheapBooks1.Add(book);
                Console.WriteLine(book.Title);
            }
            // 2
            var cheapBooks2 = books.FindAll(IsCheaperThan10Dollars);
            foreach (var book in cheapBooks2)
            {
                Console.WriteLine(book.Title);
            }
            // 3
            var cheapBooks3 = books.FindAll(book => book.Price < 10);
            foreach (var book in cheapBooks3)
            {
                Console.WriteLine(book.Title);
            }
        }

        static bool IsCheaperThan10Dollars(Book book) // predicate method
        {
            return book.Price < 10;
        }

        public static int Square(int number)
        {
            return number * number;
        }
    }
}
