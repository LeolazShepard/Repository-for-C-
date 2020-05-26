using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
namespace Linq_Example18
{
    static class MyExtMeths
    {
        public static double Reciprocal(this double v)
        {
            return 1.0 / v;
        }
        public static string RevCase(this string str)
        {
            string temp = "";
            foreach (char ch in str)
            {
                if (Char.IsLower(ch))
                    temp += Char.ToUpper(ch, CultureInfo.CurrentCulture);
                else temp += Char.ToLower(ch, CultureInfo.CurrentCulture);
            } return temp;
        }
        public static double AbsDivideBy(this double n, double d)
        { return Math.Abs(n / d); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double val = 8.0;
            string str = "Alpha Beta Gamma";
            Console.WriteLine("Зворотнє значення {0} рiвне {1}",
            val, val.Reciprocal());
            Console.WriteLine(str + " після зміни регістру: "
            + str.RevCase());
            Console.WriteLine("Результат виклику метода val.AbsDivideBy(-2): " +
           val.AbsDivideBy(-2));
            Console.ReadKey();
        }
    }
}