using System;

namespace _05_ArrayElement
{
    class ArrayElement
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 1, 5, 16, 7, 9 };
            int index = 5;

            Console.WriteLine(BiggerOrNotFromNeightboors(index, array));
        }

        static bool BiggerOrNotFromNeightboors(int index, int[] array)
        {
            bool isBigger = false;
            if(index != 0 && index != array.Length)
            {
                if((array[index] > array[index - 1]) && (array[index] > array[index + 1]))
                {
                    isBigger = true;
                }
            }

            return isBigger;
        }
    }
}
