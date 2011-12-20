using System;

namespace _03_CompareCharArraysLexicographically
{
    class CompareCharArraysLexicographically
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the arrays: ");
            int arraysLength = Int32.Parse(Console.ReadLine());

            char[] firstArray = new char[arraysLength];
            char[] secondArray = new char[arraysLength];

            Console.WriteLine("Enter the characters of firstArray: ");
            for (int index = 0; index < arraysLength; index++)
            {
                Console.Write("firstArray[{0}] = ", index);
                firstArray[index] = Char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the characters of secondArray: ");
            for (int index = 0; index < arraysLength; index++)
            {
                Console.Write("secondArray[{0}] = ", index);
                secondArray[index] = Char.Parse(Console.ReadLine());
            }

            for (int index = 0; index < arraysLength; index++)
            {
                int compare = firstArray[index].CompareTo(secondArray[index]);

                if(compare < 0)
                {
                    Console.WriteLine("{0} > {1}", firstArray[index], secondArray[index]);
                }
                else if (compare > 0)
                {
                    Console.WriteLine("{0} < {1}", firstArray[index], secondArray[index]);
                }
                else
                {
                    Console.WriteLine("{0} = {1}", firstArray[index], secondArray[index]);
                }
            }
        }
    }
}
