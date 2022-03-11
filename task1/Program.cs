using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  4 reqemli eded verilib.
             *  Bu ededin eveline 7 reqemini ,
             *  axirinada 8 reqemini artir.
             *  Example1: 333= 73338

             */

            int a = 4943;


            if (!(a > 999 && a < 10000)) 
            {
                Console.WriteLine("4 reqemli deyil");
                return;
            }

            int b = (a + 70000) * 10 + 8;
            Console.WriteLine(b);



        }
    }
}
