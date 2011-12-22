using System;

namespace _07_SortingArrayWithSelectionSort
{
    class SortingArrayWithSelectionSort
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array: ");
            int length = Int32.Parse(Console.ReadLine());
            int[] array = new int[length];

            for (int index = 0; index < length; index++)
            {
                Console.Write("array[{0}] = ", index);
                array[index] = Int32.Parse(Console.ReadLine());
            }

            int temp = 0;
            int minValue = 0;
            for (int i = 0; i < length - 1; i++)
            {
                minValue = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (array[j] < array[minValue])
                    {
                        minValue = j;
                    }
                }

                temp = array[i];
                array[i] = array[minValue];
                array[minValue] = temp;
                //array[i] ^= array[minValue];
                //array[minValue] ^= array[i];
                //array[i] ^= array[minValue];
            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
