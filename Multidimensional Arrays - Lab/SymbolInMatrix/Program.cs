using System;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];


            for (int row = 0; row < size; row++)
            {
                string colElements = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            char symbolToLookFor = char.Parse(Console.ReadLine());
            bool isFound = false;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == symbolToLookFor)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }

            if (isFound == false)
            {
                Console.WriteLine($"{symbolToLookFor} does not occur in the matrix");
            }
        }
    }
}
