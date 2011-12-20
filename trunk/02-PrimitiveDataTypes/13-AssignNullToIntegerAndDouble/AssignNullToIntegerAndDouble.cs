using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13_AssignNullToIntegerAndDouble
{
    class AssignNullToIntegerAndDouble
    {
        static void Main(string[] args)
        {
            int integerNull = Int32.Parse(null);
            double doubleNull = Double.Parse(null);

            Console.WriteLine(integerNull);
            Console.WriteLine(doubleNull);
        }
    }
}
