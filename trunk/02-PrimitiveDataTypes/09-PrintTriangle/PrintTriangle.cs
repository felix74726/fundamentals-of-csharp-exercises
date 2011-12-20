using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09_PrintTriangle
{
    class PrintTriangle
    {
        static void Main(string[] args)
        {
            UnicodeEncoding unicode = new UnicodeEncoding();
            string encodingName = unicode.EncodingName;
            Console.OutputEncoding = Encoding.UTF8;

            char ch = '\u00a9';

            Console.WriteLine("   {0}", ch);
            Console.WriteLine("  {0} {0}", ch);
            Console.WriteLine(" {0}   {0}", ch);
            Console.WriteLine("{0} {0} {0} {0}", ch);
        }
    }
}
