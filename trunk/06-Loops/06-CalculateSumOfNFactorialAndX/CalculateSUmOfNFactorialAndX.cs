using System;
using System.Numerics;

namespace _06_CalculateSumOfNFactorialAndX
{
    class CalculateSUmOfNFactorialAndX
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("X = ");
            int x = Int32.Parse(Console.ReadLine());

            BigInteger s = 1;
            BigInteger factorial = 1;
            BigInteger xByX = 1;
            for (int i = 1; i <= n; i++)
            {
                xByX *= x;
                factorial *= i;

                s += (factorial / xByX);
            }
            Console.WriteLine(s);
        }
    }
}
