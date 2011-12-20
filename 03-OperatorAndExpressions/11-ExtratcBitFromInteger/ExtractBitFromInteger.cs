using System;

namespace _11_ExtratcBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            Console.Write("i = ");
            int i = Int32.Parse(Console.ReadLine());

            Console.Write("p = ");
            int p = Int32.Parse(Console.ReadLine());

            int mask = (1 << p);
            int result = i & mask;
            Console.WriteLine("Result: " + result);  
        }
    }
}
