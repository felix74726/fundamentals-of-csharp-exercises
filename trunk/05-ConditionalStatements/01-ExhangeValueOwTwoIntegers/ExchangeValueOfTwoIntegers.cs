using System;
using System.Linq;

namespace _01_ExhangeValueOwTwoIntegers
{
    class ExchangeValueOfTwoIntegers
    {
        static void Main(string[] args)
        {
            Console.Write("First number: ");
            int firstNUmber = Int32.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int secondNumber = Int32.Parse(Console.ReadLine());

            if (firstNUmber > secondNumber)
            {
                firstNUmber ^= secondNumber;
                secondNumber ^= firstNUmber;
                firstNUmber ^= secondNumber;
            }

            Console.WriteLine("First number: " + firstNUmber);
            Console.WriteLine("Second number: " + secondNumber);
        }
    }
}
