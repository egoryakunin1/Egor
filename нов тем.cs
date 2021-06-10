using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("вед 1 чис");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("вед 3 чис");
            double  y= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("вед 2 чис");
            double z = Convert.ToDouble(Console.ReadLine());
            double c = 0;
            switch (z)
            {
                case 1: с = x + y; break;
                case 2: с = x + y; break;
                default: Console.WriteLine("ошиб выб операции"); break;

                
            }
            Console.ReadKey();
        }
    }
}
