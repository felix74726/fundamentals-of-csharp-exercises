using System;

namespace _11_FindIndexWithBinarySearch
{
    class FindIndexWithBinarySearch
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Element = ");
            int element = Int32.Parse(Console.ReadLine());

            int[] sortedArray = new int[n];
            for (int index = 0; index < sortedArray.Length; index++)
            {
                Console.Write("array[{0}] =", index);
                sortedArray[index] = Int32.Parse(Console.ReadLine());
            } 
            Array.Sort(sortedArray);

            Console.WriteLine("Sorted array: ");
            for (int index = 0; index < sortedArray.Length; index++)
            {
                Console.WriteLine("sortedArray[{0}] = {1}", index, sortedArray[index]);
            }

            int elementIndex = BinarySearch(sortedArray, element, 0, sortedArray.Length);
            Console.WriteLine("The index of {0} is: {1}",
                element, elementIndex);
        }

        private static int BinarySearch(int[] array, int element, int min, int max)
        {
            if(max < min)
            {
                return -1;
            }
            int middle = (min + max) / 2;

            if(array[middle] > element)
            {
                return BinarySearch(array, element, min, middle - 1);
            }
            else if(array[middle] < element)
            {
                return BinarySearch(array, element, middle + 1, max);
            }
            else
            {
                return middle;
            }
        }
    }
}
