using System;

namespace AppLabaKostya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x3");
            double x3 = Convert.ToDouble(Console.ReadLine());

            double y, sumSmth = 0;
            int howMinus = 0;

            double x;
            for (x = x1; x <= x2; x += x3)
            {
                y = (Math.Sin(x) + 11) * x;
                if (y > a)
                    sumSmth += y;
                if (y < 0)
                    howMinus++;
            }
            Console.WriteLine(sumSmth + " " + howMinus);

            
            sumSmth = 0; 
            howMinus = 0;
            x = x1;
            while (x <= x2)
            {
                y = (Math.Sin(x) + 11) * x;
                x += x3;
                if (y > a)
                    sumSmth += y;
                if (y < 0)
                    howMinus++;
            }
            Console.WriteLine(sumSmth + " " + howMinus);
            
            sumSmth = 0; 
            howMinus = 0;
            x = x1;
            do
            {
                y = (Math.Sin(x) + 11) * x;
                x += x3;
                if (y > a)
                    sumSmth += y;
                if (y < 0)
                    howMinus++;
            } while (x <= x2);
            Console.WriteLine(sumSmth + " " + howMinus);
        }
    }
}