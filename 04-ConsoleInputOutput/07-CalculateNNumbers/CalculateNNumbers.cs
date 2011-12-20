using System;
using System.Linq;

namespace _07_CalculateNNumbers
{
    class CalculateNNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Int32.Parse(Console.ReadLine());

            int sum = 0;
            int number;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a number: ");
                number = Int32.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine("The sum of the numbers: {0}", sum);
        }
    }
}
