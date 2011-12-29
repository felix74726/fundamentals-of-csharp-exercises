using System;
using System.Collections.Generic;

namespace _15_SieveofEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int n = 10000000;
            double biggestSquareRoot = Math.Sqrt(n);
            bool[] eliminated = new bool[n];

            List<long> primeList = new List<long>();
            primeList.Add(2);
            for (int i = 3; i <= n; i += 2)
            {
                if (!eliminated[i])
                {
                    if (i < biggestSquareRoot)
                    {
                        for (int j = i * i; j <= n; j += 2 * i)
                        {
                            eliminated[j] = true;
                        }
                    }
                    primeList.Add(i);  
                }
            }

            foreach (var item in primeList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
