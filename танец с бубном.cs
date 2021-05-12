using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ведите чесл");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 2:
                    {
                        Console.WriteLine("неуд");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("уд");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("хор");
                        break;
                    }
                case 5:

                    {
                        Console.WriteLine("отл");
                        break;
                    }
                default:{

                        Console.WriteLine("не то");
                        break;
                    }

                    

            } 
            Console.ReadKey();

        }
    }
}