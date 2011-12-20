using System;

namespace _07_PrimeOrNotInteger
{
    class PrimeOrNotInteger
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: <= 100: ");
            int number = Int32.Parse(Console.ReadLine());
            bool prime = true;

            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                }
            }

            Console.WriteLine("Prime? " + prime);
        }
    }
}
