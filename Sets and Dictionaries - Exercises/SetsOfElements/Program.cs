using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = size[0];
            int m = size[1];

            HashSet<int> leftSet = new HashSet<int>();
            HashSet<int> rightSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                leftSet.Add(currentNum);
            }

            for (int i = 0; i < m; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                rightSet.Add(currentNum);
            }

            foreach (var item in leftSet)
            {
                if (rightSet.Contains(item))
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
