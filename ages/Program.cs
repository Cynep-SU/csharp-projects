using System;

namespace ages
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            byte firstNumber = 0;
            byte secondNumber;
            if (s.Length == 1)
                secondNumber = Convert.ToByte(s[0].ToString());
            else
            {
                firstNumber = Convert.ToByte(s[0].ToString());
                secondNumber = Convert.ToByte(s[1].ToString());
            }
            switch (secondNumber)
            {
                case 1:
                    Console.WriteLine(firstNumber != 1 ? "Вам {0} год." : "Вам {0} лет.", s);
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine(firstNumber != 1 ? "Вам {0} года." : "Вам {0} лет.", s);
                    break;
                default:
                    Console.WriteLine("Вам {0} лет.", s);
                    break;
            }
        }
    }
}