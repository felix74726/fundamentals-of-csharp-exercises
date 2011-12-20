using System;
using System.Linq;

namespace _01_PrintSumOfThreeIntegers
{
    class PrintSumOfThreeIntegers
    {
        static void Main(string[] args)
        {
            Console.Write("First number = ");
            int firstNUmber = Int32.Parse(Console.ReadLine());
            Console.Write("Second number = ");
            int secondNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Third number = ");
            int thirdNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} + {2} = {3}",
                firstNUmber, secondNumber, thirdNumber,
                (firstNUmber + secondNumber + thirdNumber));
        }
    }
}
