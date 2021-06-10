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
            Console.WriteLine("вед числ n");
            int n = Convert.ToInt32(Console.ReadLine());
            int st = 0;
            int sl = 1;
            int i = 1;
             while(i<=n)
            {
                st = st + sl;
                sl = sl + 2;

            }
            Console.WriteLine(st);
            Console.ReadKey();

        }
    }
}
