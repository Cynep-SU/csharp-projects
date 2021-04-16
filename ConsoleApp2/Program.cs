using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
                Console.WriteLine("Невозможно построить треугольник");
            else
            {
                double maxSide = Math.Max(Math.Max(a, b), Math.Max(c, b));
                double kSide = Math.Min(Math.Max(a, b), Math.Max(c, b));
                double lSide = Math.Min(Math.Min(a, b), Math.Min(c, b));
                maxSide *= maxSide;
                kSide *= kSide;
                lSide *= lSide;
                if (maxSide == (kSide + lSide))
                    Console.WriteLine("Это прямоугольный треугольник");
                else if (maxSide < (kSide + lSide))
                    Console.WriteLine("Это остроугольный треугольник");
                else
                    Console.WriteLine("Это тупоугольный треугольник");
                Console.ReadKey();
            }
        }
    }
}