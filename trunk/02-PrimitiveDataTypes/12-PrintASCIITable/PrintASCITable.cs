using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12_PrintASCIITable
{
    class PrintASCITable
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 255; i++)
            {
                Console.WriteLine("{0} = {1}", i, (char)i);
            }
        }
    }
}
