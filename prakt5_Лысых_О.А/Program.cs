using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace pr5_Лысых_О_А
{
    class Program
    {

        static void Main(string[] args)
        {



            try
            {
                double x = double.Parse(Console.ReadLine());
                if (x > 0.4 & x < 1)
                {

                    double a = checked(Math.Pow(Math.Log(x), 2));

                    Console.WriteLine(1 + a);
                }
                else if (x == 0)
                {
                    Console.WriteLine("x can not be 0");
                }

                else
                {
                    Console.WriteLine("x must be in between of [0,4;1]");
                }
            }


            catch (FormatException ex)
            {

                Console.WriteLine($"Исключение : {ex.Message}");
                Console.WriteLine($"Метод :{ex.TargetSite}");

            }


        }
    }
}
