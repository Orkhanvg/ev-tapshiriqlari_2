using System;

namespace task777
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2 dene 5 reqemli eded verilib.
             * Bu ededleri toplayib.
             * Alinan cavabin evveline ve axirina 5 artir.
             * Neticenin 5 % tap
             */


            double a = 54436;

            double b = 46463;

            if ((!(a>9999 && a<100000)) && (!(b > 9999 && b < 100000)))
            {
                Console.WriteLine("5 reqemli deyil");
            }

            double c = a + b;

            double d = (c + 500000) * 10 + 5;

            double e = d * 5 / 100;
            {
                Console.WriteLine(e);
            }



        }
    }
}
