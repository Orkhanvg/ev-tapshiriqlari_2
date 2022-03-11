using System;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  4 dene 5 reqemli eded verilib.
             *  Her I ededin ustune III ededi gel .
             *  II ededin usutune IV eeddi gel.
             *  
                Sonra cavablari vur birbirine.
            Alinan neticeden III ededin 3%-ni cix.
             */

            double a = 34403;

            double b = 38902;

            double c = 42083;

            double d = 22819;



            if ((!(a > 9999 && a < 100000)) & (!(b >9999 && b < 100000)) & (!(c > 9999 && c < 100000)) & (!(d > 9999 && d < 100000)))


            {
                Console.WriteLine(" 5 reqemli deyil");
                return;
            }

            double e = a + c;
            double f = b + d;
            double g = e * f;
            double h = c * 3 / 100;
            double l = g - h;

            Console.WriteLine(l);



        }
    }
}
