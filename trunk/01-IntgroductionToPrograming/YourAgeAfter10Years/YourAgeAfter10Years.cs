using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YourAgeAfter10Years
{
    class YourAgeAfter10Years
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine(age + 10);
        }
    }
}
