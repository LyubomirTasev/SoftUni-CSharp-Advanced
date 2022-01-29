using System;
using System.Collections.Generic;

namespace BalancedParantheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> parantheses = new Stack<char>();

            bool isBalanced = true;

            foreach (var symbol in input)
            {
                if (symbol == '{' || symbol == '[' || symbol == '(')
                {
                    parantheses.Push(symbol);
                }
                else
                {
                    if (parantheses.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }

                    bool isValid = (symbol == '}' && parantheses.Peek() == '{')
                        || (symbol == ']' && parantheses.Peek() == '[')
                        || (symbol == ')' && parantheses.Peek() == '(');

                    if (isValid)
                    {
                        parantheses.Pop();
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }

            if (isBalanced == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
