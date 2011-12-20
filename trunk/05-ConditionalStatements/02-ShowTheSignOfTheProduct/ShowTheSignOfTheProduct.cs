using System;
using System.Linq;

namespace _02_ShowTheSignOfTheProduct
{
    class ShowTheSignOfTheProduct
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = Int32.Parse(Console.ReadLine());

            if(a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("The product is 0!");
                return;
            }
            if ((a < 0 && b < 0) && c > 0)
            {
                Console.WriteLine("+");
            }
            else if ((a < 0 && c < 0) && b > 0)
            {
                Console.WriteLine("+");
            }
            else if ((b < 0 && c < 0) && a > 0)
            {
                Console.WriteLine("+");
            }
            else if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}