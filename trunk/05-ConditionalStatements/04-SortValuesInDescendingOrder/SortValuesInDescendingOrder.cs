using System;
using System.Linq;

namespace _04_SortValuesInDescendingOrder
{
    class SortValuesInDescendingOrder
    {
        static void Main(string[] args)
        {
            Console.Write("First Number = ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Second Number = ");
            int secondNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Third number: ");
            int thirdNumber = Int32.Parse(Console.ReadLine());


            int highNumber;
            int middleNumber;
            int lowNumber;

            if(firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                highNumber = firstNumber;
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                highNumber = secondNumber;
            }
            else
            {
                highNumber = thirdNumber;
            }

            if((firstNumber < secondNumber && firstNumber > thirdNumber) ||
                (firstNumber > secondNumber && firstNumber < thirdNumber))
            {
                middleNumber = firstNumber;
            }
            else if ((secondNumber < firstNumber && secondNumber > thirdNumber) ||
                (secondNumber > firstNumber && secondNumber < thirdNumber))
            {
                middleNumber = secondNumber;
            }
            else
            {
                middleNumber = thirdNumber;
            }

            if(firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                lowNumber = firstNumber;
            }
            else if (secondNumber < firstNumber && secondNumber < thirdNumber)
            {
                lowNumber = secondNumber;
            }
            else
            {
                lowNumber = thirdNumber;
            }

            firstNumber = highNumber;
            secondNumber = middleNumber;
            thirdNumber = lowNumber;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
        }
    }
}