using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            double p = 2 * (a + b);
            double d = Math.Sqrt(Math.Sqrt(a) + Math.Sqrt(b));
            Console.WriteLine("Периметр равен " + p);
            Console.WriteLine("Диагональ равна " + d);
            Console.ReadKey();
        }
    }
}
