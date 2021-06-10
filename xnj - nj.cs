using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a =new int[n];
            Random r = new Random();
            for (int i=0;i <n; i++) 
            {
                a[i] = r.Next(10, 50);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
                { for(int j = 0; j < n; j++)
                {if (a[j] > a[ j + 1])
                    {
                        int p = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = p;

                    }
                           

                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + "");
            }
            Console.ReadKey();

        }

    }
}
