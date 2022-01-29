using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> occurences = new SortedDictionary<char, int>();
            char[] someInput = Console.ReadLine().ToCharArray();

            foreach (var symbol in someInput)
            {
                if (occurences.ContainsKey(symbol))
                {
                    occurences[symbol]++;
                }
                else
                {
                    occurences.Add(symbol, 1);
                }
            }

            foreach (var item in occurences)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
