using System;

namespace _13_ExchangeBits
{
    class ExchangeBits
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            uint number = UInt32.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            uint lowBitsMask = number & (uint)(7 << 3);
            uint hightBitsMask = number & (uint)(7 << 24);

            uint result = number & ~(uint)(7 << 3);
            result &= (number & ~(uint)(7 << 24));

            result = result | (lowBitsMask << 20);
            result = result | (hightBitsMask >> 20);
            
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
        }
    }
}
