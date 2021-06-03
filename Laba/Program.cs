using System;

namespace Laba
{
    class Program
    {
        
        static void Main(string[] args)
        {
            float y;
            Console.WriteLine("Введите C");
            float c = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите D");
            float d = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите x1");
            float x1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите x2");
            float x2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите x3");
            float x3 = Convert.ToSingle(Console.ReadLine());
            Cycles cycles = new Cycles(c, d, x1, x2, x3);
            Console.WriteLine(cycles.do_while_());
            Console.WriteLine(cycles.for_());
            Console.WriteLine(cycles.while_());
        }
    }

    public class Cycles
    {
        private float c, x1, y, d, x2, x3;
        
        public Cycles(float c_, float d_, float x1_, float x2_, float x3_)
        {
            c = c_;
            d = d_;
            x1 = x1_;
            x2 = x2_;
            x3 = x3_;
        }
        
        public float F(float x)
        {
            return x;
        }

        public string for_()
        {
            int numC = 0;
            int numD = 0;
            for (float x = x1; x <= x2; x += x3)
            {
                y = F(x);
                if (y < d)
                    numD += 1;
                if (y > c)
                    numC += 1;
            }

            return $"{numC}, {numD}";
        }

        public string while_()
        {
            int numC = 0;
            int numD = 0;
            float x = x1;
            while (x <= x2)
            {
                y = F(x);
                if (y < d)
                    numD += 1;
                if (y > c)
                    numC += 1;
                x += x3;
            }
            return $"{numC}, {numD}";
        }
        
        public string do_while_()
        {
            int numC = 0;
            int numD = 0;
            float x = x1;
            if (x1 > x2)
                return "Error";
            do
            {
                y = F(x);
                if (y < d)
                    numD += 1;
                if (y > c)
                    numC += 1;
                x += x3;
            } while (x <= x2);
            return $"{numC}, {numD}";
        }
    }
}

