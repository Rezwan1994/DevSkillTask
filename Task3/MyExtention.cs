using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class MyExtention
    {
        public static void BubbleSort(this List<int> list)
        {

            int temp;
            for (int j = 0; j <= list.Count - 2; j++)
            {
                for (int i = 0; i <= list.Count - 2; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int p in list)
                Console.Write(p + " ");
            Console.Read();
        }
    }
}
