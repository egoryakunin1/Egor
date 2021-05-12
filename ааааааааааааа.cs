using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ведите x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ведите y");
            double y = Convert.ToDouble(Console.ReadLine());
            if ((x > 0) && (y > 0))
                Console.WriteLine("1 чет");
            else
            {
                if ((x > 0) && (y > 0))
                    Console.WriteLine("2чет");
                else

                {
                    if ((x > 0) && (y > 0))
                        Console.WriteLine("3чет");
                    else

                    {
                        if ((x > 0) && (y > 0))
                            Console.WriteLine("4чет");
                        else
                            Console.WriteLine("точ леж на оси ");
                    }
                    Console.ReadKey();

                }
            }
        }
    }
}
