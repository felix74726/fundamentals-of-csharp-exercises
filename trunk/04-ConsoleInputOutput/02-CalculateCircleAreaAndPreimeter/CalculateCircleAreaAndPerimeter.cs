using System;
using System.Linq;

namespace _02_CalculateCircleAreaAndPreimeter
{
    class CalculateCircleAreaAndPerimeter
    {
        static void Main(string[] args)
        {
            Console.Write("r = ");
            double r = Double.Parse(Console.ReadLine());

            double area = Math.PI * (r * r);
            double perimeter = 2 * (Math.PI * r);

            Console.WriteLine("The area of the circle is: {0}", area);
            Console.WriteLine("The perimeter of the circle is: {0}", perimeter);
        }
    }
}
