using System;
using System.Collections.Generic;
using System.Linq;

namespace _16_SubsetsWithSumS
{
    class SubsetsWithSumS
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("S = ");
            int s = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = Int32.Parse(Console.ReadLine());
            }

            HasSubsetWithSumS(s, array);
        }

        static void HasSubsetWithSumS(int s, int[] array)
        {
            Array.Sort(array);
            List<int> subsetElemets = new List<int>();

            int sum = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    sum += array[j];
                    subsetElemets.Add(array[j]);
                    if(sum == s)
                    {
                        PrintSubsetElements(s, subsetElemets);
                        //sum = 0;
                        break;
                    }
                    if(sum > s)
                    {
                        sum = 0;
                        subsetElemets.Clear();
                    }
                }
            }
        }

        private static void PrintSubsetElements(int s, List<int> subsetElements)
        {
            Console.Write("yes(");
            for (int i = 0; i < subsetElements.Count; i++)
            {
                if (i == subsetElements.Count - 1)
                {
                    Console.WriteLine("{0})", subsetElements[i]);
                }
                else
                {
                    Console.Write("{0} + ", subsetElements[i]);
                }
            }
        }
    }
}