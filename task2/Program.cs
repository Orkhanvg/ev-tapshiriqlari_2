using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 444;

            if (!(a > 99 && a < 1000))
            {
                Console.WriteLine("3 reqemli deyil");
                return;
            }
            int b = a * 1000 + a;

            Console.WriteLine(b);
        }
    }
}
