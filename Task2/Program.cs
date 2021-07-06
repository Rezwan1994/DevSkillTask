using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static int fillUpThisPartYourself(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            var numbers = new List<int> { 4, 3, 38, 8, 2, 4, 9, 3, 4, 0, 3, 2, 7, 9 };
            IBubbleSort<int> bubbleSort = new BubbleSort<int>();
            bubbleSort.Sort(numbers, fillUpThisPartYourself);

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
