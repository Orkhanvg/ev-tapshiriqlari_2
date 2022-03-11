using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3 dene 4 reqemli eded verilib. 
             * I ededin 1%-ni, 
             * II ededin 2% 
             * , III ededin 3 % tap.
             * 
                Neticeleri bir birinden cix.
            Alinan cavabin ustune III ededin 7% faizini gel
             */

            double a = 9354;
            double b = 9003;
            double c = 4046;

            if ((!(a <= 9999 && a > 999)) & (b <= 9999 && b > 999) & (c <= 9999 && c > 999))

            {
                Console.WriteLine("4 reqemli deyil");

                return;
            }

                double d = a * 1 / 100;

                double e = b * 2 / 100;

                double f = c * 3 / 100;



                double g = d - e - f;



                double h = c * 7 / 100;

                double l = g + h;
                {
                    Console.WriteLine(l);
                }
               
                    
            }


        }
    }

