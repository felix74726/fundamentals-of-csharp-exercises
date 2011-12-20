using System;

namespace _10_IsPBitOneChecker
{
    class IsPBitOneChecker
    {
        static void Main(string[] args)
        {
            Console.Write("Entrer one integer number: ");
            int v = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the position p: ");
            int p = Int32.Parse(Console.ReadLine());

            int mask = 1 << p;        
            int nAndMask = v & mask;  
            int bit = nAndMask >> p; 
            bool isPBitOne = false;
            if(bit == 1)
            {
                isPBitOne = true;
            }
            Console.WriteLine(isPBitOne); 
        }
    }
}
