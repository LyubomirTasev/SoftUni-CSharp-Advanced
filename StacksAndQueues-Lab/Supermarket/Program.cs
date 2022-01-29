using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string customersName = Console.ReadLine();
            Queue<string> queue = new Queue<string>();

            int count = 0;

            while (customersName != "End")
            {
                queue.Enqueue(customersName);
                count++;

                if (customersName == "Paid")
                {
                    for (int i = 0; i <= queue.Count; i++)
                    {
                        Console.WriteLine(queue.Dequeue());
                        count = 0;
                    }
                }

                customersName = Console.ReadLine();
            }

            Console.WriteLine($"{count} people remaining.");
        }
    }
}
