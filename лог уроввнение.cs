using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("видите 1 число");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("видите 2 число");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
            Console.ReadKey();
            Console.WriteLine("видите 1 число");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("видите 2 число");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("видите 3 число");
            double z = Convert.ToDouble(Console.ReadLine());
            if (x < (y + z) & (y < (x + z)) & (z < (x + y)))
            {
                Console.WriteLine("треугольник есть");
              
            }
            else
            {
                Console.WriteLine("треугольник не есть");
            }
            Console.ReadKey();

        



        }
    }
}
