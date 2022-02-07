using System;

namespace Iterators
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();


            foreach (var item in student)
            {
                Console.WriteLine(item);
            }
        }
    }
}
