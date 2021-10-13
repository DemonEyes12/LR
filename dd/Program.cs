using System;

namespace ConsoleApp3bcv
{
    class Program
    {
        static void Main(string[] args)
        {
            Classdrob d1 = new Classdrob(2, 3);
            Classdrob d2 = new Classdrob(-2);
            Classdrob d3 = new Classdrob(2, 3, 4);
            Console.WriteLine(d1.ToDouble());
            Console.WriteLine((d1 * d3).ToDouble());
            Console.WriteLine((d1 * d2).Znak);
            Console.ReadKey();

        }

    }
}