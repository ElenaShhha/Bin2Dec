using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bin2Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            string valueBin = "";
            do
            {
                valueBin = Input();
            }
            while (IsBinary(valueBin) == false);


            int n = valueBin.Length - 1;
            long result = 0;

            foreach (char c in valueBin)
            {
                long сharToInt = (long)c - '0';
                result = result + сharToInt * (long)(Math.Pow(2, n));
                n--;
            }
            System.Console.WriteLine("Число в десятичной степени - {0}", result);
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        static string Input()
        {
            System.Console.WriteLine("Введите число в двоичной системе счисления");
            return System.Console.ReadLine();
        }

        static bool IsBinary(string value)
        {
            foreach (char c in value)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
