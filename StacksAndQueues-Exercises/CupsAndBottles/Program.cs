using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottlesValues = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> cups = new Queue<int>(cupsValues);
            Stack<int> bottles = new Stack<int>(bottlesValues);

            bool isNewOne = true;
            int currentCup = 0;
            int wastedLiters = 0;

            while (cups.Any() && bottles.Any())
            {
                if (isNewOne)
                {
                    currentCup = cups.Peek();
                    isNewOne = false;
                }

                int currentBottle = bottles.Pop();

                if (currentCup - currentBottle <= 0)
                {
                    wastedLiters += currentCup - currentBottle;

                    cups.Dequeue();
                    isNewOne = true;
                }
                else
                {
                    currentCup -= currentBottle;
                }
            }

            if (cups.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }

            Console.WriteLine($"Wasted liters of water: {Math.Abs(wastedLiters)}");
        }
    }
}
