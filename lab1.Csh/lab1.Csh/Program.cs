using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Csh
{
    class Program
    {

        static void Main(string[] args)
        {
            double A=0, B=0, C=0, d, x1, x2;

            func("A", out A);
            func("B", out B);
            func("C", out C);


            d = B * B - 4 * A * C;
            x1 = (B * (-1) + Math.Sqrt(d)) / (2 * A);
            x2 = (B * (-1) - Math.Sqrt(d)) / (2 * A);
            Console.WriteLine("");
            if (double.IsNaN(x1))
            {
                Console.WriteLine("Корней не существует!");
            }
            else
            {
                Console.WriteLine("Корень x1= " + x1.ToString());
                Console.WriteLine("Корень x2= " + x2.ToString());
            }
            Console.ReadKey();
        }

        static void func(String name, out double i)
        {
            bool ConvertResult = false; string str;
            i = 0;
            while (!ConvertResult)
            {
                Console.Write("Введите {0}: ", name);
                str = Console.ReadLine();
                ConvertResult = double.TryParse(str, out i);
                if (!ConvertResult) { Console.WriteLine("Вы ввели не число"); }
            }
        }
    }

    
}
