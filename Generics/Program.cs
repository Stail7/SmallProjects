using System;

namespace Generics
{
    public class GenericList<T>
    {
        public void Add(T item)
        {

        }

        public T this[int index]
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book{Isbn = "1234", Title = "C# Book"};

            // System.Collections.Generic.

            var books = new GenericList<Book>();
            books.Add(book);

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1", new Book());


            var number = new Nullable<int>(5);
            Console.WriteLine("Has value ? " + number.HasValue + " " + number.GetValueOrDefault());
        }
    }
}
