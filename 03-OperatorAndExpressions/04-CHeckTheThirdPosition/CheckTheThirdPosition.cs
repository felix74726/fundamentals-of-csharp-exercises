using System;

namespace _04_CHeckTheThirdPosition
{
    class CheckTheThirdPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Int32.Parse(Console.ReadLine());

            int thirdDigit = (number / 100) % 10;

            if (thirdDigit == 7)
            {
                Console.WriteLine("The third digit of the number {0} is 7",
                    number);
            }
            else
            {
                Console.WriteLine("The third digit of the number {0} is not 7", number);
            }
        }
    }
}
