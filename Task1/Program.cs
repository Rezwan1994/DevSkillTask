using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyboard = new Keyboard();
            
            var a = keyboard['A'];
            a.Press();

            var c = keyboard['C'];
            c.Press();

            if (a.Pressed)
                Console.WriteLine("Test Passed");

            if (c.Pressed)
                Console.WriteLine("Test Passed");
        }
    }
}
