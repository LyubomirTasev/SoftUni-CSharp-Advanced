using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split(" -> ");
                string color = inputArgs[0];
                string[] clothes = inputArgs[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (var cloth in clothes)
                {
                    if (!wardrobe.ContainsKey(cloth))
                    {
                        wardrobe[color].Add(cloth, 0);
                    }

                    wardrobe[color][cloth]++;
                }
            }

            string[] target = Console.ReadLine().Split();

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var clothe in color.Value)
                {
                    if (clothe.Key == target[1] && color.Key == target[0])
                    {
                        Console.WriteLine($"* {clothe.Key} - {clothe.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothe.Key} - {clothe.Value}");
                    }
                }
            }
        }
    }
}
