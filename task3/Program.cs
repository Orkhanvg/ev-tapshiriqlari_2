using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 5 reqemli eded verilib. 
             * Bu ededin evvel 18 % 
             * sonra ise 3 % tap.
              */


            double a = 83484;

            if (!(a > 9999 && a < 100000))
            {
                Console.WriteLine("5 reqemli deyil");
                return;
            }


            double b = a * 18 / 100;

            Console.WriteLine(b);

            double c = b * 3 / 100;
            Console.WriteLine(c);
            


                         }
}
    }

