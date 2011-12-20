using System;

namespace _03_AreaOfRectangle
{
    class AreaOfRectangle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rectangle's width: ");
            double width = Double.Parse(Console.ReadLine());

            Console.Write("Enter rectangle's height: ");
            double height = Double.Parse(Console.ReadLine());

            double area = width * height;

            Console.WriteLine("The are of the rectangle is: {0}", area);
        }
    }
}
