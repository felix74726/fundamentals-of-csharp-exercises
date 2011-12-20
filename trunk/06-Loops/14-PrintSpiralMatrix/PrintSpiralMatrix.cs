using System;

namespace _14_PrintSpiralMatrix
{
    class PrintSpiralMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int row;
            int col;
            int i;
            int value = 1;

            for (row = 0, col = n - 1; col >= 0; row++, col--)
            {
                for (i = row; i < col; i++)
                {
                    matrix[row, i] = value;
                    value++;
                }
                for (i = row; i < col; i++)
                {
                    matrix[i, col] = value;
                    value++;
                }
                for (i = col; i > row; i--)
                {
                    matrix[col, i] = value;
                    value++;
                }
                for (i = col; i > row; i--)
                {
                    matrix[i, row] = value;
                    value++;
                }
            }

            if (n % 2 != 0)
            {
                matrix[(n / 2), (n / 2)] = value;
            }

            for (row = 0; row < n; row++)
            {
                for (col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
