using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> evenNumbers = new Queue<int>();

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    evenNumbers.Enqueue(item);
                }
            }

            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}
