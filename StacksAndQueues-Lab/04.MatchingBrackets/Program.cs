using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> indices = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')                      // 1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5
                {
                    indices.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int openBracketIndex = indices.Pop();
                    int closedBracketIndex = i;

                    Console.WriteLine(expression.Substring(openBracketIndex, closedBracketIndex - openBracketIndex + 1));
                }
            }
        }
    }
}
