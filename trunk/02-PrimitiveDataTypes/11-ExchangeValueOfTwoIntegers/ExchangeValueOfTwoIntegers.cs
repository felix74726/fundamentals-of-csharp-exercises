using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11_ExchangeValueOfTwoIntegers
{
    class ExchangeValueOfTwoIntegers
    {
        static void Main(string[] args)
        {
            Console.Write("First number: ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int secondNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Numbers value before exchange: ");
            Console.WriteLine("First number: {0}", firstNumber);
            Console.WriteLine("Second number: {0}",secondNumber);

            firstNumber ^= secondNumber;
            secondNumber ^= firstNumber;
            firstNumber ^= secondNumber;

            Console.WriteLine("Numbers value after exchange: ");
            Console.WriteLine("First number: {0}", firstNumber);
            Console.WriteLine("Second number: {0}",secondNumber);
        }
    }
}
