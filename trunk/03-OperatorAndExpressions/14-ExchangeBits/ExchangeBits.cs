using System;

namespace _14_ExchangeBits
{
    class ExchangeBits
    {
        static void Main(string[] args)
        {
            Console.Write("p = ");
            int p = Int32.Parse(Console.ReadLine());
            Console.Write("q = ");
            int q = Int32.Parse(Console.ReadLine());
            Console.Write("k = ");
            uint k = UInt32.Parse(Console.ReadLine());

            Console.Write("Enter a number: ");
            uint number = UInt32.Parse(Console.ReadLine());

            uint lowBitsMask = 1;
            uint hightBitsMask = 1;

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            uint result = 0;
            for (int i = 1; i < k - 1; i++)
            {
                result = number & ~(uint)(1 << p);
                result &= (number & ~(uint)(1 << q));

                result = result | (lowBitsMask << p);
                result = result | (hightBitsMask >> q);
                p++;
                q++;
            }

            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
        }
    }
}
