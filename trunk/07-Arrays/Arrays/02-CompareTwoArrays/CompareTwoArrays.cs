using System;

namespace _02_CompareTwoArrays
{
    class CompareTwoArrays
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the arrays: ");
            int arraysLength = Int32.Parse(Console.ReadLine());

            int[] firstArray = new int[arraysLength];
            int[] secondArray = new int[arraysLength];

            Console.WriteLine("Enter the elements of the first array: ");
            for (int index = 0; index < arraysLength; index++)
            {
                Console.Write("firstArray[{0}] = ", index);
                firstArray[index] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the elements of the second array: ");
            for (int index = 0; index < arraysLength; index++)
            {
                Console.Write("secondArray[{0}] = ", index);
                secondArray[index] = Int32.Parse(Console.ReadLine());
            }

            for (int index = 0; index < arraysLength; index++)
            {
                if(firstArray[index] > secondArray[index])
                {
                    Console.WriteLine("firstArray[{0}] > secondArray[{0}]", index);
                }
                else if (firstArray[index] < secondArray[index])
                {
                    Console.WriteLine("secondArray[{0}] < firstArray[{0}]", index);
                }
                else
                {
                    Console.WriteLine("firstArray[{0}] == secondArray[{0}]", index);
                }
            }
        }
    }
}
