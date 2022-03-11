using System;

namespace taask14
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 6 dene 6 reqemli eded verilib.
             * Evvel hamisini topla .
             * Sonra I ve III ededi bir birine yapishdir
             * ve bir eded al.
                I neticeden II neticeni cix.
            Alinan cavabin 10% tap.
            Neticenin uzerine V ve VI ededleri gel.
            Yekunda alinan cavabin 11% tap.
             */


            double a = 123456;
            double b = 123456;
            double c = 123456;
            double d = 123456;
            double e = 123456;
            double f = 123456;


            if ((!(a > 99999 && a < 1000000)) && (b > 99999 && b < 1000000) && (c > 99999 && c < 1000000) &&
                (d > 99999 && d < 1000000) && (e > 99999 && e < 1000000) && (f > 99999 && f < 1000000)) 
            {
                Console.WriteLine("6 reqemli deyil");
                return;
            }

            double g = a + b + c + d + e + f;
            double h = a * 1000000 + c;
           
            double l = (g - h) * 10 / 100;
            l = (l + e + f) * 11 / 100;
            Console.WriteLine(l);

            
             






        }
    }
}
