using System;
using System.Numerics;

namespace _13_CalculateTrailingZerosOfNFactorial
{
    class CalculateTrailingZerosOfNFactorial
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            for (int i = n; i > 0; i--)
            {
                factorial *= i;
            }

            int zeros = 0;
            for (int i = 5; i <= n; i *= 5)
            {
                zeros += n / i;
            }
            Console.WriteLine("Trailing zeros: {0}", zeros);
        }
    }
}
