using System;
using System.Linq;

namespace _04_FindNummbersThatRemindOfFive
{
    class FindNumbersThatRemindOfFive
    {
        static void Main(string[] args)
        {
            Console.Write("First number: ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int secondNumber = Int32.Parse(Console.ReadLine());

            int remindCounter = 0; ;

            if (firstNumber > secondNumber)
            {
                for (int i = secondNumber; i <= firstNumber; i++)
                {
                    if((i % 5) == 0)
                    {
                        remindCounter++;
                    }
                }
            }
            else if (firstNumber < secondNumber)
            {
                for (int i = firstNumber; i <= secondNumber; i++)
                {
                    if ((i % 5) == 0)
                    {
                        remindCounter++;
                    }
                }
            }
            else
            {
                if ((firstNumber % 5) == 0)
                {
                    remindCounter++;
                }
                else
                {
                    Console.WriteLine("The numbers are equal!");
                }
            }

            Console.WriteLine("The number that the reminder of the division by 5 is 0 are: {0}",
                remindCounter);
        }
    }
}
