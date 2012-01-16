using System;

namespace _03_PrintLastDigitWithWord
{
    class PrintLastDigitWithWord
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Int32.Parse(Console.ReadLine());

            Console.WriteLine(ReturnWord(number));
        }

        static string ReturnWord(int number)
        {
            string word = "";
            int lastDigit = number % 10;
            switch (lastDigit)
            {
                case 0:
                    word = "Zero";
                    break;
                case 1:
                    word = "One";
                    break;
                case 2:
                    word = "Two";
                    break;
                case 3:
                    word = "Three";
                    break;
                case 4:
                    word = "Four";
                    break;
                case 5:
                    word = "Five";
                        break;
                case 6:
                    word = "Six";
                    break;
                case 7:
                    word = "Seven";
                    break;
                case 8:
                    word = "Eight";
                    break;
                case 9:
                    word = "Nine";
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }

            return word;
        }
    }
}
