using System;
using System.Linq;

namespace _09_PrintFirst100FibonachiSequence
{
    class PrintFirst100FibonachiSequence
    {
        static void Main(string[] args)
        {
            decimal previous = 0;
            decimal result = 1;
            decimal sum = 0;

            for (int i = 0; i < 100; i++)
            {
                sum = result + previous;
                previous = result;
                result = sum;
                Console.WriteLine(result);
            }
        }
    }
}
