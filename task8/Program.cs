using System;

namespace task888
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3 dene 6 reqemli eded verilib.
             * Her birinin 10 faizini tapib
             * neticeleri topla.
             * Alinan cavabin 10% tap.
             */

            double a = 585484;
            double b = 439894;
            double c = 390944;

            if ((!(a < 1000000 && a > 99999)) & (b < 1000000 && b > 99999) & (c < 1000000 && c > 99999))
            {
                Console.WriteLine("6 reqemli deyil");
                return;
            }
            


            
                double e = a * 10 / 100;
                double f = b * 10 / 100;
                double g = c * 10 / 100;
                double h = e + f + g;
                double l = h * 10 / 100;
                Console.WriteLine(l);
            

        }

        
    }
}
