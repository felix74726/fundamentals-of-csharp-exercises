using System;

namespace _14_QuickSortForArrayOfStrings
{
    class QuickSortForArrayOfStrings
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array: ");
            int length = Int32.Parse(Console.ReadLine());

            string[] array = new string[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = Console.ReadLine();
            }

            Sort(array);
            Console.WriteLine("Sorted array: ");
            foreach(string word in array)
            {
                Console.WriteLine(word);
            }
        }

        public static void Sort(string[] items)
        {
            QuickSort(items, 0, items.Length - 1);
        }

        public static void QuickSort(string[] array, int left, int right)
        {
            int i = left;
            int j = right;

            string x = array[(left + right) / 2];
            do
            {
                while(array[i].CompareTo(x) < 0)
                {
                    i++;
                }
                while(array[j].CompareTo(x) > 0)
                {
                    j--;
                }

                string temp;
                if(i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
            while(i <= j);

            if(left < j)
            {
                QuickSort(array, left, j);
            }
            if(i < right)
            {
                QuickSort(array, i, right);
            }
        }
    }
}
