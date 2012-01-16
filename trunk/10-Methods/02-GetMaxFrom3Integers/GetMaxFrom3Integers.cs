using System;

namespace _02_GetMaxFrom3Integers
{
    class GetMaxFrom3Integers
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = Int32.Parse(Console.ReadLine());

            int biggerNumber = GetMax(GetMax(a, b), c);
            Console.WriteLine("The bigger number is: {0}", biggerNumber);
        }

        static int GetMax(int a, int b)
        {
            int max = a;
            if(b > a)
            {
                max = b;
            }

            return max;
        }
    }
}
