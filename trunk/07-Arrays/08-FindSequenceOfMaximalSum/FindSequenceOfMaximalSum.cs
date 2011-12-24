using System;

namespace _08_FindSequenceOfMaximalSum
{
    class FindSequenceOfMaximalSum
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int index = 0; index < array.Length; index++)
            {
                Console.Write("array[{0}] = ", index);
                array[index] = Int32.Parse(Console.ReadLine());
            }

            int sum = 0;
            int bestSum = Int32.MinValue;
            int counter = 0;
            int firstIndex = 0;
            for (int index = 0; index < array.Length; index++)
            {
                sum += array[index];
                counter++;
                if(sum < 0)
                {
                    sum = 0;
                    counter = 0;
                }
                else if(sum > bestSum)
                {
                    bestSum = sum;
                    firstIndex = index - counter;
                }
            }

            for (int index = firstIndex + 1; index < counter + firstIndex; index++)
            {
                Console.Write("{0} ", array[index]);
            }
        }
    }
}
