using System;
using System.Collections.Generic;

namespace _10_FindSequenceOfMaximalSum
{
    class FindSequenceOfMaximalSum
    {
        static void Main(string[] args)
        {
            Console.Write("S = ");
            int s = Int32.Parse(Console.ReadLine());
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int index = 0; index < array.Length; index++)
            {
                Console.Write("array[{0}] = ", index);
                array[index] = Int32.Parse(Console.ReadLine());
            }

            int sum = 0;
            List<int> list = new List<int>();
            for (int index = 0; index < array.Length; index++)
            {
                sum += array[index];
                list.Add(array[index]);
                if (sum == s)
                {
                    PrintLsit(list);
                }
                else if (sum > s)
                {
                    sum = array[index];
                    list.Clear();
                    list.Add(array[index]);
                }
            }
        }

        private static void PrintLsit(List<int> list)
        {
            Console.Write("{ ");
            foreach (int item in list)
            {
                Console.Write("{0} ", item);
            }
            Console.Write("}");
        }
    }
}