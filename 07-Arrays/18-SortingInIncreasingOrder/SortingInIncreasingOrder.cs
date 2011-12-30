using System;
using System.Collections.Generic;
using System.Linq;

namespace _18_SortingInIncreasingOrder
{
    class SortingInIncreasingOrder
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int number = Int32.Parse(Console.ReadLine());
                list.Add(number);
            }

            List<int> sortedList = SortIncresingOrder(list);
            PrintList(sortedList);
        }

        private static List<int> SortIncresingOrder(List<int> list)
        {
            List<int> currentList = new List<int>();
            List<int> biggestSequence = new List<int>();
            for (int i = 0; i < list.Count - 1; i++)
            {
                currentList.Add(list[i]);
                for (int j = i; j < list.Count; j++)
                {
                    if(currentList[currentList.Count - 1] < list[j])
                    {
                        currentList.Add(list[j]);
                    }
                }
                if(biggestSequence.Count < currentList.Count)
                {
                    biggestSequence = currentList.ToList<int>();
                }
                currentList.Clear();
            }
            return biggestSequence;
        }

        private static void PrintList(List<int> elements)
        {
            Console.Write("{");
            foreach (int element in elements)
            {
                Console.Write(" {0} ", element);
            }
            Console.WriteLine("}");
        }
    }
}
