using System;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {/*
            1 ci 10000
            2 ci 10000
            3 ci 10000
            4 ci 500
            5 ci 500

            12500003
        */




            /*5 dene eded verilib. 
             * Bunlardan 3 denesi 5 reqemli.
             * 2 denesi ise 3 reqemlidir. 
             * 5 reqemli ededlerin 5% tap 
             * ,neticeleri vur bir birine.
Sonra 3 reqemli ededlerin 3% tap ,neticeleri topla.
            Sonra yekunda alinan iki cavalarin her birinin 10%-ni tapib topla.



                       */


            double a = 10087500;
            double b = 10000;
            double c = 10000;
            double d = 500;
            double e = 500;

            if ((!(a>9999 && a< 100000)) &(b > 9999 && b < 100000) & (c > 9999 && c < 100000))
            {
                Console.WriteLine("5 reqemli deyil");
                return;
            }

            

            if ((!(d>99 && d<10000 )) &(e > 99 && e < 10000))
            {
                Console.WriteLine("3 reqemli deyil");
                return;
            }

            double f = a * 5 / 100;
            double g = b * 5 / 100;
            double h = c * 5 / 100;
            double l = f * g * h;
            double k = d * 3 / 100;
            double m = e * 3 / 100;
            double n = k + m;
         
            double o = l * 10 / 100;
            double q = n * 10 / 100;
            double p = o + q;
            {
                Console.WriteLine(p);
            }
            


        }
    }
}
