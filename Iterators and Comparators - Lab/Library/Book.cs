using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        public Book(string title, int year, List<string> authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors;
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public int CompareTo(Book other)
        {
            if (Year > other.Year)
            {
                return 1;
            }
            else if (Year < other.Year)
            {
                return -1;
            }
            else
            {
                if (Title.CompareTo(other.Title) > 0)
                {
                    return 1;
                }
                else if (Title.CompareTo(other.Title) < 0)
                {
                    return -1;
                }

                return 0;

                //return Title.CompareTo(other.Title); => написаното горе, на един ред
            }
        }
    }
}
