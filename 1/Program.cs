using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Программа удвоения двумерного массива.\nВведите размерность массива:\nM = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            int[,] b = new int[m, n];  
            Console.WriteLine("Введите значения в массив A:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++) 
                {
                    a[i,j] = 2 * Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Вывод массива:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.Write("Для завершения работы программы нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
