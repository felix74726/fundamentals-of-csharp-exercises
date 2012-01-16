using System;

namespace _04_CountNumberInArray
{
    class CountNumberInArray
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 1, 4, 6, 3, 4, 2, 4, 6, 7, 9 };
            int number = 2;
            Console.WriteLine(CountAppears(number, array));
        }

        static int CountAppears(int number, int[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(number == array[i])
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
