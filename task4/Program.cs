using System;

namespace task444
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3 reqemli eded verilib.
             * Bu ededin axirina 7 artir.
             * Sonra cavabin 7% tap;
             */

            double a = 196;

            if (!(a > 99 && a < 1000))
            {
                Console.WriteLine( "3reqemli deyil" );

            }

            double b = a * 10 + 7;
            {
                Console.WriteLine(b);

            }

            double c = b * 7 / 100;

            Console.WriteLine(c);


        }

       

        
    }
}
