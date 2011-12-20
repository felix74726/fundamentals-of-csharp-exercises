using System;

namespace _02_NotDivisibleTo3And7
{
    class NotDivisibleTo3And7
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if((i % 7 == 0) && (i % 3 == 0))
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
