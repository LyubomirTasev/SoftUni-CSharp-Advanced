using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterators
{
    public class Student : IEnumerable<double>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<double> Grades { get; set; }

        public IEnumerator<double> GetEnumerator()
        {
            return Grades.GetEnumerator();
        }

        public void PrintGrades()
        {
            Console.WriteLine(string.Join(" ", Grades));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
