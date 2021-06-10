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
            Console.WriteLine("Beg gJlny MaciBa");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(10, 20);
                Console.WriteLine(mas[i]);

            }
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                m = m + mas[i];
            }
            if (m % 2 == 0) 
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            Console.ReadKey();
        }
    }
}
