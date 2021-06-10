using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ведите l");
            double l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ведите r1");
            double r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ведите r2");
            double r2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ведите a");
            double a = Convert.ToInt32(Console.ReadLine());
           
          if (a >1)
            {
                a = r1 / r2;
                double res = l * a;
                Console.WriteLine(+res);
              

            }
            Console.WriteLine("a="r);
            Console.ReadKey();

            
        }
    }
}
