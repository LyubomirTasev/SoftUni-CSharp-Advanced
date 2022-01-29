using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers); // !!! добавям числата в стека

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] cmdArgs = command.Split();
                string operation = cmdArgs[0];

                if (operation == "add")
                {
                    int firstNum = int.Parse(cmdArgs[1]);
                    int secondNum = int.Parse(cmdArgs[2]);

                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }

                else if (operation == "remove")
                {
                    int countOfNumbersToRemove = int.Parse(cmdArgs[1]);
                    if (stack.Count > countOfNumbersToRemove)
                    {
                        for (int i = 0; i < countOfNumbersToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            int sum = stack.Sum(); // !!! така намираме сумата най-лесно

            //int suma = 0;

            //while (stack.Count > 0)             /////
            //{                                 ////
            //    int number = stack.Pop(); ///////     пълният вариант за намиране на сумата
            //    suma += number;              //// 
            //}                                 /////

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
