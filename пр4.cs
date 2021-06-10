using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            //Единицы длины пронумерованы следующим образом: 1 –дециметр, 2 – километр, 3 – метр, 4 – миллиметр, 5 – сантиметр.Данномер единицы длины и длина отрезка L в этих единицах(вещественноечисло).Вывести длину данного отрезка в метрах

            Console.WriteLine("вед L");
            {
                switch (l)
                {
                    case 1: return length * 10;
                    case 2: return length * 0.001;
                    case 3: return length; ;
                    case 4: return length * 1000;
                    case 5: return length * 100;
                    default: throw new ArgumentException("Данной величины не существует");
                }

                Console.WriteLine("7 метров = {0} см.", (6, 7));
            }
                Console.ReadKey();
            }
        
    }
}
