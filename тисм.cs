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
            int a = 1;
            for (int i = 3; i <= 24; i++) 
            {
                a = a * 2;

            }
            Console.WriteLine("a=" + a);
            Console.ReadKey();
        }
    }
}
