using System;
using System.Linq;

namespace _03_FindBiggestNumber
{
    class FindBiggestNumber
    {
        static void Main(string[] args)
        {
            Console.Write("First Number = ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Second Number = ");
            int secondNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Third number: ");
            int thirdNumber = Int32.Parse(Console.ReadLine());

            if((firstNumber > secondNumber) && (firstNumber > thirdNumber))
            {
                Console.WriteLine("The biggest number is: {0}", firstNumber);
            }
            else if ((secondNumber > firstNumber) && (secondNumber > thirdNumber))
            {
                Console.WriteLine("The biggest number is: {0}", secondNumber);
            }
            else
            {
                Console.WriteLine("The biggest number is: {0}", thirdNumber);
            }
        }
    }
}
