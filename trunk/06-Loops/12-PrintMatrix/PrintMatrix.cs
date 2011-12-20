using System;

namespace _12_PrintMatrix
{
    class PrintMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Int32.Parse(Console.ReadLine());

            int value = 0;
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                value = row + 1;
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = value;
                    value++;
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
