using System;

namespace task9
{
    class Program
    {
        private static void Main(string[] args)
        {
            /*
             * 3 dene 6 reqemli eded verilib.
             * Her birinin 10 faizini tapib
             * neticeleri topla. 
             * Alinan cavabin 10% tap
           */

            double a = 444883;
            double b = 87795;
            double c = 494882;

            if ((!(a > 99999 && a < 100000)) &
                (!(b > 99999 && b < 1000000)) &
                (!(c > 99999 && c < 1000000)))

            {
                Console.WriteLine("6 reqemli deyil");
                return;
            }

            double d = a * 10 / 100;
            double e = b * 10 / 100;
            double f = c * 10 / 100;
            double g = d + e + f;

            double h = g * 10 / 100;

            {
                Console.WriteLine(h);

            }
        }

    }
}

