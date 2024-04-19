using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Программа нахождения суммы положительных элементов массива.\nВведите размерность массива:\nM = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            int[,] b = new int[m, n];
            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = rnd.Next(-50,49);
                    if (b[i, j] > 0)
                        sum += b[i, j];
                }
            }
            Console.WriteLine("Вывод массива:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма положительных элементов:" + sum);
            Console.Write("Для завершения работы программы нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
