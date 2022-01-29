using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfABullet = int.Parse(Console.ReadLine());
            int numberOfBulletsInBarrel = int.Parse(Console.ReadLine());

            int[] bulletsValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locksValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligence = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(bulletsValues);
            Queue<int> locks = new Queue<int>(locksValues);

            int shotBullets = 0;

            while (bullets.Any() && locks.Any())
            {
                if (locks.Peek() >= bullets.Peek())
                {
                    bullets.Pop();
                    locks.Dequeue();
                    Console.WriteLine("Bang!");

                    shotBullets++;
                    if (shotBullets == numberOfBulletsInBarrel)
                    {
                        Console.WriteLine("Reloading!");
                        continue;
                    }
                }
                else
                {
                    bullets.Pop();
                    Console.WriteLine("Ping!");
                    shotBullets++;
                }
            }

            int realEarnings = intelligence - (priceOfABullet * shotBullets);

            if (bullets.Count() == 0 && locks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count()}");
            }
            else
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${realEarnings}");
            }
        }
    }
}
