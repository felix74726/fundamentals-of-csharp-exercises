using System;

namespace _08_CalculateTrapezoidArea
{
    class CalculateTrapezoidArea
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = Double.Parse(Console.ReadLine());
            Console.Write("h = ");
            double h = Double.Parse(Console.ReadLine());

            double area = ((a + b) / 2) * h;

            Console.WriteLine("The area of the trapezoid is: {0}", area);
        }
    }
}
