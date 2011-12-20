using System;

namespace _01_IntegerArrayAllocateAndInitialize
{
    class IntegerArrayAllocateAndInitialize
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];

            for (int index = 0; index < arr.Length; index++)
            {
                arr[index] = index * 5;
            }

            for (int index = 0; index < arr.Length; index++)
            {
                Console.WriteLine("arr[{0}] = {1}", index, arr[index]);
            }
        }
    }
}
