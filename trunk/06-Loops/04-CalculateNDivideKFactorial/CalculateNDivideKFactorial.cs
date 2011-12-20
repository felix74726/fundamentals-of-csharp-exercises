﻿using System;
using System.Numerics;

namespace _04_CalculateNDivideKFactorial
{
    class CalculateNDivideKFactorial
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = Int32.Parse(Console.ReadLine());

            BigInteger nFactorial = 1;
            for (int i = n; i > 0; i--)
            {
                nFactorial *= i;
            }

            BigInteger kFactorial = 1;
            for (int i = k; i > 0; i-- )
            {
                kFactorial *= i;
            }

            BigInteger result = nFactorial / kFactorial;

            Console.WriteLine(result);
        }
    }
}
