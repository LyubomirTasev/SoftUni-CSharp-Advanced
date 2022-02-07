using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class BookAuthorsCountComparator : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            if (x.Authors.Count > y.Authors.Count)
            {
                return 1;
            }
            else if (x.Authors.Count < y.Authors.Count)
            {
                return -1;
            }
            else
            {
                return x.Title.CompareTo(y.Title);
            }
        }
    }
}
