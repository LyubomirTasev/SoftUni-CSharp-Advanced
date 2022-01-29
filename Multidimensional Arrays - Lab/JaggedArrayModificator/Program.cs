using System;
using System.Linq;

namespace JaggedArrayModificator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedMatrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] subArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedMatrix[i] = new int[subArray.Length];

                for (int j = 0; j < subArray.Length; j++)
                {
                    jaggedMatrix[i][j] = subArray[j];
                }
            }
            string line = Console.ReadLine();

            while (line != "END")
            {
                string[] commandParts = line.Split();
                string action = commandParts[0];
                int row = int.Parse(commandParts[1]);
                int col = int.Parse(commandParts[2]);
                int value = int.Parse(commandParts[3]);

                if (row < 0 || row >= jaggedMatrix.Length || col < 0 || col >= jaggedMatrix[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    line = Console.ReadLine();
                    continue;
                }

                if (action == "Add")
                {
                    jaggedMatrix[row][col] += value;
                }
                else if (action == "Subtract")
                {
                    jaggedMatrix[row][col] -= value;
                }

                line = Console.ReadLine();
            }

            for (int i = 0; i < jaggedMatrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", jaggedMatrix[i]));
            }
        }
    }
}
