using System;

namespace task555
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4 reqemli eded verilib.
             * Bu ededin evveline 4 reqemi ,
             * axirina ise 44 ededini artir.
             * Alinan cavabin 44 % tap.
             
             
              
             
             */

            double a = 9876;
            if (!(a < 10000 && a > 999))
            {
                Console.WriteLine("4 reqemli deyil");
                return;
            }

            double b = 40000 + a;

            double c = b * 100 + 44;

            double d = c * 44 / 100;

            Console.WriteLine(d);

            









        }
    }
}
