using System;

namespace task666
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   4 reqemli eded verilib. 
             *   Bu ededin evvel 20%-ni , 
             *   sonra ise cavabin 10% tap.
             *   Alinan cavabin kvadratini tap.
             */

            double a = 6463;

            if (!(a > 999 && a < 10000))
            

            {
                Console.WriteLine("4 reqemli deyil");
                return;
            }

            double b = a * 20 / 100;

            double c = b * 10 / 100;

            double d = c * b;

            
                Console.WriteLine(d);

            



        }
    }
}
