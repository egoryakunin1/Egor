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
            Console.WriteLine("ведите х");
            int x = Convert.ToInt32(Console.ReadLine());


            if (x % 10 == 7)
            {
                Console.WriteLine("цел");
            }
            else
            {
                Console.WriteLine("не цел");
            }

            Console.ReadKey();
        }
    }
}
