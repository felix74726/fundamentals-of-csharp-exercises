using System;
using System.Collections.Generic;
using System.Linq;

namespace _17_SubsetOfKElemetdsWithSumS
{
    class SubsetOfKElemetdsWithSumS
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());

            Console.Write("K = ");
            int k = Int32.Parse(Console.ReadLine());

            Console.Write("S = ");
            int s = Int32.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = Int32.Parse(Console.ReadLine());
            }

            int j = 0;
            int sum = 0;
            List<int> elements = new List<int>();
            for (int i = 0; i < array.Length - k + 1; i++)
            {
                for (j = i; j < k; j++)
                {
                    elements.Add(array[j]);
                    sum += array[j];
                    if(sum == s)
                    {
                        PrintElements(elements);
                        break;
                    }
                    if(sum > s)
                    {
                        break;
                    }
                }
                k++;
                elements.Clear();
                sum = 0;
            }
        }

        private static void PrintElements(List<int> elements)
        {
            Console.Write("{");
            foreach (int element in elements)
            {
                Console.Write(" {0} ", element);
            }
            Console.WriteLine("}");
        }
    }
}
