using System;

namespace _01_OddOrEvenInteger
{
    class OddOrEvenINtegerr
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Int32.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number {0} is even.", number);
            }
            else
            {
                Console.WriteLine("The number {0} is odd.", number);
            }
        }
    }
}
