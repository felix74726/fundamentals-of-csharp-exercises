using System;

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
            int temp = k;
            int j = 0;
            int variable = 0;
            for (int i = 0; i < n - k; i++)
            {
                for (j = variable; j < temp; j++)
                {
                    sum += array[j];
                    if(sum > biggerSum)
                    {
                        biggerSum = sum;
                    }
                }
                temp++;
                variable++;
                sum = 0;
            }

            Console.WriteLine(biggerSum);
        }
    }
}
