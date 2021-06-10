using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 Дано натуральное число. Определить: количество четных цифр в нем
            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            int c = 0;
            while (a != 0)
            {
                if ((a % 10) % 2 == 0)
                {
                    c++;
                }
                a = a / 10;
            }
            Console.WriteLine("Количество четных цыфр: {0}", c);
            Console.ReadKey();
        }
    }
}
