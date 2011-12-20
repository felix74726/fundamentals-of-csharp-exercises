using System;

namespace _12_ModifyBit
{
    class ModifyBit
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("v = (0 or 1): ");
            byte v = Byte.Parse(Console.ReadLine());
            Console.Write("p = ");
            int p = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

            int mask = v << p;
            n = n & ~(mask);
            n = n | mask;
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));  
        }
    }
}
