using System;

namespace _03_ReturnMinAndMaxNumber
{
    class ReturnMinAndMaxNumber
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers: ");
            int numbersOfSequences = Int32.Parse(Console.ReadLine());

            int number;
            int minValue = Int32.MaxValue;
            int maxValue = Int32.MinValue;

            for (int i = 0; i < numbersOfSequences; i++)
            {
                Console.Write("Enter a number: ");
                number = Int32.Parse(Console.ReadLine());
                if(number > maxValue)
                {
                    maxValue = number;
                }
                else if (number < minValue)
                {
                    minValue = number;
                }
            }

            Console.WriteLine("Max number is: {0}", maxValue);
            Console.WriteLine("Min number is: {0}", minValue);
        }
    }
}
