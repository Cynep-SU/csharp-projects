using System;

/* Это задача где надо вывести таблицу умножения.
 Ну и я немного поиздевался над консолью.
 */

namespace Мне_лень_придумывать_названия
{
    class Program
    {
        static void main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }
        }

        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\t1       2       3       4       5       6       7       8       9       10");
            Console.ResetColor();
            for (int i = 1; i < 11; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write($"{i}\t");
                Console.ResetColor();
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
            
        }
    }
}