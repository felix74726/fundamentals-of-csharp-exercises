using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_EqualNeightborElementsInMatrix
{
    class EqualNeightborElementsInMatrix
    {
        static void Main(string[] args)
        {
            int[,] matrix = 
            {
                { 1, 3, 2, 2, 2, 4 },
                { 3, 3, 3, 2, 4, 4 },
                { 4, 3, 2, 1, 3, 3 },
                { 4, 3, 1, 3, 3, 1 },
                { 4, 3, 3, 3, 1, 1 }
            };

            int currentElement = 0;
            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    currentElement = matrix[i, j];

                    FindValidEqualNeighborElement(matrix, i, j, currentElement);
                    counter = 0;
                }
            }
        }

        private static void CountEqualNeghborElements(int[,] matrix)
        {

        }

        static void FindValidEqualNeighborElement(int[,] matrix, int row, int col, int element)
        {
            int counter = 0;
            int largestAreaOfEqualNumber = 0;
            bool[,] visited = null ;
            if ((row >= matrix.GetLength(0)) || (row < 0) ||
                ((col >= matrix.GetLength(1)) || (col < 0)))
            {
                return;
            }

            if (visited[row, col])
            {
                return;
            }

            if (matrix[row, col] != element)
            {
                return;
            }

            if (matrix[row, col] == element)
            {
                visited[row, col] = true;

                counter++;
            }

            FindValidEqualNeighborElement(matrix, row + 1, col, element);
            FindValidEqualNeighborElement(matrix, row, col + 1, element);
            FindValidEqualNeighborElement(matrix, row - 1, col, element);
            FindValidEqualNeighborElement(matrix, row, col - 1, element);

            if (counter > largestAreaOfEqualNumber)
            {
                largestAreaOfEqualNumber = counter;
            }
        }
    }
}
