using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_ComparesFloatingPoint
{
    class ComparesFloatingPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first floating point number: ");
            decimal firstNumber = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second floating point number: ");
            decimal secondNumber = Decimal.Parse(Console.ReadLine());

            bool areEquals = false;
            if(firstNumber == secondNumber)
            {
                areEquals = true;
            }

            Console.WriteLine("Are equals: {0}", areEquals);
        }
    }
}
