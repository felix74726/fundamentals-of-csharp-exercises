using System;
using System.Linq;

namespace _20_GenerateAllVariationsOfK
{
    class GenerateAllVariationsOfK
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = Int32.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            GenerateAllVariations(array, 0, array.Length - 1, k - 1);
        }

        static void GenerateAllVariations(int[] array, int index, int length, int k)
        {
            if (index == length)
            {
                PrintAllPermutations(k, array);
            }
            else
            {
                for (int i = index; i <= length; i++)
                {
                    Swap(ref array[index], ref array[i]);
                    GenerateAllVariations(array, index + 1, length, k);
                    Swap(ref array[index], ref array[i]);
                }
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            if (a == b)
            {
                return;
            }
            else
            {
                a ^= b;
                b ^= a;
                a ^= b;
            }
        }

        private static void PrintAllPermutations(int length, int[] array)
        {
            for (int i = 0; i <= length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
    }
}
