using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Library
{
    public class BookComparer : IComparer<Book>
    {
        public int Compare([AllowNull] Book x, [AllowNull] Book y)
        {
            if (x.Title.CompareTo(y.Title) > 0)
            {
                return 1;
            }
            else if (x.Title.CompareTo(y.Title) < 0)
            {
                return -1;
            }
            else
            {
                return x.Year.CompareTo(y.Year);
            }
        }
    }
}
