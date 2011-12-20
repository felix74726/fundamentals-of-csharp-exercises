using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_DoubleOrFloat
{
    class DoubleOrFloat
    {
        static void Main(string[] args)
        {
            double doubleValueOne = 34.567839023;
            float floatValueOne = 12.345f;
            double doubleValueTwo = 8923.1234857;
            float floatValueTwo = 3456.091f;

            Console.WriteLine("{0} {1} {2} {3}",
                doubleValueOne, floatValueOne, doubleValueTwo, floatValueTwo);
        }
    }
}
