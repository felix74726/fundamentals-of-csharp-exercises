using System;

namespace _05_MaximalIncreasingSequenceInArray
{
    class MaximalIncreasingSequenceInArray
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

            int increasingSequence = 0;
            int counter = 0;
            int firstNumberInSequence = 0;
            for (int index = 0; index < length - 1; index++)
            {
                if(array[index] + 1 == array[index + 1])
                {
                    counter++;
                    if (counter > increasingSequence)
                    {
                        increasingSequence = counter;
                    }
                    if (counter == 1)
                    {
                        firstNumberInSequence = index;
                    }
                }
                if ((array[index] + 1 != array[index + 1]))
                {
                    counter = 0;
                }
            }

            Console.Write("{");
            for (int index = firstNumberInSequence; 
                index <= firstNumberInSequence + increasingSequence; index++)
            {
                Console.Write("{0},", array[index]);
            }
            Console.WriteLine("}");
        }
    }
}
