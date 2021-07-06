using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {

        static void Main(string[] args)
        {
            var numbers = new List<int> { 4, 3, 38, 8, 2, 4, 9, 3, 4, 0, 3, 2, 7, 9 };
            numbers.BubbleSort();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
