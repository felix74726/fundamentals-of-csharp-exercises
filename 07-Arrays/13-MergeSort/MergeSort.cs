using System;

namespace _13_MergeSort
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = n - 1; j >= i; --j)
                {
                    if (array[j - 1] > array[j])
                    {
                        array[j - 1] ^= array[j];
                        array[j] ^= array[j - 1];
                        array[j - 1] ^= array[j];
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }
        }
    }
}