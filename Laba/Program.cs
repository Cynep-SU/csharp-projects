using System;

namespace Laba
{
    class Program
    {
        
        static void Main(string[] args)
        {
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
        private float c, x1, _y, d, x2, x3;
        
        public Cycles(float c, float d, float x1, float x2, float x3)
        {
            this.c = c;
            this.d = d;
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
        }
        
        private float F(float x)
        {
            return (float) ((Math.Pow(x, x) - 10f * Math.Sin(x)) * x);
        }

        public string for_()
        {
            int numC = 0;
            int numD = 0;
            for (float x = x1; x <= x2; x += x3)
            {
                _y = F(x);
                if (_y < d)
                    numD++;
                if (_y > c)
                    numC++;
            }

            return $"Количество больше С = {numC}, меньше D = {numD}";
        }

        public string while_()
        {
            int numC = 0;
            int numD = 0;
            float x = x1;
            while (x <= x2)
            {
                _y = F(x);
                if (_y < d)
                    numD++;
                if (_y > c)
                    numC++;
                x += x3;
            }
            return $"Количество больше С = {numC}, меньше D = {numD}";
        }
        
        public string do_while_()
        {
            int numC = 0;
            int numD = 0;
            float x = x1;
            if (x1 > x2)
                return "Error, такого не должно быть.";
            do
            {
                _y = F(x);
                if (_y < d)
                    numD++;
                if (_y > c)
                    numC++;
                x += x3;
            } while (x <= x2);
            return $"Количество больше С = {numC}, меньше D = {numD}";
        }
    }
}

