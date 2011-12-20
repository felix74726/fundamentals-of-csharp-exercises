using System;
using System.Linq;

namespace _05_FindGreaterFromTwoIntegers
{
    class FindGreaterFromTwoIntegers
    {
        static void Main(string[] args)
        {
            Console.Write("First number: ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int secondNumber = Int32.Parse(Console.ReadLine());

            int greaterNumber = firstNumber - ((firstNumber - secondNumber) & 
                (firstNumber - secondNumber) >> 31);

            Console.WriteLine(greaterNumber);
        }
    }
}
