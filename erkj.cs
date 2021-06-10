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
        {  //Обьявить массив длинной 15 элементов
           //Заполнить его случайными значениями от 15 до 35
           //Вывести на экран
           //Найти сумму квадратов элементов массива
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(15 , 35);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i] + " ");

            }
            Console.ReadKey();
        }
    }
}
