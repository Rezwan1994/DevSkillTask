using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][,] numbers = new int[][,]
            {
                new int[,] { {1,3}, {5,7} },
                new int[,] { {0,2}, {4,6}, {8,10} },
                new int[,] { {11,22}, {99,88}, {0,9} }
            };

            for (int i = 0; i < numbers.Length; i++)
            {
                int x = 0;
                for (int j = 0; j < numbers[i].GetLength(x); j++)
                {

                    for (int k = 0; k < numbers[j].Rank; k++)
                        Console.Write(numbers[i][j, k] + " ");
                    Console.WriteLine();
                }
                x++;
                Console.WriteLine();
            }
        }
    }
}
