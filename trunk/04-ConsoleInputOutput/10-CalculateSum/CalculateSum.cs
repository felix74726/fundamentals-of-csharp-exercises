using System;
using System.Linq;

namespace _10_CalculateSum
{
    class CalculateSum
    {
        static void Main(string[] args)
        {
            double newSum = 1;
            double oldSum = 0;

            for (int i = 2; Math.Abs(newSum - oldSum) > 0.001; i++)
            {
                oldSum = newSum;
                if (i % 2 == 0)
                {
                    newSum += 1.0 / i;
                }
                else
                {
                    newSum += - 1.0 / i;
                }
            }

            Console.WriteLine("The sum with accuracy 0.001 is: {0:F3}", newSum);
        }
    }
}
