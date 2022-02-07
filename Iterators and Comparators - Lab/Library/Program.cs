using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
               new Book("Twenty Thousand Leagues Under the Seas", 1870, new List<string>() { "Jules Verne" }),
               new Book("Gulliver's Travels", 1726, new List<string>() { "Jonathan Swift" }),
               new Book("Les Misérables", 1862, new List<string>() { "Victor-Marie Hugo" }),
               new Book("Kinder – und Hausmärchen", 1812, new List<string>() { "Jacob Grimm", "Wilhelm Grimm" }),
               new Book("Lord of the rings", 1954, new List<string>() { "J.R.R. Tolkien" }),
               new Book("Moby Dick", 1851, new List<string>() { "Herman Melville" }),
               new Book("Destination Unknown", 1954, new List<string>() { "Agatha Christie" })
            };

            //books.OrderBy(x => x.Year).ThenBy(x => x.Title);
            books.Sort(new BookComparer());
            foreach (var book in books)
            {
                Console.WriteLine($"{string.Join(" & ", book.Authors)} - {book.Title} ({book.Year})");
            }
        }

        public static void Library()
        {
            Library library = new Library();
            library.Add(new Book("Twenty Thousand Leagues Under the Seas", 1870, new List<string>() { "Jules Verne" }));
            library.Add(new Book("Gulliver's Travels", 1726, new List<string>() { "Jonathan Swift" }));
            library.Add(new Book("Les Misérables", 1862, new List<string>() { "Victor-Marie Hugo" }));
            library.Add(new Book("Kinder – und Hausmärchen", 1812, new List<string>() { "Jacob Grimm", "Wilhelm Grimm" }));
            library.Add(new Book("Moby Dick", 1851, new List<string>() { "Herman Melville" }));
            library.Add(new Book("Lord of the rings", 1954, new List<string>() { "J.R.R. Tolkien" }));
        }
    }
}
