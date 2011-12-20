using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintCurrentDateAndTime
{
    class PrintCurrentDateAndTime
    {
        static void Main(string[] args)
        {
            DateTime currentDateAndTime = DateTime.Now;
            Console.WriteLine(currentDateAndTime);
        }
    }
}
