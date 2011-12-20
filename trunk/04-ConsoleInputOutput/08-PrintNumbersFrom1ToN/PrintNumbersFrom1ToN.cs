using System;
using System.Linq;

namespace _08_PrintNumbersFrom1ToN
{
    class PrintNumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
