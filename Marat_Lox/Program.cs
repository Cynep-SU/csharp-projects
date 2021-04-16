using System;
using System.Linq;

namespace Marat_Lox
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                if (a > c)

                    Console.WriteLine("" + a + " " + c + " " + b);

                else

                    Console.WriteLine("" + c + " " + a + " " + b);

            }else if (b > c)
            {
                if (c > a)

                    Console.WriteLine("" + b + " " + c + " " + a);

                else

                    Console.WriteLine("" + b + " " + a + " " + c);
                
            }else
                Console.WriteLine("" + c + " " + b + " " + a);
            

        }
    }
}