using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("вед техзнч числ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0;
            if (x < 1000)
            {
                y = 3;y = 6;y = 9;
            }
            Console.WriteLine("вход" +x);
            Console.ReadKey();
        }
    }
}
