using System;

namespace ages
{
    class Program
    {
        private static void Main(string[] args)
        {
            string s = Console.ReadLine();
            byte firstNumber = (byte) (Convert.ToInt16(s) / 10);
            byte secondNumber = Convert.ToByte(s[^1].ToString());
            switch (secondNumber)
            {
                case 1:
                    Console.WriteLine(firstNumber.ToString()[^1] != '1' ? "Вам {0} год." : "Вам {0} лет.", s);
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine(firstNumber.ToString()[^1] != '1' ? "Вам {0} года." : "Вам {0} лет.", s);
                    break;
                default:
                    Console.WriteLine("Вам {0} лет.", s);
                    break;
            }
        }
    }
}