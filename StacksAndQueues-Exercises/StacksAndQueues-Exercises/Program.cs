using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueues_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] operations = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int elementsToPush = operations[0];
            int elementsToPop = operations[1];
            int elementToLookFor = operations[2];

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < elementsToPush; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < elementsToPop; i++)
            {
                queue.Dequeue();
            }

            if (queue.Any())
            {
                if (queue.Contains(elementToLookFor))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
