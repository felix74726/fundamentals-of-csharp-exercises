using System;

namespace _06_IsXAndYInACricle
{
    class IsXAndYInACircle
    {
         static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = Double.Parse(Console.ReadLine());

            if ((x > -5 && x < 5) && ((y > -5) && (y < 5)))
            {
                Console.WriteLine("The point {0},{1} is inside a circle K(0, 5)", x, y);
            }
            else
            {
                Console.WriteLine("The point {0},{1} is not inside a circle K(0, 5)", x, y);
            }
        }
    }
}
