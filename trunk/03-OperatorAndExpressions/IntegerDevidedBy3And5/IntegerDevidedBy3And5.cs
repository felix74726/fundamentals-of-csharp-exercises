using System;

namespace IntegerDevidedBy3And5
{
    class IntegerDevidedBy3And5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Int32.Parse(Console.ReadLine());

            if ((number % 5 == 0) && (number % 7 == 0))
            {
                Console.WriteLine("The number {0} can be devided by 5 and 7 in the same time",
                    number);
            }
            else
            {
                Console.WriteLine("The number {0} can not be devided by 5 and 7 in the same time",
                    number);
            }
        }
    }
}
