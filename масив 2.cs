using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(2, 6);
                Console.Write(mas[i]);
            }
            int o4 = 0;
            int o5 = 0;
            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                if (mas[i] == 4)
                {
                    o4 = o4 + 1;
                }
                else if (mas[i] == 5)
                {
                    o5 = o5 + 1;
                }
            }
            Console.WriteLine(o4);
            Console.WriteLine(o5);
            Console.ReadKey(); 
        }
    }
}
