using System;

namespace _04_MaximalSequenceOfEqualElements
{
    class MaximalSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] array = new int[length];

            for (int index = 0; index < length; index++)
            {
                Console.Write("array[{0}] = ", index);
                array[index] = Int32.Parse(Console.ReadLine());
            }

            int maximalSequence = 0;
            int firstIndex = 0;
            int lastIndex = 0;
            int counter = 0;
            for (int index = 0; index < length - 1; index++)
            {
                if(array[index] == array[index + 1])
                {
                    counter++;
                    if (counter > maximalSequence)
                    {
                        maximalSequence = counter;
                        lastIndex = index + 1;
                    }
                }
                if ((
                    counter == maximalSequence) && (array[index] != array[index + 1]))
                {
                    lastIndex = index;
                    counter = 0;
                }
            }

            firstIndex = lastIndex - maximalSequence;

            Console.Write("{");
            for (int index = firstIndex; index <= lastIndex; index++)
            {
                Console.Write("{0},", array[index]);
            }
            Console.WriteLine("}");
        }
    }
}
