using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0;
            Console.WriteLine("Write X number");
            int x = Int32.Parse(Console.ReadLine()!);
            do
            {
                n = Int32.Parse(Console.ReadLine()!);
                if (n % x == 0)
                    sum += n;
            } while (n > 0);
            Console.WriteLine($"Sum of multiples of x = {sum}");
        }
    }
}