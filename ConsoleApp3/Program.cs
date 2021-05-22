using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args) // Это решение с for
        {
            double x = Double.Parse(Console.ReadLine() ?? string.Empty);
            double sum = 0;
            double k = Double.Parse(Console.ReadLine() ?? string.Empty);
            for (int i = 0; i < k; i++)
            {
                sum += x;
                x *= 1.1;
            }
            Console.WriteLine(sum);
        }

        static void main_2(string[] args) // Это решение с while
        {
            double x = Double.Parse(Console.ReadLine() ?? string.Empty);
            double sum = 0;
            double k = Double.Parse(Console.ReadLine() ?? string.Empty);
            int i = 0;
            while (i < k)
            {
                i++;
                sum += x;
                x *= 1.1;
            }
            Console.WriteLine(sum);
        }
    }
}