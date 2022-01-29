using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Reverse().ToArray();

            Stack<string> calc = new Stack<string>(input);

            while (calc.Count > 1)
            {
                int a = int.Parse(calc.Pop());
                char symbol = char.Parse(calc.Pop());
                int b = int.Parse(calc.Pop());

                if (symbol == '+')
                {
                    calc.Push((a + b).ToString());
                }
                else
                {
                    calc.Push((a - b).ToString());
                }
            }

            Console.WriteLine(calc.Pop());
        }
    }
}
