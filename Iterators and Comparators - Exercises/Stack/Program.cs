using System;
using System.Linq;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "END")
                {
                    break;
                }
                else if (tokens[0] == "Push")
                {
                    stack.Push(tokens.Skip(1).Select(e => e.Split(",").First()).ToArray());
                }
                else if (tokens[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
