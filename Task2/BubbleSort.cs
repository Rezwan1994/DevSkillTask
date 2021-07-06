using System;
using System.Collections.Generic;

namespace Task2
{
    internal class BubbleSort<T> : IBubbleSort<int>
    {
        public void Sort(IList<int> itemsToSort, Func<int, int, int> comparer)
        {
            int temp;
            for (int j = 0; j <= itemsToSort.Count - 2; j++)
            {
                for (int i = 0; i <= itemsToSort.Count - 2; i++)
                {
                    if (itemsToSort[i] > itemsToSort[i + 1])
                    {
                        temp = itemsToSort[i + 1];
                        itemsToSort[i + 1] = itemsToSort[i];
                        itemsToSort[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int p in itemsToSort)
                Console.Write(p + " ");
            Console.Read();
        }
    }
}