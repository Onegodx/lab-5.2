// See https://aka.ms/new-console-template for more information
// Миньков Владимир 22исп2-1 12 вариант базовый уровень 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] arr = new double[n, n];
            Random r = new Random();
            double max = arr[0, 0];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = r.Next(0, 100) / 10.0;
                    Console.Write(arr[i, j] + " ");
                    if (i == j)
                    {
                        if (arr[i, j] >= max)
                        {
                            max = arr[i, j];
                            index = j;
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Максимальный элемент = {0}, находится в столбце {1}", max, index);
            double[] mas = new double[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = arr[i, index];
                Console.Write(mas[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
