using System;

namespace _09_TheMostFrequentNumber
{
    class TheMostFrequentNumbers
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

            Array.Sort(array);

            int counter = 1;
            int mostFrequentNumber = 0;
            int frequencyCount = Int32.MinValue;
            for (int index = 0; index < array.Length - 1; index++)
            {
                if (array[index] == array[index + 1])
                {
                    counter++;
                    if (frequencyCount < counter)
                    {
                        mostFrequentNumber = array[index];
                        frequencyCount = counter;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            Console.WriteLine("The most frequent number is: {0} with {1} times containing.", 
                mostFrequentNumber, frequencyCount);
        }
    }
}
