using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_QuotedStrings
{
    class QuotedStrings
    {
        static void Main(string[] args)
        {
            string withoutQuotedString = "The \"use\" of quotation causes difficulties.";
            string quotedString = @"The ""use"" of quotation causes difficulties.";

            Console.WriteLine("@-quoted string: " + quotedString);
            Console.WriteLine("without @-quoted string: " + withoutQuotedString);
        }
    }
}
