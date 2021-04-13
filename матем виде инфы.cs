using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ведите чесло чесло х1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ведите чесло чесло х2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double x1x2 = (Math.Pow(x1, 2) + Math.Pow(x2, 2));
            Console.WriteLine("ответ:" + x1x2);
            Console.ReadKey();

            Console.WriteLine("видите число y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("видите число y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("видите число y3");
            double y3 = Convert.ToDouble(Console.ReadLine());
            double y1y2y3 = y1 * y2 + y1 * y3 +y2 * y3;
            Console.WriteLine("ответ" + y1y2y3);
            Console.ReadKey();

            Console.WriteLine("ведите чесло чесло z1");
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ведите чесло чесло a1");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ведите чесло чесло b1");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ведите чесло чесло d1");
            double d1 = Convert.ToDouble(Console.ReadLine());
            double l1 = a1 * b1 + (d1 * Math.Pow(a1, 2) / 2);
            Console.WriteLine("ответ" + l1);
            Console.ReadKey();


        }
    }
}
