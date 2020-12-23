using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x;
            double y;
            String Str;
            Console.Title = "Operator If";
            Console.Write("Введите значение х: ");
            Str = Console.ReadLine();
            x = Convert.ToDouble(Str);
            Console.Write("Введите значение b: ");
            Str = Console.ReadLine();
            b = Convert.ToDouble(Str);
            Console.Write("Введите значение a: ");
            Str = Console.ReadLine();
            a = Convert.ToDouble(Str);
            Console.Write("Введите значение c: ");
            Str = Console.ReadLine();
            c = Convert.ToDouble(Str);
            if (x < 0 && b != 0)
            {
                y = a * (int)Math.Pow(x, 2) + b * x + c;
            }
            else if (x > 0 && b == 0)
            {
                y = (x - a) / (x - c);
            }
            else
            {
                y = x / c;
            }          
            Console.Write("Результат равен: " + y);
            Console.WriteLine(Str);
            Console.Write("Для завершения нажмите Enter");
            Console.Read();
        }
    }
}


