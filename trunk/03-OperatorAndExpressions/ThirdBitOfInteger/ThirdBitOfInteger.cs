using System;

namespace ThirdBitOfInteger
{
    class ThirdBitOfInteger
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Int32.Parse(Console.ReadLine());

            if ((number & (1 << 3)) == 0)
            {
                Console.WriteLine("The thir bit of integer {0} is 0",
                    number);
            }
            else
            {
                Console.WriteLine("The third bit of integer {0} is 1",
                    number);
            }
        }
    }
}
