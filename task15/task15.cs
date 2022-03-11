using System;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             *7 dene eded verilib.Bunlardan 2 denesi 
             *3 reqemlidir.
             *2 denesi 4 reqemlidir.
             *2 denesi 5 reqemlidir.
             *1 denesi ise 6 reqemlidir.
                3 reqemli ededleri topla ,
            sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.

                Sonra neticenin axirina 7 reqemini artir.
            Sonra cavabin ustune gel 5 reqemli ededlerin cemini gel.

            Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
            Sonra alinan cavabin ustune gel 6 reqemli ededi gel
            Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
            Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.
            Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.
             */

            double a = 328;
            double b = 324;
            double c = 8594;
            double d = 4033;
            double e = 74844;
            double f = 43455;
            double g = 546555;
            if ((!(a > 99 && a < 1000)) & (b > 99 && b < 1000))
            {
                Console.WriteLine("3 reqemli deyil");
                return;


            }

            if ((!(c > 999 && c < 10000)) & (d > 999 && d < 10000))
            {
                Console.WriteLine("4 reqemli deyil");
                return;


            }

            if ((!(e > 9999 && e < 100000)) & (f > 9999 && f < 100000))
            {
                Console.WriteLine("5 reqemli deyil");
                return;


            }

            if ((!(g > 99999 && g < 1000000)))
            {
                Console.WriteLine("6 reqemli deyil");
                return;
            }

            double h = c * d + a + b;




            double l = a + b;
            double y = l + c * d;

            double j = y * 10 + 7;
            double r = j + e + f;
            double s = r - (a * b * 10) + 1 + g;

            double o = a + b + c + d;
            double v = s - o;
            double i = v * 18 / 100;
            double x = i * 3 / 100;
            double q = x * 1 / 100;
            double z = e + f + q;
            Console.WriteLine(z);
            { 




            }
        }
    }
}
