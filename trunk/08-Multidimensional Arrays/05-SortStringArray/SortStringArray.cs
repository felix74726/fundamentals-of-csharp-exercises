using System;
using System.Linq;

namespace _05_SortStringArray
{
    class SortStringArray
    {
        static void Main(string[] args)
        {
            string[] array = { "hi", "hello", "some", "text", "a", "interesting", "b" };

            SortStringArrayByLength(array);
        }

        static void SortStringArrayByLength(string[] array)
        {
            var arrayAnscending =
                from arr in array
                orderby arr.Length
                select arr;

            foreach (var arr in arrayAnscending)
            {
                Console.WriteLine(arr);
            }
        }
    }
}
