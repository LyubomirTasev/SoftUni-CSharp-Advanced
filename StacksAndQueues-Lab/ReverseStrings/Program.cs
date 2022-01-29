using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<string> reversed = new Stack<string>();

            foreach (char item in input)
            {
                reversed.Push(item.ToString());
            }

            while (reversed.Count != 0)
            {
                Console.Write(reversed.Pop());
            }
            Console.WriteLine();
        }
    }
}
