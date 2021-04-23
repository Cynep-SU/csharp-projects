using System;

namespace ages
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            byte first_number;
            byte second_number;
            if (s.Length == 1)
            {
                first_number = 0;
                second_number = Convert.ToByte(s[0].ToString());
            }
            else{
                first_number = Convert.ToByte(s[0].ToString());
                second_number = Convert.ToByte(s[1].ToString());
            }
            switch (second_number)
            {
                case 1:
                    if (first_number != 1)
                        Console.WriteLine("{0} год", s);
                    else
                        Console.WriteLine("{0} лет", s);
                    break;
                case 2:
                case 3:
                case 4:
                    if (first_number != 1)
                        Console.WriteLine("{0} года", s);
                    else
                        Console.WriteLine("{0} лет", s);
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 0:
                    Console.WriteLine("{0} лет", s);
                    break;
            }
        }
    }
}