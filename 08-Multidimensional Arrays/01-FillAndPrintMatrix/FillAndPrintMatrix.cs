using System;

namespace _01_FillAndPrintMatrix
{
    class FillAndPrintMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            //Console.WriteLine("a)");
            //Console.WriteLine();
            //matrix = FillMatrixUpToDown(matrix);
            //PrintMatrix(matrix);

            //Console.WriteLine("b)");
            //Console.WriteLine();
            //matrix = FillMatrixUpToDownAndUp(matrix);
            //PrintMatrix(matrix);

            matrix = FillMatrixSpiral(matrix);
            PrintMatrix(matrix);

        }

        private static int[,] FillMatrixSpiral(int[,] matrix)
        {
            int value = 1;
            int n = matrix.GetLength(0);
            int col = 0;
            int temp = 0;
            int row2 = n - 1;
            int length = n;
            for (int row = 0; row < Math.Sqrt(n); row++)
            {
                for (col = temp; col < length; col++)
                {
                    matrix[col, row] = value;
                    value++;
                }
                n--;
                for (col = row + 1; col <= n; col++)
                {
                    matrix[row2, col] = value;
                    value++;
                }
                for (col = n - 1; col >= 0; col--)
                {
                    matrix[col, n] = value;
                    value++;
                }
                n--;
                for (col = n; col > temp; col--)
                {
                    matrix[row, col] = value;
                    value++;
                }
                temp++;
                row2--;
                length--;
                if (n == 0)
                {
                    break;
                }
            }
            return matrix;
        }

        private static int[,] FillMatrixUpToDown(int[,] matrix)
        {
            int value = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[col, row] = value;
                    value++;
                }
            }
            return matrix;
        }

        private static int[,] FillMatrixUpToDownAndUp(int[,] matrix)
        {
            int value = 1;
            int length = matrix.GetLength(0) - 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row % 2 == 0)
                    {
                        matrix[col, row] = value;
                        value++;
                    }
                    else
                    {
                        matrix[length, row] = value;
                        value++;
                        length--;
                    }
                }
                length = matrix.GetLength(0) - 1;
            }
            return matrix;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0}\t", matrix[row, col]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}