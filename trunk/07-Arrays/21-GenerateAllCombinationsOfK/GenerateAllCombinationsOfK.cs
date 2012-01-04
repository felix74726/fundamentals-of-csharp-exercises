using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21_GenerateAllCombinationsOfK
{
    class GenerateAllCombinationsOfK
    { 
        static void Main(string[] args)
        {
            int n = 5;
            int k = 2;

            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            GenerateAllCombinations(array, 0, array.Length - 1, k - 1);
        }

        static void GenerateAllCombinations(int[] array, int index, int length, int k)
        {
            if (index == length)
            {
                PrintAllPermutations(k, array);
            }
            else
            {
                for (int i = index; i <= length; i++)
                {
                    if (array[length] == k)
                    {
                        break;
                    }

                    Swap(ref array[index], ref array[i]);
                    GenerateAllCombinations(array, index + 1, length, k);
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