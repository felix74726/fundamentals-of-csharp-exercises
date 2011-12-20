using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_AppropriateVariablesNames
{
    class AppropriateVariablesNames
    {
        static void Main(string[] args)
        {
            ushort ushortNumber = 52130;
            sbyte sbytenumber = -115;
            long longNumber = 4825932L;
            byte byteNumber = 97;
            short shortNumber = -10000;

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}",
                ushortNumber, sbytenumber, longNumber, byteNumber, shortNumber);
        }
    }
}
