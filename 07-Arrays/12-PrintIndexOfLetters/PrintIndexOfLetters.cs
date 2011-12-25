using System;

namespace _12_PrintIndexOfLetters
{
    class PrintIndexOfLetters
    {
        static void Main(string[] args)
        {
            char[] letters = new char[26];

            for (int index = 0; index < letters.Length; index++)
            {
                letters[index] = (char)(index + 65);
            }

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if(word.ToUpper()[i] == letters[j])
                    {
                        Console.WriteLine("The inddex of {0} in the array is: {1}",
                            word.ToUpper()[i], j);
                    }
                }
            }
        }
    }
}
