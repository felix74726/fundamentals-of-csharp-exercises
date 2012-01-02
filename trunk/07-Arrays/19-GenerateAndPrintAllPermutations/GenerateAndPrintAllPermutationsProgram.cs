using System;
using System.Linq;

namespace _19_GenerateAndPrintAllPermutations
{
    class GenerateAndPrintAllPermutationsProgram
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            GeneratePermutations(array, 0, array.Length - 1);
        }

        static void GeneratePermutations(int[] array, int k, int m)
        {
            if (k == m)
            {
                PrintAllPermutations(m, array);
            }
            else
            {
                for (int i = k; i <= m; i++)
                {
                    if (array[i] != array[k])
                    {
                        Swap(ref array[k], ref array[i]);
                        GeneratePermutations(array, k + 1, m);
                        Swap(ref array[k], ref array[i]);
                    }
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

        private static void PrintAllPermutations(int m, int[] array)
        {
            for (int i = 0; i <= m; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
    }
}
