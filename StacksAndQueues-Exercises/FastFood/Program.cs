using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queueOfOrders = new Queue<int>();

            foreach (var order in orders)
            {
                queueOfOrders.Enqueue(order);
            }
            int maxOrder = int.MinValue;

            while (queueOfOrders.Count > 0 && quantityOfFood > 0)
            {
                int currentOrder = queueOfOrders.Peek();

                if (maxOrder < currentOrder)
                {
                    maxOrder = currentOrder;
                }

                if (quantityOfFood - currentOrder < 0)
                {
                    break;
                }

                quantityOfFood -= currentOrder;
                queueOfOrders.Dequeue();
            }

            Console.WriteLine(maxOrder);

            if (queueOfOrders.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queueOfOrders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
