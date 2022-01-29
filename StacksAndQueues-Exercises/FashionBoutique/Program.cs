using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInABox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacityOfARack = int.Parse(Console.ReadLine());

            Stack<int> stackOfClothes = new Stack<int>(clothesInABox);
            int sum = 0;
            int countOfRacks = 0;

            while (stackOfClothes.Count > 0)
            {
                int currentPack = sum + stackOfClothes.Peek();

                if (currentPack < capacityOfARack)
                {
                    sum += stackOfClothes.Pop();
                }

                else if (capacityOfARack == currentPack)
                {
                    countOfRacks++;
                    stackOfClothes.Pop();
                    sum = 0;
                }
                else
                {
                    countOfRacks++;
                    sum = stackOfClothes.Pop();
                }
            }

            if (sum > 0)
            {
                countOfRacks++;
            }

            Console.WriteLine(countOfRacks);
        }
    }
}
