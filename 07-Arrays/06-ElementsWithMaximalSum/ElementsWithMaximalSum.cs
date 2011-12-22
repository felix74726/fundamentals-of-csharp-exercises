using System;
using System.Collections.Generic;

namespace _06_ElementsWithMaximalSum
{
    class ElementsWithMaximalSum
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = Int32.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write("array[{0}] = ", index);
                array[index] = Int32.Parse(Console.ReadLine());
            }

            int sum = 0;
            int biggerSum = 0;
            int[] maximalSumElements = new int[k];
            List<int> list = new List<int>();
            int temp = k;
            int j = 0;
            int variable = 0;
            for (int i = 0; i < n - k + 1; i++)
            {
                for (j = variable; j < temp; j++)
                {
                    list.Add(array[j]);
                    sum += array[j];
                    if(sum > biggerSum)
                    {
                        biggerSum = sum;
                        maximalSumElements = list.ToArray();
                    }
                }
                list.Clear();
                temp++;
                variable++;
                sum = 0;
            }

            Console.WriteLine("Elements with maximum sum: ");
            foreach(int element in maximalSumElements)
            {
                Console.WriteLine(element);
            }
        }
    }
}
