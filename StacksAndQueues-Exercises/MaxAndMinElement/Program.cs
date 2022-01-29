using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxAndMinElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "1":
                        stack.Push(int.Parse(command[1]));
                        break;
                    case "2":
                        if (stack.Any())
                        {
                            stack.Pop();
                        }
                        break;
                    case "3":
                        Console.WriteLine(stack.Max());
                        break;
                    case "4":
                        Console.WriteLine(stack.Min());
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
