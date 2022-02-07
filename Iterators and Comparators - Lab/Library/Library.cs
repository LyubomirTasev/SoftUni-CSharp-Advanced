using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] booksParam)
        {
            books = booksParam.ToList();
            books.Sort();
        }

        public void Add(Book book)
        {
            books.Add(book);
            books.Sort();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            for (int index = 0; index < books.Count; index++)
            {
                yield return books[index];
            }
        }

        public void Remove(Book book)
        {
            books.Remove(book);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
